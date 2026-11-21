using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000219 RID: 537
	public class ConfigDiceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C99 RID: 3225 RVA: 0x000A46DB File Offset: 0x000A28DB
		static ConfigDiceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDiceById.CreateStaticDefaultValue), new Action(ConfigDiceById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x000A46FC File Offset: 0x000A28FC
		public static void CreateStaticDefaultValue()
		{
			ConfigDiceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDiceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dango.db"),
				new ValueTuple<string, object>("文件", "t.团子.xlsx"),
				new ValueTuple<string, object>("表名", "Dice"),
				new ValueTuple<string, object>("语句", "select BinData from `Dice` where Id=?")
			});
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000A477B File Offset: 0x000A297B
		public static void ResetStaticDefaultValue()
		{
			ConfigDiceById.LogPair = null;
			ConfigDiceById.HandleId = 0;
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x000A4789 File Offset: 0x000A2989
		public static void Init()
		{
			ConfigDiceById.HandleId = ConfigCommon.InitDataStatement(ConfigDiceById.HandleId, "db_dango.db", "select BinData from `Dice` where Id=?");
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x000A47A4 File Offset: 0x000A29A4
		public static Dice? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDiceById.HandleId, ConfigDiceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Dice?(Dice.GetRootAsDice(configBuffer));
				}
			}
			ConfigDiceById.LogPair.Clear();
			ConfigDiceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDiceById.HandleId, 1, p0Id, ConfigDiceById.LogPair) || ConfigCommon.Step(ConfigDiceById.HandleId, true, ConfigDiceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDiceById.HandleId, ConfigDiceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDiceById.HandleId, 0, ConfigDiceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDiceById.HandleId, ConfigDiceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Dice rootAsDice = Dice.GetRootAsDice(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDiceById.HandleId, ConfigDiceById.LogPair);
			return new Dice?(rootAsDice);
		}

		// Token: 0x04000E93 RID: 3731
		private const string DB = "db_dango.db";

		// Token: 0x04000E94 RID: 3732
		private const string FILE = "t.团子.xlsx";

		// Token: 0x04000E95 RID: 3733
		private const string TABLE = "Dice";

		// Token: 0x04000E96 RID: 3734
		private const string COMMAND = "select BinData from `Dice` where Id=?";

		// Token: 0x04000E97 RID: 3735
		private const string KEY_PREFIX = "DiceById";

		// Token: 0x04000E98 RID: 3736
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E99 RID: 3737
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000207 RID: 519
	public class ConfigDiceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C2D RID: 3117 RVA: 0x0009E7A3 File Offset: 0x0009C9A3
		static ConfigDiceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDiceById.CreateStaticDefaultValue), new Action(ConfigDiceById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0009E7C4 File Offset: 0x0009C9C4
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

		// Token: 0x06000C2F RID: 3119 RVA: 0x0009E843 File Offset: 0x0009CA43
		public static void ResetStaticDefaultValue()
		{
			ConfigDiceById.LogPair = null;
			ConfigDiceById.HandleId = 0;
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0009E851 File Offset: 0x0009CA51
		public static void Init()
		{
			ConfigDiceById.HandleId = ConfigCommon.InitDataStatement(ConfigDiceById.HandleId, "db_dango.db", "select BinData from `Dice` where Id=?");
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0009E86C File Offset: 0x0009CA6C
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

		// Token: 0x04000E15 RID: 3605
		private const string DB = "db_dango.db";

		// Token: 0x04000E16 RID: 3606
		private const string FILE = "t.团子.xlsx";

		// Token: 0x04000E17 RID: 3607
		private const string TABLE = "Dice";

		// Token: 0x04000E18 RID: 3608
		private const string COMMAND = "select BinData from `Dice` where Id=?";

		// Token: 0x04000E19 RID: 3609
		private const string KEY_PREFIX = "DiceById";

		// Token: 0x04000E1A RID: 3610
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E1B RID: 3611
		private static int HandleId;
	}
}

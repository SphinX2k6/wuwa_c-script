using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F5 RID: 1269
	public class ConfigLordGymById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DC9 RID: 7625 RVA: 0x001019F7 File Offset: 0x000FFBF7
		static ConfigLordGymById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymById.CreateStaticDefaultValue), new Action(ConfigLordGymById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00101A18 File Offset: 0x000FFC18
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGym"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGym` where Id=?")
			});
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00101A97 File Offset: 0x000FFC97
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymById.LogPair = null;
			ConfigLordGymById.HandleId = 0;
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00101AA5 File Offset: 0x000FFCA5
		public static void Init()
		{
			ConfigLordGymById.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymById.HandleId, "db_lordgym.db", "select BinData from `LordGym` where Id=?");
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00101AC0 File Offset: 0x000FFCC0
		public static LordGym? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymById.HandleId, ConfigLordGymById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LordGym?(LordGym.GetRootAsLordGym(configBuffer));
				}
			}
			ConfigLordGymById.LogPair.Clear();
			ConfigLordGymById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLordGymById.HandleId, 1, p0Id, ConfigLordGymById.LogPair) || ConfigCommon.Step(ConfigLordGymById.HandleId, true, ConfigLordGymById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLordGymById.HandleId, ConfigLordGymById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymById.HandleId, 0, ConfigLordGymById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLordGymById.HandleId, ConfigLordGymById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LordGym rootAsLordGym = LordGym.GetRootAsLordGym(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLordGymById.HandleId, ConfigLordGymById.LogPair);
			return new LordGym?(rootAsLordGym);
		}

		// Token: 0x04002297 RID: 8855
		private const string DB = "db_lordgym.db";

		// Token: 0x04002298 RID: 8856
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x04002299 RID: 8857
		private const string TABLE = "LordGym";

		// Token: 0x0400229A RID: 8858
		private const string COMMAND = "select BinData from `LordGym` where Id=?";

		// Token: 0x0400229B RID: 8859
		private const string KEY_PREFIX = "LordGymById";

		// Token: 0x0400229C RID: 8860
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400229D RID: 8861
		private static int HandleId;
	}
}

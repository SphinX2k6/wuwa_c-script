using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000014 RID: 20
	public class ConfigAbyssInstByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000078 RID: 120 RVA: 0x0005CA50 File Offset: 0x0005AC50
		static ConfigAbyssInstByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssInstByInstId.CreateStaticDefaultValue), new Action(ConfigAbyssInstByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0005CA70 File Offset: 0x0005AC70
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssInstByInstId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssInstByInstId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabyss.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔副本.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssInst"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssInst` where InstId=?")
			});
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0005CAEF File Offset: 0x0005ACEF
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssInstByInstId.LogPair = null;
			ConfigAbyssInstByInstId.HandleId = 0;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0005CAFD File Offset: 0x0005ACFD
		public static void Init()
		{
			ConfigAbyssInstByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssInstByInstId.HandleId, "db_dangoabyss.db", "select BinData from `AbyssInst` where InstId=?");
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0005CB18 File Offset: 0x0005AD18
		public static AbyssInst? GetConfig(int p0InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssInstByInstId.HandleId, ConfigAbyssInstByInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssInstByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssInst?(AbyssInst.GetRootAsAbyssInst(configBuffer));
				}
			}
			ConfigAbyssInstByInstId.LogPair.Clear();
			ConfigAbyssInstByInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p0InstId));
			if (!ConfigCommon.BindInt(ConfigAbyssInstByInstId.HandleId, 1, p0InstId, ConfigAbyssInstByInstId.LogPair) || ConfigCommon.Step(ConfigAbyssInstByInstId.HandleId, true, ConfigAbyssInstByInstId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssInstByInstId.HandleId, ConfigAbyssInstByInstId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssInstByInstId.HandleId, 0, ConfigAbyssInstByInstId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssInstByInstId.HandleId, ConfigAbyssInstByInstId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssInst rootAsAbyssInst = AbyssInst.GetRootAsAbyssInst(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssInstByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssInstByInstId.HandleId, ConfigAbyssInstByInstId.LogPair);
			return new AbyssInst?(rootAsAbyssInst);
		}

		// Token: 0x04000070 RID: 112
		private const string DB = "db_dangoabyss.db";

		// Token: 0x04000071 RID: 113
		private const string FILE = "s.深渊爬塔副本.xlsx";

		// Token: 0x04000072 RID: 114
		private const string TABLE = "AbyssInst";

		// Token: 0x04000073 RID: 115
		private const string COMMAND = "select BinData from `AbyssInst` where InstId=?";

		// Token: 0x04000074 RID: 116
		private const string KEY_PREFIX = "AbyssInstByInstId";

		// Token: 0x04000075 RID: 117
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000076 RID: 118
		private static int HandleId;
	}
}

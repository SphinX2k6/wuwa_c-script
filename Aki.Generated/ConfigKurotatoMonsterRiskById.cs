using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A6 RID: 1190
	public class ConfigKurotatoMonsterRiskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BEF RID: 7151 RVA: 0x000F74D8 File Offset: 0x000F56D8
		static ConfigKurotatoMonsterRiskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterRiskById.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterRiskById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x000F74F8 File Offset: 0x000F56F8
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoMonsterRiskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoMonsterRiskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoMonsterRisk"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoMonsterRisk` where Id=?")
			});
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x000F7577 File Offset: 0x000F5777
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterRiskById.LogPair = null;
			ConfigKurotatoMonsterRiskById.HandleId = 0;
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x000F7585 File Offset: 0x000F5785
		public static void Init()
		{
			ConfigKurotatoMonsterRiskById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterRiskById.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonsterRisk` where Id=?");
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x000F75A0 File Offset: 0x000F57A0
		public static KurotatoMonsterRisk? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoMonsterRiskById.HandleId, ConfigKurotatoMonsterRiskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterRiskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoMonsterRisk?(KurotatoMonsterRisk.GetRootAsKurotatoMonsterRisk(configBuffer));
				}
			}
			ConfigKurotatoMonsterRiskById.LogPair.Clear();
			ConfigKurotatoMonsterRiskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoMonsterRiskById.HandleId, 1, p0Id, ConfigKurotatoMonsterRiskById.LogPair) || ConfigCommon.Step(ConfigKurotatoMonsterRiskById.HandleId, true, ConfigKurotatoMonsterRiskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterRiskById.HandleId, ConfigKurotatoMonsterRiskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoMonsterRiskById.HandleId, 0, ConfigKurotatoMonsterRiskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterRiskById.HandleId, ConfigKurotatoMonsterRiskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoMonsterRisk rootAsKurotatoMonsterRisk = KurotatoMonsterRisk.GetRootAsKurotatoMonsterRisk(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterRiskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoMonsterRiskById.HandleId, ConfigKurotatoMonsterRiskById.LogPair);
			return new KurotatoMonsterRisk?(rootAsKurotatoMonsterRisk);
		}

		// Token: 0x0400206E RID: 8302
		private const string DB = "db_kurotato.db";

		// Token: 0x0400206F RID: 8303
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x04002070 RID: 8304
		private const string TABLE = "KurotatoMonsterRisk";

		// Token: 0x04002071 RID: 8305
		private const string COMMAND = "select BinData from `KurotatoMonsterRisk` where Id=?";

		// Token: 0x04002072 RID: 8306
		private const string KEY_PREFIX = "KurotatoMonsterRiskById";

		// Token: 0x04002073 RID: 8307
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002074 RID: 8308
		private static int HandleId;
	}
}

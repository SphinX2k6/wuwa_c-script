using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004BC RID: 1212
	public class ConfigKurotatoMonsterRiskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C73 RID: 7283 RVA: 0x000FDC2C File Offset: 0x000FBE2C
		static ConfigKurotatoMonsterRiskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterRiskById.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterRiskById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x000FDC4C File Offset: 0x000FBE4C
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

		// Token: 0x06001C75 RID: 7285 RVA: 0x000FDCCB File Offset: 0x000FBECB
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterRiskById.LogPair = null;
			ConfigKurotatoMonsterRiskById.HandleId = 0;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x000FDCD9 File Offset: 0x000FBED9
		public static void Init()
		{
			ConfigKurotatoMonsterRiskById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterRiskById.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonsterRisk` where Id=?");
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x000FDCF4 File Offset: 0x000FBEF4
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

		// Token: 0x04002108 RID: 8456
		private const string DB = "db_kurotato.db";

		// Token: 0x04002109 RID: 8457
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x0400210A RID: 8458
		private const string TABLE = "KurotatoMonsterRisk";

		// Token: 0x0400210B RID: 8459
		private const string COMMAND = "select BinData from `KurotatoMonsterRisk` where Id=?";

		// Token: 0x0400210C RID: 8460
		private const string KEY_PREFIX = "KurotatoMonsterRiskById";

		// Token: 0x0400210D RID: 8461
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400210E RID: 8462
		private static int HandleId;
	}
}

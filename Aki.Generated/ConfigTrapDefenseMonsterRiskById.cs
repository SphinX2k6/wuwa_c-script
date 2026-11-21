using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B0E RID: 2830
	public class ConfigTrapDefenseMonsterRiskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004268 RID: 17000 RVA: 0x001D43D3 File Offset: 0x001D25D3
		static ConfigTrapDefenseMonsterRiskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterRiskById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterRiskById.ResetStaticDefaultValue));
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x001D43F4 File Offset: 0x001D25F4
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterRiskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMonsterRiskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMonsterRisk"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMonsterRisk` where Id=?")
			});
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x001D4473 File Offset: 0x001D2673
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterRiskById.LogPair = null;
			ConfigTrapDefenseMonsterRiskById.HandleId = 0;
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x001D4481 File Offset: 0x001D2681
		public static void Init()
		{
			ConfigTrapDefenseMonsterRiskById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterRiskById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterRisk` where Id=?");
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x001D449C File Offset: 0x001D269C
		public static TrapDefenseMonsterRisk? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMonsterRiskById.HandleId, ConfigTrapDefenseMonsterRiskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterRiskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseMonsterRisk?(TrapDefenseMonsterRisk.GetRootAsTrapDefenseMonsterRisk(configBuffer));
				}
			}
			ConfigTrapDefenseMonsterRiskById.LogPair.Clear();
			ConfigTrapDefenseMonsterRiskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseMonsterRiskById.HandleId, 1, p0Id, ConfigTrapDefenseMonsterRiskById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseMonsterRiskById.HandleId, true, ConfigTrapDefenseMonsterRiskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterRiskById.HandleId, ConfigTrapDefenseMonsterRiskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMonsterRiskById.HandleId, 0, ConfigTrapDefenseMonsterRiskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterRiskById.HandleId, ConfigTrapDefenseMonsterRiskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseMonsterRisk rootAsTrapDefenseMonsterRisk = TrapDefenseMonsterRisk.GetRootAsTrapDefenseMonsterRisk(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterRiskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMonsterRiskById.HandleId, ConfigTrapDefenseMonsterRiskById.LogPair);
			return new TrapDefenseMonsterRisk?(rootAsTrapDefenseMonsterRisk);
		}

		// Token: 0x04004D48 RID: 19784
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D49 RID: 19785
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004D4A RID: 19786
		private const string TABLE = "TrapDefenseMonsterRisk";

		// Token: 0x04004D4B RID: 19787
		private const string COMMAND = "select BinData from `TrapDefenseMonsterRisk` where Id=?";

		// Token: 0x04004D4C RID: 19788
		private const string KEY_PREFIX = "TrapDefenseMonsterRiskById";

		// Token: 0x04004D4D RID: 19789
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D4E RID: 19790
		private static int HandleId;
	}
}

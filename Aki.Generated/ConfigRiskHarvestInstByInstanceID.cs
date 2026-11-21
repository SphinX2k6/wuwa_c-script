using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000828 RID: 2088
	public class ConfigRiskHarvestInstByInstanceID : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003102 RID: 12546 RVA: 0x00171BD0 File Offset: 0x0016FDD0
		static ConfigRiskHarvestInstByInstanceID()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestInstByInstanceID.CreateStaticDefaultValue), new Action(ConfigRiskHarvestInstByInstanceID.ResetStaticDefaultValue));
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x00171BF0 File Offset: 0x0016FDF0
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestInstByInstanceID.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestInstByInstanceID.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestInst"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestInst` where InstanceID = ?")
			});
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x00171C6F File Offset: 0x0016FE6F
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestInstByInstanceID.LogPair = null;
			ConfigRiskHarvestInstByInstanceID.HandleId = 0;
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x00171C7D File Offset: 0x0016FE7D
		public static void Init()
		{
			ConfigRiskHarvestInstByInstanceID.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestInstByInstanceID.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestInst` where InstanceID = ?");
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x00171C98 File Offset: 0x0016FE98
		public static RiskHarvestInst? GetConfig(int p0InstanceID, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestInstByInstanceID.HandleId, ConfigRiskHarvestInstByInstanceID.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestInstByInstanceID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceID);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RiskHarvestInst?(RiskHarvestInst.GetRootAsRiskHarvestInst(configBuffer));
				}
			}
			ConfigRiskHarvestInstByInstanceID.LogPair.Clear();
			ConfigRiskHarvestInstByInstanceID.LogPair.Add(new ValueTuple<string, object>("InstanceID", p0InstanceID));
			if (!ConfigCommon.BindInt(ConfigRiskHarvestInstByInstanceID.HandleId, 1, p0InstanceID, ConfigRiskHarvestInstByInstanceID.LogPair) || ConfigCommon.Step(ConfigRiskHarvestInstByInstanceID.HandleId, true, ConfigRiskHarvestInstByInstanceID.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRiskHarvestInstByInstanceID.HandleId, ConfigRiskHarvestInstByInstanceID.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestInstByInstanceID.HandleId, 0, ConfigRiskHarvestInstByInstanceID.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRiskHarvestInstByInstanceID.HandleId, ConfigRiskHarvestInstByInstanceID.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RiskHarvestInst rootAsRiskHarvestInst = RiskHarvestInst.GetRootAsRiskHarvestInst(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestInstByInstanceID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceID);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRiskHarvestInstByInstanceID.HandleId, ConfigRiskHarvestInstByInstanceID.LogPair);
			return new RiskHarvestInst?(rootAsRiskHarvestInst);
		}

		// Token: 0x040038FE RID: 14590
		private const string DB = "db_riskharvest.db";

		// Token: 0x040038FF RID: 14591
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x04003900 RID: 14592
		private const string TABLE = "RiskHarvestInst";

		// Token: 0x04003901 RID: 14593
		private const string COMMAND = "select BinData from `RiskHarvestInst` where InstanceID = ?";

		// Token: 0x04003902 RID: 14594
		private const string KEY_PREFIX = "RiskHarvestInstByInstanceID";

		// Token: 0x04003903 RID: 14595
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003904 RID: 14596
		private static int HandleId;
	}
}

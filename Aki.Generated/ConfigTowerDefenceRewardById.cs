using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD3 RID: 2771
	public class ConfigTowerDefenceRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004106 RID: 16646 RVA: 0x001CC607 File Offset: 0x001CA807
		static ConfigTowerDefenceRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceRewardById.CreateStaticDefaultValue), new Action(ConfigTowerDefenceRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x001CC628 File Offset: 0x001CA828
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefenceRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefenceRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefenceReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefenceReward` where Id = ?")
			});
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x001CC6A7 File Offset: 0x001CA8A7
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceRewardById.LogPair = null;
			ConfigTowerDefenceRewardById.HandleId = 0;
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x001CC6B5 File Offset: 0x001CA8B5
		public static void Init()
		{
			ConfigTowerDefenceRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceRewardById.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceReward` where Id = ?");
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x001CC6D0 File Offset: 0x001CA8D0
		public static TowerDefenceReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefenceRewardById.HandleId, ConfigTowerDefenceRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefenceRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerDefenceReward?(TowerDefenceReward.GetRootAsTowerDefenceReward(configBuffer));
				}
			}
			ConfigTowerDefenceRewardById.LogPair.Clear();
			ConfigTowerDefenceRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTowerDefenceRewardById.HandleId, 1, p0Id, ConfigTowerDefenceRewardById.LogPair) || ConfigCommon.Step(ConfigTowerDefenceRewardById.HandleId, true, ConfigTowerDefenceRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerDefenceRewardById.HandleId, ConfigTowerDefenceRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefenceRewardById.HandleId, 0, ConfigTowerDefenceRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerDefenceRewardById.HandleId, ConfigTowerDefenceRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerDefenceReward rootAsTowerDefenceReward = TowerDefenceReward.GetRootAsTowerDefenceReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefenceRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerDefenceRewardById.HandleId, ConfigTowerDefenceRewardById.LogPair);
			return new TowerDefenceReward?(rootAsTowerDefenceReward);
		}

		// Token: 0x04004BAB RID: 19371
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004BAC RID: 19372
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004BAD RID: 19373
		private const string TABLE = "TowerDefenceReward";

		// Token: 0x04004BAE RID: 19374
		private const string COMMAND = "select BinData from `TowerDefenceReward` where Id = ?";

		// Token: 0x04004BAF RID: 19375
		private const string KEY_PREFIX = "TowerDefenceRewardById";

		// Token: 0x04004BB0 RID: 19376
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BB1 RID: 19377
		private static int HandleId;
	}
}

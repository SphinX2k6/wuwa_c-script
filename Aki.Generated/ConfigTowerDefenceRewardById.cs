using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009FE RID: 2558
	public class ConfigTowerDefenceRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C08 RID: 15368 RVA: 0x001AD273 File Offset: 0x001AB473
		static ConfigTowerDefenceRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceRewardById.CreateStaticDefaultValue), new Action(ConfigTowerDefenceRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x001AD294 File Offset: 0x001AB494
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

		// Token: 0x06003C0A RID: 15370 RVA: 0x001AD313 File Offset: 0x001AB513
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceRewardById.LogPair = null;
			ConfigTowerDefenceRewardById.HandleId = 0;
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x001AD321 File Offset: 0x001AB521
		public static void Init()
		{
			ConfigTowerDefenceRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceRewardById.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceReward` where Id = ?");
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x001AD33C File Offset: 0x001AB53C
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

		// Token: 0x040045D8 RID: 17880
		private const string DB = "db_towerdefense.db";

		// Token: 0x040045D9 RID: 17881
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x040045DA RID: 17882
		private const string TABLE = "TowerDefenceReward";

		// Token: 0x040045DB RID: 17883
		private const string COMMAND = "select BinData from `TowerDefenceReward` where Id = ?";

		// Token: 0x040045DC RID: 17884
		private const string KEY_PREFIX = "TowerDefenceRewardById";

		// Token: 0x040045DD RID: 17885
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045DE RID: 17886
		private static int HandleId;
	}
}

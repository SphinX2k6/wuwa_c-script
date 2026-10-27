using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F5 RID: 2549
	public class ConfigTowerDefenceInstanceByInstanceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BD2 RID: 15314 RVA: 0x001AC0CC File Offset: 0x001AA2CC
		static ConfigTowerDefenceInstanceByInstanceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceInstanceByInstanceId.CreateStaticDefaultValue), new Action(ConfigTowerDefenceInstanceByInstanceId.ResetStaticDefaultValue));
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x001AC0EC File Offset: 0x001AA2EC
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefenceInstanceByInstanceId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefenceInstanceByInstanceId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefenceInstance"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefenceInstance` where InstanceId = ?")
			});
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x001AC16B File Offset: 0x001AA36B
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceInstanceByInstanceId.LogPair = null;
			ConfigTowerDefenceInstanceByInstanceId.HandleId = 0;
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x001AC179 File Offset: 0x001AA379
		public static void Init()
		{
			ConfigTowerDefenceInstanceByInstanceId.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceInstanceByInstanceId.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceInstance` where InstanceId = ?");
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x001AC194 File Offset: 0x001AA394
		public static TowerDefenceInstance? GetConfig(int p0InstanceId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefenceInstanceByInstanceId.HandleId, ConfigTowerDefenceInstanceByInstanceId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefenceInstanceByInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerDefenceInstance?(TowerDefenceInstance.GetRootAsTowerDefenceInstance(configBuffer));
				}
			}
			ConfigTowerDefenceInstanceByInstanceId.LogPair.Clear();
			ConfigTowerDefenceInstanceByInstanceId.LogPair.Add(new ValueTuple<string, object>("InstanceId", p0InstanceId));
			if (!ConfigCommon.BindInt(ConfigTowerDefenceInstanceByInstanceId.HandleId, 1, p0InstanceId, ConfigTowerDefenceInstanceByInstanceId.LogPair) || ConfigCommon.Step(ConfigTowerDefenceInstanceByInstanceId.HandleId, true, ConfigTowerDefenceInstanceByInstanceId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerDefenceInstanceByInstanceId.HandleId, ConfigTowerDefenceInstanceByInstanceId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefenceInstanceByInstanceId.HandleId, 0, ConfigTowerDefenceInstanceByInstanceId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerDefenceInstanceByInstanceId.HandleId, ConfigTowerDefenceInstanceByInstanceId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerDefenceInstance rootAsTowerDefenceInstance = TowerDefenceInstance.GetRootAsTowerDefenceInstance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefenceInstanceByInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerDefenceInstanceByInstanceId.HandleId, ConfigTowerDefenceInstanceByInstanceId.LogPair);
			return new TowerDefenceInstance?(rootAsTowerDefenceInstance);
		}

		// Token: 0x04004599 RID: 17817
		private const string DB = "db_towerdefense.db";

		// Token: 0x0400459A RID: 17818
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x0400459B RID: 17819
		private const string TABLE = "TowerDefenceInstance";

		// Token: 0x0400459C RID: 17820
		private const string COMMAND = "select BinData from `TowerDefenceInstance` where InstanceId = ?";

		// Token: 0x0400459D RID: 17821
		private const string KEY_PREFIX = "TowerDefenceInstanceByInstanceId";

		// Token: 0x0400459E RID: 17822
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400459F RID: 17823
		private static int HandleId;
	}
}

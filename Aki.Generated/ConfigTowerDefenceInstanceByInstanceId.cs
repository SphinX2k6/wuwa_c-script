using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ACA RID: 2762
	public class ConfigTowerDefenceInstanceByInstanceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040D0 RID: 16592 RVA: 0x001CB460 File Offset: 0x001C9660
		static ConfigTowerDefenceInstanceByInstanceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceInstanceByInstanceId.CreateStaticDefaultValue), new Action(ConfigTowerDefenceInstanceByInstanceId.ResetStaticDefaultValue));
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x001CB480 File Offset: 0x001C9680
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

		// Token: 0x060040D2 RID: 16594 RVA: 0x001CB4FF File Offset: 0x001C96FF
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceInstanceByInstanceId.LogPair = null;
			ConfigTowerDefenceInstanceByInstanceId.HandleId = 0;
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x001CB50D File Offset: 0x001C970D
		public static void Init()
		{
			ConfigTowerDefenceInstanceByInstanceId.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceInstanceByInstanceId.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceInstance` where InstanceId = ?");
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x001CB528 File Offset: 0x001C9728
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

		// Token: 0x04004B6C RID: 19308
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004B6D RID: 19309
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004B6E RID: 19310
		private const string TABLE = "TowerDefenceInstance";

		// Token: 0x04004B6F RID: 19311
		private const string COMMAND = "select BinData from `TowerDefenceInstance` where InstanceId = ?";

		// Token: 0x04004B70 RID: 19312
		private const string KEY_PREFIX = "TowerDefenceInstanceByInstanceId";

		// Token: 0x04004B71 RID: 19313
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B72 RID: 19314
		private static int HandleId;
	}
}

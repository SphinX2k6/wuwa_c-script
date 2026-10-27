using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F7 RID: 2551
	public class ConfigTowerDefenceMapMarkByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BDE RID: 15326 RVA: 0x001AC4A7 File Offset: 0x001AA6A7
		static ConfigTowerDefenceMapMarkByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceMapMarkByActivityId.CreateStaticDefaultValue), new Action(ConfigTowerDefenceMapMarkByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x001AC4C8 File Offset: 0x001AA6C8
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefenceMapMarkByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefenceMapMarkByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefenceMapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefenceMapMark` where ActivityId = ?")
			});
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x001AC547 File Offset: 0x001AA747
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceMapMarkByActivityId.LogPair = null;
			ConfigTowerDefenceMapMarkByActivityId.HandleId = 0;
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x001AC555 File Offset: 0x001AA755
		public static void Init()
		{
			ConfigTowerDefenceMapMarkByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceMapMarkByActivityId.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceMapMark` where ActivityId = ?");
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x001AC570 File Offset: 0x001AA770
		public static TowerDefenceMapMark? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefenceMapMarkByActivityId.HandleId, ConfigTowerDefenceMapMarkByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefenceMapMarkByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerDefenceMapMark?(TowerDefenceMapMark.GetRootAsTowerDefenceMapMark(configBuffer));
				}
			}
			ConfigTowerDefenceMapMarkByActivityId.LogPair.Clear();
			ConfigTowerDefenceMapMarkByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTowerDefenceMapMarkByActivityId.HandleId, 1, p0ActivityId, ConfigTowerDefenceMapMarkByActivityId.LogPair) || ConfigCommon.Step(ConfigTowerDefenceMapMarkByActivityId.HandleId, true, ConfigTowerDefenceMapMarkByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerDefenceMapMarkByActivityId.HandleId, ConfigTowerDefenceMapMarkByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefenceMapMarkByActivityId.HandleId, 0, ConfigTowerDefenceMapMarkByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerDefenceMapMarkByActivityId.HandleId, ConfigTowerDefenceMapMarkByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerDefenceMapMark rootAsTowerDefenceMapMark = TowerDefenceMapMark.GetRootAsTowerDefenceMapMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefenceMapMarkByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerDefenceMapMarkByActivityId.HandleId, ConfigTowerDefenceMapMarkByActivityId.LogPair);
			return new TowerDefenceMapMark?(rootAsTowerDefenceMapMark);
		}

		// Token: 0x040045A7 RID: 17831
		private const string DB = "db_towerdefense.db";

		// Token: 0x040045A8 RID: 17832
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x040045A9 RID: 17833
		private const string TABLE = "TowerDefenceMapMark";

		// Token: 0x040045AA RID: 17834
		private const string COMMAND = "select BinData from `TowerDefenceMapMark` where ActivityId = ?";

		// Token: 0x040045AB RID: 17835
		private const string KEY_PREFIX = "TowerDefenceMapMarkByActivityId";

		// Token: 0x040045AC RID: 17836
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045AD RID: 17837
		private static int HandleId;
	}
}

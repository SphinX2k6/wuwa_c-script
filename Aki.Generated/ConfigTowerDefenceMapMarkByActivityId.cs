using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ACC RID: 2764
	public class ConfigTowerDefenceMapMarkByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040DC RID: 16604 RVA: 0x001CB83B File Offset: 0x001C9A3B
		static ConfigTowerDefenceMapMarkByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceMapMarkByActivityId.CreateStaticDefaultValue), new Action(ConfigTowerDefenceMapMarkByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x001CB85C File Offset: 0x001C9A5C
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

		// Token: 0x060040DE RID: 16606 RVA: 0x001CB8DB File Offset: 0x001C9ADB
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceMapMarkByActivityId.LogPair = null;
			ConfigTowerDefenceMapMarkByActivityId.HandleId = 0;
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x001CB8E9 File Offset: 0x001C9AE9
		public static void Init()
		{
			ConfigTowerDefenceMapMarkByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceMapMarkByActivityId.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceMapMark` where ActivityId = ?");
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x001CB904 File Offset: 0x001C9B04
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

		// Token: 0x04004B7A RID: 19322
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004B7B RID: 19323
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004B7C RID: 19324
		private const string TABLE = "TowerDefenceMapMark";

		// Token: 0x04004B7D RID: 19325
		private const string COMMAND = "select BinData from `TowerDefenceMapMark` where ActivityId = ?";

		// Token: 0x04004B7E RID: 19326
		private const string KEY_PREFIX = "TowerDefenceMapMarkByActivityId";

		// Token: 0x04004B7F RID: 19327
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B80 RID: 19328
		private static int HandleId;
	}
}

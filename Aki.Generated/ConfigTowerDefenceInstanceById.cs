using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F4 RID: 2548
	public class ConfigTowerDefenceInstanceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BCC RID: 15308 RVA: 0x001ABE83 File Offset: 0x001AA083
		static ConfigTowerDefenceInstanceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceInstanceById.CreateStaticDefaultValue), new Action(ConfigTowerDefenceInstanceById.ResetStaticDefaultValue));
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x001ABEA4 File Offset: 0x001AA0A4
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefenceInstanceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefenceInstanceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefenceInstance"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefenceInstance` where Id = ?")
			});
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x001ABF23 File Offset: 0x001AA123
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceInstanceById.LogPair = null;
			ConfigTowerDefenceInstanceById.HandleId = 0;
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x001ABF31 File Offset: 0x001AA131
		public static void Init()
		{
			ConfigTowerDefenceInstanceById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceInstanceById.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceInstance` where Id = ?");
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x001ABF4C File Offset: 0x001AA14C
		public static TowerDefenceInstance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefenceInstanceById.HandleId, ConfigTowerDefenceInstanceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefenceInstanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerDefenceInstance?(TowerDefenceInstance.GetRootAsTowerDefenceInstance(configBuffer));
				}
			}
			ConfigTowerDefenceInstanceById.LogPair.Clear();
			ConfigTowerDefenceInstanceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTowerDefenceInstanceById.HandleId, 1, p0Id, ConfigTowerDefenceInstanceById.LogPair) || ConfigCommon.Step(ConfigTowerDefenceInstanceById.HandleId, true, ConfigTowerDefenceInstanceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerDefenceInstanceById.HandleId, ConfigTowerDefenceInstanceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefenceInstanceById.HandleId, 0, ConfigTowerDefenceInstanceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerDefenceInstanceById.HandleId, ConfigTowerDefenceInstanceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerDefenceInstance rootAsTowerDefenceInstance = TowerDefenceInstance.GetRootAsTowerDefenceInstance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefenceInstanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerDefenceInstanceById.HandleId, ConfigTowerDefenceInstanceById.LogPair);
			return new TowerDefenceInstance?(rootAsTowerDefenceInstance);
		}

		// Token: 0x04004592 RID: 17810
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004593 RID: 17811
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004594 RID: 17812
		private const string TABLE = "TowerDefenceInstance";

		// Token: 0x04004595 RID: 17813
		private const string COMMAND = "select BinData from `TowerDefenceInstance` where Id = ?";

		// Token: 0x04004596 RID: 17814
		private const string KEY_PREFIX = "TowerDefenceInstanceById";

		// Token: 0x04004597 RID: 17815
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004598 RID: 17816
		private static int HandleId;
	}
}

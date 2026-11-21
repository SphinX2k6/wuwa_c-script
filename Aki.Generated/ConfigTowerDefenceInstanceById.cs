using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC9 RID: 2761
	public class ConfigTowerDefenceInstanceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040CA RID: 16586 RVA: 0x001CB217 File Offset: 0x001C9417
		static ConfigTowerDefenceInstanceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefenceInstanceById.CreateStaticDefaultValue), new Action(ConfigTowerDefenceInstanceById.ResetStaticDefaultValue));
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x001CB238 File Offset: 0x001C9438
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

		// Token: 0x060040CC RID: 16588 RVA: 0x001CB2B7 File Offset: 0x001C94B7
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefenceInstanceById.LogPair = null;
			ConfigTowerDefenceInstanceById.HandleId = 0;
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x001CB2C5 File Offset: 0x001C94C5
		public static void Init()
		{
			ConfigTowerDefenceInstanceById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefenceInstanceById.HandleId, "db_towerdefense.db", "select BinData from `TowerDefenceInstance` where Id = ?");
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x001CB2E0 File Offset: 0x001C94E0
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

		// Token: 0x04004B65 RID: 19301
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004B66 RID: 19302
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004B67 RID: 19303
		private const string TABLE = "TowerDefenceInstance";

		// Token: 0x04004B68 RID: 19304
		private const string COMMAND = "select BinData from `TowerDefenceInstance` where Id = ?";

		// Token: 0x04004B69 RID: 19305
		private const string KEY_PREFIX = "TowerDefenceInstanceById";

		// Token: 0x04004B6A RID: 19306
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B6B RID: 19307
		private static int HandleId;
	}
}

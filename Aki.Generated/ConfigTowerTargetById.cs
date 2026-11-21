using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ADC RID: 2780
	public class ConfigTowerTargetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600413C RID: 16700 RVA: 0x001CDA7F File Offset: 0x001CBC7F
		static ConfigTowerTargetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerTargetById.CreateStaticDefaultValue), new Action(ConfigTowerTargetById.ResetStaticDefaultValue));
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x001CDAA0 File Offset: 0x001CBCA0
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerTargetById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerTargetById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tower.db"),
				new ValueTuple<string, object>("文件", "p.爬塔新.xlsx"),
				new ValueTuple<string, object>("表名", "TowerTarget"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerTarget` where Id = ?")
			});
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x001CDB1F File Offset: 0x001CBD1F
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerTargetById.LogPair = null;
			ConfigTowerTargetById.HandleId = 0;
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x001CDB2D File Offset: 0x001CBD2D
		public static void Init()
		{
			ConfigTowerTargetById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerTargetById.HandleId, "db_tower.db", "select BinData from `TowerTarget` where Id = ?");
		}

		// Token: 0x06004140 RID: 16704 RVA: 0x001CDB48 File Offset: 0x001CBD48
		public static TowerTarget? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerTargetById.HandleId, ConfigTowerTargetById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerTargetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerTarget?(TowerTarget.GetRootAsTowerTarget(configBuffer));
				}
			}
			ConfigTowerTargetById.LogPair.Clear();
			ConfigTowerTargetById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTowerTargetById.HandleId, 1, p0Id, ConfigTowerTargetById.LogPair) || ConfigCommon.Step(ConfigTowerTargetById.HandleId, true, ConfigTowerTargetById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerTargetById.HandleId, ConfigTowerTargetById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerTargetById.HandleId, 0, ConfigTowerTargetById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerTargetById.HandleId, ConfigTowerTargetById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerTarget rootAsTowerTarget = TowerTarget.GetRootAsTowerTarget(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerTargetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerTargetById.HandleId, ConfigTowerTargetById.LogPair);
			return new TowerTarget?(rootAsTowerTarget);
		}

		// Token: 0x04004BEA RID: 19434
		private const string DB = "db_tower.db";

		// Token: 0x04004BEB RID: 19435
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004BEC RID: 19436
		private const string TABLE = "TowerTarget";

		// Token: 0x04004BED RID: 19437
		private const string COMMAND = "select BinData from `TowerTarget` where Id = ?";

		// Token: 0x04004BEE RID: 19438
		private const string KEY_PREFIX = "TowerTargetById";

		// Token: 0x04004BEF RID: 19439
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BF0 RID: 19440
		private static int HandleId;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F1 RID: 2545
	public class ConfigTowerConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BBA RID: 15290 RVA: 0x001AB86F File Offset: 0x001A9A6F
		static ConfigTowerConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerConfigById.CreateStaticDefaultValue), new Action(ConfigTowerConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x001AB890 File Offset: 0x001A9A90
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tower.db"),
				new ValueTuple<string, object>("文件", "p.爬塔新.xlsx"),
				new ValueTuple<string, object>("表名", "TowerConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerConfig` where Id = ?")
			});
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x001AB90F File Offset: 0x001A9B0F
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerConfigById.LogPair = null;
			ConfigTowerConfigById.HandleId = 0;
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x001AB91D File Offset: 0x001A9B1D
		public static void Init()
		{
			ConfigTowerConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerConfigById.HandleId, "db_tower.db", "select BinData from `TowerConfig` where Id = ?");
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x001AB938 File Offset: 0x001A9B38
		public static TowerConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerConfigById.HandleId, ConfigTowerConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerConfig?(TowerConfig.GetRootAsTowerConfig(configBuffer));
				}
			}
			ConfigTowerConfigById.LogPair.Clear();
			ConfigTowerConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTowerConfigById.HandleId, 1, p0Id, ConfigTowerConfigById.LogPair) || ConfigCommon.Step(ConfigTowerConfigById.HandleId, true, ConfigTowerConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerConfigById.HandleId, ConfigTowerConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerConfigById.HandleId, 0, ConfigTowerConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerConfigById.HandleId, ConfigTowerConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerConfig rootAsTowerConfig = TowerConfig.GetRootAsTowerConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerConfigById.HandleId, ConfigTowerConfigById.LogPair);
			return new TowerConfig?(rootAsTowerConfig);
		}

		// Token: 0x0400457D RID: 17789
		private const string DB = "db_tower.db";

		// Token: 0x0400457E RID: 17790
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x0400457F RID: 17791
		private const string TABLE = "TowerConfig";

		// Token: 0x04004580 RID: 17792
		private const string COMMAND = "select BinData from `TowerConfig` where Id = ?";

		// Token: 0x04004581 RID: 17793
		private const string KEY_PREFIX = "TowerConfigById";

		// Token: 0x04004582 RID: 17794
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004583 RID: 17795
		private static int HandleId;
	}
}

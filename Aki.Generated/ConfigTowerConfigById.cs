using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC6 RID: 2758
	public class ConfigTowerConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040B8 RID: 16568 RVA: 0x001CAC03 File Offset: 0x001C8E03
		static ConfigTowerConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerConfigById.CreateStaticDefaultValue), new Action(ConfigTowerConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x001CAC24 File Offset: 0x001C8E24
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

		// Token: 0x060040BA RID: 16570 RVA: 0x001CACA3 File Offset: 0x001C8EA3
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerConfigById.LogPair = null;
			ConfigTowerConfigById.HandleId = 0;
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x001CACB1 File Offset: 0x001C8EB1
		public static void Init()
		{
			ConfigTowerConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerConfigById.HandleId, "db_tower.db", "select BinData from `TowerConfig` where Id = ?");
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x001CACCC File Offset: 0x001C8ECC
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

		// Token: 0x04004B50 RID: 19280
		private const string DB = "db_tower.db";

		// Token: 0x04004B51 RID: 19281
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004B52 RID: 19282
		private const string TABLE = "TowerConfig";

		// Token: 0x04004B53 RID: 19283
		private const string COMMAND = "select BinData from `TowerConfig` where Id = ?";

		// Token: 0x04004B54 RID: 19284
		private const string KEY_PREFIX = "TowerConfigById";

		// Token: 0x04004B55 RID: 19285
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B56 RID: 19286
		private static int HandleId;
	}
}

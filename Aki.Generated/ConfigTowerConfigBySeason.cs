using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC7 RID: 2759
	public class ConfigTowerConfigBySeason : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040BE RID: 16574 RVA: 0x001CAE4C File Offset: 0x001C904C
		static ConfigTowerConfigBySeason()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerConfigBySeason.CreateStaticDefaultValue), new Action(ConfigTowerConfigBySeason.ResetStaticDefaultValue));
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x001CAE6C File Offset: 0x001C906C
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerConfigBySeason.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerConfigBySeason.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tower.db"),
				new ValueTuple<string, object>("文件", "p.爬塔新.xlsx"),
				new ValueTuple<string, object>("表名", "TowerConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerConfig` where Season = ?")
			});
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x001CAEEB File Offset: 0x001C90EB
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerConfigBySeason.LogPair = null;
			ConfigTowerConfigBySeason.HandleId = 0;
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x001CAEF9 File Offset: 0x001C90F9
		public static void Init()
		{
			ConfigTowerConfigBySeason.HandleId = ConfigCommon.InitDataStatement(ConfigTowerConfigBySeason.HandleId, "db_tower.db", "select BinData from `TowerConfig` where Season = ?");
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x001CAF14 File Offset: 0x001C9114
		[NullableContext(2)]
		public static IReadOnlyList<TowerConfig> GetConfigList(int p0Season, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerConfigBySeason.HandleId, ConfigTowerConfigBySeason.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerConfigBySeason");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Season);
				IReadOnlyList<TowerConfig> readOnlyList = (IReadOnlyList<TowerConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTowerConfigBySeason.LogPair.Clear();
			ConfigTowerConfigBySeason.LogPair.Add(new ValueTuple<string, object>("Season", p0Season));
			if (!ConfigCommon.BindInt(ConfigTowerConfigBySeason.HandleId, 1, p0Season, ConfigTowerConfigBySeason.LogPair))
			{
				ConfigCommon.Reset(ConfigTowerConfigBySeason.HandleId, ConfigTowerConfigBySeason.LogPair);
				return null;
			}
			List<TowerConfig> list = new List<TowerConfig>();
			while (ConfigCommon.Step(ConfigTowerConfigBySeason.HandleId, false, ConfigTowerConfigBySeason.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerConfigBySeason.HandleId, 0, ConfigTowerConfigBySeason.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTowerConfigBySeason.HandleId, ConfigTowerConfigBySeason.LogPair);
					return null;
				}
				TowerConfig rootAsTowerConfig = TowerConfig.GetRootAsTowerConfig(new ByteBuffer(item2));
				list.Add(rootAsTowerConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerConfigBySeason");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Season);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTowerConfigBySeason.HandleId, ConfigTowerConfigBySeason.LogPair);
			return list;
		}

		// Token: 0x04004B57 RID: 19287
		private const string DB = "db_tower.db";

		// Token: 0x04004B58 RID: 19288
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004B59 RID: 19289
		private const string TABLE = "TowerConfig";

		// Token: 0x04004B5A RID: 19290
		private const string COMMAND = "select BinData from `TowerConfig` where Season = ?";

		// Token: 0x04004B5B RID: 19291
		private const string KEY_PREFIX = "TowerConfigBySeason";

		// Token: 0x04004B5C RID: 19292
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B5D RID: 19293
		private static int HandleId;
	}
}

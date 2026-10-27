using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F2 RID: 2546
	public class ConfigTowerConfigBySeason : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BC0 RID: 15296 RVA: 0x001ABAB8 File Offset: 0x001A9CB8
		static ConfigTowerConfigBySeason()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerConfigBySeason.CreateStaticDefaultValue), new Action(ConfigTowerConfigBySeason.ResetStaticDefaultValue));
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x001ABAD8 File Offset: 0x001A9CD8
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

		// Token: 0x06003BC2 RID: 15298 RVA: 0x001ABB57 File Offset: 0x001A9D57
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerConfigBySeason.LogPair = null;
			ConfigTowerConfigBySeason.HandleId = 0;
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x001ABB65 File Offset: 0x001A9D65
		public static void Init()
		{
			ConfigTowerConfigBySeason.HandleId = ConfigCommon.InitDataStatement(ConfigTowerConfigBySeason.HandleId, "db_tower.db", "select BinData from `TowerConfig` where Season = ?");
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x001ABB80 File Offset: 0x001A9D80
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

		// Token: 0x04004584 RID: 17796
		private const string DB = "db_tower.db";

		// Token: 0x04004585 RID: 17797
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004586 RID: 17798
		private const string TABLE = "TowerConfig";

		// Token: 0x04004587 RID: 17799
		private const string COMMAND = "select BinData from `TowerConfig` where Season = ?";

		// Token: 0x04004588 RID: 17800
		private const string KEY_PREFIX = "TowerConfigBySeason";

		// Token: 0x04004589 RID: 17801
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400458A RID: 17802
		private static int HandleId;
	}
}

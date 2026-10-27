using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000320 RID: 800
	public class ConfigFloroRanchRarityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012C5 RID: 4805 RVA: 0x000C3878 File Offset: 0x000C1A78
		static ConfigFloroRanchRarityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchRarityAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchRarityAll.ResetStaticDefaultValue));
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x000C3898 File Offset: 0x000C1A98
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchRarityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchRarityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchRarity"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchRarity`")
			});
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x000C3917 File Offset: 0x000C1B17
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchRarityAll.LogPair = null;
			ConfigFloroRanchRarityAll.HandleId = 0;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x000C3925 File Offset: 0x000C1B25
		public static void Init()
		{
			ConfigFloroRanchRarityAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchRarityAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchRarity`");
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x000C3940 File Offset: 0x000C1B40
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchRarity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchRarityAll.HandleId, ConfigFloroRanchRarityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchRarity> readOnlyList = (IReadOnlyList<FloroRanchRarity>)ConfigCommon.GetConfig("FloroRanchRarityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchRarity> list = new List<FloroRanchRarity>();
			while (ConfigCommon.Step(ConfigFloroRanchRarityAll.HandleId, false, ConfigFloroRanchRarityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchRarityAll.HandleId, 0, ConfigFloroRanchRarityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchRarityAll.HandleId, ConfigFloroRanchRarityAll.LogPair);
					return null;
				}
				FloroRanchRarity rootAsFloroRanchRarity = FloroRanchRarity.GetRootAsFloroRanchRarity(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchRarity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchRarityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchRarityAll.HandleId, ConfigFloroRanchRarityAll.LogPair);
			return list;
		}

		// Token: 0x040015C4 RID: 5572
		private const string DB = "db_flororanch.db";

		// Token: 0x040015C5 RID: 5573
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015C6 RID: 5574
		private const string TABLE = "FloroRanchRarity";

		// Token: 0x040015C7 RID: 5575
		private const string COMMAND = "select BinData from `FloroRanchRarity`";

		// Token: 0x040015C8 RID: 5576
		private const string KEY_PREFIX = "FloroRanchRarityAll";

		// Token: 0x040015C9 RID: 5577
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015CA RID: 5578
		private static int HandleId;
	}
}

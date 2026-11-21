using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000335 RID: 821
	public class ConfigFloroRanchRarityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001343 RID: 4931 RVA: 0x000C9D84 File Offset: 0x000C7F84
		static ConfigFloroRanchRarityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchRarityAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchRarityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x000C9DA4 File Offset: 0x000C7FA4
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

		// Token: 0x06001345 RID: 4933 RVA: 0x000C9E23 File Offset: 0x000C8023
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchRarityAll.LogPair = null;
			ConfigFloroRanchRarityAll.HandleId = 0;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x000C9E31 File Offset: 0x000C8031
		public static void Init()
		{
			ConfigFloroRanchRarityAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchRarityAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchRarity`");
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x000C9E4C File Offset: 0x000C804C
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

		// Token: 0x04001657 RID: 5719
		private const string DB = "db_flororanch.db";

		// Token: 0x04001658 RID: 5720
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001659 RID: 5721
		private const string TABLE = "FloroRanchRarity";

		// Token: 0x0400165A RID: 5722
		private const string COMMAND = "select BinData from `FloroRanchRarity`";

		// Token: 0x0400165B RID: 5723
		private const string KEY_PREFIX = "FloroRanchRarityAll";

		// Token: 0x0400165C RID: 5724
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400165D RID: 5725
		private static int HandleId;
	}
}

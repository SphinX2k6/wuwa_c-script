using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000303 RID: 771
	public class ConfigFishingTechAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001217 RID: 4631 RVA: 0x000C3470 File Offset: 0x000C1670
		static ConfigFishingTechAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingTechAll.CreateStaticDefaultValue), new Action(ConfigFishingTechAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x000C3490 File Offset: 0x000C1690
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingTechAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingTechAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingTech"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingTech`")
			});
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x000C350F File Offset: 0x000C170F
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingTechAll.LogPair = null;
			ConfigFishingTechAll.HandleId = 0;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x000C351D File Offset: 0x000C171D
		public static void Init()
		{
			ConfigFishingTechAll.HandleId = ConfigCommon.InitDataStatement(ConfigFishingTechAll.HandleId, "db_fishing.db", "select BinData from `FishingTech`");
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x000C3538 File Offset: 0x000C1738
		[NullableContext(2)]
		public static IReadOnlyList<FishingTech> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingTechAll.HandleId, ConfigFishingTechAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FishingTech> readOnlyList = (IReadOnlyList<FishingTech>)ConfigCommon.GetConfig("FishingTechAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FishingTech> list = new List<FishingTech>();
			while (ConfigCommon.Step(ConfigFishingTechAll.HandleId, false, ConfigFishingTechAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingTechAll.HandleId, 0, ConfigFishingTechAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFishingTechAll.HandleId, ConfigFishingTechAll.LogPair);
					return null;
				}
				FishingTech rootAsFishingTech = FishingTech.GetRootAsFishingTech(new ByteBuffer(item2));
				list.Add(rootAsFishingTech);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FishingTechAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFishingTechAll.HandleId, ConfigFishingTechAll.LogPair);
			return list;
		}

		// Token: 0x040014F9 RID: 5369
		private const string DB = "db_fishing.db";

		// Token: 0x040014FA RID: 5370
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x040014FB RID: 5371
		private const string TABLE = "FishingTech";

		// Token: 0x040014FC RID: 5372
		private const string COMMAND = "select BinData from `FishingTech`";

		// Token: 0x040014FD RID: 5373
		private const string KEY_PREFIX = "FishingTechAll";

		// Token: 0x040014FE RID: 5374
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014FF RID: 5375
		private static int HandleId;
	}
}

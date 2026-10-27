using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000070 RID: 112
	public class ConfigAdvertisingTabStoryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x00068644 File Offset: 0x00066844
		static ConfigAdvertisingTabStoryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabStoryAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabStoryAll.ResetStaticDefaultValue));
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00068664 File Offset: 0x00066864
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabStoryAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabStoryAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabStory"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabStory`")
			});
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000686E3 File Offset: 0x000668E3
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabStoryAll.LogPair = null;
			ConfigAdvertisingTabStoryAll.HandleId = 0;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000686F1 File Offset: 0x000668F1
		public static void Init()
		{
			ConfigAdvertisingTabStoryAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabStoryAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabStory`");
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0006870C File Offset: 0x0006690C
		[NullableContext(2)]
		public static IReadOnlyList<AdvertisingTabStory> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabStoryAll.HandleId, ConfigAdvertisingTabStoryAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdvertisingTabStory> readOnlyList = (IReadOnlyList<AdvertisingTabStory>)ConfigCommon.GetConfig("AdvertisingTabStoryAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdvertisingTabStory> list = new List<AdvertisingTabStory>();
			while (ConfigCommon.Step(ConfigAdvertisingTabStoryAll.HandleId, false, ConfigAdvertisingTabStoryAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabStoryAll.HandleId, 0, ConfigAdvertisingTabStoryAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdvertisingTabStoryAll.HandleId, ConfigAdvertisingTabStoryAll.LogPair);
					return null;
				}
				AdvertisingTabStory rootAsAdvertisingTabStory = AdvertisingTabStory.GetRootAsAdvertisingTabStory(new ByteBuffer(item2));
				list.Add(rootAsAdvertisingTabStory);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdvertisingTabStoryAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabStoryAll.HandleId, ConfigAdvertisingTabStoryAll.LogPair);
			return list;
		}

		// Token: 0x040002F4 RID: 756
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002F5 RID: 757
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002F6 RID: 758
		private const string TABLE = "AdvertisingTabStory";

		// Token: 0x040002F7 RID: 759
		private const string COMMAND = "select BinData from `AdvertisingTabStory`";

		// Token: 0x040002F8 RID: 760
		private const string KEY_PREFIX = "AdvertisingTabStoryAll";

		// Token: 0x040002F9 RID: 761
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002FA RID: 762
		private static int HandleId;
	}
}

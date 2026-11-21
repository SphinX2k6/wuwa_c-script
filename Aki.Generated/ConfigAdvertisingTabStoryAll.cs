using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000078 RID: 120
	public class ConfigAdvertisingTabStoryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002D0 RID: 720 RVA: 0x0006CEF8 File Offset: 0x0006B0F8
		static ConfigAdvertisingTabStoryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabStoryAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabStoryAll.ResetStaticDefaultValue));
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0006CF18 File Offset: 0x0006B118
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

		// Token: 0x060002D2 RID: 722 RVA: 0x0006CF97 File Offset: 0x0006B197
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabStoryAll.LogPair = null;
			ConfigAdvertisingTabStoryAll.HandleId = 0;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0006CFA5 File Offset: 0x0006B1A5
		public static void Init()
		{
			ConfigAdvertisingTabStoryAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabStoryAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabStory`");
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0006CFC0 File Offset: 0x0006B1C0
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

		// Token: 0x0400032C RID: 812
		private const string DB = "db_advertisingpage.db";

		// Token: 0x0400032D RID: 813
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x0400032E RID: 814
		private const string TABLE = "AdvertisingTabStory";

		// Token: 0x0400032F RID: 815
		private const string COMMAND = "select BinData from `AdvertisingTabStory`";

		// Token: 0x04000330 RID: 816
		private const string KEY_PREFIX = "AdvertisingTabStoryAll";

		// Token: 0x04000331 RID: 817
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000332 RID: 818
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200095D RID: 2397
	public class ConfigSheriffClueAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003841 RID: 14401 RVA: 0x0019A8F0 File Offset: 0x00198AF0
		static ConfigSheriffClueAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffClueAll.CreateStaticDefaultValue), new Action(ConfigSheriffClueAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x0019A910 File Offset: 0x00198B10
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffClueAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffClueAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffClue"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffClue`")
			});
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x0019A98F File Offset: 0x00198B8F
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffClueAll.LogPair = null;
			ConfigSheriffClueAll.HandleId = 0;
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x0019A99D File Offset: 0x00198B9D
		public static void Init()
		{
			ConfigSheriffClueAll.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffClueAll.HandleId, "db_sheriff.db", "select BinData from `SheriffClue`");
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x0019A9B8 File Offset: 0x00198BB8
		[NullableContext(2)]
		public static IReadOnlyList<SheriffClue> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffClueAll.HandleId, ConfigSheriffClueAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SheriffClue> readOnlyList = (IReadOnlyList<SheriffClue>)ConfigCommon.GetConfig("SheriffClueAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SheriffClue> list = new List<SheriffClue>();
			while (ConfigCommon.Step(ConfigSheriffClueAll.HandleId, false, ConfigSheriffClueAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffClueAll.HandleId, 0, ConfigSheriffClueAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSheriffClueAll.HandleId, ConfigSheriffClueAll.LogPair);
					return null;
				}
				SheriffClue rootAsSheriffClue = SheriffClue.GetRootAsSheriffClue(new ByteBuffer(item2));
				list.Add(rootAsSheriffClue);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SheriffClueAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSheriffClueAll.HandleId, ConfigSheriffClueAll.LogPair);
			return list;
		}

		// Token: 0x04004171 RID: 16753
		private const string DB = "db_sheriff.db";

		// Token: 0x04004172 RID: 16754
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04004173 RID: 16755
		private const string TABLE = "SheriffClue";

		// Token: 0x04004174 RID: 16756
		private const string COMMAND = "select BinData from `SheriffClue`";

		// Token: 0x04004175 RID: 16757
		private const string KEY_PREFIX = "SheriffClueAll";

		// Token: 0x04004176 RID: 16758
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004177 RID: 16759
		private static int HandleId;
	}
}

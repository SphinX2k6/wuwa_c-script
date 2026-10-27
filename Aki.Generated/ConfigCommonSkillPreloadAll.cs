using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000186 RID: 390
	public class ConfigCommonSkillPreloadAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000925 RID: 2341 RVA: 0x0008D2B8 File Offset: 0x0008B4B8
		static ConfigCommonSkillPreloadAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonSkillPreloadAll.CreateStaticDefaultValue), new Action(ConfigCommonSkillPreloadAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0008D2D8 File Offset: 0x0008B4D8
		public static void CreateStaticDefaultValue()
		{
			ConfigCommonSkillPreloadAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCommonSkillPreloadAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_common_skill_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/CommonSkillPreload.csv"),
				new ValueTuple<string, object>("表名", "CommonSkillPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `CommonSkillPreload`")
			});
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0008D357 File Offset: 0x0008B557
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonSkillPreloadAll.LogPair = null;
			ConfigCommonSkillPreloadAll.HandleId = 0;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0008D365 File Offset: 0x0008B565
		public static void Init()
		{
			ConfigCommonSkillPreloadAll.HandleId = ConfigCommon.InitDataStatement(ConfigCommonSkillPreloadAll.HandleId, "db_common_skill_preload.db", "select BinData from `CommonSkillPreload`");
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0008D380 File Offset: 0x0008B580
		[NullableContext(2)]
		public static IReadOnlyList<CommonSkillPreload> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCommonSkillPreloadAll.HandleId, ConfigCommonSkillPreloadAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CommonSkillPreload> readOnlyList = (IReadOnlyList<CommonSkillPreload>)ConfigCommon.GetConfig("CommonSkillPreloadAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CommonSkillPreload> list = new List<CommonSkillPreload>();
			while (ConfigCommon.Step(ConfigCommonSkillPreloadAll.HandleId, false, ConfigCommonSkillPreloadAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCommonSkillPreloadAll.HandleId, 0, ConfigCommonSkillPreloadAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCommonSkillPreloadAll.HandleId, ConfigCommonSkillPreloadAll.LogPair);
					return null;
				}
				CommonSkillPreload rootAsCommonSkillPreload = CommonSkillPreload.GetRootAsCommonSkillPreload(new ByteBuffer(item2));
				list.Add(rootAsCommonSkillPreload);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CommonSkillPreloadAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCommonSkillPreloadAll.HandleId, ConfigCommonSkillPreloadAll.LogPair);
			return list;
		}

		// Token: 0x04000A8E RID: 2702
		private const string DB = "db_common_skill_preload.db";

		// Token: 0x04000A8F RID: 2703
		private const string FILE = "Preload/CommonSkillPreload.csv";

		// Token: 0x04000A90 RID: 2704
		private const string TABLE = "CommonSkillPreload";

		// Token: 0x04000A91 RID: 2705
		private const string COMMAND = "select BinData from `CommonSkillPreload`";

		// Token: 0x04000A92 RID: 2706
		private const string KEY_PREFIX = "CommonSkillPreloadAll";

		// Token: 0x04000A93 RID: 2707
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A94 RID: 2708
		private static int HandleId;
	}
}

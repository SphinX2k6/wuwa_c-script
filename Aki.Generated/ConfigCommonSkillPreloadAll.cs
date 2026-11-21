using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000198 RID: 408
	public class ConfigCommonSkillPreloadAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000991 RID: 2449 RVA: 0x000931F0 File Offset: 0x000913F0
		static ConfigCommonSkillPreloadAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonSkillPreloadAll.CreateStaticDefaultValue), new Action(ConfigCommonSkillPreloadAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00093210 File Offset: 0x00091410
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

		// Token: 0x06000993 RID: 2451 RVA: 0x0009328F File Offset: 0x0009148F
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonSkillPreloadAll.LogPair = null;
			ConfigCommonSkillPreloadAll.HandleId = 0;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0009329D File Offset: 0x0009149D
		public static void Init()
		{
			ConfigCommonSkillPreloadAll.HandleId = ConfigCommon.InitDataStatement(ConfigCommonSkillPreloadAll.HandleId, "db_common_skill_preload.db", "select BinData from `CommonSkillPreload`");
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000932B8 File Offset: 0x000914B8
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

		// Token: 0x04000B0C RID: 2828
		private const string DB = "db_common_skill_preload.db";

		// Token: 0x04000B0D RID: 2829
		private const string FILE = "Preload/CommonSkillPreload.csv";

		// Token: 0x04000B0E RID: 2830
		private const string TABLE = "CommonSkillPreload";

		// Token: 0x04000B0F RID: 2831
		private const string COMMAND = "select BinData from `CommonSkillPreload`";

		// Token: 0x04000B10 RID: 2832
		private const string KEY_PREFIX = "CommonSkillPreloadAll";

		// Token: 0x04000B11 RID: 2833
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B12 RID: 2834
		private static int HandleId;
	}
}

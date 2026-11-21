using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000600 RID: 1536
	public class ConfigNewbieCourseV2All : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600240F RID: 9231 RVA: 0x00128E9C File Offset: 0x0012709C
		static ConfigNewbieCourseV2All()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCourseV2All.CreateStaticDefaultValue), new Action(ConfigNewbieCourseV2All.ResetStaticDefaultValue));
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x00128EBC File Offset: 0x001270BC
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieCourseV2All.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieCourseV2All.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newbiecourse.db"),
				new ValueTuple<string, object>("文件", "x.新手历程活动.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieCourseV2"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieCourseV2`")
			});
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x00128F3B File Offset: 0x0012713B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCourseV2All.LogPair = null;
			ConfigNewbieCourseV2All.HandleId = 0;
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00128F49 File Offset: 0x00127149
		public static void Init()
		{
			ConfigNewbieCourseV2All.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCourseV2All.HandleId, "db_newbiecourse.db", "select BinData from `NewbieCourseV2`");
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00128F64 File Offset: 0x00127164
		[NullableContext(2)]
		public static IReadOnlyList<NewbieCourseV2> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieCourseV2All.HandleId, ConfigNewbieCourseV2All.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<NewbieCourseV2> readOnlyList = (IReadOnlyList<NewbieCourseV2>)ConfigCommon.GetConfig("NewbieCourseV2All");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<NewbieCourseV2> list = new List<NewbieCourseV2>();
			while (ConfigCommon.Step(ConfigNewbieCourseV2All.HandleId, false, ConfigNewbieCourseV2All.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieCourseV2All.HandleId, 0, ConfigNewbieCourseV2All.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewbieCourseV2All.HandleId, ConfigNewbieCourseV2All.LogPair);
					return null;
				}
				NewbieCourseV2 rootAsNewbieCourseV = NewbieCourseV2.GetRootAsNewbieCourseV2(new ByteBuffer(item2));
				list.Add(rootAsNewbieCourseV);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("NewbieCourseV2All", list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewbieCourseV2All.HandleId, ConfigNewbieCourseV2All.LogPair);
			return list;
		}

		// Token: 0x040029E6 RID: 10726
		private const string DB = "db_newbiecourse.db";

		// Token: 0x040029E7 RID: 10727
		private const string FILE = "x.新手历程活动.xlsx";

		// Token: 0x040029E8 RID: 10728
		private const string TABLE = "NewbieCourseV2";

		// Token: 0x040029E9 RID: 10729
		private const string COMMAND = "select BinData from `NewbieCourseV2`";

		// Token: 0x040029EA RID: 10730
		private const string KEY_PREFIX = "NewbieCourseV2All";

		// Token: 0x040029EB RID: 10731
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029EC RID: 10732
		private static int HandleId;
	}
}

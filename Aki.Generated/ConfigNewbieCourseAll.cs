using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E6 RID: 1510
	public class ConfigNewbieCourseAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002373 RID: 9075 RVA: 0x00122044 File Offset: 0x00120244
		static ConfigNewbieCourseAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCourseAll.CreateStaticDefaultValue), new Action(ConfigNewbieCourseAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x00122064 File Offset: 0x00120264
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieCourseAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieCourseAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newbiecourse.db"),
				new ValueTuple<string, object>("文件", "x.新手历程活动.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieCourse"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieCourse`")
			});
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x001220E3 File Offset: 0x001202E3
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCourseAll.LogPair = null;
			ConfigNewbieCourseAll.HandleId = 0;
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x001220F1 File Offset: 0x001202F1
		public static void Init()
		{
			ConfigNewbieCourseAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCourseAll.HandleId, "db_newbiecourse.db", "select BinData from `NewbieCourse`");
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x0012210C File Offset: 0x0012030C
		[NullableContext(2)]
		public static IReadOnlyList<NewbieCourse> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieCourseAll.HandleId, ConfigNewbieCourseAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<NewbieCourse> readOnlyList = (IReadOnlyList<NewbieCourse>)ConfigCommon.GetConfig("NewbieCourseAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<NewbieCourse> list = new List<NewbieCourse>();
			while (ConfigCommon.Step(ConfigNewbieCourseAll.HandleId, false, ConfigNewbieCourseAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieCourseAll.HandleId, 0, ConfigNewbieCourseAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewbieCourseAll.HandleId, ConfigNewbieCourseAll.LogPair);
					return null;
				}
				NewbieCourse rootAsNewbieCourse = NewbieCourse.GetRootAsNewbieCourse(new ByteBuffer(item2));
				list.Add(rootAsNewbieCourse);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("NewbieCourseAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewbieCourseAll.HandleId, ConfigNewbieCourseAll.LogPair);
			return list;
		}

		// Token: 0x04002930 RID: 10544
		private const string DB = "db_newbiecourse.db";

		// Token: 0x04002931 RID: 10545
		private const string FILE = "x.新手历程活动.xlsx";

		// Token: 0x04002932 RID: 10546
		private const string TABLE = "NewbieCourse";

		// Token: 0x04002933 RID: 10547
		private const string COMMAND = "select BinData from `NewbieCourse`";

		// Token: 0x04002934 RID: 10548
		private const string KEY_PREFIX = "NewbieCourseAll";

		// Token: 0x04002935 RID: 10549
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002936 RID: 10550
		private static int HandleId;
	}
}

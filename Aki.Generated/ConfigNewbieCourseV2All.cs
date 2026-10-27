using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E8 RID: 1512
	public class ConfigNewbieCourseV2All : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600237F RID: 9087 RVA: 0x00122420 File Offset: 0x00120620
		static ConfigNewbieCourseV2All()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCourseV2All.CreateStaticDefaultValue), new Action(ConfigNewbieCourseV2All.ResetStaticDefaultValue));
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x00122440 File Offset: 0x00120640
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

		// Token: 0x06002381 RID: 9089 RVA: 0x001224BF File Offset: 0x001206BF
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCourseV2All.LogPair = null;
			ConfigNewbieCourseV2All.HandleId = 0;
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x001224CD File Offset: 0x001206CD
		public static void Init()
		{
			ConfigNewbieCourseV2All.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCourseV2All.HandleId, "db_newbiecourse.db", "select BinData from `NewbieCourseV2`");
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x001224E8 File Offset: 0x001206E8
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

		// Token: 0x0400293E RID: 10558
		private const string DB = "db_newbiecourse.db";

		// Token: 0x0400293F RID: 10559
		private const string FILE = "x.新手历程活动.xlsx";

		// Token: 0x04002940 RID: 10560
		private const string TABLE = "NewbieCourseV2";

		// Token: 0x04002941 RID: 10561
		private const string COMMAND = "select BinData from `NewbieCourseV2`";

		// Token: 0x04002942 RID: 10562
		private const string KEY_PREFIX = "NewbieCourseV2All";

		// Token: 0x04002943 RID: 10563
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002944 RID: 10564
		private static int HandleId;
	}
}

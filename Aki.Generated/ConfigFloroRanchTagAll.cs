using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200033C RID: 828
	public class ConfigFloroRanchTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600136D RID: 4973 RVA: 0x000CAC04 File Offset: 0x000C8E04
		static ConfigFloroRanchTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTagAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x000CAC24 File Offset: 0x000C8E24
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchTagAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchTagAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchtag.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_词条.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchTag"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchTag`")
			});
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x000CACA3 File Offset: 0x000C8EA3
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTagAll.LogPair = null;
			ConfigFloroRanchTagAll.HandleId = 0;
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x000CACB1 File Offset: 0x000C8EB1
		public static void Init()
		{
			ConfigFloroRanchTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTagAll.HandleId, "db_flororanchtag.db", "select BinData from `FloroRanchTag`");
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x000CACCC File Offset: 0x000C8ECC
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchTag> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchTagAll.HandleId, ConfigFloroRanchTagAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchTag> readOnlyList = (IReadOnlyList<FloroRanchTag>)ConfigCommon.GetConfig("FloroRanchTagAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchTag> list = new List<FloroRanchTag>();
			while (ConfigCommon.Step(ConfigFloroRanchTagAll.HandleId, false, ConfigFloroRanchTagAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchTagAll.HandleId, 0, ConfigFloroRanchTagAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchTagAll.HandleId, ConfigFloroRanchTagAll.LogPair);
					return null;
				}
				FloroRanchTag rootAsFloroRanchTag = FloroRanchTag.GetRootAsFloroRanchTag(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchTag);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchTagAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchTagAll.HandleId, ConfigFloroRanchTagAll.LogPair);
			return list;
		}

		// Token: 0x04001688 RID: 5768
		private const string DB = "db_flororanchtag.db";

		// Token: 0x04001689 RID: 5769
		private const string FILE = "f.弗洛洛牧场_词条.xlsx";

		// Token: 0x0400168A RID: 5770
		private const string TABLE = "FloroRanchTag";

		// Token: 0x0400168B RID: 5771
		private const string COMMAND = "select BinData from `FloroRanchTag`";

		// Token: 0x0400168C RID: 5772
		private const string KEY_PREFIX = "FloroRanchTagAll";

		// Token: 0x0400168D RID: 5773
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400168E RID: 5774
		private static int HandleId;
	}
}

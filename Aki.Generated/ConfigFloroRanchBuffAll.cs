using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000324 RID: 804
	public class ConfigFloroRanchBuffAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012DD RID: 4829 RVA: 0x000C7BB8 File Offset: 0x000C5DB8
		static ConfigFloroRanchBuffAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchBuffAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchBuffAll.ResetStaticDefaultValue));
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x000C7BD8 File Offset: 0x000C5DD8
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchBuffAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchBuffAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchbuff.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_buff.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchBuff`")
			});
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x000C7C57 File Offset: 0x000C5E57
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchBuffAll.LogPair = null;
			ConfigFloroRanchBuffAll.HandleId = 0;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x000C7C65 File Offset: 0x000C5E65
		public static void Init()
		{
			ConfigFloroRanchBuffAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchBuffAll.HandleId, "db_flororanchbuff.db", "select BinData from `FloroRanchBuff`");
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x000C7C80 File Offset: 0x000C5E80
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchBuff> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchBuffAll.HandleId, ConfigFloroRanchBuffAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchBuff> readOnlyList = (IReadOnlyList<FloroRanchBuff>)ConfigCommon.GetConfig("FloroRanchBuffAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchBuff> list = new List<FloroRanchBuff>();
			while (ConfigCommon.Step(ConfigFloroRanchBuffAll.HandleId, false, ConfigFloroRanchBuffAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchBuffAll.HandleId, 0, ConfigFloroRanchBuffAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchBuffAll.HandleId, ConfigFloroRanchBuffAll.LogPair);
					return null;
				}
				FloroRanchBuff rootAsFloroRanchBuff = FloroRanchBuff.GetRootAsFloroRanchBuff(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchBuff);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchBuffAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchBuffAll.HandleId, ConfigFloroRanchBuffAll.LogPair);
			return list;
		}

		// Token: 0x040015E0 RID: 5600
		private const string DB = "db_flororanchbuff.db";

		// Token: 0x040015E1 RID: 5601
		private const string FILE = "f.弗洛洛牧场_buff.xlsx";

		// Token: 0x040015E2 RID: 5602
		private const string TABLE = "FloroRanchBuff";

		// Token: 0x040015E3 RID: 5603
		private const string COMMAND = "select BinData from `FloroRanchBuff`";

		// Token: 0x040015E4 RID: 5604
		private const string KEY_PREFIX = "FloroRanchBuffAll";

		// Token: 0x040015E5 RID: 5605
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015E6 RID: 5606
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C0 RID: 1728
	public class ConfigPhoneTipShowListAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002890 RID: 10384 RVA: 0x0013EE7C File Offset: 0x0013D07C
		static ConfigPhoneTipShowListAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhoneTipShowListAll.CreateStaticDefaultValue), new Action(ConfigPhoneTipShowListAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x0013EE9C File Offset: 0x0013D09C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhoneTipShowListAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhoneTipShowListAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "PhoneTipShowList"),
				new ValueTuple<string, object>("语句", "select BinData from `PhoneTipShowList`")
			});
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x0013EF1B File Offset: 0x0013D11B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhoneTipShowListAll.LogPair = null;
			ConfigPhoneTipShowListAll.HandleId = 0;
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x0013EF29 File Offset: 0x0013D129
		public static void Init()
		{
			ConfigPhoneTipShowListAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhoneTipShowListAll.HandleId, "db_phonemsg.db", "select BinData from `PhoneTipShowList`");
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x0013EF44 File Offset: 0x0013D144
		[NullableContext(2)]
		public static IReadOnlyList<PhoneTipShowList> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhoneTipShowListAll.HandleId, ConfigPhoneTipShowListAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhoneTipShowList> readOnlyList = (IReadOnlyList<PhoneTipShowList>)ConfigCommon.GetConfig("PhoneTipShowListAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhoneTipShowList> list = new List<PhoneTipShowList>();
			while (ConfigCommon.Step(ConfigPhoneTipShowListAll.HandleId, false, ConfigPhoneTipShowListAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhoneTipShowListAll.HandleId, 0, ConfigPhoneTipShowListAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhoneTipShowListAll.HandleId, ConfigPhoneTipShowListAll.LogPair);
					return null;
				}
				PhoneTipShowList rootAsPhoneTipShowList = PhoneTipShowList.GetRootAsPhoneTipShowList(new ByteBuffer(item2));
				list.Add(rootAsPhoneTipShowList);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhoneTipShowListAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhoneTipShowListAll.HandleId, ConfigPhoneTipShowListAll.LogPair);
			return list;
		}

		// Token: 0x04002F26 RID: 12070
		private const string DB = "db_phonemsg.db";

		// Token: 0x04002F27 RID: 12071
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04002F28 RID: 12072
		private const string TABLE = "PhoneTipShowList";

		// Token: 0x04002F29 RID: 12073
		private const string COMMAND = "select BinData from `PhoneTipShowList`";

		// Token: 0x04002F2A RID: 12074
		private const string KEY_PREFIX = "PhoneTipShowListAll";

		// Token: 0x04002F2B RID: 12075
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F2C RID: 12076
		private static int HandleId;
	}
}

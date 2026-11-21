using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D8 RID: 1752
	public class ConfigPhoneTipShowListAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002920 RID: 10528 RVA: 0x001458F8 File Offset: 0x00143AF8
		static ConfigPhoneTipShowListAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhoneTipShowListAll.CreateStaticDefaultValue), new Action(ConfigPhoneTipShowListAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x00145918 File Offset: 0x00143B18
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

		// Token: 0x06002922 RID: 10530 RVA: 0x00145997 File Offset: 0x00143B97
		public static void ResetStaticDefaultValue()
		{
			ConfigPhoneTipShowListAll.LogPair = null;
			ConfigPhoneTipShowListAll.HandleId = 0;
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x001459A5 File Offset: 0x00143BA5
		public static void Init()
		{
			ConfigPhoneTipShowListAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhoneTipShowListAll.HandleId, "db_phonemsg.db", "select BinData from `PhoneTipShowList`");
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x001459C0 File Offset: 0x00143BC0
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

		// Token: 0x04002FCE RID: 12238
		private const string DB = "db_phonemsg.db";

		// Token: 0x04002FCF RID: 12239
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04002FD0 RID: 12240
		private const string TABLE = "PhoneTipShowList";

		// Token: 0x04002FD1 RID: 12241
		private const string COMMAND = "select BinData from `PhoneTipShowList`";

		// Token: 0x04002FD2 RID: 12242
		private const string KEY_PREFIX = "PhoneTipShowListAll";

		// Token: 0x04002FD3 RID: 12243
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FD4 RID: 12244
		private static int HandleId;
	}
}

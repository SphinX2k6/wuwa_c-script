using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B78 RID: 2936
	public class ConfigWuWuTaskPackageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044E5 RID: 17637 RVA: 0x001E2ED0 File Offset: 0x001E10D0
		static ConfigWuWuTaskPackageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWuTaskPackageAll.CreateStaticDefaultValue), new Action(ConfigWuWuTaskPackageAll.ResetStaticDefaultValue));
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x001E2EF0 File Offset: 0x001E10F0
		public static void CreateStaticDefaultValue()
		{
			ConfigWuWuTaskPackageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWuWuTaskPackageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwutask.db"),
				new ValueTuple<string, object>("文件", "w.呜呜签到.xlsx"),
				new ValueTuple<string, object>("表名", "WuWuTaskPackage"),
				new ValueTuple<string, object>("语句", "select BinData from `WuWuTaskPackage`")
			});
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x001E2F6F File Offset: 0x001E116F
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWuTaskPackageAll.LogPair = null;
			ConfigWuWuTaskPackageAll.HandleId = 0;
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x001E2F7D File Offset: 0x001E117D
		public static void Init()
		{
			ConfigWuWuTaskPackageAll.HandleId = ConfigCommon.InitDataStatement(ConfigWuWuTaskPackageAll.HandleId, "db_wuwutask.db", "select BinData from `WuWuTaskPackage`");
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x001E2F98 File Offset: 0x001E1198
		[NullableContext(2)]
		public static IReadOnlyList<WuWuTaskPackage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWuWuTaskPackageAll.HandleId, ConfigWuWuTaskPackageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<WuWuTaskPackage> readOnlyList = (IReadOnlyList<WuWuTaskPackage>)ConfigCommon.GetConfig("WuWuTaskPackageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<WuWuTaskPackage> list = new List<WuWuTaskPackage>();
			while (ConfigCommon.Step(ConfigWuWuTaskPackageAll.HandleId, false, ConfigWuWuTaskPackageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWuWuTaskPackageAll.HandleId, 0, ConfigWuWuTaskPackageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWuWuTaskPackageAll.HandleId, ConfigWuWuTaskPackageAll.LogPair);
					return null;
				}
				WuWuTaskPackage rootAsWuWuTaskPackage = WuWuTaskPackage.GetRootAsWuWuTaskPackage(new ByteBuffer(item2));
				list.Add(rootAsWuWuTaskPackage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("WuWuTaskPackageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigWuWuTaskPackageAll.HandleId, ConfigWuWuTaskPackageAll.LogPair);
			return list;
		}

		// Token: 0x0400502E RID: 20526
		private const string DB = "db_wuwutask.db";

		// Token: 0x0400502F RID: 20527
		private const string FILE = "w.呜呜签到.xlsx";

		// Token: 0x04005030 RID: 20528
		private const string TABLE = "WuWuTaskPackage";

		// Token: 0x04005031 RID: 20529
		private const string COMMAND = "select BinData from `WuWuTaskPackage`";

		// Token: 0x04005032 RID: 20530
		private const string KEY_PREFIX = "WuWuTaskPackageAll";

		// Token: 0x04005033 RID: 20531
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04005034 RID: 20532
		private static int HandleId;
	}
}

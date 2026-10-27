using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA3 RID: 2723
	public class ConfigWuWuTaskPackageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FE7 RID: 16359 RVA: 0x001C3B3C File Offset: 0x001C1D3C
		static ConfigWuWuTaskPackageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWuTaskPackageAll.CreateStaticDefaultValue), new Action(ConfigWuWuTaskPackageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x001C3B5C File Offset: 0x001C1D5C
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

		// Token: 0x06003FE9 RID: 16361 RVA: 0x001C3BDB File Offset: 0x001C1DDB
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWuTaskPackageAll.LogPair = null;
			ConfigWuWuTaskPackageAll.HandleId = 0;
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x001C3BE9 File Offset: 0x001C1DE9
		public static void Init()
		{
			ConfigWuWuTaskPackageAll.HandleId = ConfigCommon.InitDataStatement(ConfigWuWuTaskPackageAll.HandleId, "db_wuwutask.db", "select BinData from `WuWuTaskPackage`");
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x001C3C04 File Offset: 0x001C1E04
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

		// Token: 0x04004A5B RID: 19035
		private const string DB = "db_wuwutask.db";

		// Token: 0x04004A5C RID: 19036
		private const string FILE = "w.呜呜签到.xlsx";

		// Token: 0x04004A5D RID: 19037
		private const string TABLE = "WuWuTaskPackage";

		// Token: 0x04004A5E RID: 19038
		private const string COMMAND = "select BinData from `WuWuTaskPackage`";

		// Token: 0x04004A5F RID: 19039
		private const string KEY_PREFIX = "WuWuTaskPackageAll";

		// Token: 0x04004A60 RID: 19040
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A61 RID: 19041
		private static int HandleId;
	}
}

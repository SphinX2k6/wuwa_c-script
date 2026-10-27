using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009EA RID: 2538
	public class ConfigTotalTopUpRotationAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B90 RID: 15248 RVA: 0x001AA9F0 File Offset: 0x001A8BF0
		static ConfigTotalTopUpRotationAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpRotationAll.CreateStaticDefaultValue), new Action(ConfigTotalTopUpRotationAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x001AAA10 File Offset: 0x001A8C10
		public static void CreateStaticDefaultValue()
		{
			ConfigTotalTopUpRotationAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTotalTopUpRotationAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_totaltopup.db"),
				new ValueTuple<string, object>("文件", "l.累充活动.xlsx"),
				new ValueTuple<string, object>("表名", "TotalTopUpRotation"),
				new ValueTuple<string, object>("语句", "select BinData from `TotalTopUpRotation`")
			});
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x001AAA8F File Offset: 0x001A8C8F
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpRotationAll.LogPair = null;
			ConfigTotalTopUpRotationAll.HandleId = 0;
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x001AAA9D File Offset: 0x001A8C9D
		public static void Init()
		{
			ConfigTotalTopUpRotationAll.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpRotationAll.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpRotation`");
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x001AAAB8 File Offset: 0x001A8CB8
		[NullableContext(2)]
		public static IReadOnlyList<TotalTopUpRotation> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTotalTopUpRotationAll.HandleId, ConfigTotalTopUpRotationAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TotalTopUpRotation> readOnlyList = (IReadOnlyList<TotalTopUpRotation>)ConfigCommon.GetConfig("TotalTopUpRotationAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TotalTopUpRotation> list = new List<TotalTopUpRotation>();
			while (ConfigCommon.Step(ConfigTotalTopUpRotationAll.HandleId, false, ConfigTotalTopUpRotationAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTotalTopUpRotationAll.HandleId, 0, ConfigTotalTopUpRotationAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTotalTopUpRotationAll.HandleId, ConfigTotalTopUpRotationAll.LogPair);
					return null;
				}
				TotalTopUpRotation rootAsTotalTopUpRotation = TotalTopUpRotation.GetRootAsTotalTopUpRotation(new ByteBuffer(item2));
				list.Add(rootAsTotalTopUpRotation);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TotalTopUpRotationAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTotalTopUpRotationAll.HandleId, ConfigTotalTopUpRotationAll.LogPair);
			return list;
		}

		// Token: 0x0400454C RID: 17740
		private const string DB = "db_totaltopup.db";

		// Token: 0x0400454D RID: 17741
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x0400454E RID: 17742
		private const string TABLE = "TotalTopUpRotation";

		// Token: 0x0400454F RID: 17743
		private const string COMMAND = "select BinData from `TotalTopUpRotation`";

		// Token: 0x04004550 RID: 17744
		private const string KEY_PREFIX = "TotalTopUpRotationAll";

		// Token: 0x04004551 RID: 17745
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004552 RID: 17746
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000963 RID: 2403
	public class ConfigSheriffMapAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003865 RID: 14437 RVA: 0x0019B5DC File Offset: 0x001997DC
		static ConfigSheriffMapAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffMapAll.CreateStaticDefaultValue), new Action(ConfigSheriffMapAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x0019B5FC File Offset: 0x001997FC
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffMapAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffMapAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffMap"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffMap`")
			});
		}

		// Token: 0x06003867 RID: 14439 RVA: 0x0019B67B File Offset: 0x0019987B
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffMapAll.LogPair = null;
			ConfigSheriffMapAll.HandleId = 0;
		}

		// Token: 0x06003868 RID: 14440 RVA: 0x0019B689 File Offset: 0x00199889
		public static void Init()
		{
			ConfigSheriffMapAll.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffMapAll.HandleId, "db_sheriff.db", "select BinData from `SheriffMap`");
		}

		// Token: 0x06003869 RID: 14441 RVA: 0x0019B6A4 File Offset: 0x001998A4
		[NullableContext(2)]
		public static IReadOnlyList<SheriffMap> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffMapAll.HandleId, ConfigSheriffMapAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SheriffMap> readOnlyList = (IReadOnlyList<SheriffMap>)ConfigCommon.GetConfig("SheriffMapAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SheriffMap> list = new List<SheriffMap>();
			while (ConfigCommon.Step(ConfigSheriffMapAll.HandleId, false, ConfigSheriffMapAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffMapAll.HandleId, 0, ConfigSheriffMapAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSheriffMapAll.HandleId, ConfigSheriffMapAll.LogPair);
					return null;
				}
				SheriffMap rootAsSheriffMap = SheriffMap.GetRootAsSheriffMap(new ByteBuffer(item2));
				list.Add(rootAsSheriffMap);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SheriffMapAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSheriffMapAll.HandleId, ConfigSheriffMapAll.LogPair);
			return list;
		}

		// Token: 0x0400419B RID: 16795
		private const string DB = "db_sheriff.db";

		// Token: 0x0400419C RID: 16796
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x0400419D RID: 16797
		private const string TABLE = "SheriffMap";

		// Token: 0x0400419E RID: 16798
		private const string COMMAND = "select BinData from `SheriffMap`";

		// Token: 0x0400419F RID: 16799
		private const string KEY_PREFIX = "SheriffMapAll";

		// Token: 0x040041A0 RID: 16800
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041A1 RID: 16801
		private static int HandleId;
	}
}

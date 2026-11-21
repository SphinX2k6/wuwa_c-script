using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A2E RID: 2606
	public class ConfigSolarSchoolTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D28 RID: 15656 RVA: 0x001B6568 File Offset: 0x001B4768
		static ConfigSolarSchoolTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolTaskAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x001B6588 File Offset: 0x001B4788
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolTaskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolTaskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolTask"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolTask`")
			});
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x001B6607 File Offset: 0x001B4807
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolTaskAll.LogPair = null;
			ConfigSolarSchoolTaskAll.HandleId = 0;
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x001B6615 File Offset: 0x001B4815
		public static void Init()
		{
			ConfigSolarSchoolTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolTaskAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolTask`");
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x001B6630 File Offset: 0x001B4830
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolTask> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolTaskAll.HandleId, ConfigSolarSchoolTaskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolTask> readOnlyList = (IReadOnlyList<SolarSchoolTask>)ConfigCommon.GetConfig("SolarSchoolTaskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolTask> list = new List<SolarSchoolTask>();
			while (ConfigCommon.Step(ConfigSolarSchoolTaskAll.HandleId, false, ConfigSolarSchoolTaskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolTaskAll.HandleId, 0, ConfigSolarSchoolTaskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolTaskAll.HandleId, ConfigSolarSchoolTaskAll.LogPair);
					return null;
				}
				SolarSchoolTask rootAsSolarSchoolTask = SolarSchoolTask.GetRootAsSolarSchoolTask(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolTask);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolTaskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolTaskAll.HandleId, ConfigSolarSchoolTaskAll.LogPair);
			return list;
		}

		// Token: 0x04004728 RID: 18216
		private const string DB = "db_solarschool.db";

		// Token: 0x04004729 RID: 18217
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x0400472A RID: 18218
		private const string TABLE = "SolarSchoolTask";

		// Token: 0x0400472B RID: 18219
		private const string COMMAND = "select BinData from `SolarSchoolTask`";

		// Token: 0x0400472C RID: 18220
		private const string KEY_PREFIX = "SolarSchoolTaskAll";

		// Token: 0x0400472D RID: 18221
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400472E RID: 18222
		private static int HandleId;
	}
}

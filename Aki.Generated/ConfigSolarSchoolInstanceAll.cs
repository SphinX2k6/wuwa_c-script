using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E8 RID: 2536
	public class ConfigSolarSchoolInstanceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B84 RID: 15236 RVA: 0x001AD3F1 File Offset: 0x001AB5F1
		static ConfigSolarSchoolInstanceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolInstanceAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolInstanceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x001AD410 File Offset: 0x001AB610
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolInstanceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolInstanceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_地点.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolInstance"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolInstance`")
			});
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x001AD48F File Offset: 0x001AB68F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolInstanceAll.LogPair = null;
			ConfigSolarSchoolInstanceAll.HandleId = 0;
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x001AD49D File Offset: 0x001AB69D
		public static void Init()
		{
			ConfigSolarSchoolInstanceAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolInstanceAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolInstance`");
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x001AD4B8 File Offset: 0x001AB6B8
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolInstance> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolInstanceAll.HandleId, ConfigSolarSchoolInstanceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolInstance> readOnlyList = (IReadOnlyList<SolarSchoolInstance>)ConfigCommon.GetConfig("SolarSchoolInstanceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolInstance> list = new List<SolarSchoolInstance>();
			while (ConfigCommon.Step(ConfigSolarSchoolInstanceAll.HandleId, false, ConfigSolarSchoolInstanceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolInstanceAll.HandleId, 0, ConfigSolarSchoolInstanceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolInstanceAll.HandleId, ConfigSolarSchoolInstanceAll.LogPair);
					return null;
				}
				SolarSchoolInstance rootAsSolarSchoolInstance = SolarSchoolInstance.GetRootAsSolarSchoolInstance(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolInstance);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolInstanceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolInstanceAll.HandleId, ConfigSolarSchoolInstanceAll.LogPair);
			return list;
		}

		// Token: 0x0400453E RID: 17726
		private const string DB = "db_solarschool.db";

		// Token: 0x0400453F RID: 17727
		private const string FILE = "d.第二索拉_地点.xlsx";

		// Token: 0x04004540 RID: 17728
		private const string TABLE = "SolarSchoolInstance";

		// Token: 0x04004541 RID: 17729
		private const string COMMAND = "select BinData from `SolarSchoolInstance`";

		// Token: 0x04004542 RID: 17730
		private const string KEY_PREFIX = "SolarSchoolInstanceAll";

		// Token: 0x04004543 RID: 17731
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004544 RID: 17732
		private static int HandleId;
	}
}

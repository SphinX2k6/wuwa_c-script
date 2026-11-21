using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009EE RID: 2542
	public class ConfigSolarSchoolItemEffectAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BA8 RID: 15272 RVA: 0x001AE018 File Offset: 0x001AC218
		static ConfigSolarSchoolItemEffectAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolItemEffectAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolItemEffectAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x001AE038 File Offset: 0x001AC238
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolItemEffectAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolItemEffectAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolItemEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolItemEffect`")
			});
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x001AE0B7 File Offset: 0x001AC2B7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolItemEffectAll.LogPair = null;
			ConfigSolarSchoolItemEffectAll.HandleId = 0;
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x001AE0C5 File Offset: 0x001AC2C5
		public static void Init()
		{
			ConfigSolarSchoolItemEffectAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolItemEffectAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolItemEffect`");
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x001AE0E0 File Offset: 0x001AC2E0
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolItemEffect> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolItemEffectAll.HandleId, ConfigSolarSchoolItemEffectAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolItemEffect> readOnlyList = (IReadOnlyList<SolarSchoolItemEffect>)ConfigCommon.GetConfig("SolarSchoolItemEffectAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolItemEffect> list = new List<SolarSchoolItemEffect>();
			while (ConfigCommon.Step(ConfigSolarSchoolItemEffectAll.HandleId, false, ConfigSolarSchoolItemEffectAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolItemEffectAll.HandleId, 0, ConfigSolarSchoolItemEffectAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolItemEffectAll.HandleId, ConfigSolarSchoolItemEffectAll.LogPair);
					return null;
				}
				SolarSchoolItemEffect rootAsSolarSchoolItemEffect = SolarSchoolItemEffect.GetRootAsSolarSchoolItemEffect(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolItemEffect);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolItemEffectAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolItemEffectAll.HandleId, ConfigSolarSchoolItemEffectAll.LogPair);
			return list;
		}

		// Token: 0x04004568 RID: 17768
		private const string DB = "db_solarschool.db";

		// Token: 0x04004569 RID: 17769
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x0400456A RID: 17770
		private const string TABLE = "SolarSchoolItemEffect";

		// Token: 0x0400456B RID: 17771
		private const string COMMAND = "select BinData from `SolarSchoolItemEffect`";

		// Token: 0x0400456C RID: 17772
		private const string KEY_PREFIX = "SolarSchoolItemEffectAll";

		// Token: 0x0400456D RID: 17773
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400456E RID: 17774
		private static int HandleId;
	}
}

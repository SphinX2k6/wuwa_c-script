using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009EC RID: 2540
	public class ConfigSolarSchoolItemByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B9C RID: 15260 RVA: 0x001ADB97 File Offset: 0x001ABD97
		static ConfigSolarSchoolItemByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolItemByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolItemByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x001ADBB8 File Offset: 0x001ABDB8
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolItemByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolItemByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolItem` where ActivityId=?")
			});
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x001ADC37 File Offset: 0x001ABE37
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolItemByActivityId.LogPair = null;
			ConfigSolarSchoolItemByActivityId.HandleId = 0;
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x001ADC45 File Offset: 0x001ABE45
		public static void Init()
		{
			ConfigSolarSchoolItemByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolItemByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolItem` where ActivityId=?");
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x001ADC60 File Offset: 0x001ABE60
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolItem> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolItemByActivityId.HandleId, ConfigSolarSchoolItemByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolItemByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolItem> readOnlyList = (IReadOnlyList<SolarSchoolItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolItemByActivityId.LogPair.Clear();
			ConfigSolarSchoolItemByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolItemByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolItemByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolItemByActivityId.HandleId, ConfigSolarSchoolItemByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolItem> list = new List<SolarSchoolItem>();
			while (ConfigCommon.Step(ConfigSolarSchoolItemByActivityId.HandleId, false, ConfigSolarSchoolItemByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolItemByActivityId.HandleId, 0, ConfigSolarSchoolItemByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolItemByActivityId.HandleId, ConfigSolarSchoolItemByActivityId.LogPair);
					return null;
				}
				SolarSchoolItem rootAsSolarSchoolItem = SolarSchoolItem.GetRootAsSolarSchoolItem(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolItemByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolItemByActivityId.HandleId, ConfigSolarSchoolItemByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400455A RID: 17754
		private const string DB = "db_solarschool.db";

		// Token: 0x0400455B RID: 17755
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x0400455C RID: 17756
		private const string TABLE = "SolarSchoolItem";

		// Token: 0x0400455D RID: 17757
		private const string COMMAND = "select BinData from `SolarSchoolItem` where ActivityId=?";

		// Token: 0x0400455E RID: 17758
		private const string KEY_PREFIX = "SolarSchoolItemByActivityId";

		// Token: 0x0400455F RID: 17759
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004560 RID: 17760
		private static int HandleId;
	}
}

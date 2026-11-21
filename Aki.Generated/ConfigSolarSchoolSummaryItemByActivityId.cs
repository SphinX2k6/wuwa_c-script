using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A2C RID: 2604
	public class ConfigSolarSchoolSummaryItemByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D1C RID: 15644 RVA: 0x001B60E8 File Offset: 0x001B42E8
		static ConfigSolarSchoolSummaryItemByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolSummaryItemByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolSummaryItemByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x001B6108 File Offset: 0x001B4308
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolSummaryItemByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolSummaryItemByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolSummaryItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolSummaryItem` where ActivityId=?")
			});
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x001B6187 File Offset: 0x001B4387
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolSummaryItemByActivityId.LogPair = null;
			ConfigSolarSchoolSummaryItemByActivityId.HandleId = 0;
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x001B6195 File Offset: 0x001B4395
		public static void Init()
		{
			ConfigSolarSchoolSummaryItemByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolSummaryItemByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolSummaryItem` where ActivityId=?");
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x001B61B0 File Offset: 0x001B43B0
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolSummaryItem> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolSummaryItemByActivityId.HandleId, ConfigSolarSchoolSummaryItemByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolSummaryItemByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolSummaryItem> readOnlyList = (IReadOnlyList<SolarSchoolSummaryItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolSummaryItemByActivityId.LogPair.Clear();
			ConfigSolarSchoolSummaryItemByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolSummaryItemByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolSummaryItemByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolSummaryItemByActivityId.HandleId, ConfigSolarSchoolSummaryItemByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolSummaryItem> list = new List<SolarSchoolSummaryItem>();
			while (ConfigCommon.Step(ConfigSolarSchoolSummaryItemByActivityId.HandleId, false, ConfigSolarSchoolSummaryItemByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolSummaryItemByActivityId.HandleId, 0, ConfigSolarSchoolSummaryItemByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolSummaryItemByActivityId.HandleId, ConfigSolarSchoolSummaryItemByActivityId.LogPair);
					return null;
				}
				SolarSchoolSummaryItem rootAsSolarSchoolSummaryItem = SolarSchoolSummaryItem.GetRootAsSolarSchoolSummaryItem(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolSummaryItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolSummaryItemByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolSummaryItemByActivityId.HandleId, ConfigSolarSchoolSummaryItemByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400471A RID: 18202
		private const string DB = "db_solarschool.db";

		// Token: 0x0400471B RID: 18203
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x0400471C RID: 18204
		private const string TABLE = "SolarSchoolSummaryItem";

		// Token: 0x0400471D RID: 18205
		private const string COMMAND = "select BinData from `SolarSchoolSummaryItem` where ActivityId=?";

		// Token: 0x0400471E RID: 18206
		private const string KEY_PREFIX = "SolarSchoolSummaryItemByActivityId";

		// Token: 0x0400471F RID: 18207
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004720 RID: 18208
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A2A RID: 2602
	public class ConfigSolarSchoolSpanByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D10 RID: 15632 RVA: 0x001B5C67 File Offset: 0x001B3E67
		static ConfigSolarSchoolSpanByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolSpanByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolSpanByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x001B5C88 File Offset: 0x001B3E88
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolSpanByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolSpanByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolSpan"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolSpan` where ActivityId=?")
			});
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x001B5D07 File Offset: 0x001B3F07
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolSpanByActivityId.LogPair = null;
			ConfigSolarSchoolSpanByActivityId.HandleId = 0;
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x001B5D15 File Offset: 0x001B3F15
		public static void Init()
		{
			ConfigSolarSchoolSpanByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolSpanByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolSpan` where ActivityId=?");
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x001B5D30 File Offset: 0x001B3F30
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolSpan> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolSpanByActivityId.HandleId, ConfigSolarSchoolSpanByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolSpanByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolSpan> readOnlyList = (IReadOnlyList<SolarSchoolSpan>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolSpanByActivityId.LogPair.Clear();
			ConfigSolarSchoolSpanByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolSpanByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolSpanByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolSpanByActivityId.HandleId, ConfigSolarSchoolSpanByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolSpan> list = new List<SolarSchoolSpan>();
			while (ConfigCommon.Step(ConfigSolarSchoolSpanByActivityId.HandleId, false, ConfigSolarSchoolSpanByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolSpanByActivityId.HandleId, 0, ConfigSolarSchoolSpanByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolSpanByActivityId.HandleId, ConfigSolarSchoolSpanByActivityId.LogPair);
					return null;
				}
				SolarSchoolSpan rootAsSolarSchoolSpan = SolarSchoolSpan.GetRootAsSolarSchoolSpan(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolSpan);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolSpanByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolSpanByActivityId.HandleId, ConfigSolarSchoolSpanByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400470C RID: 18188
		private const string DB = "db_solarschool.db";

		// Token: 0x0400470D RID: 18189
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x0400470E RID: 18190
		private const string TABLE = "SolarSchoolSpan";

		// Token: 0x0400470F RID: 18191
		private const string COMMAND = "select BinData from `SolarSchoolSpan` where ActivityId=?";

		// Token: 0x04004710 RID: 18192
		private const string KEY_PREFIX = "SolarSchoolSpanByActivityId";

		// Token: 0x04004711 RID: 18193
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004712 RID: 18194
		private static int HandleId;
	}
}

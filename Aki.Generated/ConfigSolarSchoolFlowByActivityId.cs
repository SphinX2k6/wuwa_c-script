using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009DE RID: 2526
	public class ConfigSolarSchoolFlowByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B48 RID: 15176 RVA: 0x001ABD9F File Offset: 0x001A9F9F
		static ConfigSolarSchoolFlowByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolFlowByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolFlowByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x001ABDC0 File Offset: 0x001A9FC0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolFlowByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolFlowByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_剧情.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolFlow"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolFlow` where ActivityId=?")
			});
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x001ABE3F File Offset: 0x001AA03F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolFlowByActivityId.LogPair = null;
			ConfigSolarSchoolFlowByActivityId.HandleId = 0;
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x001ABE4D File Offset: 0x001AA04D
		public static void Init()
		{
			ConfigSolarSchoolFlowByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolFlowByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolFlow` where ActivityId=?");
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x001ABE68 File Offset: 0x001AA068
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolFlow> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolFlowByActivityId.HandleId, ConfigSolarSchoolFlowByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolFlowByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolFlow> readOnlyList = (IReadOnlyList<SolarSchoolFlow>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolFlowByActivityId.LogPair.Clear();
			ConfigSolarSchoolFlowByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolFlowByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolFlowByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolFlowByActivityId.HandleId, ConfigSolarSchoolFlowByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolFlow> list = new List<SolarSchoolFlow>();
			while (ConfigCommon.Step(ConfigSolarSchoolFlowByActivityId.HandleId, false, ConfigSolarSchoolFlowByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolFlowByActivityId.HandleId, 0, ConfigSolarSchoolFlowByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolFlowByActivityId.HandleId, ConfigSolarSchoolFlowByActivityId.LogPair);
					return null;
				}
				SolarSchoolFlow rootAsSolarSchoolFlow = SolarSchoolFlow.GetRootAsSolarSchoolFlow(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolFlow);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolFlowByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolFlowByActivityId.HandleId, ConfigSolarSchoolFlowByActivityId.LogPair);
			return list;
		}

		// Token: 0x040044F8 RID: 17656
		private const string DB = "db_solarschool.db";

		// Token: 0x040044F9 RID: 17657
		private const string FILE = "d.第二索拉_剧情.xlsx";

		// Token: 0x040044FA RID: 17658
		private const string TABLE = "SolarSchoolFlow";

		// Token: 0x040044FB RID: 17659
		private const string COMMAND = "select BinData from `SolarSchoolFlow` where ActivityId=?";

		// Token: 0x040044FC RID: 17660
		private const string KEY_PREFIX = "SolarSchoolFlowByActivityId";

		// Token: 0x040044FD RID: 17661
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044FE RID: 17662
		private static int HandleId;
	}
}

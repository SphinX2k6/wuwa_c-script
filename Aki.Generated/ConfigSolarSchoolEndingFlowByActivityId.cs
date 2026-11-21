using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009CD RID: 2509
	public class ConfigSolarSchoolEndingFlowByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AE2 RID: 15074 RVA: 0x001A987F File Offset: 0x001A7A7F
		static ConfigSolarSchoolEndingFlowByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolEndingFlowByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolEndingFlowByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x001A98A0 File Offset: 0x001A7AA0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolEndingFlowByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolEndingFlowByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolEndingFlow"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolEndingFlow` where ActivityId=?")
			});
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x001A991F File Offset: 0x001A7B1F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolEndingFlowByActivityId.LogPair = null;
			ConfigSolarSchoolEndingFlowByActivityId.HandleId = 0;
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x001A992D File Offset: 0x001A7B2D
		public static void Init()
		{
			ConfigSolarSchoolEndingFlowByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolEndingFlowByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolEndingFlow` where ActivityId=?");
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x001A9948 File Offset: 0x001A7B48
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolEndingFlow> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolEndingFlowByActivityId.HandleId, ConfigSolarSchoolEndingFlowByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEndingFlowByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolEndingFlow> readOnlyList = (IReadOnlyList<SolarSchoolEndingFlow>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolEndingFlowByActivityId.LogPair.Clear();
			ConfigSolarSchoolEndingFlowByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolEndingFlowByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolEndingFlowByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolEndingFlowByActivityId.HandleId, ConfigSolarSchoolEndingFlowByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolEndingFlow> list = new List<SolarSchoolEndingFlow>();
			while (ConfigCommon.Step(ConfigSolarSchoolEndingFlowByActivityId.HandleId, false, ConfigSolarSchoolEndingFlowByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolEndingFlowByActivityId.HandleId, 0, ConfigSolarSchoolEndingFlowByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolEndingFlowByActivityId.HandleId, ConfigSolarSchoolEndingFlowByActivityId.LogPair);
					return null;
				}
				SolarSchoolEndingFlow rootAsSolarSchoolEndingFlow = SolarSchoolEndingFlow.GetRootAsSolarSchoolEndingFlow(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolEndingFlow);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEndingFlowByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolEndingFlowByActivityId.HandleId, ConfigSolarSchoolEndingFlowByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004481 RID: 17537
		private const string DB = "db_solarschool.db";

		// Token: 0x04004482 RID: 17538
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x04004483 RID: 17539
		private const string TABLE = "SolarSchoolEndingFlow";

		// Token: 0x04004484 RID: 17540
		private const string COMMAND = "select BinData from `SolarSchoolEndingFlow` where ActivityId=?";

		// Token: 0x04004485 RID: 17541
		private const string KEY_PREFIX = "SolarSchoolEndingFlowByActivityId";

		// Token: 0x04004486 RID: 17542
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004487 RID: 17543
		private static int HandleId;
	}
}

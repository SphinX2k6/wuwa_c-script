using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E2 RID: 2530
	public class ConfigSolarSchoolFunctionByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B60 RID: 15200 RVA: 0x001AC6B0 File Offset: 0x001AA8B0
		static ConfigSolarSchoolFunctionByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolFunctionByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolFunctionByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x001AC6D0 File Offset: 0x001AA8D0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolFunctionByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolFunctionByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolFunction"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolFunction` where ActivityId=?")
			});
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x001AC74F File Offset: 0x001AA94F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolFunctionByActivityId.LogPair = null;
			ConfigSolarSchoolFunctionByActivityId.HandleId = 0;
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x001AC75D File Offset: 0x001AA95D
		public static void Init()
		{
			ConfigSolarSchoolFunctionByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolFunctionByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolFunction` where ActivityId=?");
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x001AC778 File Offset: 0x001AA978
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolFunction> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolFunctionByActivityId.HandleId, ConfigSolarSchoolFunctionByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolFunctionByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolFunction> readOnlyList = (IReadOnlyList<SolarSchoolFunction>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolFunctionByActivityId.LogPair.Clear();
			ConfigSolarSchoolFunctionByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolFunctionByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolFunctionByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolFunctionByActivityId.HandleId, ConfigSolarSchoolFunctionByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolFunction> list = new List<SolarSchoolFunction>();
			while (ConfigCommon.Step(ConfigSolarSchoolFunctionByActivityId.HandleId, false, ConfigSolarSchoolFunctionByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolFunctionByActivityId.HandleId, 0, ConfigSolarSchoolFunctionByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolFunctionByActivityId.HandleId, ConfigSolarSchoolFunctionByActivityId.LogPair);
					return null;
				}
				SolarSchoolFunction rootAsSolarSchoolFunction = SolarSchoolFunction.GetRootAsSolarSchoolFunction(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolFunction);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolFunctionByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolFunctionByActivityId.HandleId, ConfigSolarSchoolFunctionByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004514 RID: 17684
		private const string DB = "db_solarschool.db";

		// Token: 0x04004515 RID: 17685
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004516 RID: 17686
		private const string TABLE = "SolarSchoolFunction";

		// Token: 0x04004517 RID: 17687
		private const string COMMAND = "select BinData from `SolarSchoolFunction` where ActivityId=?";

		// Token: 0x04004518 RID: 17688
		private const string KEY_PREFIX = "SolarSchoolFunctionByActivityId";

		// Token: 0x04004519 RID: 17689
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400451A RID: 17690
		private static int HandleId;
	}
}

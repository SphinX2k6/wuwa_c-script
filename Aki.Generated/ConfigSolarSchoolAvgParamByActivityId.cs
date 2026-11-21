using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B6 RID: 2486
	public class ConfigSolarSchoolAvgParamByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A58 RID: 14936 RVA: 0x001A68CF File Offset: 0x001A4ACF
		static ConfigSolarSchoolAvgParamByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolAvgParamByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolAvgParamByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x001A68F0 File Offset: 0x001A4AF0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolAvgParamByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolAvgParamByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_剧情.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolAvgParam"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolAvgParam` where ActivityId=?")
			});
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x001A696F File Offset: 0x001A4B6F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolAvgParamByActivityId.LogPair = null;
			ConfigSolarSchoolAvgParamByActivityId.HandleId = 0;
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x001A697D File Offset: 0x001A4B7D
		public static void Init()
		{
			ConfigSolarSchoolAvgParamByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolAvgParamByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolAvgParam` where ActivityId=?");
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x001A6998 File Offset: 0x001A4B98
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolAvgParam> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolAvgParamByActivityId.HandleId, ConfigSolarSchoolAvgParamByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAvgParamByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolAvgParam> readOnlyList = (IReadOnlyList<SolarSchoolAvgParam>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolAvgParamByActivityId.LogPair.Clear();
			ConfigSolarSchoolAvgParamByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolAvgParamByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolAvgParamByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolAvgParamByActivityId.HandleId, ConfigSolarSchoolAvgParamByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolAvgParam> list = new List<SolarSchoolAvgParam>();
			while (ConfigCommon.Step(ConfigSolarSchoolAvgParamByActivityId.HandleId, false, ConfigSolarSchoolAvgParamByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolAvgParamByActivityId.HandleId, 0, ConfigSolarSchoolAvgParamByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolAvgParamByActivityId.HandleId, ConfigSolarSchoolAvgParamByActivityId.LogPair);
					return null;
				}
				SolarSchoolAvgParam rootAsSolarSchoolAvgParam = SolarSchoolAvgParam.GetRootAsSolarSchoolAvgParam(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolAvgParam);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAvgParamByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolAvgParamByActivityId.HandleId, ConfigSolarSchoolAvgParamByActivityId.LogPair);
			return list;
		}

		// Token: 0x040043E0 RID: 17376
		private const string DB = "db_solarschool.db";

		// Token: 0x040043E1 RID: 17377
		private const string FILE = "d.第二索拉_剧情.xlsx";

		// Token: 0x040043E2 RID: 17378
		private const string TABLE = "SolarSchoolAvgParam";

		// Token: 0x040043E3 RID: 17379
		private const string COMMAND = "select BinData from `SolarSchoolAvgParam` where ActivityId=?";

		// Token: 0x040043E4 RID: 17380
		private const string KEY_PREFIX = "SolarSchoolAvgParamByActivityId";

		// Token: 0x040043E5 RID: 17381
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043E6 RID: 17382
		private static int HandleId;
	}
}

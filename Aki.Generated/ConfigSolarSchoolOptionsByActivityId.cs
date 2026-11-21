using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F7 RID: 2551
	public class ConfigSolarSchoolOptionsByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BDE RID: 15326 RVA: 0x001AF2BB File Offset: 0x001AD4BB
		static ConfigSolarSchoolOptionsByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolOptionsByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolOptionsByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x001AF2DC File Offset: 0x001AD4DC
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolOptionsByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolOptionsByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_地点.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolOptions"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolOptions` where ActivityId=?")
			});
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x001AF35B File Offset: 0x001AD55B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolOptionsByActivityId.LogPair = null;
			ConfigSolarSchoolOptionsByActivityId.HandleId = 0;
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x001AF369 File Offset: 0x001AD569
		public static void Init()
		{
			ConfigSolarSchoolOptionsByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolOptionsByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolOptions` where ActivityId=?");
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x001AF384 File Offset: 0x001AD584
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolOptions> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolOptionsByActivityId.HandleId, ConfigSolarSchoolOptionsByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolOptionsByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolOptions> readOnlyList = (IReadOnlyList<SolarSchoolOptions>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolOptionsByActivityId.LogPair.Clear();
			ConfigSolarSchoolOptionsByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolOptionsByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolOptionsByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolOptionsByActivityId.HandleId, ConfigSolarSchoolOptionsByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolOptions> list = new List<SolarSchoolOptions>();
			while (ConfigCommon.Step(ConfigSolarSchoolOptionsByActivityId.HandleId, false, ConfigSolarSchoolOptionsByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolOptionsByActivityId.HandleId, 0, ConfigSolarSchoolOptionsByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolOptionsByActivityId.HandleId, ConfigSolarSchoolOptionsByActivityId.LogPair);
					return null;
				}
				SolarSchoolOptions rootAsSolarSchoolOptions = SolarSchoolOptions.GetRootAsSolarSchoolOptions(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolOptions);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolOptionsByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolOptionsByActivityId.HandleId, ConfigSolarSchoolOptionsByActivityId.LogPair);
			return list;
		}

		// Token: 0x040045A7 RID: 17831
		private const string DB = "db_solarschool.db";

		// Token: 0x040045A8 RID: 17832
		private const string FILE = "d.第二索拉_地点.xlsx";

		// Token: 0x040045A9 RID: 17833
		private const string TABLE = "SolarSchoolOptions";

		// Token: 0x040045AA RID: 17834
		private const string COMMAND = "select BinData from `SolarSchoolOptions` where ActivityId=?";

		// Token: 0x040045AB RID: 17835
		private const string KEY_PREFIX = "SolarSchoolOptionsByActivityId";

		// Token: 0x040045AC RID: 17836
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045AD RID: 17837
		private static int HandleId;
	}
}

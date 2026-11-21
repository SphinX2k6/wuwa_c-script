using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F4 RID: 2548
	public class ConfigSolarSchoolLocationByActivityIdAndInstanceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BCC RID: 15308 RVA: 0x001AEC4F File Offset: 0x001ACE4F
		static ConfigSolarSchoolLocationByActivityIdAndInstanceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolLocationByActivityIdAndInstanceId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolLocationByActivityIdAndInstanceId.ResetStaticDefaultValue));
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x001AEC70 File Offset: 0x001ACE70
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_地点.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolLocation"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolLocation` where ActivityId=? And InstanceId=?")
			});
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x001AECEF File Offset: 0x001ACEEF
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair = null;
			ConfigSolarSchoolLocationByActivityIdAndInstanceId.HandleId = 0;
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x001AECFD File Offset: 0x001ACEFD
		public static void Init()
		{
			ConfigSolarSchoolLocationByActivityIdAndInstanceId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolLocationByActivityIdAndInstanceId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolLocation` where ActivityId=? And InstanceId=?");
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x001AED18 File Offset: 0x001ACF18
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolLocation> GetConfigList(int p0ActivityId, int p1InstanceId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolLocationByActivityIdAndInstanceId.HandleId, ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolLocationByActivityIdAndInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InstanceId);
				IReadOnlyList<SolarSchoolLocation> readOnlyList = (IReadOnlyList<SolarSchoolLocation>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair.Clear();
			ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair.Add(new ValueTuple<string, object>("InstanceId", p1InstanceId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolLocationByActivityIdAndInstanceId.HandleId, 1, p0ActivityId, ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair) || !ConfigCommon.BindInt(ConfigSolarSchoolLocationByActivityIdAndInstanceId.HandleId, 2, p1InstanceId, ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolLocationByActivityIdAndInstanceId.HandleId, ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair);
				return null;
			}
			List<SolarSchoolLocation> list = new List<SolarSchoolLocation>();
			while (ConfigCommon.Step(ConfigSolarSchoolLocationByActivityIdAndInstanceId.HandleId, false, ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolLocationByActivityIdAndInstanceId.HandleId, 0, ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolLocationByActivityIdAndInstanceId.HandleId, ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair);
					return null;
				}
				SolarSchoolLocation rootAsSolarSchoolLocation = SolarSchoolLocation.GetRootAsSolarSchoolLocation(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolLocation);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolLocationByActivityIdAndInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InstanceId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolLocationByActivityIdAndInstanceId.HandleId, ConfigSolarSchoolLocationByActivityIdAndInstanceId.LogPair);
			return list;
		}

		// Token: 0x04004592 RID: 17810
		private const string DB = "db_solarschool.db";

		// Token: 0x04004593 RID: 17811
		private const string FILE = "d.第二索拉_地点.xlsx";

		// Token: 0x04004594 RID: 17812
		private const string TABLE = "SolarSchoolLocation";

		// Token: 0x04004595 RID: 17813
		private const string COMMAND = "select BinData from `SolarSchoolLocation` where ActivityId=? And InstanceId=?";

		// Token: 0x04004596 RID: 17814
		private const string KEY_PREFIX = "SolarSchoolLocationByActivityIdAndInstanceId";

		// Token: 0x04004597 RID: 17815
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004598 RID: 17816
		private static int HandleId;
	}
}

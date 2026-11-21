using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009F3 RID: 2547
	public class ConfigSolarSchoolLocationByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BC6 RID: 15302 RVA: 0x001AEA17 File Offset: 0x001ACC17
		static ConfigSolarSchoolLocationByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolLocationByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolLocationByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x001AEA38 File Offset: 0x001ACC38
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolLocationByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolLocationByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_地点.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolLocation"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolLocation` where ActivityId=?")
			});
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x001AEAB7 File Offset: 0x001ACCB7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolLocationByActivityId.LogPair = null;
			ConfigSolarSchoolLocationByActivityId.HandleId = 0;
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x001AEAC5 File Offset: 0x001ACCC5
		public static void Init()
		{
			ConfigSolarSchoolLocationByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolLocationByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolLocation` where ActivityId=?");
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x001AEAE0 File Offset: 0x001ACCE0
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolLocation> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolLocationByActivityId.HandleId, ConfigSolarSchoolLocationByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolLocationByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolLocation> readOnlyList = (IReadOnlyList<SolarSchoolLocation>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolLocationByActivityId.LogPair.Clear();
			ConfigSolarSchoolLocationByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolLocationByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolLocationByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolLocationByActivityId.HandleId, ConfigSolarSchoolLocationByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolLocation> list = new List<SolarSchoolLocation>();
			while (ConfigCommon.Step(ConfigSolarSchoolLocationByActivityId.HandleId, false, ConfigSolarSchoolLocationByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolLocationByActivityId.HandleId, 0, ConfigSolarSchoolLocationByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolLocationByActivityId.HandleId, ConfigSolarSchoolLocationByActivityId.LogPair);
					return null;
				}
				SolarSchoolLocation rootAsSolarSchoolLocation = SolarSchoolLocation.GetRootAsSolarSchoolLocation(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolLocation);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolLocationByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolLocationByActivityId.HandleId, ConfigSolarSchoolLocationByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400458B RID: 17803
		private const string DB = "db_solarschool.db";

		// Token: 0x0400458C RID: 17804
		private const string FILE = "d.第二索拉_地点.xlsx";

		// Token: 0x0400458D RID: 17805
		private const string TABLE = "SolarSchoolLocation";

		// Token: 0x0400458E RID: 17806
		private const string COMMAND = "select BinData from `SolarSchoolLocation` where ActivityId=?";

		// Token: 0x0400458F RID: 17807
		private const string KEY_PREFIX = "SolarSchoolLocationByActivityId";

		// Token: 0x04004590 RID: 17808
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004591 RID: 17809
		private static int HandleId;
	}
}

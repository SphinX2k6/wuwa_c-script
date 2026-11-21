using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B3 RID: 2483
	public class ConfigSolarSchoolAttrByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A46 RID: 14918 RVA: 0x001A62BB File Offset: 0x001A44BB
		static ConfigSolarSchoolAttrByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolAttrByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolAttrByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x001A62DC File Offset: 0x001A44DC
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolAttrByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolAttrByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolAttr"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolAttr` where ActivityId=?")
			});
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x001A635B File Offset: 0x001A455B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolAttrByActivityId.LogPair = null;
			ConfigSolarSchoolAttrByActivityId.HandleId = 0;
		}

		// Token: 0x06003A49 RID: 14921 RVA: 0x001A6369 File Offset: 0x001A4569
		public static void Init()
		{
			ConfigSolarSchoolAttrByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolAttrByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolAttr` where ActivityId=?");
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x001A6384 File Offset: 0x001A4584
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolAttr> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolAttrByActivityId.HandleId, ConfigSolarSchoolAttrByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAttrByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolAttr> readOnlyList = (IReadOnlyList<SolarSchoolAttr>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolAttrByActivityId.LogPair.Clear();
			ConfigSolarSchoolAttrByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolAttrByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolAttrByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolAttrByActivityId.HandleId, ConfigSolarSchoolAttrByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolAttr> list = new List<SolarSchoolAttr>();
			while (ConfigCommon.Step(ConfigSolarSchoolAttrByActivityId.HandleId, false, ConfigSolarSchoolAttrByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolAttrByActivityId.HandleId, 0, ConfigSolarSchoolAttrByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolAttrByActivityId.HandleId, ConfigSolarSchoolAttrByActivityId.LogPair);
					return null;
				}
				SolarSchoolAttr rootAsSolarSchoolAttr = SolarSchoolAttr.GetRootAsSolarSchoolAttr(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolAttr);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAttrByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolAttrByActivityId.HandleId, ConfigSolarSchoolAttrByActivityId.LogPair);
			return list;
		}

		// Token: 0x040043CB RID: 17355
		private const string DB = "db_solarschool.db";

		// Token: 0x040043CC RID: 17356
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x040043CD RID: 17357
		private const string TABLE = "SolarSchoolAttr";

		// Token: 0x040043CE RID: 17358
		private const string COMMAND = "select BinData from `SolarSchoolAttr` where ActivityId=?";

		// Token: 0x040043CF RID: 17359
		private const string KEY_PREFIX = "SolarSchoolAttrByActivityId";

		// Token: 0x040043D0 RID: 17360
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043D1 RID: 17361
		private static int HandleId;
	}
}

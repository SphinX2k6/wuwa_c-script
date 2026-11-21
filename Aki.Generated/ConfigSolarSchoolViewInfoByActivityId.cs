using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A35 RID: 2613
	public class ConfigSolarSchoolViewInfoByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D52 RID: 15698 RVA: 0x001B73C8 File Offset: 0x001B55C8
		static ConfigSolarSchoolViewInfoByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolViewInfoByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolViewInfoByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x001B73E8 File Offset: 0x001B55E8
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolViewInfoByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolViewInfoByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolViewInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolViewInfo` where ActivityId=?")
			});
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x001B7467 File Offset: 0x001B5667
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolViewInfoByActivityId.LogPair = null;
			ConfigSolarSchoolViewInfoByActivityId.HandleId = 0;
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x001B7475 File Offset: 0x001B5675
		public static void Init()
		{
			ConfigSolarSchoolViewInfoByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolViewInfoByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolViewInfo` where ActivityId=?");
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x001B7490 File Offset: 0x001B5690
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolViewInfo> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolViewInfoByActivityId.HandleId, ConfigSolarSchoolViewInfoByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolViewInfoByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolViewInfo> readOnlyList = (IReadOnlyList<SolarSchoolViewInfo>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolViewInfoByActivityId.LogPair.Clear();
			ConfigSolarSchoolViewInfoByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolViewInfoByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolViewInfoByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolViewInfoByActivityId.HandleId, ConfigSolarSchoolViewInfoByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolViewInfo> list = new List<SolarSchoolViewInfo>();
			while (ConfigCommon.Step(ConfigSolarSchoolViewInfoByActivityId.HandleId, false, ConfigSolarSchoolViewInfoByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolViewInfoByActivityId.HandleId, 0, ConfigSolarSchoolViewInfoByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolViewInfoByActivityId.HandleId, ConfigSolarSchoolViewInfoByActivityId.LogPair);
					return null;
				}
				SolarSchoolViewInfo rootAsSolarSchoolViewInfo = SolarSchoolViewInfo.GetRootAsSolarSchoolViewInfo(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolViewInfo);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolViewInfoByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolViewInfoByActivityId.HandleId, ConfigSolarSchoolViewInfoByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004759 RID: 18265
		private const string DB = "db_solarschool.db";

		// Token: 0x0400475A RID: 18266
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x0400475B RID: 18267
		private const string TABLE = "SolarSchoolViewInfo";

		// Token: 0x0400475C RID: 18268
		private const string COMMAND = "select BinData from `SolarSchoolViewInfo` where ActivityId=?";

		// Token: 0x0400475D RID: 18269
		private const string KEY_PREFIX = "SolarSchoolViewInfoByActivityId";

		// Token: 0x0400475E RID: 18270
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400475F RID: 18271
		private static int HandleId;
	}
}

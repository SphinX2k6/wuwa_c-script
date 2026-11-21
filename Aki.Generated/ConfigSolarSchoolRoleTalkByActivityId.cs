using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A1A RID: 2586
	public class ConfigSolarSchoolRoleTalkByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CB0 RID: 15536 RVA: 0x001B3B7F File Offset: 0x001B1D7F
		static ConfigSolarSchoolRoleTalkByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleTalkByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleTalkByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x001B3BA0 File Offset: 0x001B1DA0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleTalkByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleTalkByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleTalk"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleTalk` where ActivityId=?")
			});
		}

		// Token: 0x06003CB2 RID: 15538 RVA: 0x001B3C1F File Offset: 0x001B1E1F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleTalkByActivityId.LogPair = null;
			ConfigSolarSchoolRoleTalkByActivityId.HandleId = 0;
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x001B3C2D File Offset: 0x001B1E2D
		public static void Init()
		{
			ConfigSolarSchoolRoleTalkByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleTalkByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleTalk` where ActivityId=?");
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x001B3C48 File Offset: 0x001B1E48
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRoleTalk> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleTalkByActivityId.HandleId, ConfigSolarSchoolRoleTalkByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleTalkByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolRoleTalk> readOnlyList = (IReadOnlyList<SolarSchoolRoleTalk>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolRoleTalkByActivityId.LogPair.Clear();
			ConfigSolarSchoolRoleTalkByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRoleTalkByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolRoleTalkByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleTalkByActivityId.HandleId, ConfigSolarSchoolRoleTalkByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolRoleTalk> list = new List<SolarSchoolRoleTalk>();
			while (ConfigCommon.Step(ConfigSolarSchoolRoleTalkByActivityId.HandleId, false, ConfigSolarSchoolRoleTalkByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleTalkByActivityId.HandleId, 0, ConfigSolarSchoolRoleTalkByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRoleTalkByActivityId.HandleId, ConfigSolarSchoolRoleTalkByActivityId.LogPair);
					return null;
				}
				SolarSchoolRoleTalk rootAsSolarSchoolRoleTalk = SolarSchoolRoleTalk.GetRootAsSolarSchoolRoleTalk(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRoleTalk);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleTalkByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleTalkByActivityId.HandleId, ConfigSolarSchoolRoleTalkByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400469C RID: 18076
		private const string DB = "db_solarschool.db";

		// Token: 0x0400469D RID: 18077
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x0400469E RID: 18078
		private const string TABLE = "SolarSchoolRoleTalk";

		// Token: 0x0400469F RID: 18079
		private const string COMMAND = "select BinData from `SolarSchoolRoleTalk` where ActivityId=?";

		// Token: 0x040046A0 RID: 18080
		private const string KEY_PREFIX = "SolarSchoolRoleTalkByActivityId";

		// Token: 0x040046A1 RID: 18081
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046A2 RID: 18082
		private static int HandleId;
	}
}

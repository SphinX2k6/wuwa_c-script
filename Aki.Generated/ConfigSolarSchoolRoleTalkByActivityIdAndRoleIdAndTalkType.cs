using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A1B RID: 2587
	public class ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CB6 RID: 15542 RVA: 0x001B3DB7 File Offset: 0x001B1FB7
		static ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.ResetStaticDefaultValue));
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x001B3DD8 File Offset: 0x001B1FD8
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleTalk"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleTalk` where ActivityId=? and RoleId=? and TalkType=?")
			});
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x001B3E57 File Offset: 0x001B2057
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair = null;
			ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.HandleId = 0;
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x001B3E65 File Offset: 0x001B2065
		public static void Init()
		{
			ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleTalk` where ActivityId=? and RoleId=? and TalkType=?");
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x001B3E80 File Offset: 0x001B2080
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRoleTalk> GetConfigList(int p0ActivityId, int p1RoleId, int p2TalkType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.HandleId, ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2TalkType);
				IReadOnlyList<SolarSchoolRoleTalk> readOnlyList = (IReadOnlyList<SolarSchoolRoleTalk>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair.Clear();
			ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair.Add(new ValueTuple<string, object>("RoleId", p1RoleId));
			ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair.Add(new ValueTuple<string, object>("TalkType", p2TalkType));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.HandleId, 1, p0ActivityId, ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair) || !ConfigCommon.BindInt(ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.HandleId, 2, p1RoleId, ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair) || !ConfigCommon.BindInt(ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.HandleId, 3, p2TalkType, ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.HandleId, ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair);
				return null;
			}
			List<SolarSchoolRoleTalk> list = new List<SolarSchoolRoleTalk>();
			while (ConfigCommon.Step(ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.HandleId, false, ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.HandleId, 0, ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.HandleId, ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair);
					return null;
				}
				SolarSchoolRoleTalk rootAsSolarSchoolRoleTalk = SolarSchoolRoleTalk.GetRootAsSolarSchoolRoleTalk(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRoleTalk);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2TalkType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.HandleId, ConfigSolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType.LogPair);
			return list;
		}

		// Token: 0x040046A3 RID: 18083
		private const string DB = "db_solarschool.db";

		// Token: 0x040046A4 RID: 18084
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x040046A5 RID: 18085
		private const string TABLE = "SolarSchoolRoleTalk";

		// Token: 0x040046A6 RID: 18086
		private const string COMMAND = "select BinData from `SolarSchoolRoleTalk` where ActivityId=? and RoleId=? and TalkType=?";

		// Token: 0x040046A7 RID: 18087
		private const string KEY_PREFIX = "SolarSchoolRoleTalkByActivityIdAndRoleIdAndTalkType";

		// Token: 0x040046A8 RID: 18088
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046A9 RID: 18089
		private static int HandleId;
	}
}

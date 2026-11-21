using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A12 RID: 2578
	public class ConfigSolarSchoolRoleFavorLevelByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C80 RID: 15488 RVA: 0x001B2A83 File Offset: 0x001B0C83
		static ConfigSolarSchoolRoleFavorLevelByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleFavorLevelByRoleId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleFavorLevelByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x001B2AA4 File Offset: 0x001B0CA4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleFavorLevelByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleFavorLevelByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleFavorLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleFavorLevel` where RoleId=?")
			});
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x001B2B23 File Offset: 0x001B0D23
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleFavorLevelByRoleId.LogPair = null;
			ConfigSolarSchoolRoleFavorLevelByRoleId.HandleId = 0;
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x001B2B31 File Offset: 0x001B0D31
		public static void Init()
		{
			ConfigSolarSchoolRoleFavorLevelByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleFavorLevelByRoleId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleFavorLevel` where RoleId=?");
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x001B2B4C File Offset: 0x001B0D4C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRoleFavorLevel> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleFavorLevelByRoleId.HandleId, ConfigSolarSchoolRoleFavorLevelByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleFavorLevelByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<SolarSchoolRoleFavorLevel> readOnlyList = (IReadOnlyList<SolarSchoolRoleFavorLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolRoleFavorLevelByRoleId.LogPair.Clear();
			ConfigSolarSchoolRoleFavorLevelByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRoleFavorLevelByRoleId.HandleId, 1, p0RoleId, ConfigSolarSchoolRoleFavorLevelByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleFavorLevelByRoleId.HandleId, ConfigSolarSchoolRoleFavorLevelByRoleId.LogPair);
				return null;
			}
			List<SolarSchoolRoleFavorLevel> list = new List<SolarSchoolRoleFavorLevel>();
			while (ConfigCommon.Step(ConfigSolarSchoolRoleFavorLevelByRoleId.HandleId, false, ConfigSolarSchoolRoleFavorLevelByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleFavorLevelByRoleId.HandleId, 0, ConfigSolarSchoolRoleFavorLevelByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRoleFavorLevelByRoleId.HandleId, ConfigSolarSchoolRoleFavorLevelByRoleId.LogPair);
					return null;
				}
				SolarSchoolRoleFavorLevel rootAsSolarSchoolRoleFavorLevel = SolarSchoolRoleFavorLevel.GetRootAsSolarSchoolRoleFavorLevel(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRoleFavorLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleFavorLevelByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleFavorLevelByRoleId.HandleId, ConfigSolarSchoolRoleFavorLevelByRoleId.LogPair);
			return list;
		}

		// Token: 0x04004664 RID: 18020
		private const string DB = "db_solarschool.db";

		// Token: 0x04004665 RID: 18021
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x04004666 RID: 18022
		private const string TABLE = "SolarSchoolRoleFavorLevel";

		// Token: 0x04004667 RID: 18023
		private const string COMMAND = "select BinData from `SolarSchoolRoleFavorLevel` where RoleId=?";

		// Token: 0x04004668 RID: 18024
		private const string KEY_PREFIX = "SolarSchoolRoleFavorLevelByRoleId";

		// Token: 0x04004669 RID: 18025
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400466A RID: 18026
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A0C RID: 2572
	public class ConfigSolarSchoolRoleByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C5C RID: 15452 RVA: 0x001B1E6B File Offset: 0x001B006B
		static ConfigSolarSchoolRoleByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x001B1E8C File Offset: 0x001B008C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRole"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRole` where ActivityId=?")
			});
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x001B1F0B File Offset: 0x001B010B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleByActivityId.LogPair = null;
			ConfigSolarSchoolRoleByActivityId.HandleId = 0;
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x001B1F19 File Offset: 0x001B0119
		public static void Init()
		{
			ConfigSolarSchoolRoleByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRole` where ActivityId=?");
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x001B1F34 File Offset: 0x001B0134
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRole> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleByActivityId.HandleId, ConfigSolarSchoolRoleByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolRole> readOnlyList = (IReadOnlyList<SolarSchoolRole>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolRoleByActivityId.LogPair.Clear();
			ConfigSolarSchoolRoleByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRoleByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolRoleByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleByActivityId.HandleId, ConfigSolarSchoolRoleByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolRole> list = new List<SolarSchoolRole>();
			while (ConfigCommon.Step(ConfigSolarSchoolRoleByActivityId.HandleId, false, ConfigSolarSchoolRoleByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleByActivityId.HandleId, 0, ConfigSolarSchoolRoleByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRoleByActivityId.HandleId, ConfigSolarSchoolRoleByActivityId.LogPair);
					return null;
				}
				SolarSchoolRole rootAsSolarSchoolRole = SolarSchoolRole.GetRootAsSolarSchoolRole(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRole);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleByActivityId.HandleId, ConfigSolarSchoolRoleByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400463A RID: 17978
		private const string DB = "db_solarschool.db";

		// Token: 0x0400463B RID: 17979
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x0400463C RID: 17980
		private const string TABLE = "SolarSchoolRole";

		// Token: 0x0400463D RID: 17981
		private const string COMMAND = "select BinData from `SolarSchoolRole` where ActivityId=?";

		// Token: 0x0400463E RID: 17982
		private const string KEY_PREFIX = "SolarSchoolRoleByActivityId";

		// Token: 0x0400463F RID: 17983
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004640 RID: 17984
		private static int HandleId;
	}
}

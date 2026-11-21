using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A0F RID: 2575
	public class ConfigSolarSchoolRoleFavorByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C6E RID: 15470 RVA: 0x001B247F File Offset: 0x001B067F
		static ConfigSolarSchoolRoleFavorByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleFavorByRoleId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleFavorByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x001B24A0 File Offset: 0x001B06A0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleFavorByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleFavorByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleFavor"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleFavor` where RoleId=?")
			});
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x001B251F File Offset: 0x001B071F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleFavorByRoleId.LogPair = null;
			ConfigSolarSchoolRoleFavorByRoleId.HandleId = 0;
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x001B252D File Offset: 0x001B072D
		public static void Init()
		{
			ConfigSolarSchoolRoleFavorByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleFavorByRoleId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleFavor` where RoleId=?");
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x001B2548 File Offset: 0x001B0748
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRoleFavor> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleFavorByRoleId.HandleId, ConfigSolarSchoolRoleFavorByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleFavorByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<SolarSchoolRoleFavor> readOnlyList = (IReadOnlyList<SolarSchoolRoleFavor>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolRoleFavorByRoleId.LogPair.Clear();
			ConfigSolarSchoolRoleFavorByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRoleFavorByRoleId.HandleId, 1, p0RoleId, ConfigSolarSchoolRoleFavorByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleFavorByRoleId.HandleId, ConfigSolarSchoolRoleFavorByRoleId.LogPair);
				return null;
			}
			List<SolarSchoolRoleFavor> list = new List<SolarSchoolRoleFavor>();
			while (ConfigCommon.Step(ConfigSolarSchoolRoleFavorByRoleId.HandleId, false, ConfigSolarSchoolRoleFavorByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleFavorByRoleId.HandleId, 0, ConfigSolarSchoolRoleFavorByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRoleFavorByRoleId.HandleId, ConfigSolarSchoolRoleFavorByRoleId.LogPair);
					return null;
				}
				SolarSchoolRoleFavor rootAsSolarSchoolRoleFavor = SolarSchoolRoleFavor.GetRootAsSolarSchoolRoleFavor(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRoleFavor);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleFavorByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleFavorByRoleId.HandleId, ConfigSolarSchoolRoleFavorByRoleId.LogPair);
			return list;
		}

		// Token: 0x0400464F RID: 17999
		private const string DB = "db_solarschool.db";

		// Token: 0x04004650 RID: 18000
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x04004651 RID: 18001
		private const string TABLE = "SolarSchoolRoleFavor";

		// Token: 0x04004652 RID: 18002
		private const string COMMAND = "select BinData from `SolarSchoolRoleFavor` where RoleId=?";

		// Token: 0x04004653 RID: 18003
		private const string KEY_PREFIX = "SolarSchoolRoleFavorByRoleId";

		// Token: 0x04004654 RID: 18004
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004655 RID: 18005
		private static int HandleId;
	}
}

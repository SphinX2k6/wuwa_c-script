using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D6 RID: 2262
	public class ConfigRoleMorphByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003517 RID: 13591 RVA: 0x00188BDC File Offset: 0x00186DDC
		static ConfigRoleMorphByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleMorphByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleMorphByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x00188BFC File Offset: 0x00186DFC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleMorphByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleMorphByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleMorph"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleMorph` where RoleId=?")
			});
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x00188C7B File Offset: 0x00186E7B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleMorphByRoleId.LogPair = null;
			ConfigRoleMorphByRoleId.HandleId = 0;
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x00188C89 File Offset: 0x00186E89
		public static void Init()
		{
			ConfigRoleMorphByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleMorphByRoleId.HandleId, "db_role.db", "select BinData from `RoleMorph` where RoleId=?");
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x00188CA4 File Offset: 0x00186EA4
		[NullableContext(2)]
		public static IReadOnlyList<RoleMorph> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleMorphByRoleId.HandleId, ConfigRoleMorphByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleMorphByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<RoleMorph> readOnlyList = (IReadOnlyList<RoleMorph>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleMorphByRoleId.LogPair.Clear();
			ConfigRoleMorphByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleMorphByRoleId.HandleId, 1, p0RoleId, ConfigRoleMorphByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleMorphByRoleId.HandleId, ConfigRoleMorphByRoleId.LogPair);
				return null;
			}
			List<RoleMorph> list = new List<RoleMorph>();
			while (ConfigCommon.Step(ConfigRoleMorphByRoleId.HandleId, false, ConfigRoleMorphByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleMorphByRoleId.HandleId, 0, ConfigRoleMorphByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleMorphByRoleId.HandleId, ConfigRoleMorphByRoleId.LogPair);
					return null;
				}
				RoleMorph rootAsRoleMorph = RoleMorph.GetRootAsRoleMorph(new ByteBuffer(item2));
				list.Add(rootAsRoleMorph);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleMorphByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleMorphByRoleId.HandleId, ConfigRoleMorphByRoleId.LogPair);
			return list;
		}

		// Token: 0x04003DC0 RID: 15808
		private const string DB = "db_role.db";

		// Token: 0x04003DC1 RID: 15809
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003DC2 RID: 15810
		private const string TABLE = "RoleMorph";

		// Token: 0x04003DC3 RID: 15811
		private const string COMMAND = "select BinData from `RoleMorph` where RoleId=?";

		// Token: 0x04003DC4 RID: 15812
		private const string KEY_PREFIX = "RoleMorphByRoleId";

		// Token: 0x04003DC5 RID: 15813
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DC6 RID: 15814
		private static int HandleId;
	}
}

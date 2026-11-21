using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E4 RID: 2276
	public class ConfigRoleSkinByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600356B RID: 13675 RVA: 0x0018AB2C File Offset: 0x00188D2C
		static ConfigRoleSkinByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleSkinByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x0018AB4C File Offset: 0x00188D4C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkin` where RoleId=?")
			});
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x0018ABCB File Offset: 0x00188DCB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinByRoleId.LogPair = null;
			ConfigRoleSkinByRoleId.HandleId = 0;
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x0018ABD9 File Offset: 0x00188DD9
		public static void Init()
		{
			ConfigRoleSkinByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinByRoleId.HandleId, "db_role.db", "select BinData from `RoleSkin` where RoleId=?");
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x0018ABF4 File Offset: 0x00188DF4
		[NullableContext(2)]
		public static IReadOnlyList<RoleSkin> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinByRoleId.HandleId, ConfigRoleSkinByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<RoleSkin> readOnlyList = (IReadOnlyList<RoleSkin>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleSkinByRoleId.LogPair.Clear();
			ConfigRoleSkinByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleSkinByRoleId.HandleId, 1, p0RoleId, ConfigRoleSkinByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleSkinByRoleId.HandleId, ConfigRoleSkinByRoleId.LogPair);
				return null;
			}
			List<RoleSkin> list = new List<RoleSkin>();
			while (ConfigCommon.Step(ConfigRoleSkinByRoleId.HandleId, false, ConfigRoleSkinByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinByRoleId.HandleId, 0, ConfigRoleSkinByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleSkinByRoleId.HandleId, ConfigRoleSkinByRoleId.LogPair);
					return null;
				}
				RoleSkin rootAsRoleSkin = RoleSkin.GetRootAsRoleSkin(new ByteBuffer(item2));
				list.Add(rootAsRoleSkin);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleSkinByRoleId.HandleId, ConfigRoleSkinByRoleId.LogPair);
			return list;
		}

		// Token: 0x04003E22 RID: 15906
		private const string DB = "db_role.db";

		// Token: 0x04003E23 RID: 15907
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003E24 RID: 15908
		private const string TABLE = "RoleSkin";

		// Token: 0x04003E25 RID: 15909
		private const string COMMAND = "select BinData from `RoleSkin` where RoleId=?";

		// Token: 0x04003E26 RID: 15910
		private const string KEY_PREFIX = "RoleSkinByRoleId";

		// Token: 0x04003E27 RID: 15911
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E28 RID: 15912
		private static int HandleId;
	}
}

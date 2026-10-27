using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C8 RID: 2248
	public class ConfigRoleSkinByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034C3 RID: 13507 RVA: 0x00183844 File Offset: 0x00181A44
		static ConfigRoleSkinByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleSkinByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00183864 File Offset: 0x00181A64
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

		// Token: 0x060034C5 RID: 13509 RVA: 0x001838E3 File Offset: 0x00181AE3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinByRoleId.LogPair = null;
			ConfigRoleSkinByRoleId.HandleId = 0;
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x001838F1 File Offset: 0x00181AF1
		public static void Init()
		{
			ConfigRoleSkinByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinByRoleId.HandleId, "db_role.db", "select BinData from `RoleSkin` where RoleId=?");
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x0018390C File Offset: 0x00181B0C
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

		// Token: 0x04003D5E RID: 15710
		private const string DB = "db_role.db";

		// Token: 0x04003D5F RID: 15711
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003D60 RID: 15712
		private const string TABLE = "RoleSkin";

		// Token: 0x04003D61 RID: 15713
		private const string COMMAND = "select BinData from `RoleSkin` where RoleId=?";

		// Token: 0x04003D62 RID: 15714
		private const string KEY_PREFIX = "RoleSkinByRoleId";

		// Token: 0x04003D63 RID: 15715
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D64 RID: 15716
		private static int HandleId;
	}
}

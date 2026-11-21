using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E5 RID: 2277
	public class ConfigRoleSkinByRoleIdAndGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003571 RID: 13681 RVA: 0x0018AD63 File Offset: 0x00188F63
		static ConfigRoleSkinByRoleIdAndGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinByRoleIdAndGroupId.CreateStaticDefaultValue), new Action(ConfigRoleSkinByRoleIdAndGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x0018AD84 File Offset: 0x00188F84
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinByRoleIdAndGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinByRoleIdAndGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkin` where RoleId=? AND GroupId=?")
			});
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x0018AE03 File Offset: 0x00189003
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinByRoleIdAndGroupId.LogPair = null;
			ConfigRoleSkinByRoleIdAndGroupId.HandleId = 0;
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x0018AE11 File Offset: 0x00189011
		public static void Init()
		{
			ConfigRoleSkinByRoleIdAndGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinByRoleIdAndGroupId.HandleId, "db_role.db", "select BinData from `RoleSkin` where RoleId=? AND GroupId=?");
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x0018AE2C File Offset: 0x0018902C
		public static RoleSkin? GetConfig(int p0RoleId, int p1GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinByRoleIdAndGroupId.HandleId, ConfigRoleSkinByRoleIdAndGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinByRoleIdAndGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleSkin?(RoleSkin.GetRootAsRoleSkin(configBuffer));
				}
			}
			ConfigRoleSkinByRoleIdAndGroupId.LogPair.Clear();
			ConfigRoleSkinByRoleIdAndGroupId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			ConfigRoleSkinByRoleIdAndGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p1GroupId));
			if (!ConfigCommon.BindInt(ConfigRoleSkinByRoleIdAndGroupId.HandleId, 1, p0RoleId, ConfigRoleSkinByRoleIdAndGroupId.LogPair) || !ConfigCommon.BindInt(ConfigRoleSkinByRoleIdAndGroupId.HandleId, 2, p1GroupId, ConfigRoleSkinByRoleIdAndGroupId.LogPair) || ConfigCommon.Step(ConfigRoleSkinByRoleIdAndGroupId.HandleId, true, ConfigRoleSkinByRoleIdAndGroupId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleSkinByRoleIdAndGroupId.HandleId, ConfigRoleSkinByRoleIdAndGroupId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinByRoleIdAndGroupId.HandleId, 0, ConfigRoleSkinByRoleIdAndGroupId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleSkinByRoleIdAndGroupId.HandleId, ConfigRoleSkinByRoleIdAndGroupId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleSkin rootAsRoleSkin = RoleSkin.GetRootAsRoleSkin(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinByRoleIdAndGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleSkinByRoleIdAndGroupId.HandleId, ConfigRoleSkinByRoleIdAndGroupId.LogPair);
			return new RoleSkin?(rootAsRoleSkin);
		}

		// Token: 0x04003E29 RID: 15913
		private const string DB = "db_role.db";

		// Token: 0x04003E2A RID: 15914
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003E2B RID: 15915
		private const string TABLE = "RoleSkin";

		// Token: 0x04003E2C RID: 15916
		private const string COMMAND = "select BinData from `RoleSkin` where RoleId=? AND GroupId=?";

		// Token: 0x04003E2D RID: 15917
		private const string KEY_PREFIX = "RoleSkinByRoleIdAndGroupId";

		// Token: 0x04003E2E RID: 15918
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E2F RID: 15919
		private static int HandleId;
	}
}

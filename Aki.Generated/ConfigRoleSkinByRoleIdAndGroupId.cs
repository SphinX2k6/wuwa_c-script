using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C9 RID: 2249
	public class ConfigRoleSkinByRoleIdAndGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034C9 RID: 13513 RVA: 0x00183A7B File Offset: 0x00181C7B
		static ConfigRoleSkinByRoleIdAndGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinByRoleIdAndGroupId.CreateStaticDefaultValue), new Action(ConfigRoleSkinByRoleIdAndGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x00183A9C File Offset: 0x00181C9C
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

		// Token: 0x060034CB RID: 13515 RVA: 0x00183B1B File Offset: 0x00181D1B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinByRoleIdAndGroupId.LogPair = null;
			ConfigRoleSkinByRoleIdAndGroupId.HandleId = 0;
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x00183B29 File Offset: 0x00181D29
		public static void Init()
		{
			ConfigRoleSkinByRoleIdAndGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinByRoleIdAndGroupId.HandleId, "db_role.db", "select BinData from `RoleSkin` where RoleId=? AND GroupId=?");
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x00183B44 File Offset: 0x00181D44
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

		// Token: 0x04003D65 RID: 15717
		private const string DB = "db_role.db";

		// Token: 0x04003D66 RID: 15718
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003D67 RID: 15719
		private const string TABLE = "RoleSkin";

		// Token: 0x04003D68 RID: 15720
		private const string COMMAND = "select BinData from `RoleSkin` where RoleId=? AND GroupId=?";

		// Token: 0x04003D69 RID: 15721
		private const string KEY_PREFIX = "RoleSkinByRoleIdAndGroupId";

		// Token: 0x04003D6A RID: 15722
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D6B RID: 15723
		private static int HandleId;
	}
}

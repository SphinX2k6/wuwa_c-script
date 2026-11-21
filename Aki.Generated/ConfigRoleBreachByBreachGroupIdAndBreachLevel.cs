using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008AA RID: 2218
	public class ConfigRoleBreachByBreachGroupIdAndBreachLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600340E RID: 13326 RVA: 0x001831CF File Offset: 0x001813CF
		static ConfigRoleBreachByBreachGroupIdAndBreachLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBreachByBreachGroupIdAndBreachLevel.CreateStaticDefaultValue), new Action(ConfigRoleBreachByBreachGroupIdAndBreachLevel.ResetStaticDefaultValue));
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x001831F0 File Offset: 0x001813F0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role_level.db"),
				new ValueTuple<string, object>("文件", "j.角色升级突破.xlsx"),
				new ValueTuple<string, object>("表名", "RoleBreach"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleBreach` where BreachGroupId=? AND BreachLevel=?")
			});
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x0018326F File Offset: 0x0018146F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair = null;
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId = 0;
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x0018327D File Offset: 0x0018147D
		public static void Init()
		{
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, "db_role_level.db", "select BinData from `RoleBreach` where BreachGroupId=? AND BreachLevel=?");
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x00183298 File Offset: 0x00181498
		public static RoleBreach? GetConfig(int p0BreachGroupId, int p1BreachLevel, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBreachByBreachGroupIdAndBreachLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BreachGroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1BreachLevel);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleBreach?(RoleBreach.GetRootAsRoleBreach(configBuffer));
				}
			}
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair.Clear();
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair.Add(new ValueTuple<string, object>("BreachGroupId", p0BreachGroupId));
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair.Add(new ValueTuple<string, object>("BreachLevel", p1BreachLevel));
			if (!ConfigCommon.BindInt(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, 1, p0BreachGroupId, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair) || !ConfigCommon.BindInt(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, 2, p1BreachLevel, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair) || ConfigCommon.Step(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, true, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, 0, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleBreach rootAsRoleBreach = RoleBreach.GetRootAsRoleBreach(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBreachByBreachGroupIdAndBreachLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BreachGroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1BreachLevel);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair);
			return new RoleBreach?(rootAsRoleBreach);
		}

		// Token: 0x04003C8C RID: 15500
		private const string DB = "db_role_level.db";

		// Token: 0x04003C8D RID: 15501
		private const string FILE = "j.角色升级突破.xlsx";

		// Token: 0x04003C8E RID: 15502
		private const string TABLE = "RoleBreach";

		// Token: 0x04003C8F RID: 15503
		private const string COMMAND = "select BinData from `RoleBreach` where BreachGroupId=? AND BreachLevel=?";

		// Token: 0x04003C90 RID: 15504
		private const string KEY_PREFIX = "RoleBreachByBreachGroupIdAndBreachLevel";

		// Token: 0x04003C91 RID: 15505
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C92 RID: 15506
		private static int HandleId;
	}
}

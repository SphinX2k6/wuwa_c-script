using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A9 RID: 2217
	public class ConfigRoleBreachByBreachGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003408 RID: 13320 RVA: 0x00182F99 File Offset: 0x00181199
		static ConfigRoleBreachByBreachGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBreachByBreachGroupId.CreateStaticDefaultValue), new Action(ConfigRoleBreachByBreachGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00182FB8 File Offset: 0x001811B8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleBreachByBreachGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleBreachByBreachGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role_level.db"),
				new ValueTuple<string, object>("文件", "j.角色升级突破.xlsx"),
				new ValueTuple<string, object>("表名", "RoleBreach"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleBreach` where BreachGroupId=?")
			});
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x00183037 File Offset: 0x00181237
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBreachByBreachGroupId.LogPair = null;
			ConfigRoleBreachByBreachGroupId.HandleId = 0;
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x00183045 File Offset: 0x00181245
		public static void Init()
		{
			ConfigRoleBreachByBreachGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBreachByBreachGroupId.HandleId, "db_role_level.db", "select BinData from `RoleBreach` where BreachGroupId=?");
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x00183060 File Offset: 0x00181260
		[NullableContext(2)]
		public static IReadOnlyList<RoleBreach> GetConfigList(int p0BreachGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleBreachByBreachGroupId.HandleId, ConfigRoleBreachByBreachGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBreachByBreachGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BreachGroupId);
				IReadOnlyList<RoleBreach> readOnlyList = (IReadOnlyList<RoleBreach>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleBreachByBreachGroupId.LogPair.Clear();
			ConfigRoleBreachByBreachGroupId.LogPair.Add(new ValueTuple<string, object>("BreachGroupId", p0BreachGroupId));
			if (!ConfigCommon.BindInt(ConfigRoleBreachByBreachGroupId.HandleId, 1, p0BreachGroupId, ConfigRoleBreachByBreachGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleBreachByBreachGroupId.HandleId, ConfigRoleBreachByBreachGroupId.LogPair);
				return null;
			}
			List<RoleBreach> list = new List<RoleBreach>();
			while (ConfigCommon.Step(ConfigRoleBreachByBreachGroupId.HandleId, false, ConfigRoleBreachByBreachGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleBreachByBreachGroupId.HandleId, 0, ConfigRoleBreachByBreachGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleBreachByBreachGroupId.HandleId, ConfigRoleBreachByBreachGroupId.LogPair);
					return null;
				}
				RoleBreach rootAsRoleBreach = RoleBreach.GetRootAsRoleBreach(new ByteBuffer(item2));
				list.Add(rootAsRoleBreach);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBreachByBreachGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BreachGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleBreachByBreachGroupId.HandleId, ConfigRoleBreachByBreachGroupId.LogPair);
			return list;
		}

		// Token: 0x04003C85 RID: 15493
		private const string DB = "db_role_level.db";

		// Token: 0x04003C86 RID: 15494
		private const string FILE = "j.角色升级突破.xlsx";

		// Token: 0x04003C87 RID: 15495
		private const string TABLE = "RoleBreach";

		// Token: 0x04003C88 RID: 15496
		private const string COMMAND = "select BinData from `RoleBreach` where BreachGroupId=?";

		// Token: 0x04003C89 RID: 15497
		private const string KEY_PREFIX = "RoleBreachByBreachGroupId";

		// Token: 0x04003C8A RID: 15498
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C8B RID: 15499
		private static int HandleId;
	}
}

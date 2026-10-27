using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A9 RID: 2217
	public class ConfigRoleGiftConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003409 RID: 13321 RVA: 0x0017F670 File Offset: 0x0017D870
		static ConfigRoleGiftConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleGiftConfigById.CreateStaticDefaultValue), new Action(ConfigRoleGiftConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x0017F690 File Offset: 0x0017D890
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleGiftConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleGiftConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rolegift.db"),
				new ValueTuple<string, object>("文件", "j.角色赠礼活动.xlsx"),
				new ValueTuple<string, object>("表名", "RoleGiftConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleGiftConfig` where Id=?")
			});
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x0017F70F File Offset: 0x0017D90F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleGiftConfigById.LogPair = null;
			ConfigRoleGiftConfigById.HandleId = 0;
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x0017F71D File Offset: 0x0017D91D
		public static void Init()
		{
			ConfigRoleGiftConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleGiftConfigById.HandleId, "db_rolegift.db", "select BinData from `RoleGiftConfig` where Id=?");
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x0017F738 File Offset: 0x0017D938
		public static RoleGiftConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleGiftConfigById.HandleId, ConfigRoleGiftConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleGiftConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleGiftConfig?(RoleGiftConfig.GetRootAsRoleGiftConfig(configBuffer));
				}
			}
			ConfigRoleGiftConfigById.LogPair.Clear();
			ConfigRoleGiftConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleGiftConfigById.HandleId, 1, p0Id, ConfigRoleGiftConfigById.LogPair) || ConfigCommon.Step(ConfigRoleGiftConfigById.HandleId, true, ConfigRoleGiftConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleGiftConfigById.HandleId, ConfigRoleGiftConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleGiftConfigById.HandleId, 0, ConfigRoleGiftConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleGiftConfigById.HandleId, ConfigRoleGiftConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleGiftConfig rootAsRoleGiftConfig = RoleGiftConfig.GetRootAsRoleGiftConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleGiftConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleGiftConfigById.HandleId, ConfigRoleGiftConfigById.LogPair);
			return new RoleGiftConfig?(rootAsRoleGiftConfig);
		}

		// Token: 0x04003C85 RID: 15493
		private const string DB = "db_rolegift.db";

		// Token: 0x04003C86 RID: 15494
		private const string FILE = "j.角色赠礼活动.xlsx";

		// Token: 0x04003C87 RID: 15495
		private const string TABLE = "RoleGiftConfig";

		// Token: 0x04003C88 RID: 15496
		private const string COMMAND = "select BinData from `RoleGiftConfig` where Id=?";

		// Token: 0x04003C89 RID: 15497
		private const string KEY_PREFIX = "RoleGiftConfigById";

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

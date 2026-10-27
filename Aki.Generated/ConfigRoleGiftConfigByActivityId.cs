using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A8 RID: 2216
	public class ConfigRoleGiftConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003403 RID: 13315 RVA: 0x0017F427 File Offset: 0x0017D627
		static ConfigRoleGiftConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleGiftConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigRoleGiftConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x0017F448 File Offset: 0x0017D648
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleGiftConfigByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleGiftConfigByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rolegift.db"),
				new ValueTuple<string, object>("文件", "j.角色赠礼活动.xlsx"),
				new ValueTuple<string, object>("表名", "RoleGiftConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleGiftConfig` where ActivityId=?")
			});
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x0017F4C7 File Offset: 0x0017D6C7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleGiftConfigByActivityId.LogPair = null;
			ConfigRoleGiftConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x0017F4D5 File Offset: 0x0017D6D5
		public static void Init()
		{
			ConfigRoleGiftConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleGiftConfigByActivityId.HandleId, "db_rolegift.db", "select BinData from `RoleGiftConfig` where ActivityId=?");
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x0017F4F0 File Offset: 0x0017D6F0
		public static RoleGiftConfig? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleGiftConfigByActivityId.HandleId, ConfigRoleGiftConfigByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleGiftConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleGiftConfig?(RoleGiftConfig.GetRootAsRoleGiftConfig(configBuffer));
				}
			}
			ConfigRoleGiftConfigByActivityId.LogPair.Clear();
			ConfigRoleGiftConfigByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoleGiftConfigByActivityId.HandleId, 1, p0ActivityId, ConfigRoleGiftConfigByActivityId.LogPair) || ConfigCommon.Step(ConfigRoleGiftConfigByActivityId.HandleId, true, ConfigRoleGiftConfigByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleGiftConfigByActivityId.HandleId, ConfigRoleGiftConfigByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleGiftConfigByActivityId.HandleId, 0, ConfigRoleGiftConfigByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleGiftConfigByActivityId.HandleId, ConfigRoleGiftConfigByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleGiftConfig rootAsRoleGiftConfig = RoleGiftConfig.GetRootAsRoleGiftConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleGiftConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleGiftConfigByActivityId.HandleId, ConfigRoleGiftConfigByActivityId.LogPair);
			return new RoleGiftConfig?(rootAsRoleGiftConfig);
		}

		// Token: 0x04003C7E RID: 15486
		private const string DB = "db_rolegift.db";

		// Token: 0x04003C7F RID: 15487
		private const string FILE = "j.角色赠礼活动.xlsx";

		// Token: 0x04003C80 RID: 15488
		private const string TABLE = "RoleGiftConfig";

		// Token: 0x04003C81 RID: 15489
		private const string COMMAND = "select BinData from `RoleGiftConfig` where ActivityId=?";

		// Token: 0x04003C82 RID: 15490
		private const string KEY_PREFIX = "RoleGiftConfigByActivityId";

		// Token: 0x04003C83 RID: 15491
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C84 RID: 15492
		private static int HandleId;
	}
}

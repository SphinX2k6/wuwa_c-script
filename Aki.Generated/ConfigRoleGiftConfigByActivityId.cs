using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C4 RID: 2244
	public class ConfigRoleGiftConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034AB RID: 13483 RVA: 0x0018670F File Offset: 0x0018490F
		static ConfigRoleGiftConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleGiftConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigRoleGiftConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x00186730 File Offset: 0x00184930
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

		// Token: 0x060034AD RID: 13485 RVA: 0x001867AF File Offset: 0x001849AF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleGiftConfigByActivityId.LogPair = null;
			ConfigRoleGiftConfigByActivityId.HandleId = 0;
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x001867BD File Offset: 0x001849BD
		public static void Init()
		{
			ConfigRoleGiftConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleGiftConfigByActivityId.HandleId, "db_rolegift.db", "select BinData from `RoleGiftConfig` where ActivityId=?");
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x001867D8 File Offset: 0x001849D8
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

		// Token: 0x04003D42 RID: 15682
		private const string DB = "db_rolegift.db";

		// Token: 0x04003D43 RID: 15683
		private const string FILE = "j.角色赠礼活动.xlsx";

		// Token: 0x04003D44 RID: 15684
		private const string TABLE = "RoleGiftConfig";

		// Token: 0x04003D45 RID: 15685
		private const string COMMAND = "select BinData from `RoleGiftConfig` where ActivityId=?";

		// Token: 0x04003D46 RID: 15686
		private const string KEY_PREFIX = "RoleGiftConfigByActivityId";

		// Token: 0x04003D47 RID: 15687
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D48 RID: 15688
		private static int HandleId;
	}
}

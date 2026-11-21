using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C5 RID: 2245
	public class ConfigRoleGiftConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034B1 RID: 13489 RVA: 0x00186958 File Offset: 0x00184B58
		static ConfigRoleGiftConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleGiftConfigById.CreateStaticDefaultValue), new Action(ConfigRoleGiftConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x00186978 File Offset: 0x00184B78
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

		// Token: 0x060034B3 RID: 13491 RVA: 0x001869F7 File Offset: 0x00184BF7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleGiftConfigById.LogPair = null;
			ConfigRoleGiftConfigById.HandleId = 0;
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00186A05 File Offset: 0x00184C05
		public static void Init()
		{
			ConfigRoleGiftConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleGiftConfigById.HandleId, "db_rolegift.db", "select BinData from `RoleGiftConfig` where Id=?");
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x00186A20 File Offset: 0x00184C20
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

		// Token: 0x04003D49 RID: 15689
		private const string DB = "db_rolegift.db";

		// Token: 0x04003D4A RID: 15690
		private const string FILE = "j.角色赠礼活动.xlsx";

		// Token: 0x04003D4B RID: 15691
		private const string TABLE = "RoleGiftConfig";

		// Token: 0x04003D4C RID: 15692
		private const string COMMAND = "select BinData from `RoleGiftConfig` where Id=?";

		// Token: 0x04003D4D RID: 15693
		private const string KEY_PREFIX = "RoleGiftConfigById";

		// Token: 0x04003D4E RID: 15694
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D4F RID: 15695
		private static int HandleId;
	}
}

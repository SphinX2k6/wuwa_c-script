using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C1 RID: 2241
	public class ConfigRoleDevWeaponJumpGroupByWeaponId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003498 RID: 13464 RVA: 0x00185F83 File Offset: 0x00184183
		static ConfigRoleDevWeaponJumpGroupByWeaponId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevWeaponJumpGroupByWeaponId.CreateStaticDefaultValue), new Action(ConfigRoleDevWeaponJumpGroupByWeaponId.ResetStaticDefaultValue));
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x00185FA4 File Offset: 0x001841A4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevWeaponJumpGroupByWeaponId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevWeaponJumpGroupByWeaponId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevWeaponJumpGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevWeaponJumpGroup` where WeaponId=?")
			});
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x00186023 File Offset: 0x00184223
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevWeaponJumpGroupByWeaponId.LogPair = null;
			ConfigRoleDevWeaponJumpGroupByWeaponId.HandleId = 0;
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x00186031 File Offset: 0x00184231
		public static void Init()
		{
			ConfigRoleDevWeaponJumpGroupByWeaponId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevWeaponJumpGroupByWeaponId.HandleId, "db_roledev.db", "select BinData from `RoleDevWeaponJumpGroup` where WeaponId=?");
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x0018604C File Offset: 0x0018424C
		public static RoleDevWeaponJumpGroup? GetConfig(int p0WeaponId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevWeaponJumpGroupByWeaponId.HandleId, ConfigRoleDevWeaponJumpGroupByWeaponId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevWeaponJumpGroupByWeaponId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WeaponId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDevWeaponJumpGroup?(RoleDevWeaponJumpGroup.GetRootAsRoleDevWeaponJumpGroup(configBuffer));
				}
			}
			ConfigRoleDevWeaponJumpGroupByWeaponId.LogPair.Clear();
			ConfigRoleDevWeaponJumpGroupByWeaponId.LogPair.Add(new ValueTuple<string, object>("WeaponId", p0WeaponId));
			if (!ConfigCommon.BindInt(ConfigRoleDevWeaponJumpGroupByWeaponId.HandleId, 1, p0WeaponId, ConfigRoleDevWeaponJumpGroupByWeaponId.LogPair) || ConfigCommon.Step(ConfigRoleDevWeaponJumpGroupByWeaponId.HandleId, true, ConfigRoleDevWeaponJumpGroupByWeaponId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDevWeaponJumpGroupByWeaponId.HandleId, ConfigRoleDevWeaponJumpGroupByWeaponId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevWeaponJumpGroupByWeaponId.HandleId, 0, ConfigRoleDevWeaponJumpGroupByWeaponId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDevWeaponJumpGroupByWeaponId.HandleId, ConfigRoleDevWeaponJumpGroupByWeaponId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDevWeaponJumpGroup rootAsRoleDevWeaponJumpGroup = RoleDevWeaponJumpGroup.GetRootAsRoleDevWeaponJumpGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevWeaponJumpGroupByWeaponId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WeaponId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDevWeaponJumpGroupByWeaponId.HandleId, ConfigRoleDevWeaponJumpGroupByWeaponId.LogPair);
			return new RoleDevWeaponJumpGroup?(rootAsRoleDevWeaponJumpGroup);
		}

		// Token: 0x04003D2D RID: 15661
		private const string DB = "db_roledev.db";

		// Token: 0x04003D2E RID: 15662
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003D2F RID: 15663
		private const string TABLE = "RoleDevWeaponJumpGroup";

		// Token: 0x04003D30 RID: 15664
		private const string COMMAND = "select BinData from `RoleDevWeaponJumpGroup` where WeaponId=?";

		// Token: 0x04003D31 RID: 15665
		private const string KEY_PREFIX = "RoleDevWeaponJumpGroupByWeaponId";

		// Token: 0x04003D32 RID: 15666
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D33 RID: 15667
		private static int HandleId;
	}
}

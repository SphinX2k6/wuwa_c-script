using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A5 RID: 2213
	public class ConfigRoleDevWeaponJumpGroupByWeaponId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033F0 RID: 13296 RVA: 0x0017EC9B File Offset: 0x0017CE9B
		static ConfigRoleDevWeaponJumpGroupByWeaponId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevWeaponJumpGroupByWeaponId.CreateStaticDefaultValue), new Action(ConfigRoleDevWeaponJumpGroupByWeaponId.ResetStaticDefaultValue));
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x0017ECBC File Offset: 0x0017CEBC
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

		// Token: 0x060033F2 RID: 13298 RVA: 0x0017ED3B File Offset: 0x0017CF3B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevWeaponJumpGroupByWeaponId.LogPair = null;
			ConfigRoleDevWeaponJumpGroupByWeaponId.HandleId = 0;
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x0017ED49 File Offset: 0x0017CF49
		public static void Init()
		{
			ConfigRoleDevWeaponJumpGroupByWeaponId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevWeaponJumpGroupByWeaponId.HandleId, "db_roledev.db", "select BinData from `RoleDevWeaponJumpGroup` where WeaponId=?");
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x0017ED64 File Offset: 0x0017CF64
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

		// Token: 0x04003C69 RID: 15465
		private const string DB = "db_roledev.db";

		// Token: 0x04003C6A RID: 15466
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C6B RID: 15467
		private const string TABLE = "RoleDevWeaponJumpGroup";

		// Token: 0x04003C6C RID: 15468
		private const string COMMAND = "select BinData from `RoleDevWeaponJumpGroup` where WeaponId=?";

		// Token: 0x04003C6D RID: 15469
		private const string KEY_PREFIX = "RoleDevWeaponJumpGroupByWeaponId";

		// Token: 0x04003C6E RID: 15470
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C6F RID: 15471
		private static int HandleId;
	}
}

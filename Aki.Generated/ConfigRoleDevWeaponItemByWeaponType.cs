using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008BF RID: 2239
	public class ConfigRoleDevWeaponItemByWeaponType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600348C RID: 13452 RVA: 0x00185BA7 File Offset: 0x00183DA7
		static ConfigRoleDevWeaponItemByWeaponType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevWeaponItemByWeaponType.CreateStaticDefaultValue), new Action(ConfigRoleDevWeaponItemByWeaponType.ResetStaticDefaultValue));
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x00185BC8 File Offset: 0x00183DC8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevWeaponItemByWeaponType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevWeaponItemByWeaponType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevWeaponItem"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevWeaponItem` where WeaponType=?")
			});
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x00185C47 File Offset: 0x00183E47
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevWeaponItemByWeaponType.LogPair = null;
			ConfigRoleDevWeaponItemByWeaponType.HandleId = 0;
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x00185C55 File Offset: 0x00183E55
		public static void Init()
		{
			ConfigRoleDevWeaponItemByWeaponType.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevWeaponItemByWeaponType.HandleId, "db_roledev.db", "select BinData from `RoleDevWeaponItem` where WeaponType=?");
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x00185C70 File Offset: 0x00183E70
		public static RoleDevWeaponItem? GetConfig(int p0WeaponType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevWeaponItemByWeaponType.HandleId, ConfigRoleDevWeaponItemByWeaponType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevWeaponItemByWeaponType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WeaponType);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDevWeaponItem?(RoleDevWeaponItem.GetRootAsRoleDevWeaponItem(configBuffer));
				}
			}
			ConfigRoleDevWeaponItemByWeaponType.LogPair.Clear();
			ConfigRoleDevWeaponItemByWeaponType.LogPair.Add(new ValueTuple<string, object>("WeaponType", p0WeaponType));
			if (!ConfigCommon.BindInt(ConfigRoleDevWeaponItemByWeaponType.HandleId, 1, p0WeaponType, ConfigRoleDevWeaponItemByWeaponType.LogPair) || ConfigCommon.Step(ConfigRoleDevWeaponItemByWeaponType.HandleId, true, ConfigRoleDevWeaponItemByWeaponType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDevWeaponItemByWeaponType.HandleId, ConfigRoleDevWeaponItemByWeaponType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevWeaponItemByWeaponType.HandleId, 0, ConfigRoleDevWeaponItemByWeaponType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDevWeaponItemByWeaponType.HandleId, ConfigRoleDevWeaponItemByWeaponType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDevWeaponItem rootAsRoleDevWeaponItem = RoleDevWeaponItem.GetRootAsRoleDevWeaponItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevWeaponItemByWeaponType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WeaponType);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDevWeaponItemByWeaponType.HandleId, ConfigRoleDevWeaponItemByWeaponType.LogPair);
			return new RoleDevWeaponItem?(rootAsRoleDevWeaponItem);
		}

		// Token: 0x04003D1F RID: 15647
		private const string DB = "db_roledev.db";

		// Token: 0x04003D20 RID: 15648
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003D21 RID: 15649
		private const string TABLE = "RoleDevWeaponItem";

		// Token: 0x04003D22 RID: 15650
		private const string COMMAND = "select BinData from `RoleDevWeaponItem` where WeaponType=?";

		// Token: 0x04003D23 RID: 15651
		private const string KEY_PREFIX = "RoleDevWeaponItemByWeaponType";

		// Token: 0x04003D24 RID: 15652
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D25 RID: 15653
		private static int HandleId;
	}
}

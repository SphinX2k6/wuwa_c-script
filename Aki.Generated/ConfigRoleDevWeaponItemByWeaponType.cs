using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A3 RID: 2211
	public class ConfigRoleDevWeaponItemByWeaponType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033E4 RID: 13284 RVA: 0x0017E8BF File Offset: 0x0017CABF
		static ConfigRoleDevWeaponItemByWeaponType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevWeaponItemByWeaponType.CreateStaticDefaultValue), new Action(ConfigRoleDevWeaponItemByWeaponType.ResetStaticDefaultValue));
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x0017E8E0 File Offset: 0x0017CAE0
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

		// Token: 0x060033E6 RID: 13286 RVA: 0x0017E95F File Offset: 0x0017CB5F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevWeaponItemByWeaponType.LogPair = null;
			ConfigRoleDevWeaponItemByWeaponType.HandleId = 0;
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x0017E96D File Offset: 0x0017CB6D
		public static void Init()
		{
			ConfigRoleDevWeaponItemByWeaponType.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevWeaponItemByWeaponType.HandleId, "db_roledev.db", "select BinData from `RoleDevWeaponItem` where WeaponType=?");
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x0017E988 File Offset: 0x0017CB88
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

		// Token: 0x04003C5B RID: 15451
		private const string DB = "db_roledev.db";

		// Token: 0x04003C5C RID: 15452
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C5D RID: 15453
		private const string TABLE = "RoleDevWeaponItem";

		// Token: 0x04003C5E RID: 15454
		private const string COMMAND = "select BinData from `RoleDevWeaponItem` where WeaponType=?";

		// Token: 0x04003C5F RID: 15455
		private const string KEY_PREFIX = "RoleDevWeaponItemByWeaponType";

		// Token: 0x04003C60 RID: 15456
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C61 RID: 15457
		private static int HandleId;
	}
}

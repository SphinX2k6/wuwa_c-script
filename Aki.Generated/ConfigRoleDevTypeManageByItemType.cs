using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008BD RID: 2237
	public class ConfigRoleDevTypeManageByItemType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003480 RID: 13440 RVA: 0x001857CB File Offset: 0x001839CB
		static ConfigRoleDevTypeManageByItemType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevTypeManageByItemType.CreateStaticDefaultValue), new Action(ConfigRoleDevTypeManageByItemType.ResetStaticDefaultValue));
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x001857EC File Offset: 0x001839EC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevTypeManageByItemType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevTypeManageByItemType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevTypeManage"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevTypeManage` where ItemType=?")
			});
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x0018586B File Offset: 0x00183A6B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevTypeManageByItemType.LogPair = null;
			ConfigRoleDevTypeManageByItemType.HandleId = 0;
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x00185879 File Offset: 0x00183A79
		public static void Init()
		{
			ConfigRoleDevTypeManageByItemType.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevTypeManageByItemType.HandleId, "db_roledev.db", "select BinData from `RoleDevTypeManage` where ItemType=?");
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x00185894 File Offset: 0x00183A94
		public static RoleDevTypeManage? GetConfig(int p0ItemType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevTypeManageByItemType.HandleId, ConfigRoleDevTypeManageByItemType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevTypeManageByItemType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemType);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDevTypeManage?(RoleDevTypeManage.GetRootAsRoleDevTypeManage(configBuffer));
				}
			}
			ConfigRoleDevTypeManageByItemType.LogPair.Clear();
			ConfigRoleDevTypeManageByItemType.LogPair.Add(new ValueTuple<string, object>("ItemType", p0ItemType));
			if (!ConfigCommon.BindInt(ConfigRoleDevTypeManageByItemType.HandleId, 1, p0ItemType, ConfigRoleDevTypeManageByItemType.LogPair) || ConfigCommon.Step(ConfigRoleDevTypeManageByItemType.HandleId, true, ConfigRoleDevTypeManageByItemType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDevTypeManageByItemType.HandleId, ConfigRoleDevTypeManageByItemType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevTypeManageByItemType.HandleId, 0, ConfigRoleDevTypeManageByItemType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDevTypeManageByItemType.HandleId, ConfigRoleDevTypeManageByItemType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDevTypeManage rootAsRoleDevTypeManage = RoleDevTypeManage.GetRootAsRoleDevTypeManage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevTypeManageByItemType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemType);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDevTypeManageByItemType.HandleId, ConfigRoleDevTypeManageByItemType.LogPair);
			return new RoleDevTypeManage?(rootAsRoleDevTypeManage);
		}

		// Token: 0x04003D11 RID: 15633
		private const string DB = "db_roledev.db";

		// Token: 0x04003D12 RID: 15634
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003D13 RID: 15635
		private const string TABLE = "RoleDevTypeManage";

		// Token: 0x04003D14 RID: 15636
		private const string COMMAND = "select BinData from `RoleDevTypeManage` where ItemType=?";

		// Token: 0x04003D15 RID: 15637
		private const string KEY_PREFIX = "RoleDevTypeManageByItemType";

		// Token: 0x04003D16 RID: 15638
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D17 RID: 15639
		private static int HandleId;
	}
}

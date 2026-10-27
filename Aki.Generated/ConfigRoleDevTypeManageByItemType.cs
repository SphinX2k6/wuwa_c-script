using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A1 RID: 2209
	public class ConfigRoleDevTypeManageByItemType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033D8 RID: 13272 RVA: 0x0017E4E3 File Offset: 0x0017C6E3
		static ConfigRoleDevTypeManageByItemType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevTypeManageByItemType.CreateStaticDefaultValue), new Action(ConfigRoleDevTypeManageByItemType.ResetStaticDefaultValue));
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x0017E504 File Offset: 0x0017C704
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

		// Token: 0x060033DA RID: 13274 RVA: 0x0017E583 File Offset: 0x0017C783
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevTypeManageByItemType.LogPair = null;
			ConfigRoleDevTypeManageByItemType.HandleId = 0;
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x0017E591 File Offset: 0x0017C791
		public static void Init()
		{
			ConfigRoleDevTypeManageByItemType.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevTypeManageByItemType.HandleId, "db_roledev.db", "select BinData from `RoleDevTypeManage` where ItemType=?");
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x0017E5AC File Offset: 0x0017C7AC
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

		// Token: 0x04003C4D RID: 15437
		private const string DB = "db_roledev.db";

		// Token: 0x04003C4E RID: 15438
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C4F RID: 15439
		private const string TABLE = "RoleDevTypeManage";

		// Token: 0x04003C50 RID: 15440
		private const string COMMAND = "select BinData from `RoleDevTypeManage` where ItemType=?";

		// Token: 0x04003C51 RID: 15441
		private const string KEY_PREFIX = "RoleDevTypeManageByItemType";

		// Token: 0x04003C52 RID: 15442
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C53 RID: 15443
		private static int HandleId;
	}
}

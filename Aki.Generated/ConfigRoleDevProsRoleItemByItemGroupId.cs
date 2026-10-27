using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200089F RID: 2207
	public class ConfigRoleDevProsRoleItemByItemGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033CC RID: 13260 RVA: 0x0017E107 File Offset: 0x0017C307
		static ConfigRoleDevProsRoleItemByItemGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevProsRoleItemByItemGroupId.CreateStaticDefaultValue), new Action(ConfigRoleDevProsRoleItemByItemGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x0017E128 File Offset: 0x0017C328
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevProsRoleItemByItemGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevProsRoleItemByItemGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevProsRoleItem"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevProsRoleItem` where ItemGroupId=?")
			});
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x0017E1A7 File Offset: 0x0017C3A7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevProsRoleItemByItemGroupId.LogPair = null;
			ConfigRoleDevProsRoleItemByItemGroupId.HandleId = 0;
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x0017E1B5 File Offset: 0x0017C3B5
		public static void Init()
		{
			ConfigRoleDevProsRoleItemByItemGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevProsRoleItemByItemGroupId.HandleId, "db_roledev.db", "select BinData from `RoleDevProsRoleItem` where ItemGroupId=?");
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x0017E1D0 File Offset: 0x0017C3D0
		public static RoleDevProsRoleItem? GetConfig(int p0ItemGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevProsRoleItemByItemGroupId.HandleId, ConfigRoleDevProsRoleItemByItemGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevProsRoleItemByItemGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemGroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDevProsRoleItem?(RoleDevProsRoleItem.GetRootAsRoleDevProsRoleItem(configBuffer));
				}
			}
			ConfigRoleDevProsRoleItemByItemGroupId.LogPair.Clear();
			ConfigRoleDevProsRoleItemByItemGroupId.LogPair.Add(new ValueTuple<string, object>("ItemGroupId", p0ItemGroupId));
			if (!ConfigCommon.BindInt(ConfigRoleDevProsRoleItemByItemGroupId.HandleId, 1, p0ItemGroupId, ConfigRoleDevProsRoleItemByItemGroupId.LogPair) || ConfigCommon.Step(ConfigRoleDevProsRoleItemByItemGroupId.HandleId, true, ConfigRoleDevProsRoleItemByItemGroupId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDevProsRoleItemByItemGroupId.HandleId, ConfigRoleDevProsRoleItemByItemGroupId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevProsRoleItemByItemGroupId.HandleId, 0, ConfigRoleDevProsRoleItemByItemGroupId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDevProsRoleItemByItemGroupId.HandleId, ConfigRoleDevProsRoleItemByItemGroupId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDevProsRoleItem rootAsRoleDevProsRoleItem = RoleDevProsRoleItem.GetRootAsRoleDevProsRoleItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevProsRoleItemByItemGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemGroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDevProsRoleItemByItemGroupId.HandleId, ConfigRoleDevProsRoleItemByItemGroupId.LogPair);
			return new RoleDevProsRoleItem?(rootAsRoleDevProsRoleItem);
		}

		// Token: 0x04003C3F RID: 15423
		private const string DB = "db_roledev.db";

		// Token: 0x04003C40 RID: 15424
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C41 RID: 15425
		private const string TABLE = "RoleDevProsRoleItem";

		// Token: 0x04003C42 RID: 15426
		private const string COMMAND = "select BinData from `RoleDevProsRoleItem` where ItemGroupId=?";

		// Token: 0x04003C43 RID: 15427
		private const string KEY_PREFIX = "RoleDevProsRoleItemByItemGroupId";

		// Token: 0x04003C44 RID: 15428
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C45 RID: 15429
		private static int HandleId;
	}
}

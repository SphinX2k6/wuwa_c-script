using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008BB RID: 2235
	public class ConfigRoleDevProsRoleItemByItemGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003474 RID: 13428 RVA: 0x001853EF File Offset: 0x001835EF
		static ConfigRoleDevProsRoleItemByItemGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevProsRoleItemByItemGroupId.CreateStaticDefaultValue), new Action(ConfigRoleDevProsRoleItemByItemGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x00185410 File Offset: 0x00183610
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

		// Token: 0x06003476 RID: 13430 RVA: 0x0018548F File Offset: 0x0018368F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevProsRoleItemByItemGroupId.LogPair = null;
			ConfigRoleDevProsRoleItemByItemGroupId.HandleId = 0;
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x0018549D File Offset: 0x0018369D
		public static void Init()
		{
			ConfigRoleDevProsRoleItemByItemGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevProsRoleItemByItemGroupId.HandleId, "db_roledev.db", "select BinData from `RoleDevProsRoleItem` where ItemGroupId=?");
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x001854B8 File Offset: 0x001836B8
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

		// Token: 0x04003D03 RID: 15619
		private const string DB = "db_roledev.db";

		// Token: 0x04003D04 RID: 15620
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003D05 RID: 15621
		private const string TABLE = "RoleDevProsRoleItem";

		// Token: 0x04003D06 RID: 15622
		private const string COMMAND = "select BinData from `RoleDevProsRoleItem` where ItemGroupId=?";

		// Token: 0x04003D07 RID: 15623
		private const string KEY_PREFIX = "RoleDevProsRoleItemByItemGroupId";

		// Token: 0x04003D08 RID: 15624
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D09 RID: 15625
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008BA RID: 2234
	public class ConfigRoleDevProsRoleItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600346E RID: 13422 RVA: 0x0018525C File Offset: 0x0018345C
		static ConfigRoleDevProsRoleItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevProsRoleItemAll.CreateStaticDefaultValue), new Action(ConfigRoleDevProsRoleItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x0018527C File Offset: 0x0018347C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevProsRoleItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevProsRoleItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevProsRoleItem"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevProsRoleItem`")
			});
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x001852FB File Offset: 0x001834FB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevProsRoleItemAll.LogPair = null;
			ConfigRoleDevProsRoleItemAll.HandleId = 0;
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x00185309 File Offset: 0x00183509
		public static void Init()
		{
			ConfigRoleDevProsRoleItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevProsRoleItemAll.HandleId, "db_roledev.db", "select BinData from `RoleDevProsRoleItem`");
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x00185324 File Offset: 0x00183524
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevProsRoleItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevProsRoleItemAll.HandleId, ConfigRoleDevProsRoleItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevProsRoleItem> readOnlyList = (IReadOnlyList<RoleDevProsRoleItem>)ConfigCommon.GetConfig("RoleDevProsRoleItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevProsRoleItem> list = new List<RoleDevProsRoleItem>();
			while (ConfigCommon.Step(ConfigRoleDevProsRoleItemAll.HandleId, false, ConfigRoleDevProsRoleItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevProsRoleItemAll.HandleId, 0, ConfigRoleDevProsRoleItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevProsRoleItemAll.HandleId, ConfigRoleDevProsRoleItemAll.LogPair);
					return null;
				}
				RoleDevProsRoleItem rootAsRoleDevProsRoleItem = RoleDevProsRoleItem.GetRootAsRoleDevProsRoleItem(new ByteBuffer(item2));
				list.Add(rootAsRoleDevProsRoleItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevProsRoleItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevProsRoleItemAll.HandleId, ConfigRoleDevProsRoleItemAll.LogPair);
			return list;
		}

		// Token: 0x04003CFC RID: 15612
		private const string DB = "db_roledev.db";

		// Token: 0x04003CFD RID: 15613
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003CFE RID: 15614
		private const string TABLE = "RoleDevProsRoleItem";

		// Token: 0x04003CFF RID: 15615
		private const string COMMAND = "select BinData from `RoleDevProsRoleItem`";

		// Token: 0x04003D00 RID: 15616
		private const string KEY_PREFIX = "RoleDevProsRoleItemAll";

		// Token: 0x04003D01 RID: 15617
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D02 RID: 15618
		private static int HandleId;
	}
}

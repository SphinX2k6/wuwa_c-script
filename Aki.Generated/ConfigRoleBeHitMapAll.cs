using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A4 RID: 2212
	public class ConfigRoleBeHitMapAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033EA RID: 13290 RVA: 0x001825E8 File Offset: 0x001807E8
		static ConfigRoleBeHitMapAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBeHitMapAll.CreateStaticDefaultValue), new Action(ConfigRoleBeHitMapAll.ResetStaticDefaultValue));
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x00182608 File Offset: 0x00180808
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleBeHitMapAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleBeHitMapAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rolebehitmap.db"),
				new ValueTuple<string, object>("文件", "j.角色受击状态机.xlsx"),
				new ValueTuple<string, object>("表名", "RoleBeHitMap"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleBeHitMap`")
			});
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x00182687 File Offset: 0x00180887
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBeHitMapAll.LogPair = null;
			ConfigRoleBeHitMapAll.HandleId = 0;
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x00182695 File Offset: 0x00180895
		public static void Init()
		{
			ConfigRoleBeHitMapAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBeHitMapAll.HandleId, "db_rolebehitmap.db", "select BinData from `RoleBeHitMap`");
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x001826B0 File Offset: 0x001808B0
		[NullableContext(2)]
		public static IReadOnlyList<RoleBeHitMap> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleBeHitMapAll.HandleId, ConfigRoleBeHitMapAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleBeHitMap> readOnlyList = (IReadOnlyList<RoleBeHitMap>)ConfigCommon.GetConfig("RoleBeHitMapAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleBeHitMap> list = new List<RoleBeHitMap>();
			while (ConfigCommon.Step(ConfigRoleBeHitMapAll.HandleId, false, ConfigRoleBeHitMapAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleBeHitMapAll.HandleId, 0, ConfigRoleBeHitMapAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleBeHitMapAll.HandleId, ConfigRoleBeHitMapAll.LogPair);
					return null;
				}
				RoleBeHitMap rootAsRoleBeHitMap = RoleBeHitMap.GetRootAsRoleBeHitMap(new ByteBuffer(item2));
				list.Add(rootAsRoleBeHitMap);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleBeHitMapAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleBeHitMapAll.HandleId, ConfigRoleBeHitMapAll.LogPair);
			return list;
		}

		// Token: 0x04003C62 RID: 15458
		private const string DB = "db_rolebehitmap.db";

		// Token: 0x04003C63 RID: 15459
		private const string FILE = "j.角色受击状态机.xlsx";

		// Token: 0x04003C64 RID: 15460
		private const string TABLE = "RoleBeHitMap";

		// Token: 0x04003C65 RID: 15461
		private const string COMMAND = "select BinData from `RoleBeHitMap`";

		// Token: 0x04003C66 RID: 15462
		private const string KEY_PREFIX = "RoleBeHitMapAll";

		// Token: 0x04003C67 RID: 15463
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C68 RID: 15464
		private static int HandleId;
	}
}

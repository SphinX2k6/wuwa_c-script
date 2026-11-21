using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000915 RID: 2325
	public class ConfigRoleTowerTokenZoneAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003691 RID: 13969 RVA: 0x0019100C File Offset: 0x0018F20C
		static ConfigRoleTowerTokenZoneAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerTokenZoneAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerTokenZoneAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x0019102C File Offset: 0x0018F22C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerTokenZoneAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerTokenZoneAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_信物.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerTokenZone"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerTokenZone`")
			});
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x001910AB File Offset: 0x0018F2AB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerTokenZoneAll.LogPair = null;
			ConfigRoleTowerTokenZoneAll.HandleId = 0;
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x001910B9 File Offset: 0x0018F2B9
		public static void Init()
		{
			ConfigRoleTowerTokenZoneAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerTokenZoneAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerTokenZone`");
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x001910D4 File Offset: 0x0018F2D4
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerTokenZone> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerTokenZoneAll.HandleId, ConfigRoleTowerTokenZoneAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerTokenZone> readOnlyList = (IReadOnlyList<RoleTowerTokenZone>)ConfigCommon.GetConfig("RoleTowerTokenZoneAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerTokenZone> list = new List<RoleTowerTokenZone>();
			while (ConfigCommon.Step(ConfigRoleTowerTokenZoneAll.HandleId, false, ConfigRoleTowerTokenZoneAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerTokenZoneAll.HandleId, 0, ConfigRoleTowerTokenZoneAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerTokenZoneAll.HandleId, ConfigRoleTowerTokenZoneAll.LogPair);
					return null;
				}
				RoleTowerTokenZone rootAsRoleTowerTokenZone = RoleTowerTokenZone.GetRootAsRoleTowerTokenZone(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerTokenZone);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerTokenZoneAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerTokenZoneAll.HandleId, ConfigRoleTowerTokenZoneAll.LogPair);
			return list;
		}

		// Token: 0x04003F79 RID: 16249
		private const string DB = "db_roletower.db";

		// Token: 0x04003F7A RID: 16250
		private const string FILE = "j.角色爬塔_信物.xlsx";

		// Token: 0x04003F7B RID: 16251
		private const string TABLE = "RoleTowerTokenZone";

		// Token: 0x04003F7C RID: 16252
		private const string COMMAND = "select BinData from `RoleTowerTokenZone`";

		// Token: 0x04003F7D RID: 16253
		private const string KEY_PREFIX = "RoleTowerTokenZoneAll";

		// Token: 0x04003F7E RID: 16254
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F7F RID: 16255
		private static int HandleId;
	}
}

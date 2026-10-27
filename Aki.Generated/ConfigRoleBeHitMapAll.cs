using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000888 RID: 2184
	public class ConfigRoleBeHitMapAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003342 RID: 13122 RVA: 0x0017B300 File Offset: 0x00179500
		static ConfigRoleBeHitMapAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBeHitMapAll.CreateStaticDefaultValue), new Action(ConfigRoleBeHitMapAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x0017B320 File Offset: 0x00179520
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

		// Token: 0x06003344 RID: 13124 RVA: 0x0017B39F File Offset: 0x0017959F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBeHitMapAll.LogPair = null;
			ConfigRoleBeHitMapAll.HandleId = 0;
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x0017B3AD File Offset: 0x001795AD
		public static void Init()
		{
			ConfigRoleBeHitMapAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBeHitMapAll.HandleId, "db_rolebehitmap.db", "select BinData from `RoleBeHitMap`");
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x0017B3C8 File Offset: 0x001795C8
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

		// Token: 0x04003B9E RID: 15262
		private const string DB = "db_rolebehitmap.db";

		// Token: 0x04003B9F RID: 15263
		private const string FILE = "j.角色受击状态机.xlsx";

		// Token: 0x04003BA0 RID: 15264
		private const string TABLE = "RoleBeHitMap";

		// Token: 0x04003BA1 RID: 15265
		private const string COMMAND = "select BinData from `RoleBeHitMap`";

		// Token: 0x04003BA2 RID: 15266
		private const string KEY_PREFIX = "RoleBeHitMapAll";

		// Token: 0x04003BA3 RID: 15267
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BA4 RID: 15268
		private static int HandleId;
	}
}

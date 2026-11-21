using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200090E RID: 2318
	public class ConfigRoleTowerStarGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003667 RID: 13927 RVA: 0x00190240 File Offset: 0x0018E440
		static ConfigRoleTowerStarGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerStarGroupAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerStarGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x00190260 File Offset: 0x0018E460
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerStarGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerStarGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局内.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerStarGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerStarGroup`")
			});
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x001902DF File Offset: 0x0018E4DF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerStarGroupAll.LogPair = null;
			ConfigRoleTowerStarGroupAll.HandleId = 0;
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x001902ED File Offset: 0x0018E4ED
		public static void Init()
		{
			ConfigRoleTowerStarGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerStarGroupAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerStarGroup`");
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x00190308 File Offset: 0x0018E508
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerStarGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerStarGroupAll.HandleId, ConfigRoleTowerStarGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerStarGroup> readOnlyList = (IReadOnlyList<RoleTowerStarGroup>)ConfigCommon.GetConfig("RoleTowerStarGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerStarGroup> list = new List<RoleTowerStarGroup>();
			while (ConfigCommon.Step(ConfigRoleTowerStarGroupAll.HandleId, false, ConfigRoleTowerStarGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerStarGroupAll.HandleId, 0, ConfigRoleTowerStarGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerStarGroupAll.HandleId, ConfigRoleTowerStarGroupAll.LogPair);
					return null;
				}
				RoleTowerStarGroup rootAsRoleTowerStarGroup = RoleTowerStarGroup.GetRootAsRoleTowerStarGroup(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerStarGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerStarGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerStarGroupAll.HandleId, ConfigRoleTowerStarGroupAll.LogPair);
			return list;
		}

		// Token: 0x04003F48 RID: 16200
		private const string DB = "db_roletower.db";

		// Token: 0x04003F49 RID: 16201
		private const string FILE = "j.角色爬塔_局内.xlsx";

		// Token: 0x04003F4A RID: 16202
		private const string TABLE = "RoleTowerStarGroup";

		// Token: 0x04003F4B RID: 16203
		private const string COMMAND = "select BinData from `RoleTowerStarGroup`";

		// Token: 0x04003F4C RID: 16204
		private const string KEY_PREFIX = "RoleTowerStarGroupAll";

		// Token: 0x04003F4D RID: 16205
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F4E RID: 16206
		private static int HandleId;
	}
}

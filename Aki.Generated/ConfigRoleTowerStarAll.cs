using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200090B RID: 2315
	public class ConfigRoleTowerStarAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003655 RID: 13909 RVA: 0x0018FC2C File Offset: 0x0018DE2C
		static ConfigRoleTowerStarAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerStarAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerStarAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x0018FC4C File Offset: 0x0018DE4C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerStarAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerStarAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局内.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerStar"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerStar`")
			});
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x0018FCCB File Offset: 0x0018DECB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerStarAll.LogPair = null;
			ConfigRoleTowerStarAll.HandleId = 0;
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x0018FCD9 File Offset: 0x0018DED9
		public static void Init()
		{
			ConfigRoleTowerStarAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerStarAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerStar`");
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x0018FCF4 File Offset: 0x0018DEF4
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerStar> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerStarAll.HandleId, ConfigRoleTowerStarAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerStar> readOnlyList = (IReadOnlyList<RoleTowerStar>)ConfigCommon.GetConfig("RoleTowerStarAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerStar> list = new List<RoleTowerStar>();
			while (ConfigCommon.Step(ConfigRoleTowerStarAll.HandleId, false, ConfigRoleTowerStarAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerStarAll.HandleId, 0, ConfigRoleTowerStarAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerStarAll.HandleId, ConfigRoleTowerStarAll.LogPair);
					return null;
				}
				RoleTowerStar rootAsRoleTowerStar = RoleTowerStar.GetRootAsRoleTowerStar(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerStar);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerStarAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerStarAll.HandleId, ConfigRoleTowerStarAll.LogPair);
			return list;
		}

		// Token: 0x04003F33 RID: 16179
		private const string DB = "db_roletower.db";

		// Token: 0x04003F34 RID: 16180
		private const string FILE = "j.角色爬塔_局内.xlsx";

		// Token: 0x04003F35 RID: 16181
		private const string TABLE = "RoleTowerStar";

		// Token: 0x04003F36 RID: 16182
		private const string COMMAND = "select BinData from `RoleTowerStar`";

		// Token: 0x04003F37 RID: 16183
		private const string KEY_PREFIX = "RoleTowerStarAll";

		// Token: 0x04003F38 RID: 16184
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F39 RID: 16185
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000868 RID: 2152
	public class ConfigRogueTalentTreeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003282 RID: 12930 RVA: 0x00177094 File Offset: 0x00175294
		static ConfigRogueTalentTreeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueTalentTreeAll.CreateStaticDefaultValue), new Action(ConfigRogueTalentTreeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x001770B4 File Offset: 0x001752B4
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueTalentTreeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueTalentTreeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueTalentTree"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueTalentTree`")
			});
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x00177133 File Offset: 0x00175333
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueTalentTreeAll.LogPair = null;
			ConfigRogueTalentTreeAll.HandleId = 0;
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x00177141 File Offset: 0x00175341
		public static void Init()
		{
			ConfigRogueTalentTreeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueTalentTreeAll.HandleId, "db_rogue.db", "select BinData from `RogueTalentTree`");
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x0017715C File Offset: 0x0017535C
		[NullableContext(2)]
		public static IReadOnlyList<RogueTalentTree> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueTalentTreeAll.HandleId, ConfigRogueTalentTreeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueTalentTree> readOnlyList = (IReadOnlyList<RogueTalentTree>)ConfigCommon.GetConfig("RogueTalentTreeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueTalentTree> list = new List<RogueTalentTree>();
			while (ConfigCommon.Step(ConfigRogueTalentTreeAll.HandleId, false, ConfigRogueTalentTreeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueTalentTreeAll.HandleId, 0, ConfigRogueTalentTreeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueTalentTreeAll.HandleId, ConfigRogueTalentTreeAll.LogPair);
					return null;
				}
				RogueTalentTree rootAsRogueTalentTree = RogueTalentTree.GetRootAsRogueTalentTree(new ByteBuffer(item2));
				list.Add(rootAsRogueTalentTree);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueTalentTreeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueTalentTreeAll.HandleId, ConfigRogueTalentTreeAll.LogPair);
			return list;
		}

		// Token: 0x04003ABE RID: 15038
		private const string DB = "db_rogue.db";

		// Token: 0x04003ABF RID: 15039
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003AC0 RID: 15040
		private const string TABLE = "RogueTalentTree";

		// Token: 0x04003AC1 RID: 15041
		private const string COMMAND = "select BinData from `RogueTalentTree`";

		// Token: 0x04003AC2 RID: 15042
		private const string KEY_PREFIX = "RogueTalentTreeAll";

		// Token: 0x04003AC3 RID: 15043
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AC4 RID: 15044
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000884 RID: 2180
	public class ConfigRogueTalentTreeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600332A RID: 13098 RVA: 0x0017E37C File Offset: 0x0017C57C
		static ConfigRogueTalentTreeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueTalentTreeAll.CreateStaticDefaultValue), new Action(ConfigRogueTalentTreeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x0017E39C File Offset: 0x0017C59C
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

		// Token: 0x0600332C RID: 13100 RVA: 0x0017E41B File Offset: 0x0017C61B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueTalentTreeAll.LogPair = null;
			ConfigRogueTalentTreeAll.HandleId = 0;
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x0017E429 File Offset: 0x0017C629
		public static void Init()
		{
			ConfigRogueTalentTreeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueTalentTreeAll.HandleId, "db_rogue.db", "select BinData from `RogueTalentTree`");
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x0017E444 File Offset: 0x0017C644
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

		// Token: 0x04003B82 RID: 15234
		private const string DB = "db_rogue.db";

		// Token: 0x04003B83 RID: 15235
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003B84 RID: 15236
		private const string TABLE = "RogueTalentTree";

		// Token: 0x04003B85 RID: 15237
		private const string COMMAND = "select BinData from `RogueTalentTree`";

		// Token: 0x04003B86 RID: 15238
		private const string KEY_PREFIX = "RogueTalentTreeAll";

		// Token: 0x04003B87 RID: 15239
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B88 RID: 15240
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000859 RID: 2137
	public class ConfigRogueResTalentTreeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003228 RID: 12840 RVA: 0x0017513C File Offset: 0x0017333C
		static ConfigRogueResTalentTreeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResTalentTreeAll.CreateStaticDefaultValue), new Action(ConfigRogueResTalentTreeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x0017515C File Offset: 0x0017335C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResTalentTreeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResTalentTreeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResTalentTree"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResTalentTree`")
			});
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x001751DB File Offset: 0x001733DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResTalentTreeAll.LogPair = null;
			ConfigRogueResTalentTreeAll.HandleId = 0;
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x001751E9 File Offset: 0x001733E9
		public static void Init()
		{
			ConfigRogueResTalentTreeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResTalentTreeAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTalentTree`");
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x00175204 File Offset: 0x00173404
		[NullableContext(2)]
		public static IReadOnlyList<RogueResTalentTree> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResTalentTreeAll.HandleId, ConfigRogueResTalentTreeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueResTalentTree> readOnlyList = (IReadOnlyList<RogueResTalentTree>)ConfigCommon.GetConfig("RogueResTalentTreeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueResTalentTree> list = new List<RogueResTalentTree>();
			while (ConfigCommon.Step(ConfigRogueResTalentTreeAll.HandleId, false, ConfigRogueResTalentTreeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResTalentTreeAll.HandleId, 0, ConfigRogueResTalentTreeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueResTalentTreeAll.HandleId, ConfigRogueResTalentTreeAll.LogPair);
					return null;
				}
				RogueResTalentTree rootAsRogueResTalentTree = RogueResTalentTree.GetRootAsRogueResTalentTree(new ByteBuffer(item2));
				list.Add(rootAsRogueResTalentTree);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueResTalentTreeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueResTalentTreeAll.HandleId, ConfigRogueResTalentTreeAll.LogPair);
			return list;
		}

		// Token: 0x04003A55 RID: 14933
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A56 RID: 14934
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A57 RID: 14935
		private const string TABLE = "RogueResTalentTree";

		// Token: 0x04003A58 RID: 14936
		private const string COMMAND = "select BinData from `RogueResTalentTree`";

		// Token: 0x04003A59 RID: 14937
		private const string KEY_PREFIX = "RogueResTalentTreeAll";

		// Token: 0x04003A5A RID: 14938
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A5B RID: 14939
		private static int HandleId;
	}
}

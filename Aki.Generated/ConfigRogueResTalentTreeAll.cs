using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000875 RID: 2165
	public class ConfigRogueResTalentTreeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032D0 RID: 13008 RVA: 0x0017C424 File Offset: 0x0017A624
		static ConfigRogueResTalentTreeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResTalentTreeAll.CreateStaticDefaultValue), new Action(ConfigRogueResTalentTreeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x0017C444 File Offset: 0x0017A644
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

		// Token: 0x060032D2 RID: 13010 RVA: 0x0017C4C3 File Offset: 0x0017A6C3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResTalentTreeAll.LogPair = null;
			ConfigRogueResTalentTreeAll.HandleId = 0;
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x0017C4D1 File Offset: 0x0017A6D1
		public static void Init()
		{
			ConfigRogueResTalentTreeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResTalentTreeAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTalentTree`");
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x0017C4EC File Offset: 0x0017A6EC
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

		// Token: 0x04003B19 RID: 15129
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003B1A RID: 15130
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003B1B RID: 15131
		private const string TABLE = "RogueResTalentTree";

		// Token: 0x04003B1C RID: 15132
		private const string COMMAND = "select BinData from `RogueResTalentTree`";

		// Token: 0x04003B1D RID: 15133
		private const string KEY_PREFIX = "RogueResTalentTreeAll";

		// Token: 0x04003B1E RID: 15134
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B1F RID: 15135
		private static int HandleId;
	}
}

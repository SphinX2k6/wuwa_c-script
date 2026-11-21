using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B2E RID: 2862
	public class ConfigTuningNodeByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004328 RID: 17192 RVA: 0x001D8B0F File Offset: 0x001D6D0F
		static ConfigTuningNodeByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTuningNodeByAll.CreateStaticDefaultValue), new Action(ConfigTuningNodeByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x001D8B30 File Offset: 0x001D6D30
		public static void CreateStaticDefaultValue()
		{
			ConfigTuningNodeByAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTuningNodeByAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tuningnode.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/t.调律台音符/*.csv*"),
				new ValueTuple<string, object>("表名", "TuningNode"),
				new ValueTuple<string, object>("语句", "select BinData from `TuningNode`")
			});
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x001D8BAF File Offset: 0x001D6DAF
		public static void ResetStaticDefaultValue()
		{
			ConfigTuningNodeByAll.LogPair = null;
			ConfigTuningNodeByAll.HandleId = 0;
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x001D8BBD File Offset: 0x001D6DBD
		public static void Init()
		{
			ConfigTuningNodeByAll.HandleId = ConfigCommon.InitDataStatement(ConfigTuningNodeByAll.HandleId, "db_tuningnode.db", "select BinData from `TuningNode`");
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x001D8BD8 File Offset: 0x001D6DD8
		[NullableContext(2)]
		public static IReadOnlyList<TuningNode> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTuningNodeByAll.HandleId, ConfigTuningNodeByAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TuningNode> readOnlyList = (IReadOnlyList<TuningNode>)ConfigCommon.GetConfig("TuningNodeByAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TuningNode> list = new List<TuningNode>();
			while (ConfigCommon.Step(ConfigTuningNodeByAll.HandleId, false, ConfigTuningNodeByAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTuningNodeByAll.HandleId, 0, ConfigTuningNodeByAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTuningNodeByAll.HandleId, ConfigTuningNodeByAll.LogPair);
					return null;
				}
				TuningNode rootAsTuningNode = TuningNode.GetRootAsTuningNode(new ByteBuffer(item2));
				list.Add(rootAsTuningNode);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TuningNodeByAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTuningNodeByAll.HandleId, ConfigTuningNodeByAll.LogPair);
			return list;
		}

		// Token: 0x04004E28 RID: 20008
		private const string DB = "db_tuningnode.db";

		// Token: 0x04004E29 RID: 20009
		private const string FILE = "k.可视化编辑/c.Csv/t.调律台音符/*.csv*";

		// Token: 0x04004E2A RID: 20010
		private const string TABLE = "TuningNode";

		// Token: 0x04004E2B RID: 20011
		private const string COMMAND = "select BinData from `TuningNode`";

		// Token: 0x04004E2C RID: 20012
		private const string KEY_PREFIX = "TuningNodeByAll";

		// Token: 0x04004E2D RID: 20013
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E2E RID: 20014
		private static int HandleId;
	}
}

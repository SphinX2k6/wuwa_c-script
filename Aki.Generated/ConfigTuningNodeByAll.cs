using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A59 RID: 2649
	public class ConfigTuningNodeByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E2A RID: 15914 RVA: 0x001B977B File Offset: 0x001B797B
		static ConfigTuningNodeByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTuningNodeByAll.CreateStaticDefaultValue), new Action(ConfigTuningNodeByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x001B979C File Offset: 0x001B799C
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

		// Token: 0x06003E2C RID: 15916 RVA: 0x001B981B File Offset: 0x001B7A1B
		public static void ResetStaticDefaultValue()
		{
			ConfigTuningNodeByAll.LogPair = null;
			ConfigTuningNodeByAll.HandleId = 0;
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x001B9829 File Offset: 0x001B7A29
		public static void Init()
		{
			ConfigTuningNodeByAll.HandleId = ConfigCommon.InitDataStatement(ConfigTuningNodeByAll.HandleId, "db_tuningnode.db", "select BinData from `TuningNode`");
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x001B9844 File Offset: 0x001B7A44
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

		// Token: 0x04004855 RID: 18517
		private const string DB = "db_tuningnode.db";

		// Token: 0x04004856 RID: 18518
		private const string FILE = "k.可视化编辑/c.Csv/t.调律台音符/*.csv*";

		// Token: 0x04004857 RID: 18519
		private const string TABLE = "TuningNode";

		// Token: 0x04004858 RID: 18520
		private const string COMMAND = "select BinData from `TuningNode`";

		// Token: 0x04004859 RID: 18521
		private const string KEY_PREFIX = "TuningNodeByAll";

		// Token: 0x0400485A RID: 18522
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400485B RID: 18523
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200084B RID: 2123
	public class ConfigRogueResGlobalParamAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031D4 RID: 12756 RVA: 0x00173368 File Offset: 0x00171568
		static ConfigRogueResGlobalParamAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResGlobalParamAll.CreateStaticDefaultValue), new Action(ConfigRogueResGlobalParamAll.ResetStaticDefaultValue));
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x00173388 File Offset: 0x00171588
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResGlobalParamAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResGlobalParamAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResGlobalParam"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResGlobalParam`")
			});
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x00173407 File Offset: 0x00171607
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResGlobalParamAll.LogPair = null;
			ConfigRogueResGlobalParamAll.HandleId = 0;
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x00173415 File Offset: 0x00171615
		public static void Init()
		{
			ConfigRogueResGlobalParamAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResGlobalParamAll.HandleId, "db_permanentrogue.db", "select BinData from `RogueResGlobalParam`");
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x00173430 File Offset: 0x00171630
		[NullableContext(2)]
		public static IReadOnlyList<RogueResGlobalParam> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResGlobalParamAll.HandleId, ConfigRogueResGlobalParamAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueResGlobalParam> readOnlyList = (IReadOnlyList<RogueResGlobalParam>)ConfigCommon.GetConfig("RogueResGlobalParamAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueResGlobalParam> list = new List<RogueResGlobalParam>();
			while (ConfigCommon.Step(ConfigRogueResGlobalParamAll.HandleId, false, ConfigRogueResGlobalParamAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResGlobalParamAll.HandleId, 0, ConfigRogueResGlobalParamAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueResGlobalParamAll.HandleId, ConfigRogueResGlobalParamAll.LogPair);
					return null;
				}
				RogueResGlobalParam rootAsRogueResGlobalParam = RogueResGlobalParam.GetRootAsRogueResGlobalParam(new ByteBuffer(item2));
				list.Add(rootAsRogueResGlobalParam);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueResGlobalParamAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueResGlobalParamAll.HandleId, ConfigRogueResGlobalParamAll.LogPair);
			return list;
		}

		// Token: 0x040039F3 RID: 14835
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039F4 RID: 14836
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039F5 RID: 14837
		private const string TABLE = "RogueResGlobalParam";

		// Token: 0x040039F6 RID: 14838
		private const string COMMAND = "select BinData from `RogueResGlobalParam`";

		// Token: 0x040039F7 RID: 14839
		private const string KEY_PREFIX = "RogueResGlobalParamAll";

		// Token: 0x040039F8 RID: 14840
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039F9 RID: 14841
		private static int HandleId;
	}
}

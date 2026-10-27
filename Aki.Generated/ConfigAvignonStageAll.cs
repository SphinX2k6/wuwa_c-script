using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000BE RID: 190
	public class ConfigAvignonStageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000475 RID: 1141 RVA: 0x00072F44 File Offset: 0x00071144
		static ConfigAvignonStageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvignonStageAll.CreateStaticDefaultValue), new Action(ConfigAvignonStageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00072F64 File Offset: 0x00071164
		public static void CreateStaticDefaultValue()
		{
			ConfigAvignonStageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvignonStageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avignon.db"),
				new ValueTuple<string, object>("文件", "a.阿维纽林神学院.xlsx"),
				new ValueTuple<string, object>("表名", "AvignonStage"),
				new ValueTuple<string, object>("语句", "select BinData from `AvignonStage`")
			});
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00072FE3 File Offset: 0x000711E3
		public static void ResetStaticDefaultValue()
		{
			ConfigAvignonStageAll.LogPair = null;
			ConfigAvignonStageAll.HandleId = 0;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00072FF1 File Offset: 0x000711F1
		public static void Init()
		{
			ConfigAvignonStageAll.HandleId = ConfigCommon.InitDataStatement(ConfigAvignonStageAll.HandleId, "db_avignon.db", "select BinData from `AvignonStage`");
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0007300C File Offset: 0x0007120C
		[NullableContext(2)]
		public static IReadOnlyList<AvignonStage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvignonStageAll.HandleId, ConfigAvignonStageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AvignonStage> readOnlyList = (IReadOnlyList<AvignonStage>)ConfigCommon.GetConfig("AvignonStageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AvignonStage> list = new List<AvignonStage>();
			while (ConfigCommon.Step(ConfigAvignonStageAll.HandleId, false, ConfigAvignonStageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvignonStageAll.HandleId, 0, ConfigAvignonStageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAvignonStageAll.HandleId, ConfigAvignonStageAll.LogPair);
					return null;
				}
				AvignonStage rootAsAvignonStage = AvignonStage.GetRootAsAvignonStage(new ByteBuffer(item2));
				list.Add(rootAsAvignonStage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AvignonStageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAvignonStageAll.HandleId, ConfigAvignonStageAll.LogPair);
			return list;
		}

		// Token: 0x04000516 RID: 1302
		private const string DB = "db_avignon.db";

		// Token: 0x04000517 RID: 1303
		private const string FILE = "a.阿维纽林神学院.xlsx";

		// Token: 0x04000518 RID: 1304
		private const string TABLE = "AvignonStage";

		// Token: 0x04000519 RID: 1305
		private const string COMMAND = "select BinData from `AvignonStage`";

		// Token: 0x0400051A RID: 1306
		private const string KEY_PREFIX = "AvignonStageAll";

		// Token: 0x0400051B RID: 1307
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400051C RID: 1308
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F3 RID: 499
	public class ConfigDangoTrashTalkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BB5 RID: 2997 RVA: 0x0009BE9C File Offset: 0x0009A09C
		static ConfigDangoTrashTalkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoTrashTalkAll.CreateStaticDefaultValue), new Action(ConfigDangoTrashTalkAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0009BEBC File Offset: 0x0009A0BC
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoTrashTalkAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoTrashTalkAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoTrashTalk"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoTrashTalk`")
			});
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0009BF3B File Offset: 0x0009A13B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoTrashTalkAll.LogPair = null;
			ConfigDangoTrashTalkAll.HandleId = 0;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0009BF49 File Offset: 0x0009A149
		public static void Init()
		{
			ConfigDangoTrashTalkAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoTrashTalkAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoTrashTalk`");
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0009BF64 File Offset: 0x0009A164
		[NullableContext(2)]
		public static IReadOnlyList<DangoTrashTalk> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoTrashTalkAll.HandleId, ConfigDangoTrashTalkAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DangoTrashTalk> readOnlyList = (IReadOnlyList<DangoTrashTalk>)ConfigCommon.GetConfig("DangoTrashTalkAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DangoTrashTalk> list = new List<DangoTrashTalk>();
			while (ConfigCommon.Step(ConfigDangoTrashTalkAll.HandleId, false, ConfigDangoTrashTalkAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoTrashTalkAll.HandleId, 0, ConfigDangoTrashTalkAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoTrashTalkAll.HandleId, ConfigDangoTrashTalkAll.LogPair);
					return null;
				}
				DangoTrashTalk rootAsDangoTrashTalk = DangoTrashTalk.GetRootAsDangoTrashTalk(new ByteBuffer(item2));
				list.Add(rootAsDangoTrashTalk);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DangoTrashTalkAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoTrashTalkAll.HandleId, ConfigDangoTrashTalkAll.LogPair);
			return list;
		}

		// Token: 0x04000D89 RID: 3465
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D8A RID: 3466
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D8B RID: 3467
		private const string TABLE = "DangoTrashTalk";

		// Token: 0x04000D8C RID: 3468
		private const string COMMAND = "select BinData from `DangoTrashTalk`";

		// Token: 0x04000D8D RID: 3469
		private const string KEY_PREFIX = "DangoTrashTalkAll";

		// Token: 0x04000D8E RID: 3470
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D8F RID: 3471
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000205 RID: 517
	public class ConfigDangoTrashTalkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C21 RID: 3105 RVA: 0x000A1DD4 File Offset: 0x0009FFD4
		static ConfigDangoTrashTalkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoTrashTalkAll.CreateStaticDefaultValue), new Action(ConfigDangoTrashTalkAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000A1DF4 File Offset: 0x0009FFF4
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

		// Token: 0x06000C23 RID: 3107 RVA: 0x000A1E73 File Offset: 0x000A0073
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoTrashTalkAll.LogPair = null;
			ConfigDangoTrashTalkAll.HandleId = 0;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x000A1E81 File Offset: 0x000A0081
		public static void Init()
		{
			ConfigDangoTrashTalkAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoTrashTalkAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoTrashTalk`");
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000A1E9C File Offset: 0x000A009C
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

		// Token: 0x04000E07 RID: 3591
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000E08 RID: 3592
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000E09 RID: 3593
		private const string TABLE = "DangoTrashTalk";

		// Token: 0x04000E0A RID: 3594
		private const string COMMAND = "select BinData from `DangoTrashTalk`";

		// Token: 0x04000E0B RID: 3595
		private const string KEY_PREFIX = "DangoTrashTalkAll";

		// Token: 0x04000E0C RID: 3596
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E0D RID: 3597
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200030C RID: 780
	public class ConfigFloroRanchAudioAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600124D RID: 4685 RVA: 0x000C1098 File Offset: 0x000BF298
		static ConfigFloroRanchAudioAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchAudioAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchAudioAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x000C10B8 File Offset: 0x000BF2B8
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchAudioAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchAudioAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchAudio"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchAudio`")
			});
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x000C1137 File Offset: 0x000BF337
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchAudioAll.LogPair = null;
			ConfigFloroRanchAudioAll.HandleId = 0;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x000C1145 File Offset: 0x000BF345
		public static void Init()
		{
			ConfigFloroRanchAudioAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchAudioAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchAudio`");
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x000C1160 File Offset: 0x000BF360
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchAudio> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchAudioAll.HandleId, ConfigFloroRanchAudioAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchAudio> readOnlyList = (IReadOnlyList<FloroRanchAudio>)ConfigCommon.GetConfig("FloroRanchAudioAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchAudio> list = new List<FloroRanchAudio>();
			while (ConfigCommon.Step(ConfigFloroRanchAudioAll.HandleId, false, ConfigFloroRanchAudioAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchAudioAll.HandleId, 0, ConfigFloroRanchAudioAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchAudioAll.HandleId, ConfigFloroRanchAudioAll.LogPair);
					return null;
				}
				FloroRanchAudio rootAsFloroRanchAudio = FloroRanchAudio.GetRootAsFloroRanchAudio(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchAudio);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchAudioAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchAudioAll.HandleId, ConfigFloroRanchAudioAll.LogPair);
			return list;
		}

		// Token: 0x04001538 RID: 5432
		private const string DB = "db_flororanch.db";

		// Token: 0x04001539 RID: 5433
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400153A RID: 5434
		private const string TABLE = "FloroRanchAudio";

		// Token: 0x0400153B RID: 5435
		private const string COMMAND = "select BinData from `FloroRanchAudio`";

		// Token: 0x0400153C RID: 5436
		private const string KEY_PREFIX = "FloroRanchAudioAll";

		// Token: 0x0400153D RID: 5437
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400153E RID: 5438
		private static int HandleId;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000967 RID: 2407
	public class ConfigSpeakerAfterChangeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600387E RID: 14462 RVA: 0x00198F6C File Offset: 0x0019716C
		static ConfigSpeakerAfterChangeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpeakerAfterChangeAll.CreateStaticDefaultValue), new Action(ConfigSpeakerAfterChangeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x00198F8C File Offset: 0x0019718C
		public static void CreateStaticDefaultValue()
		{
			ConfigSpeakerAfterChangeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpeakerAfterChangeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "SpeakerAfterChange"),
				new ValueTuple<string, object>("语句", "select BinData from `SpeakerAfterChange`")
			});
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x0019900B File Offset: 0x0019720B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpeakerAfterChangeAll.LogPair = null;
			ConfigSpeakerAfterChangeAll.HandleId = 0;
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x00199019 File Offset: 0x00197219
		public static void Init()
		{
			ConfigSpeakerAfterChangeAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpeakerAfterChangeAll.HandleId, "db_phonemsg.db", "select BinData from `SpeakerAfterChange`");
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x00199034 File Offset: 0x00197234
		[NullableContext(2)]
		public static IReadOnlyList<SpeakerAfterChange> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpeakerAfterChangeAll.HandleId, ConfigSpeakerAfterChangeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SpeakerAfterChange> readOnlyList = (IReadOnlyList<SpeakerAfterChange>)ConfigCommon.GetConfig("SpeakerAfterChangeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SpeakerAfterChange> list = new List<SpeakerAfterChange>();
			while (ConfigCommon.Step(ConfigSpeakerAfterChangeAll.HandleId, false, ConfigSpeakerAfterChangeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpeakerAfterChangeAll.HandleId, 0, ConfigSpeakerAfterChangeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpeakerAfterChangeAll.HandleId, ConfigSpeakerAfterChangeAll.LogPair);
					return null;
				}
				SpeakerAfterChange rootAsSpeakerAfterChange = SpeakerAfterChange.GetRootAsSpeakerAfterChange(new ByteBuffer(item2));
				list.Add(rootAsSpeakerAfterChange);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SpeakerAfterChangeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpeakerAfterChangeAll.HandleId, ConfigSpeakerAfterChangeAll.LogPair);
			return list;
		}

		// Token: 0x040041B7 RID: 16823
		private const string DB = "db_phonemsg.db";

		// Token: 0x040041B8 RID: 16824
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040041B9 RID: 16825
		private const string TABLE = "SpeakerAfterChange";

		// Token: 0x040041BA RID: 16826
		private const string COMMAND = "select BinData from `SpeakerAfterChange`";

		// Token: 0x040041BB RID: 16827
		private const string KEY_PREFIX = "SpeakerAfterChangeAll";

		// Token: 0x040041BC RID: 16828
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041BD RID: 16829
		private static int HandleId;
	}
}

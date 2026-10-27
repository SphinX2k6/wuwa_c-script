using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200096A RID: 2410
	public class ConfigSpeakerChangeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003890 RID: 14480 RVA: 0x00199590 File Offset: 0x00197790
		static ConfigSpeakerChangeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpeakerChangeAll.CreateStaticDefaultValue), new Action(ConfigSpeakerChangeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x001995B0 File Offset: 0x001977B0
		public static void CreateStaticDefaultValue()
		{
			ConfigSpeakerChangeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpeakerChangeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "SpeakerChange"),
				new ValueTuple<string, object>("语句", "select BinData from `SpeakerChange`")
			});
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x0019962F File Offset: 0x0019782F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpeakerChangeAll.LogPair = null;
			ConfigSpeakerChangeAll.HandleId = 0;
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x0019963D File Offset: 0x0019783D
		public static void Init()
		{
			ConfigSpeakerChangeAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpeakerChangeAll.HandleId, "db_phonemsg.db", "select BinData from `SpeakerChange`");
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x00199658 File Offset: 0x00197858
		[NullableContext(2)]
		public static IReadOnlyList<SpeakerChange> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpeakerChangeAll.HandleId, ConfigSpeakerChangeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SpeakerChange> readOnlyList = (IReadOnlyList<SpeakerChange>)ConfigCommon.GetConfig("SpeakerChangeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SpeakerChange> list = new List<SpeakerChange>();
			while (ConfigCommon.Step(ConfigSpeakerChangeAll.HandleId, false, ConfigSpeakerChangeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpeakerChangeAll.HandleId, 0, ConfigSpeakerChangeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpeakerChangeAll.HandleId, ConfigSpeakerChangeAll.LogPair);
					return null;
				}
				SpeakerChange rootAsSpeakerChange = SpeakerChange.GetRootAsSpeakerChange(new ByteBuffer(item2));
				list.Add(rootAsSpeakerChange);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SpeakerChangeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpeakerChangeAll.HandleId, ConfigSpeakerChangeAll.LogPair);
			return list;
		}

		// Token: 0x040041CC RID: 16844
		private const string DB = "db_phonemsg.db";

		// Token: 0x040041CD RID: 16845
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040041CE RID: 16846
		private const string TABLE = "SpeakerChange";

		// Token: 0x040041CF RID: 16847
		private const string COMMAND = "select BinData from `SpeakerChange`";

		// Token: 0x040041D0 RID: 16848
		private const string KEY_PREFIX = "SpeakerChangeAll";

		// Token: 0x040041D1 RID: 16849
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041D2 RID: 16850
		private static int HandleId;
	}
}

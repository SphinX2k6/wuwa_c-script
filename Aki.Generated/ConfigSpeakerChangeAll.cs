using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A3F RID: 2623
	public class ConfigSpeakerChangeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D8E RID: 15758 RVA: 0x001B8924 File Offset: 0x001B6B24
		static ConfigSpeakerChangeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpeakerChangeAll.CreateStaticDefaultValue), new Action(ConfigSpeakerChangeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x001B8944 File Offset: 0x001B6B44
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

		// Token: 0x06003D90 RID: 15760 RVA: 0x001B89C3 File Offset: 0x001B6BC3
		public static void ResetStaticDefaultValue()
		{
			ConfigSpeakerChangeAll.LogPair = null;
			ConfigSpeakerChangeAll.HandleId = 0;
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x001B89D1 File Offset: 0x001B6BD1
		public static void Init()
		{
			ConfigSpeakerChangeAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpeakerChangeAll.HandleId, "db_phonemsg.db", "select BinData from `SpeakerChange`");
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x001B89EC File Offset: 0x001B6BEC
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

		// Token: 0x0400479F RID: 18335
		private const string DB = "db_phonemsg.db";

		// Token: 0x040047A0 RID: 18336
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040047A1 RID: 18337
		private const string TABLE = "SpeakerChange";

		// Token: 0x040047A2 RID: 18338
		private const string COMMAND = "select BinData from `SpeakerChange`";

		// Token: 0x040047A3 RID: 18339
		private const string KEY_PREFIX = "SpeakerChangeAll";

		// Token: 0x040047A4 RID: 18340
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047A5 RID: 18341
		private static int HandleId;
	}
}

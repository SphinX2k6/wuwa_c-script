using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A3C RID: 2620
	public class ConfigSpeakerAfterChangeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D7C RID: 15740 RVA: 0x001B8300 File Offset: 0x001B6500
		static ConfigSpeakerAfterChangeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpeakerAfterChangeAll.CreateStaticDefaultValue), new Action(ConfigSpeakerAfterChangeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x001B8320 File Offset: 0x001B6520
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

		// Token: 0x06003D7E RID: 15742 RVA: 0x001B839F File Offset: 0x001B659F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpeakerAfterChangeAll.LogPair = null;
			ConfigSpeakerAfterChangeAll.HandleId = 0;
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x001B83AD File Offset: 0x001B65AD
		public static void Init()
		{
			ConfigSpeakerAfterChangeAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpeakerAfterChangeAll.HandleId, "db_phonemsg.db", "select BinData from `SpeakerAfterChange`");
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x001B83C8 File Offset: 0x001B65C8
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

		// Token: 0x0400478A RID: 18314
		private const string DB = "db_phonemsg.db";

		// Token: 0x0400478B RID: 18315
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x0400478C RID: 18316
		private const string TABLE = "SpeakerAfterChange";

		// Token: 0x0400478D RID: 18317
		private const string COMMAND = "select BinData from `SpeakerAfterChange`";

		// Token: 0x0400478E RID: 18318
		private const string KEY_PREFIX = "SpeakerAfterChangeAll";

		// Token: 0x0400478F RID: 18319
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004790 RID: 18320
		private static int HandleId;
	}
}

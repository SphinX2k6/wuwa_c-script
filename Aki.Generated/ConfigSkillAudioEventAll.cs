using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200097B RID: 2427
	public class ConfigSkillAudioEventAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038F5 RID: 14581 RVA: 0x0019E9E5 File Offset: 0x0019CBE5
		static ConfigSkillAudioEventAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillAudioEventAll.CreateStaticDefaultValue), new Action(ConfigSkillAudioEventAll.ResetStaticDefaultValue));
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x0019EA04 File Offset: 0x0019CC04
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillAudioEventAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillAudioEventAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillaudioevent.db"),
				new ValueTuple<string, object>("文件", "y.音频_技能音频.xlsx"),
				new ValueTuple<string, object>("表名", "SkillAudioEvent"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillAudioEvent`")
			});
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x0019EA83 File Offset: 0x0019CC83
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillAudioEventAll.LogPair = null;
			ConfigSkillAudioEventAll.HandleId = 0;
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x0019EA91 File Offset: 0x0019CC91
		public static void Init()
		{
			ConfigSkillAudioEventAll.HandleId = ConfigCommon.InitDataStatement(ConfigSkillAudioEventAll.HandleId, "db_skillaudioevent.db", "select BinData from `SkillAudioEvent`");
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x0019EAAC File Offset: 0x0019CCAC
		[NullableContext(2)]
		public static IReadOnlyList<SkillAudioEvent> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillAudioEventAll.HandleId, ConfigSkillAudioEventAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SkillAudioEvent> readOnlyList = (IReadOnlyList<SkillAudioEvent>)ConfigCommon.GetConfig("SkillAudioEventAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SkillAudioEvent> list = new List<SkillAudioEvent>();
			while (ConfigCommon.Step(ConfigSkillAudioEventAll.HandleId, false, ConfigSkillAudioEventAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillAudioEventAll.HandleId, 0, ConfigSkillAudioEventAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillAudioEventAll.HandleId, ConfigSkillAudioEventAll.LogPair);
					return null;
				}
				SkillAudioEvent rootAsSkillAudioEvent = SkillAudioEvent.GetRootAsSkillAudioEvent(new ByteBuffer(item2));
				list.Add(rootAsSkillAudioEvent);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SkillAudioEventAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillAudioEventAll.HandleId, ConfigSkillAudioEventAll.LogPair);
			return list;
		}

		// Token: 0x04004243 RID: 16963
		private const string DB = "db_skillaudioevent.db";

		// Token: 0x04004244 RID: 16964
		private const string FILE = "y.音频_技能音频.xlsx";

		// Token: 0x04004245 RID: 16965
		private const string TABLE = "SkillAudioEvent";

		// Token: 0x04004246 RID: 16966
		private const string COMMAND = "select BinData from `SkillAudioEvent`";

		// Token: 0x04004247 RID: 16967
		private const string KEY_PREFIX = "SkillAudioEventAll";

		// Token: 0x04004248 RID: 16968
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004249 RID: 16969
		private static int HandleId;
	}
}

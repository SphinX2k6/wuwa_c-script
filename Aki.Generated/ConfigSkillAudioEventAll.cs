using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000930 RID: 2352
	public class ConfigSkillAudioEventAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003733 RID: 14131 RVA: 0x001917C5 File Offset: 0x0018F9C5
		static ConfigSkillAudioEventAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillAudioEventAll.CreateStaticDefaultValue), new Action(ConfigSkillAudioEventAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x001917E4 File Offset: 0x0018F9E4
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

		// Token: 0x06003735 RID: 14133 RVA: 0x00191863 File Offset: 0x0018FA63
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillAudioEventAll.LogPair = null;
			ConfigSkillAudioEventAll.HandleId = 0;
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x00191871 File Offset: 0x0018FA71
		public static void Init()
		{
			ConfigSkillAudioEventAll.HandleId = ConfigCommon.InitDataStatement(ConfigSkillAudioEventAll.HandleId, "db_skillaudioevent.db", "select BinData from `SkillAudioEvent`");
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x0019188C File Offset: 0x0018FA8C
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

		// Token: 0x04004036 RID: 16438
		private const string DB = "db_skillaudioevent.db";

		// Token: 0x04004037 RID: 16439
		private const string FILE = "y.音频_技能音频.xlsx";

		// Token: 0x04004038 RID: 16440
		private const string TABLE = "SkillAudioEvent";

		// Token: 0x04004039 RID: 16441
		private const string COMMAND = "select BinData from `SkillAudioEvent`";

		// Token: 0x0400403A RID: 16442
		private const string KEY_PREFIX = "SkillAudioEventAll";

		// Token: 0x0400403B RID: 16443
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400403C RID: 16444
		private static int HandleId;
	}
}

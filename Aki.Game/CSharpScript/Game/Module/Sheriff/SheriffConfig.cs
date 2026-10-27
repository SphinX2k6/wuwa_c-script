using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C2C RID: 19500
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class SheriffConfig : ConfigBase
	{
		// Token: 0x06032747 RID: 206663 RVA: 0x00BC1DB4 File Offset: 0x00BBFFB4
		public SheriffAnomaly? GetAnomalyConfigById(int id)
		{
			SheriffAnomaly? config = ConfigSheriffAnomalyById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SheriffAnomaly数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06032748 RID: 206664 RVA: 0x00BC1E04 File Offset: 0x00BC0004
		public SheriffClue? GetClueConfigById(int id)
		{
			SheriffClue? config = ConfigSheriffClueById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SheriffClue数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06032749 RID: 206665 RVA: 0x00BC1E54 File Offset: 0x00BC0054
		public SheriffAnomaly? GetAnomalyConfigByQuestionId(int questionId)
		{
			SheriffAnomaly? config = ConfigSheriffAnomalyByQuestionId.GetConfig(questionId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SheriffAnomaly数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("QuestionId", questionId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603274A RID: 206666 RVA: 0x00BC1EA4 File Offset: 0x00BC00A4
		public IReadOnlyList<SheriffClue> GetAllClueConfig()
		{
			IReadOnlyList<SheriffClue> configList = ConfigSheriffClueAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.Sheriff, ELogAuthor.WHJ, "SheriffClue数据无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			IReadOnlyList<SheriffClue> readOnlyList = configList;
			return readOnlyList ?? new List<SheriffClue>();
		}

		// Token: 0x0603274B RID: 206667 RVA: 0x00BC1EE4 File Offset: 0x00BC00E4
		public SheriffCriminal? GetCriminalConfigById(int id)
		{
			SheriffCriminal? config = ConfigSheriffCriminalById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SheriffCriminal数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603274C RID: 206668 RVA: 0x00BC1F34 File Offset: 0x00BC0134
		public SheriffCriminal? GetCriminalConfigByIdentityId(int identityId)
		{
			IReadOnlyList<SheriffCriminal> configList = ConfigSheriffCriminalByIdentityId.GetConfigList(identityId, true);
			SheriffCriminal? result = (configList != null && configList.Count > 0) ? new SheriffCriminal?(configList[0]) : null;
			if (result == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SheriffCriminal数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IdentityId", identityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return result;
		}

		// Token: 0x0603274D RID: 206669 RVA: 0x00BC1FA8 File Offset: 0x00BC01A8
		public SheriffEnding? GetEndingConfigById(int id)
		{
			SheriffEnding? config = ConfigSheriffEndingById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SheriffEnding数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603274E RID: 206670 RVA: 0x00BC1FF8 File Offset: 0x00BC01F8
		public SheriffIdentity? GetIdentityConfigById(int id)
		{
			SheriffIdentity? config = ConfigSheriffIdentityById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SheriffIdentity数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603274F RID: 206671 RVA: 0x00BC2048 File Offset: 0x00BC0248
		public SheriffProgress? GetProgressConfigById(int id)
		{
			SheriffProgress? config = ConfigSheriffProgressById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SheriffProgress数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06032750 RID: 206672 RVA: 0x00BC2098 File Offset: 0x00BC0298
		public SheriffZone? GetZoneConfigById(int id)
		{
			SheriffZone? config = ConfigSheriffZoneById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SheriffZone数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06032751 RID: 206673 RVA: 0x00BC20E8 File Offset: 0x00BC02E8
		public IReadOnlyList<SheriffZone> GetZoneConfigAll()
		{
			IReadOnlyList<SheriffZone> configList = ConfigSheriffZoneAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.Sheriff, ELogAuthor.WHJ, "SheriffZone数据无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			IReadOnlyList<SheriffZone> readOnlyList = configList;
			return readOnlyList ?? new List<SheriffZone>();
		}

		// Token: 0x06032752 RID: 206674 RVA: 0x00BC2128 File Offset: 0x00BC0328
		public SheriffQuestionMainCsv? GetQuestionMainById(int id)
		{
			SheriffQuestionMainCsv? config = ConfigSheriffQuestionMainCsvById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SheriffQuestionMain数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06032753 RID: 206675 RVA: 0x00BC2178 File Offset: 0x00BC0378
		public SheriffQuestionCsv? GetQuestionById(int id)
		{
			SheriffQuestionCsv? config = ConfigSheriffQuestionCsvById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SheriffQuestion数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06032754 RID: 206676 RVA: 0x00BC21C8 File Offset: 0x00BC03C8
		public SheriffMap? GetMapConfigById(int id)
		{
			SheriffMap? config = ConfigSheriffMapById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.CB;
				string message = "SheriffMap数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06032755 RID: 206677 RVA: 0x00BC2218 File Offset: 0x00BC0418
		public SheriffAnomaly? GetAnomalyConfigByMarkId(int markId)
		{
			SheriffAnomaly? config = ConfigSheriffAnomalyByMarkId.GetConfig(markId, true);
			if (config == null)
			{
				Log.Instance.Error(ELogModule.Sheriff, ELogAuthor.CB, "SheriffAnomaly数据无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return config;
		}

		// Token: 0x06032756 RID: 206678 RVA: 0x00BC2258 File Offset: 0x00BC0458
		public SheriffQuest? GetQuestConfigByMarkId(int markId)
		{
			SheriffQuest? config = ConfigSheriffQuestByMarkId.GetConfig(markId, true);
			if (config == null)
			{
				Log.Instance.Error(ELogModule.Sheriff, ELogAuthor.CB, "SheriffQuest数据无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return config;
		}

		// Token: 0x06032757 RID: 206679 RVA: 0x00BC2298 File Offset: 0x00BC0498
		public SheriffQuest? GetQuestConfigByQuestId(int questId)
		{
			SheriffQuest? config = ConfigSheriffQuestByQuestId.GetConfig(questId, true);
			if (config == null)
			{
				Log.Instance.Error(ELogModule.Sheriff, ELogAuthor.CB, "SheriffQuest数据无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return config;
		}

		// Token: 0x06032758 RID: 206680 RVA: 0x00BC22D8 File Offset: 0x00BC04D8
		[NullableContext(2)]
		public IReadOnlyList<SheriffQuest> GetQuestConfigByZoneId(int zoneId)
		{
			IReadOnlyList<SheriffQuest> configList = ConfigSheriffQuestByZoneId.GetConfigList(zoneId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.CB;
				string message = "SheriffQuest数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ZoneId", zoneId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x06032759 RID: 206681 RVA: 0x00BC2320 File Offset: 0x00BC0520
		public SheriffAnomaly? GetAnomalyConfigByCriminalId(int criminalId)
		{
			SheriffAnomaly? config = ConfigSheriffAnomalyByCriminalId.GetConfig(criminalId, true);
			if (config == null)
			{
				Log.Instance.Error(ELogModule.Sheriff, ELogAuthor.CB, "SheriffAnomaly数据无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return config;
		}

		// Token: 0x0603275A RID: 206682 RVA: 0x00BC2360 File Offset: 0x00BC0560
		public IReadOnlyList<SheriffProgress> GetProgressConfigListByAnomalyId(int anomalyId)
		{
			IReadOnlyList<SheriffProgress> configList = ConfigSheriffProgressBySheriffAnomalyId.GetConfigList(anomalyId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.CB;
				string message = "SheriffProgress数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", anomalyId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			IReadOnlyList<SheriffProgress> readOnlyList = configList;
			return readOnlyList ?? new List<SheriffProgress>();
		}

		// Token: 0x17007C8E RID: 31886
		// (get) Token: 0x0603275B RID: 206683 RVA: 0x00BC23B1 File Offset: 0x00BC05B1
		public static SheriffConfig Instance
		{
			get
			{
				return SheriffConfig._Instance;
			}
		}

		// Token: 0x0603275C RID: 206684 RVA: 0x00BC23B8 File Offset: 0x00BC05B8
		public static SheriffConfig GetOrCreateInstance()
		{
			if (SheriffConfig._Instance == null)
			{
				SheriffConfig.CreateInstance();
			}
			return SheriffConfig._Instance;
		}

		// Token: 0x0603275D RID: 206685 RVA: 0x00BC23CC File Offset: 0x00BC05CC
		public static bool CreateInstance()
		{
			if (SheriffConfig._Instance != null)
			{
				return true;
			}
			SheriffConfig._Instance = new SheriffConfig();
			return true;
		}

		// Token: 0x0603275E RID: 206686 RVA: 0x00BC23E2 File Offset: 0x00BC05E2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603275F RID: 206687 RVA: 0x00BC23E4 File Offset: 0x00BC05E4
		public static void ResetStaticDefaultValue()
		{
			SheriffConfig._Instance = null;
		}

		// Token: 0x06032760 RID: 206688 RVA: 0x00BC23EC File Offset: 0x00BC05EC
		static SheriffConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SheriffConfig.CreateStaticDefaultValue), new Action(SheriffConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401ADBC RID: 110012
		[Nullable(2)]
		private static SheriffConfig _Instance;
	}
}

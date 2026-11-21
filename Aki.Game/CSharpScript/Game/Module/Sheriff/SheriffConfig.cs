using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BDD RID: 15325
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class SheriffConfig : ConfigBase
	{
		// Token: 0x060274FA RID: 161018 RVA: 0x00B069E4 File Offset: 0x00B04BE4
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

		// Token: 0x060274FB RID: 161019 RVA: 0x00B06A34 File Offset: 0x00B04C34
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

		// Token: 0x060274FC RID: 161020 RVA: 0x00B06A84 File Offset: 0x00B04C84
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

		// Token: 0x060274FD RID: 161021 RVA: 0x00B06AD4 File Offset: 0x00B04CD4
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

		// Token: 0x060274FE RID: 161022 RVA: 0x00B06B14 File Offset: 0x00B04D14
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

		// Token: 0x060274FF RID: 161023 RVA: 0x00B06B64 File Offset: 0x00B04D64
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

		// Token: 0x06027500 RID: 161024 RVA: 0x00B06BD8 File Offset: 0x00B04DD8
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

		// Token: 0x06027501 RID: 161025 RVA: 0x00B06C28 File Offset: 0x00B04E28
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

		// Token: 0x06027502 RID: 161026 RVA: 0x00B06C78 File Offset: 0x00B04E78
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

		// Token: 0x06027503 RID: 161027 RVA: 0x00B06CC8 File Offset: 0x00B04EC8
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

		// Token: 0x06027504 RID: 161028 RVA: 0x00B06D18 File Offset: 0x00B04F18
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

		// Token: 0x06027505 RID: 161029 RVA: 0x00B06D58 File Offset: 0x00B04F58
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

		// Token: 0x06027506 RID: 161030 RVA: 0x00B06DA8 File Offset: 0x00B04FA8
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

		// Token: 0x06027507 RID: 161031 RVA: 0x00B06DF8 File Offset: 0x00B04FF8
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

		// Token: 0x06027508 RID: 161032 RVA: 0x00B06E48 File Offset: 0x00B05048
		public SheriffAnomaly? GetAnomalyConfigByMarkId(int markId)
		{
			SheriffAnomaly? config = ConfigSheriffAnomalyByMarkId.GetConfig(markId, true);
			if (config == null)
			{
				Log.Instance.Error(ELogModule.Sheriff, ELogAuthor.CB, "SheriffAnomaly数据无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return config;
		}

		// Token: 0x06027509 RID: 161033 RVA: 0x00B06E88 File Offset: 0x00B05088
		public SheriffQuest? GetQuestConfigByMarkId(int markId)
		{
			SheriffQuest? config = ConfigSheriffQuestByMarkId.GetConfig(markId, true);
			if (config == null)
			{
				Log.Instance.Error(ELogModule.Sheriff, ELogAuthor.CB, "SheriffQuest数据无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return config;
		}

		// Token: 0x0602750A RID: 161034 RVA: 0x00B06EC8 File Offset: 0x00B050C8
		public SheriffQuest? GetQuestConfigByQuestId(int questId)
		{
			SheriffQuest? config = ConfigSheriffQuestByQuestId.GetConfig(questId, true);
			if (config == null)
			{
				Log.Instance.Error(ELogModule.Sheriff, ELogAuthor.CB, "SheriffQuest数据无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return config;
		}

		// Token: 0x0602750B RID: 161035 RVA: 0x00B06F08 File Offset: 0x00B05108
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

		// Token: 0x0602750C RID: 161036 RVA: 0x00B06F50 File Offset: 0x00B05150
		public SheriffAnomaly? GetAnomalyConfigByCriminalId(int criminalId)
		{
			SheriffAnomaly? config = ConfigSheriffAnomalyByCriminalId.GetConfig(criminalId, true);
			if (config == null)
			{
				Log.Instance.Error(ELogModule.Sheriff, ELogAuthor.CB, "SheriffAnomaly数据无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return config;
		}

		// Token: 0x0602750D RID: 161037 RVA: 0x00B06F90 File Offset: 0x00B05190
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

		// Token: 0x17005038 RID: 20536
		// (get) Token: 0x0602750E RID: 161038 RVA: 0x00B06FE1 File Offset: 0x00B051E1
		public static SheriffConfig Instance
		{
			get
			{
				return SheriffConfig._Instance;
			}
		}

		// Token: 0x0602750F RID: 161039 RVA: 0x00B06FE8 File Offset: 0x00B051E8
		public static SheriffConfig GetOrCreateInstance()
		{
			if (SheriffConfig._Instance == null)
			{
				SheriffConfig.CreateInstance();
			}
			return SheriffConfig._Instance;
		}

		// Token: 0x06027510 RID: 161040 RVA: 0x00B06FFC File Offset: 0x00B051FC
		public static bool CreateInstance()
		{
			if (SheriffConfig._Instance != null)
			{
				return true;
			}
			SheriffConfig._Instance = new SheriffConfig();
			return true;
		}

		// Token: 0x06027511 RID: 161041 RVA: 0x00B07012 File Offset: 0x00B05212
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06027512 RID: 161042 RVA: 0x00B07014 File Offset: 0x00B05214
		public static void ResetStaticDefaultValue()
		{
			SheriffConfig._Instance = null;
		}

		// Token: 0x06027513 RID: 161043 RVA: 0x00B0701C File Offset: 0x00B0521C
		static SheriffConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SheriffConfig.CreateStaticDefaultValue), new Action(SheriffConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04015719 RID: 87833
		[Nullable(2)]
		private static SheriffConfig _Instance;
	}
}

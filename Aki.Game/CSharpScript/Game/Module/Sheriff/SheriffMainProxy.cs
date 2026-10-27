using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C51 RID: 19537
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainProxy
	{
		// Token: 0x06032815 RID: 206869 RVA: 0x00BC3488 File Offset: 0x00BC1688
		public SheriffMainProxy(int gameplayId)
		{
			this.GameplayId = gameplayId;
			SheriffAnomaly? anomalyConfigByQuestionId = SheriffConfig.Instance.GetAnomalyConfigByQuestionId(this.GameplayId);
			this.AnomalyInfo = SheriffModel.Instance.GetAnomalyInfo(anomalyConfigByQuestionId.Value.Id);
		}

		// Token: 0x06032816 RID: 206870 RVA: 0x00BC3517 File Offset: 0x00BC1717
		public void InitData()
		{
			this.InitQuestionConfig();
		}

		// Token: 0x06032817 RID: 206871 RVA: 0x00BC3520 File Offset: 0x00BC1720
		public void InitGameDataOnBegin()
		{
			this.QuestionIds.Clear();
			this.QuestionIds.Add(this.FirstQuestionId);
			this.CurQuestionIndex = 0;
			this.ClueRecordsMap.Clear();
			this.EndingConfigCache = null;
			this.BackFromDetailClue = false;
			this.NeedHintToggle = false;
		}

		// Token: 0x06032818 RID: 206872 RVA: 0x00BC3570 File Offset: 0x00BC1770
		protected void InitQuestionConfig()
		{
			SheriffQuestionMainCsv value = SheriffConfig.Instance.GetQuestionMainById(this.GameplayId).Value;
			if (value.QuestionConfigs.Length == 0)
			{
				return;
			}
			int num = 0;
			using (List<ISheriffQuestionJsonConfig>.Enumerator enumerator = Json.Decode<List<ISheriffQuestionJsonConfig>>(value.QuestionConfigs, null).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ISheriffQuestionJsonConfig sheriffQuestionJsonConfig = enumerator.Current;
					this.QuestionConfigRecord[sheriffQuestionJsonConfig.QuestionId] = sheriffQuestionJsonConfig;
					if (this.FirstQuestionId == 0)
					{
						this.FirstQuestionId = sheriffQuestionJsonConfig.QuestionId;
					}
					if (num == 0)
					{
						num = sheriffQuestionJsonConfig.QuestionId;
					}
				}
				goto IL_14A;
			}
			IL_9A:
			ISheriffQuestionJsonConfig sheriffQuestionJsonConfig2;
			if (!this.QuestionConfigRecord.TryGetValue(num, out sheriffQuestionJsonConfig2))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "SheriffQuestion questionConfig Error";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				goto IL_15A;
			}
			this.QuestionCount++;
			if (sheriffQuestionJsonConfig2.ResultConfigs.Count == 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Sheriff;
				ELogAuthor author2 = ELogAuthor.WHJ;
				string message2 = "SheriffQuestion ResultConfigs Error";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("id", sheriffQuestionJsonConfig2.QuestionId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				goto IL_15A;
			}
			num = sheriffQuestionJsonConfig2.ResultConfigs[0].NextQuestionId.GetValueOrDefault();
			IL_14A:
			if (num != 0 && this.QuestionCount < 10)
			{
				goto IL_9A;
			}
			IL_15A:
			if (this.QuestionCount > 10)
			{
				Log.Instance.Error(ELogModule.Sheriff, ELogAuthor.WHJ, "SheriffQuestion Config Error, QuestionCount > 10", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06032819 RID: 206873 RVA: 0x00BC3714 File Offset: 0x00BC1914
		public int GetCurQuestionIndex()
		{
			return this.CurQuestionIndex;
		}

		// Token: 0x0603281A RID: 206874 RVA: 0x00BC371C File Offset: 0x00BC191C
		public int GetQuestionIdByIndex(int index)
		{
			return this.QuestionIds[index];
		}

		// Token: 0x0603281B RID: 206875 RVA: 0x00BC372A File Offset: 0x00BC192A
		public int GetQuestionDataLength()
		{
			return this.QuestionCount;
		}

		// Token: 0x0603281C RID: 206876 RVA: 0x00BC3734 File Offset: 0x00BC1934
		public List<int> GetClueRecords(int questionIndex)
		{
			List<int> result;
			if (!this.ClueRecordsMap.TryGetValue(questionIndex, out result))
			{
				return new List<int>();
			}
			return result;
		}

		// Token: 0x0603281D RID: 206877 RVA: 0x00BC3758 File Offset: 0x00BC1958
		public void SetClueRecords(int questionIndex, List<int> clueIds)
		{
			this.ClueRecordsMap[questionIndex] = clueIds;
			Action onClueRecordsCallback = this.OnClueRecordsCallback;
			if (onClueRecordsCallback == null)
			{
				return;
			}
			onClueRecordsCallback();
		}

		// Token: 0x0603281E RID: 206878 RVA: 0x00BC3777 File Offset: 0x00BC1977
		public List<int> GetQuestionList()
		{
			return this.QuestionIds;
		}

		// Token: 0x0603281F RID: 206879 RVA: 0x00BC377F File Offset: 0x00BC197F
		public void ClickClueDetail(int clueIndex)
		{
			this.NeedRemainHoverItem = true;
			this.ConfirmClueIndex = this.GamepadHoverIndex;
			this.CurrentClickedClueIndex = clueIndex;
			Action onCheckClueDetailCallback = this.OnCheckClueDetailCallback;
			if (onCheckClueDetailCallback == null)
			{
				return;
			}
			onCheckClueDetailCallback();
		}

		// Token: 0x06032820 RID: 206880 RVA: 0x00BC37AB File Offset: 0x00BC19AB
		public void OnHoverClue(int index)
		{
			this.GamepadHoverIndex = index;
		}

		// Token: 0x06032821 RID: 206881 RVA: 0x00BC37B4 File Offset: 0x00BC19B4
		public void CloseClueDetail()
		{
			this.BackFromDetailClue = true;
			Action onBackFromDetailClueCallback = this.OnBackFromDetailClueCallback;
			if (onBackFromDetailClueCallback == null)
			{
				return;
			}
			onBackFromDetailClueCallback();
		}

		// Token: 0x06032822 RID: 206882 RVA: 0x00BC37CD File Offset: 0x00BC19CD
		public SheriffAnomalyInfo GetAnomalyInfo()
		{
			return this.AnomalyInfo;
		}

		// Token: 0x06032823 RID: 206883 RVA: 0x00BC37D8 File Offset: 0x00BC19D8
		public int GetCurrentClueLength()
		{
			int id = this.QuestionIds[this.CurQuestionIndex];
			return SheriffConfig.Instance.GetQuestionById(id).Value.NeedClueCount;
		}

		// Token: 0x06032824 RID: 206884 RVA: 0x00BC3814 File Offset: 0x00BC1A14
		public void SetConclusionKey(string key)
		{
			int questionIdByIndex = this.GetQuestionIdByIndex(this.CurQuestionIndex);
			this.ConclusionKeyMap[questionIdByIndex] = key;
		}

		// Token: 0x06032825 RID: 206885 RVA: 0x00BC383C File Offset: 0x00BC1A3C
		public string GetConclusionKey(int questionId)
		{
			string result;
			if (!this.ConclusionKeyMap.TryGetValue(questionId, out result))
			{
				return "";
			}
			return result;
		}

		// Token: 0x06032826 RID: 206886 RVA: 0x00BC3860 File Offset: 0x00BC1A60
		public ISheriffQuestionJsonConfig GetQuestionConfig(int questionId)
		{
			return this.QuestionConfigRecord[questionId];
		}

		// Token: 0x06032827 RID: 206887 RVA: 0x00BC3870 File Offset: 0x00BC1A70
		public List<string> GetBeforeDialogStateId()
		{
			int questionIdByIndex = this.GetQuestionIdByIndex(this.CurQuestionIndex);
			return SheriffConfig.Instance.GetQuestionById(questionIdByIndex).Value.EnterFlowStateId().ToList<string>();
		}

		// Token: 0x06032828 RID: 206888 RVA: 0x00BC38AC File Offset: 0x00BC1AAC
		[NullableContext(2)]
		public void DoAfterAnalysisClueLogic(bool isReset, ISheriffQuestionResultJsonConfig config = null)
		{
			this.SetNeedHintToggle(false);
			if (isReset)
			{
				this.NeedRemainHoverItem = true;
				this.ConfirmClueIndex = this.GamepadHoverIndex;
				this.ClueRecordsMap.Remove(this.GetCurQuestionIndex());
				Action<bool> onAnalysisClueEndCallback = this.OnAnalysisClueEndCallback;
				if (onAnalysisClueEndCallback == null)
				{
					return;
				}
				onAnalysisClueEndCallback(false);
				return;
			}
			else if (config != null && config.EndingId != null)
			{
				this.EndingConfigCache = config;
				Action onConclusionInfoCallback = this.OnConclusionInfoCallback;
				if (onConclusionInfoCallback == null)
				{
					return;
				}
				onConclusionInfoCallback();
				return;
			}
			else
			{
				this.QuestionIds.Add(config.NextQuestionId.Value);
				this.CurQuestionIndex++;
				Action<bool> onAnalysisClueEndCallback2 = this.OnAnalysisClueEndCallback;
				if (onAnalysisClueEndCallback2 == null)
				{
					return;
				}
				onAnalysisClueEndCallback2(true);
				return;
			}
		}

		// Token: 0x06032829 RID: 206889 RVA: 0x00BC3960 File Offset: 0x00BC1B60
		public void RestartGameplay()
		{
			this.InitGameDataOnBegin();
			Action<bool> onAnalysisClueEndCallback = this.OnAnalysisClueEndCallback;
			if (onAnalysisClueEndCallback == null)
			{
				return;
			}
			onAnalysisClueEndCallback(true);
		}

		// Token: 0x0603282A RID: 206890 RVA: 0x00BC3979 File Offset: 0x00BC1B79
		public void CloseGameplay()
		{
			Action onGameplayAllEndCallback = this.OnGameplayAllEndCallback;
			if (onGameplayAllEndCallback == null)
			{
				return;
			}
			onGameplayAllEndCallback();
		}

		// Token: 0x0603282B RID: 206891 RVA: 0x00BC398B File Offset: 0x00BC1B8B
		public void ReplaySelectClueDialog()
		{
			Action onClickedReplayDialog = this.OnClickedReplayDialog;
			if (onClickedReplayDialog == null)
			{
				return;
			}
			onClickedReplayDialog();
		}

		// Token: 0x0603282C RID: 206892 RVA: 0x00BC39A0 File Offset: 0x00BC1BA0
		[NullableContext(0)]
		public UniTask<bool> RequestConfirm()
		{
			SheriffMainProxy.<RequestConfirm>d__49 <RequestConfirm>d__;
			<RequestConfirm>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestConfirm>d__.<>4__this = this;
			<RequestConfirm>d__.<>1__state = -1;
			<RequestConfirm>d__.<>t__builder.Start<SheriffMainProxy.<RequestConfirm>d__49>(ref <RequestConfirm>d__);
			return <RequestConfirm>d__.<>t__builder.Task;
		}

		// Token: 0x0603282D RID: 206893 RVA: 0x00BC39E4 File Offset: 0x00BC1BE4
		public bool CheckNeedHintButton()
		{
			int questionIdByIndex = this.GetQuestionIdByIndex(this.GetCurQuestionIndex());
			SheriffQuestionCsv value = SheriffConfig.Instance.GetQuestionById(questionIdByIndex).Value;
			int num;
			bool flag = (this.FailureCountMap.TryGetValue(questionIdByIndex, out num) ? num : 0) >= value.SoftPityCount;
			bool flag2 = true;
			foreach (int item in value.SoftPityClueIds())
			{
				if (!this.AnomalyInfo.ClueIds.Contains(item))
				{
					flag2 = false;
					break;
				}
			}
			return flag && flag2;
		}

		// Token: 0x0603282E RID: 206894 RVA: 0x00BC3A78 File Offset: 0x00BC1C78
		public void SetFailureCount()
		{
			int questionIdByIndex = this.GetQuestionIdByIndex(this.GetCurQuestionIndex());
			int num2;
			int num = this.FailureCountMap.TryGetValue(questionIdByIndex, out num2) ? num2 : 0;
			this.FailureCountMap[questionIdByIndex] = num + 1;
		}

		// Token: 0x0603282F RID: 206895 RVA: 0x00BC3AB6 File Offset: 0x00BC1CB6
		public bool CheckNeedHintToggle()
		{
			return this.NeedHintToggle;
		}

		// Token: 0x06032830 RID: 206896 RVA: 0x00BC3ABE File Offset: 0x00BC1CBE
		public void SetNeedHintToggle(bool needHintToggle)
		{
			this.NeedHintToggle = needHintToggle;
		}

		// Token: 0x06032831 RID: 206897 RVA: 0x00BC3AC8 File Offset: 0x00BC1CC8
		public bool CheckIsHinting(int clueId)
		{
			if (clueId <= 0)
			{
				return false;
			}
			if (!this.CheckNeedHintToggle())
			{
				return false;
			}
			int questionIdByIndex = this.GetQuestionIdByIndex(this.GetCurQuestionIndex());
			return SheriffConfig.Instance.GetQuestionById(questionIdByIndex).Value.SoftPityClueIds().Contains(clueId);
		}

		// Token: 0x06032832 RID: 206898 RVA: 0x00BC3B13 File Offset: 0x00BC1D13
		public void RefreshHintToggleState()
		{
			Action onClueHintStateChangeCallback = this.OnClueHintStateChangeCallback;
			if (onClueHintStateChangeCallback == null)
			{
				return;
			}
			onClueHintStateChangeCallback();
		}

		// Token: 0x06032833 RID: 206899 RVA: 0x00BC3B25 File Offset: 0x00BC1D25
		public void RefreshHintButtonEnable(bool isCurIndex)
		{
			Action<bool> onRefreshHintButton = this.OnRefreshHintButton;
			if (onRefreshHintButton == null)
			{
				return;
			}
			onRefreshHintButton(isCurIndex);
		}

		// Token: 0x0401AE32 RID: 110130
		[Nullable(2)]
		public Action OnClueRecordsCallback;

		// Token: 0x0401AE33 RID: 110131
		[Nullable(2)]
		public Action<bool> OnAnalysisClueEndCallback;

		// Token: 0x0401AE34 RID: 110132
		[Nullable(2)]
		public Action OnBackFromDetailClueCallback;

		// Token: 0x0401AE35 RID: 110133
		[Nullable(2)]
		public Action OnCheckClueDetailCallback;

		// Token: 0x0401AE36 RID: 110134
		[Nullable(2)]
		public Action OnConclusionInfoCallback;

		// Token: 0x0401AE37 RID: 110135
		[Nullable(2)]
		public Action OnGameplayAllEndCallback;

		// Token: 0x0401AE38 RID: 110136
		[Nullable(2)]
		public Action OnClueHintStateChangeCallback;

		// Token: 0x0401AE39 RID: 110137
		[Nullable(2)]
		public Action OnClickedReplayDialog;

		// Token: 0x0401AE3A RID: 110138
		[Nullable(2)]
		public Action<bool> OnRefreshHintButton;

		// Token: 0x0401AE3B RID: 110139
		public int CurrentClickedClueIndex;

		// Token: 0x0401AE3C RID: 110140
		public bool BackFromDetailClue;

		// Token: 0x0401AE3D RID: 110141
		protected int CurQuestionIndex;

		// Token: 0x0401AE3E RID: 110142
		protected int QuestionCount;

		// Token: 0x0401AE3F RID: 110143
		public bool NeedRemainHoverItem;

		// Token: 0x0401AE40 RID: 110144
		public int GamepadHoverIndex = -1;

		// Token: 0x0401AE41 RID: 110145
		public int ConfirmClueIndex = -1;

		// Token: 0x0401AE42 RID: 110146
		protected List<int> QuestionIds = new List<int>();

		// Token: 0x0401AE43 RID: 110147
		protected Dictionary<int, ISheriffQuestionJsonConfig> QuestionConfigRecord = new Dictionary<int, ISheriffQuestionJsonConfig>();

		// Token: 0x0401AE44 RID: 110148
		protected Dictionary<int, List<int>> ClueRecordsMap = new Dictionary<int, List<int>>();

		// Token: 0x0401AE45 RID: 110149
		protected SheriffAnomalyInfo AnomalyInfo;

		// Token: 0x0401AE46 RID: 110150
		protected Dictionary<int, string> ConclusionKeyMap = new Dictionary<int, string>();

		// Token: 0x0401AE47 RID: 110151
		protected int FirstQuestionId;

		// Token: 0x0401AE48 RID: 110152
		[Nullable(2)]
		protected ISheriffQuestionResultJsonConfig EndingConfigCache;

		// Token: 0x0401AE49 RID: 110153
		protected Dictionary<int, int> FailureCountMap = new Dictionary<int, int>();

		// Token: 0x0401AE4A RID: 110154
		protected bool NeedHintToggle;

		// Token: 0x0401AE4B RID: 110155
		protected int GameplayId;
	}
}

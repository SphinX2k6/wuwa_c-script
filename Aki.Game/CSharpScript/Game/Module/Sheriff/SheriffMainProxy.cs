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
	// Token: 0x02003C02 RID: 15362
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainProxy
	{
		// Token: 0x060275C8 RID: 161224 RVA: 0x00B080A0 File Offset: 0x00B062A0
		public SheriffMainProxy(int gameplayId)
		{
			this.GameplayId = gameplayId;
			SheriffAnomaly? anomalyConfigByQuestionId = SheriffConfig.Instance.GetAnomalyConfigByQuestionId(this.GameplayId);
			this.AnomalyInfo = SheriffModel.Instance.GetAnomalyInfo(anomalyConfigByQuestionId.Value.Id);
		}

		// Token: 0x060275C9 RID: 161225 RVA: 0x00B0812F File Offset: 0x00B0632F
		public void InitData()
		{
			this.InitQuestionConfig();
		}

		// Token: 0x060275CA RID: 161226 RVA: 0x00B08138 File Offset: 0x00B06338
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

		// Token: 0x060275CB RID: 161227 RVA: 0x00B08188 File Offset: 0x00B06388
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

		// Token: 0x060275CC RID: 161228 RVA: 0x00B0832C File Offset: 0x00B0652C
		public int GetCurQuestionIndex()
		{
			return this.CurQuestionIndex;
		}

		// Token: 0x060275CD RID: 161229 RVA: 0x00B08334 File Offset: 0x00B06534
		public int GetQuestionIdByIndex(int index)
		{
			return this.QuestionIds[index];
		}

		// Token: 0x060275CE RID: 161230 RVA: 0x00B08342 File Offset: 0x00B06542
		public int GetQuestionDataLength()
		{
			return this.QuestionCount;
		}

		// Token: 0x060275CF RID: 161231 RVA: 0x00B0834C File Offset: 0x00B0654C
		public List<int> GetClueRecords(int questionIndex)
		{
			List<int> result;
			if (!this.ClueRecordsMap.TryGetValue(questionIndex, out result))
			{
				return new List<int>();
			}
			return result;
		}

		// Token: 0x060275D0 RID: 161232 RVA: 0x00B08370 File Offset: 0x00B06570
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

		// Token: 0x060275D1 RID: 161233 RVA: 0x00B0838F File Offset: 0x00B0658F
		public List<int> GetQuestionList()
		{
			return this.QuestionIds;
		}

		// Token: 0x060275D2 RID: 161234 RVA: 0x00B08397 File Offset: 0x00B06597
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

		// Token: 0x060275D3 RID: 161235 RVA: 0x00B083C3 File Offset: 0x00B065C3
		public void OnHoverClue(int index)
		{
			this.GamepadHoverIndex = index;
		}

		// Token: 0x060275D4 RID: 161236 RVA: 0x00B083CC File Offset: 0x00B065CC
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

		// Token: 0x060275D5 RID: 161237 RVA: 0x00B083E5 File Offset: 0x00B065E5
		public SheriffAnomalyInfo GetAnomalyInfo()
		{
			return this.AnomalyInfo;
		}

		// Token: 0x060275D6 RID: 161238 RVA: 0x00B083F0 File Offset: 0x00B065F0
		public int GetCurrentClueLength()
		{
			int id = this.QuestionIds[this.CurQuestionIndex];
			return SheriffConfig.Instance.GetQuestionById(id).Value.NeedClueCount;
		}

		// Token: 0x060275D7 RID: 161239 RVA: 0x00B0842C File Offset: 0x00B0662C
		public void SetConclusionKey(string key)
		{
			int questionIdByIndex = this.GetQuestionIdByIndex(this.CurQuestionIndex);
			this.ConclusionKeyMap[questionIdByIndex] = key;
		}

		// Token: 0x060275D8 RID: 161240 RVA: 0x00B08454 File Offset: 0x00B06654
		public string GetConclusionKey(int questionId)
		{
			string result;
			if (!this.ConclusionKeyMap.TryGetValue(questionId, out result))
			{
				return "";
			}
			return result;
		}

		// Token: 0x060275D9 RID: 161241 RVA: 0x00B08478 File Offset: 0x00B06678
		public ISheriffQuestionJsonConfig GetQuestionConfig(int questionId)
		{
			return this.QuestionConfigRecord[questionId];
		}

		// Token: 0x060275DA RID: 161242 RVA: 0x00B08488 File Offset: 0x00B06688
		public List<string> GetBeforeDialogStateId()
		{
			int questionIdByIndex = this.GetQuestionIdByIndex(this.CurQuestionIndex);
			return SheriffConfig.Instance.GetQuestionById(questionIdByIndex).Value.EnterFlowStateId().ToList<string>();
		}

		// Token: 0x060275DB RID: 161243 RVA: 0x00B084C4 File Offset: 0x00B066C4
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

		// Token: 0x060275DC RID: 161244 RVA: 0x00B08578 File Offset: 0x00B06778
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

		// Token: 0x060275DD RID: 161245 RVA: 0x00B08591 File Offset: 0x00B06791
		public void CloseGameplay()
		{
			Action onGameplayAllEndCallback = this.OnGameplayAllEndCallback;
			if (onGameplayAllEndCallback == null)
			{
				return;
			}
			onGameplayAllEndCallback();
		}

		// Token: 0x060275DE RID: 161246 RVA: 0x00B085A3 File Offset: 0x00B067A3
		public void ReplaySelectClueDialog()
		{
			Action onClickedReplayDialog = this.OnClickedReplayDialog;
			if (onClickedReplayDialog == null)
			{
				return;
			}
			onClickedReplayDialog();
		}

		// Token: 0x060275DF RID: 161247 RVA: 0x00B085B8 File Offset: 0x00B067B8
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

		// Token: 0x060275E0 RID: 161248 RVA: 0x00B085FC File Offset: 0x00B067FC
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

		// Token: 0x060275E1 RID: 161249 RVA: 0x00B08690 File Offset: 0x00B06890
		public void SetFailureCount()
		{
			int questionIdByIndex = this.GetQuestionIdByIndex(this.GetCurQuestionIndex());
			int num2;
			int num = this.FailureCountMap.TryGetValue(questionIdByIndex, out num2) ? num2 : 0;
			this.FailureCountMap[questionIdByIndex] = num + 1;
		}

		// Token: 0x060275E2 RID: 161250 RVA: 0x00B086CE File Offset: 0x00B068CE
		public bool CheckNeedHintToggle()
		{
			return this.NeedHintToggle;
		}

		// Token: 0x060275E3 RID: 161251 RVA: 0x00B086D6 File Offset: 0x00B068D6
		public void SetNeedHintToggle(bool needHintToggle)
		{
			this.NeedHintToggle = needHintToggle;
		}

		// Token: 0x060275E4 RID: 161252 RVA: 0x00B086E0 File Offset: 0x00B068E0
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
			return Array.IndexOf<int>(SheriffConfig.Instance.GetQuestionById(questionIdByIndex).Value.SoftPityClueIds(), clueId) >= 0;
		}

		// Token: 0x060275E5 RID: 161253 RVA: 0x00B08731 File Offset: 0x00B06931
		public void RefreshHintToggleState()
		{
			Action onClueHintStateChangeCallback = this.OnClueHintStateChangeCallback;
			if (onClueHintStateChangeCallback == null)
			{
				return;
			}
			onClueHintStateChangeCallback();
		}

		// Token: 0x060275E6 RID: 161254 RVA: 0x00B08743 File Offset: 0x00B06943
		public void RefreshHintButtonEnable(bool isCurIndex)
		{
			Action<bool> onRefreshHintButton = this.OnRefreshHintButton;
			if (onRefreshHintButton == null)
			{
				return;
			}
			onRefreshHintButton(isCurIndex);
		}

		// Token: 0x0401578F RID: 87951
		[Nullable(2)]
		public Action OnClueRecordsCallback;

		// Token: 0x04015790 RID: 87952
		[Nullable(2)]
		public Action<bool> OnAnalysisClueEndCallback;

		// Token: 0x04015791 RID: 87953
		[Nullable(2)]
		public Action OnBackFromDetailClueCallback;

		// Token: 0x04015792 RID: 87954
		[Nullable(2)]
		public Action OnCheckClueDetailCallback;

		// Token: 0x04015793 RID: 87955
		[Nullable(2)]
		public Action OnConclusionInfoCallback;

		// Token: 0x04015794 RID: 87956
		[Nullable(2)]
		public Action OnGameplayAllEndCallback;

		// Token: 0x04015795 RID: 87957
		[Nullable(2)]
		public Action OnClueHintStateChangeCallback;

		// Token: 0x04015796 RID: 87958
		[Nullable(2)]
		public Action OnClickedReplayDialog;

		// Token: 0x04015797 RID: 87959
		[Nullable(2)]
		public Action<bool> OnRefreshHintButton;

		// Token: 0x04015798 RID: 87960
		public int CurrentClickedClueIndex;

		// Token: 0x04015799 RID: 87961
		public bool BackFromDetailClue;

		// Token: 0x0401579A RID: 87962
		protected int CurQuestionIndex;

		// Token: 0x0401579B RID: 87963
		protected int QuestionCount;

		// Token: 0x0401579C RID: 87964
		public bool NeedRemainHoverItem;

		// Token: 0x0401579D RID: 87965
		public int GamepadHoverIndex = -1;

		// Token: 0x0401579E RID: 87966
		public int ConfirmClueIndex = -1;

		// Token: 0x0401579F RID: 87967
		protected List<int> QuestionIds = new List<int>();

		// Token: 0x040157A0 RID: 87968
		protected Dictionary<int, ISheriffQuestionJsonConfig> QuestionConfigRecord = new Dictionary<int, ISheriffQuestionJsonConfig>();

		// Token: 0x040157A1 RID: 87969
		protected Dictionary<int, List<int>> ClueRecordsMap = new Dictionary<int, List<int>>();

		// Token: 0x040157A2 RID: 87970
		protected SheriffAnomalyInfo AnomalyInfo;

		// Token: 0x040157A3 RID: 87971
		protected Dictionary<int, string> ConclusionKeyMap = new Dictionary<int, string>();

		// Token: 0x040157A4 RID: 87972
		protected int FirstQuestionId;

		// Token: 0x040157A5 RID: 87973
		[Nullable(2)]
		protected ISheriffQuestionResultJsonConfig EndingConfigCache;

		// Token: 0x040157A6 RID: 87974
		protected Dictionary<int, int> FailureCountMap = new Dictionary<int, int>();

		// Token: 0x040157A7 RID: 87975
		protected bool NeedHintToggle;

		// Token: 0x040157A8 RID: 87976
		protected int GameplayId;
	}
}

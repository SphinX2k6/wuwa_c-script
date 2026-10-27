using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006667 RID: 26215
	[NullableContext(1)]
	[Nullable(0)]
	public class EncirclePlayLevelController : Singleton
	{
		// Token: 0x06041B1A RID: 269082 RVA: 0x00FEE954 File Offset: 0x00FECB54
		public EncirclePlayLevelController()
		{
			this.StateHandlers = new Dictionary<EPlayStates, Action>
			{
				{
					EPlayStates.START,
					new Action(this.HandleStart)
				},
				{
					EPlayStates.MONSTERMOVE,
					new Action(this.HandleMonsterMove)
				},
				{
					EPlayStates.MAPCHECK,
					new Action(this.HandleMapCheck)
				},
				{
					EPlayStates.END,
					new Action(this.HandleEnd)
				}
			};
		}

		// Token: 0x06041B1B RID: 269083 RVA: 0x00FEEA03 File Offset: 0x00FECC03
		public int GetCurrentDifficulty()
		{
			return this.CurrentDifficulty;
		}

		// Token: 0x06041B1C RID: 269084 RVA: 0x00FEEA0B File Offset: 0x00FECC0B
		public int GetCurrentRound()
		{
			return this.Round;
		}

		// Token: 0x06041B1D RID: 269085 RVA: 0x00FEEA13 File Offset: 0x00FECC13
		public bool GetGmLog()
		{
			return this.GmLog;
		}

		// Token: 0x06041B1E RID: 269086 RVA: 0x00FEEA1B File Offset: 0x00FECC1B
		public int GetTotalRound()
		{
			return this.Round + this.DifficultyRound;
		}

		// Token: 0x06041B1F RID: 269087 RVA: 0x00FEEA2A File Offset: 0x00FECC2A
		public void SetGmLog(bool value)
		{
			this.GmLog = value;
		}

		// Token: 0x06041B20 RID: 269088 RVA: 0x00FEEA34 File Offset: 0x00FECC34
		private bool PushNextState()
		{
			EPlayStates currentState;
			if (this.StateTransitions.TryGetValue(this.CurrentState, out currentState))
			{
				this.CurrentState = currentState;
				this.ExecuteStateHandler();
				return true;
			}
			return false;
		}

		// Token: 0x06041B21 RID: 269089 RVA: 0x00FEEA66 File Offset: 0x00FECC66
		private bool AddObstacle(int? x, int? y)
		{
			if (!this.EncirclePlayDataManagerField.CheckCanAddObstacle(x, y))
			{
				return false;
			}
			this.EncirclePlayDataManagerField.AddObstacle(x, y);
			return true;
		}

		// Token: 0x06041B22 RID: 269090 RVA: 0x00FEEA87 File Offset: 0x00FECC87
		public bool ClickMapItem(int? x, int? y)
		{
			if (this.CurrentState != EPlayStates.START)
			{
				return false;
			}
			if (this.AddObstacle(x, y))
			{
				this.IncreaseRound();
				this.PushNextState();
				return true;
			}
			return false;
		}

		// Token: 0x06041B23 RID: 269091 RVA: 0x00FEEAB0 File Offset: 0x00FECCB0
		private bool TryChangeLevelDifficulty()
		{
			EncirclePlayLevelController.<>c__DisplayClass21_0 CS$<>8__locals1 = new EncirclePlayLevelController.<>c__DisplayClass21_0();
			CS$<>8__locals1.<>4__this = this;
			EncircleChallengeGroup? encircleGroup = ActivityEncircleConfig.Instance.GetEncircleGroup(this.GroupId);
			if (encircleGroup.Value.ReduceDiffCnt() == null)
			{
				return false;
			}
			bool flag = false;
			CS$<>8__locals1.targetDifficulty = 0;
			for (int i = this.CurrentDifficulty; i < encircleGroup.Value.ReduceDiffCntIter().Count<int>(); i++)
			{
				int num = encircleGroup.Value.ReduceDiffCnt(i);
				if (this.LoseCount >= num)
				{
					CS$<>8__locals1.targetDifficulty = i + 1;
					flag = true;
				}
			}
			if (flag)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.EncircleDifficultyChangeConfirm);
				confirmBoxDataNew.FunctionMap.Add(1, new Action(this.DoResetEncircle));
				confirmBoxDataNew.FunctionMap.Add(2, new Action(CS$<>8__locals1.<TryChangeLevelDifficulty>g__ConfirmCallback|0));
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			}
			return flag;
		}

		// Token: 0x06041B24 RID: 269092 RVA: 0x00FEEB97 File Offset: 0x00FECD97
		public int GetCurrentChallengeId()
		{
			return this.ChallengeId;
		}

		// Token: 0x06041B25 RID: 269093 RVA: 0x00FEEB9F File Offset: 0x00FECD9F
		[NullableContext(2)]
		public LimitWall GetLimitWallByPosKey(int posKey)
		{
			return this.EncirclePlayDataManagerField.GetLimitWall(posKey);
		}

		// Token: 0x06041B26 RID: 269094 RVA: 0x00FEEBB0 File Offset: 0x00FECDB0
		public void EnterPlay(int groupId, int challengeId)
		{
			EncircleChallengeStartRequest encircleChallengeStartRequest = EncircleChallengeStartRequest.Create();
			encircleChallengeStartRequest.ChallengeId = challengeId;
			ActivityEncircleController.SendEnterRequest(encircleChallengeStartRequest, delegate
			{
				this.InitMap(groupId, challengeId);
			});
		}

		// Token: 0x06041B27 RID: 269095 RVA: 0x00FEEBFC File Offset: 0x00FECDFC
		private void InitMap(int groupId, int challengeId)
		{
			this.GroupId = groupId;
			this.ChallengeId = challengeId;
			this.CurrentDifficulty = 0;
			this.ClearMap();
			Dictionary<int, IHexData> hexes = this.EncirclePlayDataManagerField.InitHexMap(challengeId);
			EncircleArgs param = new EncircleArgs
			{
				Hexes = hexes,
				Height = this.EncirclePlayDataManagerField.GetMapHeight(),
				Width = this.EncirclePlayDataManagerField.GetMapWidth()
			};
			UiManager.Instance.OpenView(EUiViewName.EncirclePlayView, param, delegate(bool _, int __)
			{
				this.TryShowMonsterMoveEffect();
			});
		}

		// Token: 0x06041B28 RID: 269096 RVA: 0x00FEEC7C File Offset: 0x00FECE7C
		public void ClearMap()
		{
			this.CurrentState = EPlayStates.START;
			this.Round = 0;
			this.LoseCount = 0;
			this.DifficultyRound = 0;
			this.ChallengeStartTime = TimeUtil.Instance.GetServerTime();
			this.EncirclePlayDataManagerField.Clear();
		}

		// Token: 0x06041B29 RID: 269097 RVA: 0x00FEECB8 File Offset: 0x00FECEB8
		private void ExecuteStateHandler()
		{
			Action action;
			if (this.StateHandlers.TryGetValue(this.CurrentState, out action))
			{
				action();
			}
		}

		// Token: 0x06041B2A RID: 269098 RVA: 0x00FEECE0 File Offset: 0x00FECEE0
		private void HandleStart()
		{
			this.TryShowMonsterMoveEffect();
		}

		// Token: 0x06041B2B RID: 269099 RVA: 0x00FEECE8 File Offset: 0x00FECEE8
		public void TryShowMonsterMoveEffect()
		{
			this.EncirclePlayDataManagerField.TryShowMonsterMoveEffect();
		}

		// Token: 0x06041B2C RID: 269100 RVA: 0x00FEECF8 File Offset: 0x00FECEF8
		public void ShowItemMoveEffect(IHexPos monsterPos, bool value)
		{
			EncirclePlayView encirclePlayView = UiManager.Instance.GetViewByName(EUiViewName.EncirclePlayView) as EncirclePlayView;
			if (encirclePlayView != null)
			{
				encirclePlayView.ShowItemMoveEffect(EncircleUtils.Instance.HexPosToKey(monsterPos), value);
			}
		}

		// Token: 0x06041B2D RID: 269101 RVA: 0x00FEED30 File Offset: 0x00FECF30
		public void IncreaseRound()
		{
			this.Round++;
			EncirclePlayView encirclePlayView = UiManager.Instance.GetViewByName(EUiViewName.EncirclePlayView) as EncirclePlayView;
			if (encirclePlayView != null)
			{
				encirclePlayView.SetCurrentStepText(this.Round);
			}
		}

		// Token: 0x06041B2E RID: 269102 RVA: 0x00FEED70 File Offset: 0x00FECF70
		public void IncreaseDifficultyRound()
		{
			this.DifficultyRound++;
			EncirclePlayView encirclePlayView = UiManager.Instance.GetViewByName(EUiViewName.EncirclePlayView) as EncirclePlayView;
			if (encirclePlayView != null)
			{
				encirclePlayView.SetDifficultyStepTxt(this.DifficultyRound);
			}
		}

		// Token: 0x06041B2F RID: 269103 RVA: 0x00FEEDAF File Offset: 0x00FECFAF
		public void ExecuteWin()
		{
			this.TryCompleteRequest();
		}

		// Token: 0x06041B30 RID: 269104 RVA: 0x00FEEDB8 File Offset: 0x00FECFB8
		private void ExecuteLose()
		{
			RewardData<IEncircleRewardInfo> rewardData = new RewardData<IEncircleRewardInfo>(null, null);
			EncircleRewardInfo rewardInfo = new EncircleRewardInfo
			{
				ViewName = EUiViewName.EncircleResultView,
				IsSuccess = false,
				Type = ERewardInfoType.Common,
				Score = new int?(this.Round + this.DifficultyRound)
			};
			rewardData.SetRewardInfo(rewardInfo);
			ActivityEncircleController.Instance.SendCompleteRequest(this.GenRequestData(0), delegate
			{
				UiManager.Instance.OpenView(EUiViewName.EncircleResultView, rewardData, null);
			});
		}

		// Token: 0x06041B31 RID: 269105 RVA: 0x00FEEE38 File Offset: 0x00FED038
		private void ShowAgainWinWindow()
		{
			RewardData<IEncircleRewardInfo> rewardData = new RewardData<IEncircleRewardInfo>(null, null);
			EncircleRewardInfo rewardInfo = new EncircleRewardInfo
			{
				ViewName = EUiViewName.EncircleResultView,
				IsSuccess = true,
				Type = ERewardInfoType.Common,
				Score = new int?(this.Round + this.DifficultyRound),
				RecordScore = new int?(ActivityEncircleController.Instance.GetEncircleData().GetChallengeRecord(this.ChallengeId))
			};
			rewardData.SetRewardInfo(rewardInfo);
			UiManager.Instance.OpenView(EUiViewName.EncircleResultView, rewardData, null);
		}

		// Token: 0x06041B32 RID: 269106 RVA: 0x00FEEEBC File Offset: 0x00FED0BC
		private void TryCompleteRequest()
		{
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			if (encircleData != null && encircleData.CheckChallengeComplete(this.ChallengeId))
			{
				this.ShowAgainWinWindow();
			}
			ActivityEncircleController.Instance.SendCompleteRequest(this.GenRequestData(1), new Action(this.ClearMap));
		}

		// Token: 0x06041B33 RID: 269107 RVA: 0x00FEEF08 File Offset: 0x00FED108
		public void SetAllMonsterDead()
		{
			EncirclePlayView encirclePlayView = UiManager.Instance.GetViewByName(EUiViewName.EncirclePlayView) as EncirclePlayView;
			if (encirclePlayView != null)
			{
				encirclePlayView.SetAllMonsterDead(this.EncirclePlayDataManagerField.GetAllMonsterId());
			}
		}

		// Token: 0x06041B34 RID: 269108 RVA: 0x00FEEF3E File Offset: 0x00FED13E
		public void CloseEncircle()
		{
			ActivityEncircleController.Instance.SendCompleteRequest(this.GenRequestData(2), delegate
			{
				UiManager.Instance.CloseView(EUiViewName.EncirclePlayView, null);
			});
		}

		// Token: 0x06041B35 RID: 269109 RVA: 0x00FEEF70 File Offset: 0x00FED170
		public void ResetEncircle()
		{
			EncircleChallengeStartRequest encircleChallengeStartRequest = EncircleChallengeStartRequest.Create();
			encircleChallengeStartRequest.ChallengeId = this.ChallengeId;
			ActivityEncircleController.SendEnterRequest(encircleChallengeStartRequest, delegate
			{
				this.LoseCount++;
				if (!this.TryChangeLevelDifficulty())
				{
					this.DoResetEncircle();
				}
			});
		}

		// Token: 0x06041B36 RID: 269110 RVA: 0x00FEEF94 File Offset: 0x00FED194
		private void DoResetEncircle()
		{
			this.CurrentState = EPlayStates.START;
			this.Round = 0;
			this.DifficultyRound = 0;
			this.ChallengeStartTime = TimeUtil.Instance.GetServerTime();
			this.EncirclePlayDataManagerField.Clear();
			Dictionary<int, IHexData> p = this.EncirclePlayDataManagerField.InitHexMap(this.ChallengeId);
			EventSystem.Instance.Emit<Dictionary<int, IHexData>>(EEventName.EncircleReset, p);
			this.TryShowMonsterMoveEffect();
		}

		// Token: 0x06041B37 RID: 269111 RVA: 0x00FEEFFC File Offset: 0x00FED1FC
		public void ChangeViewMapType(int mapItemId, IHexPos currentPos, [Nullable(2)] IHexPos oldPos)
		{
			EncirclePlayView encirclePlayView = UiManager.Instance.GetViewByName(EUiViewName.EncirclePlayView) as EncirclePlayView;
			if (encirclePlayView != null)
			{
				encirclePlayView.ChangeEncircleMap(mapItemId, currentPos, oldPos);
			}
		}

		// Token: 0x06041B38 RID: 269112 RVA: 0x00FEF02A File Offset: 0x00FED22A
		private void HandleMonsterMove()
		{
			if (!this.EncirclePlayDataManagerField.TryMoveMonster())
			{
				this.SetAllMonsterDead();
			}
		}

		// Token: 0x06041B39 RID: 269113 RVA: 0x00FEF03F File Offset: 0x00FED23F
		private void HandleMapCheck()
		{
			this.PushWallLimit();
			if (this.CheckMonsterEscape())
			{
				this.ExecuteLose();
				return;
			}
			this.PushNextState();
		}

		// Token: 0x06041B3A RID: 269114 RVA: 0x00FEF05D File Offset: 0x00FED25D
		public void TryPushMoveToNextState()
		{
			if (this.CurrentState != EPlayStates.MONSTERMOVE)
			{
				return;
			}
			this.PushNextState();
		}

		// Token: 0x06041B3B RID: 269115 RVA: 0x00FEF070 File Offset: 0x00FED270
		public void SetMonsterDead(int monsterId)
		{
			EncirclePlayView encirclePlayView = UiManager.Instance.GetViewByName(EUiViewName.EncirclePlayView) as EncirclePlayView;
			if (encirclePlayView != null)
			{
				encirclePlayView.SetMonsterDead(monsterId);
			}
		}

		// Token: 0x06041B3C RID: 269116 RVA: 0x00FEF09C File Offset: 0x00FED29C
		private void HandleEnd()
		{
			this.PushNextState();
		}

		// Token: 0x06041B3D RID: 269117 RVA: 0x00FEF0A5 File Offset: 0x00FED2A5
		private bool CheckMonsterEscape()
		{
			return this.EncirclePlayDataManagerField.CheckMonsterEscape();
		}

		// Token: 0x06041B3E RID: 269118 RVA: 0x00FEF0B4 File Offset: 0x00FED2B4
		public EPlayStates GetNextState()
		{
			EPlayStates result;
			this.StateTransitions.TryGetValue(this.CurrentState, out result);
			return result;
		}

		// Token: 0x06041B3F RID: 269119 RVA: 0x00FEF0D6 File Offset: 0x00FED2D6
		private void PushWallLimit()
		{
			this.EncirclePlayDataManagerField.PushWallLimit();
		}

		// Token: 0x06041B40 RID: 269120 RVA: 0x00FEF0E3 File Offset: 0x00FED2E3
		public bool CheckIsBoundary(IHexPos pos)
		{
			return this.EncirclePlayDataManagerField.CheckIsBoundary(pos);
		}

		// Token: 0x06041B41 RID: 269121 RVA: 0x00FEF0F4 File Offset: 0x00FED2F4
		private EncircleChallengeCompleteRequest GenRequestData(int result)
		{
			EncircleChallengeCompleteRequest encircleChallengeCompleteRequest = EncircleChallengeCompleteRequest.Create();
			encircleChallengeCompleteRequest.ChallengeId = this.ChallengeId;
			encircleChallengeCompleteRequest.Step = this.Round + this.DifficultyRound;
			encircleChallengeCompleteRequest.Result = result;
			encircleChallengeCompleteRequest.ReducedDifficulty = (this.CurrentDifficulty > 0);
			encircleChallengeCompleteRequest.GameSeconds = (int)(TimeUtil.Instance.GetServerTime() - this.ChallengeStartTime);
			return encircleChallengeCompleteRequest;
		}

		// Token: 0x17009639 RID: 38457
		// (get) Token: 0x06041B42 RID: 269122 RVA: 0x00FEF153 File Offset: 0x00FED353
		public static EncirclePlayLevelController Instance
		{
			get
			{
				if (EncirclePlayLevelController._instance == null)
				{
					EncirclePlayLevelController._instance = new EncirclePlayLevelController();
					EncirclePlayLevelController._instance.OnInit();
				}
				return EncirclePlayLevelController._instance;
			}
		}

		// Token: 0x06041B43 RID: 269123 RVA: 0x00FEF176 File Offset: 0x00FED376
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041B44 RID: 269124 RVA: 0x00FEF178 File Offset: 0x00FED378
		public static void ResetStaticDefaultValue()
		{
			EncirclePlayLevelController instance = EncirclePlayLevelController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			EncirclePlayLevelController._instance = null;
		}

		// Token: 0x06041B45 RID: 269125 RVA: 0x00FEF191 File Offset: 0x00FED391
		static EncirclePlayLevelController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EncirclePlayLevelController.CreateStaticDefaultValue), new Action(EncirclePlayLevelController.ResetStaticDefaultValue));
		}

		// Token: 0x040222D1 RID: 139985
		private readonly EncirclePlayDataManager EncirclePlayDataManagerField = new EncirclePlayDataManager();

		// Token: 0x040222D2 RID: 139986
		private readonly Dictionary<EPlayStates, EPlayStates> StateTransitions = new Dictionary<EPlayStates, EPlayStates>
		{
			{
				EPlayStates.START,
				EPlayStates.MONSTERMOVE
			},
			{
				EPlayStates.MONSTERMOVE,
				EPlayStates.MAPCHECK
			},
			{
				EPlayStates.MAPCHECK,
				EPlayStates.END
			},
			{
				EPlayStates.END,
				EPlayStates.START
			}
		};

		// Token: 0x040222D3 RID: 139987
		private readonly Dictionary<EPlayStates, Action> StateHandlers;

		// Token: 0x040222D4 RID: 139988
		private EPlayStates CurrentState;

		// Token: 0x040222D5 RID: 139989
		private int CurrentDifficulty;

		// Token: 0x040222D6 RID: 139990
		private int LoseCount;

		// Token: 0x040222D7 RID: 139991
		private int Round;

		// Token: 0x040222D8 RID: 139992
		private int GroupId;

		// Token: 0x040222D9 RID: 139993
		private int ChallengeId;

		// Token: 0x040222DA RID: 139994
		private int DifficultyRound;

		// Token: 0x040222DB RID: 139995
		private double ChallengeStartTime = -1.0;

		// Token: 0x040222DC RID: 139996
		private bool GmLog;

		// Token: 0x040222DD RID: 139997
		[Nullable(2)]
		private static EncirclePlayLevelController _instance;
	}
}

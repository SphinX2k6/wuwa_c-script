using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Encircle.View;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02003015 RID: 12309
	[NullableContext(1)]
	[Nullable(0)]
	public class EncirclePlayLevelController : Singleton
	{
		// Token: 0x0601D339 RID: 119609 RVA: 0x008EA368 File Offset: 0x008E8568
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

		// Token: 0x0601D33A RID: 119610 RVA: 0x008EA417 File Offset: 0x008E8617
		public int GetCurrentDifficulty()
		{
			return this.CurrentDifficulty;
		}

		// Token: 0x0601D33B RID: 119611 RVA: 0x008EA41F File Offset: 0x008E861F
		public int GetCurrentRound()
		{
			return this.Round;
		}

		// Token: 0x0601D33C RID: 119612 RVA: 0x008EA427 File Offset: 0x008E8627
		public bool GetGmLog()
		{
			return this.GmLog;
		}

		// Token: 0x0601D33D RID: 119613 RVA: 0x008EA42F File Offset: 0x008E862F
		public int GetTotalRound()
		{
			return this.Round + this.DifficultyRound;
		}

		// Token: 0x0601D33E RID: 119614 RVA: 0x008EA43E File Offset: 0x008E863E
		public void SetGmLog(bool value)
		{
			this.GmLog = value;
		}

		// Token: 0x0601D33F RID: 119615 RVA: 0x008EA448 File Offset: 0x008E8648
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

		// Token: 0x0601D340 RID: 119616 RVA: 0x008EA47A File Offset: 0x008E867A
		private bool AddObstacle(int? x, int? y)
		{
			if (!this.EncirclePlayDataManagerField.CheckCanAddObstacle(x, y))
			{
				return false;
			}
			this.EncirclePlayDataManagerField.AddObstacle(x, y);
			return true;
		}

		// Token: 0x0601D341 RID: 119617 RVA: 0x008EA49B File Offset: 0x008E869B
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

		// Token: 0x0601D342 RID: 119618 RVA: 0x008EA4C4 File Offset: 0x008E86C4
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
			int num = 0;
			foreach (int num2 in encircleGroup.Value.ReduceDiffCntIter())
			{
				num++;
			}
			for (int i = this.CurrentDifficulty; i < num; i++)
			{
				int num3 = encircleGroup.Value.ReduceDiffCnt(i);
				if (this.LoseCount >= num3)
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

		// Token: 0x0601D343 RID: 119619 RVA: 0x008EA5E8 File Offset: 0x008E87E8
		public int GetCurrentChallengeId()
		{
			return this.ChallengeId;
		}

		// Token: 0x0601D344 RID: 119620 RVA: 0x008EA5F0 File Offset: 0x008E87F0
		[NullableContext(2)]
		public LimitWall GetLimitWallByPosKey(int posKey)
		{
			return this.EncirclePlayDataManagerField.GetLimitWall(posKey);
		}

		// Token: 0x0601D345 RID: 119621 RVA: 0x008EA600 File Offset: 0x008E8800
		public void EnterPlay(int groupId, int challengeId)
		{
			EncircleChallengeStartRequest encircleChallengeStartRequest = EncircleChallengeStartRequest.Create();
			encircleChallengeStartRequest.ChallengeId = challengeId;
			ActivityEncircleController.SendEnterRequest(encircleChallengeStartRequest, delegate
			{
				this.InitMap(groupId, challengeId);
			});
		}

		// Token: 0x0601D346 RID: 119622 RVA: 0x008EA64C File Offset: 0x008E884C
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

		// Token: 0x0601D347 RID: 119623 RVA: 0x008EA6CC File Offset: 0x008E88CC
		public void ClearMap()
		{
			this.CurrentState = EPlayStates.START;
			this.Round = 0;
			this.LoseCount = 0;
			this.DifficultyRound = 0;
			this.ChallengeStartTime = TimeUtil.Instance.GetServerTime();
			this.EncirclePlayDataManagerField.Clear();
		}

		// Token: 0x0601D348 RID: 119624 RVA: 0x008EA708 File Offset: 0x008E8908
		private void ExecuteStateHandler()
		{
			Action action;
			if (this.StateHandlers.TryGetValue(this.CurrentState, out action))
			{
				action();
			}
		}

		// Token: 0x0601D349 RID: 119625 RVA: 0x008EA730 File Offset: 0x008E8930
		private void HandleStart()
		{
			this.TryShowMonsterMoveEffect();
		}

		// Token: 0x0601D34A RID: 119626 RVA: 0x008EA738 File Offset: 0x008E8938
		public void TryShowMonsterMoveEffect()
		{
			this.EncirclePlayDataManagerField.TryShowMonsterMoveEffect();
		}

		// Token: 0x0601D34B RID: 119627 RVA: 0x008EA748 File Offset: 0x008E8948
		public void ShowItemMoveEffect(IHexPos monsterPos, bool value)
		{
			EncirclePlayView encirclePlayView = UiManager.Instance.GetViewByName(EUiViewName.EncirclePlayView) as EncirclePlayView;
			if (encirclePlayView != null)
			{
				encirclePlayView.ShowItemMoveEffect(EncircleUtils.Instance.HexPosToKey(monsterPos), value);
			}
		}

		// Token: 0x0601D34C RID: 119628 RVA: 0x008EA780 File Offset: 0x008E8980
		public void IncreaseRound()
		{
			this.Round++;
			EncirclePlayView encirclePlayView = UiManager.Instance.GetViewByName(EUiViewName.EncirclePlayView) as EncirclePlayView;
			if (encirclePlayView != null)
			{
				encirclePlayView.SetCurrentStepText(this.Round);
			}
		}

		// Token: 0x0601D34D RID: 119629 RVA: 0x008EA7C0 File Offset: 0x008E89C0
		public void IncreaseDifficultyRound()
		{
			this.DifficultyRound++;
			EncirclePlayView encirclePlayView = UiManager.Instance.GetViewByName(EUiViewName.EncirclePlayView) as EncirclePlayView;
			if (encirclePlayView != null)
			{
				encirclePlayView.SetDifficultyStepTxt(this.DifficultyRound);
			}
		}

		// Token: 0x0601D34E RID: 119630 RVA: 0x008EA7FF File Offset: 0x008E89FF
		public void ExecuteWin()
		{
			this.TryCompleteRequest();
		}

		// Token: 0x0601D34F RID: 119631 RVA: 0x008EA808 File Offset: 0x008E8A08
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

		// Token: 0x0601D350 RID: 119632 RVA: 0x008EA888 File Offset: 0x008E8A88
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

		// Token: 0x0601D351 RID: 119633 RVA: 0x008EA90C File Offset: 0x008E8B0C
		private void TryCompleteRequest()
		{
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			if (encircleData != null && encircleData.CheckChallengeComplete(this.ChallengeId))
			{
				this.ShowAgainWinWindow();
			}
			ActivityEncircleController.Instance.SendCompleteRequest(this.GenRequestData(1), new Action(this.ClearMap));
		}

		// Token: 0x0601D352 RID: 119634 RVA: 0x008EA958 File Offset: 0x008E8B58
		public void SetAllMonsterDead()
		{
			EncirclePlayView encirclePlayView = UiManager.Instance.GetViewByName(EUiViewName.EncirclePlayView) as EncirclePlayView;
			if (encirclePlayView != null)
			{
				encirclePlayView.SetAllMonsterDead(this.EncirclePlayDataManagerField.GetAllMonsterId());
			}
		}

		// Token: 0x0601D353 RID: 119635 RVA: 0x008EA98E File Offset: 0x008E8B8E
		public void CloseEncircle()
		{
			ActivityEncircleController.Instance.SendCompleteRequest(this.GenRequestData(2), delegate
			{
				UiManager.Instance.CloseView(EUiViewName.EncirclePlayView, null);
			});
		}

		// Token: 0x0601D354 RID: 119636 RVA: 0x008EA9C0 File Offset: 0x008E8BC0
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

		// Token: 0x0601D355 RID: 119637 RVA: 0x008EA9E4 File Offset: 0x008E8BE4
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

		// Token: 0x0601D356 RID: 119638 RVA: 0x008EAA4C File Offset: 0x008E8C4C
		public void ChangeViewMapType(int mapItemId, IHexPos currentPos, [Nullable(2)] IHexPos oldPos)
		{
			EncirclePlayView encirclePlayView = UiManager.Instance.GetViewByName(EUiViewName.EncirclePlayView) as EncirclePlayView;
			if (encirclePlayView != null)
			{
				encirclePlayView.ChangeEncircleMap(mapItemId, currentPos, oldPos);
			}
		}

		// Token: 0x0601D357 RID: 119639 RVA: 0x008EAA7A File Offset: 0x008E8C7A
		private void HandleMonsterMove()
		{
			if (!this.EncirclePlayDataManagerField.TryMoveMonster())
			{
				this.SetAllMonsterDead();
			}
		}

		// Token: 0x0601D358 RID: 119640 RVA: 0x008EAA8F File Offset: 0x008E8C8F
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

		// Token: 0x0601D359 RID: 119641 RVA: 0x008EAAAD File Offset: 0x008E8CAD
		public void TryPushMoveToNextState()
		{
			if (this.CurrentState != EPlayStates.MONSTERMOVE)
			{
				return;
			}
			this.PushNextState();
		}

		// Token: 0x0601D35A RID: 119642 RVA: 0x008EAAC0 File Offset: 0x008E8CC0
		public void SetMonsterDead(int monsterId)
		{
			EncirclePlayView encirclePlayView = UiManager.Instance.GetViewByName(EUiViewName.EncirclePlayView) as EncirclePlayView;
			if (encirclePlayView != null)
			{
				encirclePlayView.SetMonsterDead(monsterId);
			}
		}

		// Token: 0x0601D35B RID: 119643 RVA: 0x008EAAEC File Offset: 0x008E8CEC
		private void HandleEnd()
		{
			this.PushNextState();
		}

		// Token: 0x0601D35C RID: 119644 RVA: 0x008EAAF5 File Offset: 0x008E8CF5
		private bool CheckMonsterEscape()
		{
			return this.EncirclePlayDataManagerField.CheckMonsterEscape();
		}

		// Token: 0x0601D35D RID: 119645 RVA: 0x008EAB04 File Offset: 0x008E8D04
		public EPlayStates GetNextState()
		{
			EPlayStates result;
			this.StateTransitions.TryGetValue(this.CurrentState, out result);
			return result;
		}

		// Token: 0x0601D35E RID: 119646 RVA: 0x008EAB26 File Offset: 0x008E8D26
		private void PushWallLimit()
		{
			this.EncirclePlayDataManagerField.PushWallLimit();
		}

		// Token: 0x0601D35F RID: 119647 RVA: 0x008EAB33 File Offset: 0x008E8D33
		public bool CheckIsBoundary(IHexPos pos)
		{
			return this.EncirclePlayDataManagerField.CheckIsBoundary(pos);
		}

		// Token: 0x0601D360 RID: 119648 RVA: 0x008EAB44 File Offset: 0x008E8D44
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

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x0601D361 RID: 119649 RVA: 0x008EABA3 File Offset: 0x008E8DA3
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

		// Token: 0x0601D362 RID: 119650 RVA: 0x008EABC6 File Offset: 0x008E8DC6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0601D363 RID: 119651 RVA: 0x008EABC8 File Offset: 0x008E8DC8
		public static void ResetStaticDefaultValue()
		{
			EncirclePlayLevelController instance = EncirclePlayLevelController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			EncirclePlayLevelController._instance = null;
		}

		// Token: 0x0601D364 RID: 119652 RVA: 0x008EABE1 File Offset: 0x008E8DE1
		static EncirclePlayLevelController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EncirclePlayLevelController.CreateStaticDefaultValue), new Action(EncirclePlayLevelController.ResetStaticDefaultValue));
		}

		// Token: 0x0400F5DB RID: 62939
		private readonly EncirclePlayDataManager EncirclePlayDataManagerField = new EncirclePlayDataManager();

		// Token: 0x0400F5DC RID: 62940
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

		// Token: 0x0400F5DD RID: 62941
		private readonly Dictionary<EPlayStates, Action> StateHandlers;

		// Token: 0x0400F5DE RID: 62942
		private EPlayStates CurrentState;

		// Token: 0x0400F5DF RID: 62943
		private int CurrentDifficulty;

		// Token: 0x0400F5E0 RID: 62944
		private int LoseCount;

		// Token: 0x0400F5E1 RID: 62945
		private int Round;

		// Token: 0x0400F5E2 RID: 62946
		private int GroupId;

		// Token: 0x0400F5E3 RID: 62947
		private int ChallengeId;

		// Token: 0x0400F5E4 RID: 62948
		private int DifficultyRound;

		// Token: 0x0400F5E5 RID: 62949
		private double ChallengeStartTime = -1.0;

		// Token: 0x0400F5E6 RID: 62950
		private bool GmLog;

		// Token: 0x0400F5E7 RID: 62951
		[Nullable(2)]
		private static EncirclePlayLevelController _instance;
	}
}

using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200608C RID: 24716
	public class FunctionItem : UiPanelBase
	{
		// Token: 0x0603E7BA RID: 255930 RVA: 0x00F1A104 File Offset: 0x00F18304
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickFunction))
			};
		}

		// Token: 0x0603E7BB RID: 255931 RVA: 0x00F1A21C File Offset: 0x00F1841C
		public FunctionItem(ESpringFunctionType functionType)
		{
			this.FunctionType = functionType;
		}

		// Token: 0x0603E7BC RID: 255932 RVA: 0x00F1A22B File Offset: 0x00F1842B
		protected override void OnStart()
		{
			this.Refresh();
			this.InitRedDot();
		}

		// Token: 0x0603E7BD RID: 255933 RVA: 0x00F1A239 File Offset: 0x00F18439
		protected override void OnBeforeDestroy()
		{
			this.DestroyRedDot();
		}

		// Token: 0x0603E7BE RID: 255934 RVA: 0x00F1A244 File Offset: 0x00F18444
		private void InitRedDot()
		{
			SpringManorGameHandleBase gameplayData = SpringManorModel.Instance.GetGameplayData(this.FunctionType);
			this.RedDotName = gameplayData.GetRedDotName();
			if (this.RedDotName != null)
			{
				RedDotController.Instance.BindRedDot(this.RedDotName.Value, base.GetItem(9), null, 0);
				return;
			}
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603E7BF RID: 255935 RVA: 0x00F1A2AE File Offset: 0x00F184AE
		private void DestroyRedDot()
		{
			if (this.RedDotName == null)
			{
				return;
			}
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(9), 0);
		}

		// Token: 0x0603E7C0 RID: 255936 RVA: 0x00F1A2DC File Offset: 0x00F184DC
		public void Refresh()
		{
			this.RefreshState();
			this.SetLockState(this.State != EFunctionState.Unlock);
			switch (this.State)
			{
			case EFunctionState.LockBeforeTime:
			{
				SpringManorModel instance = SpringManorModel.Instance;
				string item = (instance != null) ? instance.GetFunctionUnlockRemainText(this.FunctionType) : null;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "Spring26_Gameplay_TimeLock", new <>z__ReadOnlySingleElementList<object>(item));
				return;
			}
			case EFunctionState.LockAfterTime:
			{
				SpringManorConfig instance2 = SpringManorConfig.Instance;
				SpringFestivalUnlock? springFestivalUnlock = (instance2 != null) ? instance2.GetFunctionConfigById((int)this.FunctionType) : null;
				int? num = (springFestivalUnlock != null) ? new int?(springFestivalUnlock.GetValueOrDefault().ConditionGroup) : null;
				ConditionConfig instance3 = ConditionConfig.Instance;
				ConditionGroup? conditionGroup = (instance3 != null) ? instance3.GetConditionGroupConfig(num.Value) : null;
				string key = (conditionGroup != null) ? conditionGroup.GetValueOrDefault().HintText : null;
				UUIText text = base.GetText(5);
				if (text == null)
				{
					return;
				}
				text.ShowTextNew(key);
				return;
			}
			case EFunctionState.Unlock:
			{
				SpringManorGameHandleBase gameplayData = SpringManorModel.Instance.GetGameplayData(this.FunctionType);
				int currentProgress = gameplayData.GetCurrentProgress();
				int totalProgress = gameplayData.GetTotalProgress();
				string textStringId = (currentProgress >= totalProgress) ? "Spring26_GameProgress_Done" : "Spring26_GameProgress";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), textStringId, new <>z__ReadOnlyArray<object>(new object[]
				{
					currentProgress.ToString(),
					totalProgress.ToString()
				}));
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0603E7C1 RID: 255937 RVA: 0x00F1A45C File Offset: 0x00F1865C
		private void RefreshState()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance.ActivityData.IsFunctionUnlocked(this.FunctionType))
			{
				this.State = EFunctionState.Unlock;
				return;
			}
			string functionUnlockRemainText = instance.GetFunctionUnlockRemainText(this.FunctionType);
			this.State = ((functionUnlockRemainText == null) ? EFunctionState.LockAfterTime : EFunctionState.LockBeforeTime);
		}

		// Token: 0x0603E7C2 RID: 255938 RVA: 0x00F1A4A4 File Offset: 0x00F186A4
		private void SetLockState(bool isLock)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(!isLock);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(isLock);
			}
			UUIItem item3 = base.GetItem(7);
			if (item3 != null)
			{
				item3.SetUIActive(!isLock);
			}
			UUIItem item4 = base.GetItem(1);
			if (item4 != null)
			{
				item4.SetUIActive(!isLock);
			}
			UUIItem item5 = base.GetItem(2);
			if (item5 == null)
			{
				return;
			}
			item5.SetUIActive(isLock);
		}

		// Token: 0x0603E7C3 RID: 255939 RVA: 0x00F1A518 File Offset: 0x00F18718
		private void OnClickFunction()
		{
			if (this.State != EFunctionState.Unlock)
			{
				this.OnClickSkip();
				return;
			}
			SpringManorModel.Instance.GetGameplayData(this.FunctionType).EnterGame();
		}

		// Token: 0x0603E7C4 RID: 255940 RVA: 0x00F1A540 File Offset: 0x00F18740
		private void OnClickSkip()
		{
			if (this.State == EFunctionState.LockBeforeTime)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Spring26_Gameplay_TimeLimit", Array.Empty<object>());
				return;
			}
			List<IActivityConditionData> list = new List<IActivityConditionData>();
			SpringManorConfig instance = SpringManorConfig.Instance;
			SpringFestivalUnlock? springFestivalUnlock = (instance != null) ? instance.GetFunctionConfigById((int)this.FunctionType) : null;
			foreach (int conditionId in ConditionConfig.Instance.GetGroupConditionIds(springFestivalUnlock.Value.ConditionGroup))
			{
				Condition? conditionConfig = ConditionConfig.Instance.GetConditionConfig(conditionId);
				int accessType = -1;
				if (conditionConfig.Value.AccessId != 0)
				{
					accessType = GetWayConfig.Instance.GetConfigById(conditionConfig.Value.AccessId).Value.SkipName;
				}
				ActivityConditionData item = new ActivityConditionData
				{
					ConditionId = conditionId,
					ConditionTextId = conditionConfig.Value.Description,
					IsFinished = this.IsConditionFinished(conditionId),
					AccessId = conditionConfig.Value.AccessId,
					AccessType = accessType
				};
				list.Add(item);
			}
			ConditionGroupData param = new ConditionGroupData(springFestivalUnlock.Value.ConditionGroup, list, "", false);
			UiManager.Instance.OpenView(EUiViewName.CommonConditionView, param, null);
		}

		// Token: 0x0603E7C5 RID: 255941 RVA: 0x00F1A6A4 File Offset: 0x00F188A4
		private bool IsConditionFinished(int conditionId)
		{
			return false;
		}

		// Token: 0x04020B22 RID: 133922
		private EFunctionState State;

		// Token: 0x04020B23 RID: 133923
		private ERedDotName? RedDotName;

		// Token: 0x04020B24 RID: 133924
		private readonly ESpringFunctionType FunctionType;
	}
}

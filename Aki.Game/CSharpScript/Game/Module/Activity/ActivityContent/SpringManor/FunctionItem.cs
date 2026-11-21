using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200500A RID: 20490
	public class FunctionItem : UiPanelBase
	{
		// Token: 0x0603347E RID: 210046 RVA: 0x00E60EC8 File Offset: 0x00E5F0C8
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

		// Token: 0x0603347F RID: 210047 RVA: 0x00E60FE0 File Offset: 0x00E5F1E0
		public FunctionItem(ESpringFunctionType functionType)
		{
			this.FunctionType = functionType;
		}

		// Token: 0x06033480 RID: 210048 RVA: 0x00E60FEF File Offset: 0x00E5F1EF
		protected override void OnStart()
		{
			this.Refresh();
			this.InitRedDot();
		}

		// Token: 0x06033481 RID: 210049 RVA: 0x00E60FFD File Offset: 0x00E5F1FD
		protected override void OnBeforeDestroy()
		{
			this.DestroyRedDot();
		}

		// Token: 0x06033482 RID: 210050 RVA: 0x00E61008 File Offset: 0x00E5F208
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

		// Token: 0x06033483 RID: 210051 RVA: 0x00E61072 File Offset: 0x00E5F272
		private void DestroyRedDot()
		{
			if (this.RedDotName == null)
			{
				return;
			}
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(9), 0);
		}

		// Token: 0x06033484 RID: 210052 RVA: 0x00E610A0 File Offset: 0x00E5F2A0
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

		// Token: 0x06033485 RID: 210053 RVA: 0x00E61220 File Offset: 0x00E5F420
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

		// Token: 0x06033486 RID: 210054 RVA: 0x00E61268 File Offset: 0x00E5F468
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

		// Token: 0x06033487 RID: 210055 RVA: 0x00E612DC File Offset: 0x00E5F4DC
		private void OnClickFunction()
		{
			if (this.State != EFunctionState.Unlock)
			{
				this.OnClickSkip();
				return;
			}
			SpringManorModel.Instance.GetGameplayData(this.FunctionType).EnterGame();
		}

		// Token: 0x06033488 RID: 210056 RVA: 0x00E61304 File Offset: 0x00E5F504
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

		// Token: 0x06033489 RID: 210057 RVA: 0x00E61468 File Offset: 0x00E5F668
		private bool IsConditionFinished(int conditionId)
		{
			return false;
		}

		// Token: 0x0401B44F RID: 111695
		private EFunctionState State;

		// Token: 0x0401B450 RID: 111696
		private ERedDotName? RedDotName;

		// Token: 0x0401B451 RID: 111697
		private readonly ESpringFunctionType FunctionType;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ResManager;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000A08 RID: 2568
[NullableContext(2)]
[Nullable(0)]
public class ActivityFunctionalTypeA : UiPanelBase
{
	// Token: 0x17000D82 RID: 3458
	// (get) Token: 0x06006FF4 RID: 28660 RVA: 0x00226528 File Offset: 0x00224728
	// (set) Token: 0x06006FF5 RID: 28661 RVA: 0x00226530 File Offset: 0x00224730
	public ActivityButtonItem FunctionButton { get; private set; }

	// Token: 0x17000D83 RID: 3459
	// (get) Token: 0x06006FF6 RID: 28662 RVA: 0x00226539 File Offset: 0x00224739
	// (set) Token: 0x06006FF7 RID: 28663 RVA: 0x00226541 File Offset: 0x00224741
	public ButtonSpriteItem CircleButton { get; private set; }

	// Token: 0x17000D84 RID: 3460
	// (get) Token: 0x06006FF8 RID: 28664 RVA: 0x0022654A File Offset: 0x0022474A
	// (set) Token: 0x06006FF9 RID: 28665 RVA: 0x00226552 File Offset: 0x00224752
	public FunctionalPanelConditionLock PanelLock { get; private set; }

	// Token: 0x17000D85 RID: 3461
	// (get) Token: 0x06006FFA RID: 28666 RVA: 0x0022655B File Offset: 0x0022475B
	// (set) Token: 0x06006FFB RID: 28667 RVA: 0x00226563 File Offset: 0x00224763
	public FunctionalPanelConditionActivate PanelActivate { get; private set; }

	// Token: 0x17000D86 RID: 3462
	// (get) Token: 0x06006FFC RID: 28668 RVA: 0x0022656C File Offset: 0x0022476C
	// (set) Token: 0x06006FFD RID: 28669 RVA: 0x00226574 File Offset: 0x00224774
	protected ActivityBaseData Data { get; set; }

	// Token: 0x06006FFE RID: 28670 RVA: 0x0022657D File Offset: 0x0022477D
	public ActivityFunctionalTypeA(ActivityBaseData data)
	{
		this.Data = data;
	}

	// Token: 0x06006FFF RID: 28671 RVA: 0x0022658C File Offset: 0x0022478C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007000 RID: 28672 RVA: 0x002266BC File Offset: 0x002248BC
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityFunctionalTypeA.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityFunctionalTypeA.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007001 RID: 28673 RVA: 0x002266FF File Offset: 0x002248FF
	[NullableContext(1)]
	public void SetLockTextByTextId(string textId, params string[] args)
	{
		this.PanelLock.SetTextByTextId(textId, args);
	}

	// Token: 0x06007002 RID: 28674 RVA: 0x0022670E File Offset: 0x0022490E
	[NullableContext(1)]
	public void SetLockTextByText(string text)
	{
		this.PanelLock.SetTextByText(text);
	}

	// Token: 0x06007003 RID: 28675 RVA: 0x0022671C File Offset: 0x0022491C
	public void SetLockSpriteVisible(bool bVisible)
	{
		this.PanelLock.SetSpriteVisible(bVisible);
	}

	// Token: 0x06007004 RID: 28676 RVA: 0x0022672A File Offset: 0x0022492A
	public void SetPanelConditionVisible(bool bVisible)
	{
		base.GetItem(0).SetUIActive(bVisible);
	}

	// Token: 0x06007005 RID: 28677 RVA: 0x00226739 File Offset: 0x00224939
	public void SetLockConditionButtonVisible(bool bVisible)
	{
		this.PanelLock.SetButtonVisible(bVisible);
	}

	// Token: 0x06007006 RID: 28678 RVA: 0x00226747 File Offset: 0x00224947
	[NullableContext(1)]
	public void SetActivateTextByTextId(string textId, params string[] args)
	{
		this.PanelActivate.SetTextByTextId(textId, args);
	}

	// Token: 0x06007007 RID: 28679 RVA: 0x00226756 File Offset: 0x00224956
	[NullableContext(1)]
	public void SetActivateTextByText(string text)
	{
		this.PanelActivate.SetTextByText(text);
	}

	// Token: 0x06007008 RID: 28680 RVA: 0x00226764 File Offset: 0x00224964
	public void SetActivateSpriteVisible(bool bVisible)
	{
		this.PanelActivate.SetSpriteVisible(bVisible);
	}

	// Token: 0x06007009 RID: 28681 RVA: 0x00226772 File Offset: 0x00224972
	public void SetActivatePanelConditionVisible(bool bVisible)
	{
		base.GetItem(2).SetUIActive(bVisible);
	}

	// Token: 0x0600700A RID: 28682 RVA: 0x00226781 File Offset: 0x00224981
	public void SetRewardButtonVisible(bool bVisible)
	{
		base.GetItem(4).SetUIActive(bVisible);
	}

	// Token: 0x0600700B RID: 28683 RVA: 0x00226790 File Offset: 0x00224990
	[NullableContext(1)]
	public void SetRewardButtonFunction(Action buttonFunction)
	{
		this.CircleButton.SetFunction(buttonFunction);
	}

	// Token: 0x0600700C RID: 28684 RVA: 0x0022679E File Offset: 0x0022499E
	public void SetFunctionRedDotVisible(bool bVisible)
	{
		this.FunctionButton.SetRedDotVisible(bVisible);
	}

	// Token: 0x0600700D RID: 28685 RVA: 0x002267AC File Offset: 0x002249AC
	[NullableContext(1)]
	public void SetPanelTipByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), textId, args);
	}

	// Token: 0x0600700E RID: 28686 RVA: 0x002267C1 File Offset: 0x002249C1
	[NullableContext(1)]
	public void SetPanelTipByText(string text)
	{
		base.GetText(7).SetText(text, true);
	}

	// Token: 0x0600700F RID: 28687 RVA: 0x002267D1 File Offset: 0x002249D1
	public void SetPanelTipVisible(bool bVisible)
	{
		base.GetItem(6).SetUIActive(bVisible);
	}

	// Token: 0x06007010 RID: 28688 RVA: 0x002267E0 File Offset: 0x002249E0
	public void RefreshGeneralPerformance(IActivityFunctionAreaParams parameters = null)
	{
		if (this.Data == null)
		{
			Log.Instance.Error(ELogModule.Activity, ELogAuthor.YYZ, "未传递活动数据,请传递数据再刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		bool flag = this.Data.IsUnLock();
		bool flag2 = this.Data.CanPreOpen();
		bool flag3 = this.Data.HasPreOpenCondition();
		if (flag)
		{
			if (parameters != null)
			{
				this.SetGeneralUnlockPerformance(parameters);
			}
			return;
		}
		if (!flag3)
		{
			this.FunctionButton.SetUiActive(false);
			this.SetPerformanceConditionLock(this.Data.ConditionGroupId, this.Data.Id);
			return;
		}
		if (flag2)
		{
			this.SetPanelTipByTextId("ActivityPreOpenTip", Array.Empty<string>());
			this.SetPanelTipVisible(true);
			this.FunctionButton.SetLocalTextNew("ActivityPreOpen", Array.Empty<object>());
			Action <>9__1;
			this.FunctionButton.SetFunction(delegate
			{
				ActivityController instance = ActivityController.Instance;
				ActivityBaseData data = this.Data;
				Action onClicked;
				if ((onClicked = <>9__1) == null)
				{
					onClicked = (<>9__1 = delegate()
					{
						IActivityFunctionAreaParams parameters2 = parameters;
						if (((parameters2 != null) ? parameters2.BeforePreOpenCheck : null) != null && !parameters.BeforePreOpenCheck())
						{
							return;
						}
						this.OpenPreOpenRequestConfirmBox();
					});
				}
				instance.JumpAndLog(data, onClicked);
			});
			this.FunctionButton.SetUiActive(true);
			this.SetPanelConditionVisible(false);
			return;
		}
		this.FunctionButton.SetUiActive(false);
		this.SetPerformanceConditionLock(this.Data.PreOpenConditionGroupId, this.Data.Id);
	}

	// Token: 0x06007011 RID: 28689 RVA: 0x00226914 File Offset: 0x00224B14
	[NullableContext(1)]
	public void SetGeneralUnlockPerformance(IActivityFunctionAreaParams parameters)
	{
		this.SetPanelConditionVisible(false);
		this.SetPanelTipVisible(false);
		if (parameters.UnlockBtnTextId != null)
		{
			if (parameters.UnlockBtnTextArgs != null)
			{
				ActivityButtonItem functionButton = this.FunctionButton;
				string unlockBtnTextId = parameters.UnlockBtnTextId;
				object[] unlockBtnTextArgs = parameters.UnlockBtnTextArgs;
				functionButton.SetLocalTextNew(unlockBtnTextId, unlockBtnTextArgs);
			}
			else
			{
				this.FunctionButton.SetLocalTextNew(parameters.UnlockBtnTextId, Array.Empty<object>());
			}
		}
		if (parameters.UnlockBtnFunction != null)
		{
			this.FunctionButton.SetFunction(parameters.UnlockBtnFunction);
		}
		this.FunctionButton.SetUiActive(true);
	}

	// Token: 0x06007012 RID: 28690 RVA: 0x00226995 File Offset: 0x00224B95
	public void SetPerformanceOpenTimeOver()
	{
		this.SetPanelConditionVisible(true);
		this.SetLockTextByTextId("Activity_EndDesc01", Array.Empty<string>());
		this.SetActivatePanelConditionVisible(false);
		this.SetLockConditionButtonVisible(false);
		this.SetRewardButtonVisible(false);
		this.FunctionButton.SetUiActive(false);
	}

	// Token: 0x06007013 RID: 28691 RVA: 0x002269D0 File Offset: 0x00224BD0
	public void SetPerformanceConditionLock(int conditionGroupId, int activityId)
	{
		this.SetPanelConditionVisible(true);
		this.SetActivatePanelConditionVisible(false);
		this.SetLockConditionButtonVisible(true);
		string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(conditionGroupId);
		if (conditionGroupHintText != null)
		{
			this.SetLockTextByTextId(conditionGroupHintText, Array.Empty<string>());
		}
		this.PanelLock.ButtonCallBack = delegate()
		{
			ActivityController.Instance.OpenActivityConditionView(activityId);
		};
	}

	// Token: 0x06007014 RID: 28692 RVA: 0x00226A2C File Offset: 0x00224C2C
	[NullableContext(1)]
	public void SetPerformanceSubPackageLock(string textId, List<int> subPackageIdList)
	{
		this.SetPanelConditionVisible(true);
		this.SetActivatePanelConditionVisible(false);
		this.SetLockConditionButtonVisible(true);
		this.PanelLock.ButtonCallBack = delegate()
		{
			foreach (int id in subPackageIdList)
			{
				DownLoadSubPackage? downLoadSubPackageById = SubPackageConfig.Instance.GetDownLoadSubPackageById(id);
				if (downLoadSubPackageById != null)
				{
					foreach (int blockId in downLoadSubPackageById.Value.GetAreaArray())
					{
						if (ResourceManagerController.Instance.IsNeedReOpenMap(blockId))
						{
							SubPackageDownLoadModel.Instance.OpenBlockNeedReLoginConfirm();
							return;
						}
					}
				}
			}
			SubPackageDownLoadModel.Instance.OpenSubPackageDownLoadConfirmBySubPackageIds(textId, subPackageIdList);
		};
	}

	// Token: 0x06007015 RID: 28693 RVA: 0x00226A7C File Offset: 0x00224C7C
	public void OpenPreOpenRequestConfirmBox()
	{
		if (this.Data == null)
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityPreOpen);
		Action value = delegate()
		{
			Action<bool> callback = delegate(bool success)
			{
				if (!success)
				{
					return;
				}
				EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, this.Data.Id);
			};
			ActivityController.Instance.RequestPreOpenActivity(this.Data, callback);
		};
		confirmBoxDataNew.FunctionMap.Add(2, value);
		string preOpenText = this.Data.LocalConfig.Value.PreOpenText;
		if (preOpenText != null)
		{
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				ConfigMultiTextLang.GetLocalTextNew(preOpenText, null)
			});
		}
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06007016 RID: 28694 RVA: 0x00226AF5 File Offset: 0x00224CF5
	public UUIItem GetFunctionButtonItem()
	{
		return base.GetItem(1);
	}

	// Token: 0x02006D17 RID: 27927
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023D0A RID: 146698
		public const int PanelCondition = 0;

		// Token: 0x04023D0B RID: 146699
		public const int FunctionButton = 1;

		// Token: 0x04023D0C RID: 146700
		public const int PanelActivate = 2;

		// Token: 0x04023D0D RID: 146701
		public const int FunctionRedDot = 3;

		// Token: 0x04023D0E RID: 146702
		public const int PanelCircle = 4;

		// Token: 0x04023D0F RID: 146703
		public const int ButtonCircle = 5;

		// Token: 0x04023D10 RID: 146704
		public const int PanelTip = 6;

		// Token: 0x04023D11 RID: 146705
		public const int TxtTip = 7;
	}
}

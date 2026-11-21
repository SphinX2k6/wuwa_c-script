using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000A07 RID: 2567
[NullableContext(2)]
[Nullable(0)]
public class ActivityFunctionalArea : UiPanelBase
{
	// Token: 0x17000D7F RID: 3455
	// (get) Token: 0x06006FD3 RID: 28627 RVA: 0x00225F0A File Offset: 0x0022410A
	// (set) Token: 0x06006FD4 RID: 28628 RVA: 0x00225F12 File Offset: 0x00224112
	public ActivityButtonItem FunctionButton { get; set; }

	// Token: 0x17000D80 RID: 3456
	// (get) Token: 0x06006FD5 RID: 28629 RVA: 0x00225F1B File Offset: 0x0022411B
	// (set) Token: 0x06006FD6 RID: 28630 RVA: 0x00225F23 File Offset: 0x00224123
	public ButtonSpriteItem CircleButton { get; set; }

	// Token: 0x17000D81 RID: 3457
	// (get) Token: 0x06006FD7 RID: 28631 RVA: 0x00225F2C File Offset: 0x0022412C
	// (set) Token: 0x06006FD8 RID: 28632 RVA: 0x00225F34 File Offset: 0x00224134
	public FunctionalPanelConditionLock PanelLock { get; set; }

	// Token: 0x06006FD9 RID: 28633 RVA: 0x00225F3D File Offset: 0x0022413D
	public ActivityFunctionalArea(ActivityBaseData data)
	{
		this.Data = data;
	}

	// Token: 0x06006FDA RID: 28634 RVA: 0x00225F4C File Offset: 0x0022414C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
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
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006FDB RID: 28635 RVA: 0x0022603C File Offset: 0x0022423C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityFunctionalArea.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityFunctionalArea.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006FDC RID: 28636 RVA: 0x00226080 File Offset: 0x00224280
	private UniTask CreatePanelLockAsync()
	{
		ActivityFunctionalArea.<CreatePanelLockAsync>d__17 <CreatePanelLockAsync>d__;
		<CreatePanelLockAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePanelLockAsync>d__.<>4__this = this;
		<CreatePanelLockAsync>d__.<>1__state = -1;
		<CreatePanelLockAsync>d__.<>t__builder.Start<ActivityFunctionalArea.<CreatePanelLockAsync>d__17>(ref <CreatePanelLockAsync>d__);
		return <CreatePanelLockAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006FDD RID: 28637 RVA: 0x002260C4 File Offset: 0x002242C4
	private UniTask CreateCircleButtonAsync()
	{
		ActivityFunctionalArea.<CreateCircleButtonAsync>d__18 <CreateCircleButtonAsync>d__;
		<CreateCircleButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCircleButtonAsync>d__.<>4__this = this;
		<CreateCircleButtonAsync>d__.<>1__state = -1;
		<CreateCircleButtonAsync>d__.<>t__builder.Start<ActivityFunctionalArea.<CreateCircleButtonAsync>d__18>(ref <CreateCircleButtonAsync>d__);
		return <CreateCircleButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006FDE RID: 28638 RVA: 0x00226108 File Offset: 0x00224308
	private UniTask CreateFunctionButtonAsync()
	{
		ActivityFunctionalArea.<CreateFunctionButtonAsync>d__19 <CreateFunctionButtonAsync>d__;
		<CreateFunctionButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateFunctionButtonAsync>d__.<>4__this = this;
		<CreateFunctionButtonAsync>d__.<>1__state = -1;
		<CreateFunctionButtonAsync>d__.<>t__builder.Start<ActivityFunctionalArea.<CreateFunctionButtonAsync>d__19>(ref <CreateFunctionButtonAsync>d__);
		return <CreateFunctionButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006FDF RID: 28639 RVA: 0x0022614B File Offset: 0x0022434B
	protected override void OnStart()
	{
		this.SetRewardRedDotVisible(false);
	}

	// Token: 0x06006FE0 RID: 28640 RVA: 0x00226154 File Offset: 0x00224354
	[NullableContext(1)]
	public void SetLockTextByTextId(string textId, params string[] args)
	{
		this.PanelLock.SetTextByTextId(textId, args);
	}

	// Token: 0x06006FE1 RID: 28641 RVA: 0x00226163 File Offset: 0x00224363
	[NullableContext(1)]
	public void SetLockTextByText(string text)
	{
		this.PanelLock.SetTextByText(text);
	}

	// Token: 0x06006FE2 RID: 28642 RVA: 0x00226171 File Offset: 0x00224371
	public void SetLockSpriteVisible(bool bVisible)
	{
		this.PanelLock.SetSpriteVisible(bVisible);
	}

	// Token: 0x06006FE3 RID: 28643 RVA: 0x0022617F File Offset: 0x0022437F
	public void SetPanelConditionVisible(bool bVisible)
	{
		base.GetItem(0).SetUIActive(bVisible);
	}

	// Token: 0x06006FE4 RID: 28644 RVA: 0x0022618E File Offset: 0x0022438E
	public void SetRewardButtonVisible(bool state)
	{
		base.GetItem(2).SetUIActive(state);
	}

	// Token: 0x06006FE5 RID: 28645 RVA: 0x0022619D File Offset: 0x0022439D
	[NullableContext(1)]
	public void SetRewardButtonFunction(Action buttonFunction)
	{
		this.CircleButton.SetFunction(buttonFunction);
	}

	// Token: 0x06006FE6 RID: 28646 RVA: 0x002261AB File Offset: 0x002243AB
	public void SetRewardRedDotVisible(bool bVisible)
	{
		this.CircleButton.SetRedDotVisible(bVisible);
	}

	// Token: 0x06006FE7 RID: 28647 RVA: 0x002261B9 File Offset: 0x002243B9
	public void BindRewardRedDot(ERedDotName redDotName, int uId = 0)
	{
		this.CircleButton.BindRedDot(redDotName, uId);
	}

	// Token: 0x06006FE8 RID: 28648 RVA: 0x002261C8 File Offset: 0x002243C8
	public void UnbindRewardRedDot()
	{
		this.CircleButton.UnBindRedDot();
	}

	// Token: 0x06006FE9 RID: 28649 RVA: 0x002261D5 File Offset: 0x002243D5
	public void SetFunctionButtonVisible(bool bVisible)
	{
		ActivityButtonItem functionButton = this.FunctionButton;
		if (functionButton == null)
		{
			return;
		}
		functionButton.SetUiActive(bVisible);
	}

	// Token: 0x06006FEA RID: 28650 RVA: 0x002261E8 File Offset: 0x002243E8
	[NullableContext(1)]
	public void SetPanelTipByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textId, args);
	}

	// Token: 0x06006FEB RID: 28651 RVA: 0x002261FD File Offset: 0x002243FD
	[NullableContext(1)]
	public void SetPanelTipByText(string text)
	{
		base.GetText(5).SetText(text, true);
	}

	// Token: 0x06006FEC RID: 28652 RVA: 0x0022620D File Offset: 0x0022440D
	public void SetPanelTipVisible(bool bVisible)
	{
		base.GetItem(4).SetUIActive(bVisible);
	}

	// Token: 0x06006FED RID: 28653 RVA: 0x0022621C File Offset: 0x0022441C
	public void RefreshGeneralPerformance(IActivityFunctionAreaParams @params = null)
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
			if (@params != null)
			{
				this.SetGeneralUnlockPerformance(@params);
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
			this.SetPanelConditionVisible(true);
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
						IActivityFunctionAreaParams params2 = @params;
						if (((params2 != null) ? params2.BeforePreOpenCheck : null) != null && !@params.BeforePreOpenCheck())
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

	// Token: 0x06006FEE RID: 28654 RVA: 0x00226350 File Offset: 0x00224550
	[NullableContext(1)]
	public void SetGeneralUnlockPerformance(IActivityFunctionAreaParams @params)
	{
		this.SetPanelConditionVisible(false);
		if (@params.UnlockBtnTextId != null)
		{
			if (@params.UnlockBtnTextArgs != null)
			{
				ActivityButtonItem functionButton = this.FunctionButton;
				string unlockBtnTextId = @params.UnlockBtnTextId;
				object[] unlockBtnTextArgs = @params.UnlockBtnTextArgs;
				functionButton.SetLocalTextNew(unlockBtnTextId, unlockBtnTextArgs);
			}
			else
			{
				this.FunctionButton.SetLocalTextNew(@params.UnlockBtnTextId, Array.Empty<object>());
			}
		}
		if (@params.UnlockBtnFunction != null)
		{
			this.FunctionButton.SetFunction(@params.UnlockBtnFunction);
		}
		this.FunctionButton.SetUiActive(true);
	}

	// Token: 0x06006FEF RID: 28655 RVA: 0x002263CA File Offset: 0x002245CA
	public void SetPerformanceOpenTimeOver()
	{
		this.SetPanelConditionVisible(true);
		this.SetLockTextByTextId("Activity_EndDesc01", Array.Empty<string>());
		this.PanelLock.SetButtonVisible(false);
		this.SetRewardButtonVisible(false);
		this.FunctionButton.SetUiActive(false);
	}

	// Token: 0x06006FF0 RID: 28656 RVA: 0x00226404 File Offset: 0x00224604
	public void SetPerformanceConditionLock(int conditionGroupId, int activityId)
	{
		this.SetPanelConditionVisible(true);
		this.PanelLock.SetButtonVisible(true);
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

	// Token: 0x06006FF1 RID: 28657 RVA: 0x00226460 File Offset: 0x00224660
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
		confirmBoxDataNew.FunctionMap[2] = value;
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

	// Token: 0x0400451B RID: 17691
	protected readonly ActivityBaseData Data;

	// Token: 0x02006D10 RID: 27920
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023CF0 RID: 146672
		public const int PanelCondition = 0;

		// Token: 0x04023CF1 RID: 146673
		public const int ButtonFunction = 1;

		// Token: 0x04023CF2 RID: 146674
		public const int PanelCircle = 2;

		// Token: 0x04023CF3 RID: 146675
		public const int ButtonCircle = 3;

		// Token: 0x04023CF4 RID: 146676
		public const int PanelTip = 4;

		// Token: 0x04023CF5 RID: 146677
		public const int TxtTip = 5;
	}
}

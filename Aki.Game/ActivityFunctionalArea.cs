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

// Token: 0x0200154F RID: 5455
[NullableContext(2)]
[Nullable(0)]
public class ActivityFunctionalArea : UiPanelBase
{
	// Token: 0x17000D5E RID: 3422
	// (get) Token: 0x06009BF5 RID: 39925 RVA: 0x0021C15A File Offset: 0x0021A35A
	// (set) Token: 0x06009BF6 RID: 39926 RVA: 0x0021C162 File Offset: 0x0021A362
	public ActivityButtonItem FunctionButton { get; set; }

	// Token: 0x17000D5F RID: 3423
	// (get) Token: 0x06009BF7 RID: 39927 RVA: 0x0021C16B File Offset: 0x0021A36B
	// (set) Token: 0x06009BF8 RID: 39928 RVA: 0x0021C173 File Offset: 0x0021A373
	public ButtonSpriteItem CircleButton { get; set; }

	// Token: 0x17000D60 RID: 3424
	// (get) Token: 0x06009BF9 RID: 39929 RVA: 0x0021C17C File Offset: 0x0021A37C
	// (set) Token: 0x06009BFA RID: 39930 RVA: 0x0021C184 File Offset: 0x0021A384
	public FunctionalPanelConditionLock PanelLock { get; set; }

	// Token: 0x06009BFB RID: 39931 RVA: 0x0021C18D File Offset: 0x0021A38D
	public ActivityFunctionalArea(ActivityBaseData data)
	{
		this.Data = data;
	}

	// Token: 0x06009BFC RID: 39932 RVA: 0x0021C19C File Offset: 0x0021A39C
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

	// Token: 0x06009BFD RID: 39933 RVA: 0x0021C28C File Offset: 0x0021A48C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityFunctionalArea.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityFunctionalArea.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009BFE RID: 39934 RVA: 0x0021C2D0 File Offset: 0x0021A4D0
	private UniTask CreatePanelLockAsync()
	{
		ActivityFunctionalArea.<CreatePanelLockAsync>d__17 <CreatePanelLockAsync>d__;
		<CreatePanelLockAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePanelLockAsync>d__.<>4__this = this;
		<CreatePanelLockAsync>d__.<>1__state = -1;
		<CreatePanelLockAsync>d__.<>t__builder.Start<ActivityFunctionalArea.<CreatePanelLockAsync>d__17>(ref <CreatePanelLockAsync>d__);
		return <CreatePanelLockAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009BFF RID: 39935 RVA: 0x0021C314 File Offset: 0x0021A514
	private UniTask CreateCircleButtonAsync()
	{
		ActivityFunctionalArea.<CreateCircleButtonAsync>d__18 <CreateCircleButtonAsync>d__;
		<CreateCircleButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCircleButtonAsync>d__.<>4__this = this;
		<CreateCircleButtonAsync>d__.<>1__state = -1;
		<CreateCircleButtonAsync>d__.<>t__builder.Start<ActivityFunctionalArea.<CreateCircleButtonAsync>d__18>(ref <CreateCircleButtonAsync>d__);
		return <CreateCircleButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009C00 RID: 39936 RVA: 0x0021C358 File Offset: 0x0021A558
	private UniTask CreateFunctionButtonAsync()
	{
		ActivityFunctionalArea.<CreateFunctionButtonAsync>d__19 <CreateFunctionButtonAsync>d__;
		<CreateFunctionButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateFunctionButtonAsync>d__.<>4__this = this;
		<CreateFunctionButtonAsync>d__.<>1__state = -1;
		<CreateFunctionButtonAsync>d__.<>t__builder.Start<ActivityFunctionalArea.<CreateFunctionButtonAsync>d__19>(ref <CreateFunctionButtonAsync>d__);
		return <CreateFunctionButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009C01 RID: 39937 RVA: 0x0021C39B File Offset: 0x0021A59B
	protected override void OnStart()
	{
		this.SetRewardRedDotVisible(false);
	}

	// Token: 0x06009C02 RID: 39938 RVA: 0x0021C3A4 File Offset: 0x0021A5A4
	[NullableContext(1)]
	public void SetLockTextByTextId(string textId, params string[] args)
	{
		this.PanelLock.SetTextByTextId(textId, args);
	}

	// Token: 0x06009C03 RID: 39939 RVA: 0x0021C3B3 File Offset: 0x0021A5B3
	[NullableContext(1)]
	public void SetLockTextByText(string text)
	{
		this.PanelLock.SetTextByText(text);
	}

	// Token: 0x06009C04 RID: 39940 RVA: 0x0021C3C1 File Offset: 0x0021A5C1
	public void SetLockSpriteVisible(bool bVisible)
	{
		this.PanelLock.SetSpriteVisible(bVisible);
	}

	// Token: 0x06009C05 RID: 39941 RVA: 0x0021C3CF File Offset: 0x0021A5CF
	public void SetPanelConditionVisible(bool bVisible)
	{
		base.GetItem(0).SetUIActive(bVisible);
	}

	// Token: 0x06009C06 RID: 39942 RVA: 0x0021C3DE File Offset: 0x0021A5DE
	public void SetRewardButtonVisible(bool state)
	{
		base.GetItem(2).SetUIActive(state);
	}

	// Token: 0x06009C07 RID: 39943 RVA: 0x0021C3ED File Offset: 0x0021A5ED
	[NullableContext(1)]
	public void SetRewardButtonFunction(Action buttonFunction)
	{
		this.CircleButton.SetFunction(buttonFunction);
	}

	// Token: 0x06009C08 RID: 39944 RVA: 0x0021C3FB File Offset: 0x0021A5FB
	public void SetRewardRedDotVisible(bool bVisible)
	{
		this.CircleButton.SetRedDotVisible(bVisible);
	}

	// Token: 0x06009C09 RID: 39945 RVA: 0x0021C409 File Offset: 0x0021A609
	public void BindRewardRedDot(ERedDotName redDotName, int uId = 0)
	{
		this.CircleButton.BindRedDot(redDotName, uId);
	}

	// Token: 0x06009C0A RID: 39946 RVA: 0x0021C418 File Offset: 0x0021A618
	public void UnbindRewardRedDot()
	{
		this.CircleButton.UnBindRedDot();
	}

	// Token: 0x06009C0B RID: 39947 RVA: 0x0021C425 File Offset: 0x0021A625
	public void SetFunctionButtonVisible(bool bVisible)
	{
		ActivityButtonItem functionButton = this.FunctionButton;
		if (functionButton == null)
		{
			return;
		}
		functionButton.SetUiActive(bVisible);
	}

	// Token: 0x06009C0C RID: 39948 RVA: 0x0021C438 File Offset: 0x0021A638
	[NullableContext(1)]
	public void SetPanelTipByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textId, args);
	}

	// Token: 0x06009C0D RID: 39949 RVA: 0x0021C44D File Offset: 0x0021A64D
	[NullableContext(1)]
	public void SetPanelTipByText(string text)
	{
		base.GetText(5).SetText(text, true);
	}

	// Token: 0x06009C0E RID: 39950 RVA: 0x0021C45D File Offset: 0x0021A65D
	public void SetPanelTipVisible(bool bVisible)
	{
		base.GetItem(4).SetUIActive(bVisible);
	}

	// Token: 0x06009C0F RID: 39951 RVA: 0x0021C46C File Offset: 0x0021A66C
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

	// Token: 0x06009C10 RID: 39952 RVA: 0x0021C5A0 File Offset: 0x0021A7A0
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

	// Token: 0x06009C11 RID: 39953 RVA: 0x0021C61A File Offset: 0x0021A81A
	public void SetPerformanceOpenTimeOver()
	{
		this.SetPanelConditionVisible(true);
		this.SetLockTextByTextId("Activity_EndDesc01", Array.Empty<string>());
		this.PanelLock.SetButtonVisible(false);
		this.SetRewardButtonVisible(false);
		this.FunctionButton.SetUiActive(false);
	}

	// Token: 0x06009C12 RID: 39954 RVA: 0x0021C654 File Offset: 0x0021A854
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

	// Token: 0x06009C13 RID: 39955 RVA: 0x0021C6B0 File Offset: 0x0021A8B0
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

	// Token: 0x04004475 RID: 17525
	protected readonly ActivityBaseData Data;

	// Token: 0x02007B85 RID: 31621
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040289B5 RID: 166325
		public const int PanelCondition = 0;

		// Token: 0x040289B6 RID: 166326
		public const int ButtonFunction = 1;

		// Token: 0x040289B7 RID: 166327
		public const int PanelCircle = 2;

		// Token: 0x040289B8 RID: 166328
		public const int ButtonCircle = 3;

		// Token: 0x040289B9 RID: 166329
		public const int PanelTip = 4;

		// Token: 0x040289BA RID: 166330
		public const int TxtTip = 5;
	}
}

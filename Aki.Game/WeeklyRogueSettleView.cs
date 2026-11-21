using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022B2 RID: 8882
public class WeeklyRogueSettleView : UiViewBase
{
	// Token: 0x06015EF1 RID: 89841 RVA: 0x0065C2F3 File Offset: 0x0065A4F3
	[NullableContext(1)]
	public WeeklyRogueSettleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015EF2 RID: 89842 RVA: 0x0065C2FC File Offset: 0x0065A4FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem))
		};
	}

	// Token: 0x06015EF3 RID: 89843 RVA: 0x0065C384 File Offset: 0x0065A584
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueSettleView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueSettleView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015EF4 RID: 89844 RVA: 0x0065C3C7 File Offset: 0x0065A5C7
	protected override void OnBeforeShow()
	{
		this.InitAutoLeaveTimer();
		this.RefreshTitle();
	}

	// Token: 0x06015EF5 RID: 89845 RVA: 0x0065C3D5 File Offset: 0x0065A5D5
	protected override void OnBeforeDestroy()
	{
		this.ClearAutoLeaveTimer();
	}

	// Token: 0x06015EF6 RID: 89846 RVA: 0x0065C3E0 File Offset: 0x0065A5E0
	protected void RefreshTitle()
	{
		if (this.Data == null)
		{
			return;
		}
		UUIText text = base.GetText(1);
		UUITexture texture = base.GetTexture(2);
		if (texture != null)
		{
			texture.SetUIActive(false);
		}
		LguiUtil.Instance.SetLocalTextNew(text, "Text_ChallengeFinish_Text", Array.Empty<object>());
		base.PlaySequence("Success", null, false);
	}

	// Token: 0x06015EF7 RID: 89847 RVA: 0x0065C433 File Offset: 0x0065A633
	private void ClearAutoLeaveTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
		}
		this.AutoLeaveTimerId = null;
	}

	// Token: 0x06015EF8 RID: 89848 RVA: 0x0065C45F File Offset: 0x0065A65F
	private void OnClickBtnLeave()
	{
		WeeklyRogueController instance = WeeklyRogueController.Instance;
		if (instance != null)
		{
			instance.MarkAutoOpenDailyActivityWeekly();
		}
		base.CloseMe(delegate(bool success)
		{
			if (success)
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
			}
		});
	}

	// Token: 0x06015EF9 RID: 89849 RVA: 0x0065C498 File Offset: 0x0065A698
	private void InitAutoLeaveTimer()
	{
		int leftSecondToAutoLeave = 31;
		this.AutoLeaveTimerId = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			int leftSecondToAutoLeave;
			if (leftSecondToAutoLeave <= 0)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
				this.OnClickBtnLeave();
				return;
			}
			ActivityCorniceMeetingButton activityCorniceMeetingButton = this.ButtonMap[0];
			string textId = "InstanceDungeonLeftTimeToAutoLeave";
			string[] array = new string[1];
			int num = 0;
			leftSecondToAutoLeave = leftSecondToAutoLeave;
			leftSecondToAutoLeave--;
			array[num] = leftSecondToAutoLeave.ToString();
			activityCorniceMeetingButton.SetFloatText(textId, array);
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x06015EFA RID: 89850 RVA: 0x0065C4E4 File Offset: 0x0065A6E4
	private UniTask InitButtonAsync()
	{
		WeeklyRogueSettleView.<InitButtonAsync>d__16 <InitButtonAsync>d__;
		<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButtonAsync>d__.<>4__this = this;
		<InitButtonAsync>d__.<>1__state = -1;
		<InitButtonAsync>d__.<>t__builder.Start<WeeklyRogueSettleView.<InitButtonAsync>d__16>(ref <InitButtonAsync>d__);
		return <InitButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015EFB RID: 89851 RVA: 0x0065C528 File Offset: 0x0065A728
	[NullableContext(1)]
	private UniTask CreateButton(UUIItem uiItem, WeeklyRogueSettleView.EButtons buttonIndex, Action clickFunction)
	{
		WeeklyRogueSettleView.<CreateButton>d__17 <CreateButton>d__;
		<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateButton>d__.<>4__this = this;
		<CreateButton>d__.buttonIndex = buttonIndex;
		<CreateButton>d__.clickFunction = clickFunction;
		<CreateButton>d__.<>1__state = -1;
		<CreateButton>d__.<>t__builder.Start<WeeklyRogueSettleView.<CreateButton>d__17>(ref <CreateButton>d__);
		return <CreateButton>d__.<>t__builder.Task;
	}

	// Token: 0x0400B86D RID: 47213
	private const int LEAVETIME = 30;

	// Token: 0x0400B86E RID: 47214
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, ActivityCorniceMeetingButton> ButtonMap;

	// Token: 0x0400B86F RID: 47215
	[Nullable(2)]
	private TimerHandle AutoLeaveTimerId;

	// Token: 0x0400B870 RID: 47216
	[Nullable(2)]
	protected RogueWeeklyResultNotify Data;

	// Token: 0x0400B871 RID: 47217
	[Nullable(2)]
	protected WeeklyRogueSettleInfoPanel InfoPanel;

	// Token: 0x0200851B RID: 34075
	private enum EComponents
	{
		// Token: 0x0402AE7E RID: 175742
		TxtTitle = 1,
		// Token: 0x0402AE7F RID: 175743
		TextureIcon,
		// Token: 0x0402AE80 RID: 175744
		ButtonHorizontalItem = 4,
		// Token: 0x0402AE81 RID: 175745
		ButtonItem,
		// Token: 0x0402AE82 RID: 175746
		Content = 20
	}

	// Token: 0x0200851C RID: 34076
	private enum EButtons
	{
		// Token: 0x0402AE84 RID: 175748
		LeftButton,
		// Token: 0x0402AE85 RID: 175749
		RightButton
	}
}

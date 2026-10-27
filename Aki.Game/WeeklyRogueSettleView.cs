using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D58 RID: 11608
public class WeeklyRogueSettleView : UiViewBase
{
	// Token: 0x0601864F RID: 99919 RVA: 0x006362E3 File Offset: 0x006344E3
	[NullableContext(1)]
	public WeeklyRogueSettleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06018650 RID: 99920 RVA: 0x006362EC File Offset: 0x006344EC
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

	// Token: 0x06018651 RID: 99921 RVA: 0x00636374 File Offset: 0x00634574
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueSettleView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueSettleView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06018652 RID: 99922 RVA: 0x006363B7 File Offset: 0x006345B7
	protected override void OnBeforeShow()
	{
		this.InitAutoLeaveTimer();
		this.RefreshTitle();
	}

	// Token: 0x06018653 RID: 99923 RVA: 0x006363C5 File Offset: 0x006345C5
	protected override void OnBeforeDestroy()
	{
		this.ClearAutoLeaveTimer();
	}

	// Token: 0x06018654 RID: 99924 RVA: 0x006363D0 File Offset: 0x006345D0
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

	// Token: 0x06018655 RID: 99925 RVA: 0x00636423 File Offset: 0x00634623
	private void ClearAutoLeaveTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
		}
		this.AutoLeaveTimerId = null;
	}

	// Token: 0x06018656 RID: 99926 RVA: 0x0063644F File Offset: 0x0063464F
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

	// Token: 0x06018657 RID: 99927 RVA: 0x00636488 File Offset: 0x00634688
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

	// Token: 0x06018658 RID: 99928 RVA: 0x006364D4 File Offset: 0x006346D4
	private UniTask InitButtonAsync()
	{
		WeeklyRogueSettleView.<InitButtonAsync>d__16 <InitButtonAsync>d__;
		<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButtonAsync>d__.<>4__this = this;
		<InitButtonAsync>d__.<>1__state = -1;
		<InitButtonAsync>d__.<>t__builder.Start<WeeklyRogueSettleView.<InitButtonAsync>d__16>(ref <InitButtonAsync>d__);
		return <InitButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06018659 RID: 99929 RVA: 0x00636518 File Offset: 0x00634718
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

	// Token: 0x0400B4F8 RID: 46328
	private const int LEAVETIME = 30;

	// Token: 0x0400B4F9 RID: 46329
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, ActivityCorniceMeetingButton> ButtonMap;

	// Token: 0x0400B4FA RID: 46330
	[Nullable(2)]
	private TimerHandle AutoLeaveTimerId;

	// Token: 0x0400B4FB RID: 46331
	[Nullable(2)]
	protected RogueWeeklyResultNotify Data;

	// Token: 0x0400B4FC RID: 46332
	[Nullable(2)]
	protected WeeklyRogueSettleInfoPanel InfoPanel;

	// Token: 0x020092F4 RID: 37620
	private enum EComponents
	{
		// Token: 0x0402F7F6 RID: 194550
		TxtTitle = 1,
		// Token: 0x0402F7F7 RID: 194551
		TextureIcon,
		// Token: 0x0402F7F8 RID: 194552
		ButtonHorizontalItem = 4,
		// Token: 0x0402F7F9 RID: 194553
		ButtonItem,
		// Token: 0x0402F7FA RID: 194554
		Content = 20
	}

	// Token: 0x020092F5 RID: 37621
	private enum EButtons
	{
		// Token: 0x0402F7FC RID: 194556
		LeftButton,
		// Token: 0x0402F7FD RID: 194557
		RightButton
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A37 RID: 6711
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssInfoView : UiViewBase
{
	// Token: 0x0600C560 RID: 50528 RVA: 0x002CC8E2 File Offset: 0x002CAAE2
	[NullableContext(1)]
	public DangoAbyssInfoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C561 RID: 50529 RVA: 0x002CC8EC File Offset: 0x002CAAEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x0600C562 RID: 50530 RVA: 0x002CC99E File Offset: 0x002CAB9E
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssRoomInfoUpdate, new Action(this.OnAbyssRoomInfoUpdate));
	}

	// Token: 0x0600C563 RID: 50531 RVA: 0x002CC9BC File Offset: 0x002CABBC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssRoomInfoUpdate, new Action(this.OnAbyssRoomInfoUpdate));
	}

	// Token: 0x0600C564 RID: 50532 RVA: 0x002CC9DC File Offset: 0x002CABDC
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssInfoView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssInfoView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C565 RID: 50533 RVA: 0x002CCA1F File Offset: 0x002CAC1F
	private void OnAbyssRoomInfoUpdate()
	{
		this.RefreshProgressElements();
	}

	// Token: 0x0600C566 RID: 50534 RVA: 0x002CCA27 File Offset: 0x002CAC27
	private void OnRefreshTime(float _)
	{
		this.RefreshTimeText();
	}

	// Token: 0x0600C567 RID: 50535 RVA: 0x002CCA30 File Offset: 0x002CAC30
	private void RefreshProgressElements()
	{
		float instanceProgress = DangoAbyssModel.Instance.GetInstanceProgress();
		this.RefreshRewardItem(instanceProgress);
	}

	// Token: 0x0600C568 RID: 50536 RVA: 0x002CCA4F File Offset: 0x002CAC4F
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C569 RID: 50537 RVA: 0x002CCA58 File Offset: 0x002CAC58
	protected override void OnBeforeShow()
	{
		this.RefreshDeadText();
		this.RefreshFloorText();
		this.RefreshTimeText();
		this.RefreshProgressElements();
		this.RefreshTitleText();
		this.RefreshDescText();
	}

	// Token: 0x0600C56A RID: 50538 RVA: 0x002CCA80 File Offset: 0x002CAC80
	private void RefreshDeadText()
	{
		string instanceReviveTipTips = DangoAbyssModel.Instance.GetInstanceReviveTipTips();
		SpriteTextItem deadInfoItem = this.DeadInfoItem;
		if (deadInfoItem == null)
		{
			return;
		}
		deadInfoItem.SetDesc(instanceReviveTipTips);
	}

	// Token: 0x0600C56B RID: 50539 RVA: 0x002CCAAC File Offset: 0x002CACAC
	private void RefreshFloorText()
	{
		string instanceFloorDetailProgressText = DangoAbyssModel.Instance.GetInstanceFloorDetailProgressText();
		SpriteTextItem roomInfoItem = this.RoomInfoItem;
		if (roomInfoItem == null)
		{
			return;
		}
		roomInfoItem.SetDesc(instanceFloorDetailProgressText);
	}

	// Token: 0x0600C56C RID: 50540 RVA: 0x002CCAD8 File Offset: 0x002CACD8
	private void RefreshTimeText()
	{
		string instanceRemainTimeText = DangoAbyssModel.Instance.GetInstanceRemainTimeText();
		SpriteTextItem timeItem = this.TimeItem;
		if (timeItem == null)
		{
			return;
		}
		timeItem.SetDesc(instanceRemainTimeText);
	}

	// Token: 0x0600C56D RID: 50541 RVA: 0x002CCB04 File Offset: 0x002CAD04
	private void RefreshTitleText()
	{
		string currentAbyssName = DangoAbyssModel.Instance.GetCurrentAbyssName();
		if (currentAbyssName != "")
		{
			SpriteTextItem currentLevelTitleItem = this.CurrentLevelTitleItem;
			if (currentLevelTitleItem == null)
			{
				return;
			}
			currentLevelTitleItem.SetDesc(currentAbyssName);
		}
	}

	// Token: 0x0600C56E RID: 50542 RVA: 0x002CCB3C File Offset: 0x002CAD3C
	private void RefreshDescText()
	{
		string currentRouteDesc = DangoAbyssModel.Instance.GetCurrentRouteDesc();
		DescItem descItem = this.DescItem;
		if (descItem == null)
		{
			return;
		}
		descItem.SetDesc(currentRouteDesc);
	}

	// Token: 0x0600C56F RID: 50543 RVA: 0x002CCB65 File Offset: 0x002CAD65
	private void RefreshRewardItem(float progress)
	{
		RewardInfoItem rewardItem = this.RewardItem;
		if (rewardItem == null)
		{
			return;
		}
		rewardItem.RefreshByProgress(progress);
	}

	// Token: 0x0600C570 RID: 50544 RVA: 0x002CCB78 File Offset: 0x002CAD78
	protected override void OnBeforeDestroy()
	{
		if (this.RefreshTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}
	}

	// Token: 0x04005AF9 RID: 23289
	private PopupCaptionItem CaptionItem;

	// Token: 0x04005AFA RID: 23290
	private SpriteTextItem CurrentLevelTitleItem;

	// Token: 0x04005AFB RID: 23291
	private SpriteTextItem DeadInfoItem;

	// Token: 0x04005AFC RID: 23292
	private SpriteTextItem TimeItem;

	// Token: 0x04005AFD RID: 23293
	private SpriteTextItem RoomInfoItem;

	// Token: 0x04005AFE RID: 23294
	private RewardInfoItem RewardItem;

	// Token: 0x04005AFF RID: 23295
	private DescItem DescItem;

	// Token: 0x04005B00 RID: 23296
	private TimerHandle RefreshTimer;

	// Token: 0x02007F80 RID: 32640
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040299F0 RID: 170480
		CaptionItem,
		// Token: 0x040299F1 RID: 170481
		CurrentLevelTitleItem,
		// Token: 0x040299F2 RID: 170482
		DeadInfoItem,
		// Token: 0x040299F3 RID: 170483
		RewardItem,
		// Token: 0x040299F4 RID: 170484
		TimeItem,
		// Token: 0x040299F5 RID: 170485
		RoomInfoItem,
		// Token: 0x040299F6 RID: 170486
		DescItem
	}
}

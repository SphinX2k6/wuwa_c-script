using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EF6 RID: 3830
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssInfoView : UiViewBase
{
	// Token: 0x06009970 RID: 39280 RVA: 0x002D7A06 File Offset: 0x002D5C06
	[NullableContext(1)]
	public DangoAbyssInfoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009971 RID: 39281 RVA: 0x002D7A10 File Offset: 0x002D5C10
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

	// Token: 0x06009972 RID: 39282 RVA: 0x002D7AC2 File Offset: 0x002D5CC2
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssRoomInfoUpdate, new Action(this.OnAbyssRoomInfoUpdate));
	}

	// Token: 0x06009973 RID: 39283 RVA: 0x002D7AE0 File Offset: 0x002D5CE0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssRoomInfoUpdate, new Action(this.OnAbyssRoomInfoUpdate));
	}

	// Token: 0x06009974 RID: 39284 RVA: 0x002D7B00 File Offset: 0x002D5D00
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssInfoView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssInfoView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009975 RID: 39285 RVA: 0x002D7B43 File Offset: 0x002D5D43
	private void OnAbyssRoomInfoUpdate()
	{
		this.RefreshProgressElements();
	}

	// Token: 0x06009976 RID: 39286 RVA: 0x002D7B4B File Offset: 0x002D5D4B
	private void OnRefreshTime(float _)
	{
		this.RefreshTimeText();
	}

	// Token: 0x06009977 RID: 39287 RVA: 0x002D7B54 File Offset: 0x002D5D54
	private void RefreshProgressElements()
	{
		float instanceProgress = DangoAbyssModel.Instance.GetInstanceProgress();
		this.RefreshRewardItem(instanceProgress);
	}

	// Token: 0x06009978 RID: 39288 RVA: 0x002D7B73 File Offset: 0x002D5D73
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009979 RID: 39289 RVA: 0x002D7B7C File Offset: 0x002D5D7C
	protected override void OnBeforeShow()
	{
		this.RefreshDeadText();
		this.RefreshFloorText();
		this.RefreshTimeText();
		this.RefreshProgressElements();
		this.RefreshTitleText();
		this.RefreshDescText();
	}

	// Token: 0x0600997A RID: 39290 RVA: 0x002D7BA4 File Offset: 0x002D5DA4
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

	// Token: 0x0600997B RID: 39291 RVA: 0x002D7BD0 File Offset: 0x002D5DD0
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

	// Token: 0x0600997C RID: 39292 RVA: 0x002D7BFC File Offset: 0x002D5DFC
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

	// Token: 0x0600997D RID: 39293 RVA: 0x002D7C28 File Offset: 0x002D5E28
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

	// Token: 0x0600997E RID: 39294 RVA: 0x002D7C60 File Offset: 0x002D5E60
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

	// Token: 0x0600997F RID: 39295 RVA: 0x002D7C89 File Offset: 0x002D5E89
	private void RefreshRewardItem(float progress)
	{
		RewardInfoItem rewardItem = this.RewardItem;
		if (rewardItem == null)
		{
			return;
		}
		rewardItem.RefreshByProgress(progress);
	}

	// Token: 0x06009980 RID: 39296 RVA: 0x002D7C9C File Offset: 0x002D5E9C
	protected override void OnBeforeDestroy()
	{
		if (this.RefreshTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}
	}

	// Token: 0x04005BC8 RID: 23496
	private PopupCaptionItem CaptionItem;

	// Token: 0x04005BC9 RID: 23497
	private SpriteTextItem CurrentLevelTitleItem;

	// Token: 0x04005BCA RID: 23498
	private SpriteTextItem DeadInfoItem;

	// Token: 0x04005BCB RID: 23499
	private SpriteTextItem TimeItem;

	// Token: 0x04005BCC RID: 23500
	private SpriteTextItem RoomInfoItem;

	// Token: 0x04005BCD RID: 23501
	private RewardInfoItem RewardItem;

	// Token: 0x04005BCE RID: 23502
	private DescItem DescItem;

	// Token: 0x04005BCF RID: 23503
	private TimerHandle RefreshTimer;

	// Token: 0x0200710F RID: 28943
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024D2D RID: 150829
		CaptionItem,
		// Token: 0x04024D2E RID: 150830
		CurrentLevelTitleItem,
		// Token: 0x04024D2F RID: 150831
		DeadInfoItem,
		// Token: 0x04024D30 RID: 150832
		RewardItem,
		// Token: 0x04024D31 RID: 150833
		TimeItem,
		// Token: 0x04024D32 RID: 150834
		RoomInfoItem,
		// Token: 0x04024D33 RID: 150835
		DescItem
	}
}

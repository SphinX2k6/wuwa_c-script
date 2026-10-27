using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001291 RID: 4753
[NullableContext(2)]
[Nullable(0)]
public class InviteNewbieSubView : ActivitySubViewBase
{
	// Token: 0x060081F2 RID: 33266 RVA: 0x001B8E34 File Offset: 0x001B7034
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
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickCopyInviteCodeButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060081F3 RID: 33267 RVA: 0x001B8F5E File Offset: 0x001B715E
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.InviteNewbieInviteCodeChanged, new Action<string>(this.HandleInviteNewbieInviteCodeChanged));
	}

	// Token: 0x060081F4 RID: 33268 RVA: 0x001B8F7C File Offset: 0x001B717C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.InviteNewbieInviteCodeChanged, new Action<string>(this.HandleInviteNewbieInviteCodeChanged));
	}

	// Token: 0x060081F5 RID: 33269 RVA: 0x001B8F9C File Offset: 0x001B719C
	protected override UniTask OnBeforeStartAsync()
	{
		InviteNewbieSubView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InviteNewbieSubView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060081F6 RID: 33270 RVA: 0x001B8FDF File Offset: 0x001B71DF
	private void OnClickCopyInviteCodeButton()
	{
		ActivityInviteNewbieController.Instance.HandleOnCopyInviteCodeClick();
	}

	// Token: 0x060081F7 RID: 33271 RVA: 0x001B8FEC File Offset: 0x001B71EC
	protected override void OnRefreshView()
	{
		InviteNewbieModel instance = InviteNewbieModel.Instance;
		this.RefreshTimeText();
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(instance.InviteCode, true);
		}
		this.RefreshCopyItemState();
	}

	// Token: 0x060081F8 RID: 33272 RVA: 0x001B9024 File Offset: 0x001B7224
	protected override void OnTimer(float delta)
	{
		this.RefreshTimeText();
	}

	// Token: 0x060081F9 RID: 33273 RVA: 0x001B902C File Offset: 0x001B722C
	private void RefreshTimeText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		InviteNewbieActivityItem activityItem = this.ActivityItem;
		if (activityItem == null)
		{
			return;
		}
		activityItem.RefreshTimerTextByData(item, item2);
	}

	// Token: 0x060081FA RID: 33274 RVA: 0x001B9060 File Offset: 0x001B7260
	private void RefreshCopyItemState()
	{
		string inviteCode = InviteNewbieModel.Instance.InviteCode;
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(!StringUtils.IsEmpty(inviteCode));
		}
	}

	// Token: 0x060081FB RID: 33275 RVA: 0x001B9092 File Offset: 0x001B7292
	[NullableContext(1)]
	private void HandleInviteNewbieInviteCodeChanged(string newCode)
	{
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetText(newCode ?? "", true);
	}

	// Token: 0x04003ACE RID: 15054
	private InviteNewbieActivityItem ActivityItem;

	// Token: 0x04003ACF RID: 15055
	private InviteNewbieRewardItem RewardItem;

	// Token: 0x04003AD0 RID: 15056
	private InviteNewbieBgItem BgItem;

	// Token: 0x020078A7 RID: 30887
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04027BFC RID: 162812
		public const int ActivityRootItem = 0;

		// Token: 0x04027BFD RID: 162813
		public const int RewardRootItem = 1;

		// Token: 0x04027BFE RID: 162814
		public const int CopyInviteCodeButton = 2;

		// Token: 0x04027BFF RID: 162815
		public const int InviteCodeText = 3;

		// Token: 0x04027C00 RID: 162816
		public const int ContentRootItem = 4;

		// Token: 0x04027C01 RID: 162817
		public const int CopyItem = 5;
	}
}

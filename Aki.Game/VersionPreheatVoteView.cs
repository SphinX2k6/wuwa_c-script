using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001578 RID: 5496
[NullableContext(1)]
[Nullable(0)]
public class VersionPreheatVoteView : UiViewBase
{
	// Token: 0x06009D26 RID: 40230 RVA: 0x00220905 File Offset: 0x0021EB05
	public VersionPreheatVoteView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06009D27 RID: 40231 RVA: 0x00220910 File Offset: 0x0021EB10
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.HandleOnClickExit));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009D28 RID: 40232 RVA: 0x00220AA0 File Offset: 0x0021ECA0
	protected override UniTask OnBeforeStartAsync()
	{
		VersionPreheatVoteView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VersionPreheatVoteView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009D29 RID: 40233 RVA: 0x00220AE3 File Offset: 0x0021ECE3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.VersionPreheatRewardResponse, new Action<int>(this.HandleVersionPreheatRewardResponse));
		EventSystem.Instance.Add<bool>(EEventName.VersionPreheatOnClickVote, new Action<bool>(this.HandleVersionPreheatOnClickVote));
	}

	// Token: 0x06009D2A RID: 40234 RVA: 0x00220B1D File Offset: 0x0021ED1D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.VersionPreheatRewardResponse, new <>f__AnonymousDelegate2<int>(this.HandleVersionPreheatRewardResponse));
		EventSystem.Instance.Remove(EEventName.VersionPreheatOnClickVote, new Action<bool>(this.HandleVersionPreheatOnClickVote));
	}

	// Token: 0x06009D2B RID: 40235 RVA: 0x00220B57 File Offset: 0x0021ED57
	private void HandleOnClickExit()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009D2C RID: 40236 RVA: 0x00220B60 File Offset: 0x0021ED60
	private void HandleVersionPreheatRewardResponse(int i = 0)
	{
		base.CloseMe(null);
	}

	// Token: 0x06009D2D RID: 40237 RVA: 0x00220B69 File Offset: 0x0021ED69
	private void HandleVersionPreheatOnClickVote(bool isLeft)
	{
		this.LeftToggle.RefreshToggle(isLeft);
		this.RightToggle.RefreshToggle(!isLeft);
	}

	// Token: 0x06009D2E RID: 40238 RVA: 0x00220B86 File Offset: 0x0021ED86
	private CommonItemSmallItemGrid GridProxyCreateFunction()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06009D2F RID: 40239 RVA: 0x00220B90 File Offset: 0x0021ED90
	public void RefreshExternal(VersionPreheatVoteData data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.TitleTextId, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.ContentTextId, Array.Empty<object>());
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(data.CrestIndex == 0);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetUIActive(data.CrestIndex == 1);
		}
		this.LeftToggle.RefreshExternal(data.LeftToggleData);
		this.RightToggle.RefreshExternal(data.RightToggleData);
		this.ItemLayout.RefreshByData(data.ItemListData, null, false);
		if (data.IsLeftChosen == null)
		{
			this.LeftToggle.RefreshToggleDirectly(false);
			this.RightToggle.RefreshToggleDirectly(false);
			return;
		}
		this.HandleVersionPreheatOnClickVote(data.IsLeftChosen.Value);
	}

	// Token: 0x040044F4 RID: 17652
	private VersionPreheatToggleItem LeftToggle;

	// Token: 0x040044F5 RID: 17653
	private VersionPreheatToggleItem RightToggle;

	// Token: 0x040044F6 RID: 17654
	private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

	// Token: 0x02007BA9 RID: 31657
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04028A7B RID: 166523
		public const int Crest1Item = 0;

		// Token: 0x04028A7C RID: 166524
		public const int Crest2Item = 1;

		// Token: 0x04028A7D RID: 166525
		public const int TitleText = 2;

		// Token: 0x04028A7E RID: 166526
		public const int ContentText = 3;

		// Token: 0x04028A7F RID: 166527
		public const int LeftToggleItem = 4;

		// Token: 0x04028A80 RID: 166528
		public const int RightToggleItem = 5;

		// Token: 0x04028A81 RID: 166529
		public const int ItemLayout = 6;

		// Token: 0x04028A82 RID: 166530
		public const int ItemTemplateItem = 7;

		// Token: 0x04028A83 RID: 166531
		public const int ExitButton = 8;
	}
}

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

// Token: 0x02000A30 RID: 2608
[NullableContext(1)]
[Nullable(0)]
public class VersionPreheatVoteView : UiViewBase
{
	// Token: 0x06007104 RID: 28932 RVA: 0x0022A6B5 File Offset: 0x002288B5
	public VersionPreheatVoteView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06007105 RID: 28933 RVA: 0x0022A6C0 File Offset: 0x002288C0
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

	// Token: 0x06007106 RID: 28934 RVA: 0x0022A850 File Offset: 0x00228A50
	protected override UniTask OnBeforeStartAsync()
	{
		VersionPreheatVoteView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VersionPreheatVoteView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007107 RID: 28935 RVA: 0x0022A893 File Offset: 0x00228A93
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.VersionPreheatRewardResponse, new Action<int>(this.HandleVersionPreheatRewardResponse));
		EventSystem.Instance.Add<bool>(EEventName.VersionPreheatOnClickVote, new Action<bool>(this.HandleVersionPreheatOnClickVote));
	}

	// Token: 0x06007108 RID: 28936 RVA: 0x0022A8CD File Offset: 0x00228ACD
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.VersionPreheatRewardResponse, new <>f__AnonymousDelegate2<int>(this.HandleVersionPreheatRewardResponse));
		EventSystem.Instance.Remove(EEventName.VersionPreheatOnClickVote, new Action<bool>(this.HandleVersionPreheatOnClickVote));
	}

	// Token: 0x06007109 RID: 28937 RVA: 0x0022A907 File Offset: 0x00228B07
	private void HandleOnClickExit()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600710A RID: 28938 RVA: 0x0022A910 File Offset: 0x00228B10
	private void HandleVersionPreheatRewardResponse(int i = 0)
	{
		base.CloseMe(null);
	}

	// Token: 0x0600710B RID: 28939 RVA: 0x0022A919 File Offset: 0x00228B19
	private void HandleVersionPreheatOnClickVote(bool isLeft)
	{
		this.LeftToggle.RefreshToggle(isLeft);
		this.RightToggle.RefreshToggle(!isLeft);
	}

	// Token: 0x0600710C RID: 28940 RVA: 0x0022A936 File Offset: 0x00228B36
	private CommonItemSmallItemGrid GridProxyCreateFunction()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600710D RID: 28941 RVA: 0x0022A940 File Offset: 0x00228B40
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

	// Token: 0x0400459A RID: 17818
	private VersionPreheatToggleItem LeftToggle;

	// Token: 0x0400459B RID: 17819
	private VersionPreheatToggleItem RightToggle;

	// Token: 0x0400459C RID: 17820
	private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

	// Token: 0x02006D34 RID: 27956
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04023DB6 RID: 146870
		public const int Crest1Item = 0;

		// Token: 0x04023DB7 RID: 146871
		public const int Crest2Item = 1;

		// Token: 0x04023DB8 RID: 146872
		public const int TitleText = 2;

		// Token: 0x04023DB9 RID: 146873
		public const int ContentText = 3;

		// Token: 0x04023DBA RID: 146874
		public const int LeftToggleItem = 4;

		// Token: 0x04023DBB RID: 146875
		public const int RightToggleItem = 5;

		// Token: 0x04023DBC RID: 146876
		public const int ItemLayout = 6;

		// Token: 0x04023DBD RID: 146877
		public const int ItemTemplateItem = 7;

		// Token: 0x04023DBE RID: 146878
		public const int ExitButton = 8;
	}
}

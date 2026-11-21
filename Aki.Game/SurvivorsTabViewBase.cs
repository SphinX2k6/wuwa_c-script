using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020AB RID: 8363
[NullableContext(1)]
[Nullable(0)]
public abstract class SurvivorsTabViewBase<TProxy, [Nullable(0)] TData> : UiTabViewBase where TProxy : class, IGridProxy<TData> where TData : ISurvivorsHandbookItemDataBase
{
	// Token: 0x06014954 RID: 84308
	protected abstract TProxy CreateLoopItem();

	// Token: 0x06014955 RID: 84309
	protected abstract IReadOnlyList<TData> GenerateItemUiDataList();

	// Token: 0x06014956 RID: 84310
	protected abstract int GetLoopItemIndex();

	// Token: 0x06014957 RID: 84311
	protected abstract int GetLoopScrollComponentIndex();

	// Token: 0x06014958 RID: 84312 RVA: 0x005FF9C9 File Offset: 0x005FDBC9
	protected virtual UniTask InitSubComponents()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06014959 RID: 84313
	protected abstract void OnSelectItem(TData data, bool isFromClick);

	// Token: 0x17001EF6 RID: 7926
	// (get) Token: 0x0601495A RID: 84314
	protected abstract ESurvivorsRogueItemType ItemType { get; }

	// Token: 0x0601495B RID: 84315 RVA: 0x005FF9D0 File Offset: 0x005FDBD0
	protected virtual void OnTriggerSequenceStartEvent()
	{
	}

	// Token: 0x0601495C RID: 84316 RVA: 0x005FF9D2 File Offset: 0x005FDBD2
	private void OnActivitySequenceEmitEvent(string name)
	{
		if (name == "Start")
		{
			this.OnTriggerSequenceStartEvent();
		}
	}

	// Token: 0x0601495D RID: 84317 RVA: 0x005FF9E7 File Offset: 0x005FDBE7
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0601495E RID: 84318 RVA: 0x005FFA05 File Offset: 0x005FDC05
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0601495F RID: 84319 RVA: 0x005FFA24 File Offset: 0x005FDC24
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsTabViewBase<TProxy, TData>.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsTabViewBase<TProxy, TData>.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014960 RID: 84320 RVA: 0x005FFA68 File Offset: 0x005FDC68
	protected override void OnShowUiTabViewFromToggle()
	{
		LoopScrollView<TProxy, TData> itemScroll = this.ItemScroll;
		if (itemScroll != null)
		{
			itemScroll.ResetGridController();
		}
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Start", false, null);
	}

	// Token: 0x06014961 RID: 84321 RVA: 0x005FFAA8 File Offset: 0x005FDCA8
	protected override void OnShowUiTabViewFromView()
	{
		LoopScrollView<TProxy, TData> itemScroll = this.ItemScroll;
		if (itemScroll != null)
		{
			itemScroll.ResetGridController();
		}
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Start", false, null);
	}

	// Token: 0x06014962 RID: 84322 RVA: 0x005FFAE8 File Offset: 0x005FDCE8
	private UniTask InitItemScroll()
	{
		SurvivorsTabViewBase<TProxy, TData>.<InitItemScroll>d__17 <InitItemScroll>d__;
		<InitItemScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitItemScroll>d__.<>4__this = this;
		<InitItemScroll>d__.<>1__state = -1;
		<InitItemScroll>d__.<>t__builder.Start<SurvivorsTabViewBase<TProxy, TData>.<InitItemScroll>d__17>(ref <InitItemScroll>d__);
		return <InitItemScroll>d__.<>t__builder.Task;
	}

	// Token: 0x06014963 RID: 84323 RVA: 0x005FFB2C File Offset: 0x005FDD2C
	[NullableContext(2)]
	protected bool OnCanClickItem(object data, bool isForceSelected, EToggleState state)
	{
		if (data == null)
		{
			return false;
		}
		TData tdata = (TData)((object)data);
		int id = tdata.Id;
		int? currentItemId = this.CurrentItemId;
		return !(id == currentItemId.GetValueOrDefault() & currentItemId != null);
	}

	// Token: 0x06014964 RID: 84324 RVA: 0x005FFB70 File Offset: 0x005FDD70
	protected void OnItemClick(TData data, TProxy itemGrid)
	{
		int id = data.Id;
		int? currentItemId = this.CurrentItemId;
		if (id == currentItemId.GetValueOrDefault() & currentItemId != null)
		{
			return;
		}
		int gridIndex = itemGrid.GridIndex;
		this.SelectItemByIndex(gridIndex, true);
	}

	// Token: 0x06014965 RID: 84325 RVA: 0x005FFBBC File Offset: 0x005FDDBC
	private void SelectItemByIndex(int gridIndex, bool isFromClick = true)
	{
		this.ItemScroll.SelectGridProxy(gridIndex, false);
		TData tdata = this.ItemScroll.TryGetCachedData(gridIndex);
		this.CurrentItemId = new int?(tdata.Id);
		if (tdata.IsNew.GetValueOrDefault())
		{
			SurvivorsRogueModel.Instance.SetItemClicked(this.ItemType, tdata.Id);
			ref TData ptr = ref tdata;
			if (default(TData) == null)
			{
				TData tdata2 = tdata;
				ptr = ref tdata2;
			}
			ptr.IsNew = new bool?(false);
			LoopScrollView<TProxy, TData> itemScroll = this.ItemScroll;
			if (itemScroll != null)
			{
				itemScroll.RefreshGridProxy(gridIndex);
			}
		}
		this.OnSelectItem(tdata, isFromClick);
	}

	// Token: 0x06014966 RID: 84326 RVA: 0x005FFC74 File Offset: 0x005FDE74
	private void RefreshTitle(IReadOnlyList<TData> uiDataList)
	{
		int num = 0;
		for (int i = 0; i < uiDataList.Count; i++)
		{
			TData tdata = uiDataList[i];
			if (tdata.LockState == null || !tdata.LockState.Value)
			{
				num++;
			}
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "WeaponEvolveTitle_UnlockedNum", new <>z__ReadOnlyArray<object>(new object[]
		{
			num.ToString(),
			uiDataList.Count.ToString()
		}));
	}

	// Token: 0x0400AEDB RID: 44763
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<TProxy, TData> ItemScroll;

	// Token: 0x0400AEDC RID: 44764
	protected int? CurrentItemId = new int?(-1);
}

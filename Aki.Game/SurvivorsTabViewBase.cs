using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B2F RID: 11055
[NullableContext(1)]
[Nullable(0)]
public abstract class SurvivorsTabViewBase<TProxy, [Nullable(0)] TData> : UiTabViewBase where TProxy : class, IGridProxy<TData> where TData : ISurvivorsHandbookItemDataBase
{
	// Token: 0x06016F23 RID: 93987
	protected abstract TProxy CreateLoopItem();

	// Token: 0x06016F24 RID: 93988
	protected abstract IReadOnlyList<TData> GenerateItemUiDataList();

	// Token: 0x06016F25 RID: 93989
	protected abstract int GetLoopItemIndex();

	// Token: 0x06016F26 RID: 93990
	protected abstract int GetLoopScrollComponentIndex();

	// Token: 0x06016F27 RID: 93991 RVA: 0x005D2E55 File Offset: 0x005D1055
	protected virtual UniTask InitSubComponents()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06016F28 RID: 93992
	protected abstract void OnSelectItem(TData data, bool isFromClick);

	// Token: 0x17001E9E RID: 7838
	// (get) Token: 0x06016F29 RID: 93993
	protected abstract ESurvivorsRogueItemType ItemType { get; }

	// Token: 0x06016F2A RID: 93994 RVA: 0x005D2E5C File Offset: 0x005D105C
	protected virtual void OnTriggerSequenceStartEvent()
	{
	}

	// Token: 0x06016F2B RID: 93995 RVA: 0x005D2E5E File Offset: 0x005D105E
	private void OnActivitySequenceEmitEvent(string name)
	{
		if (name == "Start")
		{
			this.OnTriggerSequenceStartEvent();
		}
	}

	// Token: 0x06016F2C RID: 93996 RVA: 0x005D2E73 File Offset: 0x005D1073
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06016F2D RID: 93997 RVA: 0x005D2E91 File Offset: 0x005D1091
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06016F2E RID: 93998 RVA: 0x005D2EB0 File Offset: 0x005D10B0
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsTabViewBase<TProxy, TData>.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsTabViewBase<TProxy, TData>.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016F2F RID: 93999 RVA: 0x005D2EF4 File Offset: 0x005D10F4
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

	// Token: 0x06016F30 RID: 94000 RVA: 0x005D2F34 File Offset: 0x005D1134
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

	// Token: 0x06016F31 RID: 94001 RVA: 0x005D2F74 File Offset: 0x005D1174
	private UniTask InitItemScroll()
	{
		SurvivorsTabViewBase<TProxy, TData>.<InitItemScroll>d__17 <InitItemScroll>d__;
		<InitItemScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitItemScroll>d__.<>4__this = this;
		<InitItemScroll>d__.<>1__state = -1;
		<InitItemScroll>d__.<>t__builder.Start<SurvivorsTabViewBase<TProxy, TData>.<InitItemScroll>d__17>(ref <InitItemScroll>d__);
		return <InitItemScroll>d__.<>t__builder.Task;
	}

	// Token: 0x06016F32 RID: 94002 RVA: 0x005D2FB8 File Offset: 0x005D11B8
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

	// Token: 0x06016F33 RID: 94003 RVA: 0x005D2FFC File Offset: 0x005D11FC
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

	// Token: 0x06016F34 RID: 94004 RVA: 0x005D3048 File Offset: 0x005D1248
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

	// Token: 0x06016F35 RID: 94005 RVA: 0x005D3100 File Offset: 0x005D1300
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

	// Token: 0x0400AAD5 RID: 43733
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<TProxy, TData> ItemScroll;

	// Token: 0x0400AAD6 RID: 43734
	protected int? CurrentItemId = new int?(-1);
}

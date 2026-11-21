using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B95 RID: 2965
[NullableContext(1)]
[Nullable(0)]
public class AdviceView : UiViewBase
{
	// Token: 0x06007B8F RID: 31631 RVA: 0x0026488D File Offset: 0x00262A8D
	public AdviceView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06007B90 RID: 31632 RVA: 0x00264898 File Offset: 0x00262A98
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x06007B91 RID: 31633 RVA: 0x00264908 File Offset: 0x00262B08
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollView<AdviceItem>(base.GetScrollViewWithScrollbar(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AdviceItem>(this.InitItem), null);
	}

	// Token: 0x06007B92 RID: 31634 RVA: 0x00264929 File Offset: 0x00262B29
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnDeleteAdviceSuccess, new Action(this.RefreshScrollerView));
		EventSystem.Instance.Add(EEventName.OnCreateAdviceSuccess, new Action(this.RefreshScrollerView));
	}

	// Token: 0x06007B93 RID: 31635 RVA: 0x00264963 File Offset: 0x00262B63
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnDeleteAdviceSuccess, new Action(this.RefreshScrollerView));
		EventSystem.Instance.Remove(EEventName.OnCreateAdviceSuccess, new Action(this.RefreshScrollerView));
	}

	// Token: 0x06007B94 RID: 31636 RVA: 0x0026499D File Offset: 0x00262B9D
	private void RefreshScrollerView()
	{
		this.RefreshScorller();
		this.RefreshShowItem();
		this.RefreshProgressText();
	}

	// Token: 0x06007B95 RID: 31637 RVA: 0x002649B4 File Offset: 0x00262BB4
	private ILayoutItem<AdviceItem> InitItem(object data, UUIItem uiItem, int index)
	{
		AdviceItem adviceItem = new AdviceItem(uiItem);
		adviceItem.Update((AdviceData)data);
		return new LayoutItem<AdviceItem>
		{
			Key = index,
			Value = adviceItem
		};
	}

	// Token: 0x06007B96 RID: 31638 RVA: 0x002649EC File Offset: 0x00262BEC
	protected override void OnAfterShow()
	{
		this.RefreshScorller();
		this.RefreshShowItem();
		this.RefreshProgressText();
	}

	// Token: 0x06007B97 RID: 31639 RVA: 0x00264A00 File Offset: 0x00262C00
	private void RefreshScorller()
	{
		AdviceData[] adviceArray = AdviceModel.Instance.GetAdviceArray();
		this.AdviceDataArray = new List<AdviceData>();
		if (adviceArray != null)
		{
			List<AdviceData> list = new List<AdviceData>();
			for (int i = adviceArray.Length - 1; i >= 0; i--)
			{
				list.Add(adviceArray[i]);
			}
			this.AdviceDataArray = list;
		}
		this.ScrollView.RefreshByData<AdviceData>(this.AdviceDataArray, null);
		this.ScrollView.UnBindLateUpdate();
		this.ScrollToDirty = true;
		this.WaitingLateUpdateFlag = 0;
		this.ScrollView.BindLateUpdate(new Action<float>(this.LateUpdate));
	}

	// Token: 0x06007B98 RID: 31640 RVA: 0x00264A98 File Offset: 0x00262C98
	private void RefreshProgressText()
	{
		AdviceData[] adviceArray = AdviceModel.Instance.GetAdviceArray();
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("AdviceCreateLimit").GetValueOrDefault();
		LguiUtil.Instance.SetLocalText(base.GetText(3), "ReputationNormalValue", new <>z__ReadOnlyArray<object>(new object[]
		{
			(adviceArray != null) ? adviceArray.Length : 0,
			valueOrDefault
		}));
	}

	// Token: 0x06007B99 RID: 31641 RVA: 0x00264B00 File Offset: 0x00262D00
	private void LateUpdate(float deltaTime)
	{
		if (this.ScrollToDirty && this.WaitingLateUpdateFlag >= 1)
		{
			this.ScrollToDirty = false;
			float progress = this.GetProgress(this.AdviceDataArray.ToArray());
			base.GetScrollViewWithScrollbar(1).SetScrollProgress(progress);
			this.ScrollView.UnBindLateUpdate();
		}
		this.WaitingLateUpdateFlag++;
	}

	// Token: 0x06007B9A RID: 31642 RVA: 0x00264B60 File Offset: 0x00262D60
	private float GetProgress(AdviceData[] dataArray)
	{
		int num = 0;
		long? adviceViewShowId = AdviceModel.Instance.AdviceViewShowId;
		for (int i = 0; i < dataArray.Length; i++)
		{
			if (adviceViewShowId != null)
			{
				long? adviceBigId = dataArray[i].GetAdviceBigId();
				long? num2 = adviceViewShowId;
				if (adviceBigId.GetValueOrDefault() == num2.GetValueOrDefault() & adviceBigId != null == (num2 != null))
				{
					num = i;
					break;
				}
			}
		}
		if (dataArray.Length > 1)
		{
			return (float)num / (float)(dataArray.Length - 1);
		}
		return 0f;
	}

	// Token: 0x06007B9B RID: 31643 RVA: 0x00264BDC File Offset: 0x00262DDC
	private void RefreshShowItem()
	{
		AdviceData[] adviceArray = AdviceModel.Instance.GetAdviceArray();
		bool flag = adviceArray == null || adviceArray.Length == 0;
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		if (scrollViewWithScrollbar == null)
		{
			return;
		}
		UUIItem rootComponent = scrollViewWithScrollbar.GetRootComponent();
		if (rootComponent == null)
		{
			return;
		}
		rootComponent.SetUIActive(!flag);
	}

	// Token: 0x06007B9C RID: 31644 RVA: 0x00264C32 File Offset: 0x00262E32
	protected override void OnBeforeDestroy()
	{
		GenericScrollView<AdviceItem> scrollView = this.ScrollView;
		if (scrollView == null)
		{
			return;
		}
		scrollView.ClearChildren();
	}

	// Token: 0x04004C3F RID: 19519
	private const int WAITUPDATECOUNT = 1;

	// Token: 0x04004C40 RID: 19520
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceItem> ScrollView;

	// Token: 0x04004C41 RID: 19521
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<AdviceData> AdviceDataArray;

	// Token: 0x04004C42 RID: 19522
	private bool ScrollToDirty;

	// Token: 0x04004C43 RID: 19523
	private int WaitingLateUpdateFlag;

	// Token: 0x02006E36 RID: 28214
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04024194 RID: 147860
		public const int ScorllerItem = 0;

		// Token: 0x04024195 RID: 147861
		public const int Scroller = 1;

		// Token: 0x04024196 RID: 147862
		public const int NullObject = 2;

		// Token: 0x04024197 RID: 147863
		public const int ProgressText = 3;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016DD RID: 5853
[NullableContext(1)]
[Nullable(0)]
public class AdviceView : UiViewBase
{
	// Token: 0x0600A7AF RID: 42927 RVA: 0x0025A485 File Offset: 0x00258685
	public AdviceView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A7B0 RID: 42928 RVA: 0x0025A490 File Offset: 0x00258690
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

	// Token: 0x0600A7B1 RID: 42929 RVA: 0x0025A500 File Offset: 0x00258700
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollView<AdviceItem>(base.GetScrollViewWithScrollbar(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AdviceItem>(this.InitItem), null);
	}

	// Token: 0x0600A7B2 RID: 42930 RVA: 0x0025A521 File Offset: 0x00258721
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnDeleteAdviceSuccess, new Action(this.RefreshScrollerView));
		EventSystem.Instance.Add(EEventName.OnCreateAdviceSuccess, new Action(this.RefreshScrollerView));
	}

	// Token: 0x0600A7B3 RID: 42931 RVA: 0x0025A55B File Offset: 0x0025875B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnDeleteAdviceSuccess, new Action(this.RefreshScrollerView));
		EventSystem.Instance.Remove(EEventName.OnCreateAdviceSuccess, new Action(this.RefreshScrollerView));
	}

	// Token: 0x0600A7B4 RID: 42932 RVA: 0x0025A595 File Offset: 0x00258795
	private void RefreshScrollerView()
	{
		this.RefreshScorller();
		this.RefreshShowItem();
		this.RefreshProgressText();
	}

	// Token: 0x0600A7B5 RID: 42933 RVA: 0x0025A5AC File Offset: 0x002587AC
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

	// Token: 0x0600A7B6 RID: 42934 RVA: 0x0025A5E4 File Offset: 0x002587E4
	protected override void OnAfterShow()
	{
		this.RefreshScorller();
		this.RefreshShowItem();
		this.RefreshProgressText();
	}

	// Token: 0x0600A7B7 RID: 42935 RVA: 0x0025A5F8 File Offset: 0x002587F8
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

	// Token: 0x0600A7B8 RID: 42936 RVA: 0x0025A690 File Offset: 0x00258890
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

	// Token: 0x0600A7B9 RID: 42937 RVA: 0x0025A6F8 File Offset: 0x002588F8
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

	// Token: 0x0600A7BA RID: 42938 RVA: 0x0025A758 File Offset: 0x00258958
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

	// Token: 0x0600A7BB RID: 42939 RVA: 0x0025A7D4 File Offset: 0x002589D4
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

	// Token: 0x0600A7BC RID: 42940 RVA: 0x0025A82A File Offset: 0x00258A2A
	protected override void OnBeforeDestroy()
	{
		GenericScrollView<AdviceItem> scrollView = this.ScrollView;
		if (scrollView == null)
		{
			return;
		}
		scrollView.ClearChildren();
	}

	// Token: 0x04004B98 RID: 19352
	private const int WAITUPDATECOUNT = 1;

	// Token: 0x04004B99 RID: 19353
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceItem> ScrollView;

	// Token: 0x04004B9A RID: 19354
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<AdviceData> AdviceDataArray;

	// Token: 0x04004B9B RID: 19355
	private bool ScrollToDirty;

	// Token: 0x04004B9C RID: 19356
	private int WaitingLateUpdateFlag;

	// Token: 0x02007CB1 RID: 31921
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04028E6B RID: 167531
		public const int ScorllerItem = 0;

		// Token: 0x04028E6C RID: 167532
		public const int Scroller = 1;

		// Token: 0x04028E6D RID: 167533
		public const int NullObject = 2;

		// Token: 0x04028E6E RID: 167534
		public const int ProgressText = 3;
	}
}

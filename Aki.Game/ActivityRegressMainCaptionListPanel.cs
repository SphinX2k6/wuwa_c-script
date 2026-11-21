using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000944 RID: 2372
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressMainCaptionListPanel : UiPanelBase
{
	// Token: 0x060068AE RID: 26798 RVA: 0x0020B972 File Offset: 0x00209B72
	public void Init(CommonTabComponentData<ActivityRegressTabItemPanel> data)
	{
		this.TabComponentData = data;
	}

	// Token: 0x060068AF RID: 26799 RVA: 0x0020B97C File Offset: 0x00209B7C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060068B0 RID: 26800 RVA: 0x0020BA08 File Offset: 0x00209C08
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressMainCaptionListPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressMainCaptionListPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060068B1 RID: 26801 RVA: 0x0020BA4B File Offset: 0x00209C4B
	public void BindTabTitleCallBack(Action callBack)
	{
		this.TabTitle.OnBackBtnCallBack = callBack;
	}

	// Token: 0x060068B2 RID: 26802 RVA: 0x0020BA5C File Offset: 0x00209C5C
	protected override void OnStart()
	{
		base.OnStart();
		this.ScrollView = base.GetScrollViewWithScrollbar(1);
		this.TabComponent = new TabComponent<ActivityRegressTabItemPanel>(this.ScrollView.Content.Get().GetUIItem(), new Func<UUIItem, int?, ActivityRegressTabItemPanel>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), null);
	}

	// Token: 0x060068B3 RID: 26803 RVA: 0x0020BAB8 File Offset: 0x00209CB8
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
		if (this.TabTitle != null)
		{
			this.TabTitle.Destroy(null);
			this.TabTitle = null;
		}
	}

	// Token: 0x060068B4 RID: 26804 RVA: 0x0020BAF8 File Offset: 0x00209CF8
	private void ToggleCallBack(int index)
	{
		CommonTabData commonTabData = this.TabComponentData.GetCommonData(index);
		if (commonTabData != null)
		{
			this.TabTitle.UpdateIcon(commonTabData.GetSmallIcon());
			this.TabTitle.UpdateTitle(commonTabData.GetTitleData());
		}
		this.TabComponentData.ToggleCallBack(index);
	}

	// Token: 0x060068B5 RID: 26805 RVA: 0x0020BB4D File Offset: 0x00209D4D
	private ActivityRegressTabItemPanel ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return this.TabComponentData.ProxyCreate(uiItem, new int?(index.GetValueOrDefault()));
	}

	// Token: 0x060068B6 RID: 26806 RVA: 0x0020BB6C File Offset: 0x00209D6C
	public UniTask RefreshTabItemByDataAsync(List<CommonTabItemData> array)
	{
		ActivityRegressMainCaptionListPanel.<RefreshTabItemByDataAsync>d__13 <RefreshTabItemByDataAsync>d__;
		<RefreshTabItemByDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabItemByDataAsync>d__.<>4__this = this;
		<RefreshTabItemByDataAsync>d__.array = array;
		<RefreshTabItemByDataAsync>d__.<>1__state = -1;
		<RefreshTabItemByDataAsync>d__.<>t__builder.Start<ActivityRegressMainCaptionListPanel.<RefreshTabItemByDataAsync>d__13>(ref <RefreshTabItemByDataAsync>d__);
		return <RefreshTabItemByDataAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060068B7 RID: 26807 RVA: 0x0020BBB7 File Offset: 0x00209DB7
	public void SelectToggleByIndex(int index, bool bIgnored = false, bool bFire = true)
	{
		this.TabComponent.SelectToggleByIndex(index, bIgnored, bFire);
	}

	// Token: 0x060068B8 RID: 26808 RVA: 0x0020BBC7 File Offset: 0x00209DC7
	public Dictionary<int, ActivityRegressTabItemPanel> GetTabItemMap()
	{
		return this.TabComponent.GetTabItemMap();
	}

	// Token: 0x060068B9 RID: 26809 RVA: 0x0020BBD4 File Offset: 0x00209DD4
	[NullableContext(2)]
	public CommonTabData GetTabComponentData(int index)
	{
		return this.TabComponentData.GetCommonData(index);
	}

	// Token: 0x060068BA RID: 26810 RVA: 0x0020BBE7 File Offset: 0x00209DE7
	public void SetPnlListUiActive(bool bActive)
	{
		base.GetItem(2).SetUIActive(bActive);
	}

	// Token: 0x060068BB RID: 26811 RVA: 0x0020BBF6 File Offset: 0x00209DF6
	public void UpdateTitle([Nullable(2)] string iconPath, CommonTabTitleData title)
	{
		if (!string.IsNullOrEmpty(iconPath))
		{
			this.TabTitle.UpdateIcon(iconPath);
		}
		if (title != null)
		{
			this.TabTitle.UpdateTitle(title);
		}
	}

	// Token: 0x060068BC RID: 26812 RVA: 0x0020BC1B File Offset: 0x00209E1B
	public void BindCanExecuteChange(Func<int, bool?, bool> canChange)
	{
		this.TabComponent.SetCanChange(canChange);
	}

	// Token: 0x04004292 RID: 17042
	[Nullable(2)]
	protected ActivityRegressMainTabTitlePanel TabTitle;

	// Token: 0x04004293 RID: 17043
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonTabComponentData<ActivityRegressTabItemPanel> TabComponentData;

	// Token: 0x04004294 RID: 17044
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<ActivityRegressTabItemPanel> TabComponent;

	// Token: 0x04004295 RID: 17045
	[Nullable(2)]
	private UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x02006C42 RID: 27714
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023942 RID: 145730
		public const int PnlCaption = 0;

		// Token: 0x04023943 RID: 145731
		public const int SvList = 1;

		// Token: 0x04023944 RID: 145732
		public const int PnlList = 2;
	}
}

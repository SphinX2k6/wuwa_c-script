using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001490 RID: 5264
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressMainCaptionListPanel : UiPanelBase
{
	// Token: 0x06009519 RID: 38169 RVA: 0x00202A0A File Offset: 0x00200C0A
	public void Init(CommonTabComponentData<ActivityRegressTabItemPanel> data)
	{
		this.TabComponentData = data;
	}

	// Token: 0x0600951A RID: 38170 RVA: 0x00202A14 File Offset: 0x00200C14
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

	// Token: 0x0600951B RID: 38171 RVA: 0x00202AA0 File Offset: 0x00200CA0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressMainCaptionListPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressMainCaptionListPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600951C RID: 38172 RVA: 0x00202AE3 File Offset: 0x00200CE3
	public void BindTabTitleCallBack(Action callBack)
	{
		this.TabTitle.OnBackBtnCallBack = callBack;
	}

	// Token: 0x0600951D RID: 38173 RVA: 0x00202AF4 File Offset: 0x00200CF4
	protected override void OnStart()
	{
		base.OnStart();
		this.ScrollView = base.GetScrollViewWithScrollbar(1);
		this.TabComponent = new TabComponent<ActivityRegressTabItemPanel>(this.ScrollView.Content.Get().GetUIItem(), new Func<UUIItem, int?, ActivityRegressTabItemPanel>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), null);
	}

	// Token: 0x0600951E RID: 38174 RVA: 0x00202B50 File Offset: 0x00200D50
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

	// Token: 0x0600951F RID: 38175 RVA: 0x00202B90 File Offset: 0x00200D90
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

	// Token: 0x06009520 RID: 38176 RVA: 0x00202BE5 File Offset: 0x00200DE5
	private ActivityRegressTabItemPanel ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return this.TabComponentData.ProxyCreate(uiItem, new int?(index.GetValueOrDefault()));
	}

	// Token: 0x06009521 RID: 38177 RVA: 0x00202C04 File Offset: 0x00200E04
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

	// Token: 0x06009522 RID: 38178 RVA: 0x00202C4F File Offset: 0x00200E4F
	public void SelectToggleByIndex(int index, bool bIgnored = false, bool bFire = true)
	{
		this.TabComponent.SelectToggleByIndex(index, bIgnored, bFire);
	}

	// Token: 0x06009523 RID: 38179 RVA: 0x00202C5F File Offset: 0x00200E5F
	public Dictionary<int, ActivityRegressTabItemPanel> GetTabItemMap()
	{
		return this.TabComponent.GetTabItemMap();
	}

	// Token: 0x06009524 RID: 38180 RVA: 0x00202C6C File Offset: 0x00200E6C
	[NullableContext(2)]
	public CommonTabData GetTabComponentData(int index)
	{
		return this.TabComponentData.GetCommonData(index);
	}

	// Token: 0x06009525 RID: 38181 RVA: 0x00202C7F File Offset: 0x00200E7F
	public void SetPnlListUiActive(bool bActive)
	{
		base.GetItem(2).SetUIActive(bActive);
	}

	// Token: 0x06009526 RID: 38182 RVA: 0x00202C8E File Offset: 0x00200E8E
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

	// Token: 0x06009527 RID: 38183 RVA: 0x00202CB3 File Offset: 0x00200EB3
	public void BindCanExecuteChange(Func<int, bool?, bool> canChange)
	{
		this.TabComponent.SetCanChange(canChange);
	}

	// Token: 0x040041FA RID: 16890
	[Nullable(2)]
	protected ActivityRegressMainTabTitlePanel TabTitle;

	// Token: 0x040041FB RID: 16891
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonTabComponentData<ActivityRegressTabItemPanel> TabComponentData;

	// Token: 0x040041FC RID: 16892
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<ActivityRegressTabItemPanel> TabComponent;

	// Token: 0x040041FD RID: 16893
	[Nullable(2)]
	private UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x02007ABE RID: 31422
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04028628 RID: 165416
		public const int PnlCaption = 0;

		// Token: 0x04028629 RID: 165417
		public const int SvList = 1;

		// Token: 0x0402862A RID: 165418
		public const int PnlList = 2;
	}
}

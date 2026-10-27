using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019B7 RID: 6583
[NullableContext(1)]
[Nullable(0)]
public class TabComponentWithTitle<[Nullable(0)] TTabItem> : UiPanelBase where TTabItem : CommonTabItemBase
{
	// Token: 0x0600C02F RID: 49199 RVA: 0x002B5652 File Offset: 0x002B3852
	public TabComponentWithTitle(UUIItem uiItem, CommonTabComponentData<TTabItem> data)
	{
		this.TabComponentData = data;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600C030 RID: 49200 RVA: 0x002B5670 File Offset: 0x002B3870
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C031 RID: 49201 RVA: 0x002B56DC File Offset: 0x002B38DC
	protected override void OnStart()
	{
		this.ScrollView = base.GetScrollViewWithScrollbar(1);
		this.TabComponent = new TabComponent<TTabItem>(this.ScrollView.Content.Get().GetUIItem(), new Func<UUIItem, int?, TTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), null);
		this.TabTitle = new CommonTabTitle(base.GetItem(0));
	}

	// Token: 0x0600C032 RID: 49202 RVA: 0x002B5744 File Offset: 0x002B3944
	protected override void OnBeforeDestroy()
	{
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

	// Token: 0x0600C033 RID: 49203 RVA: 0x002B577C File Offset: 0x002B397C
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

	// Token: 0x0600C034 RID: 49204 RVA: 0x002B57D1 File Offset: 0x002B39D1
	private TTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return this.TabComponentData.ProxyCreate(uiItem, new int?(index.GetValueOrDefault()));
	}

	// Token: 0x0600C035 RID: 49205 RVA: 0x002B57F0 File Offset: 0x002B39F0
	[NullableContext(2)]
	public void RefreshTabItem(int length, Action callBack = null)
	{
		List<CommonTabItemData> list = new List<CommonTabItemData>();
		for (int i = 0; i < length; i++)
		{
			list.Add(new CommonTabItemData
			{
				Index = i,
				Data = this.TabComponentData.GetCommonData(i)
			});
		}
		this.TabComponent.RefreshTabItem(list, callBack);
	}

	// Token: 0x0600C036 RID: 49206 RVA: 0x002B5848 File Offset: 0x002B3A48
	public UniTask RefreshTabItemAsync(int length)
	{
		TabComponentWithTitle<TTabItem>.<RefreshTabItemAsync>d__12 <RefreshTabItemAsync>d__;
		<RefreshTabItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabItemAsync>d__.<>4__this = this;
		<RefreshTabItemAsync>d__.length = length;
		<RefreshTabItemAsync>d__.<>1__state = -1;
		<RefreshTabItemAsync>d__.<>t__builder.Start<TabComponentWithTitle<TTabItem>.<RefreshTabItemAsync>d__12>(ref <RefreshTabItemAsync>d__);
		return <RefreshTabItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C037 RID: 49207 RVA: 0x002B5894 File Offset: 0x002B3A94
	public UniTask RefreshTabItemByDataAsync(List<CommonTabItemData> array)
	{
		TabComponentWithTitle<TTabItem>.<RefreshTabItemByDataAsync>d__13 <RefreshTabItemByDataAsync>d__;
		<RefreshTabItemByDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabItemByDataAsync>d__.<>4__this = this;
		<RefreshTabItemByDataAsync>d__.array = array;
		<RefreshTabItemByDataAsync>d__.<>1__state = -1;
		<RefreshTabItemByDataAsync>d__.<>t__builder.Start<TabComponentWithTitle<TTabItem>.<RefreshTabItemByDataAsync>d__13>(ref <RefreshTabItemByDataAsync>d__);
		return <RefreshTabItemByDataAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C038 RID: 49208 RVA: 0x002B58DF File Offset: 0x002B3ADF
	public void SelectToggleByIndex(int index, bool bIgnored = false)
	{
		this.TabComponent.SelectToggleByIndex(index, bIgnored, true);
	}

	// Token: 0x0600C039 RID: 49209 RVA: 0x002B58EF File Offset: 0x002B3AEF
	public int GetSelectedIndex()
	{
		return this.TabComponent.GetSelectedIndex();
	}

	// Token: 0x0600C03A RID: 49210 RVA: 0x002B58FC File Offset: 0x002B3AFC
	public void ScrollToToggleByIndex(int index)
	{
		TTabItem tabItem = this.TabComponent.GetTabItemByIndex(index);
		TTimerAction <>9__1;
		this.ScrollView.OnLateUpdate.Bind(delegate(float _)
		{
			TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
			TTimerAction action;
			if ((action = <>9__1) == null)
			{
				action = (<>9__1 = delegate(float __)
				{
					this.ScrollView.ScrollTo(tabItem.GetRootItem(), false);
				});
			}
			gameplayTimeInstance.Next(action, null, null);
			this.ScrollView.OnLateUpdate.Unbind();
		});
	}

	// Token: 0x0600C03B RID: 49211 RVA: 0x002B5944 File Offset: 0x002B3B44
	[NullableContext(2)]
	public TTabItem GetTabItemByIndex(int index)
	{
		return this.TabComponent.GetTabItemByIndex(index);
	}

	// Token: 0x0600C03C RID: 49212 RVA: 0x002B5952 File Offset: 0x002B3B52
	public Dictionary<int, TTabItem> GetTabItemMap()
	{
		return this.TabComponent.GetTabItemMap();
	}

	// Token: 0x0600C03D RID: 49213 RVA: 0x002B595F File Offset: 0x002B3B5F
	[NullableContext(2)]
	public CommonTabData GetTabComponentData(int index)
	{
		return this.TabComponentData.GetCommonData(index);
	}

	// Token: 0x0600C03E RID: 49214 RVA: 0x002B5974 File Offset: 0x002B3B74
	public void RefreshTitleByIndex(int index)
	{
		CommonTabData commonTabData = this.TabComponentData.GetCommonData(index);
		if (commonTabData != null)
		{
			this.TabTitle.UpdateTitle(commonTabData.GetTitleData());
		}
	}

	// Token: 0x0600C03F RID: 49215 RVA: 0x002B59A7 File Offset: 0x002B3BA7
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public TabComponent<TTabItem> GetTabComponent()
	{
		return this.TabComponent;
	}

	// Token: 0x0600C040 RID: 49216 RVA: 0x002B59B0 File Offset: 0x002B3BB0
	public void SetCanChange(Func<int, bool> callback)
	{
		this.TabComponent.SetCanChange((int index, bool? forceSwitch) => callback(index));
	}

	// Token: 0x0400565B RID: 22107
	[Nullable(2)]
	protected CommonTabTitle TabTitle;

	// Token: 0x0400565C RID: 22108
	private readonly CommonTabComponentData<TTabItem> TabComponentData;

	// Token: 0x0400565D RID: 22109
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<TTabItem> TabComponent;

	// Token: 0x0400565E RID: 22110
	[Nullable(2)]
	private UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x02007EE2 RID: 32482
	[NullableContext(0)]
	private class ETabComponentWithTitle
	{
		// Token: 0x0402975C RID: 169820
		public const int Title = 0;

		// Token: 0x0402975D RID: 169821
		public const int ScrollView = 1;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000E75 RID: 3701
[NullableContext(1)]
[Nullable(0)]
public class TabComponentWithTitle<[Nullable(0)] TTabItem> : UiPanelBase where TTabItem : CommonTabItemBase
{
	// Token: 0x06009439 RID: 37945 RVA: 0x002C05E2 File Offset: 0x002BE7E2
	public TabComponentWithTitle(UUIItem uiItem, CommonTabComponentData<TTabItem> data)
	{
		this.TabComponentData = data;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600943A RID: 37946 RVA: 0x002C0600 File Offset: 0x002BE800
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

	// Token: 0x0600943B RID: 37947 RVA: 0x002C066C File Offset: 0x002BE86C
	protected override void OnStart()
	{
		this.ScrollView = base.GetScrollViewWithScrollbar(1);
		this.TabComponent = new TabComponent<TTabItem>(this.ScrollView.Content.Get().GetUIItem(), new Func<UUIItem, int?, TTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), null);
		this.TabTitle = new CommonTabTitle(base.GetItem(0));
	}

	// Token: 0x0600943C RID: 37948 RVA: 0x002C06D4 File Offset: 0x002BE8D4
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

	// Token: 0x0600943D RID: 37949 RVA: 0x002C070C File Offset: 0x002BE90C
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

	// Token: 0x0600943E RID: 37950 RVA: 0x002C0761 File Offset: 0x002BE961
	private TTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return this.TabComponentData.ProxyCreate(uiItem, new int?(index.GetValueOrDefault()));
	}

	// Token: 0x0600943F RID: 37951 RVA: 0x002C0780 File Offset: 0x002BE980
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

	// Token: 0x06009440 RID: 37952 RVA: 0x002C07D8 File Offset: 0x002BE9D8
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

	// Token: 0x06009441 RID: 37953 RVA: 0x002C0824 File Offset: 0x002BEA24
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

	// Token: 0x06009442 RID: 37954 RVA: 0x002C086F File Offset: 0x002BEA6F
	public void SelectToggleByIndex(int index, bool bIgnored = false)
	{
		this.TabComponent.SelectToggleByIndex(index, bIgnored, true);
	}

	// Token: 0x06009443 RID: 37955 RVA: 0x002C087F File Offset: 0x002BEA7F
	public int GetSelectedIndex()
	{
		return this.TabComponent.GetSelectedIndex();
	}

	// Token: 0x06009444 RID: 37956 RVA: 0x002C088C File Offset: 0x002BEA8C
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

	// Token: 0x06009445 RID: 37957 RVA: 0x002C08D4 File Offset: 0x002BEAD4
	[NullableContext(2)]
	public TTabItem GetTabItemByIndex(int index)
	{
		return this.TabComponent.GetTabItemByIndex(index);
	}

	// Token: 0x06009446 RID: 37958 RVA: 0x002C08E2 File Offset: 0x002BEAE2
	public Dictionary<int, TTabItem> GetTabItemMap()
	{
		return this.TabComponent.GetTabItemMap();
	}

	// Token: 0x06009447 RID: 37959 RVA: 0x002C08EF File Offset: 0x002BEAEF
	[NullableContext(2)]
	public CommonTabData GetTabComponentData(int index)
	{
		return this.TabComponentData.GetCommonData(index);
	}

	// Token: 0x06009448 RID: 37960 RVA: 0x002C0904 File Offset: 0x002BEB04
	public void RefreshTitleByIndex(int index)
	{
		CommonTabData commonTabData = this.TabComponentData.GetCommonData(index);
		if (commonTabData != null)
		{
			this.TabTitle.UpdateTitle(commonTabData.GetTitleData());
		}
	}

	// Token: 0x06009449 RID: 37961 RVA: 0x002C0937 File Offset: 0x002BEB37
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public TabComponent<TTabItem> GetTabComponent()
	{
		return this.TabComponent;
	}

	// Token: 0x0600944A RID: 37962 RVA: 0x002C0940 File Offset: 0x002BEB40
	public void SetCanChange(Func<int, bool> callback)
	{
		this.TabComponent.SetCanChange((int index, bool? forceSwitch) => callback(index));
	}

	// Token: 0x0400570D RID: 22285
	[Nullable(2)]
	protected CommonTabTitle TabTitle;

	// Token: 0x0400570E RID: 22286
	private readonly CommonTabComponentData<TTabItem> TabComponentData;

	// Token: 0x0400570F RID: 22287
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<TTabItem> TabComponent;

	// Token: 0x04005710 RID: 22288
	[Nullable(2)]
	private UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x02007071 RID: 28785
	[NullableContext(0)]
	private class ETabComponentWithTitle
	{
		// Token: 0x04024A99 RID: 150169
		public const int Title = 0;

		// Token: 0x04024A9A RID: 150170
		public const int ScrollView = 1;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001DE3 RID: 7651
[NullableContext(1)]
[Nullable(0)]
public class GeographyHandBookView : UiViewBase
{
	// Token: 0x0600E8D1 RID: 59601 RVA: 0x00371D10 File Offset: 0x0036FF10
	public GeographyHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.GeographyTypeList = new List<GeographyType>();
		this.GeographyHandBookItemList = new List<GeographyHandBookItem>();
	}

	// Token: 0x0600E8D2 RID: 59602 RVA: 0x00371D30 File Offset: 0x0036FF30
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent))
		};
	}

	// Token: 0x0600E8D3 RID: 59603 RVA: 0x00371DA0 File Offset: 0x0036FFA0
	protected override void OnStart()
	{
		this.InitVerticalLayout();
	}

	// Token: 0x0600E8D4 RID: 59604 RVA: 0x00371DA8 File Offset: 0x0036FFA8
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600E8D5 RID: 59605 RVA: 0x00371DB0 File Offset: 0x0036FFB0
	protected void Refresh()
	{
		this.RefreshVerticalLayout();
		this.RefreshCollectText();
	}

	// Token: 0x0600E8D6 RID: 59606 RVA: 0x00371DC0 File Offset: 0x0036FFC0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
		EventSystem.Instance.Add(EEventName.OnPhotoSelect, new Action<int>(this.OnGeographyPhotoSelect));
	}

	// Token: 0x0600E8D7 RID: 59607 RVA: 0x00371E40 File Offset: 0x00370040
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
		EventSystem.Instance.Remove(EEventName.OnPhotoSelect, new Action<int>(this.OnGeographyPhotoSelect));
	}

	// Token: 0x0600E8D8 RID: 59608 RVA: 0x00371EC0 File Offset: 0x003700C0
	protected override UniTask OnBeforeStartAsync()
	{
		GeographyHandBookView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GeographyHandBookView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E8D9 RID: 59609 RVA: 0x00371F03 File Offset: 0x00370103
	private void InitTabData()
	{
		this.TabDataList = ConfigGeographyTabTypeAll.GetConfigList(true);
	}

	// Token: 0x0600E8DA RID: 59610 RVA: 0x00371F14 File Offset: 0x00370114
	private void InitSelectedTabIndex()
	{
		List<GeographyType> list = ConfigCommon.ToList<GeographyType>(HandBookConfig.Instance.GetGeographyTypeConfigList());
		if (list == null)
		{
			return;
		}
		list.Sort(new Comparison<GeographyType>(this.SortIndex));
		this.GeographyTypeList = list;
		IGeographyHandBookViewParam geographyHandBookViewParam = this.OpenParam as IGeographyHandBookViewParam;
		if (geographyHandBookViewParam != null && geographyHandBookViewParam.SelectedId > 0)
		{
			GeographyHandBook? config = HandBookConfig.Instance.GetGeographyHandBookConfig(geographyHandBookViewParam.SelectedId);
			if (config != null)
			{
				this.SelectedId = geographyHandBookViewParam.SelectedId;
				this.CurSelectTabIndex = this.TabDataList.ToList<GeographyTabType>().FindIndex((GeographyTabType tab) => tab.Id == config.Value.GeographyTabType);
			}
		}
	}

	// Token: 0x0600E8DB RID: 59611 RVA: 0x00371FC0 File Offset: 0x003701C0
	protected override void OnBeforeShow()
	{
		this.RefreshToggleState();
		this.TabComponent.SelectToggleByIndex(this.CurSelectTabIndex, false);
		if (this.SelectedId > 0)
		{
			GeographyHandBook? config = HandBookConfig.Instance.GetGeographyHandBookConfig(this.SelectedId);
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.TryScrollToHandBookItem(config.Value, true);
				this.SelectedId = 0;
			}, null, null);
		}
	}

	// Token: 0x0600E8DC RID: 59612 RVA: 0x0037202C File Offset: 0x0037022C
	private void RefreshToggleState()
	{
		bool flag = true;
		foreach (GeographyHandBookItem geographyHandBookItem in this.GenericLayout.GetLayoutItemList())
		{
			foreach (GeographyHandBookChildItem geographyHandBookChildItem in geographyHandBookItem.GetChildItemList())
			{
				UUIExtendToggle tog = geographyHandBookChildItem.GetTog();
				if (flag && geographyHandBookChildItem.GetIsUnlock())
				{
					tog.SetToggleStateForce(EToggleState.ETT_Checked, false, true, false);
					flag = false;
				}
				else
				{
					tog.SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
				}
			}
		}
	}

	// Token: 0x0600E8DD RID: 59613 RVA: 0x003720E8 File Offset: 0x003702E8
	protected UniTask InitCommonTabTitle()
	{
		GeographyHandBookView.<InitCommonTabTitle>d__22 <InitCommonTabTitle>d__;
		<InitCommonTabTitle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCommonTabTitle>d__.<>4__this = this;
		<InitCommonTabTitle>d__.<>1__state = -1;
		<InitCommonTabTitle>d__.<>t__builder.Start<GeographyHandBookView.<InitCommonTabTitle>d__22>(ref <InitCommonTabTitle>d__);
		return <InitCommonTabTitle>d__.<>t__builder.Task;
	}

	// Token: 0x0600E8DE RID: 59614 RVA: 0x0037212B File Offset: 0x0037032B
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600E8DF RID: 59615 RVA: 0x00372134 File Offset: 0x00370334
	[NullableContext(2)]
	private CommonTabData GetCommonData(int index)
	{
		GeographyTabType geographyTabType = this.TabDataList[index];
		return new CommonTabData(geographyTabType.Icon, new CommonTabTitleData(geographyTabType.TypeName, Array.Empty<object>()), null);
	}

	// Token: 0x0600E8E0 RID: 59616 RVA: 0x0037216C File Offset: 0x0037036C
	private void ToggleCallBack(int index)
	{
		this.LastClickTime = new double?(Time.Instance.Now);
		this.CurSelectTabIndex = index;
		this.Refresh();
	}

	// Token: 0x0600E8E1 RID: 59617 RVA: 0x00372190 File Offset: 0x00370390
	protected bool CanToggleChange()
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		if (this.LastClickTime != null)
		{
			double? num = Time.Instance.Now - this.LastClickTime;
			int? interval = this.Interval;
			double? num2 = (interval != null) ? new double?((double)interval.GetValueOrDefault()) : null;
			if (!(num.GetValueOrDefault() >= num2.GetValueOrDefault() & (num != null & num2 != null)))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600E8E2 RID: 59618 RVA: 0x00372243 File Offset: 0x00370443
	protected void InitVerticalLayout()
	{
		this.GenericLayout = new GenericLayout<GeographyHandBookItem, IGeographyHandBookItemData>(base.GetVerticalLayout(1), new Func<GeographyHandBookItem>(this.InitGeographyHandBookItem), null, false, true);
	}

	// Token: 0x0600E8E3 RID: 59619 RVA: 0x00372268 File Offset: 0x00370468
	protected void RefreshVerticalLayout()
	{
		List<IGeographyHandBookItemData> list = new List<IGeographyHandBookItemData>();
		GeographyTabType geographyTabType = this.TabDataList[this.CurSelectTabIndex];
		foreach (GeographyType type in this.GeographyTypeList)
		{
			IReadOnlyList<GeographyHandBook> configList = ConfigGeographyHandBookByTabTypeAndType.GetConfigList(geographyTabType.Id, type.Id, true);
			if (configList != null && configList.Count > 0)
			{
				GeographyHandBookItemData item = new GeographyHandBookItemData
				{
					TabType = this.TabDataList[this.CurSelectTabIndex],
					Type = type,
					HandBookList = (ConfigCommon.ToList<GeographyHandBook>(configList) ?? new List<GeographyHandBook>())
				};
				list.Add(item);
			}
		}
		this.GeographyHandBookItemList = new List<GeographyHandBookItem>();
		this.GenericLayout.RefreshByData(list, delegate
		{
			UUIItem itemByIndex = this.GenericLayout.GetItemByIndex(0);
			if (itemByIndex != null)
			{
				base.GetScrollViewWithScrollbar(3).ScrollTo(itemByIndex, false);
			}
			this.RefreshToggleState();
		}, false);
	}

	// Token: 0x0600E8E4 RID: 59620 RVA: 0x00372358 File Offset: 0x00370558
	private GeographyHandBookItem InitGeographyHandBookItem()
	{
		GeographyHandBookItem geographyHandBookItem = new GeographyHandBookItem();
		this.GeographyHandBookItemList.Add(geographyHandBookItem);
		return geographyHandBookItem;
	}

	// Token: 0x0600E8E5 RID: 59621 RVA: 0x00372378 File Offset: 0x00370578
	private int SortIndex(GeographyType a, GeographyType b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600E8E6 RID: 59622 RVA: 0x00372389 File Offset: 0x00370589
	private int SortGeographyHandBookIndex(GeographyHandBook a, GeographyHandBook b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600E8E7 RID: 59623 RVA: 0x0037239A File Offset: 0x0037059A
	private void OnClickCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.GeographyHandBookView, null);
	}

	// Token: 0x0600E8E8 RID: 59624 RVA: 0x003723AC File Offset: 0x003705AC
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Geography);
		LguiUtil.Instance.SetLocalText(base.GetText(2), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			collectProgress[0],
			collectProgress[1]
		}));
	}

	// Token: 0x0600E8E9 RID: 59625 RVA: 0x003723FC File Offset: 0x003705FC
	protected void OnHandBookRead(EHandBookTabType type, int id)
	{
		if (type != EHandBookTabType.Geography)
		{
			return;
		}
		List<GeographyHandBookItem> layoutItemList = this.GenericLayout.GetLayoutItemList();
		int count = layoutItemList.Count;
		for (int i = 0; i < count; i++)
		{
			List<GeographyHandBookChildItem> childItemList = layoutItemList[i].GetChildItemList();
			int count2 = childItemList.Count;
			for (int j = 0; j < count2; j++)
			{
				GeographyHandBookChildItem geographyHandBookChildItem = childItemList[j];
				if (((GeographyHandBook)geographyHandBookChildItem.GetData().Config).Id == id)
				{
					geographyHandBookChildItem.SetNewState(false);
					return;
				}
			}
		}
	}

	// Token: 0x0600E8EA RID: 59626 RVA: 0x00372484 File Offset: 0x00370684
	protected void OnGeographyPhotoSelect(int configId)
	{
		List<GeographyHandBook> list = ConfigCommon.ToList<GeographyHandBook>(HandBookConfig.Instance.GetAllGeographyHandBookConfig());
		if (list == null)
		{
			return;
		}
		list.Sort(new Comparison<GeographyHandBook>(this.SortGeographyHandBookIndex));
		int count = list.Count;
		GeographyHandBook? curSelectConfig = null;
		for (int i = 0; i < count; i++)
		{
			GeographyHandBook value = list[i];
			if (value.Id == configId)
			{
				curSelectConfig = new GeographyHandBook?(value);
				break;
			}
		}
		IReadOnlyList<GeographyTabType> tabDataList = this.TabDataList;
		this.CurSelectTabIndex = ((tabDataList != null) ? new int?(tabDataList.ToList<GeographyTabType>().FindIndex((GeographyTabType tab) => tab.Id == curSelectConfig.Value.GeographyTabType)) : null).GetValueOrDefault(-1);
		this.TabComponent.SelectToggleByIndex(this.CurSelectTabIndex, false);
		this.TryScrollToHandBookItem(curSelectConfig.Value, false);
	}

	// Token: 0x0600E8EB RID: 59627 RVA: 0x00372568 File Offset: 0x00370768
	private void TryScrollToHandBookItem(GeographyHandBook itemConfig, bool toggleItem = false)
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(3);
		List<GeographyHandBookItem> layoutItemList = this.GenericLayout.GetLayoutItemList();
		int count = layoutItemList.Count;
		for (int i = 0; i < count; i++)
		{
			List<GeographyHandBookChildItem> childItemList = layoutItemList[i].GetChildItemList();
			int count2 = childItemList.Count;
			for (int j = 0; j < count2; j++)
			{
				GeographyHandBookChildItem geographyHandBookChildItem = childItemList[j];
				GeographyHandBook geographyHandBook = (GeographyHandBook)geographyHandBookChildItem.GetData().Config;
				if (geographyHandBook.Id == itemConfig.Id && geographyHandBook.Type == itemConfig.Type)
				{
					geographyHandBookChildItem.SetToggleState(EToggleState.ETT_Checked);
					scrollViewWithScrollbar.ScrollTo(geographyHandBookChildItem.GetRootItem(), false);
					if (toggleItem)
					{
						geographyHandBookChildItem.ToggleClick();
					}
				}
				else
				{
					geographyHandBookChildItem.SetToggleState(EToggleState.ETT_UnChecked);
				}
			}
		}
	}

	// Token: 0x0600E8EC RID: 59628 RVA: 0x00372632 File Offset: 0x00370832
	protected override void OnBeforeDestroy()
	{
		this.RoleRootUiCameraHandleData = null;
		if (this.GenericLayout != null)
		{
			this.GenericLayout.ClearChildren();
			this.GenericLayout = null;
		}
		this.GeographyTypeList = new List<GeographyType>();
		this.GeographyHandBookItemList = new List<GeographyHandBookItem>();
	}

	// Token: 0x04006BD2 RID: 27602
	[Nullable(2)]
	private IReadOnlyList<GeographyTabType> TabDataList;

	// Token: 0x04006BD3 RID: 27603
	private double? LastClickTime;

	// Token: 0x04006BD4 RID: 27604
	private int? Interval;

	// Token: 0x04006BD5 RID: 27605
	private int CurSelectTabIndex;

	// Token: 0x04006BD6 RID: 27606
	private int SelectedId;

	// Token: 0x04006BD7 RID: 27607
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x04006BD8 RID: 27608
	[Nullable(2)]
	protected UiCameraHandleData RoleRootUiCameraHandleData;

	// Token: 0x04006BD9 RID: 27609
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<GeographyHandBookItem, IGeographyHandBookItemData> GenericLayout;

	// Token: 0x04006BDA RID: 27610
	private List<GeographyType> GeographyTypeList;

	// Token: 0x04006BDB RID: 27611
	private List<GeographyHandBookItem> GeographyHandBookItemList;
}

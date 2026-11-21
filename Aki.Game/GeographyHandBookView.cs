using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012A5 RID: 4773
[NullableContext(1)]
[Nullable(0)]
public class GeographyHandBookView : UiViewBase
{
	// Token: 0x0600BCF0 RID: 48368 RVA: 0x0037D9FC File Offset: 0x0037BBFC
	public GeographyHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.GeographyTypeList = new List<GeographyType>();
		this.GeographyHandBookItemList = new List<GeographyHandBookItem>();
	}

	// Token: 0x0600BCF1 RID: 48369 RVA: 0x0037DA1C File Offset: 0x0037BC1C
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

	// Token: 0x0600BCF2 RID: 48370 RVA: 0x0037DA8C File Offset: 0x0037BC8C
	protected override void OnStart()
	{
		this.InitVerticalLayout();
	}

	// Token: 0x0600BCF3 RID: 48371 RVA: 0x0037DA94 File Offset: 0x0037BC94
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600BCF4 RID: 48372 RVA: 0x0037DA9C File Offset: 0x0037BC9C
	protected void Refresh()
	{
		this.RefreshVerticalLayout();
		this.RefreshCollectText();
	}

	// Token: 0x0600BCF5 RID: 48373 RVA: 0x0037DAAC File Offset: 0x0037BCAC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
		EventSystem.Instance.Add(EEventName.OnPhotoSelect, new Action<int>(this.OnGeographyPhotoSelect));
	}

	// Token: 0x0600BCF6 RID: 48374 RVA: 0x0037DB2C File Offset: 0x0037BD2C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
		EventSystem.Instance.Remove(EEventName.OnPhotoSelect, new Action<int>(this.OnGeographyPhotoSelect));
	}

	// Token: 0x0600BCF7 RID: 48375 RVA: 0x0037DBAC File Offset: 0x0037BDAC
	protected override UniTask OnBeforeStartAsync()
	{
		GeographyHandBookView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GeographyHandBookView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BCF8 RID: 48376 RVA: 0x0037DBEF File Offset: 0x0037BDEF
	private void InitTabData()
	{
		this.TabDataList = ConfigGeographyTabTypeAll.GetConfigList(true);
	}

	// Token: 0x0600BCF9 RID: 48377 RVA: 0x0037DC00 File Offset: 0x0037BE00
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
			GeographyHandBook? geographyHandBookConfig = HandBookConfig.Instance.GetGeographyHandBookConfig(geographyHandBookViewParam.SelectedId);
			if (geographyHandBookConfig != null)
			{
				this.SelectedId = geographyHandBookViewParam.SelectedId;
				this.CurSelectTabIndex = -1;
				for (int i = 0; i < this.TabDataList.Count; i++)
				{
					if (this.TabDataList[i].Id == geographyHandBookConfig.Value.GeographyTabType)
					{
						this.CurSelectTabIndex = i;
						return;
					}
				}
			}
		}
	}

	// Token: 0x0600BCFA RID: 48378 RVA: 0x0037DCC4 File Offset: 0x0037BEC4
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

	// Token: 0x0600BCFB RID: 48379 RVA: 0x0037DD30 File Offset: 0x0037BF30
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

	// Token: 0x0600BCFC RID: 48380 RVA: 0x0037DDEC File Offset: 0x0037BFEC
	protected UniTask InitCommonTabTitle()
	{
		GeographyHandBookView.<InitCommonTabTitle>d__22 <InitCommonTabTitle>d__;
		<InitCommonTabTitle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCommonTabTitle>d__.<>4__this = this;
		<InitCommonTabTitle>d__.<>1__state = -1;
		<InitCommonTabTitle>d__.<>t__builder.Start<GeographyHandBookView.<InitCommonTabTitle>d__22>(ref <InitCommonTabTitle>d__);
		return <InitCommonTabTitle>d__.<>t__builder.Task;
	}

	// Token: 0x0600BCFD RID: 48381 RVA: 0x0037DE2F File Offset: 0x0037C02F
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600BCFE RID: 48382 RVA: 0x0037DE38 File Offset: 0x0037C038
	[NullableContext(2)]
	private CommonTabData GetCommonData(int index)
	{
		GeographyTabType geographyTabType = this.TabDataList[index];
		return new CommonTabData(geographyTabType.Icon, new CommonTabTitleData(geographyTabType.TypeName, Array.Empty<object>()), null);
	}

	// Token: 0x0600BCFF RID: 48383 RVA: 0x0037DE70 File Offset: 0x0037C070
	private void ToggleCallBack(int index)
	{
		this.LastClickTime = new double?(Time.Instance.Now);
		this.CurSelectTabIndex = index;
		this.Refresh();
	}

	// Token: 0x0600BD00 RID: 48384 RVA: 0x0037DE94 File Offset: 0x0037C094
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

	// Token: 0x0600BD01 RID: 48385 RVA: 0x0037DF47 File Offset: 0x0037C147
	protected void InitVerticalLayout()
	{
		this.GenericLayout = new GenericLayout<GeographyHandBookItem, IGeographyHandBookItemData>(base.GetVerticalLayout(1), new Func<GeographyHandBookItem>(this.InitGeographyHandBookItem), null, false, true);
	}

	// Token: 0x0600BD02 RID: 48386 RVA: 0x0037DF6C File Offset: 0x0037C16C
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

	// Token: 0x0600BD03 RID: 48387 RVA: 0x0037E05C File Offset: 0x0037C25C
	private GeographyHandBookItem InitGeographyHandBookItem()
	{
		GeographyHandBookItem geographyHandBookItem = new GeographyHandBookItem();
		this.GeographyHandBookItemList.Add(geographyHandBookItem);
		return geographyHandBookItem;
	}

	// Token: 0x0600BD04 RID: 48388 RVA: 0x0037E07C File Offset: 0x0037C27C
	private int SortIndex(GeographyType a, GeographyType b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600BD05 RID: 48389 RVA: 0x0037E08D File Offset: 0x0037C28D
	private int SortGeographyHandBookIndex(GeographyHandBook a, GeographyHandBook b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600BD06 RID: 48390 RVA: 0x0037E09E File Offset: 0x0037C29E
	private void OnClickCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.GeographyHandBookView, null);
	}

	// Token: 0x0600BD07 RID: 48391 RVA: 0x0037E0B0 File Offset: 0x0037C2B0
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Geography);
		LguiUtil.Instance.SetLocalText(base.GetText(2), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			collectProgress[0],
			collectProgress[1]
		}));
	}

	// Token: 0x0600BD08 RID: 48392 RVA: 0x0037E100 File Offset: 0x0037C300
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

	// Token: 0x0600BD09 RID: 48393 RVA: 0x0037E188 File Offset: 0x0037C388
	protected void OnGeographyPhotoSelect(int configId)
	{
		List<GeographyHandBook> list = ConfigCommon.ToList<GeographyHandBook>(HandBookConfig.Instance.GetAllGeographyHandBookConfig());
		if (list == null)
		{
			return;
		}
		list.Sort(new Comparison<GeographyHandBook>(this.SortGeographyHandBookIndex));
		int count = list.Count;
		GeographyHandBook? geographyHandBook = null;
		for (int i = 0; i < count; i++)
		{
			GeographyHandBook value = list[i];
			if (value.Id == configId)
			{
				geographyHandBook = new GeographyHandBook?(value);
				break;
			}
		}
		this.CurSelectTabIndex = -1;
		if (this.TabDataList != null)
		{
			for (int j = 0; j < this.TabDataList.Count; j++)
			{
				if (this.TabDataList[j].Id == geographyHandBook.Value.GeographyTabType)
				{
					this.CurSelectTabIndex = j;
					break;
				}
			}
		}
		this.TabComponent.SelectToggleByIndex(this.CurSelectTabIndex, false);
		this.TryScrollToHandBookItem(geographyHandBook.Value, false);
	}

	// Token: 0x0600BD0A RID: 48394 RVA: 0x0037E270 File Offset: 0x0037C470
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

	// Token: 0x0600BD0B RID: 48395 RVA: 0x0037E33A File Offset: 0x0037C53A
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

	// Token: 0x04006CB3 RID: 27827
	[Nullable(2)]
	private IReadOnlyList<GeographyTabType> TabDataList;

	// Token: 0x04006CB4 RID: 27828
	private double? LastClickTime;

	// Token: 0x04006CB5 RID: 27829
	private int? Interval;

	// Token: 0x04006CB6 RID: 27830
	private int CurSelectTabIndex;

	// Token: 0x04006CB7 RID: 27831
	private int SelectedId;

	// Token: 0x04006CB8 RID: 27832
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x04006CB9 RID: 27833
	[Nullable(2)]
	protected UiCameraHandleData RoleRootUiCameraHandleData;

	// Token: 0x04006CBA RID: 27834
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<GeographyHandBookItem, IGeographyHandBookItemData> GenericLayout;

	// Token: 0x04006CBB RID: 27835
	private List<GeographyType> GeographyTypeList;

	// Token: 0x04006CBC RID: 27836
	private List<GeographyHandBookItem> GeographyHandBookItemList;
}

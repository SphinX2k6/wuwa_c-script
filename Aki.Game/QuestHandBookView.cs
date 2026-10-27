using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E43 RID: 7747
[NullableContext(1)]
[Nullable(0)]
public class QuestHandBookView : UiViewBase
{
	// Token: 0x0600EB99 RID: 60313 RVA: 0x0037E981 File Offset: 0x0037CB81
	public QuestHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.PlotTypeList = new List<PlotType>();
	}

	// Token: 0x0600EB9A RID: 60314 RVA: 0x0037E998 File Offset: 0x0037CB98
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600EB9B RID: 60315 RVA: 0x0037E9F2 File Offset: 0x0037CBF2
	protected override void OnStart()
	{
		this.Refresh();
		this.InitCommonTabTitle();
	}

	// Token: 0x0600EB9C RID: 60316 RVA: 0x0037EA00 File Offset: 0x0037CC00
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600EB9D RID: 60317 RVA: 0x0037EA08 File Offset: 0x0037CC08
	protected void Refresh()
	{
		this.InitVerticalLayout();
		this.RefreshCollectText();
	}

	// Token: 0x0600EB9E RID: 60318 RVA: 0x0037EA18 File Offset: 0x0037CC18
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnPhotoSelect, new Action<int>(this.OnPhotoSelect));
	}

	// Token: 0x0600EB9F RID: 60319 RVA: 0x0037EA7C File Offset: 0x0037CC7C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnPhotoSelect, new Action<int>(this.OnPhotoSelect));
	}

	// Token: 0x0600EBA0 RID: 60320 RVA: 0x0037EADD File Offset: 0x0037CCDD
	protected override void OnAfterShow()
	{
	}

	// Token: 0x0600EBA1 RID: 60321 RVA: 0x0037EAE0 File Offset: 0x0037CCE0
	protected void InitCommonTabTitle()
	{
		HandBookEntrance? handBookEntranceConfig = HandBookConfig.Instance.GetHandBookEntranceConfig(EHandBookTabType.Quest);
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickCloseButton));
		this.CaptionItem.SetTitleLocalText(handBookEntranceConfig.Value.Name);
		this.CaptionItem.SetTitleIcon(handBookEntranceConfig.Value.TitleIcon);
	}

	// Token: 0x0600EBA2 RID: 60322 RVA: 0x0037EB58 File Offset: 0x0037CD58
	protected void InitVerticalLayout()
	{
		List<PlotType> list = ConfigCommon.ToList<PlotType>(HandBookConfig.Instance.GetPlotTypeConfigList());
		list.Sort(new Comparison<PlotType>(this.SortIndex));
		this.PlotTypeList = list;
		if (this.GenericLayout == null)
		{
			this.GenericLayout = new GenericLayoutNew<PlotHandBookItem>(base.GetVerticalLayout(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PlotHandBookItem>(this.InitPlotHandBookItem), null);
		}
		this.GenericLayout.ClearChildren();
		this.GenericLayout.RebuildLayoutByDataNew<PlotType>(this.PlotTypeList, null);
	}

	// Token: 0x0600EBA3 RID: 60323 RVA: 0x0037EBDC File Offset: 0x0037CDDC
	private ILayoutItem<PlotHandBookItem> InitPlotHandBookItem(object data, UUIItem uiItem, int index)
	{
		PlotHandBookItem plotHandBookItem = new PlotHandBookItem(uiItem);
		plotHandBookItem.Refresh((PlotType)data, false, index);
		return new LayoutItem<PlotHandBookItem>
		{
			Key = index,
			Value = plotHandBookItem
		};
	}

	// Token: 0x0600EBA4 RID: 60324 RVA: 0x0037EC16 File Offset: 0x0037CE16
	private int SortIndex(PlotType a, PlotType b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600EBA5 RID: 60325 RVA: 0x0037EC27 File Offset: 0x0037CE27
	private void OnClickCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.QuestHandBookView, null);
	}

	// Token: 0x0600EBA6 RID: 60326 RVA: 0x0037EC3C File Offset: 0x0037CE3C
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Quest);
		LguiUtil.Instance.SetLocalText(base.GetText(2), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			collectProgress[0],
			collectProgress[1]
		}));
	}

	// Token: 0x0600EBA7 RID: 60327 RVA: 0x0037EC8C File Offset: 0x0037CE8C
	protected override void OnBeforeShow()
	{
		bool flag = true;
		GenericLayoutNew<PlotHandBookItem> genericLayout = this.GenericLayout;
		List<PlotHandBookItem> list = (genericLayout != null) ? genericLayout.GetLayoutItemList() : null;
		if (list != null)
		{
			foreach (PlotHandBookItem plotHandBookItem in list)
			{
				foreach (PlotHandBookChildItem plotHandBookChildItem in plotHandBookItem.GetChildItemList())
				{
					UUIExtendToggle tog = plotHandBookChildItem.GetTog();
					if (flag && plotHandBookChildItem.GetIsUnlock())
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
	}

	// Token: 0x0600EBA8 RID: 60328 RVA: 0x0037ED58 File Offset: 0x0037CF58
	protected override void OnBeforeDestroy()
	{
		if (this.GenericLayout != null)
		{
			this.GenericLayout.ClearChildren();
			this.GenericLayout = null;
		}
		this.PlotTypeList = new List<PlotType>();
	}

	// Token: 0x0600EBA9 RID: 60329 RVA: 0x0037ED80 File Offset: 0x0037CF80
	protected void OnPhotoSelect(int configId)
	{
		GenericLayoutNew<PlotHandBookItem> genericLayout = this.GenericLayout;
		List<PlotHandBookItem> list = (genericLayout != null) ? genericLayout.GetLayoutItemList() : null;
		if (list != null)
		{
			foreach (PlotHandBookItem plotHandBookItem in list)
			{
				foreach (PlotHandBookChildItem plotHandBookChildItem in plotHandBookItem.GetChildItemList())
				{
					UUIExtendToggle tog = plotHandBookChildItem.GetTog();
					HandBookCommonItemData data = plotHandBookChildItem.GetData();
					if (data != null)
					{
						if (((PhotographHandBook)data.Config).Id == configId)
						{
							tog.SetToggleStateForce(EToggleState.ETT_Checked, false, true, false);
						}
						else
						{
							tog.SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
						}
					}
				}
			}
		}
	}

	// Token: 0x04006D4C RID: 27980
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<PlotHandBookItem> GenericLayout;

	// Token: 0x04006D4D RID: 27981
	private List<PlotType> PlotTypeList;

	// Token: 0x04006D4E RID: 27982
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x020083F4 RID: 33780
	[NullableContext(0)]
	private class EGeographyHandBookViewDefine
	{
		// Token: 0x0402AF4C RID: 175948
		public const int TitleItem = 0;

		// Token: 0x0402AF4D RID: 175949
		public const int VerticalLayout = 1;

		// Token: 0x0402AF4E RID: 175950
		public const int CollectCountText = 2;
	}
}

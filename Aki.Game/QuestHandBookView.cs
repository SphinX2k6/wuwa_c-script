using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001305 RID: 4869
[NullableContext(1)]
[Nullable(0)]
public class QuestHandBookView : UiViewBase
{
	// Token: 0x0600BFB8 RID: 49080 RVA: 0x0038A611 File Offset: 0x00388811
	public QuestHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.PlotTypeList = new List<PlotType>();
	}

	// Token: 0x0600BFB9 RID: 49081 RVA: 0x0038A628 File Offset: 0x00388828
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600BFBA RID: 49082 RVA: 0x0038A682 File Offset: 0x00388882
	protected override void OnStart()
	{
		this.Refresh();
		this.InitCommonTabTitle();
	}

	// Token: 0x0600BFBB RID: 49083 RVA: 0x0038A690 File Offset: 0x00388890
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600BFBC RID: 49084 RVA: 0x0038A698 File Offset: 0x00388898
	protected void Refresh()
	{
		this.InitVerticalLayout();
		this.RefreshCollectText();
	}

	// Token: 0x0600BFBD RID: 49085 RVA: 0x0038A6A8 File Offset: 0x003888A8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnPhotoSelect, new Action<int>(this.OnPhotoSelect));
	}

	// Token: 0x0600BFBE RID: 49086 RVA: 0x0038A70C File Offset: 0x0038890C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnPhotoSelect, new Action<int>(this.OnPhotoSelect));
	}

	// Token: 0x0600BFBF RID: 49087 RVA: 0x0038A76D File Offset: 0x0038896D
	protected override void OnAfterShow()
	{
	}

	// Token: 0x0600BFC0 RID: 49088 RVA: 0x0038A770 File Offset: 0x00388970
	protected void InitCommonTabTitle()
	{
		HandBookEntrance? handBookEntranceConfig = HandBookConfig.Instance.GetHandBookEntranceConfig(EHandBookTabType.Quest);
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickCloseButton));
		this.CaptionItem.SetTitleLocalText(handBookEntranceConfig.Value.Name);
		this.CaptionItem.SetTitleIcon(handBookEntranceConfig.Value.TitleIcon);
	}

	// Token: 0x0600BFC1 RID: 49089 RVA: 0x0038A7E8 File Offset: 0x003889E8
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

	// Token: 0x0600BFC2 RID: 49090 RVA: 0x0038A86C File Offset: 0x00388A6C
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

	// Token: 0x0600BFC3 RID: 49091 RVA: 0x0038A8A6 File Offset: 0x00388AA6
	private int SortIndex(PlotType a, PlotType b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600BFC4 RID: 49092 RVA: 0x0038A8B7 File Offset: 0x00388AB7
	private void OnClickCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.QuestHandBookView, null);
	}

	// Token: 0x0600BFC5 RID: 49093 RVA: 0x0038A8CC File Offset: 0x00388ACC
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Quest);
		LguiUtil.Instance.SetLocalText(base.GetText(2), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			collectProgress[0],
			collectProgress[1]
		}));
	}

	// Token: 0x0600BFC6 RID: 49094 RVA: 0x0038A91C File Offset: 0x00388B1C
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

	// Token: 0x0600BFC7 RID: 49095 RVA: 0x0038A9E8 File Offset: 0x00388BE8
	protected override void OnBeforeDestroy()
	{
		if (this.GenericLayout != null)
		{
			this.GenericLayout.ClearChildren();
			this.GenericLayout = null;
		}
		this.PlotTypeList = new List<PlotType>();
	}

	// Token: 0x0600BFC8 RID: 49096 RVA: 0x0038AA10 File Offset: 0x00388C10
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

	// Token: 0x04006E2D RID: 28205
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<PlotHandBookItem> GenericLayout;

	// Token: 0x04006E2E RID: 28206
	private List<PlotType> PlotTypeList;

	// Token: 0x04006E2F RID: 28207
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x02007579 RID: 30073
	[NullableContext(0)]
	private class EGeographyHandBookViewDefine
	{
		// Token: 0x04026270 RID: 156272
		public const int TitleItem = 0;

		// Token: 0x04026271 RID: 156273
		public const int VerticalLayout = 1;

		// Token: 0x04026272 RID: 156274
		public const int CollectCountText = 2;
	}
}

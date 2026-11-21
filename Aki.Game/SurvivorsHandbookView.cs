using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020B7 RID: 8375
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsHandbookView : UiViewBase
{
	// Token: 0x06014990 RID: 84368 RVA: 0x00600809 File Offset: 0x005FEA09
	public SurvivorsHandbookView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014991 RID: 84369 RVA: 0x00600824 File Offset: 0x005FEA24
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06014992 RID: 84370 RVA: 0x00600860 File Offset: 0x005FEA60
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsHandbookView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsHandbookView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014993 RID: 84371 RVA: 0x006008A4 File Offset: 0x005FEAA4
	protected override void OnBeforeShow()
	{
		if (this.IsFirstShow)
		{
			this.InitUiSceneRoleActor();
			ISurvivorsHandbookViewOpenParams survivorsHandbookViewOpenParams = this.OpenParam as ISurvivorsHandbookViewOpenParams;
			int num = 0;
			if (survivorsHandbookViewOpenParams != null)
			{
				ESurvivorsRogueItemType selectTabType = survivorsHandbookViewOpenParams.SelectTabType;
				EUiTabViewName? viewName = this.GetTabViewName(selectTabType);
				if (viewName != null)
				{
					num = this.TabDataList.FindIndex(delegate(UiDynamicTab data)
					{
						string childViewName = data.ChildViewName;
						EUiTabViewName? viewName = viewName;
						return childViewName == ((viewName != null) ? viewName.GetValueOrDefault() : null);
					});
					if (num == -1)
					{
						num = 0;
					}
				}
				this.DefaultSelectId = survivorsHandbookViewOpenParams.SelectCfgId;
			}
			TabComponentWithCaptionItem<CommonTabItem> captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SelectToggleByIndex(num, true);
			}
			this.IsFirstShow = false;
		}
		SurvivorsActivityController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06014994 RID: 84372 RVA: 0x00600948 File Offset: 0x005FEB48
	private void InitUiSceneRoleActor()
	{
		UiModelBase model = this.TsUiSceneRoleActor.Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		if (uiModelActorComponent != null)
		{
			uiModelActorComponent.SetTransformByTag("RoleCase");
		}
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, false, false);
	}

	// Token: 0x06014995 RID: 84373 RVA: 0x00600980 File Offset: 0x005FEB80
	private UniTask InitHandbookTab()
	{
		SurvivorsHandbookView.<InitHandbookTab>d__11 <InitHandbookTab>d__;
		<InitHandbookTab>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitHandbookTab>d__.<>4__this = this;
		<InitHandbookTab>d__.<>1__state = -1;
		<InitHandbookTab>d__.<>t__builder.Start<SurvivorsHandbookView.<InitHandbookTab>d__11>(ref <InitHandbookTab>d__);
		return <InitHandbookTab>d__.<>t__builder.Task;
	}

	// Token: 0x06014996 RID: 84374 RVA: 0x006009C3 File Offset: 0x005FEBC3
	private void InitTabViewComponent()
	{
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(0), EKeyMode.Default);
	}

	// Token: 0x06014997 RID: 84375 RVA: 0x006009D8 File Offset: 0x005FEBD8
	private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x06014998 RID: 84376 RVA: 0x006009E0 File Offset: 0x005FEBE0
	private void ToggleCallBack(int index)
	{
		UiDynamicTab data = this.TabDataList[index];
		EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
		CommonTabItem tabItemByIndex = this.CaptionItem.GetTabItemByIndex(index);
		TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
		if (tabViewComponent != null)
		{
			tabViewComponent.ToggleCallBack(data, viewName, tabItemByIndex, this.DefaultSelectId, null);
		}
		if (this.DefaultSelectId != null)
		{
			this.DefaultSelectId = null;
		}
	}

	// Token: 0x06014999 RID: 84377 RVA: 0x00600A58 File Offset: 0x005FEC58
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x0601499A RID: 84378 RVA: 0x00600A90 File Offset: 0x005FEC90
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601499B RID: 84379 RVA: 0x00600A9C File Offset: 0x005FEC9C
	protected override void OnBeforeDestroy()
	{
		SurvivorsRogueModel.Instance.SaveCacheHandbookClickedMap();
		if (this.TsUiSceneRoleActor != null)
		{
			UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
			this.TsUiSceneRoleActor = null;
		}
		if (this.CaptionItem != null)
		{
			this.CaptionItem.Destroy(null);
			this.CaptionItem = null;
		}
	}

	// Token: 0x0601499C RID: 84380 RVA: 0x00600AEE File Offset: 0x005FECEE
	protected override void OnAfterDestroy()
	{
		if (this.TsUiSceneRoleActor != null)
		{
			UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
			this.TsUiSceneRoleActor = null;
		}
	}

	// Token: 0x0601499D RID: 84381 RVA: 0x00600B10 File Offset: 0x005FED10
	private EUiTabViewName? GetTabViewName(ESurvivorsRogueItemType type)
	{
		switch (type)
		{
		case ESurvivorsRogueItemType.Normal:
			return new EUiTabViewName?(EUiTabViewName.SurvivorsItemTabView);
		case ESurvivorsRogueItemType.Weapon:
			return new EUiTabViewName?(EUiTabViewName.SurvivorsWeaponTabView);
		case ESurvivorsRogueItemType.Character:
			return new EUiTabViewName?(EUiTabViewName.SurvivorsRoleTabView);
		default:
			return null;
		}
	}

	// Token: 0x0400AF09 RID: 44809
	[Nullable(2)]
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400AF0A RID: 44810
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CommonTabItem> CaptionItem;

	// Token: 0x0400AF0B RID: 44811
	private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x0400AF0C RID: 44812
	[Nullable(2)]
	private TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x0400AF0D RID: 44813
	private int? DefaultSelectId;

	// Token: 0x0400AF0E RID: 44814
	private bool IsFirstShow = true;
}

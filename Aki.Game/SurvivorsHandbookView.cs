using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B3B RID: 11067
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsHandbookView : UiViewBase
{
	// Token: 0x06016F5F RID: 94047 RVA: 0x005D3C99 File Offset: 0x005D1E99
	public SurvivorsHandbookView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016F60 RID: 94048 RVA: 0x005D3CB4 File Offset: 0x005D1EB4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06016F61 RID: 94049 RVA: 0x005D3CF0 File Offset: 0x005D1EF0
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsHandbookView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsHandbookView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016F62 RID: 94050 RVA: 0x005D3D34 File Offset: 0x005D1F34
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

	// Token: 0x06016F63 RID: 94051 RVA: 0x005D3DD8 File Offset: 0x005D1FD8
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

	// Token: 0x06016F64 RID: 94052 RVA: 0x005D3E10 File Offset: 0x005D2010
	private UniTask InitHandbookTab()
	{
		SurvivorsHandbookView.<InitHandbookTab>d__11 <InitHandbookTab>d__;
		<InitHandbookTab>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitHandbookTab>d__.<>4__this = this;
		<InitHandbookTab>d__.<>1__state = -1;
		<InitHandbookTab>d__.<>t__builder.Start<SurvivorsHandbookView.<InitHandbookTab>d__11>(ref <InitHandbookTab>d__);
		return <InitHandbookTab>d__.<>t__builder.Task;
	}

	// Token: 0x06016F65 RID: 94053 RVA: 0x005D3E53 File Offset: 0x005D2053
	private void InitTabViewComponent()
	{
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(0), EKeyMode.Default);
	}

	// Token: 0x06016F66 RID: 94054 RVA: 0x005D3E68 File Offset: 0x005D2068
	private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x06016F67 RID: 94055 RVA: 0x005D3E70 File Offset: 0x005D2070
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

	// Token: 0x06016F68 RID: 94056 RVA: 0x005D3EE8 File Offset: 0x005D20E8
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x06016F69 RID: 94057 RVA: 0x005D3F20 File Offset: 0x005D2120
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06016F6A RID: 94058 RVA: 0x005D3F2C File Offset: 0x005D212C
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

	// Token: 0x06016F6B RID: 94059 RVA: 0x005D3F7E File Offset: 0x005D217E
	protected override void OnAfterDestroy()
	{
		if (this.TsUiSceneRoleActor != null)
		{
			UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
			this.TsUiSceneRoleActor = null;
		}
	}

	// Token: 0x06016F6C RID: 94060 RVA: 0x005D3FA0 File Offset: 0x005D21A0
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

	// Token: 0x0400AB03 RID: 43779
	[Nullable(2)]
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400AB04 RID: 43780
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CommonTabItem> CaptionItem;

	// Token: 0x0400AB05 RID: 43781
	private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x0400AB06 RID: 43782
	[Nullable(2)]
	private TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x0400AB07 RID: 43783
	private int? DefaultSelectId;

	// Token: 0x0400AB08 RID: 43784
	private bool IsFirstShow = true;
}

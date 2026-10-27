using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B2D RID: 11053
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SurvivorsRoleTabView : SurvivorsTabViewBase<SurvivorsRoleTabItem, SurvivorsHandbookItemDataBase>
{
	// Token: 0x17001E9D RID: 7837
	// (get) Token: 0x06016F10 RID: 93968 RVA: 0x005D29E9 File Offset: 0x005D0BE9
	protected override ESurvivorsRogueItemType ItemType
	{
		get
		{
			return ESurvivorsRogueItemType.Character;
		}
	}

	// Token: 0x06016F11 RID: 93969 RVA: 0x005D29EC File Offset: 0x005D0BEC
	protected override int GetLoopItemIndex()
	{
		return 3;
	}

	// Token: 0x06016F12 RID: 93970 RVA: 0x005D29EF File Offset: 0x005D0BEF
	protected override int GetLoopScrollComponentIndex()
	{
		return 1;
	}

	// Token: 0x06016F13 RID: 93971 RVA: 0x005D29F4 File Offset: 0x005D0BF4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x06016F14 RID: 93972 RVA: 0x005D2A90 File Offset: 0x005D0C90
	protected override UniTask InitSubComponents()
	{
		SurvivorsRoleTabView.<InitSubComponents>d__8 <InitSubComponents>d__;
		<InitSubComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSubComponents>d__.<>4__this = this;
		<InitSubComponents>d__.<>1__state = -1;
		<InitSubComponents>d__.<>t__builder.Start<SurvivorsRoleTabView.<InitSubComponents>d__8>(ref <InitSubComponents>d__);
		return <InitSubComponents>d__.<>t__builder.Task;
	}

	// Token: 0x06016F15 RID: 93973 RVA: 0x005D2AD3 File Offset: 0x005D0CD3
	protected override void OnTriggerSequenceStartEvent()
	{
		SurvivorsRoleTabDetail roleDetailItem = this.RoleDetailItem;
		if (roleDetailItem == null)
		{
			return;
		}
		roleDetailItem.Refresh(this.CurrentItemId.Value, true, 6);
	}

	// Token: 0x06016F16 RID: 93974 RVA: 0x005D2AF2 File Offset: 0x005D0CF2
	protected override void OnBeforeShow()
	{
		UiModelBase model = UiSceneManager.Instance.GetRoleSystemRoleActor().Model;
		UiModelLoadingIconComponent uiModelLoadingIconComponent = (model != null) ? model.CheckGetComponent<UiModelLoadingIconComponent>() : null;
		if (uiModelLoadingIconComponent != null)
		{
			uiModelLoadingIconComponent.SetLoadingOpen(true);
		}
		UiSceneManager.Instance.ShowRoleSystemRoleActor();
	}

	// Token: 0x06016F17 RID: 93975 RVA: 0x005D2B25 File Offset: 0x005D0D25
	protected override void OnHideUiTabViewBase(bool fromToggle)
	{
		UiSceneManager.Instance.HideRoleSystemRoleActor();
		if (UiSceneManager.Instance.HasRoleSystemRoleActor())
		{
			UiModelBase model = UiSceneManager.Instance.GetRoleSystemRoleActor().Model;
			UiModelLoadingIconComponent uiModelLoadingIconComponent = (model != null) ? model.CheckGetComponent<UiModelLoadingIconComponent>() : null;
			if (uiModelLoadingIconComponent == null)
			{
				return;
			}
			uiModelLoadingIconComponent.SetLoadingOpen(false);
		}
	}

	// Token: 0x06016F18 RID: 93976 RVA: 0x005D2B63 File Offset: 0x005D0D63
	protected override void OnStart()
	{
		this.PanelLock.SetButtonVisible(false);
	}

	// Token: 0x06016F19 RID: 93977 RVA: 0x005D2B71 File Offset: 0x005D0D71
	protected override SurvivorsRoleTabItem CreateLoopItem()
	{
		SurvivorsRoleTabItem survivorsRoleTabItem = new SurvivorsRoleTabItem();
		survivorsRoleTabItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(base.OnCanClickItem));
		survivorsRoleTabItem.OnClickCallBack = new Action<SurvivorsHandbookItemDataBase, SurvivorsRoleTabItem>(base.OnItemClick);
		return survivorsRoleTabItem;
	}

	// Token: 0x06016F1A RID: 93978 RVA: 0x005D2B9C File Offset: 0x005D0D9C
	protected override IReadOnlyList<SurvivorsHandbookItemDataBase> GenerateItemUiDataList()
	{
		SurvivorsRogueModel instance = SurvivorsRogueModel.Instance;
		SurvivorsActivityData activityData = instance.ActivityData;
		if (activityData == null)
		{
			return Array.Empty<SurvivorsHandbookItemDataBase>();
		}
		List<SurvivorsHandbookItemDataBase> list = new List<SurvivorsHandbookItemDataBase>();
		List<int> showRoleList = activityData.GetShowRoleList();
		for (int i = 0; i < showRoleList.Count; i++)
		{
			int id = showRoleList[i];
			SurvivorsHandbookItemDataBase item = new SurvivorsHandbookItemDataBase
			{
				Id = id,
				LockState = new bool?(instance.GetItemIsLock(this.ItemType, id)),
				IsNew = new bool?(instance.GetItemIsNew(this.ItemType, id))
			};
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06016F1B RID: 93979 RVA: 0x005D2C38 File Offset: 0x005D0E38
	protected override void OnSelectItem(SurvivorsHandbookItemDataBase data, bool isFromClick)
	{
		SurvivorsRole value = SurvivorsRogueConfig.Instance.GetSurvivorsRole(data.Id).Value;
		FunctionalPanelConditionLock panelLock = this.PanelLock;
		if (panelLock != null)
		{
			panelLock.SetUiActive(data.LockState.GetValueOrDefault());
		}
		if (data.LockState.GetValueOrDefault())
		{
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(value.UnlockConditionId);
			FunctionalPanelConditionLock panelLock2 = this.PanelLock;
			if (panelLock2 != null)
			{
				panelLock2.SetTextByTextId(conditionGroupHintText ?? string.Empty, Array.Empty<string>());
			}
		}
		this.RoleDetailItem.Refresh(data.Id, isFromClick, 6);
		this.RefreshDisplayModel(value.TrialRoleId);
		if (isFromClick)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.StopSequenceByKey("Switch", false, false);
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 == null)
			{
				return;
			}
			uiViewSequence2.PlaySequence("Switch", false, null);
		}
	}

	// Token: 0x06016F1C RID: 93980 RVA: 0x005D2D18 File Offset: 0x005D0F18
	private void RefreshDisplayModel(int trialRoleId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleId, true);
		if (roleDataById != null)
		{
			RoleController.Instance.OnSelectedRoleChangeByConfig(roleDataById.GetRoleConfig().Id, roleDataById.GetRoleSkinId(), null);
		}
	}

	// Token: 0x0400AAD1 RID: 43729
	[Nullable(2)]
	private SurvivorsRoleTabDetail RoleDetailItem;

	// Token: 0x0400AAD2 RID: 43730
	[Nullable(2)]
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x0400AAD3 RID: 43731
	private const int SHOW_ATTRIBUTE_NUM = 6;
}

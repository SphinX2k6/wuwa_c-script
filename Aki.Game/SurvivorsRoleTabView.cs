using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020A9 RID: 8361
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class SurvivorsRoleTabView : SurvivorsTabViewBase<SurvivorsRoleTabItem, SurvivorsHandbookItemDataBase>
{
	// Token: 0x17001EF5 RID: 7925
	// (get) Token: 0x06014941 RID: 84289 RVA: 0x005FF55D File Offset: 0x005FD75D
	protected override ESurvivorsRogueItemType ItemType
	{
		get
		{
			return ESurvivorsRogueItemType.Character;
		}
	}

	// Token: 0x06014942 RID: 84290 RVA: 0x005FF560 File Offset: 0x005FD760
	protected override int GetLoopItemIndex()
	{
		return 3;
	}

	// Token: 0x06014943 RID: 84291 RVA: 0x005FF563 File Offset: 0x005FD763
	protected override int GetLoopScrollComponentIndex()
	{
		return 1;
	}

	// Token: 0x06014944 RID: 84292 RVA: 0x005FF568 File Offset: 0x005FD768
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

	// Token: 0x06014945 RID: 84293 RVA: 0x005FF604 File Offset: 0x005FD804
	protected override UniTask InitSubComponents()
	{
		SurvivorsRoleTabView.<InitSubComponents>d__8 <InitSubComponents>d__;
		<InitSubComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSubComponents>d__.<>4__this = this;
		<InitSubComponents>d__.<>1__state = -1;
		<InitSubComponents>d__.<>t__builder.Start<SurvivorsRoleTabView.<InitSubComponents>d__8>(ref <InitSubComponents>d__);
		return <InitSubComponents>d__.<>t__builder.Task;
	}

	// Token: 0x06014946 RID: 84294 RVA: 0x005FF647 File Offset: 0x005FD847
	protected override void OnTriggerSequenceStartEvent()
	{
		SurvivorsRoleTabDetail roleDetailItem = this.RoleDetailItem;
		if (roleDetailItem == null)
		{
			return;
		}
		roleDetailItem.Refresh(this.CurrentItemId.Value, true, 6);
	}

	// Token: 0x06014947 RID: 84295 RVA: 0x005FF666 File Offset: 0x005FD866
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

	// Token: 0x06014948 RID: 84296 RVA: 0x005FF699 File Offset: 0x005FD899
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

	// Token: 0x06014949 RID: 84297 RVA: 0x005FF6D7 File Offset: 0x005FD8D7
	protected override void OnStart()
	{
		this.PanelLock.SetButtonVisible(false);
	}

	// Token: 0x0601494A RID: 84298 RVA: 0x005FF6E5 File Offset: 0x005FD8E5
	protected override SurvivorsRoleTabItem CreateLoopItem()
	{
		SurvivorsRoleTabItem survivorsRoleTabItem = new SurvivorsRoleTabItem();
		survivorsRoleTabItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(base.OnCanClickItem));
		survivorsRoleTabItem.OnClickCallBack = new Action<SurvivorsHandbookItemDataBase, SurvivorsRoleTabItem>(base.OnItemClick);
		return survivorsRoleTabItem;
	}

	// Token: 0x0601494B RID: 84299 RVA: 0x005FF710 File Offset: 0x005FD910
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

	// Token: 0x0601494C RID: 84300 RVA: 0x005FF7AC File Offset: 0x005FD9AC
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

	// Token: 0x0601494D RID: 84301 RVA: 0x005FF88C File Offset: 0x005FDA8C
	private void RefreshDisplayModel(int trialRoleId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleId, true);
		if (roleDataById != null)
		{
			RoleController.Instance.OnSelectedRoleChangeByConfig(roleDataById.GetRoleConfig().Id, roleDataById.GetRoleSkinId(), null);
		}
	}

	// Token: 0x0400AED7 RID: 44759
	[Nullable(2)]
	private SurvivorsRoleTabDetail RoleDetailItem;

	// Token: 0x0400AED8 RID: 44760
	[Nullable(2)]
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x0400AED9 RID: 44761
	private const int SHOW_ATTRIBUTE_NUM = 6;
}

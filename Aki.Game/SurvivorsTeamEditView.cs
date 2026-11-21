using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020D4 RID: 8404
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsTeamEditView : UiViewBase
{
	// Token: 0x06014A53 RID: 84563 RVA: 0x006043E3 File Offset: 0x006025E3
	[NullableContext(1)]
	public SurvivorsTeamEditView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014A54 RID: 84564 RVA: 0x006043F8 File Offset: 0x006025F8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIInturnAnimController)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OnConfirmBtnClick)),
			new ValueTuple<int, Delegate>(10, new Action(this.OnHandBookBtnClick))
		};
	}

	// Token: 0x06014A55 RID: 84565 RVA: 0x00604558 File Offset: 0x00602758
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsTeamEditView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsTeamEditView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014A56 RID: 84566 RVA: 0x0060459B File Offset: 0x0060279B
	protected override void OnBeforeShow()
	{
		SurvivorsActivityController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06014A57 RID: 84567 RVA: 0x006045A7 File Offset: 0x006027A7
	protected override void OnBeforeDestroy()
	{
		if (this.TsUiSceneRoleActor != null)
		{
			UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
			this.TsUiSceneRoleActor = null;
		}
	}

	// Token: 0x06014A58 RID: 84568 RVA: 0x006045CC File Offset: 0x006027CC
	private UniTask InitItemScroll()
	{
		SurvivorsTeamEditView.<InitItemScroll>d__14 <InitItemScroll>d__;
		<InitItemScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitItemScroll>d__.<>4__this = this;
		<InitItemScroll>d__.<>1__state = -1;
		<InitItemScroll>d__.<>t__builder.Start<SurvivorsTeamEditView.<InitItemScroll>d__14>(ref <InitItemScroll>d__);
		return <InitItemScroll>d__.<>t__builder.Task;
	}

	// Token: 0x06014A59 RID: 84569 RVA: 0x00604610 File Offset: 0x00602810
	private void GetData()
	{
		this.SurvivorsLevelInfo = SurvivorsRogueModel.Instance.SelectLevelInfo;
		SurvivorsActivityData activityData = SurvivorsRogueModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		SurvivorsLevel value = SurvivorsRogueConfig.Instance.GetSurvivorsLevel(this.SurvivorsLevelInfo.LevelId).Value;
		foreach (int num in activityData.GetShowRoleList())
		{
			int trialRoleId = SurvivorsRogueConfig.Instance.GetSurvivorsRole(num).Value.TrialRoleId;
			bool flag = activityData.RoleMap[num];
			bool flag2 = false;
			for (int i = 0; i < value.InitRolesLength; i++)
			{
				if (value.InitRoles(i) == num)
				{
					flag2 = true;
					break;
				}
			}
			SurvivorsRoleData survivorsRoleData = new SurvivorsRoleData(num, trialRoleId, flag || flag2);
			survivorsRoleData.IsSurvivorsTrial = flag2;
			this.RoleDataList.Add(survivorsRoleData);
		}
		this.RoleDataList.Sort(delegate(SurvivorsRoleData a, SurvivorsRoleData b)
		{
			if (a.IsSurvivorsTrial != b.IsSurvivorsTrial)
			{
				if (!a.IsSurvivorsTrial)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (a.IsUnLock == b.IsUnLock)
				{
					return 0;
				}
				if (!a.IsUnLock)
				{
					return 1;
				}
				return -1;
			}
		});
	}

	// Token: 0x06014A5A RID: 84570 RVA: 0x0060474C File Offset: 0x0060294C
	private void RefreshView()
	{
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(this.CurSelectRoleData.IsUnLock);
		}
		UUIButtonComponent button = base.GetButton(6);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(this.CurSelectRoleData.IsUnLock);
		}
		this.PnlRedTips.SetUiActive(!this.CurSelectRoleData.IsUnLock);
		if (!this.CurSelectRoleData.IsUnLock)
		{
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(this.CurSelectRoleData.UnlockConditionId);
			this.PnlRedTips.SetTextByTextId(conditionGroupHintText, Array.Empty<string>());
		}
		this.RoleInfoPanel.RefreshFourAttr(this.CurSelectRoleData.SurRoleId, true);
		SurvivorsRogueWeaponCard survivorsRogueWeaponCard = SurvivorsRogueCardDataFactory.CreateGeneralWeapon(this.CurSelectRoleData.InitWeaponID);
		survivorsRogueWeaponCard.TagVisible = new bool?(false);
		this.CardItem.Apply(survivorsRogueWeaponCard);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.CurSelectRoleData.TrialRoleId, true);
		if (roleDataById == null)
		{
			return;
		}
		RoleController.Instance.OnSelectedRoleChangeByConfig(roleDataById.GetRoleConfig().Id, roleDataById.GetRoleSkinId(), null);
	}

	// Token: 0x06014A5B RID: 84571 RVA: 0x00604864 File Offset: 0x00602A64
	protected override void OnHandleLoadScene()
	{
		if (this.TsUiSceneRoleActor == null)
		{
			this.TsUiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInRoleView);
		}
		UiModelBase model = this.TsUiSceneRoleActor.Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		if (uiModelActorComponent != null)
		{
			uiModelActorComponent.SetTransformByTag("RoleCase");
		}
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, false, false);
		this.RefreshView();
	}

	// Token: 0x06014A5C RID: 84572 RVA: 0x006048C5 File Offset: 0x00602AC5
	[NullableContext(1)]
	private SurvivorsTeamEditRoleItemGird OnGridProxyCreate()
	{
		SurvivorsTeamEditRoleItemGird survivorsTeamEditRoleItemGird = new SurvivorsTeamEditRoleItemGird();
		survivorsTeamEditRoleItemGird.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		survivorsTeamEditRoleItemGird.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return survivorsTeamEditRoleItemGird;
	}

	// Token: 0x06014A5D RID: 84573 RVA: 0x006048F0 File Offset: 0x00602AF0
	[NullableContext(1)]
	private void ToggleFunction(MediumItemGridExtendCallback callbackParameter)
	{
		int state = (int)callbackParameter.State;
		SurvivorsRoleData survivorsRoleData = (SurvivorsRoleData)callbackParameter.Data;
		if (state == 1)
		{
			this.RoleScrollView.DeselectCurrentGridProxy(false);
			int gridIndex = this.RoleDataList.IndexOf(survivorsRoleData);
			this.RoleScrollView.SelectGridProxy(gridIndex, false);
			this.CurSelectRoleData = survivorsRoleData;
			this.RefreshView();
		}
	}

	// Token: 0x06014A5E RID: 84574 RVA: 0x00604945 File Offset: 0x00602B45
	[NullableContext(1)]
	private bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
	{
		return true;
	}

	// Token: 0x06014A5F RID: 84575 RVA: 0x00604948 File Offset: 0x00602B48
	private void OnConfirmBtnClick()
	{
		this.SurvivorsLevelInfo.RoleId = this.CurSelectRoleData.SurRoleId;
		SurvivorsRogueController.Instance.OpenEnterInstConfirm();
	}

	// Token: 0x06014A60 RID: 84576 RVA: 0x0060496C File Offset: 0x00602B6C
	private void OnHandBookBtnClick()
	{
		SurvivorsHandbookViewOpenParams survivorsHandbookViewOpenParams = new SurvivorsHandbookViewOpenParams();
		survivorsHandbookViewOpenParams.SelectTabType = ESurvivorsRogueItemType.Weapon;
		SurvivorsRoleData curSelectRoleData = this.CurSelectRoleData;
		survivorsHandbookViewOpenParams.SelectCfgId = ((curSelectRoleData != null) ? new int?(curSelectRoleData.InitWeaponID) : null);
		SurvivorsHandbookViewOpenParams param = survivorsHandbookViewOpenParams;
		UiManager.Instance.OpenView(EUiViewName.SurvivorsHandbookView, param, null);
	}

	// Token: 0x06014A61 RID: 84577 RVA: 0x006049BC File Offset: 0x00602BBC
	private void OnBackBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.SurvivorsTeamEditView, null);
	}

	// Token: 0x0400AFE8 RID: 45032
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400AFE9 RID: 45033
	private SurvivorsActivityDefine.SurvivorsLevelInfo SurvivorsLevelInfo;

	// Token: 0x0400AFEA RID: 45034
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<SurvivorsTeamEditRoleItemGird, SurvivorsRoleData> RoleScrollView;

	// Token: 0x0400AFEB RID: 45035
	private SurvivorsRoleData CurSelectRoleData;

	// Token: 0x0400AFEC RID: 45036
	[Nullable(1)]
	private readonly List<SurvivorsRoleData> RoleDataList = new List<SurvivorsRoleData>();

	// Token: 0x0400AFED RID: 45037
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400AFEE RID: 45038
	private SurvivorsRogueCardBase CardItem;

	// Token: 0x0400AFEF RID: 45039
	private SurvivorsRoleTabDetail RoleInfoPanel;

	// Token: 0x0400AFF0 RID: 45040
	private FunctionalPanelConditionLock PnlRedTips;
}

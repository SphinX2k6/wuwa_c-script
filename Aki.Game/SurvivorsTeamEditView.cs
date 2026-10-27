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

// Token: 0x02002B58 RID: 11096
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsTeamEditView : UiViewBase
{
	// Token: 0x06017022 RID: 94242 RVA: 0x005D7877 File Offset: 0x005D5A77
	[NullableContext(1)]
	public SurvivorsTeamEditView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06017023 RID: 94243 RVA: 0x005D788C File Offset: 0x005D5A8C
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

	// Token: 0x06017024 RID: 94244 RVA: 0x005D79EC File Offset: 0x005D5BEC
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsTeamEditView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsTeamEditView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017025 RID: 94245 RVA: 0x005D7A2F File Offset: 0x005D5C2F
	protected override void OnBeforeShow()
	{
		SurvivorsActivityController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06017026 RID: 94246 RVA: 0x005D7A3B File Offset: 0x005D5C3B
	protected override void OnBeforeDestroy()
	{
		if (this.TsUiSceneRoleActor != null)
		{
			UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
			this.TsUiSceneRoleActor = null;
		}
	}

	// Token: 0x06017027 RID: 94247 RVA: 0x005D7A60 File Offset: 0x005D5C60
	private UniTask InitItemScroll()
	{
		SurvivorsTeamEditView.<InitItemScroll>d__14 <InitItemScroll>d__;
		<InitItemScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitItemScroll>d__.<>4__this = this;
		<InitItemScroll>d__.<>1__state = -1;
		<InitItemScroll>d__.<>t__builder.Start<SurvivorsTeamEditView.<InitItemScroll>d__14>(ref <InitItemScroll>d__);
		return <InitItemScroll>d__.<>t__builder.Task;
	}

	// Token: 0x06017028 RID: 94248 RVA: 0x005D7AA4 File Offset: 0x005D5CA4
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

	// Token: 0x06017029 RID: 94249 RVA: 0x005D7BE0 File Offset: 0x005D5DE0
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

	// Token: 0x0601702A RID: 94250 RVA: 0x005D7CF8 File Offset: 0x005D5EF8
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

	// Token: 0x0601702B RID: 94251 RVA: 0x005D7D59 File Offset: 0x005D5F59
	[NullableContext(1)]
	private SurvivorsTeamEditRoleItemGird OnGridProxyCreate()
	{
		SurvivorsTeamEditRoleItemGird survivorsTeamEditRoleItemGird = new SurvivorsTeamEditRoleItemGird();
		survivorsTeamEditRoleItemGird.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		survivorsTeamEditRoleItemGird.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return survivorsTeamEditRoleItemGird;
	}

	// Token: 0x0601702C RID: 94252 RVA: 0x005D7D84 File Offset: 0x005D5F84
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

	// Token: 0x0601702D RID: 94253 RVA: 0x005D7DD9 File Offset: 0x005D5FD9
	[NullableContext(1)]
	private bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
	{
		return true;
	}

	// Token: 0x0601702E RID: 94254 RVA: 0x005D7DDC File Offset: 0x005D5FDC
	private void OnConfirmBtnClick()
	{
		this.SurvivorsLevelInfo.RoleId = this.CurSelectRoleData.SurRoleId;
		SurvivorsRogueController.Instance.OpenEnterInstConfirm();
	}

	// Token: 0x0601702F RID: 94255 RVA: 0x005D7E00 File Offset: 0x005D6000
	private void OnHandBookBtnClick()
	{
		SurvivorsHandbookViewOpenParams survivorsHandbookViewOpenParams = new SurvivorsHandbookViewOpenParams();
		survivorsHandbookViewOpenParams.SelectTabType = ESurvivorsRogueItemType.Weapon;
		SurvivorsRoleData curSelectRoleData = this.CurSelectRoleData;
		survivorsHandbookViewOpenParams.SelectCfgId = ((curSelectRoleData != null) ? new int?(curSelectRoleData.InitWeaponID) : null);
		SurvivorsHandbookViewOpenParams param = survivorsHandbookViewOpenParams;
		UiManager.Instance.OpenView(EUiViewName.SurvivorsHandbookView, param, null);
	}

	// Token: 0x06017030 RID: 94256 RVA: 0x005D7E50 File Offset: 0x005D6050
	private void OnBackBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.SurvivorsTeamEditView, null);
	}

	// Token: 0x0400ABE2 RID: 44002
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400ABE3 RID: 44003
	private SurvivorsActivityDefine.SurvivorsLevelInfo SurvivorsLevelInfo;

	// Token: 0x0400ABE4 RID: 44004
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<SurvivorsTeamEditRoleItemGird, SurvivorsRoleData> RoleScrollView;

	// Token: 0x0400ABE5 RID: 44005
	private SurvivorsRoleData CurSelectRoleData;

	// Token: 0x0400ABE6 RID: 44006
	[Nullable(1)]
	private readonly List<SurvivorsRoleData> RoleDataList = new List<SurvivorsRoleData>();

	// Token: 0x0400ABE7 RID: 44007
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400ABE8 RID: 44008
	private SurvivorsRogueCardBase CardItem;

	// Token: 0x0400ABE9 RID: 44009
	private SurvivorsRoleTabDetail RoleInfoPanel;

	// Token: 0x0400ABEA RID: 44010
	private FunctionalPanelConditionLock PnlRedTips;
}

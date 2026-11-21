using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001371 RID: 4977
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryRoleEquipItem : UiPanelBase
{
	// Token: 0x0600C596 RID: 50582 RVA: 0x003ACFCD File Offset: 0x003AB1CD
	public HonamiStoryRoleEquipItem(HonamiStoryRoleEquipData roleEquipData)
	{
		this.RoleEquipData = roleEquipData;
	}

	// Token: 0x0600C597 RID: 50583 RVA: 0x003ACFE7 File Offset: 0x003AB1E7
	public void RegisterPanel(HonamiStoryBackpackPanelBase panel)
	{
		this.Panel = panel;
	}

	// Token: 0x0600C598 RID: 50584 RVA: 0x003ACFF0 File Offset: 0x003AB1F0
	public HonamiStoryRoleEquipData GetRoleEquipData()
	{
		return this.RoleEquipData;
	}

	// Token: 0x0600C599 RID: 50585 RVA: 0x003ACFF8 File Offset: 0x003AB1F8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnRoleItemClicked)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickedMore))
		};
	}

	// Token: 0x0600C59A RID: 50586 RVA: 0x003AD0D0 File Offset: 0x003AB2D0
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryRoleEquipItem.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryRoleEquipItem.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C59B RID: 50587 RVA: 0x003AD113 File Offset: 0x003AB313
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnHonamiStoryBackpackClickWeapon, new Action(this.OnAfterClickedWeaponItem));
	}

	// Token: 0x0600C59C RID: 50588 RVA: 0x003AD131 File Offset: 0x003AB331
	protected override void OnBeforeShow()
	{
		this.RefreshRoleItem();
		this.RefreshWeaponItem();
		this.RefreshBtnMoreVisible();
	}

	// Token: 0x0600C59D RID: 50589 RVA: 0x003AD145 File Offset: 0x003AB345
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnHonamiStoryBackpackClickWeapon, new Action(this.OnAfterClickedWeaponItem));
	}

	// Token: 0x0600C59E RID: 50590 RVA: 0x003AD164 File Offset: 0x003AB364
	private void RefreshRoleItem()
	{
		int roleId = this.RoleEquipData.GetRoleId();
		UUISprite sprite = base.GetSprite(1);
		if (sprite != null)
		{
			sprite.SetUIActive(roleId <= 0);
		}
		UUITexture texture = base.GetTexture(2);
		if (texture != null)
		{
			texture.SetUIActive(roleId > 0);
		}
		if (roleId <= 0)
		{
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		if (roleConfig == null)
		{
			return;
		}
		RoleSkinData roleSkinDataByRoleId = RoleSkinModel.Instance.GetRoleSkinDataByRoleId(roleId);
		string path = (roleSkinDataByRoleId != null) ? roleSkinDataByRoleId.GetRoleSkinConfig().RoleHeadIconLarge : roleConfig.Value.RoleHeadIconLarge;
		base.SetRoleIconByRoleIdOrSkinId(path, base.GetTexture(2), roleId, new int?(roleConfig.Value.SkinId), null, null);
	}

	// Token: 0x0600C59F RID: 50591 RVA: 0x003AD228 File Offset: 0x003AB428
	private UniTask InitRolePluginItemList()
	{
		HonamiStoryRoleEquipItem.<InitRolePluginItemList>d__20 <InitRolePluginItemList>d__;
		<InitRolePluginItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRolePluginItemList>d__.<>4__this = this;
		<InitRolePluginItemList>d__.<>1__state = -1;
		<InitRolePluginItemList>d__.<>t__builder.Start<HonamiStoryRoleEquipItem.<InitRolePluginItemList>d__20>(ref <InitRolePluginItemList>d__);
		return <InitRolePluginItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600C5A0 RID: 50592 RVA: 0x003AD26C File Offset: 0x003AB46C
	private UniTask InitRolePluginItem(int index)
	{
		HonamiStoryRoleEquipItem.<InitRolePluginItem>d__21 <InitRolePluginItem>d__;
		<InitRolePluginItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRolePluginItem>d__.<>4__this = this;
		<InitRolePluginItem>d__.index = index;
		<InitRolePluginItem>d__.<>1__state = -1;
		<InitRolePluginItem>d__.<>t__builder.Start<HonamiStoryRoleEquipItem.<InitRolePluginItem>d__21>(ref <InitRolePluginItem>d__);
		return <InitRolePluginItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C5A1 RID: 50593 RVA: 0x003AD2B8 File Offset: 0x003AB4B8
	public UniTask RefreshUiAsync(HonamiStoryRoleEquipData equipData)
	{
		HonamiStoryRoleEquipItem.<RefreshUiAsync>d__22 <RefreshUiAsync>d__;
		<RefreshUiAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshUiAsync>d__.<>4__this = this;
		<RefreshUiAsync>d__.equipData = equipData;
		<RefreshUiAsync>d__.<>1__state = -1;
		<RefreshUiAsync>d__.<>t__builder.Start<HonamiStoryRoleEquipItem.<RefreshUiAsync>d__22>(ref <RefreshUiAsync>d__);
		return <RefreshUiAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C5A2 RID: 50594 RVA: 0x003AD304 File Offset: 0x003AB504
	private UniTask RefreshPluginItemList()
	{
		HonamiStoryRoleEquipItem.<RefreshPluginItemList>d__23 <RefreshPluginItemList>d__;
		<RefreshPluginItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshPluginItemList>d__.<>4__this = this;
		<RefreshPluginItemList>d__.<>1__state = -1;
		<RefreshPluginItemList>d__.<>t__builder.Start<HonamiStoryRoleEquipItem.<RefreshPluginItemList>d__23>(ref <RefreshPluginItemList>d__);
		return <RefreshPluginItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600C5A3 RID: 50595 RVA: 0x003AD348 File Offset: 0x003AB548
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<HonamiStoryEquipGridItem> CreateRolePluginItem()
	{
		HonamiStoryRoleEquipItem.<CreateRolePluginItem>d__24 <CreateRolePluginItem>d__;
		<CreateRolePluginItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<HonamiStoryEquipGridItem>.Create();
		<CreateRolePluginItem>d__.<>4__this = this;
		<CreateRolePluginItem>d__.<>1__state = -1;
		<CreateRolePluginItem>d__.<>t__builder.Start<HonamiStoryRoleEquipItem.<CreateRolePluginItem>d__24>(ref <CreateRolePluginItem>d__);
		return <CreateRolePluginItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C5A4 RID: 50596 RVA: 0x003AD38C File Offset: 0x003AB58C
	[return: Nullable(2)]
	public HonamiStoryEquipGridItem GetEquipItemByEventData(ULGUIPointerEventData eventData)
	{
		foreach (HonamiStoryEquipGridItem honamiStoryEquipGridItem in this.RolePluginItemList)
		{
			if (HonamiStoryUtil.CheckEventDataInItemViewport(eventData, honamiStoryEquipGridItem.GetRootItem(), true))
			{
				return honamiStoryEquipGridItem;
			}
		}
		return null;
	}

	// Token: 0x0600C5A5 RID: 50597 RVA: 0x003AD3F0 File Offset: 0x003AB5F0
	public List<HonamiStoryEquipGridItem> GetPluginItemList()
	{
		return this.RolePluginItemList;
	}

	// Token: 0x0600C5A6 RID: 50598 RVA: 0x003AD3F8 File Offset: 0x003AB5F8
	public void SetRoleTipOpenState(bool isOpen)
	{
		bool btnMoreShowVisible = this.GetBtnMoreShowVisible();
		this.IsRoleTipsOpen = isOpen;
		UUIButtonComponent button = base.GetButton(5);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(btnMoreShowVisible && !isOpen);
	}

	// Token: 0x0600C5A7 RID: 50599 RVA: 0x003AD43C File Offset: 0x003AB63C
	private void RefreshBtnMoreVisible()
	{
		bool btnMoreShowVisible = this.GetBtnMoreShowVisible();
		UUIButtonComponent button = base.GetButton(5);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(btnMoreShowVisible && !this.IsRoleTipsOpen);
	}

	// Token: 0x0600C5A8 RID: 50600 RVA: 0x003AD480 File Offset: 0x003AB680
	private bool GetBtnMoreShowVisible()
	{
		if (!HonamiStoryModel.Instance.GetBackpackLogic().IsBackpackView() && HonamiStoryUtil.IsMobileView())
		{
			return false;
		}
		bool flag = this.RoleEquipData.GetWeaponId() <= 0;
		bool flag2 = this.RoleEquipData.GetEquipItemDataList().Count == 0;
		return !flag || !flag2;
	}

	// Token: 0x0600C5A9 RID: 50601 RVA: 0x003AD4D4 File Offset: 0x003AB6D4
	[NullableContext(2)]
	private void OnEnterGrid(HonamiStoryItemGridItem item)
	{
		Action<HonamiStoryItemGridItem> onEnterGridCb = this.OnEnterGridCb;
		if (onEnterGridCb == null)
		{
			return;
		}
		onEnterGridCb(item);
	}

	// Token: 0x0600C5AA RID: 50602 RVA: 0x003AD4E7 File Offset: 0x003AB6E7
	private void OnExitGrid()
	{
		Action onExitGridCb = this.OnExitGridCb;
		if (onExitGridCb == null)
		{
			return;
		}
		onExitGridCb();
	}

	// Token: 0x0600C5AB RID: 50603 RVA: 0x003AD4F9 File Offset: 0x003AB6F9
	private void OnDownGrid()
	{
		Action onDownGridCb = this.OnDownGridCb;
		if (onDownGridCb == null)
		{
			return;
		}
		onDownGridCb();
	}

	// Token: 0x0600C5AC RID: 50604 RVA: 0x003AD50B File Offset: 0x003AB70B
	private void OnClickedGrid([Nullable(2)] HonamiStoryItemGridItem item, Vector2D loc, Vector2D size)
	{
		Action<HonamiStoryItemGridItem, Vector2D, Vector2D> onClickedGridCb = this.OnClickedGridCb;
		if (onClickedGridCb == null)
		{
			return;
		}
		onClickedGridCb(item, loc, size);
	}

	// Token: 0x0600C5AD RID: 50605 RVA: 0x003AD520 File Offset: 0x003AB720
	public void SetEnableState(EHonamiStoryBackpackLogicState state)
	{
		bool flag = state == EHonamiStoryBackpackLogicState.Normal;
		bool flag2 = state == EHonamiStoryBackpackLogicState.Dragging || state == EHonamiStoryBackpackLogicState.DraggingPlugins;
		float alpha = (flag || flag2) ? 1f : 0.4f;
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.RootUIComp.Get().SetAlpha(alpha);
		}
		UUIButtonComponent button2 = base.GetButton(0);
		if (button2 != null)
		{
			button2.RootUIComp.Get().SetRaycastTarget(flag);
		}
		HonamiStoryWeaponToggleItem weaponItem = this.WeaponItem;
		if (weaponItem != null)
		{
			weaponItem.SetIsEnable(flag);
		}
		UUIButtonComponent button3 = base.GetButton(5);
		if (button3 != null)
		{
			button3.RootUIComp.Get().SetAlpha(alpha);
		}
		UUIButtonComponent button4 = base.GetButton(5);
		if (button4 != null)
		{
			button4.RootUIComp.Get().SetRaycastTarget(flag);
		}
		bool flag3 = flag2 || flag || state == EHonamiStoryBackpackLogicState.Instead;
		float alpha2 = flag3 ? 1f : 0.4f;
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetAlpha(alpha2);
		}
		foreach (HonamiStoryEquipGridItem honamiStoryEquipGridItem in this.RolePluginItemList)
		{
			honamiStoryEquipGridItem.SetIsEnable(flag3);
		}
	}

	// Token: 0x0600C5AE RID: 50606 RVA: 0x003AD660 File Offset: 0x003AB860
	public void RefreshState(EHonamiStoryBackpackLogicState state)
	{
		foreach (HonamiStoryEquipGridItem honamiStoryEquipGridItem in this.RolePluginItemList)
		{
			honamiStoryEquipGridItem.Refresh(honamiStoryEquipGridItem.GetData(), -1);
		}
	}

	// Token: 0x0600C5AF RID: 50607 RVA: 0x003AD6B8 File Offset: 0x003AB8B8
	private void OnClickedMore()
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (backpackLogicState == EHonamiStoryBackpackLogicState.Normal)
		{
			if (this.OnMoreClickedCb != null)
			{
				this.OnMoreClickedCb(this);
				return;
			}
		}
		else if (backpackLogicState == EHonamiStoryBackpackLogicState.Tips || backpackLogicState == EHonamiStoryBackpackLogicState.TipsWithPlugins)
		{
			HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
			if (backpackLogic == null)
			{
				return;
			}
			backpackLogic.CloseTips();
		}
	}

	// Token: 0x0600C5B0 RID: 50608 RVA: 0x003AD704 File Offset: 0x003AB904
	private void OnRoleItemClicked()
	{
		bool flag = this.CheckChangeRoleFunctionOpen();
		bool flag2 = HonamiStoryUtil.CheckInHonamiStoryDungeon();
		HonamiStoryModel.Instance.AddLevel = new int[]
		{
			90,
			90
		};
		if (flag2 || !flag)
		{
			this.HandleSpecialRoleSelected();
			return;
		}
		this.HandleNormalRoleSelected();
	}

	// Token: 0x0600C5B1 RID: 50609 RVA: 0x003AD74C File Offset: 0x003AB94C
	private void ConfirmCallback(int targetRoleId)
	{
		HonamiStoryModel.Instance.AddLevel = new int[]
		{
			-1,
			-1
		};
		int[] allRoleIdList = HonamiStoryModel.Instance.GetAllRoleIdList();
		int roleId = this.RoleEquipData.GetRoleId();
		if (roleId == targetRoleId)
		{
			int num = allRoleIdList.IndexOf(roleId);
			if (num != -1)
			{
				allRoleIdList[num] = 0;
			}
		}
		else
		{
			bool roleEquipDataByRoleId = HonamiStoryModel.Instance.GetRoleEquipDataByRoleId(targetRoleId) != null;
			int num2 = allRoleIdList.IndexOf(targetRoleId);
			int num3 = allRoleIdList.IndexOf(roleId);
			if (roleEquipDataByRoleId)
			{
				allRoleIdList[num2] = roleId;
			}
			allRoleIdList[num3] = targetRoleId;
		}
		HonamiStoryController.Instance.RequestHonamiStoryEquipRole(allRoleIdList);
	}

	// Token: 0x0600C5B2 RID: 50610 RVA: 0x003AD7D0 File Offset: 0x003AB9D0
	[NullableContext(2)]
	private string GetConfirmButtonTextFunction(int roleConfigId)
	{
		if (roleConfigId == 0)
		{
			return null;
		}
		int roleId = this.RoleEquipData.GetRoleId();
		if (roleId == 0)
		{
			return "JoinText";
		}
		if (roleId == roleConfigId)
		{
			return "GoDownText";
		}
		return "ChangeText";
	}

	// Token: 0x0600C5B3 RID: 50611 RVA: 0x003AD806 File Offset: 0x003ABA06
	private bool IsNeedRevive(int roleConfigId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleConfigId, true);
		return (roleDataById == null || !roleDataById.IsTrialRole()) && FormationModel.Instance.IsRoleDead(roleConfigId);
	}

	// Token: 0x0600C5B4 RID: 50612 RVA: 0x003AD834 File Offset: 0x003ABA34
	private bool CanJoinTeam(int roleId)
	{
		int num = this.CheckChangeRoleFunctionOpen() ? 1 : 0;
		bool flag = HonamiStoryUtil.CheckInHonamiStoryDungeon();
		if (num == 0 || flag)
		{
			return false;
		}
		int roleId2 = this.RoleEquipData.GetRoleId();
		if (roleId == roleId2)
		{
			return true;
		}
		RoleModel instance = RoleModel.Instance;
		RoleDataBase roleDataBase = (instance != null) ? instance.GetRoleDataById(roleId, true) : null;
		if (FormationModel.Instance.IsRoleDead(roleId) && (roleDataBase == null || !roleDataBase.IsTrialRole()))
		{
			return false;
		}
		for (int i = 0; i < 3; i++)
		{
			HonamiStoryRoleEquipData roleEquipDataByPosition = HonamiStoryModel.Instance.GetRoleEquipDataByPosition(i);
			int num2 = (roleEquipDataByPosition != null) ? roleEquipDataByPosition.GetRoleId() : 0;
			RoleModel instance2 = RoleModel.Instance;
			RoleDataBase roleDataBase2 = (instance2 != null) ? instance2.GetRoleDataById(num2, true) : null;
			if (roleDataBase2 != null && roleDataBase2.IsTrialRole())
			{
				RoleConfig instance3 = RoleConfig.Instance;
				TrialRoleInfo? trialRoleInfo = (instance3 != null) ? instance3.GetTrialRoleConfig(num2) : null;
				if (trialRoleInfo != null && trialRoleInfo.Value.ParentId == roleId)
				{
					return false;
				}
			}
			if (roleDataBase != null && roleDataBase.IsTrialRole())
			{
				RoleConfig instance4 = RoleConfig.Instance;
				TrialRoleInfo? trialRoleInfo2 = (instance4 != null) ? instance4.GetTrialRoleConfig(roleId) : null;
				if (trialRoleInfo2 != null && num2 == trialRoleInfo2.Value.ParentId)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600C5B5 RID: 50613 RVA: 0x003AD970 File Offset: 0x003ABB70
	private void OnBackCallback()
	{
		int[] allRoleIdList = HonamiStoryModel.Instance.GetAllRoleIdList();
		for (int i = 0; i < allRoleIdList.Length; i++)
		{
			RoleModel instance = RoleModel.Instance;
			RoleDataBase roleDataBase = (instance != null) ? instance.GetRoleDataById(allRoleIdList[i], true) : null;
			if (roleDataBase == null || !roleDataBase.IsTrialRole())
			{
				RoleModel instance2 = RoleModel.Instance;
				if (((instance2 != null) ? instance2.GetRoleInstanceById(allRoleIdList[i]) : null) == null)
				{
					HonamiStoryModel.Instance.UpdateRoleByPosition(0, i);
				}
			}
		}
		this.RefreshRoleItem();
		HonamiStoryModel.Instance.AddLevel = new int[]
		{
			-1,
			-1
		};
	}

	// Token: 0x0600C5B6 RID: 50614 RVA: 0x003AD9FC File Offset: 0x003ABBFC
	private bool CheckChangeRoleFunctionOpen()
	{
		return FunctionModel.Instance.IsOpen(10111);
	}

	// Token: 0x0600C5B7 RID: 50615 RVA: 0x003ADA10 File Offset: 0x003ABC10
	private void HandleSpecialRoleSelected()
	{
		bool isInDungeon = HonamiStoryUtil.CheckInHonamiStoryDungeon();
		int roleId2 = this.RoleEquipData.GetRoleId();
		int position = this.RoleEquipData.GetPosition();
		int[] allRoleIdList = HonamiStoryModel.Instance.GetAllRoleIdList();
		List<RoleDataBase> list = new List<RoleDataBase>();
		foreach (int id in allRoleIdList)
		{
			RoleModel instance = RoleModel.Instance;
			RoleDataBase roleDataBase = (instance != null) ? instance.GetRoleDataById(id, true) : null;
			if (roleDataBase != null)
			{
				list.Add(roleDataBase);
			}
		}
		TeamRoleSelectViewData teamRoleSelectViewData = new TeamRoleSelectViewData(EFilterSortGroupId.EditFormation, roleId2, list, null, null, new int?(position + 1), null);
		teamRoleSelectViewData.FormationRoleList = allRoleIdList;
		teamRoleSelectViewData.IsNeedRevive = new Func<int, bool>(this.IsNeedRevive);
		teamRoleSelectViewData.BackCallBack = new Action(this.OnBackCallback);
		teamRoleSelectViewData.ForFunction = ETeamRoleUseFunction.HonamiStory;
		teamRoleSelectViewData.ShowLockPanel = ((int roleId) => true);
		teamRoleSelectViewData.GetLockTextCallBack = delegate(int roleId)
		{
			if (isInDungeon)
			{
				return "HonamiStory_UnableSwitch1";
			}
			return "HonamiStory_UnableSwitch2";
		};
		RoleController.Instance.OpenTeamRoleSelectView(teamRoleSelectViewData);
		AudioSystem.Instance.PostEvent("play_ui_honamistory_roleselect_page_start");
	}

	// Token: 0x0600C5B8 RID: 50616 RVA: 0x003ADB44 File Offset: 0x003ABD44
	private unsafe void HandleNormalRoleSelected()
	{
		int roleId = this.RoleEquipData.GetRoleId();
		int position = this.RoleEquipData.GetPosition();
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(false);
		if (activityData == null)
		{
			return;
		}
		InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
		InstanceDungeon? instanceDungeon = (instance != null) ? instance.GetConfig(activityData.AreaInstId) : null;
		if (instanceDungeon == null)
		{
			return;
		}
		FormationConfig instance2 = FormationConfig.Instance;
		FightFormation? fightFormation = (instance2 != null) ? instance2.GetFightFormationConfig(instanceDungeon.Value.FightFormationId) : null;
		if (fightFormation == null)
		{
			return;
		}
		Log instance3 = Log.Instance;
		ELogModule module = ELogModule.HonamiStory;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "OnRoleItemClicked 编队配置信息";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dungeonId", activityData.AreaInstId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("formationId", instanceDungeon.Value.FightFormationId);
		instance3.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		int[] array = fightFormation.Value.TrialRole();
		int[] array2 = fightFormation.Value.LimitRole();
		List<int> list = new List<int>();
		List<RoleDataBase> list2 = new List<RoleDataBase>();
		foreach (int num in array2)
		{
			RoleModel instance4 = RoleModel.Instance;
			RoleInstance roleInstance = (instance4 != null) ? instance4.GetRoleInstanceById(num) : null;
			if (roleInstance != null)
			{
				list.Add(num);
				list2.Add(roleInstance);
			}
		}
		foreach (int id in array)
		{
			RoleConfig instance5 = RoleConfig.Instance;
			TrialRoleInfo? trialRoleInfo = (instance5 != null) ? instance5.GetTrialRoleConfigByGroupId(id) : null;
			if (trialRoleInfo != null)
			{
				int parentId = trialRoleInfo.Value.ParentId;
				if (!list.Contains(parentId))
				{
					RoleModel instance6 = RoleModel.Instance;
					RoleDataBase roleDataBase = (instance6 != null) ? instance6.GetRoleDataById(trialRoleInfo.Value.Id, true) : null;
					if (roleDataBase != null)
					{
						list2.Add(roleDataBase);
					}
				}
			}
		}
		list2.Sort(delegate(RoleDataBase a, RoleDataBase b)
		{
			if (!a.IsTrialRole())
			{
				return -1;
			}
			return 1;
		});
		TeamRoleSelectViewData teamRoleSelectViewData = new TeamRoleSelectViewData(EFilterSortGroupId.EditFormation, roleId, list2, new Action<int>(this.ConfirmCallback), null, new int?(position + 1), null);
		teamRoleSelectViewData.FormationRoleList = HonamiStoryModel.Instance.GetAllRoleIdList();
		teamRoleSelectViewData.IsNeedRevive = new Func<int, bool>(this.IsNeedRevive);
		teamRoleSelectViewData.GetConfirmButtonTextCallBack = new Func<int, string>(this.GetConfirmButtonTextFunction);
		teamRoleSelectViewData.GetConfirmButtonEnableCallBack = new Func<int, bool>(this.CanJoinTeam);
		teamRoleSelectViewData.CanJoinTeam = new Func<int, bool>(this.CanJoinTeam);
		teamRoleSelectViewData.BackCallBack = new Action(this.OnBackCallback);
		teamRoleSelectViewData.ForFunction = ETeamRoleUseFunction.HonamiStory;
		RoleController.Instance.OpenTeamRoleSelectView(teamRoleSelectViewData);
		AudioSystem.Instance.PostEvent("play_ui_honamistory_roleselect_page_start");
	}

	// Token: 0x0600C5B9 RID: 50617 RVA: 0x003ADE44 File Offset: 0x003AC044
	private void OnClickedWeaponItem(HonamiStoryWeaponToggleItem selectedWeaponItem)
	{
		int weaponId = this.RoleEquipData.GetWeaponId();
		bool flag = HonamiStoryUtil.CheckInHonamiStoryDungeon();
		if (weaponId <= 0 && flag)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_NoWeaponEquip", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryWeaponSelectView, this.RoleEquipData, null);
		HonamiStoryWeaponToggleItem weaponItem = this.WeaponItem;
		if (weaponItem == null)
		{
			return;
		}
		weaponItem.ResetToggleState();
	}

	// Token: 0x0600C5BA RID: 50618 RVA: 0x003ADEA7 File Offset: 0x003AC0A7
	private void OnAfterClickedWeaponItem()
	{
		HonamiStoryWeaponToggleItem weaponItem = this.WeaponItem;
		if (weaponItem == null)
		{
			return;
		}
		weaponItem.SetNewItemShow(false);
	}

	// Token: 0x0600C5BB RID: 50619 RVA: 0x003ADEBC File Offset: 0x003AC0BC
	private void RefreshWeaponItem()
	{
		int weaponId = this.RoleEquipData.GetWeaponId();
		HonamiStoryWeaponToggleItemData data = new HonamiStoryWeaponToggleItemData
		{
			WeaponId = weaponId,
			EquipData = this.RoleEquipData,
			UseWay = EHonamiStoryWeaponUseWay.Equip
		};
		HonamiStoryWeaponToggleItem weaponItem = this.WeaponItem;
		if (weaponItem == null)
		{
			return;
		}
		weaponItem.Refresh(data, false, 0);
	}

	// Token: 0x0600C5BC RID: 50620 RVA: 0x003ADF08 File Offset: 0x003AC108
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public ValueTuple<UUIItem, UUIItem>? GuideFindPluginItemWithId(int id)
	{
		foreach (HonamiStoryEquipGridItem honamiStoryEquipGridItem in this.RolePluginItemList)
		{
			HonamiStoryItemDataBase data = honamiStoryEquipGridItem.GetData();
			if (data != null && data.GetItemId() == id)
			{
				HonamiStoryItemGridItem itemGridItem = honamiStoryEquipGridItem.GetItemGridItem();
				UUIItem uuiitem = (itemGridItem != null) ? itemGridItem.GetRootItem() : null;
				if (uuiitem == null)
				{
					return null;
				}
				return new ValueTuple<UUIItem, UUIItem>?(new ValueTuple<UUIItem, UUIItem>(uuiitem, uuiitem));
			}
		}
		return null;
	}

	// Token: 0x0600C5BD RID: 50621 RVA: 0x003ADFA8 File Offset: 0x003AC1A8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (configParams[0] == "AddBtn")
		{
			foreach (HonamiStoryEquipGridItem honamiStoryEquipGridItem in this.RolePluginItemList)
			{
				UUIItem[] guideUiItemAndUiItemForShowEx = honamiStoryEquipGridItem.GetGuideUiItemAndUiItemForShowEx(configParams);
				if (guideUiItemAndUiItemForShowEx != null && guideUiItemAndUiItemForShowEx.Length != 0)
				{
					return guideUiItemAndUiItemForShowEx;
				}
			}
		}
		return null;
	}

	// Token: 0x04007090 RID: 28816
	[Nullable(2)]
	public Action<HonamiStoryItemGridItem> OnEnterGridCb;

	// Token: 0x04007091 RID: 28817
	[Nullable(2)]
	public Action OnExitGridCb;

	// Token: 0x04007092 RID: 28818
	[Nullable(2)]
	public Action OnDownGridCb;

	// Token: 0x04007093 RID: 28819
	[Nullable(new byte[]
	{
		2,
		2,
		1,
		1
	})]
	public Action<HonamiStoryItemGridItem, Vector2D, Vector2D> OnClickedGridCb;

	// Token: 0x04007094 RID: 28820
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<HonamiStoryRoleEquipItem> OnMoreClickedCb;

	// Token: 0x04007095 RID: 28821
	private HonamiStoryBackpackPanelBase Panel;

	// Token: 0x04007096 RID: 28822
	private readonly List<HonamiStoryEquipGridItem> RolePluginItemList = new List<HonamiStoryEquipGridItem>();

	// Token: 0x04007097 RID: 28823
	[Nullable(2)]
	private HonamiStoryWeaponToggleItem WeaponItem;

	// Token: 0x04007098 RID: 28824
	private bool IsRoleTipsOpen;

	// Token: 0x04007099 RID: 28825
	private HonamiStoryRoleEquipData RoleEquipData;

	// Token: 0x02007609 RID: 30217
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402654C RID: 157004
		BtnHead,
		// Token: 0x0402654D RID: 157005
		SpriteRoleEmpty,
		// Token: 0x0402654E RID: 157006
		TexRole,
		// Token: 0x0402654F RID: 157007
		WeaponItem,
		// Token: 0x04026550 RID: 157008
		PluginRoot,
		// Token: 0x04026551 RID: 157009
		BtnMore
	}
}

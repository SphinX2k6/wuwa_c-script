using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EAF RID: 7855
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryRoleEquipItem : UiPanelBase
{
	// Token: 0x0600F177 RID: 61815 RVA: 0x003A14C5 File Offset: 0x0039F6C5
	public HonamiStoryRoleEquipItem(HonamiStoryRoleEquipData roleEquipData)
	{
		this.RoleEquipData = roleEquipData;
	}

	// Token: 0x0600F178 RID: 61816 RVA: 0x003A14DF File Offset: 0x0039F6DF
	public void RegisterPanel(HonamiStoryBackpackPanelBase panel)
	{
		this.Panel = panel;
	}

	// Token: 0x0600F179 RID: 61817 RVA: 0x003A14E8 File Offset: 0x0039F6E8
	public HonamiStoryRoleEquipData GetRoleEquipData()
	{
		return this.RoleEquipData;
	}

	// Token: 0x0600F17A RID: 61818 RVA: 0x003A14F0 File Offset: 0x0039F6F0
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

	// Token: 0x0600F17B RID: 61819 RVA: 0x003A15C8 File Offset: 0x0039F7C8
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryRoleEquipItem.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryRoleEquipItem.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F17C RID: 61820 RVA: 0x003A160B File Offset: 0x0039F80B
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnHonamiStoryBackpackClickWeapon, new Action(this.OnAfterClickedWeaponItem));
	}

	// Token: 0x0600F17D RID: 61821 RVA: 0x003A1629 File Offset: 0x0039F829
	protected override void OnBeforeShow()
	{
		this.RefreshRoleItem();
		this.RefreshWeaponItem();
		this.RefreshBtnMoreVisible();
	}

	// Token: 0x0600F17E RID: 61822 RVA: 0x003A163D File Offset: 0x0039F83D
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnHonamiStoryBackpackClickWeapon, new Action(this.OnAfterClickedWeaponItem));
	}

	// Token: 0x0600F17F RID: 61823 RVA: 0x003A165C File Offset: 0x0039F85C
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

	// Token: 0x0600F180 RID: 61824 RVA: 0x003A1720 File Offset: 0x0039F920
	private UniTask InitRolePluginItemList()
	{
		HonamiStoryRoleEquipItem.<InitRolePluginItemList>d__20 <InitRolePluginItemList>d__;
		<InitRolePluginItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRolePluginItemList>d__.<>4__this = this;
		<InitRolePluginItemList>d__.<>1__state = -1;
		<InitRolePluginItemList>d__.<>t__builder.Start<HonamiStoryRoleEquipItem.<InitRolePluginItemList>d__20>(ref <InitRolePluginItemList>d__);
		return <InitRolePluginItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600F181 RID: 61825 RVA: 0x003A1764 File Offset: 0x0039F964
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

	// Token: 0x0600F182 RID: 61826 RVA: 0x003A17B0 File Offset: 0x0039F9B0
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

	// Token: 0x0600F183 RID: 61827 RVA: 0x003A17FC File Offset: 0x0039F9FC
	private UniTask RefreshPluginItemList()
	{
		HonamiStoryRoleEquipItem.<RefreshPluginItemList>d__23 <RefreshPluginItemList>d__;
		<RefreshPluginItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshPluginItemList>d__.<>4__this = this;
		<RefreshPluginItemList>d__.<>1__state = -1;
		<RefreshPluginItemList>d__.<>t__builder.Start<HonamiStoryRoleEquipItem.<RefreshPluginItemList>d__23>(ref <RefreshPluginItemList>d__);
		return <RefreshPluginItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600F184 RID: 61828 RVA: 0x003A1840 File Offset: 0x0039FA40
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

	// Token: 0x0600F185 RID: 61829 RVA: 0x003A1884 File Offset: 0x0039FA84
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

	// Token: 0x0600F186 RID: 61830 RVA: 0x003A18E8 File Offset: 0x0039FAE8
	public List<HonamiStoryEquipGridItem> GetPluginItemList()
	{
		return this.RolePluginItemList;
	}

	// Token: 0x0600F187 RID: 61831 RVA: 0x003A18F0 File Offset: 0x0039FAF0
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

	// Token: 0x0600F188 RID: 61832 RVA: 0x003A1934 File Offset: 0x0039FB34
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

	// Token: 0x0600F189 RID: 61833 RVA: 0x003A1978 File Offset: 0x0039FB78
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

	// Token: 0x0600F18A RID: 61834 RVA: 0x003A19CC File Offset: 0x0039FBCC
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

	// Token: 0x0600F18B RID: 61835 RVA: 0x003A19DF File Offset: 0x0039FBDF
	private void OnExitGrid()
	{
		Action onExitGridCb = this.OnExitGridCb;
		if (onExitGridCb == null)
		{
			return;
		}
		onExitGridCb();
	}

	// Token: 0x0600F18C RID: 61836 RVA: 0x003A19F1 File Offset: 0x0039FBF1
	private void OnDownGrid()
	{
		Action onDownGridCb = this.OnDownGridCb;
		if (onDownGridCb == null)
		{
			return;
		}
		onDownGridCb();
	}

	// Token: 0x0600F18D RID: 61837 RVA: 0x003A1A03 File Offset: 0x0039FC03
	private void OnClickedGrid([Nullable(2)] HonamiStoryItemGridItem item, Vector2D loc, Vector2D size)
	{
		Action<HonamiStoryItemGridItem, Vector2D, Vector2D> onClickedGridCb = this.OnClickedGridCb;
		if (onClickedGridCb == null)
		{
			return;
		}
		onClickedGridCb(item, loc, size);
	}

	// Token: 0x0600F18E RID: 61838 RVA: 0x003A1A18 File Offset: 0x0039FC18
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

	// Token: 0x0600F18F RID: 61839 RVA: 0x003A1B58 File Offset: 0x0039FD58
	public void RefreshState(EHonamiStoryBackpackLogicState state)
	{
		foreach (HonamiStoryEquipGridItem honamiStoryEquipGridItem in this.RolePluginItemList)
		{
			honamiStoryEquipGridItem.Refresh(honamiStoryEquipGridItem.GetData(), -1);
		}
	}

	// Token: 0x0600F190 RID: 61840 RVA: 0x003A1BB0 File Offset: 0x0039FDB0
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

	// Token: 0x0600F191 RID: 61841 RVA: 0x003A1BFC File Offset: 0x0039FDFC
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

	// Token: 0x0600F192 RID: 61842 RVA: 0x003A1C44 File Offset: 0x0039FE44
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
		HonamiStoryController.Instance.RequestHonamiStoryEquipRole(allRoleIdList.ToList<int>());
	}

	// Token: 0x0600F193 RID: 61843 RVA: 0x003A1CD0 File Offset: 0x0039FED0
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

	// Token: 0x0600F194 RID: 61844 RVA: 0x003A1D06 File Offset: 0x0039FF06
	private bool IsNeedRevive(int roleConfigId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleConfigId, true);
		return (roleDataById == null || !roleDataById.IsTrialRole()) && FormationModel.Instance.IsRoleDead(roleConfigId);
	}

	// Token: 0x0600F195 RID: 61845 RVA: 0x003A1D34 File Offset: 0x0039FF34
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

	// Token: 0x0600F196 RID: 61846 RVA: 0x003A1E70 File Offset: 0x003A0070
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

	// Token: 0x0600F197 RID: 61847 RVA: 0x003A1EFC File Offset: 0x003A00FC
	private bool CheckChangeRoleFunctionOpen()
	{
		return FunctionModel.Instance.IsOpen(10111);
	}

	// Token: 0x0600F198 RID: 61848 RVA: 0x003A1F10 File Offset: 0x003A0110
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

	// Token: 0x0600F199 RID: 61849 RVA: 0x003A2044 File Offset: 0x003A0244
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

	// Token: 0x0600F19A RID: 61850 RVA: 0x003A2344 File Offset: 0x003A0544
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

	// Token: 0x0600F19B RID: 61851 RVA: 0x003A23A7 File Offset: 0x003A05A7
	private void OnAfterClickedWeaponItem()
	{
		HonamiStoryWeaponToggleItem weaponItem = this.WeaponItem;
		if (weaponItem == null)
		{
			return;
		}
		weaponItem.SetNewItemShow(false);
	}

	// Token: 0x0600F19C RID: 61852 RVA: 0x003A23BC File Offset: 0x003A05BC
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

	// Token: 0x0600F19D RID: 61853 RVA: 0x003A2408 File Offset: 0x003A0608
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

	// Token: 0x0600F19E RID: 61854 RVA: 0x003A24A8 File Offset: 0x003A06A8
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

	// Token: 0x04006FAF RID: 28591
	[Nullable(2)]
	public Action<HonamiStoryItemGridItem> OnEnterGridCb;

	// Token: 0x04006FB0 RID: 28592
	[Nullable(2)]
	public Action OnExitGridCb;

	// Token: 0x04006FB1 RID: 28593
	[Nullable(2)]
	public Action OnDownGridCb;

	// Token: 0x04006FB2 RID: 28594
	[Nullable(new byte[]
	{
		2,
		2,
		1,
		1
	})]
	public Action<HonamiStoryItemGridItem, Vector2D, Vector2D> OnClickedGridCb;

	// Token: 0x04006FB3 RID: 28595
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<HonamiStoryRoleEquipItem> OnMoreClickedCb;

	// Token: 0x04006FB4 RID: 28596
	private HonamiStoryBackpackPanelBase Panel;

	// Token: 0x04006FB5 RID: 28597
	private readonly List<HonamiStoryEquipGridItem> RolePluginItemList = new List<HonamiStoryEquipGridItem>();

	// Token: 0x04006FB6 RID: 28598
	[Nullable(2)]
	private HonamiStoryWeaponToggleItem WeaponItem;

	// Token: 0x04006FB7 RID: 28599
	private bool IsRoleTipsOpen;

	// Token: 0x04006FB8 RID: 28600
	private HonamiStoryRoleEquipData RoleEquipData;

	// Token: 0x02008484 RID: 33924
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B228 RID: 176680
		BtnHead,
		// Token: 0x0402B229 RID: 176681
		SpriteRoleEmpty,
		// Token: 0x0402B22A RID: 176682
		TexRole,
		// Token: 0x0402B22B RID: 176683
		WeaponItem,
		// Token: 0x0402B22C RID: 176684
		PluginRoot,
		// Token: 0x0402B22D RID: 176685
		BtnMore
	}
}

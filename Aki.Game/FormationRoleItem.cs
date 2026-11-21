using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010CC RID: 4300
[NullableContext(2)]
[Nullable(0)]
public class FormationRoleItem : FormationSlotBase
{
	// Token: 0x170011D3 RID: 4563
	// (get) Token: 0x0600AAE6 RID: 43750 RVA: 0x00325E2F File Offset: 0x0032402F
	[Nullable(1)]
	protected override string LogTag { [NullableContext(1)] get; } = "FormationRoleItem";

	// Token: 0x170011D4 RID: 4564
	// (get) Token: 0x0600AAE7 RID: 43751 RVA: 0x00325E38 File Offset: 0x00324038
	private FormationRoleDragAvatarItem ReadyDragAvatarItem
	{
		get
		{
			FormationRoleDragAvatarItem dragAvatarItem = this.DragAvatarItem;
			if (dragAvatarItem == null || !dragAvatarItem.IsStart)
			{
				return null;
			}
			return dragAvatarItem;
		}
	}

	// Token: 0x0600AAE8 RID: 43752 RVA: 0x00325E5A File Offset: 0x0032405A
	[NullableContext(1)]
	public FormationRoleItem(int position, IFormationProvider provider) : base(position, provider)
	{
		this.SkillBranchToggleHandler = new FormationSkillBranchToggleHandler(() => this.ModeToggleItem);
	}

	// Token: 0x0600AAE9 RID: 43753 RVA: 0x00325E90 File Offset: 0x00324090
	protected unsafe override void OnRegisterComponent()
	{
		int num = 25;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIDraggableComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(base.OnClickChooseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600AAEA RID: 43754 RVA: 0x00326240 File Offset: 0x00324440
	protected override UniTask OnBeforeStartAsync()
	{
		FormationRoleItem.<OnBeforeStartAsync>d__31 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FormationRoleItem.<OnBeforeStartAsync>d__31>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AAEB RID: 43755 RVA: 0x00326284 File Offset: 0x00324484
	protected override void OnStart()
	{
		this.SceneRoleActor = UiSceneManager.Instance.InitRoleFormationActor(EUiModelUseWay.RoleInFormation);
		this.SceneRoleActor.Model.CheckGetComponent<UiFormationRoleDataComponent>().Position = this.Position;
		this.SceneRoleActor.Model.CheckGetComponent<UiRoleOrnamentComponent>().FollowRoleVisibility = true;
		this.SetModelLoadingAnchor(null);
		EventSystem.Instance.Add<int>(EEventName.WeaponRoleEquipChanged, new Action<int>(this.OnRoleWeaponChanged));
		EventSystem.Instance.Add<int, int>(EEventName.FightWeaponSkinChange, new Action<int, int>(this.OnRoleWeaponSkinChanged));
		EventSystem.Instance.Add(EEventName.OnOrnamentChange, new Action(this.OnRoleOrnamentChanged));
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.SkillBranchToggleHandler.OnRoleSkillBranchChanged));
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.SkillBranchToggleHandler.OnRoleSkillBranchChanged));
		base.BindDragCallbacks(base.GetDraggable(22));
		this.BindHoverCallbacks();
		this.StartSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.CloseSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600AAEC RID: 43756 RVA: 0x003263A7 File Offset: 0x003245A7
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		this.IsHovering = false;
		this.StopFormation3DHoverEffect();
		this.StopFormation3DDeployEffect();
	}

	// Token: 0x0600AAED RID: 43757 RVA: 0x003263C4 File Offset: 0x003245C4
	protected override void OnBeforeDestroy()
	{
		this.ResolvePendingModelLoad();
		this.UnbindHoverCallbacks();
		this.IsHovering = false;
		this.StopFormation3DHoverEffect();
		this.StopFormation3DDeployEffect();
		EventSystem.Instance.Remove<int>(EEventName.WeaponRoleEquipChanged, new Action<int>(this.OnRoleWeaponChanged));
		EventSystem.Instance.Remove<int, int>(EEventName.FightWeaponSkinChange, new Action<int, int>(this.OnRoleWeaponSkinChanged));
		EventSystem.Instance.Remove(EEventName.OnOrnamentChange, new Action(this.OnRoleOrnamentChanged));
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.SkillBranchToggleHandler.OnRoleSkillBranchChanged));
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.SkillBranchToggleHandler.OnRoleSkillBranchChanged));
		base.OnBeforeDestroy();
		UiSceneManager.Instance.DestroyRoleFormationActor(this.SceneRoleActor);
		this.SkillBranchToggleHandler.Clear();
		this.ModeToggleItem = null;
		this.DestroyDragAvatarItem();
		LevelSequencePlayer startSequencePlayer = this.StartSequencePlayer;
		if (startSequencePlayer != null)
		{
			startSequencePlayer.Clear();
		}
		this.StartSequencePlayer = null;
		LevelSequencePlayer closeSequencePlayer = this.CloseSequencePlayer;
		if (closeSequencePlayer != null)
		{
			closeSequencePlayer.Clear();
		}
		this.CloseSequencePlayer = null;
	}

	// Token: 0x0600AAEE RID: 43758 RVA: 0x003264E8 File Offset: 0x003246E8
	public void DestroyDragAvatarItem()
	{
		FormationRoleDragAvatarItem dragAvatarItem = this.DragAvatarItem;
		this.DragAvatarItem = null;
		if (dragAvatarItem != null && !dragAvatarItem.IsDestroyOrDestroying)
		{
			dragAvatarItem.Destroy(null);
		}
	}

	// Token: 0x0600AAEF RID: 43759 RVA: 0x00326518 File Offset: 0x00324718
	public void SetSlotVisibleWithSequence(bool visible, bool immediateHide = false)
	{
		if (this.IsSlotVisible == visible)
		{
			return;
		}
		this.IsSlotVisible = visible;
		if (visible)
		{
			base.SetUiActive(true);
			this.PlayStartSequence();
			return;
		}
		LevelSequencePlayer startSequencePlayer = this.StartSequencePlayer;
		if (startSequencePlayer != null)
		{
			startSequencePlayer.StopSequenceByKey("Start", false, true);
		}
		if (immediateHide)
		{
			LevelSequencePlayer closeSequencePlayer = this.CloseSequencePlayer;
			if (closeSequencePlayer == null)
			{
				return;
			}
			closeSequencePlayer.PlayLevelSequenceByName("Close", false, null, true);
			return;
		}
		else
		{
			LevelSequencePlayer closeSequencePlayer2 = this.CloseSequencePlayer;
			if (closeSequencePlayer2 == null)
			{
				return;
			}
			closeSequencePlayer2.PlayLevelSequenceByName("Close", false, null, false);
			return;
		}
	}

	// Token: 0x0600AAF0 RID: 43760 RVA: 0x003265A4 File Offset: 0x003247A4
	private void PlayStartSequence()
	{
		LevelSequencePlayer closeSequencePlayer = this.CloseSequencePlayer;
		if (closeSequencePlayer != null)
		{
			closeSequencePlayer.StopSequenceByKey("Close", false, false);
		}
		LevelSequencePlayer startSequencePlayer = this.StartSequencePlayer;
		if (startSequencePlayer != null && startSequencePlayer.IsPlayingSequence("Start"))
		{
			this.StartSequencePlayer.ReplaySequenceByKey("Start");
			return;
		}
		LevelSequencePlayer startSequencePlayer2 = this.StartSequencePlayer;
		if (startSequencePlayer2 == null)
		{
			return;
		}
		startSequencePlayer2.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600AAF1 RID: 43761 RVA: 0x00326613 File Offset: 0x00324813
	public void RequestStartSequenceOnRoleChanged()
	{
		this.NeedStartSequenceOnRoleChanged = true;
	}

	// Token: 0x0600AAF2 RID: 43762 RVA: 0x0032661C File Offset: 0x0032481C
	private void OnRoleWeaponChanged(int roleId)
	{
		if (this.IsSelfSlot)
		{
			int? configId = this.ConfigId;
			if (configId.GetValueOrDefault() == roleId & configId != null)
			{
				TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
				object obj;
				if (sceneRoleActor == null)
				{
					obj = null;
				}
				else
				{
					UiModelBase model = sceneRoleActor.Model;
					obj = ((model != null) ? model.CheckGetComponent<UiRoleWeaponComponent>() : null);
				}
				object obj2 = obj;
				if (obj2 == null)
				{
					return;
				}
				obj2.RefreshWeaponByRole();
				return;
			}
		}
	}

	// Token: 0x0600AAF3 RID: 43763 RVA: 0x00326677 File Offset: 0x00324877
	private void OnRoleWeaponSkinChanged(int roleId, int modelId)
	{
		this.OnRoleWeaponChanged(roleId);
	}

	// Token: 0x0600AAF4 RID: 43764 RVA: 0x00326680 File Offset: 0x00324880
	public void RefreshRoleOrnaments()
	{
		if (!this.IsSelfSlot || this.ConfigId == null)
		{
			return;
		}
		TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
		UiModelBase uiModelBase = (sceneRoleActor != null) ? sceneRoleActor.Model : null;
		UiRoleOrnamentComponent uiRoleOrnamentComponent = (uiModelBase != null) ? uiModelBase.CheckGetComponent<UiRoleOrnamentComponent>() : null;
		if (uiRoleOrnamentComponent == null)
		{
			return;
		}
		uiRoleOrnamentComponent.RefreshModels(null, false);
	}

	// Token: 0x0600AAF5 RID: 43765 RVA: 0x003266CD File Offset: 0x003248CD
	private void OnRoleOrnamentChanged()
	{
		TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
		UiModelBase uiModelBase = (sceneRoleActor != null) ? sceneRoleActor.Model : null;
		UiModelDataComponent uiModelDataComponent = (uiModelBase != null) ? uiModelBase.CheckGetComponent<UiModelDataComponent>() : null;
		if (uiModelDataComponent != null && uiModelDataComponent.GetVisible())
		{
			this.RefreshRoleOrnaments();
		}
	}

	// Token: 0x0600AAF6 RID: 43766 RVA: 0x00326704 File Offset: 0x00324904
	[NullableContext(1)]
	public override void Refresh(IRoleSlotDisplayData data)
	{
		int? num = this.ConfigId;
		int num2 = data.ConfigId;
		if (num.GetValueOrDefault() == num2 & num != null)
		{
			num = this.SkinId;
			num2 = data.SkinId;
			if (num.GetValueOrDefault() == num2 & num != null)
			{
				goto IL_4A;
			}
		}
		this.ResolvePendingModelLoad();
		IL_4A:
		this.RefreshRoleData(data);
	}

	// Token: 0x0600AAF7 RID: 43767 RVA: 0x00326764 File Offset: 0x00324964
	[NullableContext(0)]
	public UniTask<long?> RefreshAndWaitModelLoaded([Nullable(1)] IRoleSlotDisplayData data)
	{
		FormationRoleItem.<RefreshAndWaitModelLoaded>d__44 <RefreshAndWaitModelLoaded>d__;
		<RefreshAndWaitModelLoaded>d__.<>t__builder = AsyncUniTaskMethodBuilder<long?>.Create();
		<RefreshAndWaitModelLoaded>d__.<>4__this = this;
		<RefreshAndWaitModelLoaded>d__.data = data;
		<RefreshAndWaitModelLoaded>d__.<>1__state = -1;
		<RefreshAndWaitModelLoaded>d__.<>t__builder.Start<FormationRoleItem.<RefreshAndWaitModelLoaded>d__44>(ref <RefreshAndWaitModelLoaded>d__);
		return <RefreshAndWaitModelLoaded>d__.<>t__builder.Task;
	}

	// Token: 0x0600AAF8 RID: 43768 RVA: 0x003267B0 File Offset: 0x003249B0
	[NullableContext(1)]
	private void RefreshRoleData(IRoleSlotDisplayData data)
	{
		if (data.ConfigId == 0)
		{
			this.ResetRole();
			return;
		}
		int? num = this.ConfigId;
		int num2 = data.ConfigId;
		bool flag;
		if (num.GetValueOrDefault() == num2 & num != null)
		{
			num = this.SkinId;
			num2 = data.SkinId;
			flag = !(num.GetValueOrDefault() == num2 & num != null);
		}
		else
		{
			flag = true;
		}
		bool flag2 = flag;
		if (this.NeedStartSequenceOnRoleChanged && this.IsSlotVisible)
		{
			num = this.ConfigId;
			num2 = data.ConfigId;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				this.PlayStartSequence();
			}
		}
		this.NeedStartSequenceOnRoleChanged = false;
		num = this.ConfigId;
		num2 = data.ConfigId;
		bool flag3 = !(num.GetValueOrDefault() == num2 & num != null) && !this.InDragMode;
		num2 = this.RoleRefreshSerial + 1;
		this.RoleRefreshSerial = num2;
		int refreshSerial = num2;
		bool flag4 = this.NeedDeployEffectOnNextRefresh || (flag2 && !this.IsRoleSelectPreviewMode);
		this.NeedDeployEffectOnNextRefresh = false;
		if (flag3 || flag4)
		{
			this.StopFormation3DHoverEffect();
		}
		this.RefreshRoleDataInternal(data, flag4, flag3, refreshSerial);
	}

	// Token: 0x0600AAF9 RID: 43769 RVA: 0x003268DC File Offset: 0x00324ADC
	[NullableContext(1)]
	private void RefreshRoleDataInternal(IRoleSlotDisplayData data, bool needPlayDeployEffect, bool needRoleChangeEffect, int refreshSerial)
	{
		FormationRoleItem.<>c__DisplayClass46_0 CS$<>8__locals1 = new FormationRoleItem.<>c__DisplayClass46_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.data = data;
		CS$<>8__locals1.refreshSerial = refreshSerial;
		CS$<>8__locals1.needRoleChangeEffect = needRoleChangeEffect;
		CS$<>8__locals1.needPlayDeployEffect = needPlayDeployEffect;
		this.ConfigId = new int?(CS$<>8__locals1.data.ConfigId);
		this.SkinId = new int?(CS$<>8__locals1.data.SkinId);
		this.PlayerInternal = new int?(CS$<>8__locals1.data.PlayerId);
		this.OnlineIndex = new int?(CS$<>8__locals1.data.OnlineIndex);
		this.IsSelfSlot = CS$<>8__locals1.data.IsSelf;
		this.IsThirdPartyVisibleInternal = CS$<>8__locals1.data.IsThirdPartyVisible;
		this.RefreshPanelAdd();
		base.GetItem(4).SetUIActive(true);
		base.GetSprite(6).SetUIActive(false);
		this.RefreshDeadState(CS$<>8__locals1.data.IsDead);
		this.RefreshDeadStateForSpecialTrialRole(CS$<>8__locals1.data.ConfigId, CS$<>8__locals1.data.CanUseSpecialTrialRole);
		base.GetItem(3).SetUIActive(false);
		this.RefreshOnlineState(CS$<>8__locals1.data.OnlineIndex, CS$<>8__locals1.data.PlayerId, CS$<>8__locals1.data.IsSelf);
		this.RefreshThirdPartyItem(CS$<>8__locals1.data.ThirdPartyOnlineId);
		this.RefreshModeToggle(CS$<>8__locals1.data.ConfigId, CS$<>8__locals1.data.SkillBranch);
		this.RefreshElement(CS$<>8__locals1.data.ConfigId);
		base.RefreshName(CS$<>8__locals1.data.Name);
		base.RefreshLevel(CS$<>8__locals1.data.Level);
		this.RefreshInfoPanelOffset(new int?(CS$<>8__locals1.data.ConfigId), new int?(CS$<>8__locals1.data.SkinId));
		SlotExtensionRegistry.InvokeRefresh(this.Extensions, CS$<>8__locals1.data);
		FormationRoleEquip formationRoleEquip = (!CS$<>8__locals1.data.IsSelf) ? CS$<>8__locals1.data.Equip : null;
		CS$<>8__locals1.ornamentComponent = this.SceneRoleActor.Model.CheckGetComponent<UiRoleOrnamentComponent>();
		if (formationRoleEquip != null)
		{
			OrnamentModelContext[] array;
			if (formationRoleEquip.DressList.Length != 0)
			{
				int[] dressList = formationRoleEquip.DressList;
				array = new OrnamentModelContext[dressList.Length];
				for (int i = 0; i < dressList.Length; i++)
				{
					array[i] = UiModelUtil.BuildOrnamentModelContext(CS$<>8__locals1.data.SkinId, dressList[i]);
				}
			}
			else
			{
				array = new OrnamentModelContext[]
				{
					new OrnamentModelContext
					{
						ModelId = 0,
						HideInUi = true,
						OrnamentUiBuff = new List<long>(),
						EquipTags = new List<string>()
					}
				};
			}
			UiRoleOrnamentComponent ornamentComponent = CS$<>8__locals1.ornamentComponent;
			if (ornamentComponent != null)
			{
				ornamentComponent.SetPendingContexts(array);
			}
		}
		UiFormationRoleLoadComponent uiFormationRoleLoadComponent = this.SceneRoleActor.Model.CheckGetComponent<UiFormationRoleLoadComponent>();
		this.IsRoleModelLoading = true;
		if (CS$<>8__locals1.data.IsSelf)
		{
			uiFormationRoleLoadComponent.LoadModelByRoleDataId(CS$<>8__locals1.data.ConfigId, CS$<>8__locals1.data.SkinId, true, new Action(CS$<>8__locals1.<RefreshRoleDataInternal>g__OnModelLoadFinish|0));
		}
		else
		{
			uiFormationRoleLoadComponent.LoadModelByRoleConfigId(CS$<>8__locals1.data.ConfigId, CS$<>8__locals1.data.SkinId, true, new Action(CS$<>8__locals1.<RefreshRoleDataInternal>g__OnModelLoadFinish|0));
		}
		if (formationRoleEquip != null && formationRoleEquip.WeaponId > 0)
		{
			UiRoleWeaponComponent uiRoleWeaponComponent = this.SceneRoleActor.Model.CheckGetComponent<UiRoleWeaponComponent>();
			TeammateWeaponSnapshotData teammateWeaponSnapshotData = new TeammateWeaponSnapshotData(formationRoleEquip.WeaponId, formationRoleEquip.WeaponBreachLevel);
			teammateWeaponSnapshotData.SetRoleId(CS$<>8__locals1.data.ConfigId);
			int weaponSkinId = (formationRoleEquip.WeaponSkinId > 0) ? formationRoleEquip.WeaponSkinId : -1;
			int num = (uiRoleWeaponComponent != null) ? uiRoleWeaponComponent.GetWeaponCount() : 0;
			if (uiRoleWeaponComponent != null)
			{
				uiRoleWeaponComponent.RefreshWeaponCase();
			}
			if (uiRoleWeaponComponent != null)
			{
				uiRoleWeaponComponent.SetWeaponByWeaponData(teammateWeaponSnapshotData, weaponSkinId);
			}
			if (num == 0 && uiRoleWeaponComponent != null)
			{
				uiRoleWeaponComponent.AttachWeaponToRole();
			}
		}
	}

	// Token: 0x0600AAFA RID: 43770 RVA: 0x00326C7C File Offset: 0x00324E7C
	public override void ResetRole()
	{
		this.ResolvePendingModelLoad();
		this.RoleRefreshSerial++;
		this.IsRoleModelLoading = false;
		this.NeedDeployEffectOnNextRefresh = false;
		this.NeedStartSequenceOnRoleChanged = false;
		this.SetModelLoadingActive(false);
		this.StopFormation3DHoverEffect();
		this.StopFormation3DDeployEffect();
		UiModelBase model = this.SceneRoleActor.Model;
		this.ConfigId = null;
		this.SkinId = null;
		this.PlayerInternal = null;
		this.OnlineIndex = null;
		this.IsSelfSlot = false;
		this.IsDeadInternal = false;
		this.IsThirdPartyVisibleInternal = false;
		this.RefreshPanelAdd();
		base.GetItem(3).SetUIActive(false);
		base.GetItem(11).SetUIActive(false);
		base.GetItem(4).SetUIActive(false);
		base.GetItem(19).SetUIActive(false);
		base.GetItem(13).SetUIActive(false);
		base.GetSprite(6).SetUIActive(false);
		base.GetItem(7).SetUIActive(false);
		this.RefreshInfoPanelOffset(null, null);
		this.RefreshThirdPartyItem(null);
		this.SkillBranchToggleHandler.Clear();
		SlotExtensionRegistry.InvokeRefresh(this.Extensions, FormationDefine.CreateEmptySlotDisplayData());
		UiModelUtil.Instance.SetVisible(model, false);
	}

	// Token: 0x0600AAFB RID: 43771 RVA: 0x00326DC1 File Offset: 0x00324FC1
	private void RefreshPanelAdd()
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.ConfigId == null && !this.InDragMode);
	}

	// Token: 0x0600AAFC RID: 43772 RVA: 0x00326DF0 File Offset: 0x00324FF0
	private void ResolvePendingModelLoad()
	{
		Action<long?> pendingModelLoadResolve = this.PendingModelLoadResolve;
		if (pendingModelLoadResolve == null)
		{
			return;
		}
		pendingModelLoadResolve(null);
	}

	// Token: 0x0600AAFD RID: 43773 RVA: 0x00326E16 File Offset: 0x00325016
	private void SetModelLoadingActive(bool active)
	{
		TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
		object obj;
		if (sceneRoleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = sceneRoleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelLoadingIconComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.SetLoadingActive(active);
	}

	// Token: 0x0600AAFE RID: 43774 RVA: 0x00326E41 File Offset: 0x00325041
	public void SetModelLoadingAnchor(UUIItem anchor = null)
	{
		TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
		object obj;
		if (sceneRoleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = sceneRoleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelLoadingIconComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.SetFollowUiItem(anchor ?? base.GetRootItem());
	}

	// Token: 0x0600AAFF RID: 43775 RVA: 0x00326E76 File Offset: 0x00325076
	public void SetRoleSelectPreviewMode(bool isPreview)
	{
		this.IsRoleSelectPreviewMode = isPreview;
		if (isPreview)
		{
			this.IsHovering = false;
			this.StopFormation3DHoverEffect();
		}
	}

	// Token: 0x0600AB00 RID: 43776 RVA: 0x00326E8F File Offset: 0x0032508F
	public void RequestDeployEffectOnNextRefresh()
	{
		this.NeedDeployEffectOnNextRefresh = true;
	}

	// Token: 0x0600AB01 RID: 43777 RVA: 0x00326E98 File Offset: 0x00325098
	private void RefreshModeToggle(int roleId, IRoleSlotDisplayData.SkillBranchData branch)
	{
		this.SkillBranchToggleHandler.Refresh(roleId, this.IsDeadInternal ? null : branch);
	}

	// Token: 0x0600AB02 RID: 43778 RVA: 0x00326EB4 File Offset: 0x003250B4
	private void RefreshElement(int configId)
	{
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(configId);
		if (roleConfig == null)
		{
			UUIItem item = base.GetItem(13);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			UUIItem item2 = base.GetItem(13);
			if (item2 == null)
			{
				return;
			}
			int elementId = roleConfig.Value.ElementId;
			item2.SetUIActive(true);
			if (this.MiniElementItem == null)
			{
				this.MiniElementItem = new MiniElementItem(elementId, item2, item2.GetOwner());
			}
			this.MiniElementItem.RefreshMiniElement(elementId);
			return;
		}
	}

	// Token: 0x0600AB03 RID: 43779 RVA: 0x00326F38 File Offset: 0x00325138
	private void RefreshInfoPanelOffset(int? roleId, int? skinId)
	{
		int? num;
		if (!RoleUtils.IsTrialRole(roleId.GetValueOrDefault()))
		{
			num = null;
		}
		else
		{
			TrialRoleConfig instance = TrialRoleConfig.Instance;
			TrialRoleInfo? trialRoleInfo;
			num = ((instance != null) ? ((instance.GetTrialRoleConfig(roleId.GetValueOrDefault()) != null) ? new int?(trialRoleInfo.GetValueOrDefault().ParentId) : null) : null);
		}
		int? num2 = num;
		FormationConfig instance2 = FormationConfig.Instance;
		FormationMotion? formationMotion = (instance2 != null) ? instance2.GetFormationMotionConfigByRoleIdAndPosition((num2 > 0) ? num2.Value : roleId.GetValueOrDefault(), this.Position, skinId.GetValueOrDefault()) : null;
		this.ApplyPanelOffset(FormationRoleItem.EChildType.PanelLayout, this.PanelLayoutBaseOffset, (formationMotion != null) ? formationMotion.GetValueOrDefault().GetOffsetBottomUIArray() : null);
	}

	// Token: 0x0600AB04 RID: 43780 RVA: 0x00327020 File Offset: 0x00325220
	private void ApplyPanelOffset(FormationRoleItem.EChildType childType, FVector2D? baseOffset, IReadOnlyList<int> offset)
	{
		if (baseOffset == null)
		{
			return;
		}
		FVector2D value = baseOffset.Value;
		UUIItem item = base.GetItem((int)childType);
		if (item == null)
		{
			return;
		}
		item.SetAnchorOffset(new FVector2D(value.X + (float)FormationRoleItem.GetOffsetValue(offset, 0), value.Y + (float)FormationRoleItem.GetOffsetValue(offset, 1)));
	}

	// Token: 0x0600AB05 RID: 43781 RVA: 0x00327075 File Offset: 0x00325275
	private static int GetOffsetValue(IReadOnlyList<int> values, int index)
	{
		if (values == null || values.Count <= index)
		{
			return 0;
		}
		return values[index];
	}

	// Token: 0x0600AB06 RID: 43782 RVA: 0x0032708C File Offset: 0x0032528C
	private void RefreshDeadState(bool isDead)
	{
		this.IsDeadInternal = isDead;
		base.GetItem(11).SetUIActive(isDead);
	}

	// Token: 0x0600AB07 RID: 43783 RVA: 0x003270A3 File Offset: 0x003252A3
	private void RefreshDeadStateForSpecialTrialRole(int roleId, bool canUseSpecialTrialRole)
	{
		if (!RoleUtils.IsSpecialTrialRole(roleId) || !canUseSpecialTrialRole)
		{
			return;
		}
		this.RefreshDeadState(this.Provider.ResolveSpecialTrialDeadState(roleId));
	}

	// Token: 0x0600AB08 RID: 43784 RVA: 0x003270C4 File Offset: 0x003252C4
	private void RefreshOnlineState(int onlineIndex, int playerId, bool isSelf)
	{
		bool flag = onlineIndex > 0;
		base.GetItem(19).SetUIActive(flag && this.IsThirdPartyVisibleInternal);
		base.GetItem(7).SetUIActive(flag);
		if (!flag)
		{
			this.OnlineIndex = new int?(onlineIndex);
			this.PlayerInternal = new int?(playerId);
			return;
		}
		string resourceId = StringUtils.Format(isSelf ? "SP_Online{0}PIcon_Self" : "SP_Online{0}PIcon", new string[]
		{
			onlineIndex.ToString()
		});
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(8), false, null, null);
		this.OnlineIndex = new int?(onlineIndex);
		this.PlayerInternal = new int?(playerId);
	}

	// Token: 0x0600AB09 RID: 43785 RVA: 0x0032717C File Offset: 0x0032537C
	public void RefreshThirdPartyItem(string onlineId)
	{
		if (!this.IsThirdPartyVisibleInternal)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUITexture texture = base.GetTexture(20);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(false);
			return;
		}
		else
		{
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			bool flag = onlineId != null && onlineId != "";
			UUIText text = base.GetText(21);
			UUITexture texture2 = base.GetTexture(20);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			if (texture2 != null)
			{
				texture2.SetUIActive(true);
			}
			if (!flag)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "CrossNetworkPlayer_Name", Array.Empty<object>());
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_PlatformPcPhoneWhite" + ELogoSize.Medium.ToValue());
				base.SetTextureByPath(resourcePath, texture2, null, null);
				return;
			}
			if (text != null)
			{
				text.SetText(onlineId, true);
			}
			string thirdPartyWhiteLogoTexturePath = UiResourceConfig.Instance.GetThirdPartyWhiteLogoTexturePath(ELogoSize.Medium);
			base.SetTextureByPath(thirdPartyWhiteLogoTexturePath, texture2, null, null);
			return;
		}
	}

	// Token: 0x0600AB0A RID: 43786 RVA: 0x00327274 File Offset: 0x00325474
	[NullableContext(0)]
	public UniTask<bool> CreateDragAvatarItemAsync()
	{
		FormationRoleItem.<CreateDragAvatarItemAsync>d__63 <CreateDragAvatarItemAsync>d__;
		<CreateDragAvatarItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<CreateDragAvatarItemAsync>d__.<>4__this = this;
		<CreateDragAvatarItemAsync>d__.<>1__state = -1;
		<CreateDragAvatarItemAsync>d__.<>t__builder.Start<FormationRoleItem.<CreateDragAvatarItemAsync>d__63>(ref <CreateDragAvatarItemAsync>d__);
		return <CreateDragAvatarItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AB0B RID: 43787 RVA: 0x003272B7 File Offset: 0x003254B7
	protected override void OnDragShowProgress(float fill)
	{
		this.SetDragProgressFill(fill);
	}

	// Token: 0x0600AB0C RID: 43788 RVA: 0x003272C0 File Offset: 0x003254C0
	protected override void OnDragShowEnd()
	{
		this.SetDragProgressFill(0f);
		this.IsExChangeCandidate = false;
		FormationRoleDragAvatarItem readyDragAvatarItem = this.ReadyDragAvatarItem;
		if (readyDragAvatarItem != null)
		{
			readyDragAvatarItem.SetExchangeState(false);
		}
		FormationRoleDragAvatarItem readyDragAvatarItem2 = this.ReadyDragAvatarItem;
		if (readyDragAvatarItem2 == null)
		{
			return;
		}
		readyDragAvatarItem2.SetBgVisible(this.ConfigId.GetValueOrDefault() > 0);
	}

	// Token: 0x0600AB0D RID: 43789 RVA: 0x0032730F File Offset: 0x0032550F
	protected override void OnEnterMoveState()
	{
		AudioSystem.Instance.PostEvent("play_ui_team3d_role_ball_cursor");
	}

	// Token: 0x0600AB0E RID: 43790 RVA: 0x00327321 File Offset: 0x00325521
	private void SetDragProgressFill(float value)
	{
		base.GetItem(17).SetUIActive(value > 0f);
		base.GetSprite(18).SetFillAmount(value);
	}

	// Token: 0x0600AB0F RID: 43791 RVA: 0x00327348 File Offset: 0x00325548
	public override void ShowOtherItemUpState()
	{
		if (!this.IsSelfSlot || this.StartDrag)
		{
			return;
		}
		if (!this.IsExChangeCandidate)
		{
			this.IsExChangeCandidate = true;
			AudioSystem.Instance.PostEvent("play_ui_team3d_role_select");
		}
		FormationRoleDragAvatarItem readyDragAvatarItem = this.ReadyDragAvatarItem;
		if (readyDragAvatarItem != null)
		{
			readyDragAvatarItem.SetExchangeState(true);
		}
		FormationRoleDragAvatarItem readyDragAvatarItem2 = this.ReadyDragAvatarItem;
		if (readyDragAvatarItem2 == null)
		{
			return;
		}
		readyDragAvatarItem2.SetBgVisible(false);
	}

	// Token: 0x0600AB10 RID: 43792 RVA: 0x003273A8 File Offset: 0x003255A8
	public override void RefreshLockItemState(bool isDrag)
	{
		this.InDragMode = isDrag;
		if (isDrag)
		{
			this.EnterDragDisplayMode();
			return;
		}
		this.ExitDragDisplayMode();
	}

	// Token: 0x0600AB11 RID: 43793 RVA: 0x003273C4 File Offset: 0x003255C4
	private void EnterDragDisplayMode()
	{
		this.StopFormation3DHoverEffect();
		this.StopFormation3DDeployEffect();
		TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
		if (((sceneRoleActor != null) ? sceneRoleActor.Model : null) != null)
		{
			UiModelUtil.Instance.SetVisible(this.SceneRoleActor.Model, false);
		}
		this.RefreshPanelAdd();
		base.GetItem(4).SetUIActive(false);
		base.GetItem(13).SetUIActive(false);
		base.GetItem(19).SetUIActive(false);
		base.GetItem(11).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
		TeamRoleSelectSkillBranchItem modeToggleItem = this.ModeToggleItem;
		if (modeToggleItem != null)
		{
			modeToggleItem.SetUiActive(false);
		}
		FormationRoleDragAvatarItem readyDragAvatarItem = this.ReadyDragAvatarItem;
		if (readyDragAvatarItem == null)
		{
			return;
		}
		if (this.StartDrag)
		{
			readyDragAvatarItem.SetUiActive(false);
			return;
		}
		readyDragAvatarItem.SetUiActive(true);
		readyDragAvatarItem.ResetStates();
		readyDragAvatarItem.SetHeadVisible(true);
		readyDragAvatarItem.SetBgVisible(this.ConfigId.GetValueOrDefault() > 0);
		if (this.ConfigId != null)
		{
			int? configId = this.ConfigId;
			int num = 0;
			if (!(configId.GetValueOrDefault() == num & configId != null) && this.IsSelfSlot)
			{
				readyDragAvatarItem.RefreshRoleIcon(this.ConfigId.GetValueOrDefault(), this.SkinId.GetValueOrDefault());
				return;
			}
		}
		readyDragAvatarItem.SetLockState(true);
	}

	// Token: 0x0600AB12 RID: 43794 RVA: 0x00327500 File Offset: 0x00325700
	private void ExitDragDisplayMode()
	{
		FormationRoleDragAvatarItem readyDragAvatarItem = this.ReadyDragAvatarItem;
		if (readyDragAvatarItem != null)
		{
			readyDragAvatarItem.ResetStates();
		}
		FormationRoleDragAvatarItem readyDragAvatarItem2 = this.ReadyDragAvatarItem;
		if (readyDragAvatarItem2 != null)
		{
			readyDragAvatarItem2.SetUiActive(false);
		}
		bool flag = this.ConfigId.GetValueOrDefault() > 0;
		if (flag)
		{
			TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
			if (((sceneRoleActor != null) ? sceneRoleActor.Model : null) != null)
			{
				UiModelUtil.Instance.SetVisible(this.SceneRoleActor.Model, true);
			}
		}
		this.RefreshPanelAdd();
		base.GetItem(4).SetUIActive(flag);
		base.GetItem(13).SetUIActive(flag);
		base.GetItem(19).SetUIActive(this.OnlineIndex.GetValueOrDefault() > 0 && this.IsThirdPartyVisibleInternal);
		base.GetItem(11).SetUIActive(this.IsDeadInternal);
		base.GetItem(3).SetUIActive(false);
		this.SkillBranchToggleHandler.ApplyLastDto();
		this.PlayFormation3DHoverEffect();
	}

	// Token: 0x0600AB13 RID: 43795 RVA: 0x003275E4 File Offset: 0x003257E4
	private void BindHoverCallbacks()
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.OnPointEnterCallBack.Bind(new Action(this.OnChooseButtonPointEnter));
		}
		if (button == null)
		{
			return;
		}
		button.OnPointExitCallBack.Bind(new Action(this.OnChooseButtonPointExit));
	}

	// Token: 0x0600AB14 RID: 43796 RVA: 0x00327630 File Offset: 0x00325830
	private void UnbindHoverCallbacks()
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.OnPointEnterCallBack.Unbind();
		}
		if (button == null)
		{
			return;
		}
		button.OnPointExitCallBack.Unbind();
	}

	// Token: 0x0600AB15 RID: 43797 RVA: 0x00327659 File Offset: 0x00325859
	private void OnChooseButtonPointEnter()
	{
		this.IsHovering = true;
		this.PlayFormation3DHoverEffect();
	}

	// Token: 0x0600AB16 RID: 43798 RVA: 0x00327668 File Offset: 0x00325868
	private void OnChooseButtonPointExit()
	{
		this.IsHovering = false;
		this.StopFormation3DHoverEffect();
	}

	// Token: 0x0600AB17 RID: 43799 RVA: 0x00327678 File Offset: 0x00325878
	private void PlayFormation3DDeployEffect()
	{
		this.StopFormation3DDeployEffect();
		TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
		if (sceneRoleActor == null)
		{
			Log.Instance.Error(ELogModule.Role, ELogAuthor.SYB, "PlayFormation3DDeployEffect roleActor is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UiModelBase model = sceneRoleActor.Model;
		if (model == null)
		{
			return;
		}
		UiModelEffectComponent effectComponent = model.CheckGetComponent<UiModelEffectComponent>();
		UiModelActorComponent uiModelActorComponent = model.CheckGetComponent<UiModelActorComponent>();
		USkeletalMeshComponent uskeletalMeshComponent = (uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null;
		if (effectComponent == null || uskeletalMeshComponent == null)
		{
			return;
		}
		int refreshSerial = this.RoleRefreshSerial;
		UiModelEffectPlayContext context = new UiModelEffectPlayContext
		{
			EffectPath = EffectUtil.GetEffectPath("Formation3DDeploy"),
			AttachTargetComponent = uskeletalMeshComponent,
			SocketName = CharacterNameDefines.Instance.ROOT,
			IsForceShow = false,
			Callback = delegate(ELoadEffectResult result, int handle)
			{
				if (refreshSerial == this.RoleRefreshSerial)
				{
					return;
				}
				effectComponent.StopEffect(handle, true);
			}
		};
		this.DeployEffectHandle = effectComponent.PlayEffectByContext(context);
	}

	// Token: 0x0600AB18 RID: 43800 RVA: 0x0032775C File Offset: 0x0032595C
	private void StopFormation3DDeployEffect()
	{
		int deployEffectHandle = this.DeployEffectHandle;
		this.DeployEffectHandle = 0;
		if (deployEffectHandle == 0)
		{
			return;
		}
		TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
		object obj;
		if (sceneRoleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = sceneRoleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelEffectComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.StopEffect(deployEffectHandle, true);
	}

	// Token: 0x0600AB19 RID: 43801 RVA: 0x003277A8 File Offset: 0x003259A8
	private void PlayFormation3DHoverEffect()
	{
		if (!this.IsHovering || this.IsRoleSelectPreviewMode || this.InDragMode || this.IsRoleModelLoading || this.ConfigId.GetValueOrDefault() == 0 || this.HoverEffectHandle != 0)
		{
			return;
		}
		TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
		UiModelBase uiModelBase = (sceneRoleActor != null) ? sceneRoleActor.Model : null;
		if (uiModelBase == null)
		{
			return;
		}
		UiModelEffectComponent uiModelEffectComponent = uiModelBase.CheckGetComponent<UiModelEffectComponent>();
		UiModelActorComponent uiModelActorComponent = uiModelBase.CheckGetComponent<UiModelActorComponent>();
		USkeletalMeshComponent uskeletalMeshComponent = (uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null;
		if (uiModelEffectComponent == null || uskeletalMeshComponent == null)
		{
			return;
		}
		string effectPath = EffectUtil.GetEffectPath("Formation3DHover");
		UiModelEffectPlayContext context = new UiModelEffectPlayContext
		{
			EffectPath = effectPath,
			AttachTargetComponent = uskeletalMeshComponent,
			SocketName = CharacterNameDefines.Instance.ROOT
		};
		this.HoverEffectHandle = uiModelEffectComponent.PlayEffectByContext(context);
	}

	// Token: 0x0600AB1A RID: 43802 RVA: 0x00327864 File Offset: 0x00325A64
	private void StopFormation3DHoverEffect()
	{
		int hoverEffectHandle = this.HoverEffectHandle;
		this.HoverEffectHandle = 0;
		if (hoverEffectHandle == 0)
		{
			return;
		}
		TsUiSceneRoleActor sceneRoleActor = this.SceneRoleActor;
		object obj;
		if (sceneRoleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = sceneRoleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelEffectComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.StopEffect(hoverEffectHandle, true);
	}

	// Token: 0x0600AB1B RID: 43803 RVA: 0x003278AD File Offset: 0x00325AAD
	protected override UUISprite GetPingSprite()
	{
		return base.GetSprite(6);
	}

	// Token: 0x0600AB1C RID: 43804 RVA: 0x003278B6 File Offset: 0x00325AB6
	protected override UUIText GetNameText()
	{
		return base.GetText(15);
	}

	// Token: 0x0600AB1D RID: 43805 RVA: 0x003278C0 File Offset: 0x00325AC0
	protected override UUIArtText GetLevelArtText()
	{
		return base.GetArtText(14);
	}

	// Token: 0x0600AB1E RID: 43806 RVA: 0x003278CA File Offset: 0x00325ACA
	public override AActor GetTrialRoleItemOwner()
	{
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return null;
		}
		return item.GetOwner();
	}

	// Token: 0x0600AB1F RID: 43807 RVA: 0x003278DF File Offset: 0x00325ADF
	[NullableContext(1)]
	public override AActor GetRoleItemOwner()
	{
		return base.GetItem(2).GetOwner();
	}

	// Token: 0x0600AB20 RID: 43808 RVA: 0x003278ED File Offset: 0x00325AED
	public override AActor GetLikeItemOwner()
	{
		return null;
	}

	// Token: 0x0600AB21 RID: 43809 RVA: 0x003278F0 File Offset: 0x00325AF0
	public override UUIItem GetChooseButtonRoot()
	{
		UUIButtonComponent button = base.GetButton(0);
		TWeakObjectPtr<UUIItem>? tweakObjectPtr = (button != null) ? new TWeakObjectPtr<UUIItem>?(button.RootUIComp) : null;
		if (tweakObjectPtr == null)
		{
			return null;
		}
		return tweakObjectPtr.GetValueOrDefault();
	}

	// Token: 0x0600AB22 RID: 43810 RVA: 0x00327935 File Offset: 0x00325B35
	public override AActor GetSkillBranchToggleItemOwner()
	{
		return null;
	}

	// Token: 0x0600AB23 RID: 43811 RVA: 0x00327938 File Offset: 0x00325B38
	public void OnHandleLoadScene()
	{
		UiModelActorComponent uiModelActorComponent = this.SceneRoleActor.Model.CheckGetComponent<UiModelActorComponent>();
		if (uiModelActorComponent == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
		defaultInterpolatedStringHandler.AppendLiteral("RoleCase");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.Position);
		uiModelActorComponent.SetTransformByTag(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x0600AB24 RID: 43812 RVA: 0x00327988 File Offset: 0x00325B88
	public void OnHandleReleaseScene()
	{
		this.ResolvePendingModelLoad();
		this.RoleRefreshSerial++;
		this.IsRoleModelLoading = false;
		this.IsHovering = false;
		this.StopFormation3DHoverEffect();
		this.StopFormation3DDeployEffect();
		this.SetModelLoadingActive(false);
		UiModelBase model = this.SceneRoleActor.Model;
		UiModelUtil.Instance.SetVisible(model, false);
	}

	// Token: 0x04006305 RID: 25349
	[Nullable(1)]
	private const string FORMATION_3D_DEPLOY_EFFECT_ID = "Formation3DDeploy";

	// Token: 0x04006306 RID: 25350
	[Nullable(1)]
	private const string FORMATION_3D_HOVER_EFFECT_ID = "Formation3DHover";

	// Token: 0x04006308 RID: 25352
	private bool IsDeadInternal;

	// Token: 0x04006309 RID: 25353
	private TsUiSceneRoleActor SceneRoleActor;

	// Token: 0x0400630A RID: 25354
	private MiniElementItem MiniElementItem;

	// Token: 0x0400630B RID: 25355
	private TeamRoleSelectSkillBranchItem ModeToggleItem;

	// Token: 0x0400630C RID: 25356
	[Nullable(1)]
	private readonly FormationSkillBranchToggleHandler SkillBranchToggleHandler;

	// Token: 0x0400630D RID: 25357
	private Action<long?> PendingModelLoadResolve;

	// Token: 0x0400630E RID: 25358
	private int RoleRefreshSerial;

	// Token: 0x0400630F RID: 25359
	private bool InDragMode;

	// Token: 0x04006310 RID: 25360
	private bool IsExChangeCandidate;

	// Token: 0x04006311 RID: 25361
	private FormationRoleDragAvatarItem DragAvatarItem;

	// Token: 0x04006312 RID: 25362
	private bool IsHovering;

	// Token: 0x04006313 RID: 25363
	private int HoverEffectHandle;

	// Token: 0x04006314 RID: 25364
	private int DeployEffectHandle;

	// Token: 0x04006315 RID: 25365
	private bool IsRoleModelLoading;

	// Token: 0x04006316 RID: 25366
	private bool IsRoleSelectPreviewMode;

	// Token: 0x04006317 RID: 25367
	private bool NeedDeployEffectOnNextRefresh;

	// Token: 0x04006318 RID: 25368
	private FVector2D? PanelLayoutBaseOffset;

	// Token: 0x04006319 RID: 25369
	private LevelSequencePlayer StartSequencePlayer;

	// Token: 0x0400631A RID: 25370
	private LevelSequencePlayer CloseSequencePlayer;

	// Token: 0x0400631B RID: 25371
	private bool IsSlotVisible = true;

	// Token: 0x0400631C RID: 25372
	private bool NeedStartSequenceOnRoleChanged;

	// Token: 0x02007349 RID: 29513
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402588F RID: 153743
		ChooseButton,
		// Token: 0x04025890 RID: 153744
		PanelAdd,
		// Token: 0x04025891 RID: 153745
		PanelRole,
		// Token: 0x04025892 RID: 153746
		PanelLock,
		// Token: 0x04025893 RID: 153747
		PanelPreView,
		// Token: 0x04025894 RID: 153748
		PanelPlatform,
		// Token: 0x04025895 RID: 153749
		SignalSprite,
		// Token: 0x04025896 RID: 153750
		PlayerPosItem,
		// Token: 0x04025897 RID: 153751
		PlayerPosSprite,
		// Token: 0x04025898 RID: 153752
		PanelWaitState,
		// Token: 0x04025899 RID: 153753
		PanelWait,
		// Token: 0x0402589A RID: 153754
		PanelDead,
		// Token: 0x0402589B RID: 153755
		TrialItem,
		// Token: 0x0402589C RID: 153756
		PanelElement,
		// Token: 0x0402589D RID: 153757
		LevelTxt,
		// Token: 0x0402589E RID: 153758
		NameTxt,
		// Token: 0x0402589F RID: 153759
		ModeToggle,
		// Token: 0x040258A0 RID: 153760
		PanelDragProgress,
		// Token: 0x040258A1 RID: 153761
		DragProgressItem,
		// Token: 0x040258A2 RID: 153762
		PanelTop,
		// Token: 0x040258A3 RID: 153763
		PlatformTex,
		// Token: 0x040258A4 RID: 153764
		PSIdTxt,
		// Token: 0x040258A5 RID: 153765
		DragItem,
		// Token: 0x040258A6 RID: 153766
		DragStateItem,
		// Token: 0x040258A7 RID: 153767
		PanelLayout
	}
}

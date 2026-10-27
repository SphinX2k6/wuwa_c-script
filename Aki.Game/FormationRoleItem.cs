using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001C0D RID: 7181
[NullableContext(2)]
[Nullable(0)]
public class FormationRoleItem : FormationSlotBase
{
	// Token: 0x170011AE RID: 4526
	// (get) Token: 0x0600D6D3 RID: 54995 RVA: 0x0031AB3B File Offset: 0x00318D3B
	[Nullable(1)]
	protected override string LogTag { [NullableContext(1)] get; } = "FormationRoleItem";

	// Token: 0x0600D6D4 RID: 54996 RVA: 0x0031AB43 File Offset: 0x00318D43
	[NullableContext(1)]
	public FormationRoleItem(int position, IFormationProvider provider) : base(position, provider)
	{
		this.SkillBranchToggleHandler = new FormationSkillBranchToggleHandler(() => this.ModeToggleItem);
	}

	// Token: 0x0600D6D5 RID: 54997 RVA: 0x0031AB78 File Offset: 0x00318D78
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

	// Token: 0x0600D6D6 RID: 54998 RVA: 0x0031AF28 File Offset: 0x00319128
	protected override UniTask OnBeforeStartAsync()
	{
		FormationRoleItem.<OnBeforeStartAsync>d__29 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FormationRoleItem.<OnBeforeStartAsync>d__29>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D6D7 RID: 54999 RVA: 0x0031AF6C File Offset: 0x0031916C
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

	// Token: 0x0600D6D8 RID: 55000 RVA: 0x0031B08F File Offset: 0x0031928F
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		this.IsHovering = false;
		this.StopFormation3DHoverEffect();
		this.StopFormation3DDeployEffect();
	}

	// Token: 0x0600D6D9 RID: 55001 RVA: 0x0031B0AC File Offset: 0x003192AC
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

	// Token: 0x0600D6DA RID: 55002 RVA: 0x0031B1D0 File Offset: 0x003193D0
	public void DestroyDragAvatarItem()
	{
		FormationRoleDragAvatarItem dragAvatarItem = this.DragAvatarItem;
		this.DragAvatarItem = null;
		if (dragAvatarItem != null && !dragAvatarItem.IsDestroyOrDestroying)
		{
			dragAvatarItem.Destroy(null);
		}
	}

	// Token: 0x0600D6DB RID: 55003 RVA: 0x0031B200 File Offset: 0x00319400
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

	// Token: 0x0600D6DC RID: 55004 RVA: 0x0031B28C File Offset: 0x0031948C
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

	// Token: 0x0600D6DD RID: 55005 RVA: 0x0031B2FB File Offset: 0x003194FB
	public void RequestStartSequenceOnRoleChanged()
	{
		this.NeedStartSequenceOnRoleChanged = true;
	}

	// Token: 0x0600D6DE RID: 55006 RVA: 0x0031B304 File Offset: 0x00319504
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

	// Token: 0x0600D6DF RID: 55007 RVA: 0x0031B35F File Offset: 0x0031955F
	private void OnRoleWeaponSkinChanged(int roleId, int modelId)
	{
		this.OnRoleWeaponChanged(roleId);
	}

	// Token: 0x0600D6E0 RID: 55008 RVA: 0x0031B368 File Offset: 0x00319568
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

	// Token: 0x0600D6E1 RID: 55009 RVA: 0x0031B3B5 File Offset: 0x003195B5
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

	// Token: 0x0600D6E2 RID: 55010 RVA: 0x0031B3EC File Offset: 0x003195EC
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

	// Token: 0x0600D6E3 RID: 55011 RVA: 0x0031B44C File Offset: 0x0031964C
	[NullableContext(0)]
	public UniTask<long?> RefreshAndWaitModelLoaded([Nullable(1)] IRoleSlotDisplayData data)
	{
		FormationRoleItem.<RefreshAndWaitModelLoaded>d__42 <RefreshAndWaitModelLoaded>d__;
		<RefreshAndWaitModelLoaded>d__.<>t__builder = AsyncUniTaskMethodBuilder<long?>.Create();
		<RefreshAndWaitModelLoaded>d__.<>4__this = this;
		<RefreshAndWaitModelLoaded>d__.data = data;
		<RefreshAndWaitModelLoaded>d__.<>1__state = -1;
		<RefreshAndWaitModelLoaded>d__.<>t__builder.Start<FormationRoleItem.<RefreshAndWaitModelLoaded>d__42>(ref <RefreshAndWaitModelLoaded>d__);
		return <RefreshAndWaitModelLoaded>d__.<>t__builder.Task;
	}

	// Token: 0x0600D6E4 RID: 55012 RVA: 0x0031B498 File Offset: 0x00319698
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

	// Token: 0x0600D6E5 RID: 55013 RVA: 0x0031B5C4 File Offset: 0x003197C4
	[NullableContext(1)]
	private void RefreshRoleDataInternal(IRoleSlotDisplayData data, bool needPlayDeployEffect, bool needRoleChangeEffect, int refreshSerial)
	{
		FormationRoleItem.<>c__DisplayClass44_0 CS$<>8__locals1 = new FormationRoleItem.<>c__DisplayClass44_0();
		CS$<>8__locals1.data = data;
		CS$<>8__locals1.<>4__this = this;
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
			if (formationRoleEquip.DressList.Length == 0)
			{
				(array = new OrnamentModelContext[1])[0] = new OrnamentModelContext
				{
					ModelId = 0,
					HideInUi = true,
					OrnamentUiBuff = new List<long>(),
					EquipTags = new List<string>()
				};
			}
			else
			{
				array = (from ornamentId in formationRoleEquip.DressList
				select UiModelUtil.BuildOrnamentModelContext(CS$<>8__locals1.data.SkinId, ornamentId)).ToArray<OrnamentModelContext>();
			}
			OrnamentModelContext[] pendingContexts = array;
			UiRoleOrnamentComponent ornamentComponent = CS$<>8__locals1.ornamentComponent;
			if (ornamentComponent != null)
			{
				ornamentComponent.SetPendingContexts(pendingContexts);
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

	// Token: 0x0600D6E6 RID: 55014 RVA: 0x0031B940 File Offset: 0x00319B40
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

	// Token: 0x0600D6E7 RID: 55015 RVA: 0x0031BA85 File Offset: 0x00319C85
	private void RefreshPanelAdd()
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.ConfigId == null && !this.InDragMode);
	}

	// Token: 0x0600D6E8 RID: 55016 RVA: 0x0031BAB4 File Offset: 0x00319CB4
	private void ResolvePendingModelLoad()
	{
		Action<long?> pendingModelLoadResolve = this.PendingModelLoadResolve;
		if (pendingModelLoadResolve == null)
		{
			return;
		}
		pendingModelLoadResolve(null);
	}

	// Token: 0x0600D6E9 RID: 55017 RVA: 0x0031BADA File Offset: 0x00319CDA
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

	// Token: 0x0600D6EA RID: 55018 RVA: 0x0031BB05 File Offset: 0x00319D05
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

	// Token: 0x0600D6EB RID: 55019 RVA: 0x0031BB3A File Offset: 0x00319D3A
	public void SetRoleSelectPreviewMode(bool isPreview)
	{
		this.IsRoleSelectPreviewMode = isPreview;
		if (isPreview)
		{
			this.IsHovering = false;
			this.StopFormation3DHoverEffect();
		}
	}

	// Token: 0x0600D6EC RID: 55020 RVA: 0x0031BB53 File Offset: 0x00319D53
	public void RequestDeployEffectOnNextRefresh()
	{
		this.NeedDeployEffectOnNextRefresh = true;
	}

	// Token: 0x0600D6ED RID: 55021 RVA: 0x0031BB5C File Offset: 0x00319D5C
	private void RefreshModeToggle(int roleId, IRoleSlotDisplayData.SkillBranchData branch)
	{
		this.SkillBranchToggleHandler.Refresh(roleId, this.IsDeadInternal ? null : branch);
	}

	// Token: 0x0600D6EE RID: 55022 RVA: 0x0031BB78 File Offset: 0x00319D78
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

	// Token: 0x0600D6EF RID: 55023 RVA: 0x0031BBFC File Offset: 0x00319DFC
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

	// Token: 0x0600D6F0 RID: 55024 RVA: 0x0031BCE4 File Offset: 0x00319EE4
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

	// Token: 0x0600D6F1 RID: 55025 RVA: 0x0031BD39 File Offset: 0x00319F39
	private static int GetOffsetValue(IReadOnlyList<int> values, int index)
	{
		if (values == null || values.Count <= index)
		{
			return 0;
		}
		return values[index];
	}

	// Token: 0x0600D6F2 RID: 55026 RVA: 0x0031BD50 File Offset: 0x00319F50
	private void RefreshDeadState(bool isDead)
	{
		this.IsDeadInternal = isDead;
		base.GetItem(11).SetUIActive(isDead);
	}

	// Token: 0x0600D6F3 RID: 55027 RVA: 0x0031BD67 File Offset: 0x00319F67
	private void RefreshDeadStateForSpecialTrialRole(int roleId, bool canUseSpecialTrialRole)
	{
		if (!RoleUtils.IsSpecialTrialRole(roleId) || !canUseSpecialTrialRole)
		{
			return;
		}
		this.RefreshDeadState(this.Provider.ResolveSpecialTrialDeadState(roleId));
	}

	// Token: 0x0600D6F4 RID: 55028 RVA: 0x0031BD88 File Offset: 0x00319F88
	private void RefreshOnlineState(int onlineIndex, int playerId, bool isSelf)
	{
		bool flag = onlineIndex > 0;
		base.GetItem(19).SetUIActive(flag);
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

	// Token: 0x0600D6F5 RID: 55029 RVA: 0x0031BE34 File Offset: 0x0031A034
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

	// Token: 0x0600D6F6 RID: 55030 RVA: 0x0031BF2C File Offset: 0x0031A12C
	[NullableContext(0)]
	public UniTask<bool> CreateDragAvatarItemAsync()
	{
		FormationRoleItem.<CreateDragAvatarItemAsync>d__61 <CreateDragAvatarItemAsync>d__;
		<CreateDragAvatarItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<CreateDragAvatarItemAsync>d__.<>4__this = this;
		<CreateDragAvatarItemAsync>d__.<>1__state = -1;
		<CreateDragAvatarItemAsync>d__.<>t__builder.Start<FormationRoleItem.<CreateDragAvatarItemAsync>d__61>(ref <CreateDragAvatarItemAsync>d__);
		return <CreateDragAvatarItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D6F7 RID: 55031 RVA: 0x0031BF6F File Offset: 0x0031A16F
	protected override void OnDragShowProgress(float fill)
	{
		this.SetDragProgressFill(fill);
	}

	// Token: 0x0600D6F8 RID: 55032 RVA: 0x0031BF78 File Offset: 0x0031A178
	protected override void OnDragShowEnd()
	{
		this.SetDragProgressFill(0f);
		this.IsExChangeCandidate = false;
		FormationRoleDragAvatarItem dragAvatarItem = this.DragAvatarItem;
		if (dragAvatarItem != null)
		{
			dragAvatarItem.SetExchangeState(false);
		}
		FormationRoleDragAvatarItem dragAvatarItem2 = this.DragAvatarItem;
		if (dragAvatarItem2 == null)
		{
			return;
		}
		dragAvatarItem2.SetBgVisible(this.ConfigId.GetValueOrDefault() > 0);
	}

	// Token: 0x0600D6F9 RID: 55033 RVA: 0x0031BFC7 File Offset: 0x0031A1C7
	protected override void OnEnterMoveState()
	{
		AudioSystem.Instance.PostEvent("play_ui_team3d_role_ball_cursor");
	}

	// Token: 0x0600D6FA RID: 55034 RVA: 0x0031BFD9 File Offset: 0x0031A1D9
	private void SetDragProgressFill(float value)
	{
		base.GetItem(17).SetUIActive(value > 0f);
		base.GetSprite(18).SetFillAmount(value);
	}

	// Token: 0x0600D6FB RID: 55035 RVA: 0x0031C000 File Offset: 0x0031A200
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
		FormationRoleDragAvatarItem dragAvatarItem = this.DragAvatarItem;
		if (dragAvatarItem != null)
		{
			dragAvatarItem.SetExchangeState(true);
		}
		FormationRoleDragAvatarItem dragAvatarItem2 = this.DragAvatarItem;
		if (dragAvatarItem2 == null)
		{
			return;
		}
		dragAvatarItem2.SetBgVisible(false);
	}

	// Token: 0x0600D6FC RID: 55036 RVA: 0x0031C060 File Offset: 0x0031A260
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

	// Token: 0x0600D6FD RID: 55037 RVA: 0x0031C07C File Offset: 0x0031A27C
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
		FormationRoleDragAvatarItem dragAvatarItem = this.DragAvatarItem;
		if (dragAvatarItem == null)
		{
			return;
		}
		if (this.StartDrag)
		{
			dragAvatarItem.SetUiActive(false);
			return;
		}
		dragAvatarItem.SetUiActive(true);
		dragAvatarItem.ResetStates();
		dragAvatarItem.SetHeadVisible(true);
		dragAvatarItem.SetBgVisible(this.ConfigId.GetValueOrDefault() > 0);
		if (this.ConfigId != null)
		{
			int? configId = this.ConfigId;
			int num = 0;
			if (!(configId.GetValueOrDefault() == num & configId != null) && this.IsSelfSlot)
			{
				dragAvatarItem.RefreshRoleIcon(this.ConfigId.GetValueOrDefault(), this.SkinId.GetValueOrDefault());
				return;
			}
		}
		dragAvatarItem.SetLockState(true);
	}

	// Token: 0x0600D6FE RID: 55038 RVA: 0x0031C1B8 File Offset: 0x0031A3B8
	private void ExitDragDisplayMode()
	{
		FormationRoleDragAvatarItem dragAvatarItem = this.DragAvatarItem;
		if (dragAvatarItem != null)
		{
			dragAvatarItem.ResetStates();
		}
		FormationRoleDragAvatarItem dragAvatarItem2 = this.DragAvatarItem;
		if (dragAvatarItem2 != null)
		{
			dragAvatarItem2.SetUiActive(false);
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
		base.GetItem(19).SetUIActive(this.OnlineIndex.GetValueOrDefault() > 0);
		base.GetItem(11).SetUIActive(this.IsDeadInternal);
		base.GetItem(3).SetUIActive(false);
		this.SkillBranchToggleHandler.ApplyLastDto();
		this.PlayFormation3DHoverEffect();
	}

	// Token: 0x0600D6FF RID: 55039 RVA: 0x0031C294 File Offset: 0x0031A494
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

	// Token: 0x0600D700 RID: 55040 RVA: 0x0031C2E0 File Offset: 0x0031A4E0
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

	// Token: 0x0600D701 RID: 55041 RVA: 0x0031C309 File Offset: 0x0031A509
	private void OnChooseButtonPointEnter()
	{
		this.IsHovering = true;
		this.PlayFormation3DHoverEffect();
	}

	// Token: 0x0600D702 RID: 55042 RVA: 0x0031C318 File Offset: 0x0031A518
	private void OnChooseButtonPointExit()
	{
		this.IsHovering = false;
		this.StopFormation3DHoverEffect();
	}

	// Token: 0x0600D703 RID: 55043 RVA: 0x0031C328 File Offset: 0x0031A528
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

	// Token: 0x0600D704 RID: 55044 RVA: 0x0031C40C File Offset: 0x0031A60C
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

	// Token: 0x0600D705 RID: 55045 RVA: 0x0031C458 File Offset: 0x0031A658
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

	// Token: 0x0600D706 RID: 55046 RVA: 0x0031C514 File Offset: 0x0031A714
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

	// Token: 0x0600D707 RID: 55047 RVA: 0x0031C55D File Offset: 0x0031A75D
	protected override UUISprite GetPingSprite()
	{
		return base.GetSprite(6);
	}

	// Token: 0x0600D708 RID: 55048 RVA: 0x0031C566 File Offset: 0x0031A766
	protected override UUIText GetNameText()
	{
		return base.GetText(15);
	}

	// Token: 0x0600D709 RID: 55049 RVA: 0x0031C570 File Offset: 0x0031A770
	protected override UUIArtText GetLevelArtText()
	{
		return base.GetArtText(14);
	}

	// Token: 0x0600D70A RID: 55050 RVA: 0x0031C57A File Offset: 0x0031A77A
	public override AActor GetTrialRoleItemOwner()
	{
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return null;
		}
		return item.GetOwner();
	}

	// Token: 0x0600D70B RID: 55051 RVA: 0x0031C58F File Offset: 0x0031A78F
	[NullableContext(1)]
	public override AActor GetRoleItemOwner()
	{
		return base.GetItem(2).GetOwner();
	}

	// Token: 0x0600D70C RID: 55052 RVA: 0x0031C59D File Offset: 0x0031A79D
	public override AActor GetLikeItemOwner()
	{
		return null;
	}

	// Token: 0x0600D70D RID: 55053 RVA: 0x0031C5A0 File Offset: 0x0031A7A0
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

	// Token: 0x0600D70E RID: 55054 RVA: 0x0031C5E5 File Offset: 0x0031A7E5
	public override AActor GetSkillBranchToggleItemOwner()
	{
		return null;
	}

	// Token: 0x0600D70F RID: 55055 RVA: 0x0031C5E8 File Offset: 0x0031A7E8
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

	// Token: 0x0600D710 RID: 55056 RVA: 0x0031C638 File Offset: 0x0031A838
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

	// Token: 0x04006233 RID: 25139
	[Nullable(1)]
	private const string FORMATION_3D_DEPLOY_EFFECT_ID = "Formation3DDeploy";

	// Token: 0x04006234 RID: 25140
	[Nullable(1)]
	private const string FORMATION_3D_HOVER_EFFECT_ID = "Formation3DHover";

	// Token: 0x04006236 RID: 25142
	private bool IsDeadInternal;

	// Token: 0x04006237 RID: 25143
	private TsUiSceneRoleActor SceneRoleActor;

	// Token: 0x04006238 RID: 25144
	private MiniElementItem MiniElementItem;

	// Token: 0x04006239 RID: 25145
	private TeamRoleSelectSkillBranchItem ModeToggleItem;

	// Token: 0x0400623A RID: 25146
	[Nullable(1)]
	private readonly FormationSkillBranchToggleHandler SkillBranchToggleHandler;

	// Token: 0x0400623B RID: 25147
	private Action<long?> PendingModelLoadResolve;

	// Token: 0x0400623C RID: 25148
	private int RoleRefreshSerial;

	// Token: 0x0400623D RID: 25149
	private bool InDragMode;

	// Token: 0x0400623E RID: 25150
	private bool IsExChangeCandidate;

	// Token: 0x0400623F RID: 25151
	private FormationRoleDragAvatarItem DragAvatarItem;

	// Token: 0x04006240 RID: 25152
	private bool IsHovering;

	// Token: 0x04006241 RID: 25153
	private int HoverEffectHandle;

	// Token: 0x04006242 RID: 25154
	private int DeployEffectHandle;

	// Token: 0x04006243 RID: 25155
	private bool IsRoleModelLoading;

	// Token: 0x04006244 RID: 25156
	private bool IsRoleSelectPreviewMode;

	// Token: 0x04006245 RID: 25157
	private bool NeedDeployEffectOnNextRefresh;

	// Token: 0x04006246 RID: 25158
	private FVector2D? PanelLayoutBaseOffset;

	// Token: 0x04006247 RID: 25159
	private LevelSequencePlayer StartSequencePlayer;

	// Token: 0x04006248 RID: 25160
	private LevelSequencePlayer CloseSequencePlayer;

	// Token: 0x04006249 RID: 25161
	private bool IsSlotVisible = true;

	// Token: 0x0400624A RID: 25162
	private bool NeedStartSequenceOnRoleChanged;

	// Token: 0x020081C0 RID: 33216
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A568 RID: 173416
		ChooseButton,
		// Token: 0x0402A569 RID: 173417
		PanelAdd,
		// Token: 0x0402A56A RID: 173418
		PanelRole,
		// Token: 0x0402A56B RID: 173419
		PanelLock,
		// Token: 0x0402A56C RID: 173420
		PanelPreView,
		// Token: 0x0402A56D RID: 173421
		PanelPlatform,
		// Token: 0x0402A56E RID: 173422
		SignalSprite,
		// Token: 0x0402A56F RID: 173423
		PlayerPosItem,
		// Token: 0x0402A570 RID: 173424
		PlayerPosSprite,
		// Token: 0x0402A571 RID: 173425
		PanelWaitState,
		// Token: 0x0402A572 RID: 173426
		PanelWait,
		// Token: 0x0402A573 RID: 173427
		PanelDead,
		// Token: 0x0402A574 RID: 173428
		TrialItem,
		// Token: 0x0402A575 RID: 173429
		PanelElement,
		// Token: 0x0402A576 RID: 173430
		LevelTxt,
		// Token: 0x0402A577 RID: 173431
		NameTxt,
		// Token: 0x0402A578 RID: 173432
		ModeToggle,
		// Token: 0x0402A579 RID: 173433
		PanelDragProgress,
		// Token: 0x0402A57A RID: 173434
		DragProgressItem,
		// Token: 0x0402A57B RID: 173435
		PanelTop,
		// Token: 0x0402A57C RID: 173436
		PlatformTex,
		// Token: 0x0402A57D RID: 173437
		PSIdTxt,
		// Token: 0x0402A57E RID: 173438
		DragItem,
		// Token: 0x0402A57F RID: 173439
		DragStateItem,
		// Token: 0x0402A580 RID: 173440
		PanelLayout
	}
}

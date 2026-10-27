using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BFD RID: 7165
[NullableContext(1)]
[Nullable(0)]
public class Formation3D : FormationFlavorViewBase
{
	// Token: 0x0600D5CB RID: 54731 RVA: 0x00315BD4 File Offset: 0x00313DD4
	public Formation3D(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x170011A2 RID: 4514
	// (get) Token: 0x0600D5CC RID: 54732 RVA: 0x00315C5A File Offset: 0x00313E5A
	protected virtual SlotPresenter3D Presenter { [PreserveBaseOverrides] get; } = new SlotPresenter3D();

	// Token: 0x170011A3 RID: 4515
	// (get) Token: 0x0600D5CD RID: 54733 RVA: 0x00315C62 File Offset: 0x00313E62
	protected override EUiViewName RoleSelectViewName { get; } = EUiViewName.TeamSceneRoleSelectView;

	// Token: 0x170011A4 RID: 4516
	// (get) Token: 0x0600D5CE RID: 54734 RVA: 0x00315C6A File Offset: 0x00313E6A
	protected override FormationActionKeys FormationActionKeys { get; } = new FormationActionKeys
	{
		PresetForm = 11,
		EditFormName = 12
	};

	// Token: 0x170011A5 RID: 4517
	// (get) Token: 0x0600D5CF RID: 54735 RVA: 0x00315C72 File Offset: 0x00313E72
	protected override FormationViewKeys Keys { get; } = new FormationViewKeys
	{
		Close = 3,
		Tab = 0,
		Confirm = 1,
		QuickSelect = 4,
		Loading = 5,
		ConfirmText = 2,
		DescToggleItem = new int?(6)
	};

	// Token: 0x0600D5D0 RID: 54736 RVA: 0x00315C7C File Offset: 0x00313E7C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 5;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickConfirm));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickClose));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickQuickSelect));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action(base.OnClickPresetForm));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action(base.OnClickEditFormName));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D5D1 RID: 54737 RVA: 0x00315F67 File Offset: 0x00314167
	protected override IFormationTabComponent CreateFormationTabComponent(UUIItem uiItem, CommonTabComponentData<EditFormationTabItem> data)
	{
		return new Formation3DTabComponent(uiItem, data, new Func<int, bool>(this.IsCurrentTab));
	}

	// Token: 0x0600D5D2 RID: 54738 RVA: 0x00315F7D File Offset: 0x0031417D
	public override string GetBlackScreenStyleOnOpen()
	{
		return "Formation3D";
	}

	// Token: 0x0600D5D3 RID: 54739 RVA: 0x00315F84 File Offset: 0x00314184
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		if (!GameModeModel.Instance.IsMulti)
		{
			((Formation3DTabComponent)this.TabComponent).SetInitialNavigationFocus();
		}
		UiSceneManager.Instance.SetUiShowRoomFloorReflection(false);
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.RoleWeaponTabView);
	}

	// Token: 0x0600D5D4 RID: 54740 RVA: 0x00315FBE File Offset: 0x003141BE
	protected override void OnBeforeHide()
	{
		this.FinishCameraResetForRoleItems();
		base.OnBeforeHide();
	}

	// Token: 0x0600D5D5 RID: 54741 RVA: 0x00315FCC File Offset: 0x003141CC
	protected override void OnFormationEditViewOpenChanged(bool isOpen)
	{
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(!isOpen && !GameModeModel.Instance.IsMulti);
		}
		for (int i = 1; i <= 3; i++)
		{
			bool flag = FormationModel.Instance.GetEditingRoleId(this.EditFormationId, i) > 0;
			FormationRoleItem byPosition = this.Presenter.GetByPosition(i);
			if (byPosition != null)
			{
				byPosition.SetSlotVisibleWithSequence(!isOpen || !flag, false);
			}
		}
	}

	// Token: 0x0600D5D6 RID: 54742 RVA: 0x00316044 File Offset: 0x00314244
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraAnimationDefine.IFinishData>(this.OnPlayCameraAnimationFinish));
		if (GameModeModel.Instance.IsMulti)
		{
			EventSystem.Instance.Add<int, ENetPingState>(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing));
		}
	}

	// Token: 0x0600D5D7 RID: 54743 RVA: 0x00316098 File Offset: 0x00314298
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraAnimationDefine.IFinishData>(this.OnPlayCameraAnimationFinish));
		if (EventSystem.Instance.Has(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing)))
		{
			EventSystem.Instance.Remove<int, ENetPingState>(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing));
		}
	}

	// Token: 0x0600D5D8 RID: 54744 RVA: 0x003160FC File Offset: 0x003142FC
	private void OnPlayCameraAnimationFinish(UiCameraAnimationDefine.IFinishData finishData)
	{
		if (!this.IsWaitingCameraResetForRoleItems || finishData.FinishType != UiCameraAnimationDefine.ECameraAnimationFinishType.Finished || finishData.ToHandleData.ViewName != this.ViewInfo.Name || UiSceneManager.Instance.SelectFormationPosition != -1)
		{
			return;
		}
		this.FinishCameraResetForRoleItems();
	}

	// Token: 0x0600D5D9 RID: 54745 RVA: 0x00316150 File Offset: 0x00314350
	private void OnRefreshPlayerPing(int playerId, ENetPingState ping)
	{
		foreach (FormationRoleItem formationRoleItem in this.Presenter.RoleItems)
		{
			if (formationRoleItem.GetOnlineIndex().GetValueOrDefault() > 0)
			{
				int? player = formationRoleItem.GetPlayer();
				if (player.GetValueOrDefault() == playerId & player != null)
				{
					formationRoleItem.RefreshPing(ping);
				}
			}
		}
	}

	// Token: 0x0600D5DA RID: 54746 RVA: 0x003161D8 File Offset: 0x003143D8
	private void ExchangeRoleCallBack(int dropPosition, int fromPosition, int fromRoleId, int dropRoleId)
	{
		FormationModel instance = FormationModel.Instance;
		instance.SetEditingRoleId(this.EditFormationId, dropPosition, fromRoleId, true);
		instance.SetEditingRoleId(this.EditFormationId, fromPosition, dropRoleId, true);
		this.OnRefreshRoleView(new int[]
		{
			dropPosition,
			fromPosition
		});
	}

	// Token: 0x0600D5DB RID: 54747 RVA: 0x00316214 File Offset: 0x00314414
	protected override UniTask CreateAllSlotsAsync()
	{
		Formation3D.<CreateAllSlotsAsync>d__29 <CreateAllSlotsAsync>d__;
		<CreateAllSlotsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAllSlotsAsync>d__.<>4__this = this;
		<CreateAllSlotsAsync>d__.<>1__state = -1;
		<CreateAllSlotsAsync>d__.<>t__builder.Start<Formation3D.<CreateAllSlotsAsync>d__29>(ref <CreateAllSlotsAsync>d__);
		return <CreateAllSlotsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D5DC RID: 54748 RVA: 0x00316258 File Offset: 0x00314458
	[NullableContext(2)]
	protected override void RefreshAllRoleView(int formationId, int[] needRefreshPosition = null)
	{
		if (formationId != this.EditFormationId)
		{
			foreach (FormationRoleItem formationRoleItem in this.Presenter.RoleItems)
			{
				formationRoleItem.RequestStartSequenceOnRoleChanged();
			}
		}
		base.RefreshAllRoleView(formationId, needRefreshPosition);
	}

	// Token: 0x0600D5DD RID: 54749 RVA: 0x003162C0 File Offset: 0x003144C0
	[NullableContext(0)]
	protected override UniTask<long?> RefreshAllRoleViewAsync(int formationId, [Nullable(2)] int[] needRefreshPosition = null)
	{
		Formation3D.<RefreshAllRoleViewAsync>d__31 <RefreshAllRoleViewAsync>d__;
		<RefreshAllRoleViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<long?>.Create();
		<RefreshAllRoleViewAsync>d__.<>4__this = this;
		<RefreshAllRoleViewAsync>d__.formationId = formationId;
		<RefreshAllRoleViewAsync>d__.needRefreshPosition = needRefreshPosition;
		<RefreshAllRoleViewAsync>d__.<>1__state = -1;
		<RefreshAllRoleViewAsync>d__.<>t__builder.Start<Formation3D.<RefreshAllRoleViewAsync>d__31>(ref <RefreshAllRoleViewAsync>d__);
		return <RefreshAllRoleViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D5DE RID: 54750 RVA: 0x00316314 File Offset: 0x00314514
	protected override TeamRoleSelectViewData GetRoleSelectViewData()
	{
		TeamRoleSelectViewData roleSelectViewData = base.GetRoleSelectViewData();
		Action<int> confirmCallback = roleSelectViewData.ConfirmCallBack;
		roleSelectViewData.ConfirmCallBack = delegate(int roleId)
		{
			Action<int> confirmCallback = confirmCallback;
			if (confirmCallback != null)
			{
				confirmCallback(roleId);
			}
			this.RoleSelectDeployEffectPosition = ((FormationModel.Instance.GetEditingRoleId(this.EditFormationId, this.EditPosition) == roleId) ? this.EditPosition : 0);
		};
		Action backCallback = roleSelectViewData.BackCallBack;
		roleSelectViewData.BackCallBack = delegate()
		{
			this.RoleSelectDeployEffectPosition = 0;
			Action backCallback = backCallback;
			if (backCallback == null)
			{
				return;
			}
			backCallback();
		};
		roleSelectViewData.SetHideFinishCallBack(new Action(this.OnRoleSelectHideFinished));
		roleSelectViewData.OnRoleSelect = new Action<int>(this.OnRoleSelect);
		roleSelectViewData.OnModelLoadingAnchorChanged = new Action<UUIItem>(this.OnModelLoadingAnchorChanged);
		roleSelectViewData.OnDetailOpen = new Action(this.OnRoleDetailOpen);
		roleSelectViewData.OnDetailClose = new Action(this.OnRoleDetailClose);
		return roleSelectViewData;
	}

	// Token: 0x0600D5DF RID: 54751 RVA: 0x003163CC File Offset: 0x003145CC
	private void OnRoleSelectHideFinished()
	{
		int roleSelectDeployEffectPosition = this.RoleSelectDeployEffectPosition;
		this.RoleSelectDeployEffectPosition = 0;
		if (roleSelectDeployEffectPosition > 0)
		{
			FormationRoleItem byPosition = this.Presenter.GetByPosition(roleSelectDeployEffectPosition);
			if (byPosition != null)
			{
				byPosition.RequestDeployEffectOnNextRefresh();
			}
		}
		this.OnRefreshRoleView(null);
		this.SetRoleSelectPreviewMode(false);
	}

	// Token: 0x0600D5E0 RID: 54752 RVA: 0x00316410 File Offset: 0x00314610
	private void SetRoleSelectPreviewMode(bool isPreview)
	{
		foreach (FormationRoleItem formationRoleItem in this.Presenter.RoleItems)
		{
			formationRoleItem.SetRoleSelectPreviewMode(isPreview);
		}
	}

	// Token: 0x0600D5E1 RID: 54753 RVA: 0x00316468 File Offset: 0x00314668
	[NullableContext(2)]
	private void OnModelLoadingAnchorChanged(UUIItem anchor)
	{
		FormationRoleItem byPosition = this.Presenter.GetByPosition(this.EditPosition);
		if (byPosition == null)
		{
			return;
		}
		byPosition.SetModelLoadingAnchor(anchor);
	}

	// Token: 0x0600D5E2 RID: 54754 RVA: 0x00316486 File Offset: 0x00314686
	private void OnRoleDetailOpen()
	{
		UiSceneManager.Instance.SetRoleFormationActorsVisibleExcept(-1, false);
	}

	// Token: 0x0600D5E3 RID: 54755 RVA: 0x00316494 File Offset: 0x00314694
	private void OnRoleDetailClose()
	{
		UiSceneManager.Instance.SetRoleFormationActorsVisibleExcept(this.EditPosition, false);
		FormationRoleItem byPosition = this.Presenter.GetByPosition(this.EditPosition);
		if (byPosition == null)
		{
			return;
		}
		byPosition.RefreshRoleOrnaments();
	}

	// Token: 0x0600D5E4 RID: 54756 RVA: 0x003164C4 File Offset: 0x003146C4
	private void OnRoleSelect(int roleId)
	{
		FormationRoleItem byPosition = this.Presenter.GetByPosition(this.EditPosition);
		if (byPosition == null)
		{
			return;
		}
		RoleModel instance = RoleModel.Instance;
		RoleDataBase roleDataBase = (instance != null) ? instance.GetRoleDataById(roleId, true) : null;
		if (roleDataBase == null)
		{
			byPosition.ResetRole();
			return;
		}
		int roleSkinId = roleDataBase.GetRoleSkinId();
		RoleLevelData levelData = roleDataBase.GetLevelData();
		int level = (levelData != null) ? levelData.GetLevel() : 0;
		string roleName = RoleModel.Instance.GetRoleName(roleId, null);
		CreatureModel instance2 = CreatureModel.Instance;
		int playerId = (instance2 != null) ? instance2.GetPlayerId() : 0;
		PlayerInfoModel instance3 = PlayerInfoModel.Instance;
		string thirdPartyOnlineId = ((instance3 != null) ? instance3.GetThirdPartyOnlineId() : null) ?? "";
		IRoleSlotDisplayData data = new IRoleSlotDisplayData
		{
			ConfigId = roleId,
			SkinId = roleSkinId,
			Level = level,
			Name = roleName,
			OnlineIndex = 0,
			PlayerId = playerId,
			ThirdPartyOnlineId = thirdPartyOnlineId,
			CanUseSpecialTrialRole = this.CanUseSpecialTrailRole,
			IsDead = false,
			IsTrialRole = roleDataBase.IsTrialRole(),
			IsSelf = true,
			IsMultiContext = false,
			IsThirdPartyVisible = false
		};
		int editPosition = this.EditPosition;
		byPosition.Refresh(data);
		this.AdaptRoleSelectCameraToPreview(editPosition, roleId, roleSkinId);
	}

	// Token: 0x0600D5E5 RID: 54757 RVA: 0x003165F0 File Offset: 0x003147F0
	private void AdaptRoleSelectCameraToPreview(int position, int roleId, int skinId)
	{
		if (UiSceneManager.Instance.SelectFormationPosition != position)
		{
			return;
		}
		if (this.SkipNextCameraAdapt)
		{
			this.SkipNextCameraAdapt = false;
			return;
		}
		FTransformDouble? ftransformDouble = this.BuildRoleFocusTransform(position, roleId, skinId);
		if (ftransformDouble == null)
		{
			return;
		}
		UiCameraAnimationManager.Instance.RefreshCurrentCameraExternalTransform(ftransformDouble.Value, false);
	}

	// Token: 0x0600D5E6 RID: 54758 RVA: 0x00316644 File Offset: 0x00314844
	protected override void OnEnterRoleSelectScene(int position)
	{
		this.RoleSelectDeployEffectPosition = 0;
		this.SetRoleSelectPreviewMode(true);
		UiSceneManager.Instance.SelectFormationPosition = position;
		this.CacheRoleSelectInitialCameraLocation();
		IRoleSlotDisplayData roleSlotDisplayData = this.Provider.BuildSlotDisplayData(this.EditFormationId, position);
		bool flag = roleSlotDisplayData.ConfigId > 0;
		UiSceneManager.Instance.SetRoleFormationActorsVisibleExcept(flag ? position : -1, false);
		string viewName = FormationDefine.FormationPositionToCameraRecord[position];
		FTransformDouble? externalTransform = (roleSlotDisplayData.ConfigId != 0) ? this.BuildRoleFocusTransform(position, roleSlotDisplayData.ConfigId, roleSlotDisplayData.SkinId) : null;
		this.SkipNextCameraAdapt = (externalTransform != null);
		UiCameraAnimationManager.Instance.PushCameraHandleByOpenView(viewName, null, true, externalTransform, this.ViewInfo.Name);
	}

	// Token: 0x0600D5E7 RID: 54759 RVA: 0x00316708 File Offset: 0x00314908
	private FTransformDouble? BuildRoleFocusTransform(int position, int roleId, int skinId)
	{
		int? num;
		if (!RoleUtils.IsTrialRole(roleId))
		{
			num = null;
		}
		else
		{
			TrialRoleConfig instance = TrialRoleConfig.Instance;
			TrialRoleInfo? trialRoleInfo;
			num = ((instance != null) ? ((instance.GetTrialRoleConfig(roleId) != null) ? new int?(trialRoleInfo.GetValueOrDefault().ParentId) : null) : null);
		}
		int? num2 = num;
		int roleId2 = (num2 > 0) ? num2.Value : roleId;
		FormationConfig instance2 = FormationConfig.Instance;
		FormationMotion? formationMotion = (instance2 != null) ? instance2.GetFormationMotionConfigByRoleIdAndPosition(roleId2, position, skinId) : null;
		Aki.Config.Vector? vector = (formationMotion != null) ? formationMotion.GetValueOrDefault().FocusPos : null;
		if (vector == null)
		{
			return null;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
		defaultInterpolatedStringHandler.AppendLiteral("RoleCase");
		defaultInterpolatedStringHandler.AppendFormatted<int>(position);
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(defaultInterpolatedStringHandler.ToStringAndClear()).Value, ECollectActorType.UI);
		FTransformDouble? ftransformDouble = (actorWithTag != null) ? new FTransformDouble?(actorWithTag.D_GetTransform()) : null;
		if (ftransformDouble == null)
		{
			return null;
		}
		FTransformDouble value = ftransformDouble.Value;
		FVectorDouble fvectorDouble = new FVectorDouble((double)vector.Value.X, (double)vector.Value.Y, (double)vector.Value.Z);
		FVectorDouble focusWorldLocation = value.TransformPosition(fvectorDouble);
		Aki.Config.Vector? vector2 = (formationMotion != null) ? formationMotion.GetValueOrDefault().Offset : null;
		Aki.Config.Vector? vector3 = (formationMotion != null) ? formationMotion.GetValueOrDefault().OffsetRotation : null;
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("Formation3DCameraOffsetLocation");
		IReadOnlyList<int> intArrayConfig2 = ConfigCommonParamById.GetIntArrayConfig("Formation3DCameraOffsetRotation");
		if (this.InitialCameraLocation == null)
		{
			return null;
		}
		fvectorDouble = this.InitialCameraLocation.Value;
		FRotator frotator = UKismetMathLibrary.D_FindLookAtRotation(fvectorDouble, focusWorldLocation);
		FVectorDouble fvectorDouble2 = this.BuildRoleFocusCameraLocation(focusWorldLocation, intArrayConfig, frotator);
		FVectorDouble fvectorDouble3 = new FVectorDouble(fvectorDouble2.X + (double)((vector2 != null) ? vector2.GetValueOrDefault().X : 0f), fvectorDouble2.Y + (double)((vector2 != null) ? vector2.GetValueOrDefault().Y : 0f), fvectorDouble2.Z + (double)((vector2 != null) ? vector2.GetValueOrDefault().Z : 0f));
		FRotator frotator2 = new FRotator(frotator.Pitch + (float)Formation3D.GetListValue(intArrayConfig2, 1) + ((vector3 != null) ? vector3.GetValueOrDefault().Y : 0f), frotator.Yaw + (float)Formation3D.GetListValue(intArrayConfig2, 2) + ((vector3 != null) ? vector3.GetValueOrDefault().Z : 0f), frotator.Roll + (float)Formation3D.GetListValue(intArrayConfig2, 0) + ((vector3 != null) ? vector3.GetValueOrDefault().X : 0f));
		fvectorDouble = new FVectorDouble(1.0, 1.0, 1.0);
		FVector fvector = fvectorDouble;
		return new FTransformDouble?(new FTransformDouble(ref frotator2, ref fvectorDouble3, ref fvector));
	}

	// Token: 0x0600D5E8 RID: 54760 RVA: 0x00316A9C File Offset: 0x00314C9C
	private void CacheRoleSelectInitialCameraLocation()
	{
		if (this.InitialCameraLocation != null)
		{
			return;
		}
		UiCameraHandleData lastHandleData = UiCameraAnimationManager.Instance.GetLastHandleData();
		FVectorDouble? fvectorDouble = (lastHandleData != null) ? lastHandleData.GetTargetLocation() : null;
		if (fvectorDouble == null)
		{
			return;
		}
		this.InitialCameraLocation = new FVectorDouble?(new FVectorDouble(fvectorDouble.Value.X, fvectorDouble.Value.Y, fvectorDouble.Value.Z));
	}

	// Token: 0x0600D5E9 RID: 54761 RVA: 0x00316B14 File Offset: 0x00314D14
	[NullableContext(2)]
	private FVectorDouble BuildRoleFocusCameraLocation(FVectorDouble focusWorldLocation, IReadOnlyList<int> commonOffset, FRotator baseRotation)
	{
		FVectorDouble fvectorDouble = baseRotation.VectorDouble();
		FVector rightVector = UKismetMathLibrary.GetRightVector(baseRotation);
		return new FVectorDouble(focusWorldLocation.X + fvectorDouble.X * (double)Formation3D.GetListValue(commonOffset, 0) + (double)(rightVector.X * (float)Formation3D.GetListValue(commonOffset, 1)), focusWorldLocation.Y + fvectorDouble.Y * (double)Formation3D.GetListValue(commonOffset, 0) + (double)(rightVector.Y * (float)Formation3D.GetListValue(commonOffset, 1)), focusWorldLocation.Z + fvectorDouble.Z * (double)Formation3D.GetListValue(commonOffset, 0) + (double)(rightVector.Z * (float)Formation3D.GetListValue(commonOffset, 1)) + (double)Formation3D.GetListValue(commonOffset, 2));
	}

	// Token: 0x0600D5EA RID: 54762 RVA: 0x00316BB3 File Offset: 0x00314DB3
	[NullableContext(2)]
	private static int GetListValue(IReadOnlyList<int> values, int index)
	{
		if (values == null || values.Count <= index)
		{
			return 0;
		}
		return values[index];
	}

	// Token: 0x0600D5EB RID: 54763 RVA: 0x00316BCC File Offset: 0x00314DCC
	protected override void OnExitRoleSelectScene()
	{
		UiSceneManager.Instance.SelectFormationPosition = -1;
		UiSceneManager.Instance.SetRoleFormationActorsVisibleExcept(-1, true);
		this.IsWaitingCameraResetForRoleItems = true;
		this.SetRoleItemsVisible(false);
		base.PlayTabStartSequence();
		UiCameraAnimationManager.Instance.PushCameraHandleByOpenView(this.ViewInfo.Name, null, true, null, null);
		if (!UiCameraAnimationManager.Instance.IsPlayingAnimation())
		{
			this.FinishCameraResetForRoleItems();
		}
	}

	// Token: 0x0600D5EC RID: 54764 RVA: 0x00316C44 File Offset: 0x00314E44
	private void FinishCameraResetForRoleItems()
	{
		if (!this.IsWaitingCameraResetForRoleItems)
		{
			return;
		}
		this.IsWaitingCameraResetForRoleItems = false;
		this.SetRoleItemsVisible(true);
	}

	// Token: 0x0600D5ED RID: 54765 RVA: 0x00316C60 File Offset: 0x00314E60
	private void SetRoleItemsVisible(bool visible)
	{
		foreach (FormationRoleItem formationRoleItem in this.Presenter.RoleItems)
		{
			formationRoleItem.SetSlotVisibleWithSequence(visible, true);
		}
	}

	// Token: 0x040061D4 RID: 25044
	private bool SkipNextCameraAdapt;

	// Token: 0x040061D5 RID: 25045
	private FVectorDouble? InitialCameraLocation;

	// Token: 0x040061D6 RID: 25046
	private bool IsWaitingCameraResetForRoleItems;

	// Token: 0x040061D7 RID: 25047
	private int RoleSelectDeployEffectPosition;

	// Token: 0x0200819F RID: 33183
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A4C0 RID: 173248
		TabComponent,
		// Token: 0x0402A4C1 RID: 173249
		ConfirmButton,
		// Token: 0x0402A4C2 RID: 173250
		ConfirmText,
		// Token: 0x0402A4C3 RID: 173251
		CloseButton,
		// Token: 0x0402A4C4 RID: 173252
		QuickSelectButton,
		// Token: 0x0402A4C5 RID: 173253
		LoadingItem,
		// Token: 0x0402A4C6 RID: 173254
		DescToggleItem,
		// Token: 0x0402A4C7 RID: 173255
		TeamRoleSlot1,
		// Token: 0x0402A4C8 RID: 173256
		TeamRoleSlot2,
		// Token: 0x0402A4C9 RID: 173257
		TeamRoleSlot3,
		// Token: 0x0402A4CA RID: 173258
		PanelPresetForm,
		// Token: 0x0402A4CB RID: 173259
		BtnPresetForm,
		// Token: 0x0402A4CC RID: 173260
		BtnEditFormName,
		// Token: 0x0402A4CD RID: 173261
		PanelRoleItemAll,
		// Token: 0x0402A4CE RID: 173262
		DragRoleItem
	}
}

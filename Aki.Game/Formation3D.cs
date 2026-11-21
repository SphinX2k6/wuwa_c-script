using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010BC RID: 4284
[NullableContext(1)]
[Nullable(0)]
public class Formation3D : FormationFlavorViewBase
{
	// Token: 0x0600A9DE RID: 43486 RVA: 0x00320ED0 File Offset: 0x0031F0D0
	public Formation3D(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x170011C7 RID: 4551
	// (get) Token: 0x0600A9DF RID: 43487 RVA: 0x00320F56 File Offset: 0x0031F156
	protected virtual SlotPresenter3D Presenter { [PreserveBaseOverrides] get; } = new SlotPresenter3D();

	// Token: 0x170011C8 RID: 4552
	// (get) Token: 0x0600A9E0 RID: 43488 RVA: 0x00320F5E File Offset: 0x0031F15E
	protected override EUiViewName RoleSelectViewName { get; } = EUiViewName.TeamSceneRoleSelectView;

	// Token: 0x170011C9 RID: 4553
	// (get) Token: 0x0600A9E1 RID: 43489 RVA: 0x00320F66 File Offset: 0x0031F166
	protected override FormationActionKeys FormationActionKeys { get; } = new FormationActionKeys
	{
		PresetForm = 11,
		EditFormName = 12
	};

	// Token: 0x170011CA RID: 4554
	// (get) Token: 0x0600A9E2 RID: 43490 RVA: 0x00320F6E File Offset: 0x0031F16E
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

	// Token: 0x0600A9E3 RID: 43491 RVA: 0x00320F78 File Offset: 0x0031F178
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

	// Token: 0x0600A9E4 RID: 43492 RVA: 0x00321263 File Offset: 0x0031F463
	protected override IFormationTabComponent CreateFormationTabComponent(UUIItem uiItem, CommonTabComponentData<EditFormationTabItem> data)
	{
		return new Formation3DTabComponent(uiItem, data, new Func<int, bool>(this.IsCurrentTab));
	}

	// Token: 0x0600A9E5 RID: 43493 RVA: 0x00321279 File Offset: 0x0031F479
	public override string GetBlackScreenStyleOnOpen()
	{
		return "Formation3D";
	}

	// Token: 0x0600A9E6 RID: 43494 RVA: 0x00321280 File Offset: 0x0031F480
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

	// Token: 0x0600A9E7 RID: 43495 RVA: 0x003212BA File Offset: 0x0031F4BA
	protected override void OnBeforeHide()
	{
		this.FinishCameraResetForRoleItems();
		base.OnBeforeHide();
	}

	// Token: 0x0600A9E8 RID: 43496 RVA: 0x003212C8 File Offset: 0x0031F4C8
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

	// Token: 0x0600A9E9 RID: 43497 RVA: 0x00321340 File Offset: 0x0031F540
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraDefine.IFinishData>(this.OnPlayCameraAnimationFinish));
		if (GameModeModel.Instance.IsMulti)
		{
			EventSystem.Instance.Add<int, ENetPingState>(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing));
		}
	}

	// Token: 0x0600A9EA RID: 43498 RVA: 0x00321394 File Offset: 0x0031F594
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraDefine.IFinishData>(this.OnPlayCameraAnimationFinish));
		if (EventSystem.Instance.Has(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing)))
		{
			EventSystem.Instance.Remove<int, ENetPingState>(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing));
		}
	}

	// Token: 0x0600A9EB RID: 43499 RVA: 0x003213F8 File Offset: 0x0031F5F8
	private void OnPlayCameraAnimationFinish(UiCameraDefine.IFinishData finishData)
	{
		if (!this.IsWaitingCameraResetForRoleItems || finishData.FinishType != ECameraAnimationFinishType.Finished || finishData.ToHandleData.GetViewName() != this.ViewInfo.Name || UiSceneManager.Instance.SelectFormationPosition != -1)
		{
			return;
		}
		this.FinishCameraResetForRoleItems();
	}

	// Token: 0x0600A9EC RID: 43500 RVA: 0x0032144C File Offset: 0x0031F64C
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

	// Token: 0x0600A9ED RID: 43501 RVA: 0x003214D4 File Offset: 0x0031F6D4
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

	// Token: 0x0600A9EE RID: 43502 RVA: 0x00321510 File Offset: 0x0031F710
	protected override UniTask CreateAllSlotsAsync()
	{
		Formation3D.<CreateAllSlotsAsync>d__29 <CreateAllSlotsAsync>d__;
		<CreateAllSlotsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAllSlotsAsync>d__.<>4__this = this;
		<CreateAllSlotsAsync>d__.<>1__state = -1;
		<CreateAllSlotsAsync>d__.<>t__builder.Start<Formation3D.<CreateAllSlotsAsync>d__29>(ref <CreateAllSlotsAsync>d__);
		return <CreateAllSlotsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A9EF RID: 43503 RVA: 0x00321554 File Offset: 0x0031F754
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

	// Token: 0x0600A9F0 RID: 43504 RVA: 0x003215BC File Offset: 0x0031F7BC
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

	// Token: 0x0600A9F1 RID: 43505 RVA: 0x00321610 File Offset: 0x0031F810
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

	// Token: 0x0600A9F2 RID: 43506 RVA: 0x003216C8 File Offset: 0x0031F8C8
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

	// Token: 0x0600A9F3 RID: 43507 RVA: 0x0032170C File Offset: 0x0031F90C
	private void SetRoleSelectPreviewMode(bool isPreview)
	{
		foreach (FormationRoleItem formationRoleItem in this.Presenter.RoleItems)
		{
			formationRoleItem.SetRoleSelectPreviewMode(isPreview);
		}
	}

	// Token: 0x0600A9F4 RID: 43508 RVA: 0x00321764 File Offset: 0x0031F964
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

	// Token: 0x0600A9F5 RID: 43509 RVA: 0x00321782 File Offset: 0x0031F982
	private void OnRoleDetailOpen()
	{
		UiSceneManager.Instance.SetRoleFormationActorsVisibleExcept(-1, false);
	}

	// Token: 0x0600A9F6 RID: 43510 RVA: 0x00321790 File Offset: 0x0031F990
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

	// Token: 0x0600A9F7 RID: 43511 RVA: 0x003217C0 File Offset: 0x0031F9C0
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

	// Token: 0x0600A9F8 RID: 43512 RVA: 0x003218EC File Offset: 0x0031FAEC
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
		UiCameraModel.Instance.RefreshCurrentTransformHandle(ftransformDouble.Value, false);
	}

	// Token: 0x0600A9F9 RID: 43513 RVA: 0x00321940 File Offset: 0x0031FB40
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
		FTransformDouble? transform = (roleSlotDisplayData.ConfigId != 0) ? this.BuildRoleFocusTransform(position, roleSlotDisplayData.ConfigId, roleSlotDisplayData.SkinId) : null;
		this.SkipNextCameraAdapt = (transform != null);
		UiCameraModel.Instance.PushTransformCameraHandleByViewName(viewName, transform, true);
	}

	// Token: 0x0600A9FA RID: 43514 RVA: 0x003219EC File Offset: 0x0031FBEC
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

	// Token: 0x0600A9FB RID: 43515 RVA: 0x00321D80 File Offset: 0x0031FF80
	private void CacheRoleSelectInitialCameraLocation()
	{
		if (this.InitialCameraLocation != null)
		{
			return;
		}
		UiCameraHandleData lastHandleData = UiCameraModel.Instance.GetLastHandleData();
		FVectorDouble? fvectorDouble = (lastHandleData != null) ? new FVectorDouble?(lastHandleData.GetTargetLocation()) : null;
		if (fvectorDouble == null)
		{
			return;
		}
		this.InitialCameraLocation = new FVectorDouble?(new FVectorDouble(fvectorDouble.Value.X, fvectorDouble.Value.Y, fvectorDouble.Value.Z));
	}

	// Token: 0x0600A9FC RID: 43516 RVA: 0x00321E00 File Offset: 0x00320000
	[NullableContext(2)]
	private FVectorDouble BuildRoleFocusCameraLocation(FVectorDouble focusWorldLocation, IReadOnlyList<int> commonOffset, FRotator baseRotation)
	{
		FVectorDouble fvectorDouble = baseRotation.VectorDouble();
		FVector rightVector = UKismetMathLibrary.GetRightVector(baseRotation);
		return new FVectorDouble(focusWorldLocation.X + fvectorDouble.X * (double)Formation3D.GetListValue(commonOffset, 0) + (double)(rightVector.X * (float)Formation3D.GetListValue(commonOffset, 1)), focusWorldLocation.Y + fvectorDouble.Y * (double)Formation3D.GetListValue(commonOffset, 0) + (double)(rightVector.Y * (float)Formation3D.GetListValue(commonOffset, 1)), focusWorldLocation.Z + fvectorDouble.Z * (double)Formation3D.GetListValue(commonOffset, 0) + (double)(rightVector.Z * (float)Formation3D.GetListValue(commonOffset, 1)) + (double)Formation3D.GetListValue(commonOffset, 2));
	}

	// Token: 0x0600A9FD RID: 43517 RVA: 0x00321E9F File Offset: 0x0032009F
	[NullableContext(2)]
	private static int GetListValue(IReadOnlyList<int> values, int index)
	{
		if (values == null || values.Count <= index)
		{
			return 0;
		}
		return values[index];
	}

	// Token: 0x0600A9FE RID: 43518 RVA: 0x00321EB8 File Offset: 0x003200B8
	protected override void OnExitRoleSelectScene()
	{
		UiSceneManager.Instance.SelectFormationPosition = -1;
		UiSceneManager.Instance.SetRoleFormationActorsVisibleExcept(-1, true);
		this.IsWaitingCameraResetForRoleItems = true;
		this.SetRoleItemsVisible(false);
		base.PlayTabStartSequence();
		UiCameraModel.Instance.PushCameraHandleByViewName(this.ViewInfo.Name, true);
		if (!UiCameraModel.Instance.IsPlayingAnimation())
		{
			this.FinishCameraResetForRoleItems();
		}
	}

	// Token: 0x0600A9FF RID: 43519 RVA: 0x00321F1E File Offset: 0x0032011E
	private void FinishCameraResetForRoleItems()
	{
		if (!this.IsWaitingCameraResetForRoleItems)
		{
			return;
		}
		this.IsWaitingCameraResetForRoleItems = false;
		this.SetRoleItemsVisible(true);
	}

	// Token: 0x0600AA00 RID: 43520 RVA: 0x00321F38 File Offset: 0x00320138
	private void SetRoleItemsVisible(bool visible)
	{
		foreach (FormationRoleItem formationRoleItem in this.Presenter.RoleItems)
		{
			formationRoleItem.SetSlotVisibleWithSequence(visible, true);
		}
	}

	// Token: 0x040062A6 RID: 25254
	private bool SkipNextCameraAdapt;

	// Token: 0x040062A7 RID: 25255
	private FVectorDouble? InitialCameraLocation;

	// Token: 0x040062A8 RID: 25256
	private bool IsWaitingCameraResetForRoleItems;

	// Token: 0x040062A9 RID: 25257
	private int RoleSelectDeployEffectPosition;

	// Token: 0x0200732B RID: 29483
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040257EE RID: 153582
		TabComponent,
		// Token: 0x040257EF RID: 153583
		ConfirmButton,
		// Token: 0x040257F0 RID: 153584
		ConfirmText,
		// Token: 0x040257F1 RID: 153585
		CloseButton,
		// Token: 0x040257F2 RID: 153586
		QuickSelectButton,
		// Token: 0x040257F3 RID: 153587
		LoadingItem,
		// Token: 0x040257F4 RID: 153588
		DescToggleItem,
		// Token: 0x040257F5 RID: 153589
		TeamRoleSlot1,
		// Token: 0x040257F6 RID: 153590
		TeamRoleSlot2,
		// Token: 0x040257F7 RID: 153591
		TeamRoleSlot3,
		// Token: 0x040257F8 RID: 153592
		PanelPresetForm,
		// Token: 0x040257F9 RID: 153593
		BtnPresetForm,
		// Token: 0x040257FA RID: 153594
		BtnEditFormName,
		// Token: 0x040257FB RID: 153595
		PanelRoleItemAll,
		// Token: 0x040257FC RID: 153596
		DragRoleItem
	}
}

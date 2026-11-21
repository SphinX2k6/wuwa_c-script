using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.Module.SeamlessTravel;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x020025B6 RID: 9654
[NullableContext(1)]
[Nullable(0)]
public class CharacterGlideComponent : EntityComponent
{
	// Token: 0x17002570 RID: 9584
	// (get) Token: 0x06017F39 RID: 98105 RVA: 0x00726F60 File Offset: 0x00725160
	public bool SoarBoostOn
	{
		get
		{
			return this.SoarBoostOnInternal;
		}
	}

	// Token: 0x06017F3A RID: 98106 RVA: 0x00726F68 File Offset: 0x00725168
	public void RefreshSoarBoost()
	{
		bool flag = (this.SoarBoostOnNormal || this.SoarBoostOnSpec) && this.TagComponent != null && this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA"]);
		if (this.SoarBoostOnInternal == flag)
		{
			return;
		}
		this.SoarBoostOnInternal = flag;
		if (this.SoarBoostOnInternal)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null)
			{
				return;
			}
			tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA.冲刺"]));
			return;
		}
		else
		{
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 == null)
			{
				return;
			}
			tagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA.冲刺"]));
			return;
		}
	}

	// Token: 0x06017F3B RID: 98107 RVA: 0x0072700E File Offset: 0x0072520E
	private void OnPositionStateChanged(ECharPositionState oldMoveState, ECharPositionState newMoveState)
	{
		this.RefreshSoarBoost();
		this.RefreshEnableAutoFlight();
		this.RefreshSoarExploreIcon();
	}

	// Token: 0x06017F3C RID: 98108 RVA: 0x00727024 File Offset: 0x00725224
	private void OnMoveStateChanged(ECharMoveState oldMoveState, ECharMoveState newMoveState)
	{
		if (newMoveState == ECharMoveState.Soar)
		{
			this.ActorComp.ClearInput(false, true);
			this.CalculateSoarQuat();
			this.CurrentSoarQuat.RotateVector(global::Vector.UpVectorProxy, this.CurrentSoarNormal);
			this.SoarBoostOnNormal = false;
			this.SoarBalanceOn = false;
			this.InSoarSplineMove = false;
			this.SoarUpDownState = CharacterGlideComponent.ESoarUpDownState.Normal;
			this.OffsetNormalAngle = 0f;
			this.OffsetTurnAngle = 0f;
			this.RefreshSoarMaterialEffect();
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA.冲刺可用"]));
			}
			FKuroPerfSightHelper.BeginExtTag("Soar");
		}
		if (oldMoveState == ECharMoveState.Soar)
		{
			FKuroPerfSightHelper.EndExtTag("Soar");
			this.RefreshSoarMaterialEffect();
		}
		this.RefreshSoarBoost();
		this.RefreshEnableAutoFlight();
	}

	// Token: 0x17002571 RID: 9585
	// (get) Token: 0x06017F3D RID: 98109 RVA: 0x007270EA File Offset: 0x007252EA
	// (set) Token: 0x06017F3E RID: 98110 RVA: 0x007270F4 File Offset: 0x007252F4
	private bool InSoarSplineMove
	{
		get
		{
			return this.InSoarSplineMoveInternal;
		}
		set
		{
			if (this.InSoarSplineMoveInternal == value)
			{
				return;
			}
			this.InSoarSplineMoveInternal = value;
			if (value)
			{
				this.JustEnterSoarSplineMove = true;
				this.CurrentSoarNormal.CrossProduct(this.ActorComp.ActorForwardProxy, this.SoarSplineTargetDirect);
				this.SoarSplineTargetDirect.CrossProductEqual(this.CurrentSoarNormal);
				if (!this.SoarSplineTargetDirect.Normalize(9.99999993922529E-09))
				{
					this.SoarSplineTargetDirect.DeepCopy(this.ActorComp.ActorForwardProxy);
				}
				CharacterGlideComponent.TmpRotator.Set(0f, this.OffsetTurnAngle, 0f);
				CharacterGlideComponent.TmpRotator.Quaternion(CharacterGlideComponent.TmpQuat);
				this.ActorComp.ActorQuatProxy.Multiply(CharacterGlideComponent.TmpQuat, CharacterGlideComponent.TmpQuat);
				this.ActorComp.ActorQuatProxy.Inverse(CharacterGlideComponent.TmpQuat2);
				CharacterGlideComponent.TmpQuat2.RotateVector(this.SoarSplineTargetDirect, this.SoarSplineTargetDirect);
				CharacterGlideComponent.TmpQuat.RotateVector(this.SoarSplineTargetDirect, this.SoarSplineTargetDirect);
				BaseTagComponent tagComponent = this.TagComponent;
				if (tagComponent != null)
				{
					tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA.风道中"]));
				}
			}
			else
			{
				this.CurrentSoarQuat.RotateVector(global::Vector.UpVectorProxy, this.CurrentSoarNormal);
				this.OffsetNormalAngle = 0f;
				this.ActorComp.ActorQuatProxy.Inverse(CharacterGlideComponent.TmpQuat2);
				CharacterGlideComponent.TmpQuat2.RotateVector(this.SoarSplineTargetDirect, CharacterGlideComponent.TmpVector);
				this.OffsetTurnAngle = (float)Math.Atan2(CharacterGlideComponent.TmpVector.Y, CharacterGlideComponent.TmpVector.X) * 57.29578f;
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 != null)
				{
					tagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA.风道中"]));
				}
			}
			this.RefreshEnableAutoFlight();
		}
	}

	// Token: 0x17002572 RID: 9586
	// (get) Token: 0x06017F3F RID: 98111 RVA: 0x007272C8 File Offset: 0x007254C8
	// (set) Token: 0x06017F40 RID: 98112 RVA: 0x007272D0 File Offset: 0x007254D0
	private bool EnableAutoFlight
	{
		get
		{
			return this.EnableAutoFlightInternal;
		}
		set
		{
			if (this.EnableAutoFlightInternal == value)
			{
				return;
			}
			this.EnableAutoFlightInternal = value;
			if (value)
			{
				BP_CameraDrivenAutoFlightData_C loadedAsset = ResourceSystem.Instance.GetLoadedAsset<BP_CameraDrivenAutoFlightData_C>("/Game/Aki/Character/Input/DataAsset/DA_CameraDrivenAutoFlightData.DA_CameraDrivenAutoFlightData");
				if (loadedAsset != null)
				{
					CharacterInputComponent component = base.Entity.GetComponent<CharacterInputComponent>();
					if (component == null)
					{
						return;
					}
					component.TurnOnCameraDrivenAutoFlightMode(loadedAsset);
					return;
				}
			}
			else
			{
				CharacterInputComponent component2 = base.Entity.GetComponent<CharacterInputComponent>();
				if (component2 == null)
				{
					return;
				}
				component2.TurnOffCameraDrivenAutoFlightMode();
			}
		}
	}

	// Token: 0x06017F41 RID: 98113 RVA: 0x00727330 File Offset: 0x00725530
	private void RefreshEnableAutoFlight()
	{
		this.EnableAutoFlight = (!this.InSoarSplineMove && this.TagComponent != null && this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA"]));
	}

	// Token: 0x17002573 RID: 9587
	// (get) Token: 0x06017F42 RID: 98114 RVA: 0x00727365 File Offset: 0x00725565
	// (set) Token: 0x06017F43 RID: 98115 RVA: 0x00727370 File Offset: 0x00725570
	private CharacterGlideComponent.ESoarUpDownState SoarUpDownState
	{
		get
		{
			return this.SoarUpDownStateInternal;
		}
		set
		{
			if (this.SoarUpDownStateInternal == value)
			{
				return;
			}
			if (this.TagComponent != null)
			{
				if (this.SoarUpDownStateInternal == CharacterGlideComponent.ESoarUpDownState.Up)
				{
					this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA.向上运动"]));
				}
				else if (this.SoarUpDownStateInternal == CharacterGlideComponent.ESoarUpDownState.Down)
				{
					this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA.向下运动"]));
				}
				if (value == CharacterGlideComponent.ESoarUpDownState.Up)
				{
					this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA.向上运动"]));
				}
				else if (value == CharacterGlideComponent.ESoarUpDownState.Down)
				{
					this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA.向下运动"]));
				}
			}
			this.SoarUpDownStateInternal = value;
		}
	}

	// Token: 0x06017F44 RID: 98116 RVA: 0x00727434 File Offset: 0x00725634
	private void ReceiveGlideEvent(float deltaSeconds)
	{
		if (SeamlessTravelModel.Instance.GetIsKeepingCurrentMovementMode() || TeleportModel.Instance.GetIsKeepingCurrentMovementMode())
		{
			return;
		}
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.滑翔禁止"]))
		{
			this.ExitGlideState("CharacterGlideComponent");
			return;
		}
		BaseTagComponent tagComponent2 = this.TagComponent;
		if (tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为改变.滑翔无重力"]))
		{
			this.MoveComponent.CharacterMovement.KuroFlying(deltaSeconds, 0f, 0.1f, 0.068f, 55f, 650f, 250f);
			return;
		}
		this.MoveComponent.CharacterMovement.KuroFlying(deltaSeconds, 15f, 0.1f, 0.068f, 55f, 650f, 250f);
	}

	// Token: 0x06017F45 RID: 98117 RVA: 0x0072750C File Offset: 0x0072570C
	private void ReceiveSoarEvent(float deltaSeconds)
	{
		if (SeamlessTravelModel.Instance.GetIsKeepingCurrentMovementMode() || TeleportModel.Instance.GetIsKeepingCurrentMovementMode())
		{
			return;
		}
		if (!this.CheckSoarAllowed().Item1)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if ((tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.滑翔禁止"])) || FormationAttributeController.Instance.GetValue(EFormationAttributeId.Strength) <= 10f)
			{
				this.ExitSoarState(EMovementMode.MOVE_Falling, "CharacterGlideComponent");
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip_001", Array.Empty<object>());
			this.EnterGlideState("CharacterGlideComponent");
			return;
		}
		else
		{
			this.InSoarSplineMove = (this.SplineMoveComp != null && this.SplineMoveComp.Active && this.SplineMoveComp.CurrentSplineMoveType == ESplineMovePattern.AirPassage);
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["关卡.翱翔.翱翔玩法速度迭代调整"]))
			{
				float deltaSeconds2;
				int num;
				if (deltaSeconds > 0.13333334f)
				{
					deltaSeconds2 = 0.033333335f;
					num = 4;
				}
				else
				{
					num = (int)Math.Ceiling((double)(deltaSeconds / 0.033333335f));
					deltaSeconds2 = deltaSeconds / (float)num;
				}
				for (int i = 0; i < num; i++)
				{
					this.SoarMove(deltaSeconds2);
				}
			}
			else
			{
				this.SoarMove(Math.Min(deltaSeconds, 0.033333335f));
			}
			float num2 = (float)Math.Asin(GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.ActorVelocityProxy) / this.ActorComp.ActorVelocityProxy.Size()) * 57.29578f;
			if (num2 > (float)ConfigCommonParamById.GetIntConfig("SoarUpwardThreshold").GetValueOrDefault(30))
			{
				this.SoarUpDownState = CharacterGlideComponent.ESoarUpDownState.Up;
				return;
			}
			if (num2 > (float)ConfigCommonParamById.GetIntConfig("SoarDownwardThreshold").GetValueOrDefault(-45))
			{
				this.SoarUpDownState = CharacterGlideComponent.ESoarUpDownState.Normal;
				return;
			}
			this.SoarUpDownState = CharacterGlideComponent.ESoarUpDownState.Down;
			return;
		}
	}

	// Token: 0x06017F46 RID: 98118 RVA: 0x007276C8 File Offset: 0x007258C8
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public ValueTuple<bool, string> CheckSoarAllowed()
	{
		if (!FunctionModel.Instance.IsOpen(EFunctionType.Soar))
		{
			return new ValueTuple<bool, string>(false, "翱翔功能未开启");
		}
		if (FunctionModel.Instance.IsLimit(10026010))
		{
			return new ValueTuple<bool, string>(false, "翱翔功能被限制");
		}
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null || !tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.准用翱翔"]))
		{
			return new ValueTuple<bool, string>(false, "缺少准用Tag");
		}
		BaseTagComponent tagComponent2 = this.TagComponent;
		if (tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.禁用翱翔"]))
		{
			return new ValueTuple<bool, string>(false, "持有禁用Tag");
		}
		if (WorldModel.Instance.IsEnableEnvironmentDetecting && GameModeModel.Instance.UseWorldPartition)
		{
			UWorld world = GlobalData.World;
			FKuroVoxelInfo fkuroVoxelInfo = new FKuroVoxelInfo();
			int num = 0;
			if (world != null && this.ActorComp != null && VoxelUtils.TryGetVoxelInfo(world, this.ActorComp.ActorLocation, ref fkuroVoxelInfo, ref num, this.ActorComp.ScaledHalfHeight + 2500f))
			{
				byte envType = fkuroVoxelInfo.EnvType;
				if (envType == 0 || envType == 2 || envType == 1 || envType == 3)
				{
					return new ValueTuple<bool, string>(false, "检测到封闭或过渡区域");
				}
			}
		}
		return new ValueTuple<bool, string>(true, null);
	}

	// Token: 0x06017F47 RID: 98119 RVA: 0x007277F4 File Offset: 0x007259F4
	private void SoarMove(float deltaSeconds)
	{
		if (this.ActorComp == null || this.MoveComponent == null)
		{
			return;
		}
		bool debugDraw = this.SoarConfigParams.DebugDraw;
		UCharacterMovementComponent characterMovement = this.MoveComponent.CharacterMovement;
		if (characterMovement == null)
		{
			return;
		}
		this.CalculateSoarQuat();
		EMoveHitType emoveHitType;
		if (!this.InSoarSplineMove)
		{
			emoveHitType = this.SoarMoveNormal(deltaSeconds, characterMovement);
		}
		else
		{
			emoveHitType = this.SoarMoveSpline(deltaSeconds, characterMovement);
		}
		this.ActorComp.ResetAllCachedTime();
		if (emoveHitType != EMoveHitType.Wall)
		{
			if (emoveHitType == EMoveHitType.Floor)
			{
				this.ExitSoarState(EMovementMode.MOVE_Walking, "CharacterGlideComponent");
				return;
			}
			this.LastNotHitTime = Time.Instance.Now;
		}
		else if (this.LastNotHitTime + (double)this.SoarConfigParams.SoarHitWallExitTimeLength < Time.Instance.Now)
		{
			this.ExitSoarState(EMovementMode.MOVE_Falling, "CharacterGlideComponent");
			return;
		}
	}

	// Token: 0x06017F48 RID: 98120 RVA: 0x007278B0 File Offset: 0x00725AB0
	protected void OnStateInherit(Entity other, bool notInheritMoveAndAnim)
	{
		if (other == null || !other.Valid)
		{
			return;
		}
		CharacterGlideComponent component = other.GetComponent<CharacterGlideComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		if (notInheritMoveAndAnim)
		{
			return;
		}
		this.CurrentSoarNormal.DeepCopy(component.CurrentSoarNormal);
		this.CurrentSoarQuat.DeepCopy(component.CurrentSoarQuat);
		this.OffsetNormalAngle = component.OffsetNormalAngle;
		this.OffsetTurnAngle = component.OffsetTurnAngle;
		this.LastNotHitTime = component.LastNotHitTime;
		this.CurrentSoarType = component.CurrentSoarType;
		component.CurrentSoarType = ESoarType.Normal;
		this.RefreshSoarExploreIcon();
	}

	// Token: 0x06017F49 RID: 98121 RVA: 0x00727940 File Offset: 0x00725B40
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.MoveComponent = base.Entity.GetComponent<CharacterMoveComponent>();
		this.WeaponComponent = base.Entity.GetComponent<CharacterWeaponComponent>();
		this.TagComponent = base.Entity.GetComponent<BaseTagComponent>();
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		this.SplineMoveComp = base.Entity.GetComponent<CharacterSplineMoveComponent>();
		this.SoarConfigParams = SoarConfigParams.SoarConfigBase;
		EventSystem.Instance.AddWithTarget<ECharMoveState, ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<ECharMoveState, ECharMoveState>(this.OnMoveStateChanged));
		EventSystem.Instance.AddWithTarget<ECharPositionState, ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnPositionStateChanged));
		EventSystem.Instance.AddWithTarget<float>(base.Entity, EEventName.CustomMoveGlide, new Action<float>(this.ReceiveGlideEvent));
		EventSystem.Instance.AddWithTarget<float>(base.Entity, EEventName.CustomMoveSoar, new Action<float>(this.ReceiveSoarEvent));
		EventSystem.Instance.Add(EEventName.OnChangeSelectedExploreId, new Action(this.RefreshSoarExploreIcon));
		this.RefreshSoarExploreIcon();
		BaseTagComponent tagComponent = this.TagComponent;
		this.OnAscentInWindTask = ((tagComponent != null) ? tagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.滑翔.在风场中"]), new BaseTagComponent.TTagSwitchedCallback(this.OnAscentInWind), null) : null);
		BaseTagComponent tagComponent2 = this.TagComponent;
		this.OnAscentBoostSpecTask = ((tagComponent2 != null) ? tagComponent2.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.强制冲刺.翱翔"]), new BaseTagComponent.TTagSwitchedCallback(this.OnAscentBoostSpec), null) : null);
		EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		return true;
	}

	// Token: 0x06017F4A RID: 98122 RVA: 0x00727AF8 File Offset: 0x00725CF8
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget<ECharMoveState, ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<ECharMoveState, ECharMoveState>(this.OnMoveStateChanged));
		EventSystem.Instance.RemoveWithTarget<ECharPositionState, ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnPositionStateChanged));
		EventSystem.Instance.RemoveWithTarget<float>(base.Entity, EEventName.CustomMoveGlide, new Action<float>(this.ReceiveGlideEvent));
		EventSystem.Instance.RemoveWithTarget<float>(base.Entity, EEventName.CustomMoveSoar, new Action<float>(this.ReceiveSoarEvent));
		EventSystem.Instance.Remove(EEventName.OnChangeSelectedExploreId, new Action(this.RefreshSoarExploreIcon));
		ITagTask onAscentInWindTask = this.OnAscentInWindTask;
		if (onAscentInWindTask != null)
		{
			onAscentInWindTask.EndTask();
		}
		this.OnAscentInWindTask = null;
		ITagTask onAscentBoostSpecTask = this.OnAscentBoostSpecTask;
		if (onAscentBoostSpecTask != null)
		{
			onAscentBoostSpecTask.EndTask();
		}
		this.OnAscentBoostSpecTask = null;
		EventSystem.Instance.RemoveWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		this.XaBoostShakeAsset = null;
		return true;
	}

	// Token: 0x06017F4B RID: 98123 RVA: 0x00727BFD File Offset: 0x00725DFD
	private void OnAscentInWind(int tagId, bool tagExist)
	{
		CharacterWeaponComponent weaponComponent = this.WeaponComponent;
		if (weaponComponent == null)
		{
			return;
		}
		weaponComponent.SetParaglidingIsAscent(tagExist);
	}

	// Token: 0x06017F4C RID: 98124 RVA: 0x00727C10 File Offset: 0x00725E10
	private void OnAscentBoostSpec(int tagId, bool tagExist)
	{
		this.SoarBoostOnSpec = tagExist;
		this.RefreshSoarBoost();
	}

	// Token: 0x06017F4D RID: 98125 RVA: 0x00727C1F File Offset: 0x00725E1F
	public void EnterGlideState(string context = "CharacterGlideComponent")
	{
		this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Custom,
			CustomMode = 2,
			Context = context
		});
	}

	// Token: 0x06017F4E RID: 98126 RVA: 0x00727C4B File Offset: 0x00725E4B
	public void ExitGlideState(string context = "CharacterGlideComponent")
	{
		this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Falling,
			CustomMode = 0,
			Context = context
		});
	}

	// Token: 0x06017F4F RID: 98127 RVA: 0x00727C78 File Offset: 0x00725E78
	public void EnterSoarState(string context = "CharacterGlideComponent")
	{
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Test;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "EnterSoarState";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Entity", base.Entity.Id);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Custom,
			CustomMode = 7,
			Context = context
		});
	}

	// Token: 0x06017F50 RID: 98128 RVA: 0x00727CE4 File Offset: 0x00725EE4
	public unsafe void ExitSoarState(EMovementMode newMovement = EMovementMode.MOVE_Falling, string context = "CharacterGlideComponent")
	{
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Test;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "ExitSoarState";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Entity", base.Entity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NewMovementMode", newMovement);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.SwitchCurrentSoarType(ESoarType.Normal);
		this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = newMovement,
			CustomMode = 0,
			Context = context
		});
	}

	// Token: 0x06017F51 RID: 98129 RVA: 0x00727D88 File Offset: 0x00725F88
	protected void CalculateSoarQuat()
	{
		if (this.ActorComp.ActorVelocityProxy.IsNearlyZero(9.999999747378752E-05))
		{
			this.CurrentSoarQuat.DeepCopy(this.ActorComp.ActorQuatProxy);
			return;
		}
		global::Vector tmpVector = CharacterGlideComponent.TmpVector;
		tmpVector.DeepCopy(this.ActorComp.ActorVelocityProxy);
		global::Vector tmpVector2 = CharacterGlideComponent.TmpVector2;
		tmpVector2.DeepCopy(this.ActorComp.ActorVelocityProxy);
		double num = GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, tmpVector2);
		if (tmpVector2.SizeSquared() < 10000.0)
		{
			CharacterGlideComponent.TmpVector2.DeepCopy(this.ActorComp.ActorForwardProxy);
			if (num > 0.0)
			{
				CharacterGlideComponent.TmpVector2.MultiplyEqual(-1.0);
			}
			MathUtils.Instance.LookRotationForwardFirst(tmpVector, CharacterGlideComponent.TmpVector2, this.CurrentSoarQuat);
			return;
		}
		MathUtils instance = MathUtils.Instance;
		global::Vector forward = tmpVector;
		CharacterActorComponent actorComp = this.ActorComp;
		instance.LookRotationForwardFirst(forward, (((actorComp != null) ? actorComp.MoveComp : null) != null) ? this.ActorComp.MoveComp.GravityUp : global::Vector.UpVectorProxy, this.CurrentSoarQuat);
	}

	// Token: 0x06017F52 RID: 98130 RVA: 0x00727EA0 File Offset: 0x007260A0
	private void SoarTurn(UCharacterMovementComponent characterMovement, float deltaSeconds)
	{
		if (MathUtils.Instance.IsNearlyZero((double)this.OffsetTurnAngle, null) || this.ActorComp == null)
		{
			return;
		}
		float num = this.OffsetTurnAngle * (1f - (float)Math.Pow((double)(1f - this.SoarConfigParams.SoarRotateLerp), (double)deltaSeconds));
		CharacterGlideComponent.TmpRotator.Set(0f, num, 0f);
		this.ActorComp.ActorQuatProxy.Inverse(CharacterGlideComponent.TmpQuat);
		this.ActorComp.AddActorLocalRotation(CharacterGlideComponent.TmpRotator.ToUeRotator(), "unknown", false);
		CharacterGlideComponent.TmpQuat.RotateVector(this.CurrentSoarNormal, this.CurrentSoarNormal);
		this.ActorComp.ActorQuatProxy.RotateVector(this.CurrentSoarNormal, this.CurrentSoarNormal);
		CharacterGlideComponent.TmpQuat.Multiply(this.CurrentSoarQuat, this.CurrentSoarQuat);
		this.ActorComp.ActorQuatProxy.Multiply(this.CurrentSoarQuat, this.CurrentSoarQuat);
		CharacterGlideComponent.TmpQuat.RotateVector(this.ActorComp.ActorVelocityProxy, CharacterGlideComponent.TmpVector);
		CharacterGlideComponent.TmpVector.X = CharacterGlideComponent.TmpVector.Size2D();
		CharacterGlideComponent.TmpVector.Y = 0.0;
		this.ActorComp.ActorQuatProxy.RotateVector(CharacterGlideComponent.TmpVector, CharacterGlideComponent.TmpVector2);
		this.ActorComp.SetActorVelocity(CharacterGlideComponent.TmpVector2);
		this.OffsetTurnAngle -= num;
		if (this.SoarConfigParams.DebugDraw)
		{
			CharacterGlideComponent.TmpRotator.Set(0f, this.OffsetTurnAngle, 0f);
			CharacterGlideComponent.TmpRotator.Quaternion(CharacterGlideComponent.TmpQuat);
			this.ActorComp.ActorQuatProxy.Multiply(CharacterGlideComponent.TmpQuat, CharacterGlideComponent.TmpQuat2);
			CharacterGlideComponent.TmpQuat2.GetForwardVector(CharacterGlideComponent.TmpVector);
			CharacterGlideComponent.TmpVector.MultiplyEqual(100.0);
			CharacterGlideComponent.TmpVector.AdditionEqual(this.ActorComp.ActorLocationProxy);
			UKismetSystemLibrary.D_DrawDebugArrow(this.ActorComp.Actor, this.ActorComp.ActorLocation, CharacterGlideComponent.TmpVector.ToUeVector(false), 100f, CharacterGlideComponent.yellowColor, 0f, 10f);
		}
	}

	// Token: 0x06017F53 RID: 98131 RVA: 0x007280E4 File Offset: 0x007262E4
	private void SoarBoost(UCharacterMovementComponent characterMovement, float deltaSeconds)
	{
		global::Vector actorVelocityProxy = this.ActorComp.ActorVelocityProxy;
		double num = actorVelocityProxy.SizeSquared();
		if (MathUtils.Instance.IsNearlyZero(num, null))
		{
			return;
		}
		float num2 = (float)Math.Sqrt(num);
		float num3 = Math.Min(num2 + deltaSeconds * this.SoarConfigParams.SoarBoostAccel, (this.InSoarSplineMove && this.SplineMoveComp.CurrentSplineMoveParams.SoarSprintLimit > 0f) ? this.SplineMoveComp.CurrentSplineMoveParams.SoarSprintLimit : this.SoarConfigParams.SoarMaxSpeed);
		actorVelocityProxy.Multiply((double)(num3 / num2), CharacterGlideComponent.TmpVector);
		bool debugDraw = this.SoarConfigParams.DebugDraw;
		this.ActorComp.SetActorVelocity(CharacterGlideComponent.TmpVector);
	}

	// Token: 0x06017F54 RID: 98132 RVA: 0x007281A4 File Offset: 0x007263A4
	private void BalanceVelocity(UCharacterMovementComponent characterMovement, float deltaSeconds)
	{
		if (this.ActorComp == null || this.ActorComp.InputDirectProxy.X > 0.0)
		{
			return;
		}
		bool flag = this.ActorComp.InputDirectProxy.X > (double)this.SoarConfigParams.SoarBalanceInputThreshold;
		float num;
		float num2;
		if (flag)
		{
			num = this.SoarConfigParams.SoarBalanceSpeed2;
			num2 = this.SoarConfigParams.SoarBalanceSpeedThreshold2;
		}
		else
		{
			num = this.SoarConfigParams.SoarBalanceSpeed;
			num2 = this.SoarConfigParams.SoarBalanceSpeedThreshold;
		}
		global::Vector actorVelocityProxy = this.ActorComp.ActorVelocityProxy;
		double num3 = actorVelocityProxy.SizeSquared();
		if (num3 > (double)(num2 * num2))
		{
			return;
		}
		if (flag)
		{
			CharacterGlideComponent.TmpVector.DeepCopy(actorVelocityProxy);
			CharacterGlideComponent.TmpVector.MultiplyEqual((double)(num / (float)Math.Sqrt(num3)));
		}
		else
		{
			this.ActorComp.ActorQuatProxy.RotateVector(this.SoarConfigParams.SoarBalanceVelocity, CharacterGlideComponent.TmpVector);
		}
		CharacterGlideComponent.TmpVector.SubtractionEqual(actorVelocityProxy);
		double num4 = CharacterGlideComponent.TmpVector.SizeSquared();
		double value = Math.Abs(actorVelocityProxy.Size() - (double)num);
		double num5 = MathUtils.Instance.RangeClamp(value, 0.0, (double)this.SoarConfigParams.SoarBalanceAccelOffset, (double)this.SoarConfigParams.SoarBalanceAccelMin, (double)this.SoarConfigParams.SoarBalanceAccelMax);
		this.SoarBalanceOn = true;
		bool debugDraw = this.SoarConfigParams.DebugDraw;
		if (num4 > num5 * num5 * (double)deltaSeconds * (double)deltaSeconds)
		{
			CharacterGlideComponent.TmpVector.MultiplyEqual(num5 * (double)deltaSeconds / (double)((float)Math.Sqrt(num4)));
		}
		CharacterGlideComponent.TmpVector.AdditionEqual(actorVelocityProxy);
		this.ActorComp.SetActorVelocity(CharacterGlideComponent.TmpVector);
	}

	// Token: 0x06017F55 RID: 98133 RVA: 0x00728354 File Offset: 0x00726554
	public void SetSoarBoostOn(bool on)
	{
		bool soarBoostOnNormal = this.SoarBoostOnNormal;
		this.SoarBoostOnNormal = (on && this.TagComponent != null && !this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.禁用翱翔冲刺"]));
		this.RefreshSoarBoost();
		if (!soarBoostOnNormal && this.SoarBoostOnNormal)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA"]))
			{
				this.TryPlayXaBoostShake();
			}
		}
	}

	// Token: 0x06017F56 RID: 98134 RVA: 0x007283D4 File Offset: 0x007265D4
	private void TryPlayXaBoostShake()
	{
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		if (this.XaBoostShakeAsset == null)
		{
			this.XaBoostShakeAsset = ResourceSystem.Instance.Load<UKuroForceFeedbackEffect>("/Game/Aki/Character/Role/Common/Data/GamePadShake/ABP_GamePlay/FF_BaseAnim_XA_Shake.FF_BaseAnim_XA_Shake", "js_undefined");
			if (this.XaBoostShakeAsset == null)
			{
				global::Log.Instance.Warn(ELogModule.Movement, ELogAuthor.ZJL, "Failed to load XaBoostShakeAsset", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
		}
		GamepadController.Instance.PlayKuroForceFeedback(this.XaBoostShakeAsset, CharacterGlideComponent.XaBoostShakeTag, false, false, false, "XaBoost");
	}

	// Token: 0x06017F57 RID: 98135 RVA: 0x00728454 File Offset: 0x00726654
	private void UpdateSoarNormalWithoutInput(float deltaSeconds, UCharacterMovementComponent characterMovement)
	{
		if (this.ActorComp == null)
		{
			return;
		}
		float num = (float)Math.Pow((double)(1f - (this.SoarBoostOnNormal ? this.SoarConfigParams.SoarBoostNormalLerp : this.SoarConfigParams.SoarNormalLerp)), (double)deltaSeconds);
		this.OffsetNormalAngle *= num;
		this.ActorComp.ActorQuatProxy.Inverse(CharacterGlideComponent.TmpQuat);
		CharacterGlideComponent.TmpQuat.RotateVector(this.CurrentSoarNormal, CharacterGlideComponent.TmpVector);
		float currentValue = (float)Math.Atan2(Math.Sqrt(MathUtils.Instance.Square(CharacterGlideComponent.TmpVector.Z) + MathUtils.Instance.Square(CharacterGlideComponent.TmpVector.Y)), CharacterGlideComponent.TmpVector.X) * 57.29578f;
		this.CurrentSoarQuat.RotateVector(global::Vector.UpVectorProxy, CharacterGlideComponent.TmpVector);
		double y = CharacterGlideComponent.TmpVector.DotProduct(this.ActorComp.ActorUpProxy);
		double x = CharacterGlideComponent.TmpVector.DotProduct(this.ActorComp.ActorForwardProxy);
		float num2 = (float)Math.Atan2(y, x) * 57.29578f;
		float from = MathUtils.Instance.Clamp(currentValue, num2 - this.SoarConfigParams.SoarInputNormalAngleMax, num2 + this.SoarConfigParams.SoarInputNormalAngleMax);
		float num3 = MathUtils.Instance.InterpConstantTo(from, this.SoarConfigParams.SoarPitchMin, deltaSeconds, this.SoarConfigParams.SoarNormalSpeedNoInput);
		bool debugDraw = this.SoarConfigParams.DebugDraw;
		float num4 = num3 * 0.017453292f;
		CharacterGlideComponent.TmpVector.X = (double)((float)Math.Cos((double)num4));
		CharacterGlideComponent.TmpVector.Y = 0.0;
		CharacterGlideComponent.TmpVector.Z = (double)((float)Math.Sin((double)num4));
		this.ActorComp.ActorQuatProxy.RotateVector(CharacterGlideComponent.TmpVector, this.CurrentSoarNormal);
	}

	// Token: 0x06017F58 RID: 98136 RVA: 0x0072861C File Offset: 0x0072681C
	private void UpdateSoarNormalWithInput(float deltaSeconds, UCharacterMovementComponent characterMovement, float currentSpeed)
	{
		if (this.ActorComp == null)
		{
			return;
		}
		float num = MathUtils.Instance.RangeClamp(currentSpeed, this.SoarConfigParams.SoarSpeedThresholdMin, this.SoarConfigParams.SoarSpeedThresholdMax, this.SoarConfigParams.SoarInputNormalAngleMin, this.SoarConfigParams.SoarInputNormalAngleMax);
		this.ActorComp.ActorQuatProxy.Inverse(CharacterGlideComponent.TmpQuat);
		CharacterGlideComponent.TmpQuat.RotateVector(this.CurrentSoarNormal, CharacterGlideComponent.TmpVector);
		float num2 = (float)Math.Atan2(CharacterGlideComponent.TmpVector.Z, CharacterGlideComponent.TmpVector.X) * 57.29578f;
		this.CurrentSoarQuat.RotateVector(global::Vector.UpVectorProxy, CharacterGlideComponent.TmpVector2);
		CharacterGlideComponent.TmpQuat.RotateVector(CharacterGlideComponent.TmpVector2, CharacterGlideComponent.TmpVector);
		float num3 = (float)Math.Atan2(CharacterGlideComponent.TmpVector.Z, CharacterGlideComponent.TmpVector.X) * 57.29578f;
		double num4 = -this.TmpInputDirect.X * (double)num + (double)num3;
		bool debugDraw = this.SoarConfigParams.DebugDraw;
		double num5 = num4 - (double)(num2 + this.OffsetNormalAngle);
		float num6 = (this.SoarBoostOnNormal ? this.SoarConfigParams.SoarBoostNormalSpeed : this.SoarConfigParams.SoarNormalSpeed) * deltaSeconds;
		if (Math.Abs(num5) < (double)num6)
		{
			this.OffsetNormalAngle += (float)num5;
		}
		else
		{
			this.OffsetNormalAngle += (float)Math.Sign(num5) * num6;
		}
		float num7 = (float)Math.Pow((double)(1f - (this.SoarBoostOnNormal ? this.SoarConfigParams.SoarBoostNormalLerp : this.SoarConfigParams.SoarNormalLerp)), (double)deltaSeconds);
		float num8 = MathUtils.Instance.Clamp(num2 + this.OffsetNormalAngle * (1f - num7), this.SoarConfigParams.SoarPitchMin, this.SoarConfigParams.SoarPitchMax);
		this.OffsetNormalAngle *= num7;
		float num9 = num8 * 0.017453292f;
		CharacterGlideComponent.TmpVector.X = (double)((float)Math.Cos((double)num9));
		CharacterGlideComponent.TmpVector.Y = 0.0;
		CharacterGlideComponent.TmpVector.Z = (double)((float)Math.Sin((double)num9));
		this.ActorComp.ActorQuatProxy.RotateVector(CharacterGlideComponent.TmpVector, this.CurrentSoarNormal);
		if (this.SoarConfigParams.DebugDraw)
		{
			CharacterGlideComponent.TmpVector.X = (double)((float)Math.Cos((double)((num8 + this.OffsetNormalAngle) * 0.017453292f)) * 100f);
			CharacterGlideComponent.TmpVector.Y = 0.0;
			CharacterGlideComponent.TmpVector.Z = (double)((float)Math.Sin((double)((num8 + this.OffsetNormalAngle) * 0.017453292f)) * 100f);
			this.ActorComp.ActorQuatProxy.RotateVector(CharacterGlideComponent.TmpVector, CharacterGlideComponent.TmpVector2);
			CharacterGlideComponent.TmpVector2.AdditionEqual(this.ActorComp.ActorLocationProxy);
			UKismetSystemLibrary.D_DrawDebugArrow(this.ActorComp.Actor, this.ActorComp.ActorLocation, CharacterGlideComponent.TmpVector2.ToUeVector(false), 100f, CharacterGlideComponent.blueColor, 0f, 10f);
		}
	}

	// Token: 0x06017F59 RID: 98137 RVA: 0x00728930 File Offset: 0x00726B30
	private EMoveHitType SoarMoveNormal(float deltaSeconds, UCharacterMovementComponent characterMovement)
	{
		if (this.ActorComp == null)
		{
			return EMoveHitType.None;
		}
		this.SoarBalanceOn = false;
		CharacterAnimationComponent animComp = this.AnimComp;
		bool flag = animComp != null && animComp.HasKuroRootMotion;
		double num = this.ActorComp.ActorVelocityProxy.Size();
		if (flag)
		{
			this.CurrentSoarQuat.RotateVector(global::Vector.UpVectorProxy, this.CurrentSoarNormal);
			this.OffsetNormalAngle = 0f;
			this.OffsetTurnAngle = 0f;
		}
		else
		{
			this.TmpInputDirect.DeepCopy(this.ActorComp.InputDirectProxy);
			float num2 = (float)this.TmpInputDirect.SizeSquared2D();
			if (num2 > 1f)
			{
				num2 = 1f;
			}
			else
			{
				num2 = (float)Math.Sqrt((double)num2);
			}
			this.TmpInputDirect.X = MathUtils.Instance.Clamp(this.TmpInputDirect.X / 0.7071067690849304, (double)(-(double)num2), (double)num2);
			this.TmpInputDirect.Y = MathUtils.Instance.Clamp(this.TmpInputDirect.Y / 0.7071067690849304, (double)(-(double)num2), (double)num2);
			if (MathUtils.Instance.IsNearlyZero(this.TmpInputDirect.X, null))
			{
				this.UpdateSoarNormalWithoutInput(deltaSeconds, characterMovement);
			}
			else
			{
				this.UpdateSoarNormalWithInput(deltaSeconds, characterMovement, (float)num);
			}
			this.OffsetTurnAngle = (float)MathUtils.Instance.Clamp((double)this.OffsetTurnAngle + this.TmpInputDirect.Y * (double)this.SoarConfigParams.SoarRotateSpeed * (double)deltaSeconds, -90.0, 90.0);
			this.SoarTurn(characterMovement, deltaSeconds);
			if (this.SoarBoostOn)
			{
				this.SoarBoost(characterMovement, deltaSeconds);
			}
			else
			{
				this.BalanceVelocity(characterMovement, deltaSeconds);
			}
		}
		if (this.SoarConfigParams.DebugDraw)
		{
			this.ActorComp.ActorLocationProxy.Addition(this.ActorComp.ActorVelocityProxy, CharacterGlideComponent.TmpVector);
			UKismetSystemLibrary.D_DrawDebugArrow(this.ActorComp.Actor, this.ActorComp.ActorLocation, CharacterGlideComponent.TmpVector.ToUeVector(false), 100f, CharacterGlideComponent.redColor, 0f, 10f);
			this.CurrentSoarNormal.Multiply(100.0, CharacterGlideComponent.TmpVector);
			CharacterGlideComponent.TmpVector.AdditionEqual(this.ActorComp.ActorLocationProxy);
			UKismetSystemLibrary.D_DrawDebugArrow(this.ActorComp.Actor, this.ActorComp.ActorLocation, CharacterGlideComponent.TmpVector.ToUeVector(false), 100f, CharacterGlideComponent.greenColor, 0f, 10f);
			global::Vector actorVelocityProxy = this.ActorComp.ActorVelocityProxy;
		}
		this.MoveComponent.GravityDirect.Multiply((double)this.SoarConfigParams.SoarGravityValue, CharacterGlideComponent.TmpVector);
		return UKuroMovementBPLibrary.KuroSoar(deltaSeconds, characterMovement, this.SoarConfigParams.SoarAirFriction, (float)MathUtils.Instance.RangeClamp(num, (double)this.SoarConfigParams.SoarSpeedThresholdMin, (double)this.SoarConfigParams.SoarSpeedThresholdMax, (double)this.SoarConfigParams.SoarAerodynamicsMin, (double)this.SoarConfigParams.SoarAerodynamicsMax), CharacterGlideComponent.TmpVector.ToUeVectorOld(), this.CurrentSoarNormal.ToUeVectorOld(), this.SoarConfigParams.SoarMaxSpeed);
	}

	// Token: 0x06017F5A RID: 98138 RVA: 0x00728C4C File Offset: 0x00726E4C
	private unsafe EMoveHitType SoarMoveSpline(float deltaSeconds, UCharacterMovementComponent characterMovement)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		CharacterSplineMoveComponent splineMoveComp = this.SplineMoveComp;
		CharacterAnimationComponent animComp = this.AnimComp;
		bool flag = animComp != null && animComp.HasKuroRootMotion;
		bool flag2 = !actorComp.InputDirectProxy.IsNearlyZero(9.999999747378752E-05);
		global::Vector actorVelocityProxy = actorComp.ActorVelocityProxy;
		double num = actorVelocityProxy.Size();
		SplineMoveParams currentSplineMoveParams = splineMoveComp.CurrentSplineMoveParams;
		if (currentSplineMoveParams.Spline == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[CharGlideComp][Soar] 无法获取风道轨道组件";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineId", currentSplineMoveParams.Id);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		if (flag || !flag2)
		{
			bool isPositiveMoving = splineMoveComp.IsPositiveMoving;
			float distanceAlongSplineAtSplineInputKey = currentSplineMoveParams.Spline.GetDistanceAlongSplineAtSplineInputKey(splineMoveComp.SplineTimeKey);
			int num2 = currentSplineMoveParams.Spline.GetNumberOfSplinePoints();
			if (!currentSplineMoveParams.Spline.IsClosedLoop())
			{
				num2--;
			}
			float inKey = currentSplineMoveParams.Spline.GetInputKeyAtDistanceAlongSpline(distanceAlongSplineAtSplineInputKey + (float)Math.Max((double)this.SoarConfigParams.SoarSplineMinSpeed, num) * (isPositiveMoving ? 0.5f : -0.5f)) * (float)num2;
			global::Vector tmpVector = CharacterGlideComponent.TmpVector;
			FVector directionAtSplineInputKey = currentSplineMoveParams.Spline.GetDirectionAtSplineInputKey(inKey, ESplineCoordinateSpace.World);
			tmpVector.FromUeVector(directionAtSplineInputKey);
			if (!isPositiveMoving)
			{
				CharacterGlideComponent.TmpVector.MultiplyEqual(-1.0);
			}
			if (flag)
			{
				this.InterpSoarSplineTargetDirectPlanar(CharacterGlideComponent.TmpVector, this.SoarConfigParams.SoarSplineRotateAngleSpeedWithoutInput * deltaSeconds);
			}
			else
			{
				MathUtils.Instance.SqInterpToVector(this.SoarSplineTargetDirect, CharacterGlideComponent.TmpVector, this.SoarConfigParams.SoarSplineRotateAngleSpeedWithoutInput * deltaSeconds, this.SoarSplineTargetDirect);
			}
		}
		else
		{
			CharacterGlideComponent.TmpVector.Set((double)this.SoarConfigParams.SoarSplineInputAngleCos, (double)this.SoarConfigParams.SoarSplineInputAngleSin * actorComp.InputDirectProxy.Y, (double)(-(double)this.SoarConfigParams.SoarSplineInputAngleSin) * actorComp.InputDirectProxy.X);
			CharacterGlideComponent.TmpVector.Normalize(9.99999993922529E-09);
			this.CurrentSoarQuat.RotateVector(CharacterGlideComponent.TmpVector, CharacterGlideComponent.TmpVector);
			this.ActorComp.ActorQuatProxy.Inverse(CharacterGlideComponent.TmpQuat);
			CharacterGlideComponent.TmpQuat.RotateVector(CharacterGlideComponent.TmpVector, CharacterGlideComponent.TmpVector2);
			if (CharacterGlideComponent.TmpVector2.X < (double)this.SoarConfigParams.SoarSplineInputDirectMinX)
			{
				CharacterGlideComponent.TmpVector2.X = (double)this.SoarConfigParams.SoarSplineInputDirectMinX;
				float num3 = (float)CharacterGlideComponent.TmpVector2.SizeSquared2D();
				if (num3 >= 1f)
				{
					CharacterGlideComponent.TmpVector2.Y = (double)((float)Math.Sign(CharacterGlideComponent.TmpVector2.Y) * (float)Math.Sqrt(1.0 - CharacterGlideComponent.TmpVector2.X * CharacterGlideComponent.TmpVector2.X));
					CharacterGlideComponent.TmpVector2.Z = 0.0;
				}
				else
				{
					CharacterGlideComponent.TmpVector2.Z = (double)((float)Math.Sign(CharacterGlideComponent.TmpVector2.Z) * (float)Math.Sqrt((double)(1f - num3)));
				}
				this.ActorComp.ActorQuatProxy.RotateVector(CharacterGlideComponent.TmpVector2, CharacterGlideComponent.TmpVector);
			}
			MathUtils.Instance.SqInterpToVector(this.SoarSplineTargetDirect, CharacterGlideComponent.TmpVector, this.SoarConfigParams.SoarSplineRotateAngleSpeedWithInput * deltaSeconds, this.SoarSplineTargetDirect);
		}
		MathUtils.Instance.SqLerpVector(actorVelocityProxy, this.SoarSplineTargetDirect, 1f - (float)Math.Pow((double)(1f - this.SoarConfigParams.SoarSplineRotateLerp), (double)deltaSeconds), CharacterGlideComponent.TmpVector);
		actorComp.SetActorVelocity(CharacterGlideComponent.TmpVector);
		MathUtils.Instance.LookRotationUpFirst(CharacterGlideComponent.TmpVector, actorComp.MoveComp.GravityUp, CharacterGlideComponent.TmpQuat2);
		CharacterGlideComponent.TmpQuat2.Rotator(CharacterGlideComponent.TmpRotator);
		actorComp.SetActorRotation(CharacterGlideComponent.TmpRotator.ToUeRotator(), "SoarSpline", false);
		actorVelocityProxy.Normalize(9.99999993922529E-09);
		float num4 = (float)Math.Acos(Math.Abs(MathUtils.Instance.Clamp(splineMoveComp.SplineDirection.DotProduct(actorVelocityProxy), -1.0, 1.0))) * 57.29578f;
		float num5 = (1f - num4 / 45f) * this.SoarConfigParams.SoarSplineAccel;
		double inB = MathUtils.Instance.Clamp(num + (double)(num5 * deltaSeconds), (double)this.SoarConfigParams.SoarSplineMinSpeed, (double)((this.SoarBoostOn && currentSplineMoveParams.SoarSprintLimit > 0f) ? currentSplineMoveParams.SoarSprintLimit : currentSplineMoveParams.MaxSoarSplineSpeed));
		actorVelocityProxy.Multiply(inB, CharacterGlideComponent.TmpVector);
		actorComp.SetActorVelocity(CharacterGlideComponent.TmpVector);
		if ((double)deltaSeconds > 1E-08)
		{
			splineMoveComp.SplineLocation.Subtraction(actorComp.ActorLocationProxy, CharacterGlideComponent.TmpVector);
			double num6 = CharacterGlideComponent.TmpVector.Size();
			double num7 = MathUtils.Instance.RangeClamp(num6, (double)this.SoarConfigParams.SoarSplinePushCenterDistMin, (double)this.SoarConfigParams.SoarSplinePushCenterDistMax, (double)this.SoarConfigParams.SoarSplinePushCenterSpeedMin, (double)this.SoarConfigParams.SoarSplinePushCenterSpeedMax);
			CharacterGlideComponent.TmpVector.MultiplyEqual((double)((float)Math.Min(1.0, num7 * (double)deltaSeconds / num6)));
			actorComp.MoveComp.MoveCharacter(CharacterGlideComponent.TmpVector, deltaSeconds, "Soar.Spline.Push");
		}
		if (this.SoarBoostOn)
		{
			this.SoarBoost(characterMovement, deltaSeconds);
		}
		if (this.SoarConfigParams.DebugDraw)
		{
			global::Vector actorVelocityProxy2 = actorComp.ActorVelocityProxy;
			actorComp.ActorLocationProxy.Addition(actorVelocityProxy2, CharacterGlideComponent.TmpVector);
			UKismetSystemLibrary.D_DrawDebugArrow(actorComp.Actor, actorComp.ActorLocation, CharacterGlideComponent.TmpVector.ToUeVector(false), 100f, CharacterGlideComponent.redColor, 0f, 10f);
			this.SoarSplineTargetDirect.Multiply(100.0, CharacterGlideComponent.TmpVector);
			CharacterGlideComponent.TmpVector.AdditionEqual(actorComp.ActorLocationProxy);
			UKismetSystemLibrary.D_DrawDebugArrow(actorComp.Actor, actorComp.ActorLocation, CharacterGlideComponent.TmpVector.ToUeVector(false), 100f, CharacterGlideComponent.blueColor, 0f, 10f);
		}
		return UKuroMovementBPLibrary.KuroSoar(deltaSeconds, characterMovement, currentSplineMoveParams.SoarFriction, 0f, global::Vector.ZeroVector, global::Vector.ZeroVector, (this.SoarBoostOn && currentSplineMoveParams.SoarSprintLimit > 0f) ? currentSplineMoveParams.SoarSprintLimit : currentSplineMoveParams.MaxSoarSplineSpeed);
	}

	// Token: 0x06017F5B RID: 98139 RVA: 0x007292CC File Offset: 0x007274CC
	private void InterpSoarSplineTargetDirectPlanar(global::Vector targetDirect, float maxAngle)
	{
		global::Vector gravityUp = this.ActorComp.MoveComp.GravityUp;
		double inB = gravityUp.DotProduct(targetDirect);
		global::Vector.VectorPlaneProject(targetDirect, gravityUp, CharacterGlideComponent.TmpVector2);
		double inB2 = CharacterGlideComponent.TmpVector2.Size();
		bool flag = CharacterGlideComponent.TmpVector2.Normalize(9.99999993922529E-09);
		global::Vector.VectorPlaneProject(this.SoarSplineTargetDirect, gravityUp, CharacterGlideComponent.TmpVector);
		bool flag2 = CharacterGlideComponent.TmpVector.Normalize(9.99999993922529E-09);
		if (flag && flag2)
		{
			MathUtils.Instance.SqInterpToVector(CharacterGlideComponent.TmpVector, CharacterGlideComponent.TmpVector2, maxAngle, CharacterGlideComponent.TmpVector);
		}
		else if (flag)
		{
			CharacterGlideComponent.TmpVector.DeepCopy(CharacterGlideComponent.TmpVector2);
		}
		CharacterGlideComponent.TmpVector.Multiply(inB2, this.SoarSplineTargetDirect);
		gravityUp.Multiply(inB, CharacterGlideComponent.TmpVector2);
		this.SoarSplineTargetDirect.AdditionEqual(CharacterGlideComponent.TmpVector2);
		this.SoarSplineTargetDirect.Normalize(9.99999993922529E-09);
	}

	// Token: 0x06017F5C RID: 98140 RVA: 0x007293BC File Offset: 0x007275BC
	public void SwitchCurrentSoarType(ESoarType newType)
	{
		if (this.CurrentSoarType == newType)
		{
			return;
		}
		this.CurrentSoarType = newType;
		this.RefreshSoarMaterialEffect();
		EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.SoarTypeChange);
	}

	// Token: 0x06017F5D RID: 98141 RVA: 0x007293EC File Offset: 0x007275EC
	private void RefreshSoarMaterialEffect()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			CreatureDataComponent creatureData = actorComp.CreatureData;
			if (creatureData != null)
			{
				creatureData.GetPbDataId();
			}
		}
		CharacterBuffComponent component = base.Entity.GetComponent<CharacterBuffComponent>();
		CharacterUnifiedStateComponent component2 = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		if (component2 != null && component2.MoveState == ECharMoveState.Soar && this.CurrentSoarType == ESoarType.Roam)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA.遨游中"]));
			}
			if (component != null)
			{
				component.AddBuff(613670000L, new AddBuffParam
				{
					InstigatorId = component.CreatureDataId,
					Reason = "CharGlideComp.RefreshSoarMaterialEffect"
				});
				return;
			}
		}
		else
		{
			if (component != null)
			{
				component.RemoveBuff(613670000L, -1, "CharGlideComp.RefreshSoarMaterialEffect", null, null, null);
			}
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 == null)
			{
				return;
			}
			tagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA.遨游中"]));
		}
	}

	// Token: 0x06017F5E RID: 98142 RVA: 0x007294F0 File Offset: 0x007276F0
	private void RefreshSoarExploreIcon()
	{
		bool flag = RouletteModel.Instance.CurrentExploreSkillId == 1015;
		ECharPositionState positionState = base.Entity.GetComponent<CharacterUnifiedStateComponent>().PositionState;
		if (!flag || positionState != ECharPositionState.Ground)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null)
			{
				return;
			}
			tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.弹射翱翔"]));
			return;
		}
		else
		{
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.弹射翱翔"]))
			{
				return;
			}
			BaseTagComponent tagComponent3 = this.TagComponent;
			if (tagComponent3 == null)
			{
				return;
			}
			tagComponent3.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.弹射翱翔"]));
			return;
		}
	}

	// Token: 0x06017F5F RID: 98143 RVA: 0x00729594 File Offset: 0x00727794
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterGlideComponent characterGlideComponent = (CharacterGlideComponent)componentTemplate;
		if (characterGlideComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterGlideComponent.MoveComponent == null)
		{
			this.MoveComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComponent), "MoveComponent"))
		{
			return false;
		}
		if (characterGlideComponent.WeaponComponent == null)
		{
			this.WeaponComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.WeaponComponent), "WeaponComponent"))
		{
			return false;
		}
		if (characterGlideComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		if (characterGlideComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		if (characterGlideComponent.SplineMoveComp == null)
		{
			this.SplineMoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SplineMoveComp), "SplineMoveComp"))
		{
			return false;
		}
		if (characterGlideComponent.OnAscentInWindTask == null)
		{
			this.OnAscentInWindTask = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnAscentInWindTask), "OnAscentInWindTask"))
		{
			return false;
		}
		if (characterGlideComponent.OnAscentBoostSpecTask == null)
		{
			this.OnAscentBoostSpecTask = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnAscentBoostSpecTask), "OnAscentBoostSpecTask"))
		{
			return false;
		}
		this.SoarBoostOnNormal = characterGlideComponent.SoarBoostOnNormal;
		this.SoarBoostOnSpec = characterGlideComponent.SoarBoostOnSpec;
		this.SoarBoostOnInternal = characterGlideComponent.SoarBoostOnInternal;
		this.SoarBalanceOn = characterGlideComponent.SoarBalanceOn;
		this.LastNotHitTime = characterGlideComponent.LastNotHitTime;
		if (characterGlideComponent.SoarConfigParams == null)
		{
			this.SoarConfigParams = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SoarConfigParams), "SoarConfigParams"))
		{
			return false;
		}
		this.CurrentSoarType = characterGlideComponent.CurrentSoarType;
		this.OffsetNormalAngle = characterGlideComponent.OffsetNormalAngle;
		this.OffsetTurnAngle = characterGlideComponent.OffsetTurnAngle;
		if (characterGlideComponent.CurrentSoarNormal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentSoarNormal), "CurrentSoarNormal"))
		{
			return false;
		}
		if (characterGlideComponent.CurrentSoarQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentSoarQuat), "CurrentSoarQuat"))
		{
			return false;
		}
		if (characterGlideComponent.TmpInputDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpInputDirect), "TmpInputDirect"))
		{
			return false;
		}
		if (characterGlideComponent.XaBoostShakeAsset == null)
		{
			this.XaBoostShakeAsset = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.XaBoostShakeAsset), "XaBoostShakeAsset"))
		{
			return false;
		}
		this.InSoarSplineMoveInternal = characterGlideComponent.InSoarSplineMoveInternal;
		this.JustEnterSoarSplineMove = characterGlideComponent.JustEnterSoarSplineMove;
		if (characterGlideComponent.SoarSplineTargetDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.SoarSplineTargetDirect), "SoarSplineTargetDirect"))
		{
			return false;
		}
		this.EnableAutoFlightInternal = characterGlideComponent.EnableAutoFlightInternal;
		this.SoarUpDownStateInternal = characterGlideComponent.SoarUpDownStateInternal;
		return true;
	}

	// Token: 0x17002574 RID: 9588
	// (get) Token: 0x06017F60 RID: 98144 RVA: 0x0072987A File Offset: 0x00727A7A
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002575 RID: 9589
	// (get) Token: 0x06017F61 RID: 98145 RVA: 0x0072987D File Offset: 0x00727A7D
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CD38 RID: 52536
	private const float FLYING_GRAVITY = 15f;

	// Token: 0x0400CD39 RID: 52537
	private const float FLYING_FRICTION = 0.1f;

	// Token: 0x0400CD3A RID: 52538
	private const float FLYING_DECELERATION = 0.068f;

	// Token: 0x0400CD3B RID: 52539
	private const float FLYING_ACCELERATOR = 55f;

	// Token: 0x0400CD3C RID: 52540
	private const float FLYING_MAX_SPEED = 650f;

	// Token: 0x0400CD3D RID: 52541
	private const float FLYING_MAX_FALLING_SPEED = 250f;

	// Token: 0x0400CD3E RID: 52542
	private const long ROAM_EFFECT_BUFF_ID = 613670000L;

	// Token: 0x0400CD3F RID: 52543
	private const int DETECT_VOXEL_DOWN_OFFSET = 2500;

	// Token: 0x0400CD40 RID: 52544
	public const string SOAR_CONFIG_BASE_PATH = "/Game/Aki/Data/Fight/Movement/DA_SoarConfigBase.DA_SoarConfigBase";

	// Token: 0x0400CD41 RID: 52545
	public const string SOAR_CAMERA_SHAKE_PATH = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Soar.NCS_Role_Soar_C";

	// Token: 0x0400CD42 RID: 52546
	public const string SOAR_CAMERA_SHAKE_CURVE_PATH = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/CameraShake_Curve.CameraShake_Curve";

	// Token: 0x0400CD43 RID: 52547
	public const string SOAR_AUTO_FLIGHT_PATH = "/Game/Aki/Character/Input/DataAsset/DA_CameraDrivenAutoFlightData.DA_CameraDrivenAutoFlightData";

	// Token: 0x0400CD44 RID: 52548
	public const int SOAR_CAMERA_SHAKE_SPEED_THRESHOLD = 1000;

	// Token: 0x0400CD45 RID: 52549
	public const int SOAR_CAMERA_SHAKE_SPEED_THRESHOLD_MAX = 3000;

	// Token: 0x0400CD46 RID: 52550
	private const float COS_45 = 0.70710677f;

	// Token: 0x0400CD47 RID: 52551
	private const float SOAR_MAX_DELTA = 0.033333335f;

	// Token: 0x0400CD48 RID: 52552
	private const int SOAR_MAX_ITER = 4;

	// Token: 0x0400CD49 RID: 52553
	private const float SOAR_TURN_SPEED_SQR_THRESHOLD = 10000f;

	// Token: 0x0400CD4A RID: 52554
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor redColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x0400CD4B RID: 52555
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor greenColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x0400CD4C RID: 52556
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor blueColor = new FLinearColor(0f, 0f, 1f, 1f);

	// Token: 0x0400CD4D RID: 52557
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor yellowColor = new FLinearColor(1f, 1f, 0f, 1f);

	// Token: 0x0400CD4E RID: 52558
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CD4F RID: 52559
	[Nullable(2)]
	private CharacterMoveComponent MoveComponent;

	// Token: 0x0400CD50 RID: 52560
	[Nullable(2)]
	private CharacterWeaponComponent WeaponComponent;

	// Token: 0x0400CD51 RID: 52561
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400CD52 RID: 52562
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400CD53 RID: 52563
	[Nullable(2)]
	private CharacterSplineMoveComponent SplineMoveComp;

	// Token: 0x0400CD54 RID: 52564
	[Nullable(2)]
	private ITagTask OnAscentInWindTask;

	// Token: 0x0400CD55 RID: 52565
	[Nullable(2)]
	private ITagTask OnAscentBoostSpecTask;

	// Token: 0x0400CD56 RID: 52566
	private bool SoarBoostOnNormal;

	// Token: 0x0400CD57 RID: 52567
	private bool SoarBoostOnSpec;

	// Token: 0x0400CD58 RID: 52568
	private bool SoarBoostOnInternal;

	// Token: 0x0400CD59 RID: 52569
	public bool SoarBalanceOn;

	// Token: 0x0400CD5A RID: 52570
	private double LastNotHitTime;

	// Token: 0x0400CD5B RID: 52571
	[Nullable(2)]
	private SoarConfigParams SoarConfigParams;

	// Token: 0x0400CD5C RID: 52572
	public ESoarType CurrentSoarType;

	// Token: 0x0400CD5D RID: 52573
	private float OffsetNormalAngle;

	// Token: 0x0400CD5E RID: 52574
	private float OffsetTurnAngle;

	// Token: 0x0400CD5F RID: 52575
	private readonly global::Vector CurrentSoarNormal = global::Vector.Create();

	// Token: 0x0400CD60 RID: 52576
	private readonly Quat CurrentSoarQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CD61 RID: 52577
	private readonly global::Vector TmpInputDirect = global::Vector.Create();

	// Token: 0x0400CD62 RID: 52578
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x0400CD63 RID: 52579
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector2 = global::Vector.Create();

	// Token: 0x0400CD64 RID: 52580
	[StaticVariableRuleIgnore]
	private static readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x0400CD65 RID: 52581
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CD66 RID: 52582
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CD67 RID: 52583
	private const string XaBoostShakePath = "/Game/Aki/Character/Role/Common/Data/GamePadShake/ABP_GamePlay/FF_BaseAnim_XA_Shake.FF_BaseAnim_XA_Shake";

	// Token: 0x0400CD68 RID: 52584
	[StaticVariableRuleIgnore]
	private static readonly FName? XaBoostShakeTag = FNameUtil.GetDynamicFName("CharacterGlide.XaBoostShake");

	// Token: 0x0400CD69 RID: 52585
	[Nullable(2)]
	private UKuroForceFeedbackEffect XaBoostShakeAsset;

	// Token: 0x0400CD6A RID: 52586
	private bool InSoarSplineMoveInternal;

	// Token: 0x0400CD6B RID: 52587
	protected bool JustEnterSoarSplineMove;

	// Token: 0x0400CD6C RID: 52588
	private readonly global::Vector SoarSplineTargetDirect = global::Vector.Create();

	// Token: 0x0400CD6D RID: 52589
	private bool EnableAutoFlightInternal;

	// Token: 0x0400CD6E RID: 52590
	private CharacterGlideComponent.ESoarUpDownState SoarUpDownStateInternal = CharacterGlideComponent.ESoarUpDownState.Normal;

	// Token: 0x0200886C RID: 34924
	[NullableContext(0)]
	private enum ESoarUpDownState
	{
		// Token: 0x0402BA0E RID: 178702
		Down,
		// Token: 0x0402BA0F RID: 178703
		Normal,
		// Token: 0x0402BA10 RID: 178704
		Up
	}
}

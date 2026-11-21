using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;

// Token: 0x020027B2 RID: 10162
[NullableContext(2)]
[Nullable(0)]
public class RoleGaitComponent : EntityComponent
{
	// Token: 0x170028AB RID: 10411
	// (get) Token: 0x060197EE RID: 104430 RVA: 0x007CFB89 File Offset: 0x007CDD89
	[Nullable(1)]
	public override Type[] Dependencies
	{
		[NullableContext(1)]
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent),
				typeof(CharacterMoveComponent)
			};
		}
	}

	// Token: 0x060197EF RID: 104431 RVA: 0x007CFBAC File Offset: 0x007CDDAC
	private void OnForceWalkTagChanged(bool tagExist)
	{
		if (tagExist)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]));
			}
			CharacterBuffComponent buffComp = this.BuffComp;
			if (buffComp != null)
			{
				buffComp.RemoveBuffByTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]), null, null);
			}
			this.RoleGaitUnEnableState[ERoleGaitEnableType.Run].Add(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制行走"]);
			this.RoleGaitUnEnableState[ERoleGaitEnableType.Sprint].Add(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制行走"]);
		}
		else
		{
			this.RoleGaitUnEnableState[ERoleGaitEnableType.Run].Remove(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制行走"]);
			this.RoleGaitUnEnableState[ERoleGaitEnableType.Sprint].Remove(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制行走"]);
		}
		this.RefreshMoveState();
	}

	// Token: 0x060197F0 RID: 104432 RVA: 0x007CFCA0 File Offset: 0x007CDEA0
	private void OnForceRunTagChanged(bool tagExist)
	{
		if (tagExist)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]));
			}
			CharacterBuffComponent buffComp = this.BuffComp;
			if (buffComp != null)
			{
				buffComp.RemoveBuffByTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]), null, null);
			}
			this.RoleGaitUnEnableState[ERoleGaitEnableType.Walk].Add(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制慢跑"]);
			this.RoleGaitUnEnableState[ERoleGaitEnableType.Sprint].Add(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制慢跑"]);
		}
		else
		{
			this.RoleGaitUnEnableState[ERoleGaitEnableType.Walk].Remove(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制慢跑"]);
			this.RoleGaitUnEnableState[ERoleGaitEnableType.Sprint].Remove(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制慢跑"]);
		}
		this.RefreshMoveState();
	}

	// Token: 0x060197F1 RID: 104433 RVA: 0x007CFD94 File Offset: 0x007CDF94
	private void OnForceNotWalkTagChanged(bool tagExist)
	{
		if (tagExist)
		{
			this.RoleGaitUnEnableState[ERoleGaitEnableType.Walk].Add(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止行走"]);
		}
		else
		{
			this.RoleGaitUnEnableState[ERoleGaitEnableType.Walk].Remove(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止行走"]);
		}
		this.RefreshMoveState();
	}

	// Token: 0x060197F2 RID: 104434 RVA: 0x007CFDF0 File Offset: 0x007CDFF0
	private void OnForbidSprintTagTagChanged(bool tagExist)
	{
		if (tagExist)
		{
			this.RoleGaitUnEnableState[ERoleGaitEnableType.Sprint].Add(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止冲刺"]);
		}
		else
		{
			this.RoleGaitUnEnableState[ERoleGaitEnableType.Sprint].Remove(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止冲刺"]);
		}
		this.RefreshMoveState();
	}

	// Token: 0x060197F3 RID: 104435 RVA: 0x007CFE4A File Offset: 0x007CE04A
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.RoleForbidMovementHelper = new RoleForbidMovementHelper();
		return true;
	}

	// Token: 0x060197F4 RID: 104436 RVA: 0x007CFE58 File Offset: 0x007CE058
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
		this.MoveComp = base.Entity.CheckGetComponent<CharacterMoveComponent>();
		this.UnifiedStateComponent = base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>();
		this.TagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		this.InputComp = base.Entity.CheckGetComponent<CharacterInputComponent>();
		CharacterInputComponent inputComp = this.InputComp;
		this.MoveInputGaitSwitchEnabled = (inputComp == null || !inputComp.IsMoveInputOuterRingEnabled());
		this.BuffComp = base.Entity.CheckGetComponent<CharacterBuffComponent>();
		RoleGaitStatic.Init();
		this.InitRoleForbidMovementHelper();
		return true;
	}

	// Token: 0x060197F5 RID: 104437 RVA: 0x007CFEF4 File Offset: 0x007CE0F4
	public unsafe void InitRoleForbidMovementHelper()
	{
		this.RoleGaitUnEnableState[ERoleGaitEnableType.Run] = new HashSet<int>();
		this.RoleGaitUnEnableState[ERoleGaitEnableType.Walk] = new HashSet<int>();
		this.RoleGaitUnEnableState[ERoleGaitEnableType.Sprint] = new HashSet<int>();
		this.RoleForbidMovementHelper.TagComp = base.Entity.CheckGetComponent<BaseTagComponent>();
		this.RoleForbidMovementHelper.CreateTagHandler(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制行走"], 1, new Action<bool>(this.OnForceWalkTagChanged));
		this.RoleForbidMovementHelper.CreateTagHandler(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制慢跑"], 1, new Action<bool>(this.OnForceRunTagChanged));
		this.RoleForbidMovementHelper.CreateTagHandler(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止行走"], 0, new Action<bool>(this.OnForceNotWalkTagChanged));
		RoleForbidMovementHelper roleForbidMovementHelper = this.RoleForbidMovementHelper;
		int num = 2;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount<int>(list, num);
		Span<int> span = CollectionsMarshal.AsSpan<int>(list);
		int num2 = 0;
		*span[num2] = GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制行走"];
		num2++;
		*span[num2] = GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止行走"];
		roleForbidMovementHelper.RegisterMutuallyTags(list);
		this.RoleForbidMovementHelper.CreateTagHandler(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止冲刺"], 0, new Action<bool>(this.OnForbidSprintTagTagChanged));
		this.RoleForbidMovementHelper.Awake();
	}

	// Token: 0x060197F6 RID: 104438 RVA: 0x007D0048 File Offset: 0x007CE248
	protected override bool OnClear()
	{
		RoleForbidMovementHelper roleForbidMovementHelper = this.RoleForbidMovementHelper;
		if (roleForbidMovementHelper != null)
		{
			roleForbidMovementHelper.Clear();
		}
		return true;
	}

	// Token: 0x060197F7 RID: 104439 RVA: 0x007D005C File Offset: 0x007CE25C
	protected override void OnTick(float delta)
	{
		this.RefreshMoveState();
	}

	// Token: 0x060197F8 RID: 104440 RVA: 0x007D0064 File Offset: 0x007CE264
	private void RefreshMoveState()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.IsAutonomousProxy)
		{
			return;
		}
		this.UpdateMoveStateByControllerType();
		ECharMoveState moveState = this.UnifiedStateComponent.MoveState;
		ECharPositionState positionState = this.UnifiedStateComponent.PositionState;
		BaseTagComponent tagComponent = this.TagComponent;
		bool hasSprintRetain = tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]);
		ECharDirectionState directionState = this.UnifiedStateComponent.DirectionState;
		CharacterMoveComponent moveComp = this.MoveComp;
		if (moveComp != null && moveComp.HasMoveInput)
		{
			this.UpdateMovePressing(hasSprintRetain, positionState, moveState, directionState);
			return;
		}
		this.UpdateMoveReleasing(hasSprintRetain, positionState, moveState, directionState);
	}

	// Token: 0x060197F9 RID: 104441 RVA: 0x007D00FE File Offset: 0x007CE2FE
	public bool EnableRoleGaitState(ERoleGaitEnableType type)
	{
		HashSet<int> valueOrDefault = this.RoleGaitUnEnableState.GetValueOrDefault(type);
		return valueOrDefault != null && valueOrDefault.Count == 0;
	}

	// Token: 0x060197FA RID: 104442 RVA: 0x007D011C File Offset: 0x007CE31C
	public ERoleGaitEnableType? FindEnableGaitState()
	{
		foreach (KeyValuePair<ERoleGaitEnableType, HashSet<int>> keyValuePair in this.RoleGaitUnEnableState)
		{
			if (keyValuePair.Value.Count == 0)
			{
				return new ERoleGaitEnableType?(keyValuePair.Key);
			}
		}
		return null;
	}

	// Token: 0x060197FB RID: 104443 RVA: 0x007D0190 File Offset: 0x007CE390
	public ECharMoveState? FindEnableCharMoveState()
	{
		ERoleGaitEnableType? eroleGaitEnableType = this.FindEnableGaitState();
		if (eroleGaitEnableType != null && eroleGaitEnableType != null)
		{
			switch (eroleGaitEnableType.GetValueOrDefault())
			{
			case ERoleGaitEnableType.Walk:
				return new ECharMoveState?(ECharMoveState.Walk);
			case ERoleGaitEnableType.Run:
				return new ECharMoveState?(ECharMoveState.Run);
			case ERoleGaitEnableType.Sprint:
				return new ECharMoveState?(ECharMoveState.Run);
			}
		}
		return null;
	}

	// Token: 0x060197FC RID: 104444 RVA: 0x007D01F4 File Offset: 0x007CE3F4
	protected void UpdateMovePressing(bool hasSprintRetain, ECharPositionState positionState, ECharMoveState moveState, ECharDirectionState cameraState)
	{
		switch (positionState)
		{
		case ECharPositionState.Ground:
		{
			if (hasSprintRetain && this.EnableRoleGaitState(ERoleGaitEnableType.Sprint))
			{
				float value = FormationAttributeController.Instance.GetValue(EFormationAttributeId.Strength);
				if (moveState != ECharMoveState.Sprint)
				{
					if (value >= 0.01f)
					{
						CharacterUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
						if (unifiedStateComponent == null)
						{
							return;
						}
						unifiedStateComponent.SetMoveState(ECharMoveState.Sprint);
						return;
					}
				}
				else if (value > 0f)
				{
					break;
				}
			}
			CharacterUnifiedStateComponent unifiedStateComponent2 = this.UnifiedStateComponent;
			if (unifiedStateComponent2 != null && unifiedStateComponent2.IsWalkBaseMode)
			{
				if (this.EnableRoleGaitState(ERoleGaitEnableType.Walk))
				{
					CharacterUnifiedStateComponent unifiedStateComponent3 = this.UnifiedStateComponent;
					if (unifiedStateComponent3 == null)
					{
						return;
					}
					unifiedStateComponent3.SetMoveState(ECharMoveState.Walk);
					return;
				}
				else if (this.EnableRoleGaitState(ERoleGaitEnableType.Run))
				{
					CharacterUnifiedStateComponent unifiedStateComponent4 = this.UnifiedStateComponent;
					if (unifiedStateComponent4 == null)
					{
						return;
					}
					unifiedStateComponent4.SetMoveState(ECharMoveState.Run);
					return;
				}
				else
				{
					CharacterUnifiedStateComponent unifiedStateComponent5 = this.UnifiedStateComponent;
					if (unifiedStateComponent5 == null)
					{
						return;
					}
					unifiedStateComponent5.SetMoveState(ECharMoveState.Walk);
					return;
				}
			}
			else if (this.EnableRoleGaitState(ERoleGaitEnableType.Run))
			{
				CharacterUnifiedStateComponent unifiedStateComponent6 = this.UnifiedStateComponent;
				if (unifiedStateComponent6 == null)
				{
					return;
				}
				unifiedStateComponent6.SetMoveState(ECharMoveState.Run);
				return;
			}
			else if (this.EnableRoleGaitState(ERoleGaitEnableType.Walk))
			{
				CharacterUnifiedStateComponent unifiedStateComponent7 = this.UnifiedStateComponent;
				if (unifiedStateComponent7 == null)
				{
					return;
				}
				unifiedStateComponent7.SetMoveState(ECharMoveState.Walk);
				return;
			}
			else
			{
				CharacterUnifiedStateComponent unifiedStateComponent8 = this.UnifiedStateComponent;
				if (unifiedStateComponent8 == null)
				{
					return;
				}
				unifiedStateComponent8.SetMoveState(ECharMoveState.Run);
				return;
			}
			break;
		}
		case ECharPositionState.Climb:
			if (moveState != ECharMoveState.EnterClimb && moveState != ECharMoveState.ExitClimb && moveState != ECharMoveState.FastClimb && moveState != ECharMoveState.NormalClimb)
			{
				if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制快速攀爬"]))
				{
					this.UnifiedStateComponent.SetMoveState(ECharMoveState.FastClimb);
					return;
				}
				this.UnifiedStateComponent.SetMoveState(ECharMoveState.NormalClimb);
			}
			break;
		case ECharPositionState.Air:
			break;
		case ECharPositionState.Water:
			if (moveState != ECharMoveState.FastSwim && moveState != ECharMoveState.NormalSwim)
			{
				CharacterUnifiedStateComponent unifiedStateComponent9 = this.UnifiedStateComponent;
				if (unifiedStateComponent9 == null)
				{
					return;
				}
				unifiedStateComponent9.SetMoveState(ECharMoveState.NormalSwim);
				return;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x060197FD RID: 104445 RVA: 0x007D0368 File Offset: 0x007CE568
	protected void UpdateMoveReleasing(bool hasSprintRetain, ECharPositionState positionState, ECharMoveState moveState, ECharDirectionState cameraState)
	{
		if (hasSprintRetain)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]));
			}
			CharacterBuffComponent buffComp = this.BuffComp;
			if (buffComp != null)
			{
				buffComp.RemoveBuffByTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]), null, null);
			}
		}
		switch (positionState)
		{
		case ECharPositionState.Ground:
			if (cameraState != ECharDirectionState.AimDirection)
			{
				if (moveState <= ECharMoveState.KnockUp)
				{
					switch (moveState)
					{
					case ECharMoveState.Walk:
					case ECharMoveState.Run:
					case ECharMoveState.Sprint:
					{
						if (!this.DisableStopAnim)
						{
							this.SetRunStop();
							return;
						}
						CharacterMoveComponent moveComp = this.MoveComp;
						if (moveComp == null || moveComp.Speed >= 5f)
						{
							return;
						}
						CharacterUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
						if (unifiedStateComponent == null)
						{
							return;
						}
						unifiedStateComponent.SetMoveState(ECharMoveState.Stand);
						return;
					}
					case ECharMoveState.WalkStop:
					case ECharMoveState.RunStop:
					case ECharMoveState.SprintStop:
					case ECharMoveState.Dodge:
					case ECharMoveState.LandRoll:
						break;
					case ECharMoveState.KnockDown:
					case ECharMoveState.Parry:
					case ECharMoveState.SoftKnock:
					case ECharMoveState.HeavyKnock:
						return;
					default:
						if (moveState == ECharMoveState.KnockUp)
						{
							return;
						}
						break;
					}
				}
				else if (moveState == ECharMoveState.Captured || moveState == ECharMoveState.BreakWeakness)
				{
					break;
				}
				CharacterMoveComponent moveComp2 = this.MoveComp;
				if (moveComp2 != null && moveComp2.Speed < 5f)
				{
					CharacterUnifiedStateComponent unifiedStateComponent2 = this.UnifiedStateComponent;
					if (unifiedStateComponent2 == null)
					{
						return;
					}
					unifiedStateComponent2.SetMoveState(ECharMoveState.Stand);
					return;
				}
			}
			break;
		case ECharPositionState.Climb:
		{
			CharacterUnifiedStateComponent unifiedStateComponent3 = this.UnifiedStateComponent;
			if (unifiedStateComponent3 == null || unifiedStateComponent3.MoveState != ECharMoveState.EnterClimb)
			{
				CharacterUnifiedStateComponent unifiedStateComponent4 = this.UnifiedStateComponent;
				if (unifiedStateComponent4 == null || unifiedStateComponent4.MoveState != ECharMoveState.ExitClimb)
				{
					CharacterUnifiedStateComponent unifiedStateComponent5 = this.UnifiedStateComponent;
					if (unifiedStateComponent5 == null)
					{
						return;
					}
					unifiedStateComponent5.SetMoveState(ECharMoveState.Other);
				}
			}
			break;
		}
		case ECharPositionState.Air:
			break;
		case ECharPositionState.Water:
		{
			CharacterUnifiedStateComponent unifiedStateComponent6 = this.UnifiedStateComponent;
			if (unifiedStateComponent6 == null)
			{
				return;
			}
			unifiedStateComponent6.SetMoveState(ECharMoveState.Other);
			return;
		}
		default:
			return;
		}
	}

	// Token: 0x060197FE RID: 104446 RVA: 0x007D050C File Offset: 0x007CE70C
	protected void SetRunStop()
	{
		CharacterUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		ECharMoveState? echarMoveState = (unifiedStateComponent != null) ? new ECharMoveState?(unifiedStateComponent.MoveState) : null;
		if (echarMoveState != null)
		{
			switch (echarMoveState.GetValueOrDefault())
			{
			case ECharMoveState.Walk:
			{
				CharacterUnifiedStateComponent unifiedStateComponent2 = this.UnifiedStateComponent;
				if (unifiedStateComponent2 == null)
				{
					return;
				}
				unifiedStateComponent2.SetMoveState(ECharMoveState.WalkStop);
				return;
			}
			case ECharMoveState.WalkStop:
			case ECharMoveState.RunStop:
			case ECharMoveState.SprintStop:
				break;
			case ECharMoveState.Run:
			case ECharMoveState.Sprint:
			case ECharMoveState.Dodge:
			case ECharMoveState.LandRoll:
				if (!this.CanSprintStop())
				{
					CharacterUnifiedStateComponent unifiedStateComponent3 = this.UnifiedStateComponent;
					if (unifiedStateComponent3 == null)
					{
						return;
					}
					unifiedStateComponent3.SetMoveState(ECharMoveState.RunStop);
					return;
				}
				else
				{
					CharacterUnifiedStateComponent unifiedStateComponent4 = this.UnifiedStateComponent;
					if (unifiedStateComponent4 == null)
					{
						return;
					}
					unifiedStateComponent4.SetMoveState(ECharMoveState.SprintStop);
				}
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x060197FF RID: 104447 RVA: 0x007D05B0 File Offset: 0x007CE7B0
	public void SetMoveInputGaitSwitchEnabled(bool enabled)
	{
		this.MoveInputGaitSwitchEnabled = enabled;
	}

	// Token: 0x06019800 RID: 104448 RVA: 0x007D05BC File Offset: 0x007CE7BC
	private void UpdateMoveStateByControllerType()
	{
		CharacterMoveComponent moveComp = this.MoveComp;
		if (moveComp != null && moveComp.IsMovingToLocation())
		{
			return;
		}
		if (Info.Instance.IsInKeyBoard())
		{
			if (!this.LastInKeyBoard && this.UnifiedStateComponent.MarkWalkOrRun(false, false, null))
			{
				this.UnifiedStateComponent.WalkPress();
			}
			this.LastInKeyBoard = true;
			return;
		}
		this.LastInKeyBoard = false;
		if (!this.MoveInputGaitSwitchEnabled)
		{
			return;
		}
		if (Info.Instance.IsInGamepad())
		{
			this.UpdateMoveStateByGamepad();
			return;
		}
		if (Info.Instance.IsInTouch())
		{
			this.UpdateMoveStateByTouch();
		}
	}

	// Token: 0x06019801 RID: 104449 RVA: 0x007D0654 File Offset: 0x007CE854
	private void UpdateMoveStateByGamepad()
	{
		CharacterInputComponent inputComp = this.InputComp;
		Vector vector = (inputComp != null) ? inputComp.GetMoveVectorCache() : null;
		double num = (vector != null) ? vector.SizeSquared() : 0.0;
		if (MathUtils.Instance.IsNearlyZero(num, null) || num > MathUtils.Instance.Square((double)RoleGaitStatic.GetWalkOrRunRate()))
		{
			if (this.UnifiedStateComponent.MarkWalkOrRun(false, false, null))
			{
				this.UnifiedStateComponent.WalkPress();
				return;
			}
		}
		else if (this.UnifiedStateComponent.MarkWalkOrRun(true, false, null))
		{
			this.UnifiedStateComponent.WalkPress();
		}
	}

	// Token: 0x06019802 RID: 104450 RVA: 0x007D06F8 File Offset: 0x007CE8F8
	private void UpdateMoveStateByTouch()
	{
		CharacterInputComponent inputComp = this.InputComp;
		Vector vector = (inputComp != null) ? inputComp.GetMoveVectorCache() : null;
		if (((vector != null) ? vector.SizeSquared() : 0.0) > MathUtils.Instance.Square((double)RoleGaitStatic.GetWalkOrRunRate()))
		{
			CharacterUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
			if (unifiedStateComponent != null && unifiedStateComponent.MoveState == ECharMoveState.Walk)
			{
				CharacterUnifiedStateComponent unifiedStateComponent2 = this.UnifiedStateComponent;
				if (unifiedStateComponent2 == null)
				{
					return;
				}
				unifiedStateComponent2.WalkPress();
				return;
			}
		}
		else
		{
			CharacterUnifiedStateComponent unifiedStateComponent3 = this.UnifiedStateComponent;
			if (unifiedStateComponent3 != null && unifiedStateComponent3.MoveState == ECharMoveState.Run)
			{
				CharacterUnifiedStateComponent unifiedStateComponent4 = this.UnifiedStateComponent;
				if (unifiedStateComponent4 == null)
				{
					return;
				}
				unifiedStateComponent4.WalkPress();
			}
		}
	}

	// Token: 0x06019803 RID: 104451 RVA: 0x007D078C File Offset: 0x007CE98C
	public void EnableSprintStop(bool enable)
	{
		if (this.IsDisableSprintStop != enable)
		{
			return;
		}
		this.IsDisableSprintStop = !enable;
	}

	// Token: 0x06019804 RID: 104452 RVA: 0x007D07A4 File Offset: 0x007CE9A4
	private bool CanSprintStop()
	{
		if (this.IsDisableSprintStop)
		{
			return false;
		}
		float sprintSpeed = this.MoveComp.MovementData.FaceDirection.Standing.SprintSpeed;
		float num = 150f;
		return this.MoveComp.Speed + num >= sprintSpeed;
	}

	// Token: 0x06019805 RID: 104453 RVA: 0x007D07EF File Offset: 0x007CE9EF
	public void SetDisableStopAnim(bool enable)
	{
		this.DisableStopAnim = enable;
	}

	// Token: 0x06019806 RID: 104454 RVA: 0x007D07F8 File Offset: 0x007CE9F8
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleGaitComponent roleGaitComponent = (RoleGaitComponent)componentTemplate;
		if (roleGaitComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (roleGaitComponent.InputComp == null)
		{
			this.InputComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputComp), "InputComp"))
		{
			return false;
		}
		if (roleGaitComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (roleGaitComponent.BuffComp == null)
		{
			this.BuffComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComp), "BuffComp"))
		{
			return false;
		}
		if (roleGaitComponent.UnifiedStateComponent == null)
		{
			this.UnifiedStateComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComponent), "UnifiedStateComponent"))
		{
			return false;
		}
		if (roleGaitComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		if (roleGaitComponent.RoleForbidMovementHelper == null)
		{
			this.RoleForbidMovementHelper = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RoleForbidMovementHelper), "RoleForbidMovementHelper"))
		{
			return false;
		}
		if (roleGaitComponent.RoleGaitUnEnableState == null)
		{
			this.RoleGaitUnEnableState = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RoleGaitUnEnableState), "RoleGaitUnEnableState"))
		{
			return false;
		}
		this.DisableStopAnim = roleGaitComponent.DisableStopAnim;
		this.LastInKeyBoard = roleGaitComponent.LastInKeyBoard;
		this.MoveInputGaitSwitchEnabled = roleGaitComponent.MoveInputGaitSwitchEnabled;
		this.IsDisableSprintStop = roleGaitComponent.IsDisableSprintStop;
		return true;
	}

	// Token: 0x170028AC RID: 10412
	// (get) Token: 0x06019807 RID: 104455 RVA: 0x007D09A0 File Offset: 0x007CEBA0
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028AD RID: 10413
	// (get) Token: 0x06019808 RID: 104456 RVA: 0x007D09A3 File Offset: 0x007CEBA3
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028AE RID: 10414
	// (get) Token: 0x06019809 RID: 104457 RVA: 0x007D09A6 File Offset: 0x007CEBA6
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DF5C RID: 57180
	private const float STOP_SPEED = 5f;

	// Token: 0x0400DF5D RID: 57181
	private CharacterActorComponent ActorComp;

	// Token: 0x0400DF5E RID: 57182
	private CharacterInputComponent InputComp;

	// Token: 0x0400DF5F RID: 57183
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400DF60 RID: 57184
	private CharacterBuffComponent BuffComp;

	// Token: 0x0400DF61 RID: 57185
	private CharacterUnifiedStateComponent UnifiedStateComponent;

	// Token: 0x0400DF62 RID: 57186
	private BaseTagComponent TagComponent;

	// Token: 0x0400DF63 RID: 57187
	public RoleForbidMovementHelper RoleForbidMovementHelper;

	// Token: 0x0400DF64 RID: 57188
	[Nullable(1)]
	public Dictionary<ERoleGaitEnableType, HashSet<int>> RoleGaitUnEnableState = new Dictionary<ERoleGaitEnableType, HashSet<int>>();

	// Token: 0x0400DF65 RID: 57189
	private bool DisableStopAnim;

	// Token: 0x0400DF66 RID: 57190
	private bool LastInKeyBoard = true;

	// Token: 0x0400DF67 RID: 57191
	private bool MoveInputGaitSwitchEnabled = true;

	// Token: 0x0400DF68 RID: 57192
	private bool IsDisableSprintStop;
}

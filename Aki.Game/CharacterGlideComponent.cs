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

// Token: 0x02003060 RID: 12384
[NullableContext(1)]
[Nullable(0)]
public class CharacterGlideComponent : EntityComponent
{
	// Token: 0x17002444 RID: 9284
	// (get) Token: 0x0601A58C RID: 107916 RVA: 0x00700260 File Offset: 0x006FE460
	public bool SoarBoostOn
	{
		get
		{
			return this.SoarBoostOnInternal;
		}
	}

	// Token: 0x0601A58D RID: 107917 RVA: 0x00700268 File Offset: 0x006FE468
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

	// Token: 0x0601A58E RID: 107918 RVA: 0x0070030E File Offset: 0x006FE50E
	private void OnPositionStateChanged(ECharPositionState oldMoveState, ECharPositionState newMoveState)
	{
		this.RefreshSoarBoost();
		this.RefreshEnableAutoFlight();
		this.RefreshSoarExploreIcon();
	}

	// Token: 0x0601A58F RID: 107919 RVA: 0x00700324 File Offset: 0x006FE524
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

	// Token: 0x17002445 RID: 9285
	// (get) Token: 0x0601A590 RID: 107920 RVA: 0x007003EA File Offset: 0x006FE5EA
	// (set) Token: 0x0601A591 RID: 107921 RVA: 0x007003F4 File Offset: 0x006FE5F4
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

	// Token: 0x17002446 RID: 9286
	// (get) Token: 0x0601A592 RID: 107922 RVA: 0x007005C8 File Offset: 0x006FE7C8
	// (set) Token: 0x0601A593 RID: 107923 RVA: 0x007005D0 File Offset: 0x006FE7D0
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

	// Token: 0x0601A594 RID: 107924 RVA: 0x00700630 File Offset: 0x006FE830
	private void RefreshEnableAutoFlight()
	{
		this.EnableAutoFlight = (!this.InSoarSplineMove && this.TagComponent != null && this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA"]));
	}

	// Token: 0x17002447 RID: 9287
	// (get) Token: 0x0601A595 RID: 107925 RVA: 0x00700665 File Offset: 0x006FE865
	// (set) Token: 0x0601A596 RID: 107926 RVA: 0x00700670 File Offset: 0x006FE870
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

	// Token: 0x0601A597 RID: 107927 RVA: 0x00700734 File Offset: 0x006FE934
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

	// Token: 0x0601A598 RID: 107928 RVA: 0x0070080C File Offset: 0x006FEA0C
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

	// Token: 0x0601A599 RID: 107929 RVA: 0x007009C8 File Offset: 0x006FEBC8
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

	// Token: 0x0601A59A RID: 107930 RVA: 0x00700AF4 File Offset: 0x006FECF4
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

	// Token: 0x0601A59B RID: 107931 RVA: 0x00700BB0 File Offset: 0x006FEDB0
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

	// Token: 0x0601A59C RID: 107932 RVA: 0x00700C40 File Offset: 0x006FEE40
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

	// Token: 0x0601A59D RID: 107933 RVA: 0x00700DF8 File Offset: 0x006FEFF8
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

	// Token: 0x0601A59E RID: 107934 RVA: 0x00700EFD File Offset: 0x006FF0FD
	private void OnAscentInWind(int tagId, bool tagExist)
	{
		CharacterWeaponComponent weaponComponent = this.WeaponComponent;
		if (weaponComponent == null)
		{
			return;
		}
		weaponComponent.SetParaglidingIsAscent(tagExist);
	}

	// Token: 0x0601A59F RID: 107935 RVA: 0x00700F10 File Offset: 0x006FF110
	private void OnAscentBoostSpec(int tagId, bool tagExist)
	{
		this.SoarBoostOnSpec = tagExist;
		this.RefreshSoarBoost();
	}

	// Token: 0x0601A5A0 RID: 107936 RVA: 0x00700F1F File Offset: 0x006FF11F
	public void EnterGlideState(string context = "CharacterGlideComponent")
	{
		this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Custom,
			CustomMode = 2,
			Context = context
		});
	}

	// Token: 0x0601A5A1 RID: 107937 RVA: 0x00700F4B File Offset: 0x006FF14B
	public void ExitGlideState(string context = "CharacterGlideComponent")
	{
		this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Falling,
			CustomMode = 0,
			Context = context
		});
	}

	// Token: 0x0601A5A2 RID: 107938 RVA: 0x00700F78 File Offset: 0x006FF178
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

	// Token: 0x0601A5A3 RID: 107939 RVA: 0x00700FE4 File Offset: 0x006FF1E4
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

	// Token: 0x0601A5A4 RID: 107940 RVA: 0x00701088 File Offset: 0x006FF288
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

	// Token: 0x0601A5A5 RID: 107941 RVA: 0x007011A0 File Offset: 0x006FF3A0
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

	// Token: 0x0601A5A6 RID: 107942 RVA: 0x007013E4 File Offset: 0x006FF5E4
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

	// Token: 0x0601A5A7 RID: 107943 RVA: 0x007014A4 File Offset: 0x006FF6A4
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

	// Token: 0x0601A5A8 RID: 107944 RVA: 0x00701654 File Offset: 0x006FF854
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

	// Token: 0x0601A5A9 RID: 107945 RVA: 0x007016D4 File Offset: 0x006FF8D4
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

	// Token: 0x0601A5AA RID: 107946 RVA: 0x00701754 File Offset: 0x006FF954
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

	// Token: 0x0601A5AB RID: 107947 RVA: 0x0070191C File Offset: 0x006FFB1C
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

	// Token: 0x0601A5AC RID: 107948 RVA: 0x00701C30 File Offset: 0x006FFE30
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

	// Token: 0x0601A5AD RID: 107949 RVA: 0x00701F4C File Offset: 0x0070014C
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
			MathUtils.Instance.SqInterpToVector(this.SoarSplineTargetDirect, CharacterGlideComponent.TmpVector, this.SoarConfigParams.SoarSplineRotateAngleSpeedWithoutInput * deltaSeconds, this.SoarSplineTargetDirect);
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

	// Token: 0x0601A5AE RID: 107950 RVA: 0x007025A4 File Offset: 0x007007A4
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

	// Token: 0x0601A5AF RID: 107951 RVA: 0x007025D4 File Offset: 0x007007D4
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

	// Token: 0x0601A5B0 RID: 107952 RVA: 0x007026D8 File Offset: 0x007008D8
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

	// Token: 0x0601A5B1 RID: 107953 RVA: 0x0070277C File Offset: 0x0070097C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterGlideComponent characterGlideComponent = (CharacterGlideComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterGlideComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComponent"))
		{
			if (characterGlideComponent.MoveComponent == null)
			{
				this.MoveComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComponent), "MoveComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("WeaponComponent"))
		{
			if (characterGlideComponent.WeaponComponent == null)
			{
				this.WeaponComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterWeaponComponent>(this.WeaponComponent), "WeaponComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComponent"))
		{
			if (characterGlideComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (characterGlideComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SplineMoveComp"))
		{
			if (characterGlideComponent.SplineMoveComp == null)
			{
				this.SplineMoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterSplineMoveComponent>(this.SplineMoveComp), "SplineMoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("OnAscentInWindTask"))
		{
			if (characterGlideComponent.OnAscentInWindTask == null)
			{
				this.OnAscentInWindTask = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.OnAscentInWindTask), "OnAscentInWindTask"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("OnAscentBoostSpecTask"))
		{
			if (characterGlideComponent.OnAscentBoostSpecTask == null)
			{
				this.OnAscentBoostSpecTask = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.OnAscentBoostSpecTask), "OnAscentBoostSpecTask"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SoarBoostOnNormal"))
		{
			this.SoarBoostOnNormal = characterGlideComponent.SoarBoostOnNormal;
		}
		if (base.CanResetComponentProperty("SoarBoostOnSpec"))
		{
			this.SoarBoostOnSpec = characterGlideComponent.SoarBoostOnSpec;
		}
		if (base.CanResetComponentProperty("SoarBoostOnInternal"))
		{
			this.SoarBoostOnInternal = characterGlideComponent.SoarBoostOnInternal;
		}
		if (base.CanResetComponentProperty("SoarBalanceOn"))
		{
			this.SoarBalanceOn = characterGlideComponent.SoarBalanceOn;
		}
		if (base.CanResetComponentProperty("LastNotHitTime"))
		{
			this.LastNotHitTime = characterGlideComponent.LastNotHitTime;
		}
		if (base.CanResetComponentProperty("SoarConfigParams"))
		{
			if (characterGlideComponent.SoarConfigParams == null)
			{
				this.SoarConfigParams = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SoarConfigParams>(this.SoarConfigParams), "SoarConfigParams"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurrentSoarType"))
		{
			this.CurrentSoarType = characterGlideComponent.CurrentSoarType;
		}
		if (base.CanResetComponentProperty("OffsetNormalAngle"))
		{
			this.OffsetNormalAngle = characterGlideComponent.OffsetNormalAngle;
		}
		if (base.CanResetComponentProperty("OffsetTurnAngle"))
		{
			this.OffsetTurnAngle = characterGlideComponent.OffsetTurnAngle;
		}
		if (base.CanResetComponentProperty("CurrentSoarNormal") && characterGlideComponent.CurrentSoarNormal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CurrentSoarNormal), "CurrentSoarNormal"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CurrentSoarQuat") && characterGlideComponent.CurrentSoarQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.CurrentSoarQuat), "CurrentSoarQuat"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TmpInputDirect") && characterGlideComponent.TmpInputDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpInputDirect), "TmpInputDirect"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("XaBoostShakeAsset"))
		{
			if (characterGlideComponent.XaBoostShakeAsset == null)
			{
				this.XaBoostShakeAsset = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroForceFeedbackEffect>(this.XaBoostShakeAsset), "XaBoostShakeAsset"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("InSoarSplineMoveInternal"))
		{
			this.InSoarSplineMoveInternal = characterGlideComponent.InSoarSplineMoveInternal;
		}
		if (base.CanResetComponentProperty("JustEnterSoarSplineMove"))
		{
			this.JustEnterSoarSplineMove = characterGlideComponent.JustEnterSoarSplineMove;
		}
		if (base.CanResetComponentProperty("SoarSplineTargetDirect") && characterGlideComponent.SoarSplineTargetDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SoarSplineTargetDirect), "SoarSplineTargetDirect"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("EnableAutoFlightInternal"))
		{
			this.EnableAutoFlightInternal = characterGlideComponent.EnableAutoFlightInternal;
		}
		if (base.CanResetComponentProperty("SoarUpDownStateInternal"))
		{
			this.SoarUpDownStateInternal = characterGlideComponent.SoarUpDownStateInternal;
		}
		return true;
	}

	// Token: 0x0400C95E RID: 51550
	private const float FLYING_GRAVITY = 15f;

	// Token: 0x0400C95F RID: 51551
	private const float FLYING_FRICTION = 0.1f;

	// Token: 0x0400C960 RID: 51552
	private const float FLYING_DECELERATION = 0.068f;

	// Token: 0x0400C961 RID: 51553
	private const float FLYING_ACCELERATOR = 55f;

	// Token: 0x0400C962 RID: 51554
	private const float FLYING_MAX_SPEED = 650f;

	// Token: 0x0400C963 RID: 51555
	private const float FLYING_MAX_FALLING_SPEED = 250f;

	// Token: 0x0400C964 RID: 51556
	private const long ROAM_EFFECT_BUFF_ID = 613670000L;

	// Token: 0x0400C965 RID: 51557
	private const int DETECT_VOXEL_DOWN_OFFSET = 2500;

	// Token: 0x0400C966 RID: 51558
	public const string SOAR_CONFIG_BASE_PATH = "/Game/Aki/Data/Fight/Movement/DA_SoarConfigBase.DA_SoarConfigBase";

	// Token: 0x0400C967 RID: 51559
	public const string SOAR_CAMERA_SHAKE_PATH = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Role_Soar.NCS_Role_Soar_C";

	// Token: 0x0400C968 RID: 51560
	public const string SOAR_CAMERA_SHAKE_CURVE_PATH = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/CameraShake_Curve.CameraShake_Curve";

	// Token: 0x0400C969 RID: 51561
	public const string SOAR_AUTO_FLIGHT_PATH = "/Game/Aki/Character/Input/DataAsset/DA_CameraDrivenAutoFlightData.DA_CameraDrivenAutoFlightData";

	// Token: 0x0400C96A RID: 51562
	public const int SOAR_CAMERA_SHAKE_SPEED_THRESHOLD = 1000;

	// Token: 0x0400C96B RID: 51563
	public const int SOAR_CAMERA_SHAKE_SPEED_THRESHOLD_MAX = 3000;

	// Token: 0x0400C96C RID: 51564
	private const float COS_45 = 0.70710677f;

	// Token: 0x0400C96D RID: 51565
	private const float SOAR_MAX_DELTA = 0.033333335f;

	// Token: 0x0400C96E RID: 51566
	private const int SOAR_MAX_ITER = 4;

	// Token: 0x0400C96F RID: 51567
	private const float SOAR_TURN_SPEED_SQR_THRESHOLD = 10000f;

	// Token: 0x0400C970 RID: 51568
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor redColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x0400C971 RID: 51569
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor greenColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x0400C972 RID: 51570
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor blueColor = new FLinearColor(0f, 0f, 1f, 1f);

	// Token: 0x0400C973 RID: 51571
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor yellowColor = new FLinearColor(1f, 1f, 0f, 1f);

	// Token: 0x0400C974 RID: 51572
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400C975 RID: 51573
	[Nullable(2)]
	private CharacterMoveComponent MoveComponent;

	// Token: 0x0400C976 RID: 51574
	[Nullable(2)]
	private CharacterWeaponComponent WeaponComponent;

	// Token: 0x0400C977 RID: 51575
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400C978 RID: 51576
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400C979 RID: 51577
	[Nullable(2)]
	private CharacterSplineMoveComponent SplineMoveComp;

	// Token: 0x0400C97A RID: 51578
	[Nullable(2)]
	private ITagTask OnAscentInWindTask;

	// Token: 0x0400C97B RID: 51579
	[Nullable(2)]
	private ITagTask OnAscentBoostSpecTask;

	// Token: 0x0400C97C RID: 51580
	private bool SoarBoostOnNormal;

	// Token: 0x0400C97D RID: 51581
	private bool SoarBoostOnSpec;

	// Token: 0x0400C97E RID: 51582
	private bool SoarBoostOnInternal;

	// Token: 0x0400C97F RID: 51583
	public bool SoarBalanceOn;

	// Token: 0x0400C980 RID: 51584
	private double LastNotHitTime;

	// Token: 0x0400C981 RID: 51585
	[Nullable(2)]
	private SoarConfigParams SoarConfigParams;

	// Token: 0x0400C982 RID: 51586
	public ESoarType CurrentSoarType;

	// Token: 0x0400C983 RID: 51587
	private float OffsetNormalAngle;

	// Token: 0x0400C984 RID: 51588
	private float OffsetTurnAngle;

	// Token: 0x0400C985 RID: 51589
	private readonly global::Vector CurrentSoarNormal = global::Vector.Create();

	// Token: 0x0400C986 RID: 51590
	private readonly Quat CurrentSoarQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400C987 RID: 51591
	private readonly global::Vector TmpInputDirect = global::Vector.Create();

	// Token: 0x0400C988 RID: 51592
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x0400C989 RID: 51593
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector2 = global::Vector.Create();

	// Token: 0x0400C98A RID: 51594
	[StaticVariableRuleIgnore]
	private static readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x0400C98B RID: 51595
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400C98C RID: 51596
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400C98D RID: 51597
	private const string XaBoostShakePath = "/Game/Aki/Character/Role/Common/Data/GamePadShake/ABP_GamePlay/FF_BaseAnim_XA_Shake.FF_BaseAnim_XA_Shake";

	// Token: 0x0400C98E RID: 51598
	[StaticVariableRuleIgnore]
	private static readonly FName? XaBoostShakeTag = FNameUtil.GetDynamicFName("CharacterGlide.XaBoostShake");

	// Token: 0x0400C98F RID: 51599
	[Nullable(2)]
	private UKuroForceFeedbackEffect XaBoostShakeAsset;

	// Token: 0x0400C990 RID: 51600
	private bool InSoarSplineMoveInternal;

	// Token: 0x0400C991 RID: 51601
	protected bool JustEnterSoarSplineMove;

	// Token: 0x0400C992 RID: 51602
	private readonly global::Vector SoarSplineTargetDirect = global::Vector.Create();

	// Token: 0x0400C993 RID: 51603
	private bool EnableAutoFlightInternal;

	// Token: 0x0400C994 RID: 51604
	private CharacterGlideComponent.ESoarUpDownState SoarUpDownStateInternal = CharacterGlideComponent.ESoarUpDownState.Normal;

	// Token: 0x0200964B RID: 38475
	[NullableContext(0)]
	private enum ESoarUpDownState
	{
		// Token: 0x04030381 RID: 197505
		Down,
		// Token: 0x04030382 RID: 197506
		Normal,
		// Token: 0x04030383 RID: 197507
		Up
	}
}

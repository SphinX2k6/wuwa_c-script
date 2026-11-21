using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020027FC RID: 10236
[NullableContext(2)]
[Nullable(0)]
public class PawnTurnActionController
{
	// Token: 0x06019C40 RID: 105536 RVA: 0x007F0580 File Offset: 0x007EE780
	[NullableContext(1)]
	public PawnTurnActionController(Entity entity)
	{
		this.Entity = entity;
		this.MoveComp = entity.GetComponent<BaseMoveComponent>();
		this.ActorComp = entity.GetComponent<BaseActorComponent>();
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp != null && moveComp.Valid)
		{
			this.DefaultDirect.DeepCopy(this.ActorComp.ActorForwardProxy);
		}
	}

	// Token: 0x06019C41 RID: 105537 RVA: 0x007F05F4 File Offset: 0x007EE7F4
	public void AddEvents()
	{
		if (!EventSystem.Instance.HasWithTarget(this.Entity, EEventName.CharTurnBegin, new Action(this.OnCharTurnBegin)))
		{
			EventSystem.Instance.AddWithTarget(this.Entity, EEventName.CharTurnBegin, new Action(this.OnCharTurnBegin));
			EventSystem.Instance.AddWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnCharTurnEnd));
		}
	}

	// Token: 0x06019C42 RID: 105538 RVA: 0x007F0668 File Offset: 0x007EE868
	public void RemoveEvents()
	{
		if (EventSystem.Instance.HasWithTarget(this.Entity, EEventName.CharTurnBegin, new Action(this.OnCharTurnBegin)))
		{
			EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.CharTurnBegin, new Action(this.OnCharTurnBegin));
			EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.CharTurnEnd, new Action(this.OnCharTurnEnd));
		}
	}

	// Token: 0x06019C43 RID: 105539 RVA: 0x007F06DC File Offset: 0x007EE8DC
	private void OnCharTurnBegin()
	{
	}

	// Token: 0x06019C44 RID: 105540 RVA: 0x007F06DE File Offset: 0x007EE8DE
	private void OnCharTurnEnd()
	{
		this.RemoveEvents();
		if (this.OnTurnEndHandle != null)
		{
			this.OnTurnEndHandle();
		}
	}

	// Token: 0x06019C45 RID: 105541 RVA: 0x007F06FC File Offset: 0x007EE8FC
	public unsafe void TurnToInteractTarget()
	{
		if (!this.NeedTurn)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.NPC;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[PawnTurnActionController.TurnToInteractTarget][交互转身] NeedTurn为False";
			string item = "PbDataID";
			BaseActorComponent actorComp = this.ActorComp;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (this.OnTurnToInteractTargetEndHandle != null)
			{
				this.OnTurnToInteractTargetEndHandle();
			}
			return;
		}
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp == null || !moveComp.Valid)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.NPC;
			ELogAuthor author2 = ELogAuthor.YJX;
			string message2 = "[PawnTurnActionController.TurnToInteractTarget][交互转身] MoveComp不合法";
			string item2 = "PbDataID";
			BaseActorComponent actorComp2 = this.ActorComp;
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (actorComp2 != null) ? new int?(actorComp2.CreatureData.GetPbDataId()) : null);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			if (this.OnTurnToInteractTargetEndHandle != null)
			{
				this.OnTurnToInteractTargetEndHandle();
			}
			return;
		}
		if (this.MoveComp.CharacterMovement.MovementMode != EMovementMode.MOVE_Walking && (this.MoveComp.CharacterMovement.MovementMode != EMovementMode.MOVE_Custom || this.MoveComp.CharacterMovement.CustomMovementMode != 11))
		{
			if (this.OnTurnToInteractTargetEndHandle != null)
			{
				this.OnTurnToInteractTargetEndHandle();
			}
			return;
		}
		CharacterActorComponent characterActorComponent = Global.BaseCharacter.CharacterActorComponent;
		Entity entity = this.MoveComp.Entity;
		CommonNpcPerformComponent component = entity.GetComponent<CommonNpcPerformComponent>();
		CharacterActorComponent component2 = entity.GetComponent<CharacterActorComponent>();
		if (component2 != null)
		{
			Vector vector = Vector.Create(characterActorComponent.ActorLocationProxy);
			vector.AdditionEqual(this.PlayerOffset);
			Vector inputFacingProxy = component2.InputFacingProxy;
			Vector vector2 = vector.SubtractionEqual(component2.ActorLocationProxy);
			vector2.Z = 0.0;
			vector2.Normalize(9.99999993922529E-09);
			vector2.ToOrientationRotator(MathUtils.Instance.CommonTempRotator);
			double angleByVectorDot = MathUtils.Instance.GetAngleByVectorDot(inputFacingProxy, vector2);
			if (angleByVectorDot < 60.0)
			{
				if (component != null)
				{
					component.SightTarget(new OneOf<BaseActorComponent, Vector, AActor>?(characterActorComponent), EStareActionType.TurnToPlayer);
				}
				if (this.OnTurnToInteractTargetEndHandle != null)
				{
					this.OnTurnToInteractTargetEndHandle();
				}
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.NPC;
				ELogAuthor author3 = ELogAuthor.YJX;
				string message3 = "[PawnTurnActionController.TurnToInteractTarget][交互转身] 夹角小于阈值，转头不转身";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item3 = "PbDataID";
				BaseActorComponent actorComp3 = this.ActorComp;
				ptr = new ValueTuple<string, object>(item3, (actorComp3 != null) ? new int?(actorComp3.CreatureData.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Angle", angleByVectorDot);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TurnAngleMax", 60);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("CurRot", component2.ActorRotationProxy);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("CurInputRot", component2.InputRotatorProxy);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("TarRot", MathUtils.Instance.CommonTempRotator);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
				return;
			}
			if (this.WaitTurnEnd)
			{
				this.SetPlayerLock(true);
			}
			else if (this.OnTurnToInteractTargetEndHandle != null)
			{
				this.OnTurnToInteractTargetEndHandle();
			}
			Vector vector3 = Vector.Create(characterActorComponent.ActorLocationProxy);
			vector3.AdditionEqual(this.PlayerOffset);
			this.Entity.GetComponent<BasePerformComponent>().PerformTurn(EPerformMode.Action, new TurnParam
			{
				TargetLocation = vector3
			}, null, null);
			this.OnTurnEndHandle = new Action(this.TurnToInteractTargetEnd);
			this.AddEvents();
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.NPC;
			ELogAuthor author4 = ELogAuthor.YJX;
			string message4 = "[PawnTurnActionController.TurnToInteractTarget][交互转身] 添加转身监听事件";
			string item4 = "PbDataID";
			BaseActorComponent actorComp4 = this.ActorComp;
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>(item4, (actorComp4 != null) ? new int?(actorComp4.CreatureData.GetPbDataId()) : null);
			instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			this.HasInteractTurned = new bool?(true);
		}
	}

	// Token: 0x06019C46 RID: 105542 RVA: 0x007F0B08 File Offset: 0x007EED08
	private void TurnToInteractTargetEnd()
	{
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp == null || !moveComp.Valid)
		{
			if (this.OnTurnToInteractTargetEndHandle != null)
			{
				this.OnTurnToInteractTargetEndHandle();
			}
			return;
		}
		CharacterActorComponent characterActorComponent = Global.BaseCharacter.CharacterActorComponent;
		CommonNpcPerformComponent component = this.MoveComp.Entity.GetComponent<CommonNpcPerformComponent>();
		if (component != null)
		{
			component.SightTarget(new OneOf<BaseActorComponent, Vector, AActor>?(characterActorComponent), EStareActionType.TurnToPlayer);
		}
		if (this.WaitTurnEnd)
		{
			this.SetPlayerLock(false);
			if (this.OnTurnToInteractTargetEndHandle != null)
			{
				this.OnTurnToInteractTargetEndHandle();
			}
		}
	}

	// Token: 0x06019C47 RID: 105543 RVA: 0x007F0B94 File Offset: 0x007EED94
	private void SetPlayerLock(bool value)
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		Entity entity;
		if (baseCharacter == null)
		{
			entity = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			entity = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
		}
		Entity entity2 = entity;
		if (entity2 == null)
		{
			return;
		}
		CharacterInputComponent component = entity2.GetComponent<CharacterInputComponent>();
		if (value)
		{
			entity2.GetComponent<CharacterActorComponent>().SetInputDirect(Vector.ZeroVectorProxy, false, EInputDirectSpace.World);
			component.ClearMoveVectorCache();
			component.SetActive(false);
		}
		else
		{
			component.SetActive(true);
		}
		this.IsPlayerInputLocked = value;
	}

	// Token: 0x06019C48 RID: 105544 RVA: 0x007F0C04 File Offset: 0x007EEE04
	public void TurnToDefaultForward()
	{
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp == null || !moveComp.Valid)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.NPC;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[PawnTurnActionController.TurnToDefaultForward][结束交互转身] MoveComp不合法";
			string item = "PbDataID";
			BaseActorComponent actorComp = this.ActorComp;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (this.OnTurnToDefaultForwardEndHandle != null)
			{
				this.OnTurnToDefaultForwardEndHandle();
			}
			return;
		}
		Entity entity = this.MoveComp.Entity;
		CommonNpcPerformComponent component = entity.GetComponent<CommonNpcPerformComponent>();
		if (component != null)
		{
			component.SightTarget(null, EStareActionType.TurnToPlayer);
		}
		if (!this.NeedTurn || !this.HasInteractTurned.GetValueOrDefault())
		{
			if (this.OnTurnToDefaultForwardEndHandle != null)
			{
				this.OnTurnToDefaultForwardEndHandle();
			}
			return;
		}
		if (this.MoveComp.CharacterMovement.MovementMode != EMovementMode.MOVE_Walking && (this.MoveComp.CharacterMovement.MovementMode != EMovementMode.MOVE_Custom || this.MoveComp.CharacterMovement.CustomMovementMode != 11))
		{
			if (this.OnTurnToDefaultForwardEndHandle != null)
			{
				this.OnTurnToDefaultForwardEndHandle();
			}
			return;
		}
		if (entity.GetComponent<CharacterActorComponent>() != null)
		{
			this.Entity.GetComponent<BasePerformComponent>().PerformTurn(EPerformMode.Action, new TurnParam
			{
				Direction = this.DefaultDirect
			}, null, null);
			this.OnTurnEndHandle = new Action(this.TurnToDefaultForwardEnd);
			this.AddEvents();
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.NPC;
			ELogAuthor author2 = ELogAuthor.YJX;
			string message2 = "[PawnTurnActionController.TurnToDefaultForward][结束交互转身] 添加转身监听事件";
			string item2 = "PbDataID";
			BaseActorComponent actorComp2 = this.ActorComp;
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (actorComp2 != null) ? new int?(actorComp2.CreatureData.GetPbDataId()) : null);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		this.HasInteractTurned = new bool?(false);
	}

	// Token: 0x06019C49 RID: 105545 RVA: 0x007F0DE7 File Offset: 0x007EEFE7
	private void TurnToDefaultForwardEnd()
	{
		if (this.OnTurnToDefaultForwardEndHandle != null)
		{
			this.OnTurnToDefaultForwardEndHandle();
		}
	}

	// Token: 0x06019C4A RID: 105546 RVA: 0x007F0DFC File Offset: 0x007EEFFC
	[NullableContext(1)]
	public unsafe void UpdateDefaultDirect(Vector newDirect)
	{
		this.DefaultDirect.DeepCopy(newDirect);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "[PawnTurnActionController.UpdateDefaultDirect]更新默认朝向";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item = "PbDataID";
		BaseActorComponent actorComp = this.ActorComp;
		ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NewDirect", newDirect);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x06019C4B RID: 105547 RVA: 0x007F0E93 File Offset: 0x007EF093
	public void Dispose()
	{
		this.RemoveEvents();
		this.MoveComp = null;
		if (this.IsPlayerInputLocked)
		{
			this.SetPlayerLock(false);
		}
	}

	// Token: 0x0400E21B RID: 57883
	private const int TURN_ANGLE_MAX = 60;

	// Token: 0x0400E21C RID: 57884
	private readonly Entity Entity;

	// Token: 0x0400E21D RID: 57885
	private bool? HasInteractTurned;

	// Token: 0x0400E21E RID: 57886
	[Nullable(1)]
	private readonly Vector DefaultDirect = Vector.Create();

	// Token: 0x0400E21F RID: 57887
	private readonly BaseActorComponent ActorComp;

	// Token: 0x0400E220 RID: 57888
	private BaseMoveComponent MoveComp;

	// Token: 0x0400E221 RID: 57889
	public bool NeedTurn;

	// Token: 0x0400E222 RID: 57890
	public bool WaitTurnEnd;

	// Token: 0x0400E223 RID: 57891
	[Nullable(1)]
	public Vector PlayerOffset = Vector.Create();

	// Token: 0x0400E224 RID: 57892
	protected bool IsPlayerInputLocked;

	// Token: 0x0400E225 RID: 57893
	public Action OnTurnEndHandle;

	// Token: 0x0400E226 RID: 57894
	public Action OnTurnToDefaultForwardEndHandle;

	// Token: 0x0400E227 RID: 57895
	public Action OnTurnToInteractTargetEndHandle;
}

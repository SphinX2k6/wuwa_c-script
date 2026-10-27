using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay.RollBlock.States;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock
{
	// Token: 0x02006AA0 RID: 27296
	[NullableContext(2)]
	[Nullable(0)]
	public class RbBlockComponent : RbBaseComponent
	{
		// Token: 0x06043D03 RID: 277763 RVA: 0x0109934C File Offset: 0x0109754C
		protected unsafe override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			if (this.ActorComp == null)
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "[RbBlockComponent] OnStart ActorComp is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			if (this.CreatureDataComp == null)
			{
				return false;
			}
			this.InitMoveState();
			RbBlockComponentPb rbBlockInfo = this.CreatureDataComp.RbBlockInfo;
			if (rbBlockInfo == null)
			{
				return false;
			}
			this.SizeX = rbBlockInfo.SizeX;
			this.SizeY = rbBlockInfo.SizeY;
			this.SizeZ = rbBlockInfo.SizeZ;
			this.IsVisionBlock = (rbBlockInfo.VisionBlockType != null);
			if (!this.IsVisionBlock && rbBlockInfo.DefaultBlockType != null)
			{
				this.IsMainController = rbBlockInfo.DefaultBlockType.IsMainControl;
			}
			if (this.IncId != null)
			{
				this.ChangeMoveState(rbBlockInfo.State, true);
				if (this.CacheStateInfo.Size > 0)
				{
					RbBaseMoveState curMoveState = this.CurMoveState;
					if (curMoveState != null && curMoveState.IsFinished())
					{
						this.ChangeMoveState(this.CacheStateInfo.Pop(), true);
					}
				}
			}
			else
			{
				this.CacheNewMoveState(rbBlockInfo.State);
			}
			SceneItemActorComponent component = base.Entity.GetComponent<SceneItemActorComponent>();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RollBlock;
			ELogAuthor author = ELogAuthor.CH;
			string message = "[RbBlockComponent] OnStart";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SizeX", this.SizeX);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SizeY", this.SizeY);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("location", (component != null) ? new FVectorDouble?(component.ActorLocation) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			RepeatedField<RbGridPosition> repeatedField;
			if (creatureDataComp == null)
			{
				repeatedField = null;
			}
			else
			{
				RbBlockComponentPb rbBlockInfo2 = creatureDataComp.RbBlockInfo;
				repeatedField = ((rbBlockInfo2 != null) ? rbBlockInfo2.OccupiedCellPositions : null);
			}
			RepeatedField<RbGridPosition> repeatedField2 = repeatedField;
			if (repeatedField2 != null)
			{
				foreach (RbGridPosition rbGridPosition in repeatedField2)
				{
					this.OccupiedCellIndex.Add(new JigsawIndex(rbGridPosition.X, rbGridPosition.Y));
				}
			}
			return true;
		}

		// Token: 0x06043D04 RID: 277764 RVA: 0x010995A0 File Offset: 0x010977A0
		public override void RegisterToGameplay(int incId)
		{
			base.RegisterToGameplay(incId);
			if (this.IsVisionBlock)
			{
				RollBlockController.Instance.RegisterVisionRollBlockToGameplay(this.IncId.Value);
			}
			RollBlockController.Instance.RegisterRollBlockToGameplay(this, this.IncId.Value);
			if (this.CacheStateInfo.Size > 0 && this.IncId != null)
			{
				RbBaseMoveState curMoveState = this.CurMoveState;
				if (curMoveState != null && curMoveState.IsFinished())
				{
					this.ChangeMoveState(this.CacheStateInfo.Pop(), true);
				}
			}
		}

		// Token: 0x06043D05 RID: 277765 RVA: 0x01099628 File Offset: 0x01097828
		protected unsafe override void OnTick(float delta)
		{
			if (this.FirstTick)
			{
				this.FirstTick = false;
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RollBlock;
			ELogAuthor author = ELogAuthor.CH;
			string message = "[OnTick] CurMoveState";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "State";
			RbBaseMoveState curMoveState = this.CurMoveState;
			ptr = new ValueTuple<string, object>(item, (curMoveState != null) ? new ERollBlockMoveState?(curMoveState.StateName) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "IsFinished";
			RbBaseMoveState curMoveState2 = this.CurMoveState;
			ptr2 = new ValueTuple<string, object>(item2, (curMoveState2 != null) ? new bool?(curMoveState2.IsFinished()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CacheStateInfo.Size", this.CacheStateInfo.Size);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (this.CurMoveState != null)
			{
				RbBaseMoveState curMoveState3 = this.CurMoveState;
				if (curMoveState3 == null || !curMoveState3.IsFinished())
				{
					goto IL_184;
				}
			}
			if (this.CacheStateInfo.Size > 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RollBlock;
				ELogAuthor author2 = ELogAuthor.CH;
				string message2 = "[OnTick] CurMoveState is finished, pop state";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CacheStateInfo.Size", this.CacheStateInfo.Size);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("State", this.CacheStateInfo.Peek());
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				this.ChangeMoveState(this.CacheStateInfo.Pop(), true);
			}
			IL_184:
			RbBaseMoveState curMoveState4 = this.CurMoveState;
			if (curMoveState4 != null && curMoveState4.NeedUpdate)
			{
				RbBaseMoveState curMoveState5 = this.CurMoveState;
				if (curMoveState5 != null)
				{
					curMoveState5.Update(delta);
				}
			}
			RbBaseMoveState curMoveState6 = this.CurMoveState;
			if ((curMoveState6 == null || !curMoveState6.NeedUpdate) && this.CacheStateInfo.Size == 0 && this.DisableHandle == -1)
			{
				this.DisableHandle = base.Disable("[RollBlock] CurMoveState no need update");
			}
		}

		// Token: 0x06043D06 RID: 277766 RVA: 0x0109981D File Offset: 0x01097A1D
		protected override bool OnEnd()
		{
			if (this.IsVisionBlock)
			{
				RollBlockController.Instance.UnRegisterVisionRollBlockToGameplay(this.IncId.Value);
			}
			return true;
		}

		// Token: 0x06043D07 RID: 277767 RVA: 0x0109983D File Offset: 0x01097A3D
		private void InitMoveState()
		{
			this.IdleState = new RbIdleState(this);
			this.RollState = new RbRollState(this);
			this.JumpState = new RbJumpState(this);
		}

		// Token: 0x06043D08 RID: 277768 RVA: 0x01099864 File Offset: 0x01097A64
		[NullableContext(1)]
		public global::Vector CalculateRotationCenter(float halfHeight, global::Vector inputVector)
		{
			FTransformDouble actorTransform = this.ActorComp.ActorTransform;
			global::Vector outV = global::Vector.Create();
			global::Vector vector = global::Vector.Create();
			global::Vector vector2 = vector;
			FVectorDouble location = actorTransform.GetLocation();
			vector2.FromUeVector(location);
			global::Vector vector3 = global::Vector.Create(actorTransform.GetRotation().GetAxisZ());
			global::Vector vector4 = global::Vector.Create(actorTransform.GetRotation().GetAxisX());
			global::Vector vector5 = global::Vector.Create(actorTransform.GetRotation().GetAxisY());
			bool flag = Math.Abs(global::Vector.DotProduct(vector3, global::Vector.UpVectorProxy)) > 0.8999999761581421;
			double value = global::Vector.DotProduct(vector4, inputVector);
			double value2 = global::Vector.DotProduct(vector5, inputVector);
			double value3 = global::Vector.DotProduct(vector3, inputVector);
			bool flag2 = Math.Abs(value) > 0.8999999761581421;
			bool flag3 = Math.Abs(value3) > 0.8999999761581421;
			if (flag)
			{
				vector.SubtractionEqual(global::Vector.Create(0.0, 0.0, (double)(halfHeight * (float)this.SizeZ)));
				int num = flag2 ? Math.Sign(value) : Math.Sign(value2);
				global::Vector vector6 = flag2 ? vector4 : vector5;
				vector.AdditionEqual(vector6.MultiplyEqual((double)(halfHeight * (float)(flag2 ? this.SizeX : this.SizeY) * (float)num)));
			}
			else
			{
				bool flag4 = Math.Abs(global::Vector.DotProduct(vector4, this.OriginRight)) > 0.8999999761581421;
				vector.SubtractionEqual(global::Vector.Create(0.0, 0.0, (double)(halfHeight * (float)(flag4 ? this.SizeX : this.SizeY))));
				if (flag3)
				{
					int num2 = Math.Sign(value3);
					vector.AdditionEqual(vector3.MultiplyEqual((double)(halfHeight * (float)this.SizeZ * (float)num2)));
				}
				else
				{
					global::Vector.CrossProduct(vector3, inputVector, outV);
					vector.AdditionEqual(inputVector.MultiplyEqual((double)(halfHeight * (float)(flag4 ? this.SizeY : this.SizeX))));
				}
			}
			return vector;
		}

		// Token: 0x06043D09 RID: 277769 RVA: 0x01099A77 File Offset: 0x01097C77
		public void UpdateAvailableMovement()
		{
		}

		// Token: 0x06043D0A RID: 277770 RVA: 0x01099A7C File Offset: 0x01097C7C
		public global::Vector PbDirToVector(RbGridDirection pbDir)
		{
			if (this.ActorComp == null)
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "[PbDirToVector] ActorComp is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			global::Vector vector = global::Vector.Create();
			switch (pbDir)
			{
			case RbGridDirection.RbForward:
				vector.DeepCopy(this.OriginForward);
				break;
			case RbGridDirection.RbBackward:
				vector.DeepCopy(this.OriginForward);
				vector.MultiplyEqual(-1.0);
				break;
			case RbGridDirection.RbRight:
				vector.DeepCopy(this.OriginRight);
				break;
			case RbGridDirection.RbLeft:
				vector.DeepCopy(this.OriginRight);
				vector.MultiplyEqual(-1.0);
				break;
			default:
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[PbDirToVector] 未知的方向";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Dir", pbDir);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			}
			return vector;
		}

		// Token: 0x06043D0B RID: 277771 RVA: 0x01099B5C File Offset: 0x01097D5C
		[NullableContext(1)]
		public unsafe void ChangeMoveState(RbBlockPbState newState, bool force = false)
		{
			if (this.RollState == null || this.IdleState == null)
			{
				Log.Instance.Warn(ELogModule.RollBlock, ELogAuthor.CH, "[ChangeMoveState] MoveStates are undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (!base.Entity.IsStart)
				{
					this.CacheNewMoveState(newState);
				}
				return;
			}
			if (!force && !RollBlockController.Instance.IsCurrentIncId(this.IncId.Value))
			{
				RbBaseMoveState curMoveState = this.CurMoveState;
				if (curMoveState == null || !curMoveState.IsFinished())
				{
					this.CacheNewMoveState(newState);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RollBlock;
					ELogAuthor author = ELogAuthor.CH;
					string message = "[ChangeMoveState] 当前IncId不是当前IncId，不改变状态, 缓存起来";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IncId", this.IncId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Active", base.Active);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CacheStateInfo.Size", this.CacheStateInfo.Size);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					if (this.DisableHandle != -1)
					{
						base.Enable(new int?(this.DisableHandle), "[RollBlock] CurMoveState need update");
						this.DisableHandle = -1;
					}
					return;
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RollBlock;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "[ChangeMoveState]";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("State", newState);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (newState.IdleState != null)
			{
				this.SetCurMoveState(this.IdleState, newState.IdleState);
				return;
			}
			if (newState.MovingState != null)
			{
				RbBlockMovementPbAction action = newState.MovingState.Action;
				if (((action != null) ? action.Roll : null) != null)
				{
					this.SetCurMoveState(this.RollState, newState.MovingState.Action.Roll);
					return;
				}
				RbBlockMovementPbAction action2 = newState.MovingState.Action;
				if (((action2 != null) ? action2.Jump : null) != null)
				{
					this.SetCurMoveState(this.JumpState, newState.MovingState.Action.Jump);
					return;
				}
			}
			else
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.RollBlock;
				ELogAuthor author3 = ELogAuthor.CH;
				string message3 = "[ChangeMoveState] 未知的状态";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("State", newState);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
		}

		// Token: 0x06043D0C RID: 277772 RVA: 0x01099D9C File Offset: 0x01097F9C
		private void SetCurMoveState(RbBaseMoveState value, [Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<RbBlockIdlePbState, RbJumpMovement, RbRollMovement> info)
		{
			if (value == null || this.CurMoveState == value)
			{
				return;
			}
			RbBaseMoveState curMoveState = this.CurMoveState;
			if (curMoveState != null)
			{
				curMoveState.Exit();
			}
			this.CurMoveState = value;
			RbBaseMoveState curMoveState2 = this.CurMoveState;
			if (curMoveState2 != null)
			{
				curMoveState2.Enter(info);
			}
			RbBaseMoveState curMoveState3 = this.CurMoveState;
			if (curMoveState3 != null && curMoveState3.NeedUpdate && this.DisableHandle != -1)
			{
				base.Enable(new int?(this.DisableHandle), "[RollBlock] CurMoveState need update");
				this.DisableHandle = -1;
				this.FirstTick = true;
				return;
			}
			RbBaseMoveState curMoveState4 = this.CurMoveState;
			if ((curMoveState4 == null || !curMoveState4.NeedUpdate) && this.DisableHandle == -1 && this.CacheStateInfo.Size == 0)
			{
				this.DisableHandle = base.Disable("[RollBlock] CurMoveState no need update");
			}
		}

		// Token: 0x06043D0D RID: 277773 RVA: 0x01099E64 File Offset: 0x01098064
		[NullableContext(1)]
		private void CacheNewMoveState(RbBlockPbState info)
		{
			if (this.IncId == null || !RollBlockController.Instance.IsCurrentIncId(this.IncId.Value))
			{
				if (info.IdleState != null)
				{
					this.CacheStateInfo.Clear();
				}
				Log.Instance.Info(ELogModule.RollBlock, ELogAuthor.CH, "[CacheNewMoveState] RemoveCacheStateInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.CacheStateInfo.Push(info);
		}

		// Token: 0x17009944 RID: 39236
		// (get) Token: 0x06043D0E RID: 277774 RVA: 0x01099ED6 File Offset: 0x010980D6
		public FTransformDouble Transform
		{
			get
			{
				return this.ActorComp.ActorTransform;
			}
		}

		// Token: 0x17009945 RID: 39237
		// (get) Token: 0x06043D0F RID: 277775 RVA: 0x01099EE3 File Offset: 0x010980E3
		public long CreatureDataId
		{
			get
			{
				return this.CreatureDataComp.GetCreatureDataId();
			}
		}

		// Token: 0x06043D10 RID: 277776 RVA: 0x01099EF0 File Offset: 0x010980F0
		public void SetActorTransform(FTransformDouble transform)
		{
			SceneItemActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "[SetActorLocationAndRotation] ActorComp is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			actorComp.SetActorTransform(transform, "RollBlockController", true, null);
		}

		// Token: 0x06043D11 RID: 277777 RVA: 0x01099F3E File Offset: 0x0109813E
		public AActor GetActor()
		{
			SceneItemActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return null;
			}
			return actorComp.Owner;
		}

		// Token: 0x17009946 RID: 39238
		// (get) Token: 0x06043D12 RID: 277778 RVA: 0x01099F51 File Offset: 0x01098151
		public ERollBlockMoveState CurState
		{
			get
			{
				RbBaseMoveState curMoveState = this.CurMoveState;
				if (curMoveState == null)
				{
					return ERollBlockMoveState.Idle;
				}
				return curMoveState.StateName;
			}
		}

		// Token: 0x06043D13 RID: 277779 RVA: 0x01099F64 File Offset: 0x01098164
		public override bool IsMoving()
		{
			return !this.IsVisionBlock && this.CurState != ERollBlockMoveState.Idle;
		}

		// Token: 0x06043D14 RID: 277780 RVA: 0x01099F7C File Offset: 0x0109817C
		[NullableContext(1)]
		public void SetActorLocationAndRotation(global::Vector location, global::Rotator rotation)
		{
			SceneItemActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "[SetActorLocation] ActorComp is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			actorComp.SetActorLocationAndRotation(location.ToUeVector(false), rotation.ToUeRotator(), "RollBlockController", false, null);
		}

		// Token: 0x06043D15 RID: 277781 RVA: 0x01099FD8 File Offset: 0x010981D8
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			RbBlockComponent rbBlockComponent = (RbBlockComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (rbBlockComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (rbBlockComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SizeX"))
			{
				this.SizeX = rbBlockComponent.SizeX;
			}
			if (base.CanResetComponentProperty("SizeY"))
			{
				this.SizeY = rbBlockComponent.SizeY;
			}
			if (base.CanResetComponentProperty("SizeZ"))
			{
				this.SizeZ = rbBlockComponent.SizeZ;
			}
			if (base.CanResetComponentProperty("CurMoveState"))
			{
				if (rbBlockComponent.CurMoveState == null)
				{
					this.CurMoveState = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RbBaseMoveState>(this.CurMoveState), "CurMoveState"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RollState"))
			{
				if (rbBlockComponent.RollState == null)
				{
					this.RollState = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RbRollState>(this.RollState), "RollState"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IdleState"))
			{
				if (rbBlockComponent.IdleState == null)
				{
					this.IdleState = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RbIdleState>(this.IdleState), "IdleState"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("JumpState"))
			{
				if (rbBlockComponent.JumpState == null)
				{
					this.JumpState = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RbJumpState>(this.JumpState), "JumpState"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FirstTick"))
			{
				this.FirstTick = rbBlockComponent.FirstTick;
			}
			if (base.CanResetComponentProperty("AvailableInputDirs"))
			{
				if (rbBlockComponent.AvailableInputDirs == null)
				{
					this.AvailableInputDirs = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<RbGridDirection>>(this.AvailableInputDirs), "AvailableInputDirs"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DisableHandle"))
			{
				this.DisableHandle = rbBlockComponent.DisableHandle;
			}
			if (base.CanResetComponentProperty("IsVisionBlock"))
			{
				this.IsVisionBlock = rbBlockComponent.IsVisionBlock;
			}
			return !base.CanResetComponentProperty("CacheStateInfo") || rbBlockComponent.CacheStateInfo == null || base.CheckClearObject(EntityComponentSystem.ClearObject<global::Stack<RbBlockPbState>>(this.CacheStateInfo), "CacheStateInfo");
		}

		// Token: 0x040236D8 RID: 145112
		private SceneItemActorComponent ActorComp;

		// Token: 0x040236D9 RID: 145113
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x040236DA RID: 145114
		public int SizeX = 1;

		// Token: 0x040236DB RID: 145115
		public int SizeY = 1;

		// Token: 0x040236DC RID: 145116
		public int SizeZ = 1;

		// Token: 0x040236DD RID: 145117
		private RbBaseMoveState CurMoveState;

		// Token: 0x040236DE RID: 145118
		private RbRollState RollState;

		// Token: 0x040236DF RID: 145119
		private RbIdleState IdleState;

		// Token: 0x040236E0 RID: 145120
		private RbJumpState JumpState;

		// Token: 0x040236E1 RID: 145121
		private bool FirstTick;

		// Token: 0x040236E2 RID: 145122
		[Nullable(1)]
		public List<RbGridDirection> AvailableInputDirs;

		// Token: 0x040236E3 RID: 145123
		private int DisableHandle = -1;

		// Token: 0x040236E4 RID: 145124
		public bool IsVisionBlock;

		// Token: 0x040236E5 RID: 145125
		[Nullable(1)]
		private readonly global::Stack<RbBlockPbState> CacheStateInfo = new global::Stack<RbBlockPbState>();
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Gameplay.RollBlock;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock.States
{
	// Token: 0x02006AAE RID: 27310
	[NullableContext(1)]
	[Nullable(0)]
	public class RbRollState : RbBaseMoveState
	{
		// Token: 0x06043D88 RID: 277896 RVA: 0x0109FD69 File Offset: 0x0109DF69
		public RbRollState(RbBlockComponent owner) : base(owner)
		{
		}

		// Token: 0x06043D89 RID: 277897 RVA: 0x0109FD94 File Offset: 0x0109DF94
		public override void Enter([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<RbBlockIdlePbState, RbJumpMovement, RbRollMovement> info)
		{
			if (!RollBlockDefind.isRbBlockRollState(info))
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "RbIdleState Enter without MovingState info", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.StateName = ERollBlockMoveState.Roll;
			this.Info = info.AsT3;
			this.Owner.AvailableInputDirs = new List<RbGridDirection>();
			RbRollMovement info2 = this.Info;
			RbGridDirection? rbGridDirection = (info2 != null) ? new RbGridDirection?(info2.Direction) : null;
			if (rbGridDirection != null)
			{
				this.CurMoveDir = this.Owner.PbDirToVector(rbGridDirection.Value);
			}
			this.RollingTimer = 0f;
			this.OriginTrans = new FTransformDouble?(this.Owner.Transform);
			this.GameplaySetting = RollBlockController.Instance.GameplaySetting;
			this.RotationAxis = global::Vector.Create(this.CurMoveDir);
			this.RotationAxis.CrossProductEqual(global::Vector.Create(0.0, 0.0, 1.0));
			this.RotationCenter = this.Owner.CalculateRotationCenter(50f, this.CurMoveDir);
			this.IsFinishedInternal = false;
			this.BlockRollTime = (this.Owner.IsMainController ? this.GameplaySetting.BlockRollTime : this.GameplaySetting.VisionBlockRollTime);
		}

		// Token: 0x06043D8A RID: 277898 RVA: 0x0109FEEC File Offset: 0x0109E0EC
		public override void Update(float delta)
		{
			if (this.RollingTimer >= this.BlockRollTime)
			{
				return;
			}
			if (this.Info == null || this.CurMoveDir == null || this.OriginTrans == null || this.GameplaySetting == null || this.Owner == null)
			{
				return;
			}
			this.RollingTimer += delta / (float)TimeUtil.Instance.InverseMillisecond;
			float alpha = MathUtils.Instance.Clamp(this.RollingTimer / this.BlockRollTime, 0f, 1f);
			FTransformDouble actorTransform = this.CalcNewTransform(alpha);
			this.Owner.SetActorTransform(actorTransform);
			if (this.RollingTimer >= this.BlockRollTime)
			{
				this.OnBlockRollFinish(this.Owner.Entity);
			}
		}

		// Token: 0x06043D8B RID: 277899 RVA: 0x0109FFA8 File Offset: 0x0109E1A8
		private FTransformDouble CalcNewTransform(float alpha)
		{
			global::Vector vector = global::Vector.Create(this.OriginTrans.Value.GetLocation());
			FQuat rotation = this.OriginTrans.Value.GetRotation();
			FVector fvector = this.RotationAxis.ToUeVectorOld();
			FQuat fquat = new FQuat(ref fvector, -1.5707964f * alpha);
			global::Vector vector2 = global::Vector.Create();
			vector.Subtraction(this.RotationCenter, vector2);
			fvector = vector2.ToUeVectorOld();
			FVector fvector2 = fquat.RotateVector(fvector);
			FVector fvector3 = this.RotationCenter.ToUeVectorOld();
			FVector fvector4 = fvector2 + fvector3;
			FRotator frotator = (fquat * rotation).Rotator();
			FVectorDouble fvectorDouble = new FVectorDouble(ref fvector4);
			fvector = this.OriginTrans.Value.GetScale3D();
			return new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
		}

		// Token: 0x06043D8C RID: 277900 RVA: 0x010A0080 File Offset: 0x0109E280
		private void OnBlockRollFinish(Entity entity)
		{
			FTransformDouble actorTransform = this.CalcNewTransform(1f);
			this.Owner.SetActorTransform(actorTransform);
			if (RollBlockController.Instance.IsCurrentIncId(this.Owner.IncId.Value))
			{
				base.NotifyServerMovementFinish();
			}
			this.IsFinishedInternal = true;
		}

		// Token: 0x0402374F RID: 145231
		[Nullable(2)]
		public RbRollMovement Info;

		// Token: 0x04023750 RID: 145232
		[Nullable(2)]
		private global::Vector CurMoveDir = global::Vector.Create();

		// Token: 0x04023751 RID: 145233
		private float RollingTimer;

		// Token: 0x04023752 RID: 145234
		private global::Vector RotationCenter = global::Vector.Create();

		// Token: 0x04023753 RID: 145235
		private global::Vector RotationAxis = global::Vector.Create();

		// Token: 0x04023754 RID: 145236
		private float BlockRollTime;

		// Token: 0x04023755 RID: 145237
		private FTransformDouble? OriginTrans;

		// Token: 0x04023756 RID: 145238
		[Nullable(2)]
		public BP_RollBlockGameplaySetting_C GameplaySetting;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState
{
	// Token: 0x0200608B RID: 24715
	[NullableContext(1)]
	[Nullable(0)]
	public class DgmClawBaseMoveState
	{
		// Token: 0x0603B4BA RID: 242874 RVA: 0x010C7A8C File Offset: 0x010C5C8C
		public DgmClawBaseMoveState(SceneItemDollGrabMachineComponent owner, AActor clawActor, AActor clawRootActor, FTransformDouble ownerActorTransform)
		{
			this.Owner = owner;
			this.ClawActor = clawActor;
			this.ClawRootActor = clawRootActor;
			Vector ownerLocation = this.OwnerLocation;
			FVectorDouble location = ownerActorTransform.GetLocation();
			ownerLocation.FromUeVector(location);
			Vector ownerScale = this.OwnerScale;
			FVector scale3D = ownerActorTransform.GetScale3D();
			ownerScale.FromUeVector(scale3D);
			Rotator ownerRotation = this.OwnerRotation;
			FRotator frotator = ownerActorTransform.GetRotation().Rotator();
			ownerRotation.FromUeRotator(frotator);
		}

		// Token: 0x0603B4BB RID: 242875 RVA: 0x010C7B27 File Offset: 0x010C5D27
		public virtual void Enter()
		{
		}

		// Token: 0x0603B4BC RID: 242876 RVA: 0x010C7B29 File Offset: 0x010C5D29
		protected virtual void End()
		{
			EventSystem.Instance.EmitWithTarget(this.Owner.Entity, EEventName.OnDollGrabMachineClawStateEnd);
		}

		// Token: 0x0603B4BD RID: 242877 RVA: 0x010C7B46 File Offset: 0x010C5D46
		public virtual void Exit()
		{
		}

		// Token: 0x0603B4BE RID: 242878 RVA: 0x010C7B48 File Offset: 0x010C5D48
		public virtual void Update(float delta)
		{
		}

		// Token: 0x0603B4BF RID: 242879 RVA: 0x010C7B4A File Offset: 0x010C5D4A
		public virtual void Pause()
		{
		}

		// Token: 0x0603B4C0 RID: 242880 RVA: 0x010C7B4C File Offset: 0x010C5D4C
		public virtual void Resume()
		{
		}

		// Token: 0x1700703C RID: 28732
		// (get) Token: 0x0603B4C1 RID: 242881 RVA: 0x010C7B4E File Offset: 0x010C5D4E
		public EDollGrabMachineClawState ClawState
		{
			get
			{
				return this.StateInternal;
			}
		}

		// Token: 0x1700703D RID: 28733
		// (get) Token: 0x0603B4C2 RID: 242882 RVA: 0x010C7B58 File Offset: 0x010C5D58
		public EDollGrabMachineClawState? TargetState
		{
			get
			{
				foreach (KeyValuePair<EDollGrabMachineClawState, Func<bool>> keyValuePair in this.NextStateMap)
				{
					if (keyValuePair.Value == null)
					{
						return new EDollGrabMachineClawState?(keyValuePair.Key);
					}
					if (keyValuePair.Value())
					{
						return new EDollGrabMachineClawState?(keyValuePair.Key);
					}
				}
				return null;
			}
		}

		// Token: 0x0401F3A6 RID: 127910
		protected bool IsFirstEnter;

		// Token: 0x0401F3A7 RID: 127911
		[Nullable(2)]
		protected SceneItemDollGrabMachineComponent Owner;

		// Token: 0x0401F3A8 RID: 127912
		protected Vector OwnerLocation = Vector.Create();

		// Token: 0x0401F3A9 RID: 127913
		protected Vector OwnerScale = Vector.Create();

		// Token: 0x0401F3AA RID: 127914
		protected Rotator OwnerRotation = Rotator.Create();

		// Token: 0x0401F3AB RID: 127915
		[Nullable(2)]
		protected AActor ClawActor;

		// Token: 0x0401F3AC RID: 127916
		[Nullable(2)]
		protected AActor ClawRootActor;

		// Token: 0x0401F3AD RID: 127917
		protected EDollGrabMachineClawState StateInternal;

		// Token: 0x0401F3AE RID: 127918
		[Nullable(new byte[]
		{
			1,
			2
		})]
		protected Dictionary<EDollGrabMachineClawState, Func<bool>> NextStateMap = new Dictionary<EDollGrabMachineClawState, Func<bool>>();
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState
{
	// Token: 0x02006F0A RID: 28426
	[NullableContext(1)]
	[Nullable(0)]
	public class DgmClawBaseMoveState
	{
		// Token: 0x0604530C RID: 283404 RVA: 0x0111DAEC File Offset: 0x0111BCEC
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

		// Token: 0x0604530D RID: 283405 RVA: 0x0111DB87 File Offset: 0x0111BD87
		public virtual void Enter()
		{
		}

		// Token: 0x0604530E RID: 283406 RVA: 0x0111DB89 File Offset: 0x0111BD89
		protected virtual void End()
		{
			EventSystem.Instance.EmitWithTarget(this.Owner.Entity, EEventName.OnDollGrabMachineClawStateEnd);
		}

		// Token: 0x0604530F RID: 283407 RVA: 0x0111DBA6 File Offset: 0x0111BDA6
		public virtual void Exit()
		{
		}

		// Token: 0x06045310 RID: 283408 RVA: 0x0111DBA8 File Offset: 0x0111BDA8
		public virtual void Update(float delta)
		{
		}

		// Token: 0x06045311 RID: 283409 RVA: 0x0111DBAA File Offset: 0x0111BDAA
		public virtual void Pause()
		{
		}

		// Token: 0x06045312 RID: 283410 RVA: 0x0111DBAC File Offset: 0x0111BDAC
		public virtual void Resume()
		{
		}

		// Token: 0x17009AFD RID: 39677
		// (get) Token: 0x06045313 RID: 283411 RVA: 0x0111DBAE File Offset: 0x0111BDAE
		public EDollGrabMachineClawState ClawState
		{
			get
			{
				return this.StateInternal;
			}
		}

		// Token: 0x17009AFE RID: 39678
		// (get) Token: 0x06045314 RID: 283412 RVA: 0x0111DBB8 File Offset: 0x0111BDB8
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

		// Token: 0x040240F1 RID: 147697
		protected bool IsFirstEnter;

		// Token: 0x040240F2 RID: 147698
		[Nullable(2)]
		protected SceneItemDollGrabMachineComponent Owner;

		// Token: 0x040240F3 RID: 147699
		protected Vector OwnerLocation = Vector.Create();

		// Token: 0x040240F4 RID: 147700
		protected Vector OwnerScale = Vector.Create();

		// Token: 0x040240F5 RID: 147701
		protected Rotator OwnerRotation = Rotator.Create();

		// Token: 0x040240F6 RID: 147702
		[Nullable(2)]
		protected AActor ClawActor;

		// Token: 0x040240F7 RID: 147703
		[Nullable(2)]
		protected AActor ClawRootActor;

		// Token: 0x040240F8 RID: 147704
		protected EDollGrabMachineClawState StateInternal;

		// Token: 0x040240F9 RID: 147705
		[Nullable(new byte[]
		{
			1,
			2
		})]
		protected Dictionary<EDollGrabMachineClawState, Func<bool>> NextStateMap = new Dictionary<EDollGrabMachineClawState, Func<bool>>();
	}
}

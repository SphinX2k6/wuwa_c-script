using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A38 RID: 19000
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TrapDefenseMarkItem
	{
		// Token: 0x17007A3B RID: 31291
		// (get) Token: 0x06031549 RID: 202057
		public abstract TrapDefenseDefine.ETrapDefenseMarkType MarkType { get; }

		// Token: 0x17007A3C RID: 31292
		// (get) Token: 0x0603154A RID: 202058 RVA: 0x00B71306 File Offset: 0x00B6F506
		// (set) Token: 0x0603154B RID: 202059 RVA: 0x00B7130E File Offset: 0x00B6F50E
		public int MarkId
		{
			get
			{
				return this.InnerMarkId;
			}
			set
			{
				this.InnerMarkId = value;
			}
		}

		// Token: 0x17007A3D RID: 31293
		// (get) Token: 0x0603154C RID: 202060 RVA: 0x00B71317 File Offset: 0x00B6F517
		// (set) Token: 0x0603154D RID: 202061 RVA: 0x00B7131F File Offset: 0x00B6F51F
		[Nullable(2)]
		public AActor TrackTarget
		{
			[NullableContext(2)]
			get
			{
				return this.TrackTargetInner;
			}
			[NullableContext(2)]
			set
			{
				this.TrackTargetInner = value;
			}
		}

		// Token: 0x17007A3E RID: 31294
		// (get) Token: 0x0603154E RID: 202062 RVA: 0x00B71328 File Offset: 0x00B6F528
		public virtual Vector WorldPosition
		{
			get
			{
				if (!this.EnableCachePosition)
				{
					if (this.TrackTarget != null)
					{
						Vector worldPositionVector = this.WorldPositionVector;
						FVectorDouble fvectorDouble = this.TrackTarget.D_K2_GetActorLocation();
						worldPositionVector.FromUeVector(fvectorDouble);
					}
					this.UiPositionVector = this.WorldPosition2UiPosition(this.WorldPositionVector, this.UiPositionVector);
				}
				return this.WorldPositionVector;
			}
		}

		// Token: 0x17007A3F RID: 31295
		// (get) Token: 0x0603154F RID: 202063 RVA: 0x00B7137C File Offset: 0x00B6F57C
		public Vector UiPosition
		{
			get
			{
				this.UiPositionVector = this.WorldPosition2UiPosition(this.WorldPosition, this.UiPositionVector);
				return this.UiPositionVector;
			}
		}

		// Token: 0x06031550 RID: 202064 RVA: 0x00B7139C File Offset: 0x00B6F59C
		private Vector WorldPosition2UiPosition(Vector position, [Nullable(2)] Vector receiveVector = null)
		{
			Vector vector = receiveVector ?? Vector.Create();
			position.Multiply(TrapDefenseDefine.worldToTrapDefenseUiUnit, vector);
			return vector;
		}

		// Token: 0x06031551 RID: 202065 RVA: 0x00B713C2 File Offset: 0x00B6F5C2
		[NullableContext(2)]
		public TrapDefenseMarkItem(int markId, object extraParam = null)
		{
			this.InnerMarkId = markId;
			this.EnableCachePosition = true;
		}

		// Token: 0x06031552 RID: 202066 RVA: 0x00B713EE File Offset: 0x00B6F5EE
		public void Initialize(AActor trackEntity)
		{
			this.TrackTargetInner = trackEntity;
			this.OnInitialize();
		}

		// Token: 0x06031553 RID: 202067
		protected abstract void OnInitialize();

		// Token: 0x0401A5C8 RID: 107976
		private int InnerMarkId;

		// Token: 0x0401A5C9 RID: 107977
		protected Vector WorldPositionVector = Vector.Create();

		// Token: 0x0401A5CA RID: 107978
		private Vector UiPositionVector = Vector.Create();

		// Token: 0x0401A5CB RID: 107979
		[Nullable(2)]
		private AActor TrackTargetInner;

		// Token: 0x0401A5CC RID: 107980
		protected bool EnableCachePosition;
	}
}

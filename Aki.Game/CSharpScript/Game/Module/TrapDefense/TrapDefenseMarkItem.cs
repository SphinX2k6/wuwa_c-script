using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039E0 RID: 14816
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TrapDefenseMarkItem
	{
		// Token: 0x17004DE8 RID: 19944
		// (get) Token: 0x060262D9 RID: 156377
		public abstract TrapDefenseDefine.ETrapDefenseMarkType MarkType { get; }

		// Token: 0x17004DE9 RID: 19945
		// (get) Token: 0x060262DA RID: 156378 RVA: 0x00AB527A File Offset: 0x00AB347A
		// (set) Token: 0x060262DB RID: 156379 RVA: 0x00AB5282 File Offset: 0x00AB3482
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

		// Token: 0x17004DEA RID: 19946
		// (get) Token: 0x060262DC RID: 156380 RVA: 0x00AB528B File Offset: 0x00AB348B
		// (set) Token: 0x060262DD RID: 156381 RVA: 0x00AB5293 File Offset: 0x00AB3493
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

		// Token: 0x17004DEB RID: 19947
		// (get) Token: 0x060262DE RID: 156382 RVA: 0x00AB529C File Offset: 0x00AB349C
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

		// Token: 0x17004DEC RID: 19948
		// (get) Token: 0x060262DF RID: 156383 RVA: 0x00AB52F0 File Offset: 0x00AB34F0
		public Vector UiPosition
		{
			get
			{
				this.UiPositionVector = this.WorldPosition2UiPosition(this.WorldPosition, this.UiPositionVector);
				return this.UiPositionVector;
			}
		}

		// Token: 0x060262E0 RID: 156384 RVA: 0x00AB5310 File Offset: 0x00AB3510
		private Vector WorldPosition2UiPosition(Vector position, [Nullable(2)] Vector receiveVector = null)
		{
			Vector vector = receiveVector ?? Vector.Create();
			position.Multiply(TrapDefenseDefine.worldToTrapDefenseUiUnit, vector);
			return vector;
		}

		// Token: 0x060262E1 RID: 156385 RVA: 0x00AB5336 File Offset: 0x00AB3536
		[NullableContext(2)]
		public TrapDefenseMarkItem(int markId, object extraParam = null)
		{
			this.InnerMarkId = markId;
			this.EnableCachePosition = true;
		}

		// Token: 0x060262E2 RID: 156386 RVA: 0x00AB5362 File Offset: 0x00AB3562
		public void Initialize(AActor trackEntity)
		{
			this.TrackTargetInner = trackEntity;
			this.OnInitialize();
		}

		// Token: 0x060262E3 RID: 156387
		protected abstract void OnInitialize();

		// Token: 0x04014F1A RID: 85786
		private int InnerMarkId;

		// Token: 0x04014F1B RID: 85787
		protected Vector WorldPositionVector = Vector.Create();

		// Token: 0x04014F1C RID: 85788
		private Vector UiPositionVector = Vector.Create();

		// Token: 0x04014F1D RID: 85789
		[Nullable(2)]
		private AActor TrackTargetInner;

		// Token: 0x04014F1E RID: 85790
		protected bool EnableCachePosition;
	}
}

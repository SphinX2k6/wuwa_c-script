using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x020063E6 RID: 25574
	[NullableContext(2)]
	[Nullable(0)]
	public class SkeletalMeshEffectContext : EffectContext
	{
		// Token: 0x0603DFB5 RID: 253877 RVA: 0x011FCCA6 File Offset: 0x011FAEA6
		public SkeletalMeshEffectContext(int? entityId = null, UObject sourceObject = null, bool disablePostProcess = false) : base(entityId, sourceObject, disablePostProcess)
		{
		}

		// Token: 0x0603DFB6 RID: 253878 RVA: 0x011FCCB4 File Offset: 0x011FAEB4
		[NullableContext(1)]
		public override void ToKuroEffectContext(FKuroEffectContext context)
		{
			base.ToKuroEffectContext(context);
			FKuroSkeletalMeshEffectContext fkuroSkeletalMeshEffectContext = context as FKuroSkeletalMeshEffectContext;
			if (fkuroSkeletalMeshEffectContext != null)
			{
				fkuroSkeletalMeshEffectContext.SkeletalMeshComponent = this.SkeletalMeshComp;
				fkuroSkeletalMeshEffectContext.IsSyncTimeDilation = this.IsSyncEffectTimeScale;
				fkuroSkeletalMeshEffectContext.IsSyncEventTimeToEffectTime = this.IsSyncEventTimeToEffectTime;
			}
		}

		// Token: 0x04020E60 RID: 134752
		public USkeletalMeshComponent SkeletalMeshComp;

		// Token: 0x04020E61 RID: 134753
		public bool IsSyncEffectTimeScale;

		// Token: 0x04020E62 RID: 134754
		public bool IsSyncEventTimeToEffectTime;
	}
}

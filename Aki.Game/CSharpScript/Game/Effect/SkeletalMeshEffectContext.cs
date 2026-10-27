using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x02007267 RID: 29287
	[NullableContext(2)]
	[Nullable(0)]
	public class SkeletalMeshEffectContext : EffectContext
	{
		// Token: 0x06047BFB RID: 293883 RVA: 0x0125C386 File Offset: 0x0125A586
		public SkeletalMeshEffectContext(int? entityId = null, UObject sourceObject = null, bool disablePostProcess = false) : base(entityId, sourceObject, disablePostProcess)
		{
		}

		// Token: 0x06047BFC RID: 293884 RVA: 0x0125C394 File Offset: 0x0125A594
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

		// Token: 0x04025BA1 RID: 154529
		public USkeletalMeshComponent SkeletalMeshComp;

		// Token: 0x04025BA2 RID: 154530
		public bool IsSyncEffectTimeScale;

		// Token: 0x04025BA3 RID: 154531
		public bool IsSyncEventTimeToEffectTime;
	}
}

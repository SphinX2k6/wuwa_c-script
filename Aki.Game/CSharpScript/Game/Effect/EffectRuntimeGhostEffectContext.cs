using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x02007266 RID: 29286
	public class EffectRuntimeGhostEffectContext : SkeletalMeshEffectContext
	{
		// Token: 0x06047BF9 RID: 293881 RVA: 0x0125C308 File Offset: 0x0125A508
		[NullableContext(2)]
		public EffectRuntimeGhostEffectContext(int? entityId = null, UObject sourceObject = null, bool disablePostProcess = false) : base(entityId, sourceObject, disablePostProcess)
		{
		}

		// Token: 0x06047BFA RID: 293882 RVA: 0x0125C32C File Offset: 0x0125A52C
		[NullableContext(1)]
		public override void ToKuroEffectContext(FKuroEffectContext context)
		{
			base.ToKuroEffectContext(context);
			FKuroEffectRuntimeGhostEffectContext fkuroEffectRuntimeGhostEffectContext = context as FKuroEffectRuntimeGhostEffectContext;
			if (fkuroEffectRuntimeGhostEffectContext != null)
			{
				fkuroEffectRuntimeGhostEffectContext.SpawnRate = this.SpawnRate;
				fkuroEffectRuntimeGhostEffectContext.UseSpawnRate = this.UseSpawnRate;
				fkuroEffectRuntimeGhostEffectContext.SpawnInterval = this.SpawnInterval;
				fkuroEffectRuntimeGhostEffectContext.GhostLifeTime = this.GhostLifeTime;
				fkuroEffectRuntimeGhostEffectContext.UseBaseColorTex = this.UseBaseColorTex;
			}
		}

		// Token: 0x04025B9C RID: 154524
		public float SpawnRate = --0f;

		// Token: 0x04025B9D RID: 154525
		public bool UseSpawnRate;

		// Token: 0x04025B9E RID: 154526
		public float SpawnInterval;

		// Token: 0x04025B9F RID: 154527
		public float GhostLifeTime = --0f;

		// Token: 0x04025BA0 RID: 154528
		public bool UseBaseColorTex;
	}
}

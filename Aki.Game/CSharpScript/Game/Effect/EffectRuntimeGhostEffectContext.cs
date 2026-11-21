using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x020063E5 RID: 25573
	public class EffectRuntimeGhostEffectContext : SkeletalMeshEffectContext
	{
		// Token: 0x0603DFB3 RID: 253875 RVA: 0x011FCC28 File Offset: 0x011FAE28
		[NullableContext(2)]
		public EffectRuntimeGhostEffectContext(int? entityId = null, UObject sourceObject = null, bool disablePostProcess = false) : base(entityId, sourceObject, disablePostProcess)
		{
		}

		// Token: 0x0603DFB4 RID: 253876 RVA: 0x011FCC4C File Offset: 0x011FAE4C
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

		// Token: 0x04020E5B RID: 134747
		public float SpawnRate = --0f;

		// Token: 0x04020E5C RID: 134748
		public bool UseSpawnRate;

		// Token: 0x04020E5D RID: 134749
		public float SpawnInterval;

		// Token: 0x04020E5E RID: 134750
		public float GhostLifeTime = --0f;

		// Token: 0x04020E5F RID: 134751
		public bool UseBaseColorTex;
	}
}

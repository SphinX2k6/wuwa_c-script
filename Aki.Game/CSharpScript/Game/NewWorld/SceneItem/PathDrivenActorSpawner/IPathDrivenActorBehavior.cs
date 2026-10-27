using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071C9 RID: 29129
	[NullableContext(1)]
	public interface IPathDrivenActorBehavior
	{
		// Token: 0x06047498 RID: 291992
		bool Initialize(IPathDrivenActorRuntimeData runtimeData);

		// Token: 0x06047499 RID: 291993
		void PrepareCollisionBeforeSpawn(IPathDrivenActorRuntimeData runtimeData);

		// Token: 0x0604749A RID: 291994
		void RestoreCollisionAfterSpawn(IPathDrivenActorRuntimeData runtimeData);

		// Token: 0x0604749B RID: 291995
		void ClearCollisionBeforeRecycle(IPathDrivenActorRuntimeData runtimeData);

		// Token: 0x0604749C RID: 291996
		void OnFinishing(IPathDrivenActorRuntimeData runtimeData, EPathDrivenActorFinishReason reason);

		// Token: 0x0604749D RID: 291997
		void Cleanup(IPathDrivenActorRuntimeData runtimeData);

		// Token: 0x0604749E RID: 291998
		void OnStagnationChanged(IPathDrivenActorRuntimeData runtimeData, bool isStagnated);

		// Token: 0x0604749F RID: 291999
		void OnSpawnerStagnationChanged(IPathDrivenActorRuntimeData runtimeData, bool isStagnated);

		// Token: 0x060474A0 RID: 292000
		[NullableContext(0)]
		UniTask<bool> OnTrackSwitched([Nullable(1)] IPathDrivenActorRuntimeData runtimeData, FTransformDouble fromTransform, FTransformDouble toTransform);
	}
}

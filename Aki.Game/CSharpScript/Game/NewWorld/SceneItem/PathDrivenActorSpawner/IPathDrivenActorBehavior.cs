using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x0200627E RID: 25214
	[NullableContext(1)]
	public interface IPathDrivenActorBehavior
	{
		// Token: 0x0603CD9A RID: 249242
		bool Initialize(IPathDrivenActorRuntimeData runtimeData);

		// Token: 0x0603CD9B RID: 249243
		void PrepareCollisionBeforeSpawn(IPathDrivenActorRuntimeData runtimeData);

		// Token: 0x0603CD9C RID: 249244
		void RestoreCollisionAfterSpawn(IPathDrivenActorRuntimeData runtimeData);

		// Token: 0x0603CD9D RID: 249245
		void ClearCollisionBeforeRecycle(IPathDrivenActorRuntimeData runtimeData);

		// Token: 0x0603CD9E RID: 249246
		void OnFinishing(IPathDrivenActorRuntimeData runtimeData, EPathDrivenActorFinishReason reason);

		// Token: 0x0603CD9F RID: 249247
		void Cleanup(IPathDrivenActorRuntimeData runtimeData);

		// Token: 0x0603CDA0 RID: 249248
		void OnStagnationChanged(IPathDrivenActorRuntimeData runtimeData, bool isStagnated);

		// Token: 0x0603CDA1 RID: 249249
		void OnSpawnerStagnationChanged(IPathDrivenActorRuntimeData runtimeData, bool isStagnated);

		// Token: 0x0603CDA2 RID: 249250
		[NullableContext(0)]
		UniTask<bool> OnTrackSwitched([Nullable(1)] IPathDrivenActorRuntimeData runtimeData, FTransformDouble fromTransform, FTransformDouble toTransform);
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071CA RID: 29130
	public interface IPathDrivenActorTickBehavior : IPathDrivenActorBehavior
	{
		// Token: 0x060474A1 RID: 292001
		[NullableContext(1)]
		void Tick(IPathDrivenActorRuntimeData runtimeData, float deltaSeconds);
	}
}

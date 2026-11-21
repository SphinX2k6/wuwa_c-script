using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x0200627F RID: 25215
	public interface IPathDrivenActorTickBehavior : IPathDrivenActorBehavior
	{
		// Token: 0x0603CDA3 RID: 249251
		[NullableContext(1)]
		void Tick(IPathDrivenActorRuntimeData runtimeData, float deltaSeconds);
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x02006284 RID: 25220
	public interface IPathDrivenCurveLoadRequest
	{
		// Token: 0x17007340 RID: 29504
		// (get) Token: 0x0603CDE2 RID: 249314
		// (set) Token: 0x0603CDE3 RID: 249315
		int HandleId { get; set; }

		// Token: 0x17007341 RID: 29505
		// (get) Token: 0x0603CDE4 RID: 249316
		// (set) Token: 0x0603CDE5 RID: 249317
		[Nullable(new byte[]
		{
			1,
			2
		})]
		CustomPromise<UCurveFloat> Promise { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			1,
			2
		})] set; }
	}
}

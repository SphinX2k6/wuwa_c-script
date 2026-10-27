using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071CF RID: 29135
	public interface IPathDrivenCurveLoadRequest
	{
		// Token: 0x17009DE9 RID: 40425
		// (get) Token: 0x060474E0 RID: 292064
		// (set) Token: 0x060474E1 RID: 292065
		int HandleId { get; set; }

		// Token: 0x17009DEA RID: 40426
		// (get) Token: 0x060474E2 RID: 292066
		// (set) Token: 0x060474E3 RID: 292067
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

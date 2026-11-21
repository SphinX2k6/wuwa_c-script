using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x02006285 RID: 25221
	public class PathDrivenCurveLoadRequest : IPathDrivenCurveLoadRequest
	{
		// Token: 0x17007342 RID: 29506
		// (get) Token: 0x0603CDE6 RID: 249318 RVA: 0x0117BB30 File Offset: 0x01179D30
		// (set) Token: 0x0603CDE7 RID: 249319 RVA: 0x0117BB38 File Offset: 0x01179D38
		public int HandleId { get; set; }

		// Token: 0x17007343 RID: 29507
		// (get) Token: 0x0603CDE8 RID: 249320 RVA: 0x0117BB41 File Offset: 0x01179D41
		// (set) Token: 0x0603CDE9 RID: 249321 RVA: 0x0117BB49 File Offset: 0x01179D49
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public CustomPromise<UCurveFloat> Promise { [return: Nullable(new byte[]
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

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071D0 RID: 29136
	public class PathDrivenCurveLoadRequest : IPathDrivenCurveLoadRequest
	{
		// Token: 0x17009DEB RID: 40427
		// (get) Token: 0x060474E4 RID: 292068 RVA: 0x01221CF9 File Offset: 0x0121FEF9
		// (set) Token: 0x060474E5 RID: 292069 RVA: 0x01221D01 File Offset: 0x0121FF01
		public int HandleId { get; set; }

		// Token: 0x17009DEC RID: 40428
		// (get) Token: 0x060474E6 RID: 292070 RVA: 0x01221D0A File Offset: 0x0121FF0A
		// (set) Token: 0x060474E7 RID: 292071 RVA: 0x01221D12 File Offset: 0x0121FF12
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

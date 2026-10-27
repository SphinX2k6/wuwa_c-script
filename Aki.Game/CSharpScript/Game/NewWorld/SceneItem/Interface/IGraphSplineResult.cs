using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Interface
{
	// Token: 0x020071FB RID: 29179
	[NullableContext(1)]
	public interface IGraphSplineResult
	{
		// Token: 0x17009E11 RID: 40465
		// (get) Token: 0x060476B7 RID: 292535
		// (set) Token: 0x060476B8 RID: 292536
		EGraphSplineMode Mode { get; set; }

		// Token: 0x17009E12 RID: 40466
		// (get) Token: 0x060476B9 RID: 292537
		// (set) Token: 0x060476BA RID: 292538
		[Nullable(2)]
		AActor Actor { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17009E13 RID: 40467
		// (get) Token: 0x060476BB RID: 292539
		// (set) Token: 0x060476BC RID: 292540
		List<USplineComponent> SplineComponents { get; set; }

		// Token: 0x17009E14 RID: 40468
		// (get) Token: 0x060476BD RID: 292541
		// (set) Token: 0x060476BE RID: 292542
		int EffectHandle { get; set; }
	}
}

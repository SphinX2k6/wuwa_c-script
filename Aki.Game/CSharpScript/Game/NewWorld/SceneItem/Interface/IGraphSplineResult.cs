using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Interface
{
	// Token: 0x020062B0 RID: 25264
	[NullableContext(1)]
	public interface IGraphSplineResult
	{
		// Token: 0x1700736E RID: 29550
		// (get) Token: 0x0603CFBF RID: 249791
		// (set) Token: 0x0603CFC0 RID: 249792
		EGraphSplineMode Mode { get; set; }

		// Token: 0x1700736F RID: 29551
		// (get) Token: 0x0603CFC1 RID: 249793
		// (set) Token: 0x0603CFC2 RID: 249794
		[Nullable(2)]
		AActor Actor { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007370 RID: 29552
		// (get) Token: 0x0603CFC3 RID: 249795
		// (set) Token: 0x0603CFC4 RID: 249796
		List<USplineComponent> SplineComponents { get; set; }

		// Token: 0x17007371 RID: 29553
		// (get) Token: 0x0603CFC5 RID: 249797
		// (set) Token: 0x0603CFC6 RID: 249798
		int EffectHandle { get; set; }
	}
}

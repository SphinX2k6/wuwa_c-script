using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045C9 RID: 17865
	public class EffectNiagaraParameters : EffectParametersBase
	{
		// Token: 0x0602E0F6 RID: 188662 RVA: 0x00A9E181 File Offset: 0x00A9C381
		public EffectNiagaraParameters([Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<FName, FKuroCurveFloat> floats = null, [Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<FName, FKuroCurveVector> vectors = null, [Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<FName, FKuroCurveLinearColor> colors = null)
		{
			if (floats != null)
			{
				this.FloatCurveMap = floats;
			}
			if (vectors != null)
			{
				this.VectorCurveMap = vectors;
			}
			if (colors != null)
			{
				this.LinearColorCurveMap = colors;
			}
			if (floats != null || vectors != null || colors != null)
			{
				this.HasCurveParameters = true;
			}
		}
	}
}

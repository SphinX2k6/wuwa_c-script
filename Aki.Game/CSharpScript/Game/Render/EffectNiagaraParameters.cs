using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034F1 RID: 13553
	public class EffectNiagaraParameters : EffectParametersBase
	{
		// Token: 0x060227E1 RID: 141281 RVA: 0x009CA449 File Offset: 0x009C8649
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

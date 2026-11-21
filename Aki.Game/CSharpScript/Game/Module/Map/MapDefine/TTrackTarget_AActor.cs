using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004560 RID: 17760
	[NullableContext(1)]
	[Nullable(0)]
	public class TTrackTarget_AActor : TTrackTarget
	{
		// Token: 0x0602CBEC RID: 183276 RVA: 0x00C873FE File Offset: 0x00C855FE
		public TTrackTarget_AActor(AActor Value)
		{
		}

		// Token: 0x0602CBED RID: 183277 RVA: 0x00C8740D File Offset: 0x00C8560D
		public static implicit operator AActor(TTrackTarget_AActor target)
		{
			return target.Value;
		}

		// Token: 0x0602CBEE RID: 183278 RVA: 0x00C87415 File Offset: 0x00C85615
		public new static implicit operator TTrackTarget_AActor(AActor value)
		{
			return new TTrackTarget_AActor(value);
		}

		// Token: 0x04017FEB RID: 98283
		public AActor Value = Value;
	}
}

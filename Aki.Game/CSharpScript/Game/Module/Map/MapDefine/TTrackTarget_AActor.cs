using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200558A RID: 21898
	[NullableContext(1)]
	[Nullable(0)]
	public class TTrackTarget_AActor : TTrackTarget
	{
		// Token: 0x06037CEE RID: 228590 RVA: 0x00D39726 File Offset: 0x00D37926
		public TTrackTarget_AActor(AActor Value)
		{
		}

		// Token: 0x06037CEF RID: 228591 RVA: 0x00D39735 File Offset: 0x00D37935
		public static implicit operator AActor(TTrackTarget_AActor target)
		{
			return target.Value;
		}

		// Token: 0x06037CF0 RID: 228592 RVA: 0x00D3973D File Offset: 0x00D3793D
		public new static implicit operator TTrackTarget_AActor(AActor value)
		{
			return new TTrackTarget_AActor(value);
		}

		// Token: 0x0401D560 RID: 120160
		public AActor Value = Value;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034EE RID: 13550
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectConstParameter
	{
		// Token: 0x060227D4 RID: 141268 RVA: 0x009CA347 File Offset: 0x009C8547
		public EffectConstParameter(FName name, object value)
		{
			this.Name = name;
			this.Value = value;
		}

		// Token: 0x04013104 RID: 78084
		public FName Name;

		// Token: 0x04013105 RID: 78085
		public object Value;
	}
}

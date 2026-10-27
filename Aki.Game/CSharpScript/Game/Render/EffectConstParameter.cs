using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045C6 RID: 17862
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectConstParameter
	{
		// Token: 0x0602E0E9 RID: 188649 RVA: 0x00A9E07F File Offset: 0x00A9C27F
		public EffectConstParameter(FName name, object value)
		{
			this.Name = name;
			this.Value = value;
		}

		// Token: 0x04018AC9 RID: 101065
		public FName Name;

		// Token: 0x04018ACA RID: 101066
		public object Value;
	}
}

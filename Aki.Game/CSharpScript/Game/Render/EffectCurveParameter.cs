using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045C7 RID: 17863
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectCurveParameter
	{
		// Token: 0x0602E0EA RID: 188650 RVA: 0x00A9E095 File Offset: 0x00A9C295
		public EffectCurveParameter(FName name, object parameter)
		{
			this.Name = name;
			this.Value = parameter;
		}

		// Token: 0x04018ACB RID: 101067
		public FName Name;

		// Token: 0x04018ACC RID: 101068
		public object Value;
	}
}

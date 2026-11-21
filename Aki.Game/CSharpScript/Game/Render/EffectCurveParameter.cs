using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034EF RID: 13551
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectCurveParameter
	{
		// Token: 0x060227D5 RID: 141269 RVA: 0x009CA35D File Offset: 0x009C855D
		public EffectCurveParameter(FName name, object parameter)
		{
			this.Name = name;
			this.Value = parameter;
		}

		// Token: 0x04013106 RID: 78086
		public FName Name;

		// Token: 0x04013107 RID: 78087
		public object Value;
	}
}

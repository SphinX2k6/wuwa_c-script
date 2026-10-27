using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x02007256 RID: 29270
	[NullableContext(1)]
	public interface ISetFlowBoolOption
	{
		// Token: 0x17009E71 RID: 40561
		// (get) Token: 0x06047BC8 RID: 293832
		// (set) Token: 0x06047BC9 RID: 293833
		string Option { get; set; }

		// Token: 0x17009E72 RID: 40562
		// (get) Token: 0x06047BCA RID: 293834
		// (set) Token: 0x06047BCB RID: 293835
		bool Value { get; set; }
	}
}

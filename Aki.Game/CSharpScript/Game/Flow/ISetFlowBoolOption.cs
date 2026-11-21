using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063D5 RID: 25557
	[NullableContext(1)]
	public interface ISetFlowBoolOption
	{
		// Token: 0x170075C9 RID: 30153
		// (get) Token: 0x0603DF80 RID: 253824
		// (set) Token: 0x0603DF81 RID: 253825
		string Option { get; set; }

		// Token: 0x170075CA RID: 30154
		// (get) Token: 0x0603DF82 RID: 253826
		// (set) Token: 0x0603DF83 RID: 253827
		bool Value { get; set; }
	}
}

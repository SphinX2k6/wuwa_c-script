using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063D1 RID: 25553
	[NullableContext(2)]
	public interface IFinishState
	{
		// Token: 0x170075C4 RID: 30148
		// (get) Token: 0x0603DF74 RID: 253812
		// (set) Token: 0x0603DF75 RID: 253813
		[Nullable(1)]
		string Result { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170075C5 RID: 30149
		// (get) Token: 0x0603DF76 RID: 253814
		// (set) Token: 0x0603DF77 RID: 253815
		string Arg1 { get; set; }

		// Token: 0x170075C6 RID: 30150
		// (get) Token: 0x0603DF78 RID: 253816
		// (set) Token: 0x0603DF79 RID: 253817
		string Arg2 { get; set; }
	}
}

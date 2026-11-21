using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063C3 RID: 25539
	[NullableContext(1)]
	public interface IStateInfo
	{
		// Token: 0x170075A2 RID: 30114
		// (get) Token: 0x0603DF2E RID: 253742
		// (set) Token: 0x0603DF2F RID: 253743
		int Id { get; set; }

		// Token: 0x170075A3 RID: 30115
		// (get) Token: 0x0603DF30 RID: 253744
		// (set) Token: 0x0603DF31 RID: 253745
		string Name { get; set; }

		// Token: 0x170075A4 RID: 30116
		// (get) Token: 0x0603DF32 RID: 253746
		// (set) Token: 0x0603DF33 RID: 253747
		bool? _folded { get; set; }

		// Token: 0x170075A5 RID: 30117
		// (get) Token: 0x0603DF34 RID: 253748
		// (set) Token: 0x0603DF35 RID: 253749
		IActionInfo[] Actions { get; set; }
	}
}

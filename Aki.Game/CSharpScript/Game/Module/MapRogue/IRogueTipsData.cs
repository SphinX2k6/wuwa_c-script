using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055F5 RID: 22005
	[NullableContext(1)]
	public interface IRogueTipsData
	{
		// Token: 0x1700870E RID: 34574
		// (get) Token: 0x0603806E RID: 229486
		// (set) Token: 0x0603806F RID: 229487
		string TextId { get; set; }

		// Token: 0x1700870F RID: 34575
		// (get) Token: 0x06038070 RID: 229488
		// (set) Token: 0x06038071 RID: 229489
		string[] TextParam { get; set; }

		// Token: 0x17008710 RID: 34576
		// (get) Token: 0x06038072 RID: 229490
		// (set) Token: 0x06038073 RID: 229491
		[Nullable(2)]
		Action FinishCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}

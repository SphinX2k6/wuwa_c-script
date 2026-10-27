using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FF8 RID: 20472
	[NullableContext(1)]
	public interface IAbpStateConfig
	{
		// Token: 0x17007FD9 RID: 32729
		// (get) Token: 0x060345E6 RID: 214502
		// (set) Token: 0x060345E7 RID: 214503
		string Abp { get; set; }

		// Token: 0x17007FDA RID: 32730
		// (get) Token: 0x060345E8 RID: 214504
		// (set) Token: 0x060345E9 RID: 214505
		string State1 { get; set; }

		// Token: 0x17007FDB RID: 32731
		// (get) Token: 0x060345EA RID: 214506
		// (set) Token: 0x060345EB RID: 214507
		string State2 { get; set; }
	}
}

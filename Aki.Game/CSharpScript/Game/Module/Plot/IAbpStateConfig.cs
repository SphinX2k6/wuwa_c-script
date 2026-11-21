using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FC2 RID: 16322
	[NullableContext(1)]
	public interface IAbpStateConfig
	{
		// Token: 0x1700538E RID: 21390
		// (get) Token: 0x06029471 RID: 169073
		// (set) Token: 0x06029472 RID: 169074
		string Abp { get; set; }

		// Token: 0x1700538F RID: 21391
		// (get) Token: 0x06029473 RID: 169075
		// (set) Token: 0x06029474 RID: 169076
		string State1 { get; set; }

		// Token: 0x17005390 RID: 21392
		// (get) Token: 0x06029475 RID: 169077
		// (set) Token: 0x06029476 RID: 169078
		string State2 { get; set; }
	}
}

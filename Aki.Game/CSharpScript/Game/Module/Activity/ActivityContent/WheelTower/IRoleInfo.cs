using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F20 RID: 24352
	[NullableContext(1)]
	public interface IRoleInfo
	{
		// Token: 0x17008F00 RID: 36608
		// (get) Token: 0x0603DE1B RID: 253467
		// (set) Token: 0x0603DE1C RID: 253468
		int RoleId { get; set; }

		// Token: 0x17008F01 RID: 36609
		// (get) Token: 0x0603DE1D RID: 253469
		// (set) Token: 0x0603DE1E RID: 253470
		int Weapon { get; set; }

		// Token: 0x17008F02 RID: 36610
		// (get) Token: 0x0603DE1F RID: 253471
		// (set) Token: 0x0603DE20 RID: 253472
		List<int> Phantom { get; set; }
	}
}

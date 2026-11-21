using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F07 RID: 20231
	[NullableContext(1)]
	public interface IRoleInfo
	{
		// Token: 0x170062D2 RID: 25298
		// (get) Token: 0x06032DB6 RID: 208310
		// (set) Token: 0x06032DB7 RID: 208311
		int RoleId { get; set; }

		// Token: 0x170062D3 RID: 25299
		// (get) Token: 0x06032DB8 RID: 208312
		// (set) Token: 0x06032DB9 RID: 208313
		int Weapon { get; set; }

		// Token: 0x170062D4 RID: 25300
		// (get) Token: 0x06032DBA RID: 208314
		// (set) Token: 0x06032DBB RID: 208315
		List<int> Phantom { get; set; }
	}
}

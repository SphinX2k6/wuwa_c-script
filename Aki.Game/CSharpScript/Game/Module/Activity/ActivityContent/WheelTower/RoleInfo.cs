using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F21 RID: 24353
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleInfo : IRoleInfo
	{
		// Token: 0x17008F03 RID: 36611
		// (get) Token: 0x0603DE21 RID: 253473 RVA: 0x00EF54C7 File Offset: 0x00EF36C7
		// (set) Token: 0x0603DE22 RID: 253474 RVA: 0x00EF54CF File Offset: 0x00EF36CF
		public int RoleId { get; set; }

		// Token: 0x17008F04 RID: 36612
		// (get) Token: 0x0603DE23 RID: 253475 RVA: 0x00EF54D8 File Offset: 0x00EF36D8
		// (set) Token: 0x0603DE24 RID: 253476 RVA: 0x00EF54E0 File Offset: 0x00EF36E0
		public int Weapon { get; set; }

		// Token: 0x17008F05 RID: 36613
		// (get) Token: 0x0603DE25 RID: 253477 RVA: 0x00EF54E9 File Offset: 0x00EF36E9
		// (set) Token: 0x0603DE26 RID: 253478 RVA: 0x00EF54F1 File Offset: 0x00EF36F1
		public List<int> Phantom { get; set; } = new List<int>();
	}
}

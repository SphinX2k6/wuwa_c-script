using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F08 RID: 20232
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleInfo : IRoleInfo
	{
		// Token: 0x170062D5 RID: 25301
		// (get) Token: 0x06032DBC RID: 208316 RVA: 0x00E471F3 File Offset: 0x00E453F3
		// (set) Token: 0x06032DBD RID: 208317 RVA: 0x00E471FB File Offset: 0x00E453FB
		public int RoleId { get; set; }

		// Token: 0x170062D6 RID: 25302
		// (get) Token: 0x06032DBE RID: 208318 RVA: 0x00E47204 File Offset: 0x00E45404
		// (set) Token: 0x06032DBF RID: 208319 RVA: 0x00E4720C File Offset: 0x00E4540C
		public int Weapon { get; set; }

		// Token: 0x170062D7 RID: 25303
		// (get) Token: 0x06032DC0 RID: 208320 RVA: 0x00E47215 File Offset: 0x00E45415
		// (set) Token: 0x06032DC1 RID: 208321 RVA: 0x00E4721D File Offset: 0x00E4541D
		public List<int> Phantom { get; set; } = new List<int>();
	}
}

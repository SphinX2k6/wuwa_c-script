using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Effect
{
	// Token: 0x0200726D RID: 29293
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecData
	{
		// Token: 0x17009E8A RID: 40586
		// (get) Token: 0x06047C6D RID: 293997 RVA: 0x0125D149 File Offset: 0x0125B349
		// (set) Token: 0x06047C6E RID: 293998 RVA: 0x0125D151 File Offset: 0x0125B351
		public int Id { get; set; }

		// Token: 0x17009E8B RID: 40587
		// (get) Token: 0x06047C6F RID: 293999 RVA: 0x0125D15A File Offset: 0x0125B35A
		// (set) Token: 0x06047C70 RID: 294000 RVA: 0x0125D162 File Offset: 0x0125B362
		public string Path { get; set; }

		// Token: 0x17009E8C RID: 40588
		// (get) Token: 0x06047C71 RID: 294001 RVA: 0x0125D16B File Offset: 0x0125B36B
		// (set) Token: 0x06047C72 RID: 294002 RVA: 0x0125D173 File Offset: 0x0125B373
		public byte SpecType { get; set; }

		// Token: 0x17009E8D RID: 40589
		// (get) Token: 0x06047C73 RID: 294003 RVA: 0x0125D17C File Offset: 0x0125B37C
		// (set) Token: 0x06047C74 RID: 294004 RVA: 0x0125D184 File Offset: 0x0125B384
		public sbyte EffectRegularType { get; set; }

		// Token: 0x17009E8E RID: 40590
		// (get) Token: 0x06047C75 RID: 294005 RVA: 0x0125D18D File Offset: 0x0125B38D
		// (set) Token: 0x06047C76 RID: 294006 RVA: 0x0125D195 File Offset: 0x0125B395
		public float LifeTime { get; set; }

		// Token: 0x17009E8F RID: 40591
		// (get) Token: 0x06047C77 RID: 294007 RVA: 0x0125D19E File Offset: 0x0125B39E
		// (set) Token: 0x06047C78 RID: 294008 RVA: 0x0125D1A6 File Offset: 0x0125B3A6
		public List<int> Children { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x02005837 RID: 22583
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopUpGrateViewParams
	{
		// Token: 0x17006B1F RID: 27423
		// (get) Token: 0x06037B3D RID: 228157 RVA: 0x00F92F60 File Offset: 0x00F91160
		// (set) Token: 0x06037B3E RID: 228158 RVA: 0x00F92F68 File Offset: 0x00F91168
		public CoopActivityData ActivityData { get; set; }

		// Token: 0x17006B20 RID: 27424
		// (get) Token: 0x06037B3F RID: 228159 RVA: 0x00F92F71 File Offset: 0x00F91171
		// (set) Token: 0x06037B40 RID: 228160 RVA: 0x00F92F79 File Offset: 0x00F91179
		public int RoleId { get; set; }

		// Token: 0x17006B21 RID: 27425
		// (get) Token: 0x06037B41 RID: 228161 RVA: 0x00F92F82 File Offset: 0x00F91182
		// (set) Token: 0x06037B42 RID: 228162 RVA: 0x00F92F8A File Offset: 0x00F9118A
		public int PreLevel { get; set; }

		// Token: 0x17006B22 RID: 27426
		// (get) Token: 0x06037B43 RID: 228163 RVA: 0x00F92F93 File Offset: 0x00F91193
		// (set) Token: 0x06037B44 RID: 228164 RVA: 0x00F92F9B File Offset: 0x00F9119B
		public int NextLevel { get; set; }

		// Token: 0x17006B23 RID: 27427
		// (get) Token: 0x06037B45 RID: 228165 RVA: 0x00F92FA4 File Offset: 0x00F911A4
		// (set) Token: 0x06037B46 RID: 228166 RVA: 0x00F92FAC File Offset: 0x00F911AC
		public bool IsMaxLevel { get; set; }

		// Token: 0x17006B24 RID: 27428
		// (get) Token: 0x06037B47 RID: 228167 RVA: 0x00F92FB5 File Offset: 0x00F911B5
		// (set) Token: 0x06037B48 RID: 228168 RVA: 0x00F92FBD File Offset: 0x00F911BD
		public bool IsNew { get; set; }
	}
}

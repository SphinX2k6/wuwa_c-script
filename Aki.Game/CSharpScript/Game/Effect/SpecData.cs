using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Effect
{
	// Token: 0x020063EC RID: 25580
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecData
	{
		// Token: 0x170075E3 RID: 30179
		// (get) Token: 0x0603E02A RID: 253994 RVA: 0x011FDAD9 File Offset: 0x011FBCD9
		// (set) Token: 0x0603E02B RID: 253995 RVA: 0x011FDAE1 File Offset: 0x011FBCE1
		public int Id { get; set; }

		// Token: 0x170075E4 RID: 30180
		// (get) Token: 0x0603E02C RID: 253996 RVA: 0x011FDAEA File Offset: 0x011FBCEA
		// (set) Token: 0x0603E02D RID: 253997 RVA: 0x011FDAF2 File Offset: 0x011FBCF2
		public string Path { get; set; }

		// Token: 0x170075E5 RID: 30181
		// (get) Token: 0x0603E02E RID: 253998 RVA: 0x011FDAFB File Offset: 0x011FBCFB
		// (set) Token: 0x0603E02F RID: 253999 RVA: 0x011FDB03 File Offset: 0x011FBD03
		public byte SpecType { get; set; }

		// Token: 0x170075E6 RID: 30182
		// (get) Token: 0x0603E030 RID: 254000 RVA: 0x011FDB0C File Offset: 0x011FBD0C
		// (set) Token: 0x0603E031 RID: 254001 RVA: 0x011FDB14 File Offset: 0x011FBD14
		public sbyte EffectRegularType { get; set; }

		// Token: 0x170075E7 RID: 30183
		// (get) Token: 0x0603E032 RID: 254002 RVA: 0x011FDB1D File Offset: 0x011FBD1D
		// (set) Token: 0x0603E033 RID: 254003 RVA: 0x011FDB25 File Offset: 0x011FBD25
		public float LifeTime { get; set; }

		// Token: 0x170075E8 RID: 30184
		// (get) Token: 0x0603E034 RID: 254004 RVA: 0x011FDB2E File Offset: 0x011FBD2E
		// (set) Token: 0x0603E035 RID: 254005 RVA: 0x011FDB36 File Offset: 0x011FBD36
		public List<int> Children { get; set; }
	}
}

using System;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AD1 RID: 23249
	public class IFauxPhysicsFreeRotateParam : IFauxPhysicsRotateParam
	{
		// Token: 0x17006CFC RID: 27900
		// (get) Token: 0x0603937A RID: 234362 RVA: 0x010066CE File Offset: 0x010048CE
		// (set) Token: 0x0603937B RID: 234363 RVA: 0x010066D6 File Offset: 0x010048D6
		public EFauxPhysicsRotateParam Type { get; set; }

		// Token: 0x17006CFD RID: 27901
		// (get) Token: 0x0603937C RID: 234364 RVA: 0x010066DF File Offset: 0x010048DF
		// (set) Token: 0x0603937D RID: 234365 RVA: 0x010066E7 File Offset: 0x010048E7
		public FVector? Origin { get; set; }

		// Token: 0x17006CFE RID: 27902
		// (get) Token: 0x0603937E RID: 234366 RVA: 0x010066F0 File Offset: 0x010048F0
		// (set) Token: 0x0603937F RID: 234367 RVA: 0x010066F8 File Offset: 0x010048F8
		public FVector? RelativeOffset { get; set; }

		// Token: 0x17006CFF RID: 27903
		// (get) Token: 0x06039380 RID: 234368 RVA: 0x01006701 File Offset: 0x01004901
		// (set) Token: 0x06039381 RID: 234369 RVA: 0x01006709 File Offset: 0x01004909
		public FVector? Force { get; set; }

		// Token: 0x17006D00 RID: 27904
		// (get) Token: 0x06039382 RID: 234370 RVA: 0x01006712 File Offset: 0x01004912
		// (set) Token: 0x06039383 RID: 234371 RVA: 0x0100671A File Offset: 0x0100491A
		public FVector? Impulse { get; set; }

		// Token: 0x17006D01 RID: 27905
		// (get) Token: 0x06039384 RID: 234372 RVA: 0x01006723 File Offset: 0x01004923
		// (set) Token: 0x06039385 RID: 234373 RVA: 0x0100672B File Offset: 0x0100492B
		public FVector? Movement { get; set; }
	}
}

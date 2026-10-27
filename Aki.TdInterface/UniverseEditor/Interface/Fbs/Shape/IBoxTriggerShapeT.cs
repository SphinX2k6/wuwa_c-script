using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BF6 RID: 15350
	public class IBoxTriggerShapeT
	{
		// Token: 0x17006964 RID: 26980
		// (get) Token: 0x060151F7 RID: 86519 RVA: 0x0030F7E4 File Offset: 0x0030D9E4
		// (set) Token: 0x060151F8 RID: 86520 RVA: 0x0030F7EC File Offset: 0x0030D9EC
		public ETriggerShape Type { get; set; }

		// Token: 0x17006965 RID: 26981
		// (get) Token: 0x060151F9 RID: 86521 RVA: 0x0030F7F5 File Offset: 0x0030D9F5
		// (set) Token: 0x060151FA RID: 86522 RVA: 0x0030F7FD File Offset: 0x0030D9FD
		public IVectorInfoT Center { get; set; }

		// Token: 0x17006966 RID: 26982
		// (get) Token: 0x060151FB RID: 86523 RVA: 0x0030F806 File Offset: 0x0030DA06
		// (set) Token: 0x060151FC RID: 86524 RVA: 0x0030F80E File Offset: 0x0030DA0E
		public IVectorInfoT Size { get; set; }

		// Token: 0x17006967 RID: 26983
		// (get) Token: 0x060151FD RID: 86525 RVA: 0x0030F817 File Offset: 0x0030DA17
		// (set) Token: 0x060151FE RID: 86526 RVA: 0x0030F81F File Offset: 0x0030DA1F
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x060151FF RID: 86527 RVA: 0x0030F828 File Offset: 0x0030DA28
		public IBoxTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Size = null;
			this.Rotator = null;
		}
	}
}

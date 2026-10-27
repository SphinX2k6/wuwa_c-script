using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200585F RID: 22623
	public class IResetEntitiesPosComponentT
	{
		// Token: 0x1700A91D RID: 43293
		// (get) Token: 0x0602618A RID: 156042 RVA: 0x00540AA0 File Offset: 0x0053ECA0
		// (set) Token: 0x0602618B RID: 156043 RVA: 0x00540AA8 File Offset: 0x0053ECA8
		public bool Disabled { get; set; }

		// Token: 0x1700A91E RID: 43294
		// (get) Token: 0x0602618C RID: 156044 RVA: 0x00540AB1 File Offset: 0x0053ECB1
		// (set) Token: 0x0602618D RID: 156045 RVA: 0x00540AB9 File Offset: 0x0053ECB9
		public TTriggerShapeUnion Range { get; set; }

		// Token: 0x1700A91F RID: 43295
		// (get) Token: 0x0602618E RID: 156046 RVA: 0x00540AC2 File Offset: 0x0053ECC2
		// (set) Token: 0x0602618F RID: 156047 RVA: 0x00540ACA File Offset: 0x0053ECCA
		public List<int> EntityIds { get; set; }

		// Token: 0x1700A920 RID: 43296
		// (get) Token: 0x06026190 RID: 156048 RVA: 0x00540AD3 File Offset: 0x0053ECD3
		// (set) Token: 0x06026191 RID: 156049 RVA: 0x00540ADB File Offset: 0x0053ECDB
		public byte NullMask { get; set; }

		// Token: 0x06026192 RID: 156050 RVA: 0x00540AE4 File Offset: 0x0053ECE4
		public IResetEntitiesPosComponentT()
		{
			this.Disabled = false;
			this.Range = null;
			this.EntityIds = null;
			this.NullMask = 0;
		}
	}
}

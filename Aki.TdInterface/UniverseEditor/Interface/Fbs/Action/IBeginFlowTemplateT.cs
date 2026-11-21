using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200686F RID: 26735
	public class IBeginFlowTemplateT
	{
		// Token: 0x1700C485 RID: 50309
		// (get) Token: 0x0602DB40 RID: 187200 RVA: 0x00640098 File Offset: 0x0063E298
		// (set) Token: 0x0602DB41 RID: 187201 RVA: 0x006400A0 File Offset: 0x0063E2A0
		public bool _Folded { get; set; }

		// Token: 0x1700C486 RID: 50310
		// (get) Token: 0x0602DB42 RID: 187202 RVA: 0x006400A9 File Offset: 0x0063E2A9
		// (set) Token: 0x0602DB43 RID: 187203 RVA: 0x006400B1 File Offset: 0x0063E2B1
		public List<IFlowActorUnitT> Actors { get; set; }

		// Token: 0x1700C487 RID: 50311
		// (get) Token: 0x0602DB44 RID: 187204 RVA: 0x006400BA File Offset: 0x0063E2BA
		// (set) Token: 0x0602DB45 RID: 187205 RVA: 0x006400C2 File Offset: 0x0063E2C2
		public List<int> MontageIds { get; set; }

		// Token: 0x1700C488 RID: 50312
		// (get) Token: 0x0602DB46 RID: 187206 RVA: 0x006400CB File Offset: 0x0063E2CB
		// (set) Token: 0x0602DB47 RID: 187207 RVA: 0x006400D3 File Offset: 0x0063E2D3
		public bool UseFreeCamera { get; set; }

		// Token: 0x1700C489 RID: 50313
		// (get) Token: 0x0602DB48 RID: 187208 RVA: 0x006400DC File Offset: 0x0063E2DC
		// (set) Token: 0x0602DB49 RID: 187209 RVA: 0x006400E4 File Offset: 0x0063E2E4
		public bool IsSwitchMainRole { get; set; }

		// Token: 0x1700C48A RID: 50314
		// (get) Token: 0x0602DB4A RID: 187210 RVA: 0x006400ED File Offset: 0x0063E2ED
		// (set) Token: 0x0602DB4B RID: 187211 RVA: 0x006400F5 File Offset: 0x0063E2F5
		public bool IsUseSeqFace { get; set; }

		// Token: 0x1700C48B RID: 50315
		// (get) Token: 0x0602DB4C RID: 187212 RVA: 0x006400FE File Offset: 0x0063E2FE
		// (set) Token: 0x0602DB4D RID: 187213 RVA: 0x00640106 File Offset: 0x0063E306
		public byte NullMask { get; set; }

		// Token: 0x0602DB4E RID: 187214 RVA: 0x0064010F File Offset: 0x0063E30F
		public IBeginFlowTemplateT()
		{
			this._Folded = false;
			this.Actors = null;
			this.MontageIds = null;
			this.UseFreeCamera = false;
			this.IsSwitchMainRole = false;
			this.IsUseSeqFace = false;
			this.NullMask = 0;
		}
	}
}

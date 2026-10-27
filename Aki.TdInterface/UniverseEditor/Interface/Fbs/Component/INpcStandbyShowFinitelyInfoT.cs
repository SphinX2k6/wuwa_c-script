using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200565D RID: 22109
	public class INpcStandbyShowFinitelyInfoT
	{
		// Token: 0x1700A3C4 RID: 41924
		// (get) Token: 0x06024C31 RID: 150577 RVA: 0x00512874 File Offset: 0x00510A74
		// (set) Token: 0x06024C32 RID: 150578 RVA: 0x0051287C File Offset: 0x00510A7C
		public string Montage { get; set; }

		// Token: 0x1700A3C5 RID: 41925
		// (get) Token: 0x06024C33 RID: 150579 RVA: 0x00512885 File Offset: 0x00510A85
		// (set) Token: 0x06024C34 RID: 150580 RVA: 0x0051288D File Offset: 0x00510A8D
		public IMontageIdT RegisteredMontageId { get; set; }

		// Token: 0x1700A3C6 RID: 41926
		// (get) Token: 0x06024C35 RID: 150581 RVA: 0x00512896 File Offset: 0x00510A96
		// (set) Token: 0x06024C36 RID: 150582 RVA: 0x0051289E File Offset: 0x00510A9E
		public int FaceExpressionId { get; set; }

		// Token: 0x1700A3C7 RID: 41927
		// (get) Token: 0x06024C37 RID: 150583 RVA: 0x005128A7 File Offset: 0x00510AA7
		// (set) Token: 0x06024C38 RID: 150584 RVA: 0x005128AF File Offset: 0x00510AAF
		public int Time { get; set; }

		// Token: 0x1700A3C8 RID: 41928
		// (get) Token: 0x06024C39 RID: 150585 RVA: 0x005128B8 File Offset: 0x00510AB8
		// (set) Token: 0x06024C3A RID: 150586 RVA: 0x005128C0 File Offset: 0x00510AC0
		public IIgnoreEntityIdsCollisionT IgnoreEntityCollision { get; set; }

		// Token: 0x1700A3C9 RID: 41929
		// (get) Token: 0x06024C3B RID: 150587 RVA: 0x005128C9 File Offset: 0x00510AC9
		// (set) Token: 0x06024C3C RID: 150588 RVA: 0x005128D1 File Offset: 0x00510AD1
		public byte NullMask { get; set; }

		// Token: 0x06024C3D RID: 150589 RVA: 0x005128DA File Offset: 0x00510ADA
		public INpcStandbyShowFinitelyInfoT()
		{
			this.Montage = null;
			this.RegisteredMontageId = null;
			this.FaceExpressionId = 0;
			this.Time = 0;
			this.IgnoreEntityCollision = null;
			this.NullMask = 0;
		}
	}
}

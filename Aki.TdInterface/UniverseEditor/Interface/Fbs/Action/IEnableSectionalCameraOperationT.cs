using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF9 RID: 27897
	public class IEnableSectionalCameraOperationT
	{
		// Token: 0x1700CC99 RID: 52377
		// (get) Token: 0x06030184 RID: 196996 RVA: 0x0068AC38 File Offset: 0x00688E38
		// (set) Token: 0x06030185 RID: 196997 RVA: 0x0068AC40 File Offset: 0x00688E40
		public ECameraOperationType Type { get; set; }

		// Token: 0x1700CC9A RID: 52378
		// (get) Token: 0x06030186 RID: 196998 RVA: 0x0068AC49 File Offset: 0x00688E49
		// (set) Token: 0x06030187 RID: 196999 RVA: 0x0068AC51 File Offset: 0x00688E51
		public bool EnableRotate { get; set; }

		// Token: 0x1700CC9B RID: 52379
		// (get) Token: 0x06030188 RID: 197000 RVA: 0x0068AC5A File Offset: 0x00688E5A
		// (set) Token: 0x06030189 RID: 197001 RVA: 0x0068AC62 File Offset: 0x00688E62
		public bool EnableZoom { get; set; }

		// Token: 0x1700CC9C RID: 52380
		// (get) Token: 0x0603018A RID: 197002 RVA: 0x0068AC6B File Offset: 0x00688E6B
		// (set) Token: 0x0603018B RID: 197003 RVA: 0x0068AC73 File Offset: 0x00688E73
		public byte NullMask { get; set; }

		// Token: 0x0603018C RID: 197004 RVA: 0x0068AC7C File Offset: 0x00688E7C
		public IEnableSectionalCameraOperationT()
		{
			this.Type = ECameraOperationType.Enable;
			this.EnableRotate = false;
			this.EnableZoom = false;
			this.NullMask = 0;
		}
	}
}

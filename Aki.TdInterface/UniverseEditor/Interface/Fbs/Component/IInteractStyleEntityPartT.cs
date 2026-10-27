using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200547D RID: 21629
	public class IInteractStyleEntityPartT
	{
		// Token: 0x17009F30 RID: 40752
		// (get) Token: 0x0602394D RID: 145741 RVA: 0x004EB973 File Offset: 0x004E9B73
		// (set) Token: 0x0602394E RID: 145742 RVA: 0x004EB97B File Offset: 0x004E9B7B
		public EInteractStyleType Type { get; set; }

		// Token: 0x17009F31 RID: 40753
		// (get) Token: 0x0602394F RID: 145743 RVA: 0x004EB984 File Offset: 0x004E9B84
		// (set) Token: 0x06023950 RID: 145744 RVA: 0x004EB98C File Offset: 0x004E9B8C
		public TInteractEntityPartBindUnion Bind { get; set; }

		// Token: 0x17009F32 RID: 40754
		// (get) Token: 0x06023951 RID: 145745 RVA: 0x004EB995 File Offset: 0x004E9B95
		// (set) Token: 0x06023952 RID: 145746 RVA: 0x004EB99D File Offset: 0x004E9B9D
		public float ShowAngle { get; set; }

		// Token: 0x17009F33 RID: 40755
		// (get) Token: 0x06023953 RID: 145747 RVA: 0x004EB9A6 File Offset: 0x004E9BA6
		// (set) Token: 0x06023954 RID: 145748 RVA: 0x004EB9AE File Offset: 0x004E9BAE
		public float TriggerAngle { get; set; }

		// Token: 0x06023955 RID: 145749 RVA: 0x004EB9B7 File Offset: 0x004E9BB7
		public IInteractStyleEntityPartT()
		{
			this.Type = EInteractStyleType.Panorama;
			this.Bind = null;
			this.ShowAngle = 0f;
			this.TriggerAngle = 0f;
		}
	}
}

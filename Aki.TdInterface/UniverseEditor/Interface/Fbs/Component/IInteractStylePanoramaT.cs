using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A06 RID: 23046
	public class IInteractStylePanoramaT
	{
		// Token: 0x1700A775 RID: 42869
		// (get) Token: 0x06025A27 RID: 154151 RVA: 0x00528E6B File Offset: 0x0052706B
		// (set) Token: 0x06025A28 RID: 154152 RVA: 0x00528E73 File Offset: 0x00527073
		public EInteractStyleType Type { get; set; }

		// Token: 0x1700A776 RID: 42870
		// (get) Token: 0x06025A29 RID: 154153 RVA: 0x00528E7C File Offset: 0x0052707C
		// (set) Token: 0x06025A2A RID: 154154 RVA: 0x00528E84 File Offset: 0x00527084
		public IVectorInfoT TargetPos { get; set; }

		// Token: 0x1700A777 RID: 42871
		// (get) Token: 0x06025A2B RID: 154155 RVA: 0x00528E8D File Offset: 0x0052708D
		// (set) Token: 0x06025A2C RID: 154156 RVA: 0x00528E95 File Offset: 0x00527095
		public int TriggerRange { get; set; }

		// Token: 0x1700A778 RID: 42872
		// (get) Token: 0x06025A2D RID: 154157 RVA: 0x00528E9E File Offset: 0x0052709E
		// (set) Token: 0x06025A2E RID: 154158 RVA: 0x00528EA6 File Offset: 0x005270A6
		public int TriggerAngle { get; set; }

		// Token: 0x1700A779 RID: 42873
		// (get) Token: 0x06025A2F RID: 154159 RVA: 0x00528EAF File Offset: 0x005270AF
		// (set) Token: 0x06025A30 RID: 154160 RVA: 0x00528EB7 File Offset: 0x005270B7
		public int ProtectRange { get; set; }

		// Token: 0x1700A77A RID: 42874
		// (get) Token: 0x06025A31 RID: 154161 RVA: 0x00528EC0 File Offset: 0x005270C0
		// (set) Token: 0x06025A32 RID: 154162 RVA: 0x00528EC8 File Offset: 0x005270C8
		public byte NullMask { get; set; }

		// Token: 0x06025A33 RID: 154163 RVA: 0x00528ED1 File Offset: 0x005270D1
		public IInteractStylePanoramaT()
		{
			this.Type = EInteractStyleType.Panorama;
			this.TargetPos = null;
			this.TriggerRange = 0;
			this.TriggerAngle = 0;
			this.ProtectRange = 0;
			this.NullMask = 0;
		}
	}
}

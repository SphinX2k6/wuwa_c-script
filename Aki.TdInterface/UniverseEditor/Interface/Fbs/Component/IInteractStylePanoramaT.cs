using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005480 RID: 21632
	public class IInteractStylePanoramaT
	{
		// Token: 0x17009F3B RID: 40763
		// (get) Token: 0x0602396F RID: 145775 RVA: 0x004EBDF7 File Offset: 0x004E9FF7
		// (set) Token: 0x06023970 RID: 145776 RVA: 0x004EBDFF File Offset: 0x004E9FFF
		public EInteractStyleType Type { get; set; }

		// Token: 0x17009F3C RID: 40764
		// (get) Token: 0x06023971 RID: 145777 RVA: 0x004EBE08 File Offset: 0x004EA008
		// (set) Token: 0x06023972 RID: 145778 RVA: 0x004EBE10 File Offset: 0x004EA010
		public IVectorInfoT TargetPos { get; set; }

		// Token: 0x17009F3D RID: 40765
		// (get) Token: 0x06023973 RID: 145779 RVA: 0x004EBE19 File Offset: 0x004EA019
		// (set) Token: 0x06023974 RID: 145780 RVA: 0x004EBE21 File Offset: 0x004EA021
		public int TriggerRange { get; set; }

		// Token: 0x17009F3E RID: 40766
		// (get) Token: 0x06023975 RID: 145781 RVA: 0x004EBE2A File Offset: 0x004EA02A
		// (set) Token: 0x06023976 RID: 145782 RVA: 0x004EBE32 File Offset: 0x004EA032
		public int TriggerAngle { get; set; }

		// Token: 0x17009F3F RID: 40767
		// (get) Token: 0x06023977 RID: 145783 RVA: 0x004EBE3B File Offset: 0x004EA03B
		// (set) Token: 0x06023978 RID: 145784 RVA: 0x004EBE43 File Offset: 0x004EA043
		public int ProtectRange { get; set; }

		// Token: 0x17009F40 RID: 40768
		// (get) Token: 0x06023979 RID: 145785 RVA: 0x004EBE4C File Offset: 0x004EA04C
		// (set) Token: 0x0602397A RID: 145786 RVA: 0x004EBE54 File Offset: 0x004EA054
		public byte NullMask { get; set; }

		// Token: 0x0602397B RID: 145787 RVA: 0x004EBE5D File Offset: 0x004EA05D
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

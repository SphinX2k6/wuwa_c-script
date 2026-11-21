using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200690B RID: 26891
	public class ICameraParamsT
	{
		// Token: 0x1700C5EC RID: 50668
		// (get) Token: 0x0602E122 RID: 188706 RVA: 0x0064BD36 File Offset: 0x00649F36
		// (set) Token: 0x0602E123 RID: 188707 RVA: 0x0064BD3E File Offset: 0x00649F3E
		public float Aperture { get; set; }

		// Token: 0x1700C5ED RID: 50669
		// (get) Token: 0x0602E124 RID: 188708 RVA: 0x0064BD47 File Offset: 0x00649F47
		// (set) Token: 0x0602E125 RID: 188709 RVA: 0x0064BD4F File Offset: 0x00649F4F
		public float FocalLength { get; set; }

		// Token: 0x1700C5EE RID: 50670
		// (get) Token: 0x0602E126 RID: 188710 RVA: 0x0064BD58 File Offset: 0x00649F58
		// (set) Token: 0x0602E127 RID: 188711 RVA: 0x0064BD60 File Offset: 0x00649F60
		public float FocusDistance { get; set; }

		// Token: 0x1700C5EF RID: 50671
		// (get) Token: 0x0602E128 RID: 188712 RVA: 0x0064BD69 File Offset: 0x00649F69
		// (set) Token: 0x0602E129 RID: 188713 RVA: 0x0064BD71 File Offset: 0x00649F71
		public float FocalRegion { get; set; }

		// Token: 0x1700C5F0 RID: 50672
		// (get) Token: 0x0602E12A RID: 188714 RVA: 0x0064BD7A File Offset: 0x00649F7A
		// (set) Token: 0x0602E12B RID: 188715 RVA: 0x0064BD82 File Offset: 0x00649F82
		public float Fov { get; set; }

		// Token: 0x1700C5F1 RID: 50673
		// (get) Token: 0x0602E12C RID: 188716 RVA: 0x0064BD8B File Offset: 0x00649F8B
		// (set) Token: 0x0602E12D RID: 188717 RVA: 0x0064BD93 File Offset: 0x00649F93
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700C5F2 RID: 50674
		// (get) Token: 0x0602E12E RID: 188718 RVA: 0x0064BD9C File Offset: 0x00649F9C
		// (set) Token: 0x0602E12F RID: 188719 RVA: 0x0064BDA4 File Offset: 0x00649FA4
		public IVectorInfoT Rot { get; set; }

		// Token: 0x1700C5F3 RID: 50675
		// (get) Token: 0x0602E130 RID: 188720 RVA: 0x0064BDAD File Offset: 0x00649FAD
		// (set) Token: 0x0602E131 RID: 188721 RVA: 0x0064BDB5 File Offset: 0x00649FB5
		public byte NullMask { get; set; }

		// Token: 0x0602E132 RID: 188722 RVA: 0x0064BDC0 File Offset: 0x00649FC0
		public ICameraParamsT()
		{
			this.Aperture = 0f;
			this.FocalLength = 0f;
			this.FocusDistance = 0f;
			this.FocalRegion = 0f;
			this.Fov = 0f;
			this.Pos = null;
			this.Rot = null;
			this.NullMask = 0;
		}
	}
}

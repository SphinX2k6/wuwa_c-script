using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B96 RID: 19350
	public class ICameraParamT
	{
		// Token: 0x170088E0 RID: 35040
		// (get) Token: 0x0601D7E8 RID: 120808 RVA: 0x004242D2 File Offset: 0x004224D2
		// (set) Token: 0x0601D7E9 RID: 120809 RVA: 0x004242DA File Offset: 0x004224DA
		public int CameraId { get; set; }

		// Token: 0x170088E1 RID: 35041
		// (get) Token: 0x0601D7EA RID: 120810 RVA: 0x004242E3 File Offset: 0x004224E3
		// (set) Token: 0x0601D7EB RID: 120811 RVA: 0x004242EB File Offset: 0x004224EB
		public string Name { get; set; }

		// Token: 0x170088E2 RID: 35042
		// (get) Token: 0x0601D7EC RID: 120812 RVA: 0x004242F4 File Offset: 0x004224F4
		// (set) Token: 0x0601D7ED RID: 120813 RVA: 0x004242FC File Offset: 0x004224FC
		public IVectorInfoT Pos { get; set; }

		// Token: 0x170088E3 RID: 35043
		// (get) Token: 0x0601D7EE RID: 120814 RVA: 0x00424305 File Offset: 0x00422505
		// (set) Token: 0x0601D7EF RID: 120815 RVA: 0x0042430D File Offset: 0x0042250D
		public IVectorInfoT Rot { get; set; }

		// Token: 0x170088E4 RID: 35044
		// (get) Token: 0x0601D7F0 RID: 120816 RVA: 0x00424316 File Offset: 0x00422516
		// (set) Token: 0x0601D7F1 RID: 120817 RVA: 0x0042431E File Offset: 0x0042251E
		public int Fov { get; set; }

		// Token: 0x170088E5 RID: 35045
		// (get) Token: 0x0601D7F2 RID: 120818 RVA: 0x00424327 File Offset: 0x00422527
		// (set) Token: 0x0601D7F3 RID: 120819 RVA: 0x0042432F File Offset: 0x0042252F
		public int Aperture { get; set; }

		// Token: 0x170088E6 RID: 35046
		// (get) Token: 0x0601D7F4 RID: 120820 RVA: 0x00424338 File Offset: 0x00422538
		// (set) Token: 0x0601D7F5 RID: 120821 RVA: 0x00424340 File Offset: 0x00422540
		public int FocalLength { get; set; }

		// Token: 0x170088E7 RID: 35047
		// (get) Token: 0x0601D7F6 RID: 120822 RVA: 0x00424349 File Offset: 0x00422549
		// (set) Token: 0x0601D7F7 RID: 120823 RVA: 0x00424351 File Offset: 0x00422551
		public int FocusDistance { get; set; }

		// Token: 0x170088E8 RID: 35048
		// (get) Token: 0x0601D7F8 RID: 120824 RVA: 0x0042435A File Offset: 0x0042255A
		// (set) Token: 0x0601D7F9 RID: 120825 RVA: 0x00424362 File Offset: 0x00422562
		public byte NullMask { get; set; }

		// Token: 0x0601D7FA RID: 120826 RVA: 0x0042436C File Offset: 0x0042256C
		public ICameraParamT()
		{
			this.CameraId = 0;
			this.Name = null;
			this.Pos = null;
			this.Rot = null;
			this.Fov = 0;
			this.Aperture = 0;
			this.FocalLength = 0;
			this.FocusDistance = 0;
			this.NullMask = 0;
		}
	}
}

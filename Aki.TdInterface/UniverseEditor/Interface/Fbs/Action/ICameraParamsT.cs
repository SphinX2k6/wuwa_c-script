using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200629A RID: 25242
	public class ICameraParamsT
	{
		// Token: 0x1700BC64 RID: 48228
		// (get) Token: 0x0602B9C1 RID: 178625 RVA: 0x00600F2E File Offset: 0x005FF12E
		// (set) Token: 0x0602B9C2 RID: 178626 RVA: 0x00600F36 File Offset: 0x005FF136
		public float Aperture { get; set; }

		// Token: 0x1700BC65 RID: 48229
		// (get) Token: 0x0602B9C3 RID: 178627 RVA: 0x00600F3F File Offset: 0x005FF13F
		// (set) Token: 0x0602B9C4 RID: 178628 RVA: 0x00600F47 File Offset: 0x005FF147
		public float FocalLength { get; set; }

		// Token: 0x1700BC66 RID: 48230
		// (get) Token: 0x0602B9C5 RID: 178629 RVA: 0x00600F50 File Offset: 0x005FF150
		// (set) Token: 0x0602B9C6 RID: 178630 RVA: 0x00600F58 File Offset: 0x005FF158
		public float FocusDistance { get; set; }

		// Token: 0x1700BC67 RID: 48231
		// (get) Token: 0x0602B9C7 RID: 178631 RVA: 0x00600F61 File Offset: 0x005FF161
		// (set) Token: 0x0602B9C8 RID: 178632 RVA: 0x00600F69 File Offset: 0x005FF169
		public float FocalRegion { get; set; }

		// Token: 0x1700BC68 RID: 48232
		// (get) Token: 0x0602B9C9 RID: 178633 RVA: 0x00600F72 File Offset: 0x005FF172
		// (set) Token: 0x0602B9CA RID: 178634 RVA: 0x00600F7A File Offset: 0x005FF17A
		public float Fov { get; set; }

		// Token: 0x1700BC69 RID: 48233
		// (get) Token: 0x0602B9CB RID: 178635 RVA: 0x00600F83 File Offset: 0x005FF183
		// (set) Token: 0x0602B9CC RID: 178636 RVA: 0x00600F8B File Offset: 0x005FF18B
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700BC6A RID: 48234
		// (get) Token: 0x0602B9CD RID: 178637 RVA: 0x00600F94 File Offset: 0x005FF194
		// (set) Token: 0x0602B9CE RID: 178638 RVA: 0x00600F9C File Offset: 0x005FF19C
		public IVectorInfoT Rot { get; set; }

		// Token: 0x1700BC6B RID: 48235
		// (get) Token: 0x0602B9CF RID: 178639 RVA: 0x00600FA5 File Offset: 0x005FF1A5
		// (set) Token: 0x0602B9D0 RID: 178640 RVA: 0x00600FAD File Offset: 0x005FF1AD
		public byte NullMask { get; set; }

		// Token: 0x0602B9D1 RID: 178641 RVA: 0x00600FB8 File Offset: 0x005FF1B8
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

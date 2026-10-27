using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200472E RID: 18222
	public class ICameraParamT
	{
		// Token: 0x1700829F RID: 33439
		// (get) Token: 0x0601C013 RID: 114707 RVA: 0x003F8036 File Offset: 0x003F6236
		// (set) Token: 0x0601C014 RID: 114708 RVA: 0x003F803E File Offset: 0x003F623E
		public int CameraId { get; set; }

		// Token: 0x170082A0 RID: 33440
		// (get) Token: 0x0601C015 RID: 114709 RVA: 0x003F8047 File Offset: 0x003F6247
		// (set) Token: 0x0601C016 RID: 114710 RVA: 0x003F804F File Offset: 0x003F624F
		public string Name { get; set; }

		// Token: 0x170082A1 RID: 33441
		// (get) Token: 0x0601C017 RID: 114711 RVA: 0x003F8058 File Offset: 0x003F6258
		// (set) Token: 0x0601C018 RID: 114712 RVA: 0x003F8060 File Offset: 0x003F6260
		public IVectorInfoT Pos { get; set; }

		// Token: 0x170082A2 RID: 33442
		// (get) Token: 0x0601C019 RID: 114713 RVA: 0x003F8069 File Offset: 0x003F6269
		// (set) Token: 0x0601C01A RID: 114714 RVA: 0x003F8071 File Offset: 0x003F6271
		public IVectorInfoT Rot { get; set; }

		// Token: 0x170082A3 RID: 33443
		// (get) Token: 0x0601C01B RID: 114715 RVA: 0x003F807A File Offset: 0x003F627A
		// (set) Token: 0x0601C01C RID: 114716 RVA: 0x003F8082 File Offset: 0x003F6282
		public int Fov { get; set; }

		// Token: 0x170082A4 RID: 33444
		// (get) Token: 0x0601C01D RID: 114717 RVA: 0x003F808B File Offset: 0x003F628B
		// (set) Token: 0x0601C01E RID: 114718 RVA: 0x003F8093 File Offset: 0x003F6293
		public int Aperture { get; set; }

		// Token: 0x170082A5 RID: 33445
		// (get) Token: 0x0601C01F RID: 114719 RVA: 0x003F809C File Offset: 0x003F629C
		// (set) Token: 0x0601C020 RID: 114720 RVA: 0x003F80A4 File Offset: 0x003F62A4
		public int FocalLength { get; set; }

		// Token: 0x170082A6 RID: 33446
		// (get) Token: 0x0601C021 RID: 114721 RVA: 0x003F80AD File Offset: 0x003F62AD
		// (set) Token: 0x0601C022 RID: 114722 RVA: 0x003F80B5 File Offset: 0x003F62B5
		public int FocusDistance { get; set; }

		// Token: 0x170082A7 RID: 33447
		// (get) Token: 0x0601C023 RID: 114723 RVA: 0x003F80BE File Offset: 0x003F62BE
		// (set) Token: 0x0601C024 RID: 114724 RVA: 0x003F80C6 File Offset: 0x003F62C6
		public byte NullMask { get; set; }

		// Token: 0x0601C025 RID: 114725 RVA: 0x003F80D0 File Offset: 0x003F62D0
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

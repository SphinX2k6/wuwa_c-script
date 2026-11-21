using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EBE RID: 28350
	public class IFocusObjectT
	{
		// Token: 0x1700CFF7 RID: 53239
		// (get) Token: 0x060310D1 RID: 200913 RVA: 0x006A6F17 File Offset: 0x006A5117
		// (set) Token: 0x060310D2 RID: 200914 RVA: 0x006A6F1F File Offset: 0x006A511F
		public IFocusObjectRotationConfigT RotationConfig { get; set; }

		// Token: 0x1700CFF8 RID: 53240
		// (get) Token: 0x060310D3 RID: 200915 RVA: 0x006A6F28 File Offset: 0x006A5128
		// (set) Token: 0x060310D4 RID: 200916 RVA: 0x006A6F30 File Offset: 0x006A5130
		public IFocusObjectCameraConfigT CameraConfig { get; set; }

		// Token: 0x1700CFF9 RID: 53241
		// (get) Token: 0x060310D5 RID: 200917 RVA: 0x006A6F39 File Offset: 0x006A5139
		// (set) Token: 0x060310D6 RID: 200918 RVA: 0x006A6F41 File Offset: 0x006A5141
		public int LeaveIndex { get; set; }

		// Token: 0x1700CFFA RID: 53242
		// (get) Token: 0x060310D7 RID: 200919 RVA: 0x006A6F4A File Offset: 0x006A514A
		// (set) Token: 0x060310D8 RID: 200920 RVA: 0x006A6F52 File Offset: 0x006A5152
		public byte NullMask { get; set; }

		// Token: 0x060310D9 RID: 200921 RVA: 0x006A6F5B File Offset: 0x006A515B
		public IFocusObjectT()
		{
			this.RotationConfig = null;
			this.CameraConfig = null;
			this.LeaveIndex = 0;
			this.NullMask = 0;
		}
	}
}

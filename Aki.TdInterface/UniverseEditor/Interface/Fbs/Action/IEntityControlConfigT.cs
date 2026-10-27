using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D9 RID: 26329
	public class IEntityControlConfigT
	{
		// Token: 0x1700C398 RID: 50072
		// (get) Token: 0x0602DC57 RID: 187479 RVA: 0x006429E0 File Offset: 0x00640BE0
		// (set) Token: 0x0602DC58 RID: 187480 RVA: 0x006429E8 File Offset: 0x00640BE8
		public bool IsControlPlayer { get; set; }

		// Token: 0x1700C399 RID: 50073
		// (get) Token: 0x0602DC59 RID: 187481 RVA: 0x006429F1 File Offset: 0x00640BF1
		// (set) Token: 0x0602DC5A RID: 187482 RVA: 0x006429F9 File Offset: 0x00640BF9
		public bool HideSkipButton { get; set; }

		// Token: 0x1700C39A RID: 50074
		// (get) Token: 0x0602DC5B RID: 187483 RVA: 0x00642A02 File Offset: 0x00640C02
		// (set) Token: 0x0602DC5C RID: 187484 RVA: 0x00642A0A File Offset: 0x00640C0A
		public EEntityControlCameraMode CameraMode { get; set; }

		// Token: 0x1700C39B RID: 50075
		// (get) Token: 0x0602DC5D RID: 187485 RVA: 0x00642A13 File Offset: 0x00640C13
		// (set) Token: 0x0602DC5E RID: 187486 RVA: 0x00642A1B File Offset: 0x00640C1B
		public byte NullMask { get; set; }

		// Token: 0x0602DC5F RID: 187487 RVA: 0x00642A24 File Offset: 0x00640C24
		public IEntityControlConfigT()
		{
			this.IsControlPlayer = false;
			this.HideSkipButton = false;
			this.CameraMode = EEntityControlCameraMode.UseSequenceCamera;
			this.NullMask = 0;
		}
	}
}

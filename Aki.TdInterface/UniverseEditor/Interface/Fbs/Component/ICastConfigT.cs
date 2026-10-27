using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F59 RID: 20313
	public class ICastConfigT
	{
		// Token: 0x170092A0 RID: 37536
		// (get) Token: 0x0602034F RID: 131919 RVA: 0x0047B405 File Offset: 0x00479605
		// (set) Token: 0x06020350 RID: 131920 RVA: 0x0047B40D File Offset: 0x0047960D
		public int CastAngularVelocity { get; set; }

		// Token: 0x170092A1 RID: 37537
		// (get) Token: 0x06020351 RID: 131921 RVA: 0x0047B416 File Offset: 0x00479616
		// (set) Token: 0x06020352 RID: 131922 RVA: 0x0047B41E File Offset: 0x0047961E
		public string CastCameraShake { get; set; }

		// Token: 0x170092A2 RID: 37538
		// (get) Token: 0x06020353 RID: 131923 RVA: 0x0047B427 File Offset: 0x00479627
		// (set) Token: 0x06020354 RID: 131924 RVA: 0x0047B42F File Offset: 0x0047962F
		public int CastVelocity { get; set; }

		// Token: 0x06020355 RID: 131925 RVA: 0x0047B438 File Offset: 0x00479638
		public ICastConfigT()
		{
			this.CastAngularVelocity = 0;
			this.CastCameraShake = null;
			this.CastVelocity = 0;
		}
	}
}

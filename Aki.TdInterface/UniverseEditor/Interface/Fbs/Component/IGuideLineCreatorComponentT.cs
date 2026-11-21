using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E0 RID: 22752
	public class IGuideLineCreatorComponentT
	{
		// Token: 0x1700A4FF RID: 42239
		// (get) Token: 0x06024F3C RID: 151356 RVA: 0x00512C09 File Offset: 0x00510E09
		// (set) Token: 0x06024F3D RID: 151357 RVA: 0x00512C11 File Offset: 0x00510E11
		public bool Disabled { get; set; }

		// Token: 0x1700A500 RID: 42240
		// (get) Token: 0x06024F3E RID: 151358 RVA: 0x00512C1A File Offset: 0x00510E1A
		// (set) Token: 0x06024F3F RID: 151359 RVA: 0x00512C22 File Offset: 0x00510E22
		public IColorChangeStrategyOfRGBT ColorChangeOption { get; set; }

		// Token: 0x1700A501 RID: 42241
		// (get) Token: 0x06024F40 RID: 151360 RVA: 0x00512C2B File Offset: 0x00510E2B
		// (set) Token: 0x06024F41 RID: 151361 RVA: 0x00512C33 File Offset: 0x00510E33
		public int SplineEntityId { get; set; }

		// Token: 0x1700A502 RID: 42242
		// (get) Token: 0x06024F42 RID: 151362 RVA: 0x00512C3C File Offset: 0x00510E3C
		// (set) Token: 0x06024F43 RID: 151363 RVA: 0x00512C44 File Offset: 0x00510E44
		public IGuideLineCreatorScanOptionT ScanOption { get; set; }

		// Token: 0x1700A503 RID: 42243
		// (get) Token: 0x06024F44 RID: 151364 RVA: 0x00512C4D File Offset: 0x00510E4D
		// (set) Token: 0x06024F45 RID: 151365 RVA: 0x00512C55 File Offset: 0x00510E55
		public byte NullMask { get; set; }

		// Token: 0x06024F46 RID: 151366 RVA: 0x00512C5E File Offset: 0x00510E5E
		public IGuideLineCreatorComponentT()
		{
			this.Disabled = false;
			this.ColorChangeOption = null;
			this.SplineEntityId = 0;
			this.ScanOption = null;
			this.NullMask = 0;
		}
	}
}

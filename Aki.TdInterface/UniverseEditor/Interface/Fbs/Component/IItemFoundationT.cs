using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A18 RID: 23064
	public class IItemFoundationT
	{
		// Token: 0x1700A7A4 RID: 42916
		// (get) Token: 0x06025ACC RID: 154316 RVA: 0x0052A3C1 File Offset: 0x005285C1
		// (set) Token: 0x06025ACD RID: 154317 RVA: 0x0052A3C9 File Offset: 0x005285C9
		public bool Disabled { get; set; }

		// Token: 0x1700A7A5 RID: 42917
		// (get) Token: 0x06025ACE RID: 154318 RVA: 0x0052A3D2 File Offset: 0x005285D2
		// (set) Token: 0x06025ACF RID: 154319 RVA: 0x0052A3DA File Offset: 0x005285DA
		public IAdsortTransformT AdsorptionPoint { get; set; }

		// Token: 0x1700A7A6 RID: 42918
		// (get) Token: 0x06025AD0 RID: 154320 RVA: 0x0052A3E3 File Offset: 0x005285E3
		// (set) Token: 0x06025AD1 RID: 154321 RVA: 0x0052A3EB File Offset: 0x005285EB
		public IEntityMatchT AdsorptionMatch { get; set; }

		// Token: 0x1700A7A7 RID: 42919
		// (get) Token: 0x06025AD2 RID: 154322 RVA: 0x0052A3F4 File Offset: 0x005285F4
		// (set) Token: 0x06025AD3 RID: 154323 RVA: 0x0052A3FC File Offset: 0x005285FC
		public IEntityMatchT ActiveMatch { get; set; }

		// Token: 0x1700A7A8 RID: 42920
		// (get) Token: 0x06025AD4 RID: 154324 RVA: 0x0052A405 File Offset: 0x00528605
		// (set) Token: 0x06025AD5 RID: 154325 RVA: 0x0052A40D File Offset: 0x0052860D
		public bool IsSilent { get; set; }

		// Token: 0x1700A7A9 RID: 42921
		// (get) Token: 0x06025AD6 RID: 154326 RVA: 0x0052A416 File Offset: 0x00528616
		// (set) Token: 0x06025AD7 RID: 154327 RVA: 0x0052A41E File Offset: 0x0052861E
		public bool IsDestroy { get; set; }

		// Token: 0x1700A7AA RID: 42922
		// (get) Token: 0x06025AD8 RID: 154328 RVA: 0x0052A427 File Offset: 0x00528627
		// (set) Token: 0x06025AD9 RID: 154329 RVA: 0x0052A42F File Offset: 0x0052862F
		public IItemChangeAdsorbateStateT ChangeAdsorbateState { get; set; }

		// Token: 0x1700A7AB RID: 42923
		// (get) Token: 0x06025ADA RID: 154330 RVA: 0x0052A438 File Offset: 0x00528638
		// (set) Token: 0x06025ADB RID: 154331 RVA: 0x0052A440 File Offset: 0x00528640
		public byte NullMask { get; set; }

		// Token: 0x06025ADC RID: 154332 RVA: 0x0052A449 File Offset: 0x00528649
		public IItemFoundationT()
		{
			this.Disabled = false;
			this.AdsorptionPoint = null;
			this.AdsorptionMatch = null;
			this.ActiveMatch = null;
			this.IsSilent = false;
			this.IsDestroy = false;
			this.ChangeAdsorbateState = null;
			this.NullMask = 0;
		}
	}
}

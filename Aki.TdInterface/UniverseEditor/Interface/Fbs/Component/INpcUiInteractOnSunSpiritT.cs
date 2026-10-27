using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005687 RID: 22151
	public class INpcUiInteractOnSunSpiritT
	{
		// Token: 0x1700A4AC RID: 42156
		// (get) Token: 0x06024F21 RID: 151329 RVA: 0x0051A280 File Offset: 0x00518480
		// (set) Token: 0x06024F22 RID: 151330 RVA: 0x0051A288 File Offset: 0x00518488
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700A4AD RID: 42157
		// (get) Token: 0x06024F23 RID: 151331 RVA: 0x0051A291 File Offset: 0x00518491
		// (set) Token: 0x06024F24 RID: 151332 RVA: 0x0051A299 File Offset: 0x00518499
		public string EnterMontage { get; set; }

		// Token: 0x1700A4AE RID: 42158
		// (get) Token: 0x06024F25 RID: 151333 RVA: 0x0051A2A2 File Offset: 0x005184A2
		// (set) Token: 0x06024F26 RID: 151334 RVA: 0x0051A2AA File Offset: 0x005184AA
		public string StandByMontage { get; set; }

		// Token: 0x1700A4AF RID: 42159
		// (get) Token: 0x06024F27 RID: 151335 RVA: 0x0051A2B3 File Offset: 0x005184B3
		// (set) Token: 0x06024F28 RID: 151336 RVA: 0x0051A2BB File Offset: 0x005184BB
		public string ShopSuccessMontage { get; set; }

		// Token: 0x1700A4B0 RID: 42160
		// (get) Token: 0x06024F29 RID: 151337 RVA: 0x0051A2C4 File Offset: 0x005184C4
		// (set) Token: 0x06024F2A RID: 151338 RVA: 0x0051A2CC File Offset: 0x005184CC
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700A4B1 RID: 42161
		// (get) Token: 0x06024F2B RID: 151339 RVA: 0x0051A2D5 File Offset: 0x005184D5
		// (set) Token: 0x06024F2C RID: 151340 RVA: 0x0051A2DD File Offset: 0x005184DD
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700A4B2 RID: 42162
		// (get) Token: 0x06024F2D RID: 151341 RVA: 0x0051A2E6 File Offset: 0x005184E6
		// (set) Token: 0x06024F2E RID: 151342 RVA: 0x0051A2EE File Offset: 0x005184EE
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700A4B3 RID: 42163
		// (get) Token: 0x06024F2F RID: 151343 RVA: 0x0051A2F7 File Offset: 0x005184F7
		// (set) Token: 0x06024F30 RID: 151344 RVA: 0x0051A2FF File Offset: 0x005184FF
		public string UpgradeSequence { get; set; }

		// Token: 0x1700A4B4 RID: 42164
		// (get) Token: 0x06024F31 RID: 151345 RVA: 0x0051A308 File Offset: 0x00518508
		// (set) Token: 0x06024F32 RID: 151346 RVA: 0x0051A310 File Offset: 0x00518510
		public IPlayFlowT UpgradeFlow { get; set; }

		// Token: 0x1700A4B5 RID: 42165
		// (get) Token: 0x06024F33 RID: 151347 RVA: 0x0051A319 File Offset: 0x00518519
		// (set) Token: 0x06024F34 RID: 151348 RVA: 0x0051A321 File Offset: 0x00518521
		public TMontageConfigUnion ExitMontage { get; set; }

		// Token: 0x1700A4B6 RID: 42166
		// (get) Token: 0x06024F35 RID: 151349 RVA: 0x0051A32A File Offset: 0x0051852A
		// (set) Token: 0x06024F36 RID: 151350 RVA: 0x0051A332 File Offset: 0x00518532
		public IPlayFlowT ExitFlow { get; set; }

		// Token: 0x06024F37 RID: 151351 RVA: 0x0051A33C File Offset: 0x0051853C
		public INpcUiInteractOnSunSpiritT()
		{
			this.Type = ENpcUiInteractType.HandInItem;
			this.EnterMontage = null;
			this.StandByMontage = null;
			this.ShopSuccessMontage = null;
			this.EnterFlow = null;
			this.ShopSuccessFlow = null;
			this.ShopFailedFlow = null;
			this.UpgradeSequence = null;
			this.UpgradeFlow = null;
			this.ExitMontage = null;
			this.ExitFlow = null;
		}
	}
}

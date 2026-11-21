using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F3 RID: 26867
	public class ICameraLockParamsT
	{
		// Token: 0x1700C591 RID: 50577
		// (get) Token: 0x0602E010 RID: 188432 RVA: 0x00649B66 File Offset: 0x00647D66
		// (set) Token: 0x0602E011 RID: 188433 RVA: 0x00649B6E File Offset: 0x00647D6E
		public float RelativeYawHardMin { get; set; }

		// Token: 0x1700C592 RID: 50578
		// (get) Token: 0x0602E012 RID: 188434 RVA: 0x00649B77 File Offset: 0x00647D77
		// (set) Token: 0x0602E013 RID: 188435 RVA: 0x00649B7F File Offset: 0x00647D7F
		public float RelativeYawHardMax { get; set; }

		// Token: 0x1700C593 RID: 50579
		// (get) Token: 0x0602E014 RID: 188436 RVA: 0x00649B88 File Offset: 0x00647D88
		// (set) Token: 0x0602E015 RID: 188437 RVA: 0x00649B90 File Offset: 0x00647D90
		public float RelativePitchHardMin { get; set; }

		// Token: 0x1700C594 RID: 50580
		// (get) Token: 0x0602E016 RID: 188438 RVA: 0x00649B99 File Offset: 0x00647D99
		// (set) Token: 0x0602E017 RID: 188439 RVA: 0x00649BA1 File Offset: 0x00647DA1
		public float RelativePitchHardMax { get; set; }

		// Token: 0x1700C595 RID: 50581
		// (get) Token: 0x0602E018 RID: 188440 RVA: 0x00649BAA File Offset: 0x00647DAA
		// (set) Token: 0x0602E019 RID: 188441 RVA: 0x00649BB2 File Offset: 0x00647DB2
		public float YawSignAdaptionLockDirection { get; set; }

		// Token: 0x1700C596 RID: 50582
		// (get) Token: 0x0602E01A RID: 188442 RVA: 0x00649BBB File Offset: 0x00647DBB
		// (set) Token: 0x0602E01B RID: 188443 RVA: 0x00649BC3 File Offset: 0x00647DC3
		public float RelativeRotationLagYawSpeedMin { get; set; }

		// Token: 0x1700C597 RID: 50583
		// (get) Token: 0x0602E01C RID: 188444 RVA: 0x00649BCC File Offset: 0x00647DCC
		// (set) Token: 0x0602E01D RID: 188445 RVA: 0x00649BD4 File Offset: 0x00647DD4
		public float RelativeRotationLagYawSpeedMax { get; set; }

		// Token: 0x1700C598 RID: 50584
		// (get) Token: 0x0602E01E RID: 188446 RVA: 0x00649BDD File Offset: 0x00647DDD
		// (set) Token: 0x0602E01F RID: 188447 RVA: 0x00649BE5 File Offset: 0x00647DE5
		public float RelativeRotationLagYawAngleRange { get; set; }

		// Token: 0x1700C599 RID: 50585
		// (get) Token: 0x0602E020 RID: 188448 RVA: 0x00649BEE File Offset: 0x00647DEE
		// (set) Token: 0x0602E021 RID: 188449 RVA: 0x00649BF6 File Offset: 0x00647DF6
		public float RelativeRotationLagPitchSpeedMin { get; set; }

		// Token: 0x1700C59A RID: 50586
		// (get) Token: 0x0602E022 RID: 188450 RVA: 0x00649BFF File Offset: 0x00647DFF
		// (set) Token: 0x0602E023 RID: 188451 RVA: 0x00649C07 File Offset: 0x00647E07
		public float RelativeRotationLagPitchSpeedMax { get; set; }

		// Token: 0x1700C59B RID: 50587
		// (get) Token: 0x0602E024 RID: 188452 RVA: 0x00649C10 File Offset: 0x00647E10
		// (set) Token: 0x0602E025 RID: 188453 RVA: 0x00649C18 File Offset: 0x00647E18
		public float RelativeRotationLagPitchAngleRange { get; set; }

		// Token: 0x1700C59C RID: 50588
		// (get) Token: 0x0602E026 RID: 188454 RVA: 0x00649C21 File Offset: 0x00647E21
		// (set) Token: 0x0602E027 RID: 188455 RVA: 0x00649C29 File Offset: 0x00647E29
		public float RelativeRotationLagRatioMin { get; set; }

		// Token: 0x1700C59D RID: 50589
		// (get) Token: 0x0602E028 RID: 188456 RVA: 0x00649C32 File Offset: 0x00647E32
		// (set) Token: 0x0602E029 RID: 188457 RVA: 0x00649C3A File Offset: 0x00647E3A
		public float RelativeRotationLagRatioMax { get; set; }

		// Token: 0x1700C59E RID: 50590
		// (get) Token: 0x0602E02A RID: 188458 RVA: 0x00649C43 File Offset: 0x00647E43
		// (set) Token: 0x0602E02B RID: 188459 RVA: 0x00649C4B File Offset: 0x00647E4B
		public float RelativeRotationLagDistanceRangeMin { get; set; }

		// Token: 0x1700C59F RID: 50591
		// (get) Token: 0x0602E02C RID: 188460 RVA: 0x00649C54 File Offset: 0x00647E54
		// (set) Token: 0x0602E02D RID: 188461 RVA: 0x00649C5C File Offset: 0x00647E5C
		public float RelativeRotationLagDistanceRangeMax { get; set; }

		// Token: 0x0602E02E RID: 188462 RVA: 0x00649C68 File Offset: 0x00647E68
		public ICameraLockParamsT()
		{
			this.RelativeYawHardMin = 0f;
			this.RelativeYawHardMax = 0f;
			this.RelativePitchHardMin = 0f;
			this.RelativePitchHardMax = 0f;
			this.YawSignAdaptionLockDirection = 0f;
			this.RelativeRotationLagYawSpeedMin = 0f;
			this.RelativeRotationLagYawSpeedMax = 0f;
			this.RelativeRotationLagYawAngleRange = 0f;
			this.RelativeRotationLagPitchSpeedMin = 0f;
			this.RelativeRotationLagPitchSpeedMax = 0f;
			this.RelativeRotationLagPitchAngleRange = 0f;
			this.RelativeRotationLagRatioMin = 0f;
			this.RelativeRotationLagRatioMax = 0f;
			this.RelativeRotationLagDistanceRangeMin = 0f;
			this.RelativeRotationLagDistanceRangeMax = 0f;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006282 RID: 25218
	public class ICameraLockParamsT
	{
		// Token: 0x1700BC09 RID: 48137
		// (get) Token: 0x0602B8AF RID: 178351 RVA: 0x005FED5E File Offset: 0x005FCF5E
		// (set) Token: 0x0602B8B0 RID: 178352 RVA: 0x005FED66 File Offset: 0x005FCF66
		public float RelativeYawHardMin { get; set; }

		// Token: 0x1700BC0A RID: 48138
		// (get) Token: 0x0602B8B1 RID: 178353 RVA: 0x005FED6F File Offset: 0x005FCF6F
		// (set) Token: 0x0602B8B2 RID: 178354 RVA: 0x005FED77 File Offset: 0x005FCF77
		public float RelativeYawHardMax { get; set; }

		// Token: 0x1700BC0B RID: 48139
		// (get) Token: 0x0602B8B3 RID: 178355 RVA: 0x005FED80 File Offset: 0x005FCF80
		// (set) Token: 0x0602B8B4 RID: 178356 RVA: 0x005FED88 File Offset: 0x005FCF88
		public float RelativePitchHardMin { get; set; }

		// Token: 0x1700BC0C RID: 48140
		// (get) Token: 0x0602B8B5 RID: 178357 RVA: 0x005FED91 File Offset: 0x005FCF91
		// (set) Token: 0x0602B8B6 RID: 178358 RVA: 0x005FED99 File Offset: 0x005FCF99
		public float RelativePitchHardMax { get; set; }

		// Token: 0x1700BC0D RID: 48141
		// (get) Token: 0x0602B8B7 RID: 178359 RVA: 0x005FEDA2 File Offset: 0x005FCFA2
		// (set) Token: 0x0602B8B8 RID: 178360 RVA: 0x005FEDAA File Offset: 0x005FCFAA
		public float YawSignAdaptionLockDirection { get; set; }

		// Token: 0x1700BC0E RID: 48142
		// (get) Token: 0x0602B8B9 RID: 178361 RVA: 0x005FEDB3 File Offset: 0x005FCFB3
		// (set) Token: 0x0602B8BA RID: 178362 RVA: 0x005FEDBB File Offset: 0x005FCFBB
		public float RelativeRotationLagYawSpeedMin { get; set; }

		// Token: 0x1700BC0F RID: 48143
		// (get) Token: 0x0602B8BB RID: 178363 RVA: 0x005FEDC4 File Offset: 0x005FCFC4
		// (set) Token: 0x0602B8BC RID: 178364 RVA: 0x005FEDCC File Offset: 0x005FCFCC
		public float RelativeRotationLagYawSpeedMax { get; set; }

		// Token: 0x1700BC10 RID: 48144
		// (get) Token: 0x0602B8BD RID: 178365 RVA: 0x005FEDD5 File Offset: 0x005FCFD5
		// (set) Token: 0x0602B8BE RID: 178366 RVA: 0x005FEDDD File Offset: 0x005FCFDD
		public float RelativeRotationLagYawAngleRange { get; set; }

		// Token: 0x1700BC11 RID: 48145
		// (get) Token: 0x0602B8BF RID: 178367 RVA: 0x005FEDE6 File Offset: 0x005FCFE6
		// (set) Token: 0x0602B8C0 RID: 178368 RVA: 0x005FEDEE File Offset: 0x005FCFEE
		public float RelativeRotationLagPitchSpeedMin { get; set; }

		// Token: 0x1700BC12 RID: 48146
		// (get) Token: 0x0602B8C1 RID: 178369 RVA: 0x005FEDF7 File Offset: 0x005FCFF7
		// (set) Token: 0x0602B8C2 RID: 178370 RVA: 0x005FEDFF File Offset: 0x005FCFFF
		public float RelativeRotationLagPitchSpeedMax { get; set; }

		// Token: 0x1700BC13 RID: 48147
		// (get) Token: 0x0602B8C3 RID: 178371 RVA: 0x005FEE08 File Offset: 0x005FD008
		// (set) Token: 0x0602B8C4 RID: 178372 RVA: 0x005FEE10 File Offset: 0x005FD010
		public float RelativeRotationLagPitchAngleRange { get; set; }

		// Token: 0x1700BC14 RID: 48148
		// (get) Token: 0x0602B8C5 RID: 178373 RVA: 0x005FEE19 File Offset: 0x005FD019
		// (set) Token: 0x0602B8C6 RID: 178374 RVA: 0x005FEE21 File Offset: 0x005FD021
		public float RelativeRotationLagRatioMin { get; set; }

		// Token: 0x1700BC15 RID: 48149
		// (get) Token: 0x0602B8C7 RID: 178375 RVA: 0x005FEE2A File Offset: 0x005FD02A
		// (set) Token: 0x0602B8C8 RID: 178376 RVA: 0x005FEE32 File Offset: 0x005FD032
		public float RelativeRotationLagRatioMax { get; set; }

		// Token: 0x1700BC16 RID: 48150
		// (get) Token: 0x0602B8C9 RID: 178377 RVA: 0x005FEE3B File Offset: 0x005FD03B
		// (set) Token: 0x0602B8CA RID: 178378 RVA: 0x005FEE43 File Offset: 0x005FD043
		public float RelativeRotationLagDistanceRangeMin { get; set; }

		// Token: 0x1700BC17 RID: 48151
		// (get) Token: 0x0602B8CB RID: 178379 RVA: 0x005FEE4C File Offset: 0x005FD04C
		// (set) Token: 0x0602B8CC RID: 178380 RVA: 0x005FEE54 File Offset: 0x005FD054
		public float RelativeRotationLagDistanceRangeMax { get; set; }

		// Token: 0x0602B8CD RID: 178381 RVA: 0x005FEE60 File Offset: 0x005FD060
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

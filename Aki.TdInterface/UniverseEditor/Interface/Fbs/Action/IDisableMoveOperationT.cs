using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065EC RID: 26092
	public class IDisableMoveOperationT
	{
		// Token: 0x1700C1CA RID: 49610
		// (get) Token: 0x0602D48B RID: 185483 RVA: 0x00635044 File Offset: 0x00633244
		// (set) Token: 0x0602D48C RID: 185484 RVA: 0x0063504C File Offset: 0x0063324C
		public EMoveOperationType Type { get; set; }

		// Token: 0x1700C1CB RID: 49611
		// (get) Token: 0x0602D48D RID: 185485 RVA: 0x00635055 File Offset: 0x00633255
		// (set) Token: 0x0602D48E RID: 185486 RVA: 0x0063505D File Offset: 0x0063325D
		public bool Forward { get; set; }

		// Token: 0x1700C1CC RID: 49612
		// (get) Token: 0x0602D48F RID: 185487 RVA: 0x00635066 File Offset: 0x00633266
		// (set) Token: 0x0602D490 RID: 185488 RVA: 0x0063506E File Offset: 0x0063326E
		public bool Back { get; set; }

		// Token: 0x1700C1CD RID: 49613
		// (get) Token: 0x0602D491 RID: 185489 RVA: 0x00635077 File Offset: 0x00633277
		// (set) Token: 0x0602D492 RID: 185490 RVA: 0x0063507F File Offset: 0x0063327F
		public bool Left { get; set; }

		// Token: 0x1700C1CE RID: 49614
		// (get) Token: 0x0602D493 RID: 185491 RVA: 0x00635088 File Offset: 0x00633288
		// (set) Token: 0x0602D494 RID: 185492 RVA: 0x00635090 File Offset: 0x00633290
		public bool Right { get; set; }

		// Token: 0x1700C1CF RID: 49615
		// (get) Token: 0x0602D495 RID: 185493 RVA: 0x00635099 File Offset: 0x00633299
		// (set) Token: 0x0602D496 RID: 185494 RVA: 0x006350A1 File Offset: 0x006332A1
		public bool ForceWalk { get; set; }

		// Token: 0x1700C1D0 RID: 49616
		// (get) Token: 0x0602D497 RID: 185495 RVA: 0x006350AA File Offset: 0x006332AA
		// (set) Token: 0x0602D498 RID: 185496 RVA: 0x006350B2 File Offset: 0x006332B2
		public bool ForceJog { get; set; }

		// Token: 0x1700C1D1 RID: 49617
		// (get) Token: 0x0602D499 RID: 185497 RVA: 0x006350BB File Offset: 0x006332BB
		// (set) Token: 0x0602D49A RID: 185498 RVA: 0x006350C3 File Offset: 0x006332C3
		public bool ForbidSprint { get; set; }

		// Token: 0x1700C1D2 RID: 49618
		// (get) Token: 0x0602D49B RID: 185499 RVA: 0x006350CC File Offset: 0x006332CC
		// (set) Token: 0x0602D49C RID: 185500 RVA: 0x006350D4 File Offset: 0x006332D4
		public bool ForbidAndDisableSprint { get; set; }

		// Token: 0x1700C1D3 RID: 49619
		// (get) Token: 0x0602D49D RID: 185501 RVA: 0x006350DD File Offset: 0x006332DD
		// (set) Token: 0x0602D49E RID: 185502 RVA: 0x006350E5 File Offset: 0x006332E5
		public bool ForbidAndDisableMotorcycleSprint { get; set; }

		// Token: 0x1700C1D4 RID: 49620
		// (get) Token: 0x0602D49F RID: 185503 RVA: 0x006350EE File Offset: 0x006332EE
		// (set) Token: 0x0602D4A0 RID: 185504 RVA: 0x006350F6 File Offset: 0x006332F6
		public bool DisableClimbAndStep { get; set; }

		// Token: 0x1700C1D5 RID: 49621
		// (get) Token: 0x0602D4A1 RID: 185505 RVA: 0x006350FF File Offset: 0x006332FF
		// (set) Token: 0x0602D4A2 RID: 185506 RVA: 0x00635107 File Offset: 0x00633307
		public byte NullMask { get; set; }

		// Token: 0x0602D4A3 RID: 185507 RVA: 0x00635110 File Offset: 0x00633310
		public IDisableMoveOperationT()
		{
			this.Type = EMoveOperationType.Enable;
			this.Forward = false;
			this.Back = false;
			this.Left = false;
			this.Right = false;
			this.ForceWalk = false;
			this.ForceJog = false;
			this.ForbidSprint = false;
			this.ForbidAndDisableSprint = false;
			this.ForbidAndDisableMotorcycleSprint = false;
			this.DisableClimbAndStep = false;
			this.NullMask = 0;
		}
	}
}

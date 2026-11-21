using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E8A RID: 16010
	public class IFishFollowStateT
	{
		// Token: 0x17006C31 RID: 27697
		// (get) Token: 0x060159B6 RID: 88502 RVA: 0x0031D2B5 File Offset: 0x0031B4B5
		// (set) Token: 0x060159B7 RID: 88503 RVA: 0x0031D2BD File Offset: 0x0031B4BD
		public EFishState Type { get; set; }

		// Token: 0x17006C32 RID: 27698
		// (get) Token: 0x060159B8 RID: 88504 RVA: 0x0031D2C6 File Offset: 0x0031B4C6
		// (set) Token: 0x060159B9 RID: 88505 RVA: 0x0031D2CE File Offset: 0x0031B4CE
		public TTargetTypeUnion Target { get; set; }

		// Token: 0x17006C33 RID: 27699
		// (get) Token: 0x060159BA RID: 88506 RVA: 0x0031D2D7 File Offset: 0x0031B4D7
		// (set) Token: 0x060159BB RID: 88507 RVA: 0x0031D2DF File Offset: 0x0031B4DF
		public IVectorInfoT Offset { get; set; }

		// Token: 0x17006C34 RID: 27700
		// (get) Token: 0x060159BC RID: 88508 RVA: 0x0031D2E8 File Offset: 0x0031B4E8
		// (set) Token: 0x060159BD RID: 88509 RVA: 0x0031D2F0 File Offset: 0x0031B4F0
		public bool FollowOffsetInTargetSpace { get; set; }

		// Token: 0x17006C35 RID: 27701
		// (get) Token: 0x060159BE RID: 88510 RVA: 0x0031D2F9 File Offset: 0x0031B4F9
		// (set) Token: 0x060159BF RID: 88511 RVA: 0x0031D301 File Offset: 0x0031B501
		public float MaxSpeed { get; set; }

		// Token: 0x17006C36 RID: 27702
		// (get) Token: 0x060159C0 RID: 88512 RVA: 0x0031D30A File Offset: 0x0031B50A
		// (set) Token: 0x060159C1 RID: 88513 RVA: 0x0031D312 File Offset: 0x0031B512
		public float StopDistance { get; set; }

		// Token: 0x17006C37 RID: 27703
		// (get) Token: 0x060159C2 RID: 88514 RVA: 0x0031D31B File Offset: 0x0031B51B
		// (set) Token: 0x060159C3 RID: 88515 RVA: 0x0031D323 File Offset: 0x0031B523
		public float FollowDistanceGraceTime { get; set; }

		// Token: 0x17006C38 RID: 27704
		// (get) Token: 0x060159C4 RID: 88516 RVA: 0x0031D32C File Offset: 0x0031B52C
		// (set) Token: 0x060159C5 RID: 88517 RVA: 0x0031D334 File Offset: 0x0031B534
		public float NiagaraFollowStrength { get; set; }

		// Token: 0x17006C39 RID: 27705
		// (get) Token: 0x060159C6 RID: 88518 RVA: 0x0031D33D File Offset: 0x0031B53D
		// (set) Token: 0x060159C7 RID: 88519 RVA: 0x0031D345 File Offset: 0x0031B545
		public byte NullMask { get; set; }

		// Token: 0x060159C8 RID: 88520 RVA: 0x0031D350 File Offset: 0x0031B550
		public IFishFollowStateT()
		{
			this.Type = EFishState.Idle;
			this.Target = null;
			this.Offset = null;
			this.FollowOffsetInTargetSpace = false;
			this.MaxSpeed = 0f;
			this.StopDistance = 0f;
			this.FollowDistanceGraceTime = 0f;
			this.NiagaraFollowStrength = 0f;
			this.NullMask = 0;
		}
	}
}

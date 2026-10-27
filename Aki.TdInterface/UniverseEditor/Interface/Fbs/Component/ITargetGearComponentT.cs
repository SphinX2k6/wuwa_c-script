using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A26 RID: 23078
	public class ITargetGearComponentT
	{
		// Token: 0x1700AD85 RID: 44421
		// (get) Token: 0x0602735E RID: 160606 RVA: 0x0056528F File Offset: 0x0056348F
		// (set) Token: 0x0602735F RID: 160607 RVA: 0x00565297 File Offset: 0x00563497
		public bool Disabled { get; set; }

		// Token: 0x1700AD86 RID: 44422
		// (get) Token: 0x06027360 RID: 160608 RVA: 0x005652A0 File Offset: 0x005634A0
		// (set) Token: 0x06027361 RID: 160609 RVA: 0x005652A8 File Offset: 0x005634A8
		public THitBulletTypeUnion HitBullet { get; set; }

		// Token: 0x1700AD87 RID: 44423
		// (get) Token: 0x06027362 RID: 160610 RVA: 0x005652B1 File Offset: 0x005634B1
		// (set) Token: 0x06027363 RID: 160611 RVA: 0x005652B9 File Offset: 0x005634B9
		public IHitTimeScaleRatioT AttackerHitTimeScaleRatio { get; set; }

		// Token: 0x1700AD88 RID: 44424
		// (get) Token: 0x06027364 RID: 160612 RVA: 0x005652C2 File Offset: 0x005634C2
		// (set) Token: 0x06027365 RID: 160613 RVA: 0x005652CA File Offset: 0x005634CA
		public IHitTimeScaleRatioT VictimHitTimeScaleRatio { get; set; }

		// Token: 0x1700AD89 RID: 44425
		// (get) Token: 0x06027366 RID: 160614 RVA: 0x005652D3 File Offset: 0x005634D3
		// (set) Token: 0x06027367 RID: 160615 RVA: 0x005652DB File Offset: 0x005634DB
		public List<IAimPartT> AimParts { get; set; }

		// Token: 0x1700AD8A RID: 44426
		// (get) Token: 0x06027368 RID: 160616 RVA: 0x005652E4 File Offset: 0x005634E4
		// (set) Token: 0x06027369 RID: 160617 RVA: 0x005652EC File Offset: 0x005634EC
		public string Type { get; set; }

		// Token: 0x1700AD8B RID: 44427
		// (get) Token: 0x0602736A RID: 160618 RVA: 0x005652F5 File Offset: 0x005634F5
		// (set) Token: 0x0602736B RID: 160619 RVA: 0x005652FD File Offset: 0x005634FD
		public bool IsCycle { get; set; }

		// Token: 0x1700AD8C RID: 44428
		// (get) Token: 0x0602736C RID: 160620 RVA: 0x00565306 File Offset: 0x00563506
		// (set) Token: 0x0602736D RID: 160621 RVA: 0x0056530E File Offset: 0x0056350E
		public int CycleInterval { get; set; }

		// Token: 0x1700AD8D RID: 44429
		// (get) Token: 0x0602736E RID: 160622 RVA: 0x00565317 File Offset: 0x00563517
		// (set) Token: 0x0602736F RID: 160623 RVA: 0x0056531F File Offset: 0x0056351F
		public List<string> CycleStates { get; set; }

		// Token: 0x1700AD8E RID: 44430
		// (get) Token: 0x06027370 RID: 160624 RVA: 0x00565328 File Offset: 0x00563528
		// (set) Token: 0x06027371 RID: 160625 RVA: 0x00565330 File Offset: 0x00563530
		public THitLogicTypeUnion HitLogicType { get; set; }

		// Token: 0x1700AD8F RID: 44431
		// (get) Token: 0x06027372 RID: 160626 RVA: 0x00565339 File Offset: 0x00563539
		// (set) Token: 0x06027373 RID: 160627 RVA: 0x00565341 File Offset: 0x00563541
		public ISplineMoveT Patrol { get; set; }

		// Token: 0x1700AD90 RID: 44432
		// (get) Token: 0x06027374 RID: 160628 RVA: 0x0056534A File Offset: 0x0056354A
		// (set) Token: 0x06027375 RID: 160629 RVA: 0x00565352 File Offset: 0x00563552
		public float HitCd { get; set; }

		// Token: 0x1700AD91 RID: 44433
		// (get) Token: 0x06027376 RID: 160630 RVA: 0x0056535B File Offset: 0x0056355B
		// (set) Token: 0x06027377 RID: 160631 RVA: 0x00565363 File Offset: 0x00563563
		public byte NullMask { get; set; }

		// Token: 0x06027378 RID: 160632 RVA: 0x0056536C File Offset: 0x0056356C
		public ITargetGearComponentT()
		{
			this.Disabled = false;
			this.HitBullet = null;
			this.AttackerHitTimeScaleRatio = null;
			this.VictimHitTimeScaleRatio = null;
			this.AimParts = null;
			this.Type = null;
			this.IsCycle = false;
			this.CycleInterval = 0;
			this.CycleStates = null;
			this.HitLogicType = null;
			this.Patrol = null;
			this.HitCd = 0f;
			this.NullMask = 0;
		}
	}
}

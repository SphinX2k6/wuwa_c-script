using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006033 RID: 24627
	public class ITargetGearComponentT
	{
		// Token: 0x1700B6BD RID: 46781
		// (get) Token: 0x060298D6 RID: 170198 RVA: 0x005AC253 File Offset: 0x005AA453
		// (set) Token: 0x060298D7 RID: 170199 RVA: 0x005AC25B File Offset: 0x005AA45B
		public bool Disabled { get; set; }

		// Token: 0x1700B6BE RID: 46782
		// (get) Token: 0x060298D8 RID: 170200 RVA: 0x005AC264 File Offset: 0x005AA464
		// (set) Token: 0x060298D9 RID: 170201 RVA: 0x005AC26C File Offset: 0x005AA46C
		public THitBulletTypeUnion HitBullet { get; set; }

		// Token: 0x1700B6BF RID: 46783
		// (get) Token: 0x060298DA RID: 170202 RVA: 0x005AC275 File Offset: 0x005AA475
		// (set) Token: 0x060298DB RID: 170203 RVA: 0x005AC27D File Offset: 0x005AA47D
		public IHitTimeScaleRatioT AttackerHitTimeScaleRatio { get; set; }

		// Token: 0x1700B6C0 RID: 46784
		// (get) Token: 0x060298DC RID: 170204 RVA: 0x005AC286 File Offset: 0x005AA486
		// (set) Token: 0x060298DD RID: 170205 RVA: 0x005AC28E File Offset: 0x005AA48E
		public IHitTimeScaleRatioT VictimHitTimeScaleRatio { get; set; }

		// Token: 0x1700B6C1 RID: 46785
		// (get) Token: 0x060298DE RID: 170206 RVA: 0x005AC297 File Offset: 0x005AA497
		// (set) Token: 0x060298DF RID: 170207 RVA: 0x005AC29F File Offset: 0x005AA49F
		public List<IAimPartT> AimParts { get; set; }

		// Token: 0x1700B6C2 RID: 46786
		// (get) Token: 0x060298E0 RID: 170208 RVA: 0x005AC2A8 File Offset: 0x005AA4A8
		// (set) Token: 0x060298E1 RID: 170209 RVA: 0x005AC2B0 File Offset: 0x005AA4B0
		public string Type { get; set; }

		// Token: 0x1700B6C3 RID: 46787
		// (get) Token: 0x060298E2 RID: 170210 RVA: 0x005AC2B9 File Offset: 0x005AA4B9
		// (set) Token: 0x060298E3 RID: 170211 RVA: 0x005AC2C1 File Offset: 0x005AA4C1
		public bool IsCycle { get; set; }

		// Token: 0x1700B6C4 RID: 46788
		// (get) Token: 0x060298E4 RID: 170212 RVA: 0x005AC2CA File Offset: 0x005AA4CA
		// (set) Token: 0x060298E5 RID: 170213 RVA: 0x005AC2D2 File Offset: 0x005AA4D2
		public int CycleInterval { get; set; }

		// Token: 0x1700B6C5 RID: 46789
		// (get) Token: 0x060298E6 RID: 170214 RVA: 0x005AC2DB File Offset: 0x005AA4DB
		// (set) Token: 0x060298E7 RID: 170215 RVA: 0x005AC2E3 File Offset: 0x005AA4E3
		public List<string> CycleStates { get; set; }

		// Token: 0x1700B6C6 RID: 46790
		// (get) Token: 0x060298E8 RID: 170216 RVA: 0x005AC2EC File Offset: 0x005AA4EC
		// (set) Token: 0x060298E9 RID: 170217 RVA: 0x005AC2F4 File Offset: 0x005AA4F4
		public THitLogicTypeUnion HitLogicType { get; set; }

		// Token: 0x1700B6C7 RID: 46791
		// (get) Token: 0x060298EA RID: 170218 RVA: 0x005AC2FD File Offset: 0x005AA4FD
		// (set) Token: 0x060298EB RID: 170219 RVA: 0x005AC305 File Offset: 0x005AA505
		public ISplineMoveT Patrol { get; set; }

		// Token: 0x1700B6C8 RID: 46792
		// (get) Token: 0x060298EC RID: 170220 RVA: 0x005AC30E File Offset: 0x005AA50E
		// (set) Token: 0x060298ED RID: 170221 RVA: 0x005AC316 File Offset: 0x005AA516
		public float HitCd { get; set; }

		// Token: 0x1700B6C9 RID: 46793
		// (get) Token: 0x060298EE RID: 170222 RVA: 0x005AC31F File Offset: 0x005AA51F
		// (set) Token: 0x060298EF RID: 170223 RVA: 0x005AC327 File Offset: 0x005AA527
		public byte NullMask { get; set; }

		// Token: 0x060298F0 RID: 170224 RVA: 0x005AC330 File Offset: 0x005AA530
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

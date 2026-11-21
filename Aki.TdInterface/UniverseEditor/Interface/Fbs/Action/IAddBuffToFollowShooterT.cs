using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006782 RID: 26498
	public class IAddBuffToFollowShooterT
	{
		// Token: 0x1700C0AA RID: 49322
		// (get) Token: 0x0602CECA RID: 184010 RVA: 0x00624355 File Offset: 0x00622555
		// (set) Token: 0x0602CECB RID: 184011 RVA: 0x0062435D File Offset: 0x0062255D
		public List<long> BuffIds { get; set; }

		// Token: 0x1700C0AB RID: 49323
		// (get) Token: 0x0602CECC RID: 184012 RVA: 0x00624366 File Offset: 0x00622566
		// (set) Token: 0x0602CECD RID: 184013 RVA: 0x0062436E File Offset: 0x0062256E
		public int FollowShooterId { get; set; }

		// Token: 0x1700C0AC RID: 49324
		// (get) Token: 0x0602CECE RID: 184014 RVA: 0x00624377 File Offset: 0x00622577
		// (set) Token: 0x0602CECF RID: 184015 RVA: 0x0062437F File Offset: 0x0062257F
		public byte NullMask { get; set; }

		// Token: 0x0602CED0 RID: 184016 RVA: 0x00624388 File Offset: 0x00622588
		public IAddBuffToFollowShooterT()
		{
			this.BuffIds = null;
			this.FollowShooterId = 0;
			this.NullMask = 0;
		}
	}
}

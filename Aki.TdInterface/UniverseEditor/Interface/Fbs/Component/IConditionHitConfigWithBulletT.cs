using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FF5 RID: 20469
	public class IConditionHitConfigWithBulletT
	{
		// Token: 0x1700944A RID: 37962
		// (get) Token: 0x06020B7F RID: 134015 RVA: 0x0048CAAE File Offset: 0x0048ACAE
		// (set) Token: 0x06020B80 RID: 134016 RVA: 0x0048CAB6 File Offset: 0x0048ACB6
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x1700944B RID: 37963
		// (get) Token: 0x06020B81 RID: 134017 RVA: 0x0048CABF File Offset: 0x0048ACBF
		// (set) Token: 0x06020B82 RID: 134018 RVA: 0x0048CAC7 File Offset: 0x0048ACC7
		public string State { get; set; }

		// Token: 0x1700944C RID: 37964
		// (get) Token: 0x06020B83 RID: 134019 RVA: 0x0048CAD0 File Offset: 0x0048ACD0
		// (set) Token: 0x06020B84 RID: 134020 RVA: 0x0048CAD8 File Offset: 0x0048ACD8
		public THitBulletTypeUnion HitBullets { get; set; }

		// Token: 0x06020B85 RID: 134021 RVA: 0x0048CAE1 File Offset: 0x0048ACE1
		public IConditionHitConfigWithBulletT()
		{
			this.Conditions = null;
			this.State = null;
			this.HitBullets = null;
		}
	}
}

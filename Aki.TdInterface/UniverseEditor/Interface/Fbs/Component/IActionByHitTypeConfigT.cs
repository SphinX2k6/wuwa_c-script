using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005356 RID: 21334
	public class IActionByHitTypeConfigT
	{
		// Token: 0x170096A0 RID: 38560
		// (get) Token: 0x0602136D RID: 136045 RVA: 0x00495999 File Offset: 0x00493B99
		// (set) Token: 0x0602136E RID: 136046 RVA: 0x004959A1 File Offset: 0x00493BA1
		public THitBulletTypeUnion HitBullets { get; set; }

		// Token: 0x170096A1 RID: 38561
		// (get) Token: 0x0602136F RID: 136047 RVA: 0x004959AA File Offset: 0x00493BAA
		// (set) Token: 0x06021370 RID: 136048 RVA: 0x004959B2 File Offset: 0x00493BB2
		public IConditionGroupT Condition { get; set; }

		// Token: 0x170096A2 RID: 38562
		// (get) Token: 0x06021371 RID: 136049 RVA: 0x004959BB File Offset: 0x00493BBB
		// (set) Token: 0x06021372 RID: 136050 RVA: 0x004959C3 File Offset: 0x00493BC3
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x170096A3 RID: 38563
		// (get) Token: 0x06021373 RID: 136051 RVA: 0x004959CC File Offset: 0x00493BCC
		// (set) Token: 0x06021374 RID: 136052 RVA: 0x004959D4 File Offset: 0x00493BD4
		public byte NullMask { get; set; }

		// Token: 0x06021375 RID: 136053 RVA: 0x004959DD File Offset: 0x00493BDD
		public IActionByHitTypeConfigT()
		{
			this.HitBullets = null;
			this.Condition = null;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}

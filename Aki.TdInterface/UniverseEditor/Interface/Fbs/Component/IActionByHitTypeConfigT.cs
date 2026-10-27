using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E45 RID: 20037
	public class IActionByHitTypeConfigT
	{
		// Token: 0x17008F67 RID: 36711
		// (get) Token: 0x0601F722 RID: 128802 RVA: 0x00461981 File Offset: 0x0045FB81
		// (set) Token: 0x0601F723 RID: 128803 RVA: 0x00461989 File Offset: 0x0045FB89
		public THitBulletTypeUnion HitBullets { get; set; }

		// Token: 0x17008F68 RID: 36712
		// (get) Token: 0x0601F724 RID: 128804 RVA: 0x00461992 File Offset: 0x0045FB92
		// (set) Token: 0x0601F725 RID: 128805 RVA: 0x0046199A File Offset: 0x0045FB9A
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17008F69 RID: 36713
		// (get) Token: 0x0601F726 RID: 128806 RVA: 0x004619A3 File Offset: 0x0045FBA3
		// (set) Token: 0x0601F727 RID: 128807 RVA: 0x004619AB File Offset: 0x0045FBAB
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17008F6A RID: 36714
		// (get) Token: 0x0601F728 RID: 128808 RVA: 0x004619B4 File Offset: 0x0045FBB4
		// (set) Token: 0x0601F729 RID: 128809 RVA: 0x004619BC File Offset: 0x0045FBBC
		public byte NullMask { get; set; }

		// Token: 0x0601F72A RID: 128810 RVA: 0x004619C5 File Offset: 0x0045FBC5
		public IActionByHitTypeConfigT()
		{
			this.HitBullets = null;
			this.Condition = null;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}

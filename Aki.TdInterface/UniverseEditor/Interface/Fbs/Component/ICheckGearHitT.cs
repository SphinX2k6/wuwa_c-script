using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C1 RID: 21697
	public class ICheckGearHitT
	{
		// Token: 0x17009AD9 RID: 39641
		// (get) Token: 0x06022357 RID: 140119 RVA: 0x004B71E9 File Offset: 0x004B53E9
		// (set) Token: 0x06022358 RID: 140120 RVA: 0x004B71F1 File Offset: 0x004B53F1
		public int HitIndex { get; set; }

		// Token: 0x17009ADA RID: 39642
		// (get) Token: 0x06022359 RID: 140121 RVA: 0x004B71FA File Offset: 0x004B53FA
		// (set) Token: 0x0602235A RID: 140122 RVA: 0x004B7202 File Offset: 0x004B5402
		public List<int> AffectIndex { get; set; }

		// Token: 0x17009ADB RID: 39643
		// (get) Token: 0x0602235B RID: 140123 RVA: 0x004B720B File Offset: 0x004B540B
		// (set) Token: 0x0602235C RID: 140124 RVA: 0x004B7213 File Offset: 0x004B5413
		public EGearHitAffectType AffectType { get; set; }

		// Token: 0x0602235D RID: 140125 RVA: 0x004B721C File Offset: 0x004B541C
		public ICheckGearHitT()
		{
			this.HitIndex = 0;
			this.AffectIndex = null;
			this.AffectType = EGearHitAffectType.ChangeNextState;
		}
	}
}

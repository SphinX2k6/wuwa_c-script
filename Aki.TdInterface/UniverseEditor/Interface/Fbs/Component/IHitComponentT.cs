using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200590D RID: 22797
	public class IHitComponentT
	{
		// Token: 0x1700A552 RID: 42322
		// (get) Token: 0x060250CE RID: 151758 RVA: 0x00515C78 File Offset: 0x00513E78
		// (set) Token: 0x060250CF RID: 151759 RVA: 0x00515C80 File Offset: 0x00513E80
		public bool Disabled { get; set; }

		// Token: 0x1700A553 RID: 42323
		// (get) Token: 0x060250D0 RID: 151760 RVA: 0x00515C89 File Offset: 0x00513E89
		// (set) Token: 0x060250D1 RID: 151761 RVA: 0x00515C91 File Offset: 0x00513E91
		public THitBulletTypeUnion HitBullet { get; set; }

		// Token: 0x1700A554 RID: 42324
		// (get) Token: 0x060250D2 RID: 151762 RVA: 0x00515C9A File Offset: 0x00513E9A
		// (set) Token: 0x060250D3 RID: 151763 RVA: 0x00515CA2 File Offset: 0x00513EA2
		public IHitTimeScaleRatioT AttackerHitTimeScaleRatio { get; set; }

		// Token: 0x1700A555 RID: 42325
		// (get) Token: 0x060250D4 RID: 151764 RVA: 0x00515CAB File Offset: 0x00513EAB
		// (set) Token: 0x060250D5 RID: 151765 RVA: 0x00515CB3 File Offset: 0x00513EB3
		public IHitTimeScaleRatioT VictimHitTimeScaleRatio { get; set; }

		// Token: 0x1700A556 RID: 42326
		// (get) Token: 0x060250D6 RID: 151766 RVA: 0x00515CBC File Offset: 0x00513EBC
		// (set) Token: 0x060250D7 RID: 151767 RVA: 0x00515CC4 File Offset: 0x00513EC4
		public List<IAimPartT> AimParts { get; set; }

		// Token: 0x1700A557 RID: 42327
		// (get) Token: 0x060250D8 RID: 151768 RVA: 0x00515CCD File Offset: 0x00513ECD
		// (set) Token: 0x060250D9 RID: 151769 RVA: 0x00515CD5 File Offset: 0x00513ED5
		public List<IBulletHitConfigT> BulletHitConfigs { get; set; }

		// Token: 0x1700A558 RID: 42328
		// (get) Token: 0x060250DA RID: 151770 RVA: 0x00515CDE File Offset: 0x00513EDE
		// (set) Token: 0x060250DB RID: 151771 RVA: 0x00515CE6 File Offset: 0x00513EE6
		public byte NullMask { get; set; }

		// Token: 0x060250DC RID: 151772 RVA: 0x00515CEF File Offset: 0x00513EEF
		public IHitComponentT()
		{
			this.Disabled = false;
			this.HitBullet = null;
			this.AttackerHitTimeScaleRatio = null;
			this.VictimHitTimeScaleRatio = null;
			this.AimParts = null;
			this.BulletHitConfigs = null;
			this.NullMask = 0;
		}
	}
}

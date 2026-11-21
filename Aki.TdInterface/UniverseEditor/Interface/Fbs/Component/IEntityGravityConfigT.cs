using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056DD RID: 22237
	public class IEntityGravityConfigT
	{
		// Token: 0x1700A04A RID: 41034
		// (get) Token: 0x06023AC7 RID: 146119 RVA: 0x004E7BA3 File Offset: 0x004E5DA3
		// (set) Token: 0x06023AC8 RID: 146120 RVA: 0x004E7BAB File Offset: 0x004E5DAB
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700A04B RID: 41035
		// (get) Token: 0x06023AC9 RID: 146121 RVA: 0x004E7BB4 File Offset: 0x004E5DB4
		// (set) Token: 0x06023ACA RID: 146122 RVA: 0x004E7BBC File Offset: 0x004E5DBC
		public bool SpecifyGravityLoad { get; set; }

		// Token: 0x1700A04C RID: 41036
		// (get) Token: 0x06023ACB RID: 146123 RVA: 0x004E7BC5 File Offset: 0x004E5DC5
		// (set) Token: 0x06023ACC RID: 146124 RVA: 0x004E7BCD File Offset: 0x004E5DCD
		public bool SpecifyGravityLock { get; set; }

		// Token: 0x1700A04D RID: 41037
		// (get) Token: 0x06023ACD RID: 146125 RVA: 0x004E7BD6 File Offset: 0x004E5DD6
		// (set) Token: 0x06023ACE RID: 146126 RVA: 0x004E7BDE File Offset: 0x004E5DDE
		public byte NullMask { get; set; }

		// Token: 0x06023ACF RID: 146127 RVA: 0x004E7BE7 File Offset: 0x004E5DE7
		public IEntityGravityConfigT()
		{
			this.GravityDirection = null;
			this.SpecifyGravityLoad = false;
			this.SpecifyGravityLock = false;
			this.NullMask = 0;
		}
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051AE RID: 20910
	public class IEntityScanFunctionT
	{
		// Token: 0x170098D1 RID: 39121
		// (get) Token: 0x06021D91 RID: 138641 RVA: 0x004B1FC5 File Offset: 0x004B01C5
		// (set) Token: 0x06021D92 RID: 138642 RVA: 0x004B1FCD File Offset: 0x004B01CD
		public int ScanId { get; set; }

		// Token: 0x170098D2 RID: 39122
		// (get) Token: 0x06021D93 RID: 138643 RVA: 0x004B1FD6 File Offset: 0x004B01D6
		// (set) Token: 0x06021D94 RID: 138644 RVA: 0x004B1FDE File Offset: 0x004B01DE
		public bool IsConcealed { get; set; }

		// Token: 0x170098D3 RID: 39123
		// (get) Token: 0x06021D95 RID: 138645 RVA: 0x004B1FE7 File Offset: 0x004B01E7
		// (set) Token: 0x06021D96 RID: 138646 RVA: 0x004B1FEF File Offset: 0x004B01EF
		public IScanTraceEffectT TraceEffect { get; set; }

		// Token: 0x170098D4 RID: 39124
		// (get) Token: 0x06021D97 RID: 138647 RVA: 0x004B1FF8 File Offset: 0x004B01F8
		// (set) Token: 0x06021D98 RID: 138648 RVA: 0x004B2000 File Offset: 0x004B0200
		public ESpecificScanType SpecificScanType { get; set; }

		// Token: 0x170098D5 RID: 39125
		// (get) Token: 0x06021D99 RID: 138649 RVA: 0x004B2009 File Offset: 0x004B0209
		// (set) Token: 0x06021D9A RID: 138650 RVA: 0x004B2011 File Offset: 0x004B0211
		public byte NullMask { get; set; }

		// Token: 0x06021D9B RID: 138651 RVA: 0x004B201A File Offset: 0x004B021A
		public IEntityScanFunctionT()
		{
			this.ScanId = 0;
			this.IsConcealed = false;
			this.TraceEffect = null;
			this.SpecificScanType = ESpecificScanType.None;
			this.NullMask = 0;
		}
	}
}

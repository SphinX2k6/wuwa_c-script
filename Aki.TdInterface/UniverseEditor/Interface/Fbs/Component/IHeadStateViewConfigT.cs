using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058EC RID: 22764
	public class IHeadStateViewConfigT
	{
		// Token: 0x1700A51E RID: 42270
		// (get) Token: 0x06024FB2 RID: 151474 RVA: 0x005138A7 File Offset: 0x00511AA7
		// (set) Token: 0x06024FB3 RID: 151475 RVA: 0x005138AF File Offset: 0x00511AAF
		public EHeadStateViewType HeadStateViewType { get; set; }

		// Token: 0x1700A51F RID: 42271
		// (get) Token: 0x06024FB4 RID: 151476 RVA: 0x005138B8 File Offset: 0x00511AB8
		// (set) Token: 0x06024FB5 RID: 151477 RVA: 0x005138C0 File Offset: 0x00511AC0
		public int ZOffset { get; set; }

		// Token: 0x1700A520 RID: 42272
		// (get) Token: 0x06024FB6 RID: 151478 RVA: 0x005138C9 File Offset: 0x00511AC9
		// (set) Token: 0x06024FB7 RID: 151479 RVA: 0x005138D1 File Offset: 0x00511AD1
		public int ForwardOffset { get; set; }

		// Token: 0x1700A521 RID: 42273
		// (get) Token: 0x06024FB8 RID: 151480 RVA: 0x005138DA File Offset: 0x00511ADA
		// (set) Token: 0x06024FB9 RID: 151481 RVA: 0x005138E2 File Offset: 0x00511AE2
		public string HeadStateSocketName { get; set; }

		// Token: 0x06024FBA RID: 151482 RVA: 0x005138EB File Offset: 0x00511AEB
		public IHeadStateViewConfigT()
		{
			this.HeadStateViewType = EHeadStateViewType.None;
			this.ZOffset = 0;
			this.ForwardOffset = 0;
			this.HeadStateSocketName = null;
		}
	}
}

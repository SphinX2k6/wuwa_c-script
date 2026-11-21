using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ACE RID: 27342
	public class ICommonBtOverrideT
	{
		// Token: 0x1700C8C8 RID: 51400
		// (get) Token: 0x0602EEFD RID: 192253 RVA: 0x00664B5C File Offset: 0x00662D5C
		// (set) Token: 0x0602EEFE RID: 192254 RVA: 0x00664B64 File Offset: 0x00662D64
		public int CommonBtId { get; set; }

		// Token: 0x1700C8C9 RID: 51401
		// (get) Token: 0x0602EEFF RID: 192255 RVA: 0x00664B6D File Offset: 0x00662D6D
		// (set) Token: 0x0602EF00 RID: 192256 RVA: 0x00664B75 File Offset: 0x00662D75
		public List<ICommonBtPlaceholderT> OverridePlaceholders { get; set; }

		// Token: 0x1700C8CA RID: 51402
		// (get) Token: 0x0602EF01 RID: 192257 RVA: 0x00664B7E File Offset: 0x00662D7E
		// (set) Token: 0x0602EF02 RID: 192258 RVA: 0x00664B86 File Offset: 0x00662D86
		public List<ICommonBtClientOverrideDataT> ClientOverrideData { get; set; }

		// Token: 0x0602EF03 RID: 192259 RVA: 0x00664B8F File Offset: 0x00662D8F
		public ICommonBtOverrideT()
		{
			this.CommonBtId = 0;
			this.OverridePlaceholders = null;
			this.ClientOverrideData = null;
		}
	}
}

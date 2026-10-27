using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006466 RID: 25702
	public class ICommonBtOverrideT
	{
		// Token: 0x1700BF46 RID: 48966
		// (get) Token: 0x0602C7B8 RID: 182200 RVA: 0x00619A90 File Offset: 0x00617C90
		// (set) Token: 0x0602C7B9 RID: 182201 RVA: 0x00619A98 File Offset: 0x00617C98
		public int CommonBtId { get; set; }

		// Token: 0x1700BF47 RID: 48967
		// (get) Token: 0x0602C7BA RID: 182202 RVA: 0x00619AA1 File Offset: 0x00617CA1
		// (set) Token: 0x0602C7BB RID: 182203 RVA: 0x00619AA9 File Offset: 0x00617CA9
		public List<ICommonBtPlaceholderT> OverridePlaceholders { get; set; }

		// Token: 0x1700BF48 RID: 48968
		// (get) Token: 0x0602C7BC RID: 182204 RVA: 0x00619AB2 File Offset: 0x00617CB2
		// (set) Token: 0x0602C7BD RID: 182205 RVA: 0x00619ABA File Offset: 0x00617CBA
		public List<ICommonBtClientOverrideDataT> ClientOverrideData { get; set; }

		// Token: 0x0602C7BE RID: 182206 RVA: 0x00619AC3 File Offset: 0x00617CC3
		public ICommonBtOverrideT()
		{
			this.CommonBtId = 0;
			this.OverridePlaceholders = null;
			this.ClientOverrideData = null;
		}
	}
}

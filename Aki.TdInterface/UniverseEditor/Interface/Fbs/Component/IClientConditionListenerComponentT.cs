using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FA7 RID: 20391
	public class IClientConditionListenerComponentT
	{
		// Token: 0x170093A7 RID: 37799
		// (get) Token: 0x0602071D RID: 132893 RVA: 0x00483891 File Offset: 0x00481A91
		// (set) Token: 0x0602071E RID: 132894 RVA: 0x00483899 File Offset: 0x00481A99
		public bool Disabled { get; set; }

		// Token: 0x170093A8 RID: 37800
		// (get) Token: 0x0602071F RID: 132895 RVA: 0x004838A2 File Offset: 0x00481AA2
		// (set) Token: 0x06020720 RID: 132896 RVA: 0x004838AA File Offset: 0x00481AAA
		public List<IClientConditionListenerT> Listeners { get; set; }

		// Token: 0x170093A9 RID: 37801
		// (get) Token: 0x06020721 RID: 132897 RVA: 0x004838B3 File Offset: 0x00481AB3
		// (set) Token: 0x06020722 RID: 132898 RVA: 0x004838BB File Offset: 0x00481ABB
		public byte NullMask { get; set; }

		// Token: 0x06020723 RID: 132899 RVA: 0x004838C4 File Offset: 0x00481AC4
		public IClientConditionListenerComponentT()
		{
			this.Disabled = false;
			this.Listeners = null;
			this.NullMask = 0;
		}
	}
}

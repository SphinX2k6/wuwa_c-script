using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A2 RID: 22946
	public class IStateChangeConfigT
	{
		// Token: 0x1700AC38 RID: 44088
		// (get) Token: 0x06026DF4 RID: 159220 RVA: 0x005597F2 File Offset: 0x005579F2
		// (set) Token: 0x06026DF5 RID: 159221 RVA: 0x005597FA File Offset: 0x005579FA
		public string RefreshState { get; set; }

		// Token: 0x1700AC39 RID: 44089
		// (get) Token: 0x06026DF6 RID: 159222 RVA: 0x00559803 File Offset: 0x00557A03
		// (set) Token: 0x06026DF7 RID: 159223 RVA: 0x0055980B File Offset: 0x00557A0B
		public string SubDestroyState { get; set; }

		// Token: 0x06026DF8 RID: 159224 RVA: 0x00559814 File Offset: 0x00557A14
		public IStateChangeConfigT()
		{
			this.RefreshState = null;
			this.SubDestroyState = null;
		}
	}
}

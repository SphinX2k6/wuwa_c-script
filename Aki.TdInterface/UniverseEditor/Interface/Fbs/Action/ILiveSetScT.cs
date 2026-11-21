using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200712E RID: 28974
	public class ILiveSetScT
	{
		// Token: 0x1700D425 RID: 54309
		// (get) Token: 0x0603255E RID: 206174 RVA: 0x006CE4CD File Offset: 0x006CC6CD
		// (set) Token: 0x0603255F RID: 206175 RVA: 0x006CE4D5 File Offset: 0x006CC6D5
		public TLiveScOperationUnion Operation { get; set; }

		// Token: 0x06032560 RID: 206176 RVA: 0x006CE4DE File Offset: 0x006CC6DE
		public ILiveSetScT()
		{
			this.Operation = null;
		}
	}
}

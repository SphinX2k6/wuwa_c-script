using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F1 RID: 29937
	public class IVarContextT
	{
		// Token: 0x1700E32C RID: 58156
		// (get) Token: 0x06036703 RID: 222979 RVA: 0x00765652 File Offset: 0x00763852
		// (set) Token: 0x06036704 RID: 222980 RVA: 0x0076565A File Offset: 0x0076385A
		public EVarContext Type { get; set; }

		// Token: 0x06036705 RID: 222981 RVA: 0x00765663 File Offset: 0x00763863
		public IVarContextT()
		{
			this.Type = EVarContext.None;
		}
	}
}

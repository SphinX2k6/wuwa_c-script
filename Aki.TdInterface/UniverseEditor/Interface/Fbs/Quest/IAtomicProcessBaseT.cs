using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004131 RID: 16689
	public class IAtomicProcessBaseT
	{
		// Token: 0x1700710A RID: 28938
		// (get) Token: 0x06016E9B RID: 93851 RVA: 0x0034531A File Offset: 0x0034351A
		// (set) Token: 0x06016E9C RID: 93852 RVA: 0x00345322 File Offset: 0x00343522
		public EAtomicProcess Type { get; set; }

		// Token: 0x06016E9D RID: 93853 RVA: 0x0034532B File Offset: 0x0034352B
		public IAtomicProcessBaseT()
		{
			this.Type = EAtomicProcess.StoveCoreFall;
		}
	}
}

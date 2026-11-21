using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA3 RID: 27555
	public class IDaolingAuthenticationT
	{
		// Token: 0x1700CA2C RID: 51756
		// (get) Token: 0x0602F6C7 RID: 194247 RVA: 0x0067834A File Offset: 0x0067654A
		// (set) Token: 0x0602F6C8 RID: 194248 RVA: 0x00678352 File Offset: 0x00676552
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x0602F6C9 RID: 194249 RVA: 0x0067835B File Offset: 0x0067655B
		public IDaolingAuthenticationT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}

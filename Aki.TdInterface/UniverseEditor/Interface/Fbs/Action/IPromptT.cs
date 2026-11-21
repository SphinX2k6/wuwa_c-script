using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200753B RID: 30011
	public class IPromptT
	{
		// Token: 0x1700DCCC RID: 56524
		// (get) Token: 0x06034A17 RID: 215575 RVA: 0x00714DEE File Offset: 0x00712FEE
		// (set) Token: 0x06034A18 RID: 215576 RVA: 0x00714DF6 File Offset: 0x00712FF6
		public int GeneralTextId { get; set; }

		// Token: 0x06034A19 RID: 215577 RVA: 0x00714DFF File Offset: 0x00712FFF
		public IPromptT()
		{
			this.GeneralTextId = 0;
		}
	}
}

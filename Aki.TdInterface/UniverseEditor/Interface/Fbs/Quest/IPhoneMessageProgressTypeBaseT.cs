using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F7B RID: 16251
	public class IPhoneMessageProgressTypeBaseT
	{
		// Token: 0x17007171 RID: 29041
		// (get) Token: 0x0601732C RID: 95020 RVA: 0x00358E6A File Offset: 0x0035706A
		// (set) Token: 0x0601732D RID: 95021 RVA: 0x00358E72 File Offset: 0x00357072
		public EPhoneMessageProgressType Type { get; set; }

		// Token: 0x0601732E RID: 95022 RVA: 0x00358E7B File Offset: 0x0035707B
		public IPhoneMessageProgressTypeBaseT()
		{
			this.Type = EPhoneMessageProgressType.CompleteMessage;
		}
	}
}

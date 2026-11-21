using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042CC RID: 17100
	public class IHandInItemsT
	{
		// Token: 0x17007510 RID: 29968
		// (get) Token: 0x06017FD3 RID: 98259 RVA: 0x0036CAF2 File Offset: 0x0036ACF2
		// (set) Token: 0x06017FD4 RID: 98260 RVA: 0x0036CAFA File Offset: 0x0036ACFA
		public List<IHandInItemT> Items { get; set; }

		// Token: 0x17007511 RID: 29969
		// (get) Token: 0x06017FD5 RID: 98261 RVA: 0x0036CB03 File Offset: 0x0036AD03
		// (set) Token: 0x06017FD6 RID: 98262 RVA: 0x0036CB0B File Offset: 0x0036AD0B
		public IHandInGroupT GroupConfig { get; set; }

		// Token: 0x17007512 RID: 29970
		// (get) Token: 0x06017FD7 RID: 98263 RVA: 0x0036CB14 File Offset: 0x0036AD14
		// (set) Token: 0x06017FD8 RID: 98264 RVA: 0x0036CB1C File Offset: 0x0036AD1C
		public string TidTitleText { get; set; }

		// Token: 0x17007513 RID: 29971
		// (get) Token: 0x06017FD9 RID: 98265 RVA: 0x0036CB25 File Offset: 0x0036AD25
		// (set) Token: 0x06017FDA RID: 98266 RVA: 0x0036CB2D File Offset: 0x0036AD2D
		public string TidDescText { get; set; }

		// Token: 0x17007514 RID: 29972
		// (get) Token: 0x06017FDB RID: 98267 RVA: 0x0036CB36 File Offset: 0x0036AD36
		// (set) Token: 0x06017FDC RID: 98268 RVA: 0x0036CB3E File Offset: 0x0036AD3E
		public bool RepeatItems { get; set; }

		// Token: 0x17007515 RID: 29973
		// (get) Token: 0x06017FDD RID: 98269 RVA: 0x0036CB47 File Offset: 0x0036AD47
		// (set) Token: 0x06017FDE RID: 98270 RVA: 0x0036CB4F File Offset: 0x0036AD4F
		public byte NullMask { get; set; }

		// Token: 0x06017FDF RID: 98271 RVA: 0x0036CB58 File Offset: 0x0036AD58
		public IHandInItemsT()
		{
			this.Items = null;
			this.GroupConfig = null;
			this.TidTitleText = null;
			this.TidDescText = null;
			this.RepeatItems = false;
			this.NullMask = 0;
		}
	}
}

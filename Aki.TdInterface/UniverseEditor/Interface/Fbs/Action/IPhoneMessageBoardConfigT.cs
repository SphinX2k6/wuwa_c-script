using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007419 RID: 29721
	public class IPhoneMessageBoardConfigT
	{
		// Token: 0x1700DA53 RID: 55891
		// (get) Token: 0x06034004 RID: 212996 RVA: 0x0070243C File Offset: 0x0070063C
		// (set) Token: 0x06034005 RID: 212997 RVA: 0x00702444 File Offset: 0x00700644
		public int PhoneMessageId { get; set; }

		// Token: 0x1700DA54 RID: 55892
		// (get) Token: 0x06034006 RID: 212998 RVA: 0x0070244D File Offset: 0x0070064D
		// (set) Token: 0x06034007 RID: 212999 RVA: 0x00702455 File Offset: 0x00700655
		public byte NullMask { get; set; }

		// Token: 0x06034008 RID: 213000 RVA: 0x0070245E File Offset: 0x0070065E
		public IPhoneMessageBoardConfigT()
		{
			this.PhoneMessageId = 0;
			this.NullMask = 0;
		}
	}
}

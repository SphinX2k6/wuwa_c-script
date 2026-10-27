using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA3 RID: 27811
	public class IPhoneMessageBoardConfigT
	{
		// Token: 0x1700CF16 RID: 53014
		// (get) Token: 0x0603102D RID: 200749 RVA: 0x006A7208 File Offset: 0x006A5408
		// (set) Token: 0x0603102E RID: 200750 RVA: 0x006A7210 File Offset: 0x006A5410
		public int PhoneMessageId { get; set; }

		// Token: 0x1700CF17 RID: 53015
		// (get) Token: 0x0603102F RID: 200751 RVA: 0x006A7219 File Offset: 0x006A5419
		// (set) Token: 0x06031030 RID: 200752 RVA: 0x006A7221 File Offset: 0x006A5421
		public byte NullMask { get; set; }

		// Token: 0x06031031 RID: 200753 RVA: 0x006A722A File Offset: 0x006A542A
		public IPhoneMessageBoardConfigT()
		{
			this.PhoneMessageId = 0;
			this.NullMask = 0;
		}
	}
}

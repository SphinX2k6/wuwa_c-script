using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD9 RID: 27609
	public class IDeletePhoneMessageT
	{
		// Token: 0x1700CA83 RID: 51843
		// (get) Token: 0x0602F85C RID: 194652 RVA: 0x0067AB0E File Offset: 0x00678D0E
		// (set) Token: 0x0602F85D RID: 194653 RVA: 0x0067AB16 File Offset: 0x00678D16
		public EPhoneSystemInteractType Type { get; set; }

		// Token: 0x1700CA84 RID: 51844
		// (get) Token: 0x0602F85E RID: 194654 RVA: 0x0067AB1F File Offset: 0x00678D1F
		// (set) Token: 0x0602F85F RID: 194655 RVA: 0x0067AB27 File Offset: 0x00678D27
		public int PhoneMessageId { get; set; }

		// Token: 0x1700CA85 RID: 51845
		// (get) Token: 0x0602F860 RID: 194656 RVA: 0x0067AB30 File Offset: 0x00678D30
		// (set) Token: 0x0602F861 RID: 194657 RVA: 0x0067AB38 File Offset: 0x00678D38
		public byte NullMask { get; set; }

		// Token: 0x0602F862 RID: 194658 RVA: 0x0067AB41 File Offset: 0x00678D41
		public IDeletePhoneMessageT()
		{
			this.Type = EPhoneSystemInteractType.SendPhoneMessage;
			this.PhoneMessageId = 0;
			this.NullMask = 0;
		}
	}
}

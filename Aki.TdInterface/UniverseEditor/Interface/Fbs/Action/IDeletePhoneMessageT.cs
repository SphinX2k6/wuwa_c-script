using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006568 RID: 25960
	public class IDeletePhoneMessageT
	{
		// Token: 0x1700C0E8 RID: 49384
		// (get) Token: 0x0602D0A0 RID: 184480 RVA: 0x0062E34A File Offset: 0x0062C54A
		// (set) Token: 0x0602D0A1 RID: 184481 RVA: 0x0062E352 File Offset: 0x0062C552
		public EPhoneSystemInteractType Type { get; set; }

		// Token: 0x1700C0E9 RID: 49385
		// (get) Token: 0x0602D0A2 RID: 184482 RVA: 0x0062E35B File Offset: 0x0062C55B
		// (set) Token: 0x0602D0A3 RID: 184483 RVA: 0x0062E363 File Offset: 0x0062C563
		public int PhoneMessageId { get; set; }

		// Token: 0x1700C0EA RID: 49386
		// (get) Token: 0x0602D0A4 RID: 184484 RVA: 0x0062E36C File Offset: 0x0062C56C
		// (set) Token: 0x0602D0A5 RID: 184485 RVA: 0x0062E374 File Offset: 0x0062C574
		public byte NullMask { get; set; }

		// Token: 0x0602D0A6 RID: 184486 RVA: 0x0062E37D File Offset: 0x0062C57D
		public IDeletePhoneMessageT()
		{
			this.Type = EPhoneSystemInteractType.SendPhoneMessage;
			this.PhoneMessageId = 0;
			this.NullMask = 0;
		}
	}
}

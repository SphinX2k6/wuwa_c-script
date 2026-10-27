using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F6 RID: 29430
	public class ITalkItemPhoneMessageSystemTipT
	{
		// Token: 0x1700DD6C RID: 56684
		// (get) Token: 0x06034EB9 RID: 216761 RVA: 0x0072AD46 File Offset: 0x00728F46
		// (set) Token: 0x06034EBA RID: 216762 RVA: 0x0072AD4E File Offset: 0x00728F4E
		public EPhoneMessageType Type { get; set; }

		// Token: 0x06034EBB RID: 216763 RVA: 0x0072AD57 File Offset: 0x00728F57
		public ITalkItemPhoneMessageSystemTipT()
		{
			this.Type = EPhoneMessageType.Voice;
		}
	}
}

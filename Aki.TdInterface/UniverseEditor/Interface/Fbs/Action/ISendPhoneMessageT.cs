using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F76 RID: 28534
	public class ISendPhoneMessageT
	{
		// Token: 0x1700D3F6 RID: 54262
		// (get) Token: 0x0603269B RID: 206491 RVA: 0x006CE183 File Offset: 0x006CC383
		// (set) Token: 0x0603269C RID: 206492 RVA: 0x006CE18B File Offset: 0x006CC38B
		public EPhoneSystemInteractType Type { get; set; }

		// Token: 0x1700D3F7 RID: 54263
		// (get) Token: 0x0603269D RID: 206493 RVA: 0x006CE194 File Offset: 0x006CC394
		// (set) Token: 0x0603269E RID: 206494 RVA: 0x006CE19C File Offset: 0x006CC39C
		public IPhoneRecordActionConfigT PhoneRecordActionConfig { get; set; }

		// Token: 0x0603269F RID: 206495 RVA: 0x006CE1A5 File Offset: 0x006CC3A5
		public ISendPhoneMessageT()
		{
			this.Type = EPhoneSystemInteractType.SendPhoneMessage;
			this.PhoneRecordActionConfig = null;
		}
	}
}

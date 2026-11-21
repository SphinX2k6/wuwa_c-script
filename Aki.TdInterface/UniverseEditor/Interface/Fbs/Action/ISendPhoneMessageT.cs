using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200773C RID: 30524
	public class ISendPhoneMessageT
	{
		// Token: 0x1700DFC5 RID: 57285
		// (get) Token: 0x060358EB RID: 219371 RVA: 0x0072DB3B File Offset: 0x0072BD3B
		// (set) Token: 0x060358EC RID: 219372 RVA: 0x0072DB43 File Offset: 0x0072BD43
		public EPhoneSystemInteractType Type { get; set; }

		// Token: 0x1700DFC6 RID: 57286
		// (get) Token: 0x060358ED RID: 219373 RVA: 0x0072DB4C File Offset: 0x0072BD4C
		// (set) Token: 0x060358EE RID: 219374 RVA: 0x0072DB54 File Offset: 0x0072BD54
		public IPhoneRecordActionConfigT PhoneRecordActionConfig { get; set; }

		// Token: 0x060358EF RID: 219375 RVA: 0x0072DB5D File Offset: 0x0072BD5D
		public ISendPhoneMessageT()
		{
			this.Type = EPhoneSystemInteractType.SendPhoneMessage;
			this.PhoneRecordActionConfig = null;
		}
	}
}

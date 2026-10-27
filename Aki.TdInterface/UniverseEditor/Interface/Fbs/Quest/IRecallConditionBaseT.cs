using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004074 RID: 16500
	public class IRecallConditionBaseT
	{
		// Token: 0x17007470 RID: 29808
		// (get) Token: 0x06017FCB RID: 98251 RVA: 0x00376278 File Offset: 0x00374478
		// (set) Token: 0x06017FCC RID: 98252 RVA: 0x00376280 File Offset: 0x00374480
		public ERecallConditionType Type { get; set; }

		// Token: 0x17007471 RID: 29809
		// (get) Token: 0x06017FCD RID: 98253 RVA: 0x00376289 File Offset: 0x00374489
		// (set) Token: 0x06017FCE RID: 98254 RVA: 0x00376291 File Offset: 0x00374491
		public ERecallOperation Operation { get; set; }

		// Token: 0x06017FCF RID: 98255 RVA: 0x0037629A File Offset: 0x0037449A
		public IRecallConditionBaseT()
		{
			this.Type = ERecallConditionType.ByEntityType;
			this.Operation = ERecallOperation.Include;
		}
	}
}

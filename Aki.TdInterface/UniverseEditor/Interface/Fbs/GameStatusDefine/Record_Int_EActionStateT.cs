using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B7B RID: 19323
	public class Record_Int_EActionStateT
	{
		// Token: 0x170088A0 RID: 34976
		// (get) Token: 0x0601D6CC RID: 120524 RVA: 0x00421F70 File Offset: 0x00420170
		// (set) Token: 0x0601D6CD RID: 120525 RVA: 0x00421F78 File Offset: 0x00420178
		public int Key { get; set; }

		// Token: 0x170088A1 RID: 34977
		// (get) Token: 0x0601D6CE RID: 120526 RVA: 0x00421F81 File Offset: 0x00420181
		// (set) Token: 0x0601D6CF RID: 120527 RVA: 0x00421F89 File Offset: 0x00420189
		public EActionState Value { get; set; }

		// Token: 0x0601D6D0 RID: 120528 RVA: 0x00421F92 File Offset: 0x00420192
		public Record_Int_EActionStateT()
		{
			this.Key = 0;
			this.Value = EActionState.Inactive;
		}
	}
}

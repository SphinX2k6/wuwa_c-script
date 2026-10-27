using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004713 RID: 18195
	public class Record_Int_EActionStateT
	{
		// Token: 0x1700825F RID: 33375
		// (get) Token: 0x0601BEF7 RID: 114423 RVA: 0x003F5CD4 File Offset: 0x003F3ED4
		// (set) Token: 0x0601BEF8 RID: 114424 RVA: 0x003F5CDC File Offset: 0x003F3EDC
		public int Key { get; set; }

		// Token: 0x17008260 RID: 33376
		// (get) Token: 0x0601BEF9 RID: 114425 RVA: 0x003F5CE5 File Offset: 0x003F3EE5
		// (set) Token: 0x0601BEFA RID: 114426 RVA: 0x003F5CED File Offset: 0x003F3EED
		public EActionState Value { get; set; }

		// Token: 0x0601BEFB RID: 114427 RVA: 0x003F5CF6 File Offset: 0x003F3EF6
		public Record_Int_EActionStateT()
		{
			this.Key = 0;
			this.Value = EActionState.Inactive;
		}
	}
}

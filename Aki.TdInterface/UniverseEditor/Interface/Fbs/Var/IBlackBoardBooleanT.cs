using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DE8 RID: 15848
	public class IBlackBoardBooleanT
	{
		// Token: 0x17006B07 RID: 27399
		// (get) Token: 0x06015463 RID: 87139 RVA: 0x00313AED File Offset: 0x00311CED
		// (set) Token: 0x06015464 RID: 87140 RVA: 0x00313AF5 File Offset: 0x00311CF5
		public EBlackBoardType Type { get; set; }

		// Token: 0x17006B08 RID: 27400
		// (get) Token: 0x06015465 RID: 87141 RVA: 0x00313AFE File Offset: 0x00311CFE
		// (set) Token: 0x06015466 RID: 87142 RVA: 0x00313B06 File Offset: 0x00311D06
		public string Key { get; set; }

		// Token: 0x17006B09 RID: 27401
		// (get) Token: 0x06015467 RID: 87143 RVA: 0x00313B0F File Offset: 0x00311D0F
		// (set) Token: 0x06015468 RID: 87144 RVA: 0x00313B17 File Offset: 0x00311D17
		public bool Value { get; set; }

		// Token: 0x06015469 RID: 87145 RVA: 0x00313B20 File Offset: 0x00311D20
		public IBlackBoardBooleanT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.Value = false;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DF7 RID: 15863
	public class IBlackBoardStringT
	{
		// Token: 0x17006B2A RID: 27434
		// (get) Token: 0x060154F1 RID: 87281 RVA: 0x003148D0 File Offset: 0x00312AD0
		// (set) Token: 0x060154F2 RID: 87282 RVA: 0x003148D8 File Offset: 0x00312AD8
		public EBlackBoardType Type { get; set; }

		// Token: 0x17006B2B RID: 27435
		// (get) Token: 0x060154F3 RID: 87283 RVA: 0x003148E1 File Offset: 0x00312AE1
		// (set) Token: 0x060154F4 RID: 87284 RVA: 0x003148E9 File Offset: 0x00312AE9
		public string Key { get; set; }

		// Token: 0x17006B2C RID: 27436
		// (get) Token: 0x060154F5 RID: 87285 RVA: 0x003148F2 File Offset: 0x00312AF2
		// (set) Token: 0x060154F6 RID: 87286 RVA: 0x003148FA File Offset: 0x00312AFA
		public string Value { get; set; }

		// Token: 0x060154F7 RID: 87287 RVA: 0x00314903 File Offset: 0x00312B03
		public IBlackBoardStringT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.Value = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A1F RID: 14879
	public class IBlackBoardVectorT
	{
		// Token: 0x17006601 RID: 26113
		// (get) Token: 0x060141F1 RID: 82417 RVA: 0x002F1A09 File Offset: 0x002EFC09
		// (set) Token: 0x060141F2 RID: 82418 RVA: 0x002F1A11 File Offset: 0x002EFC11
		public EBlackBoardType Type { get; set; }

		// Token: 0x17006602 RID: 26114
		// (get) Token: 0x060141F3 RID: 82419 RVA: 0x002F1A1A File Offset: 0x002EFC1A
		// (set) Token: 0x060141F4 RID: 82420 RVA: 0x002F1A22 File Offset: 0x002EFC22
		public string Key { get; set; }

		// Token: 0x17006603 RID: 26115
		// (get) Token: 0x060141F5 RID: 82421 RVA: 0x002F1A2B File Offset: 0x002EFC2B
		// (set) Token: 0x060141F6 RID: 82422 RVA: 0x002F1A33 File Offset: 0x002EFC33
		public IVectorInfoT Vector { get; set; }

		// Token: 0x060141F7 RID: 82423 RVA: 0x002F1A3C File Offset: 0x002EFC3C
		public IBlackBoardVectorT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.Vector = null;
		}
	}
}

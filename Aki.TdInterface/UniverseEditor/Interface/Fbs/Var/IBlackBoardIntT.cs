using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A19 RID: 14873
	public class IBlackBoardIntT
	{
		// Token: 0x170065F3 RID: 26099
		// (get) Token: 0x060141B7 RID: 82359 RVA: 0x002F13F1 File Offset: 0x002EF5F1
		// (set) Token: 0x060141B8 RID: 82360 RVA: 0x002F13F9 File Offset: 0x002EF5F9
		public EBlackBoardType Type { get; set; }

		// Token: 0x170065F4 RID: 26100
		// (get) Token: 0x060141B9 RID: 82361 RVA: 0x002F1402 File Offset: 0x002EF602
		// (set) Token: 0x060141BA RID: 82362 RVA: 0x002F140A File Offset: 0x002EF60A
		public string Key { get; set; }

		// Token: 0x170065F5 RID: 26101
		// (get) Token: 0x060141BB RID: 82363 RVA: 0x002F1413 File Offset: 0x002EF613
		// (set) Token: 0x060141BC RID: 82364 RVA: 0x002F141B File Offset: 0x002EF61B
		public int Value { get; set; }

		// Token: 0x060141BD RID: 82365 RVA: 0x002F1424 File Offset: 0x002EF624
		public IBlackBoardIntT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.Value = 0;
		}
	}
}

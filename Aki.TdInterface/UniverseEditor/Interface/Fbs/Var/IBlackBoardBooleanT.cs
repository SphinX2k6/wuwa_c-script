using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A0D RID: 14861
	public class IBlackBoardBooleanT
	{
		// Token: 0x170065D7 RID: 26071
		// (get) Token: 0x06014147 RID: 82247 RVA: 0x002F0901 File Offset: 0x002EEB01
		// (set) Token: 0x06014148 RID: 82248 RVA: 0x002F0909 File Offset: 0x002EEB09
		public EBlackBoardType Type { get; set; }

		// Token: 0x170065D8 RID: 26072
		// (get) Token: 0x06014149 RID: 82249 RVA: 0x002F0912 File Offset: 0x002EEB12
		// (set) Token: 0x0601414A RID: 82250 RVA: 0x002F091A File Offset: 0x002EEB1A
		public string Key { get; set; }

		// Token: 0x170065D9 RID: 26073
		// (get) Token: 0x0601414B RID: 82251 RVA: 0x002F0923 File Offset: 0x002EEB23
		// (set) Token: 0x0601414C RID: 82252 RVA: 0x002F092B File Offset: 0x002EEB2B
		public bool Value { get; set; }

		// Token: 0x0601414D RID: 82253 RVA: 0x002F0934 File Offset: 0x002EEB34
		public IBlackBoardBooleanT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.Value = false;
		}
	}
}

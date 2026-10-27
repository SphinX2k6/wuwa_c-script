using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057CD RID: 22477
	public class IQuickHackLinkEffectT
	{
		// Token: 0x1700A7CE RID: 42958
		// (get) Token: 0x06025BC8 RID: 154568 RVA: 0x00534489 File Offset: 0x00532689
		// (set) Token: 0x06025BC9 RID: 154569 RVA: 0x00534491 File Offset: 0x00532691
		public string RequiredState { get; set; }

		// Token: 0x1700A7CF RID: 42959
		// (get) Token: 0x06025BCA RID: 154570 RVA: 0x0053449A File Offset: 0x0053269A
		// (set) Token: 0x06025BCB RID: 154571 RVA: 0x005344A2 File Offset: 0x005326A2
		public string EffectPath { get; set; }

		// Token: 0x1700A7D0 RID: 42960
		// (get) Token: 0x06025BCC RID: 154572 RVA: 0x005344AB File Offset: 0x005326AB
		// (set) Token: 0x06025BCD RID: 154573 RVA: 0x005344B3 File Offset: 0x005326B3
		public IVectorInfoT StartPoint { get; set; }

		// Token: 0x1700A7D1 RID: 42961
		// (get) Token: 0x06025BCE RID: 154574 RVA: 0x005344BC File Offset: 0x005326BC
		// (set) Token: 0x06025BCF RID: 154575 RVA: 0x005344C4 File Offset: 0x005326C4
		public IVectorInfoT EndPoint { get; set; }

		// Token: 0x06025BD0 RID: 154576 RVA: 0x005344CD File Offset: 0x005326CD
		public IQuickHackLinkEffectT()
		{
			this.RequiredState = null;
			this.EffectPath = null;
			this.StartPoint = null;
			this.EndPoint = null;
		}
	}
}

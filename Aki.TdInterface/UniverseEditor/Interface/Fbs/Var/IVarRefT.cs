using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B18 RID: 15128
	public class IVarRefT
	{
		// Token: 0x170067C9 RID: 26569
		// (get) Token: 0x06014A6D RID: 84589 RVA: 0x003016E8 File Offset: 0x002FF8E8
		// (set) Token: 0x06014A6E RID: 84590 RVA: 0x003016F0 File Offset: 0x002FF8F0
		public EVar Type { get; set; }

		// Token: 0x170067CA RID: 26570
		// (get) Token: 0x06014A6F RID: 84591 RVA: 0x003016F9 File Offset: 0x002FF8F9
		// (set) Token: 0x06014A70 RID: 84592 RVA: 0x00301701 File Offset: 0x002FF901
		public EVarRefSource Source { get; set; }

		// Token: 0x06014A71 RID: 84593 RVA: 0x0030170A File Offset: 0x002FF90A
		public IVarRefT()
		{
			this.Type = EVar.Boolean;
			this.Source = EVarRefSource.Constant;
		}
	}
}

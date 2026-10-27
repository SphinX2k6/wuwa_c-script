using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A4 RID: 28836
	public class ISetVarT
	{
		// Token: 0x1700D63C RID: 54844
		// (get) Token: 0x06033109 RID: 209161 RVA: 0x006E3493 File Offset: 0x006E1693
		// (set) Token: 0x0603310A RID: 209162 RVA: 0x006E349B File Offset: 0x006E169B
		public TVarRefUnion VarLeft { get; set; }

		// Token: 0x1700D63D RID: 54845
		// (get) Token: 0x0603310B RID: 209163 RVA: 0x006E34A4 File Offset: 0x006E16A4
		// (set) Token: 0x0603310C RID: 209164 RVA: 0x006E34AC File Offset: 0x006E16AC
		public TVarRefUnion VarRight { get; set; }

		// Token: 0x0603310D RID: 209165 RVA: 0x006E34B5 File Offset: 0x006E16B5
		public ISetVarT()
		{
			this.VarLeft = null;
			this.VarRight = null;
		}
	}
}

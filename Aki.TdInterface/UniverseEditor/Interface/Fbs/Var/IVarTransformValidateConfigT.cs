using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B1E RID: 15134
	public class IVarTransformValidateConfigT
	{
		// Token: 0x170067D4 RID: 26580
		// (get) Token: 0x06014AA1 RID: 84641 RVA: 0x00301C4A File Offset: 0x002FFE4A
		// (set) Token: 0x06014AA2 RID: 84642 RVA: 0x00301C52 File Offset: 0x002FFE52
		public EVar Type { get; set; }

		// Token: 0x06014AA3 RID: 84643 RVA: 0x00301C5B File Offset: 0x002FFE5B
		public IVarTransformValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}

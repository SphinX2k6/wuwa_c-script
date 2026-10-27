using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B0F RID: 15119
	public class IVarPrefabValidateConfigT
	{
		// Token: 0x170067BF RID: 26559
		// (get) Token: 0x06014A35 RID: 84533 RVA: 0x0030121E File Offset: 0x002FF41E
		// (set) Token: 0x06014A36 RID: 84534 RVA: 0x00301226 File Offset: 0x002FF426
		public EVar Type { get; set; }

		// Token: 0x06014A37 RID: 84535 RVA: 0x0030122F File Offset: 0x002FF42F
		public IVarPrefabValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}

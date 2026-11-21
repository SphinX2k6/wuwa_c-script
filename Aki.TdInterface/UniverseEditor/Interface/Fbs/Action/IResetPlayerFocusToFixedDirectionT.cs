using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007619 RID: 30233
	public class IResetPlayerFocusToFixedDirectionT
	{
		// Token: 0x1700DE24 RID: 56868
		// (get) Token: 0x060350D3 RID: 217299 RVA: 0x007204AF File Offset: 0x0071E6AF
		// (set) Token: 0x060350D4 RID: 217300 RVA: 0x007204B7 File Offset: 0x0071E6B7
		public EResetPlayerFocusType Type { get; set; }

		// Token: 0x1700DE25 RID: 56869
		// (get) Token: 0x060350D5 RID: 217301 RVA: 0x007204C0 File Offset: 0x0071E6C0
		// (set) Token: 0x060350D6 RID: 217302 RVA: 0x007204C8 File Offset: 0x0071E6C8
		public IVectorInfoT Direction { get; set; }

		// Token: 0x060350D7 RID: 217303 RVA: 0x007204D1 File Offset: 0x0071E6D1
		public IResetPlayerFocusToFixedDirectionT()
		{
			this.Type = EResetPlayerFocusType.ResetToDefaultDirection;
			this.Direction = null;
		}
	}
}

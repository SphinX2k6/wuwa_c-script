using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200761C RID: 30236
	public class IResetPlayerFocusTypeT
	{
		// Token: 0x1700DE28 RID: 56872
		// (get) Token: 0x060350E7 RID: 217319 RVA: 0x0072066E File Offset: 0x0071E86E
		// (set) Token: 0x060350E8 RID: 217320 RVA: 0x00720676 File Offset: 0x0071E876
		public EResetPlayerFocusType Type { get; set; }

		// Token: 0x060350E9 RID: 217321 RVA: 0x0072067F File Offset: 0x0071E87F
		public IResetPlayerFocusTypeT()
		{
			this.Type = EResetPlayerFocusType.ResetToDefaultDirection;
		}
	}
}

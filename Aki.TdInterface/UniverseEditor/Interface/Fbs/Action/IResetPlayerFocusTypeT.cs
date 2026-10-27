using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E98 RID: 28312
	public class IResetPlayerFocusTypeT
	{
		// Token: 0x1700D2D1 RID: 53969
		// (get) Token: 0x060320A7 RID: 204967 RVA: 0x006C493A File Offset: 0x006C2B3A
		// (set) Token: 0x060320A8 RID: 204968 RVA: 0x006C4942 File Offset: 0x006C2B42
		public EResetPlayerFocusType Type { get; set; }

		// Token: 0x060320A9 RID: 204969 RVA: 0x006C494B File Offset: 0x006C2B4B
		public IResetPlayerFocusTypeT()
		{
			this.Type = EResetPlayerFocusType.ResetToDefaultDirection;
		}
	}
}

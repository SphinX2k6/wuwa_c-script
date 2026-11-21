using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072ED RID: 29421
	public class INewSplineStopTargetT
	{
		// Token: 0x1700D7B8 RID: 55224
		// (get) Token: 0x060334CB RID: 210123 RVA: 0x006EB5D6 File Offset: 0x006E97D6
		// (set) Token: 0x060334CC RID: 210124 RVA: 0x006EB5DE File Offset: 0x006E97DE
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x060334CD RID: 210125 RVA: 0x006EB5E7 File Offset: 0x006E97E7
		public INewSplineStopTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
		}
	}
}

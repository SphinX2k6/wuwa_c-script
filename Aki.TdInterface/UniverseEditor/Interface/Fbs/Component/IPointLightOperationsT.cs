using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005767 RID: 22375
	public class IPointLightOperationsT
	{
		// Token: 0x1700A6E3 RID: 42723
		// (get) Token: 0x060257F5 RID: 153589 RVA: 0x0052C4B7 File Offset: 0x0052A6B7
		// (set) Token: 0x060257F6 RID: 153590 RVA: 0x0052C4BF File Offset: 0x0052A6BF
		public IEntityMatchT Match { get; set; }

		// Token: 0x1700A6E4 RID: 42724
		// (get) Token: 0x060257F7 RID: 153591 RVA: 0x0052C4C8 File Offset: 0x0052A6C8
		// (set) Token: 0x060257F8 RID: 153592 RVA: 0x0052C4D0 File Offset: 0x0052A6D0
		public string SwitchToTargetState { get; set; }

		// Token: 0x060257F9 RID: 153593 RVA: 0x0052C4D9 File Offset: 0x0052A6D9
		public IPointLightOperationsT()
		{
			this.Match = null;
			this.SwitchToTargetState = null;
		}
	}
}

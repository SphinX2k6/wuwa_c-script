using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079F6 RID: 31222
	public class ISubScreenTransitionT
	{
		// Token: 0x1700E4DE RID: 58590
		// (get) Token: 0x0603704C RID: 225356 RVA: 0x0075AD17 File Offset: 0x00758F17
		// (set) Token: 0x0603704D RID: 225357 RVA: 0x0075AD1F File Offset: 0x00758F1F
		public float TransitionDuration { get; set; }

		// Token: 0x1700E4DF RID: 58591
		// (get) Token: 0x0603704E RID: 225358 RVA: 0x0075AD28 File Offset: 0x00758F28
		// (set) Token: 0x0603704F RID: 225359 RVA: 0x0075AD30 File Offset: 0x00758F30
		public string TransitionCurve { get; set; }

		// Token: 0x06037050 RID: 225360 RVA: 0x0075AD39 File Offset: 0x00758F39
		public ISubScreenTransitionT()
		{
			this.TransitionDuration = 0f;
			this.TransitionCurve = null;
		}
	}
}

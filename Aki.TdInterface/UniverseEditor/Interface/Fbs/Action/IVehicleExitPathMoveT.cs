using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200751B RID: 29979
	public class IVehicleExitPathMoveT
	{
		// Token: 0x1700E37C RID: 58236
		// (get) Token: 0x06036878 RID: 223352 RVA: 0x007686F3 File Offset: 0x007668F3
		// (set) Token: 0x06036879 RID: 223353 RVA: 0x007686FB File Offset: 0x007668FB
		public EVehicleControlType Type { get; set; }

		// Token: 0x1700E37D RID: 58237
		// (get) Token: 0x0603687A RID: 223354 RVA: 0x00768704 File Offset: 0x00766904
		// (set) Token: 0x0603687B RID: 223355 RVA: 0x0076870C File Offset: 0x0076690C
		public TCloseSplineMovePatternUnion Pattern { get; set; }

		// Token: 0x0603687C RID: 223356 RVA: 0x00768715 File Offset: 0x00766915
		public IVehicleExitPathMoveT()
		{
			this.Type = EVehicleControlType.EnterPathMoving;
			this.Pattern = null;
		}
	}
}

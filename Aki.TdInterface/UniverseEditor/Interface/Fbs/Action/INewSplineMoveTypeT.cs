using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E7 RID: 29415
	public class INewSplineMoveTypeT
	{
		// Token: 0x1700D7B3 RID: 55219
		// (get) Token: 0x060334AD RID: 210093 RVA: 0x006EB362 File Offset: 0x006E9562
		// (set) Token: 0x060334AE RID: 210094 RVA: 0x006EB36A File Offset: 0x006E956A
		public ENewSplineMoveType Type { get; set; }

		// Token: 0x060334AF RID: 210095 RVA: 0x006EB373 File Offset: 0x006E9573
		public INewSplineMoveTypeT()
		{
			this.Type = ENewSplineMoveType.FrontAxleTracking;
		}
	}
}

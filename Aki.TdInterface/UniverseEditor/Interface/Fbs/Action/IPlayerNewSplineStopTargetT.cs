using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007484 RID: 29828
	public class IPlayerNewSplineStopTargetT
	{
		// Token: 0x1700DB22 RID: 56098
		// (get) Token: 0x06034386 RID: 213894 RVA: 0x00708A8A File Offset: 0x00706C8A
		// (set) Token: 0x06034387 RID: 213895 RVA: 0x00708A92 File Offset: 0x00706C92
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x06034388 RID: 213896 RVA: 0x00708A9B File Offset: 0x00706C9B
		public IPlayerNewSplineStopTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
		}
	}
}

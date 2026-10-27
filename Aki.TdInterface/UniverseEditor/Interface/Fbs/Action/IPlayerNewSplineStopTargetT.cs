using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D09 RID: 27913
	public class IPlayerNewSplineStopTargetT
	{
		// Token: 0x1700CFDE RID: 53214
		// (get) Token: 0x06031392 RID: 201618 RVA: 0x006AD55A File Offset: 0x006AB75A
		// (set) Token: 0x06031393 RID: 201619 RVA: 0x006AD562 File Offset: 0x006AB762
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x06031394 RID: 201620 RVA: 0x006AD56B File Offset: 0x006AB76B
		public IPlayerNewSplineStopTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
		}
	}
}

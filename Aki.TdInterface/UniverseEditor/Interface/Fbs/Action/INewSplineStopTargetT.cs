using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA1 RID: 27553
	public class INewSplineStopTargetT
	{
		// Token: 0x1700CCCC RID: 52428
		// (get) Token: 0x06030651 RID: 198225 RVA: 0x00692C36 File Offset: 0x00690E36
		// (set) Token: 0x06030652 RID: 198226 RVA: 0x00692C3E File Offset: 0x00690E3E
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x06030653 RID: 198227 RVA: 0x00692C47 File Offset: 0x00690E47
		public INewSplineStopTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
		}
	}
}

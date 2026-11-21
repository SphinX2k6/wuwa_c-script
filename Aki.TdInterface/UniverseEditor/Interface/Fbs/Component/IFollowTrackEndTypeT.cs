using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005818 RID: 22552
	public class IFollowTrackEndTypeT
	{
		// Token: 0x1700A341 RID: 41793
		// (get) Token: 0x060247E7 RID: 149479 RVA: 0x00503AC2 File Offset: 0x00501CC2
		// (set) Token: 0x060247E8 RID: 149480 RVA: 0x00503ACA File Offset: 0x00501CCA
		public EFollowTrackEndType Type { get; set; }

		// Token: 0x060247E9 RID: 149481 RVA: 0x00503AD3 File Offset: 0x00501CD3
		public IFollowTrackEndTypeT()
		{
			this.Type = EFollowTrackEndType.ToStart;
		}
	}
}

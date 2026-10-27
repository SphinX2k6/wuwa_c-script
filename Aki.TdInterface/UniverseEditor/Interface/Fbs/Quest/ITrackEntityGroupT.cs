using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004200 RID: 16896
	public class ITrackEntityGroupT
	{
		// Token: 0x170077F0 RID: 30704
		// (get) Token: 0x06018F10 RID: 102160 RVA: 0x00396CFA File Offset: 0x00394EFA
		// (set) Token: 0x06018F11 RID: 102161 RVA: 0x00396D02 File Offset: 0x00394F02
		public ETrackType Type { get; set; }

		// Token: 0x170077F1 RID: 30705
		// (get) Token: 0x06018F12 RID: 102162 RVA: 0x00396D0B File Offset: 0x00394F0B
		// (set) Token: 0x06018F13 RID: 102163 RVA: 0x00396D13 File Offset: 0x00394F13
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x170077F2 RID: 30706
		// (get) Token: 0x06018F14 RID: 102164 RVA: 0x00396D1C File Offset: 0x00394F1C
		// (set) Token: 0x06018F15 RID: 102165 RVA: 0x00396D24 File Offset: 0x00394F24
		public List<int> Entities { get; set; }

		// Token: 0x170077F3 RID: 30707
		// (get) Token: 0x06018F16 RID: 102166 RVA: 0x00396D2D File Offset: 0x00394F2D
		// (set) Token: 0x06018F17 RID: 102167 RVA: 0x00396D35 File Offset: 0x00394F35
		public TTrackRuleTypeUnion TrackRuleType { get; set; }

		// Token: 0x06018F18 RID: 102168 RVA: 0x00396D3E File Offset: 0x00394F3E
		public ITrackEntityGroupT()
		{
			this.Type = ETrackType.Locations;
			this.GravityDirection = null;
			this.Entities = null;
			this.TrackRuleType = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F46 RID: 28486
	public class ISceneNewItemSplineStopTargetT
	{
		// Token: 0x1700D3B2 RID: 54194
		// (get) Token: 0x06032543 RID: 206147 RVA: 0x006CBE98 File Offset: 0x006CA098
		// (set) Token: 0x06032544 RID: 206148 RVA: 0x006CBEA0 File Offset: 0x006CA0A0
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x1700D3B3 RID: 54195
		// (get) Token: 0x06032545 RID: 206149 RVA: 0x006CBEA9 File Offset: 0x006CA0A9
		// (set) Token: 0x06032546 RID: 206150 RVA: 0x006CBEB1 File Offset: 0x006CA0B1
		public int EntityId { get; set; }

		// Token: 0x06032547 RID: 206151 RVA: 0x006CBEBA File Offset: 0x006CA0BA
		public ISceneNewItemSplineStopTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
			this.EntityId = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007341 RID: 29505
	public class INpcNewSplineMoveTargetT
	{
		// Token: 0x1700D83B RID: 55355
		// (get) Token: 0x06033748 RID: 210760 RVA: 0x006EFA14 File Offset: 0x006EDC14
		// (set) Token: 0x06033749 RID: 210761 RVA: 0x006EFA1C File Offset: 0x006EDC1C
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x1700D83C RID: 55356
		// (get) Token: 0x0603374A RID: 210762 RVA: 0x006EFA25 File Offset: 0x006EDC25
		// (set) Token: 0x0603374B RID: 210763 RVA: 0x006EFA2D File Offset: 0x006EDC2D
		public int NpcId { get; set; }

		// Token: 0x0603374C RID: 210764 RVA: 0x006EFA36 File Offset: 0x006EDC36
		public INpcNewSplineMoveTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
			this.NpcId = 0;
		}
	}
}

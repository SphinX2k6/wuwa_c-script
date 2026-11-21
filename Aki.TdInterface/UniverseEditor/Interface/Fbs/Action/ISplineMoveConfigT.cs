using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200794E RID: 31054
	public class ISplineMoveConfigT
	{
		// Token: 0x1700E3C7 RID: 58311
		// (get) Token: 0x06036B18 RID: 224024 RVA: 0x00751819 File Offset: 0x0074FA19
		// (set) Token: 0x06036B19 RID: 224025 RVA: 0x00751821 File Offset: 0x0074FA21
		public ESplineMoveConfigType Type { get; set; }

		// Token: 0x1700E3C8 RID: 58312
		// (get) Token: 0x06036B1A RID: 224026 RVA: 0x0075182A File Offset: 0x0074FA2A
		// (set) Token: 0x06036B1B RID: 224027 RVA: 0x00751832 File Offset: 0x0074FA32
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700E3C9 RID: 58313
		// (get) Token: 0x06036B1C RID: 224028 RVA: 0x0075183B File Offset: 0x0074FA3B
		// (set) Token: 0x06036B1D RID: 224029 RVA: 0x00751843 File Offset: 0x0074FA43
		public int SplineEntityId { get; set; }

		// Token: 0x06036B1E RID: 224030 RVA: 0x0075184C File Offset: 0x0074FA4C
		public ISplineMoveConfigT()
		{
			this.Type = ESplineMoveConfigType.Open;
			this.Target = null;
			this.SplineEntityId = 0;
		}
	}
}

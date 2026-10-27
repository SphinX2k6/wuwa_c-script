using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200609C RID: 24732
	public class IActorFaceExpressionT
	{
		// Token: 0x1700B63E RID: 46654
		// (get) Token: 0x0602A376 RID: 172918 RVA: 0x005D20F7 File Offset: 0x005D02F7
		// (set) Token: 0x0602A377 RID: 172919 RVA: 0x005D20FF File Offset: 0x005D02FF
		public int ActorIndex { get; set; }

		// Token: 0x1700B63F RID: 46655
		// (get) Token: 0x0602A378 RID: 172920 RVA: 0x005D2108 File Offset: 0x005D0308
		// (set) Token: 0x0602A379 RID: 172921 RVA: 0x005D2110 File Offset: 0x005D0310
		public TActorFaceExpressionUnion FaceExpression { get; set; }

		// Token: 0x0602A37A RID: 172922 RVA: 0x005D2119 File Offset: 0x005D0319
		public IActorFaceExpressionT()
		{
			this.ActorIndex = 0;
			this.FaceExpression = null;
		}
	}
}

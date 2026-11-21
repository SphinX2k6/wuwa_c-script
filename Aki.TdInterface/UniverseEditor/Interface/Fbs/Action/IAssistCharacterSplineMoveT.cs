using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200680F RID: 26639
	public class IAssistCharacterSplineMoveT
	{
		// Token: 0x1700C3CE RID: 50126
		// (get) Token: 0x0602D813 RID: 186387 RVA: 0x0063AA24 File Offset: 0x00638C24
		// (set) Token: 0x0602D814 RID: 186388 RVA: 0x0063AA2C File Offset: 0x00638C2C
		public EAssistCharacterMoveType Type { get; set; }

		// Token: 0x1700C3CF RID: 50127
		// (get) Token: 0x0602D815 RID: 186389 RVA: 0x0063AA35 File Offset: 0x00638C35
		// (set) Token: 0x0602D816 RID: 186390 RVA: 0x0063AA3D File Offset: 0x00638C3D
		public int SplineId { get; set; }

		// Token: 0x0602D817 RID: 186391 RVA: 0x0063AA46 File Offset: 0x00638C46
		public IAssistCharacterSplineMoveT()
		{
			this.Type = EAssistCharacterMoveType.Navigation;
			this.SplineId = 0;
		}
	}
}

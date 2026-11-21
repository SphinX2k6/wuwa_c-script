using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076CD RID: 30413
	public class ISceneNewItemSplineStopTargetT
	{
		// Token: 0x1700DF0E RID: 57102
		// (get) Token: 0x0603559B RID: 218523 RVA: 0x00727E00 File Offset: 0x00726000
		// (set) Token: 0x0603559C RID: 218524 RVA: 0x00727E08 File Offset: 0x00726008
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x1700DF0F RID: 57103
		// (get) Token: 0x0603559D RID: 218525 RVA: 0x00727E11 File Offset: 0x00726011
		// (set) Token: 0x0603559E RID: 218526 RVA: 0x00727E19 File Offset: 0x00726019
		public int EntityId { get; set; }

		// Token: 0x0603559F RID: 218527 RVA: 0x00727E22 File Offset: 0x00726022
		public ISceneNewItemSplineStopTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
			this.EntityId = 0;
		}
	}
}

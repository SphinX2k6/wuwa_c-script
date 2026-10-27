using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B5E RID: 27486
	public class IMoveToEntityT
	{
		// Token: 0x1700CC35 RID: 52277
		// (get) Token: 0x060303FB RID: 197627 RVA: 0x0068E4AD File Offset: 0x0068C6AD
		// (set) Token: 0x060303FC RID: 197628 RVA: 0x0068E4B5 File Offset: 0x0068C6B5
		public EMoveSceneItemType Type { get; set; }

		// Token: 0x1700CC36 RID: 52278
		// (get) Token: 0x060303FD RID: 197629 RVA: 0x0068E4BE File Offset: 0x0068C6BE
		// (set) Token: 0x060303FE RID: 197630 RVA: 0x0068E4C6 File Offset: 0x0068C6C6
		public int EntityId { get; set; }

		// Token: 0x1700CC37 RID: 52279
		// (get) Token: 0x060303FF RID: 197631 RVA: 0x0068E4CF File Offset: 0x0068C6CF
		// (set) Token: 0x06030400 RID: 197632 RVA: 0x0068E4D7 File Offset: 0x0068C6D7
		public TMoveToPointTypeUnion MoveMotion { get; set; }

		// Token: 0x06030401 RID: 197633 RVA: 0x0068E4E0 File Offset: 0x0068C6E0
		public IMoveToEntityT()
		{
			this.Type = EMoveSceneItemType.MoveToPoint;
			this.EntityId = 0;
			this.MoveMotion = null;
		}
	}
}

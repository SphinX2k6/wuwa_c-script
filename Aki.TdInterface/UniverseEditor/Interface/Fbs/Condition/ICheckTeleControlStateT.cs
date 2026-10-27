using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B5A RID: 19290
	public class ICheckTeleControlStateT
	{
		// Token: 0x17008BF2 RID: 35826
		// (get) Token: 0x0601E61D RID: 124445 RVA: 0x004419BE File Offset: 0x0043FBBE
		// (set) Token: 0x0601E61E RID: 124446 RVA: 0x004419C6 File Offset: 0x0043FBC6
		public ECondition Type { get; set; }

		// Token: 0x17008BF3 RID: 35827
		// (get) Token: 0x0601E61F RID: 124447 RVA: 0x004419CF File Offset: 0x0043FBCF
		// (set) Token: 0x0601E620 RID: 124448 RVA: 0x004419D7 File Offset: 0x0043FBD7
		public int EntityId { get; set; }

		// Token: 0x17008BF4 RID: 35828
		// (get) Token: 0x0601E621 RID: 124449 RVA: 0x004419E0 File Offset: 0x0043FBE0
		// (set) Token: 0x0601E622 RID: 124450 RVA: 0x004419E8 File Offset: 0x0043FBE8
		public ECompare CompareType { get; set; }

		// Token: 0x17008BF5 RID: 35829
		// (get) Token: 0x0601E623 RID: 124451 RVA: 0x004419F1 File Offset: 0x0043FBF1
		// (set) Token: 0x0601E624 RID: 124452 RVA: 0x004419F9 File Offset: 0x0043FBF9
		public ETeleControlState State { get; set; }

		// Token: 0x17008BF6 RID: 35830
		// (get) Token: 0x0601E625 RID: 124453 RVA: 0x00441A02 File Offset: 0x0043FC02
		// (set) Token: 0x0601E626 RID: 124454 RVA: 0x00441A0A File Offset: 0x0043FC0A
		public byte NullMask { get; set; }

		// Token: 0x0601E627 RID: 124455 RVA: 0x00441A13 File Offset: 0x0043FC13
		public ICheckTeleControlStateT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.CompareType = ECompare.Eq;
			this.State = ETeleControlState.Hold;
			this.NullMask = 0;
		}
	}
}

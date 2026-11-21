using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B98 RID: 23448
	public class INextSlideRailT
	{
		// Token: 0x1700AB66 RID: 43878
		// (get) Token: 0x06026A65 RID: 158309 RVA: 0x0054AB7C File Offset: 0x00548D7C
		// (set) Token: 0x06026A66 RID: 158310 RVA: 0x0054AB84 File Offset: 0x00548D84
		public ETriggerKey TriggerKey { get; set; }

		// Token: 0x1700AB67 RID: 43879
		// (get) Token: 0x06026A67 RID: 158311 RVA: 0x0054AB8D File Offset: 0x00548D8D
		// (set) Token: 0x06026A68 RID: 158312 RVA: 0x0054AB95 File Offset: 0x00548D95
		public int TargetRailEntityId { get; set; }

		// Token: 0x1700AB68 RID: 43880
		// (get) Token: 0x06026A69 RID: 158313 RVA: 0x0054AB9E File Offset: 0x00548D9E
		// (set) Token: 0x06026A6A RID: 158314 RVA: 0x0054ABA6 File Offset: 0x00548DA6
		public bool IsFallbackRail { get; set; }

		// Token: 0x1700AB69 RID: 43881
		// (get) Token: 0x06026A6B RID: 158315 RVA: 0x0054ABAF File Offset: 0x00548DAF
		// (set) Token: 0x06026A6C RID: 158316 RVA: 0x0054ABB7 File Offset: 0x00548DB7
		public byte NullMask { get; set; }

		// Token: 0x06026A6D RID: 158317 RVA: 0x0054ABC0 File Offset: 0x00548DC0
		public INextSlideRailT()
		{
			this.TriggerKey = ETriggerKey.Left;
			this.TargetRailEntityId = 0;
			this.IsFallbackRail = false;
			this.NullMask = 0;
		}
	}
}

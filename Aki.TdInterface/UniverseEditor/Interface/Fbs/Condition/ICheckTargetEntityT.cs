using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B4E RID: 19278
	public class ICheckTargetEntityT
	{
		// Token: 0x17008BDA RID: 35802
		// (get) Token: 0x0601E5BD RID: 124349 RVA: 0x00440ECB File Offset: 0x0043F0CB
		// (set) Token: 0x0601E5BE RID: 124350 RVA: 0x00440ED3 File Offset: 0x0043F0D3
		public ECheckEntity Type { get; set; }

		// Token: 0x17008BDB RID: 35803
		// (get) Token: 0x0601E5BF RID: 124351 RVA: 0x00440EDC File Offset: 0x0043F0DC
		// (set) Token: 0x0601E5C0 RID: 124352 RVA: 0x00440EE4 File Offset: 0x0043F0E4
		public TTargetEntityUnion TargetEntity { get; set; }

		// Token: 0x0601E5C1 RID: 124353 RVA: 0x00440EED File Offset: 0x0043F0ED
		public ICheckTargetEntityT()
		{
			this.Type = ECheckEntity.OnlinePlayer;
			this.TargetEntity = null;
		}
	}
}

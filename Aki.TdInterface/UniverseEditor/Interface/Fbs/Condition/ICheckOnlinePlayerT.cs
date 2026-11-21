using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FA5 RID: 20389
	public class ICheckOnlinePlayerT
	{
		// Token: 0x170091D4 RID: 37332
		// (get) Token: 0x0601FC57 RID: 130135 RVA: 0x0046A167 File Offset: 0x00468367
		// (set) Token: 0x0601FC58 RID: 130136 RVA: 0x0046A16F File Offset: 0x0046836F
		public ECheckEntity Type { get; set; }

		// Token: 0x170091D5 RID: 37333
		// (get) Token: 0x0601FC59 RID: 130137 RVA: 0x0046A178 File Offset: 0x00468378
		// (set) Token: 0x0601FC5A RID: 130138 RVA: 0x0046A180 File Offset: 0x00468380
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601FC5B RID: 130139 RVA: 0x0046A189 File Offset: 0x00468389
		public ICheckOnlinePlayerT()
		{
			this.Type = ECheckEntity.OnlinePlayer;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}

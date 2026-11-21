using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200591F RID: 22815
	public class IHitLogicChangeNextAndLockTargetStateT
	{
		// Token: 0x1700A579 RID: 42361
		// (get) Token: 0x06025180 RID: 151936 RVA: 0x0051744F File Offset: 0x0051564F
		// (set) Token: 0x06025181 RID: 151937 RVA: 0x00517457 File Offset: 0x00515657
		public EHitLogicType Type { get; set; }

		// Token: 0x1700A57A RID: 42362
		// (get) Token: 0x06025182 RID: 151938 RVA: 0x00517460 File Offset: 0x00515660
		// (set) Token: 0x06025183 RID: 151939 RVA: 0x00517468 File Offset: 0x00515668
		public string TargetState { get; set; }

		// Token: 0x06025184 RID: 151940 RVA: 0x00517471 File Offset: 0x00515671
		public IHitLogicChangeNextAndLockTargetStateT()
		{
			this.Type = EHitLogicType.ChangeNextState;
			this.TargetState = null;
		}
	}
}

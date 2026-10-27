using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E2 RID: 16866
	public class ITimeScaledPhotographT
	{
		// Token: 0x170077A6 RID: 30630
		// (get) Token: 0x06018DD6 RID: 101846 RVA: 0x00393F32 File Offset: 0x00392132
		// (set) Token: 0x06018DD7 RID: 101847 RVA: 0x00393F3A File Offset: 0x0039213A
		public EChildQuest Type { get; set; }

		// Token: 0x170077A7 RID: 30631
		// (get) Token: 0x06018DD8 RID: 101848 RVA: 0x00393F43 File Offset: 0x00392143
		// (set) Token: 0x06018DD9 RID: 101849 RVA: 0x00393F4B File Offset: 0x0039214B
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170077A8 RID: 30632
		// (get) Token: 0x06018DDA RID: 101850 RVA: 0x00393F54 File Offset: 0x00392154
		// (set) Token: 0x06018DDB RID: 101851 RVA: 0x00393F5C File Offset: 0x0039215C
		public ETimeScaledPhotographTip ViewFinderTip { get; set; }

		// Token: 0x170077A9 RID: 30633
		// (get) Token: 0x06018DDC RID: 101852 RVA: 0x00393F65 File Offset: 0x00392165
		// (set) Token: 0x06018DDD RID: 101853 RVA: 0x00393F6D File Offset: 0x0039216D
		public IPhotographConditionT PhotographCondition { get; set; }

		// Token: 0x170077AA RID: 30634
		// (get) Token: 0x06018DDE RID: 101854 RVA: 0x00393F76 File Offset: 0x00392176
		// (set) Token: 0x06018DDF RID: 101855 RVA: 0x00393F7E File Offset: 0x0039217E
		public ICameraConditionT CameraCondition { get; set; }

		// Token: 0x06018DE0 RID: 101856 RVA: 0x00393F87 File Offset: 0x00392187
		public ITimeScaledPhotographT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.ViewFinderTip = ETimeScaledPhotographTip.NoTip;
			this.PhotographCondition = null;
			this.CameraCondition = null;
		}
	}
}

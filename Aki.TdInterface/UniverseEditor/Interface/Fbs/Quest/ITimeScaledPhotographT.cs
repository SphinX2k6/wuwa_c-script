using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200463B RID: 17979
	public class ITimeScaledPhotographT
	{
		// Token: 0x17007DD2 RID: 32210
		// (get) Token: 0x0601A52C RID: 107820 RVA: 0x003BF386 File Offset: 0x003BD586
		// (set) Token: 0x0601A52D RID: 107821 RVA: 0x003BF38E File Offset: 0x003BD58E
		public EChildQuest Type { get; set; }

		// Token: 0x17007DD3 RID: 32211
		// (get) Token: 0x0601A52E RID: 107822 RVA: 0x003BF397 File Offset: 0x003BD597
		// (set) Token: 0x0601A52F RID: 107823 RVA: 0x003BF39F File Offset: 0x003BD59F
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007DD4 RID: 32212
		// (get) Token: 0x0601A530 RID: 107824 RVA: 0x003BF3A8 File Offset: 0x003BD5A8
		// (set) Token: 0x0601A531 RID: 107825 RVA: 0x003BF3B0 File Offset: 0x003BD5B0
		public ETimeScaledPhotographTip ViewFinderTip { get; set; }

		// Token: 0x17007DD5 RID: 32213
		// (get) Token: 0x0601A532 RID: 107826 RVA: 0x003BF3B9 File Offset: 0x003BD5B9
		// (set) Token: 0x0601A533 RID: 107827 RVA: 0x003BF3C1 File Offset: 0x003BD5C1
		public IPhotographConditionT PhotographCondition { get; set; }

		// Token: 0x17007DD6 RID: 32214
		// (get) Token: 0x0601A534 RID: 107828 RVA: 0x003BF3CA File Offset: 0x003BD5CA
		// (set) Token: 0x0601A535 RID: 107829 RVA: 0x003BF3D2 File Offset: 0x003BD5D2
		public ICameraConditionT CameraCondition { get; set; }

		// Token: 0x0601A536 RID: 107830 RVA: 0x003BF3DB File Offset: 0x003BD5DB
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

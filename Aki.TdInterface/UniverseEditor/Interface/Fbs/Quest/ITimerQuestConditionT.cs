using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041DC RID: 16860
	public class ITimerQuestConditionT
	{
		// Token: 0x17007794 RID: 30612
		// (get) Token: 0x06018D98 RID: 101784 RVA: 0x00393762 File Offset: 0x00391962
		// (set) Token: 0x06018D99 RID: 101785 RVA: 0x0039376A File Offset: 0x0039196A
		public EChildQuest Type { get; set; }

		// Token: 0x17007795 RID: 30613
		// (get) Token: 0x06018D9A RID: 101786 RVA: 0x00393773 File Offset: 0x00391973
		// (set) Token: 0x06018D9B RID: 101787 RVA: 0x0039377B File Offset: 0x0039197B
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007796 RID: 30614
		// (get) Token: 0x06018D9C RID: 101788 RVA: 0x00393784 File Offset: 0x00391984
		// (set) Token: 0x06018D9D RID: 101789 RVA: 0x0039378C File Offset: 0x0039198C
		public int Time { get; set; }

		// Token: 0x17007797 RID: 30615
		// (get) Token: 0x06018D9E RID: 101790 RVA: 0x00393795 File Offset: 0x00391995
		// (set) Token: 0x06018D9F RID: 101791 RVA: 0x0039379D File Offset: 0x0039199D
		public TVarRefUnion VarForTime { get; set; }

		// Token: 0x17007798 RID: 30616
		// (get) Token: 0x06018DA0 RID: 101792 RVA: 0x003937A6 File Offset: 0x003919A6
		// (set) Token: 0x06018DA1 RID: 101793 RVA: 0x003937AE File Offset: 0x003919AE
		public ETimerType TimerType { get; set; }

		// Token: 0x17007799 RID: 30617
		// (get) Token: 0x06018DA2 RID: 101794 RVA: 0x003937B7 File Offset: 0x003919B7
		// (set) Token: 0x06018DA3 RID: 101795 RVA: 0x003937BF File Offset: 0x003919BF
		public ITimerUiConfigT UiConfig { get; set; }

		// Token: 0x1700779A RID: 30618
		// (get) Token: 0x06018DA4 RID: 101796 RVA: 0x003937C8 File Offset: 0x003919C8
		// (set) Token: 0x06018DA5 RID: 101797 RVA: 0x003937D0 File Offset: 0x003919D0
		public byte NullMask { get; set; }

		// Token: 0x06018DA6 RID: 101798 RVA: 0x003937D9 File Offset: 0x003919D9
		public ITimerQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Time = 0;
			this.VarForTime = null;
			this.TimerType = ETimerType.CountDownChallenge;
			this.UiConfig = null;
			this.NullMask = 0;
		}
	}
}

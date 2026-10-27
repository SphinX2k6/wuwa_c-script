using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BBD RID: 19389
	public class IComparePlayerMotionStateT
	{
		// Token: 0x17008CCA RID: 36042
		// (get) Token: 0x0601E970 RID: 125296 RVA: 0x004473A3 File Offset: 0x004455A3
		// (set) Token: 0x0601E971 RID: 125297 RVA: 0x004473AB File Offset: 0x004455AB
		public ECondition Type { get; set; }

		// Token: 0x17008CCB RID: 36043
		// (get) Token: 0x0601E972 RID: 125298 RVA: 0x004473B4 File Offset: 0x004455B4
		// (set) Token: 0x0601E973 RID: 125299 RVA: 0x004473BC File Offset: 0x004455BC
		public EPlayerMotionState MotionState { get; set; }

		// Token: 0x17008CCC RID: 36044
		// (get) Token: 0x0601E974 RID: 125300 RVA: 0x004473C5 File Offset: 0x004455C5
		// (set) Token: 0x0601E975 RID: 125301 RVA: 0x004473CD File Offset: 0x004455CD
		public ECompare Compare { get; set; }

		// Token: 0x17008CCD RID: 36045
		// (get) Token: 0x0601E976 RID: 125302 RVA: 0x004473D6 File Offset: 0x004455D6
		// (set) Token: 0x0601E977 RID: 125303 RVA: 0x004473DE File Offset: 0x004455DE
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601E978 RID: 125304 RVA: 0x004473E7 File Offset: 0x004455E7
		public IComparePlayerMotionStateT()
		{
			this.Type = ECondition.CompareVar;
			this.MotionState = EPlayerMotionState.Ground;
			this.Compare = ECompare.Eq;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}

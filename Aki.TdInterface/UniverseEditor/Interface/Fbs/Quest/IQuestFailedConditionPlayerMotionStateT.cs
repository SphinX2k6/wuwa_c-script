using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004425 RID: 17445
	public class IQuestFailedConditionPlayerMotionStateT
	{
		// Token: 0x170078C9 RID: 30921
		// (get) Token: 0x06018F46 RID: 102214 RVA: 0x0038F1B8 File Offset: 0x0038D3B8
		// (set) Token: 0x06018F47 RID: 102215 RVA: 0x0038F1C0 File Offset: 0x0038D3C0
		public EPlayerMotionState MotionState { get; set; }

		// Token: 0x170078CA RID: 30922
		// (get) Token: 0x06018F48 RID: 102216 RVA: 0x0038F1C9 File Offset: 0x0038D3C9
		// (set) Token: 0x06018F49 RID: 102217 RVA: 0x0038F1D1 File Offset: 0x0038D3D1
		public ECompare Compare { get; set; }

		// Token: 0x06018F4A RID: 102218 RVA: 0x0038F1DA File Offset: 0x0038D3DA
		public IQuestFailedConditionPlayerMotionStateT()
		{
			this.MotionState = EPlayerMotionState.Ground;
			this.Compare = ECompare.Eq;
		}
	}
}

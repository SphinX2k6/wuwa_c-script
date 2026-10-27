using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064B1 RID: 25777
	public class ICommonTipTypeT
	{
		// Token: 0x1700BFD1 RID: 49105
		// (get) Token: 0x0602CAEC RID: 183020 RVA: 0x00621FFE File Offset: 0x006201FE
		// (set) Token: 0x0602CAED RID: 183021 RVA: 0x00622006 File Offset: 0x00620206
		public ECommonTipType Type { get; set; }

		// Token: 0x0602CAEE RID: 183022 RVA: 0x0062200F File Offset: 0x0062020F
		public ICommonTipTypeT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
		}
	}
}

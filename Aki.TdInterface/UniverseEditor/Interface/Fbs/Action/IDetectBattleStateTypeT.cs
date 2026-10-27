using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065B3 RID: 26035
	public class IDetectBattleStateTypeT
	{
		// Token: 0x1700C14B RID: 49483
		// (get) Token: 0x0602D293 RID: 184979 RVA: 0x00631432 File Offset: 0x0062F632
		// (set) Token: 0x0602D294 RID: 184980 RVA: 0x0063143A File Offset: 0x0062F63A
		public EDetectBattleConditionType Type { get; set; }

		// Token: 0x0602D295 RID: 184981 RVA: 0x00631443 File Offset: 0x0062F643
		public IDetectBattleStateTypeT()
		{
			this.Type = EDetectBattleConditionType.DetectBattleTag;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C1B RID: 27675
	public class IDetectBattleStateTypeT
	{
		// Token: 0x1700CADA RID: 51930
		// (get) Token: 0x0602FA17 RID: 195095 RVA: 0x0067D5F6 File Offset: 0x0067B7F6
		// (set) Token: 0x0602FA18 RID: 195096 RVA: 0x0067D5FE File Offset: 0x0067B7FE
		public EDetectBattleConditionType Type { get; set; }

		// Token: 0x0602FA19 RID: 195097 RVA: 0x0067D607 File Offset: 0x0067B807
		public IDetectBattleStateTypeT()
		{
			this.Type = EDetectBattleConditionType.DetectBattleTag;
		}
	}
}

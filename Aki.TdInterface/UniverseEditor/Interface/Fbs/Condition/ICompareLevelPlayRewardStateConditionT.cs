using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BAE RID: 19374
	public class ICompareLevelPlayRewardStateConditionT
	{
		// Token: 0x17008CA7 RID: 36007
		// (get) Token: 0x0601E8E8 RID: 125160 RVA: 0x0044650C File Offset: 0x0044470C
		// (set) Token: 0x0601E8E9 RID: 125161 RVA: 0x00446514 File Offset: 0x00444714
		public ECondition Type { get; set; }

		// Token: 0x17008CA8 RID: 36008
		// (get) Token: 0x0601E8EA RID: 125162 RVA: 0x0044651D File Offset: 0x0044471D
		// (set) Token: 0x0601E8EB RID: 125163 RVA: 0x00446525 File Offset: 0x00444725
		public ECompare Compare { get; set; }

		// Token: 0x0601E8EC RID: 125164 RVA: 0x0044652E File Offset: 0x0044472E
		public ICompareLevelPlayRewardStateConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
		}
	}
}

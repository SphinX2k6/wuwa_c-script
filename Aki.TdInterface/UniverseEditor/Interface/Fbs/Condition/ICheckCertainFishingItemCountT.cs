using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E4C RID: 20044
	public class ICheckCertainFishingItemCountT
	{
		// Token: 0x17008ED2 RID: 36562
		// (get) Token: 0x0601F033 RID: 127027 RVA: 0x00454778 File Offset: 0x00452978
		// (set) Token: 0x0601F034 RID: 127028 RVA: 0x00454780 File Offset: 0x00452980
		public ECondition Type { get; set; }

		// Token: 0x17008ED3 RID: 36563
		// (get) Token: 0x0601F035 RID: 127029 RVA: 0x00454789 File Offset: 0x00452989
		// (set) Token: 0x0601F036 RID: 127030 RVA: 0x00454791 File Offset: 0x00452991
		public int Id { get; set; }

		// Token: 0x17008ED4 RID: 36564
		// (get) Token: 0x0601F037 RID: 127031 RVA: 0x0045479A File Offset: 0x0045299A
		// (set) Token: 0x0601F038 RID: 127032 RVA: 0x004547A2 File Offset: 0x004529A2
		public ECompare Compare { get; set; }

		// Token: 0x17008ED5 RID: 36565
		// (get) Token: 0x0601F039 RID: 127033 RVA: 0x004547AB File Offset: 0x004529AB
		// (set) Token: 0x0601F03A RID: 127034 RVA: 0x004547B3 File Offset: 0x004529B3
		public int Count { get; set; }

		// Token: 0x0601F03B RID: 127035 RVA: 0x004547BC File Offset: 0x004529BC
		public ICheckCertainFishingItemCountT()
		{
			this.Type = ECondition.CompareVar;
			this.Id = 0;
			this.Compare = ECompare.Eq;
			this.Count = 0;
		}
	}
}

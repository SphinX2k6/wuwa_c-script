using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200508F RID: 20623
	public class ICompareFishingPrestigeLevelConditionT
	{
		// Token: 0x170093AA RID: 37802
		// (get) Token: 0x06020444 RID: 132164 RVA: 0x00478896 File Offset: 0x00476A96
		// (set) Token: 0x06020445 RID: 132165 RVA: 0x0047889E File Offset: 0x00476A9E
		public ECondition Type { get; set; }

		// Token: 0x170093AB RID: 37803
		// (get) Token: 0x06020446 RID: 132166 RVA: 0x004788A7 File Offset: 0x00476AA7
		// (set) Token: 0x06020447 RID: 132167 RVA: 0x004788AF File Offset: 0x00476AAF
		public ECompare Compare { get; set; }

		// Token: 0x170093AC RID: 37804
		// (get) Token: 0x06020448 RID: 132168 RVA: 0x004788B8 File Offset: 0x00476AB8
		// (set) Token: 0x06020449 RID: 132169 RVA: 0x004788C0 File Offset: 0x00476AC0
		public int PrestigeLevel { get; set; }

		// Token: 0x0602044A RID: 132170 RVA: 0x004788C9 File Offset: 0x00476AC9
		public ICompareFishingPrestigeLevelConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.PrestigeLevel = 0;
		}
	}
}

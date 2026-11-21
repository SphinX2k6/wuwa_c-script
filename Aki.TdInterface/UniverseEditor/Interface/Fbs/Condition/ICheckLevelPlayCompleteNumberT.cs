using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F90 RID: 20368
	public class ICheckLevelPlayCompleteNumberT
	{
		// Token: 0x170091A7 RID: 37287
		// (get) Token: 0x0601FBA1 RID: 129953 RVA: 0x00468D80 File Offset: 0x00466F80
		// (set) Token: 0x0601FBA2 RID: 129954 RVA: 0x00468D88 File Offset: 0x00466F88
		public ECondition Type { get; set; }

		// Token: 0x170091A8 RID: 37288
		// (get) Token: 0x0601FBA3 RID: 129955 RVA: 0x00468D91 File Offset: 0x00466F91
		// (set) Token: 0x0601FBA4 RID: 129956 RVA: 0x00468D99 File Offset: 0x00466F99
		public int LevelId { get; set; }

		// Token: 0x170091A9 RID: 37289
		// (get) Token: 0x0601FBA5 RID: 129957 RVA: 0x00468DA2 File Offset: 0x00466FA2
		// (set) Token: 0x0601FBA6 RID: 129958 RVA: 0x00468DAA File Offset: 0x00466FAA
		public ECompare Compare { get; set; }

		// Token: 0x170091AA RID: 37290
		// (get) Token: 0x0601FBA7 RID: 129959 RVA: 0x00468DB3 File Offset: 0x00466FB3
		// (set) Token: 0x0601FBA8 RID: 129960 RVA: 0x00468DBB File Offset: 0x00466FBB
		public int Number { get; set; }

		// Token: 0x0601FBA9 RID: 129961 RVA: 0x00468DC4 File Offset: 0x00466FC4
		public ICheckLevelPlayCompleteNumberT()
		{
			this.Type = ECondition.CompareVar;
			this.LevelId = 0;
			this.Compare = ECompare.Eq;
			this.Number = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E37 RID: 20023
	public class ICheckAiStateT
	{
		// Token: 0x17008EA0 RID: 36512
		// (get) Token: 0x0601EF75 RID: 126837 RVA: 0x004532EE File Offset: 0x004514EE
		// (set) Token: 0x0601EF76 RID: 126838 RVA: 0x004532F6 File Offset: 0x004514F6
		public ECondition Type { get; set; }

		// Token: 0x17008EA1 RID: 36513
		// (get) Token: 0x0601EF77 RID: 126839 RVA: 0x004532FF File Offset: 0x004514FF
		// (set) Token: 0x0601EF78 RID: 126840 RVA: 0x00453307 File Offset: 0x00451507
		public ECompare Compare { get; set; }

		// Token: 0x17008EA2 RID: 36514
		// (get) Token: 0x0601EF79 RID: 126841 RVA: 0x00453310 File Offset: 0x00451510
		// (set) Token: 0x0601EF7A RID: 126842 RVA: 0x00453318 File Offset: 0x00451518
		public EAiStateType StateType { get; set; }

		// Token: 0x0601EF7B RID: 126843 RVA: 0x00453321 File Offset: 0x00451521
		public ICheckAiStateT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.StateType = EAiStateType.AnimalStandUp;
		}
	}
}

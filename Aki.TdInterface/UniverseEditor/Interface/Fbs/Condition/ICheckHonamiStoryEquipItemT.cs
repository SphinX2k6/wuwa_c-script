using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F1E RID: 20254
	public class ICheckHonamiStoryEquipItemT
	{
		// Token: 0x170090A5 RID: 37029
		// (get) Token: 0x0601F795 RID: 128917 RVA: 0x00461A7E File Offset: 0x0045FC7E
		// (set) Token: 0x0601F796 RID: 128918 RVA: 0x00461A86 File Offset: 0x0045FC86
		public ECondition Type { get; set; }

		// Token: 0x170090A6 RID: 37030
		// (get) Token: 0x0601F797 RID: 128919 RVA: 0x00461A8F File Offset: 0x0045FC8F
		// (set) Token: 0x0601F798 RID: 128920 RVA: 0x00461A97 File Offset: 0x0045FC97
		public int ItemId { get; set; }

		// Token: 0x170090A7 RID: 37031
		// (get) Token: 0x0601F799 RID: 128921 RVA: 0x00461AA0 File Offset: 0x0045FCA0
		// (set) Token: 0x0601F79A RID: 128922 RVA: 0x00461AA8 File Offset: 0x0045FCA8
		public int Count { get; set; }

		// Token: 0x0601F79B RID: 128923 RVA: 0x00461AB1 File Offset: 0x0045FCB1
		public ICheckHonamiStoryEquipItemT()
		{
			this.Type = ECondition.CompareVar;
			this.ItemId = 0;
			this.Count = 0;
		}
	}
}

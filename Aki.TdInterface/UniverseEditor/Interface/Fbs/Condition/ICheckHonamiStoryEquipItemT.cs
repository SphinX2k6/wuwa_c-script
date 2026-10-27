using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A58 RID: 19032
	public class ICheckHonamiStoryEquipItemT
	{
		// Token: 0x170089C9 RID: 35273
		// (get) Token: 0x0601DCF2 RID: 122098 RVA: 0x004308F2 File Offset: 0x0042EAF2
		// (set) Token: 0x0601DCF3 RID: 122099 RVA: 0x004308FA File Offset: 0x0042EAFA
		public ECondition Type { get; set; }

		// Token: 0x170089CA RID: 35274
		// (get) Token: 0x0601DCF4 RID: 122100 RVA: 0x00430903 File Offset: 0x0042EB03
		// (set) Token: 0x0601DCF5 RID: 122101 RVA: 0x0043090B File Offset: 0x0042EB0B
		public int ItemId { get; set; }

		// Token: 0x170089CB RID: 35275
		// (get) Token: 0x0601DCF6 RID: 122102 RVA: 0x00430914 File Offset: 0x0042EB14
		// (set) Token: 0x0601DCF7 RID: 122103 RVA: 0x0043091C File Offset: 0x0042EB1C
		public int Count { get; set; }

		// Token: 0x0601DCF8 RID: 122104 RVA: 0x00430925 File Offset: 0x0042EB25
		public ICheckHonamiStoryEquipItemT()
		{
			this.Type = ECondition.CompareVar;
			this.ItemId = 0;
			this.Count = 0;
		}
	}
}

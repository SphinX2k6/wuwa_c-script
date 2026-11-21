using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F21 RID: 20257
	public class ICheckHonamiStoryGetItemT
	{
		// Token: 0x170090AB RID: 37035
		// (get) Token: 0x0601F7AD RID: 128941 RVA: 0x00461CB0 File Offset: 0x0045FEB0
		// (set) Token: 0x0601F7AE RID: 128942 RVA: 0x00461CB8 File Offset: 0x0045FEB8
		public ECondition Type { get; set; }

		// Token: 0x170090AC RID: 37036
		// (get) Token: 0x0601F7AF RID: 128943 RVA: 0x00461CC1 File Offset: 0x0045FEC1
		// (set) Token: 0x0601F7B0 RID: 128944 RVA: 0x00461CC9 File Offset: 0x0045FEC9
		public int ItemId { get; set; }

		// Token: 0x0601F7B1 RID: 128945 RVA: 0x00461CD2 File Offset: 0x0045FED2
		public ICheckHonamiStoryGetItemT()
		{
			this.Type = ECondition.CompareVar;
			this.ItemId = 0;
		}
	}
}

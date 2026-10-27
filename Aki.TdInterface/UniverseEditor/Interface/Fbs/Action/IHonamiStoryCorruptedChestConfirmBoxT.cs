using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200691C RID: 26908
	public class IHonamiStoryCorruptedChestConfirmBoxT
	{
		// Token: 0x1700C7A6 RID: 51110
		// (get) Token: 0x0602EF97 RID: 192407 RVA: 0x00667CBC File Offset: 0x00665EBC
		// (set) Token: 0x0602EF98 RID: 192408 RVA: 0x00667CC4 File Offset: 0x00665EC4
		public EInteractionConfirmBoxType Type { get; set; }

		// Token: 0x1700C7A7 RID: 51111
		// (get) Token: 0x0602EF99 RID: 192409 RVA: 0x00667CCD File Offset: 0x00665ECD
		// (set) Token: 0x0602EF9A RID: 192410 RVA: 0x00667CD5 File Offset: 0x00665ED5
		public int Id { get; set; }

		// Token: 0x0602EF9B RID: 192411 RVA: 0x00667CDE File Offset: 0x00665EDE
		public IHonamiStoryCorruptedChestConfirmBoxT()
		{
			this.Type = EInteractionConfirmBoxType.Common;
			this.Id = 0;
		}
	}
}

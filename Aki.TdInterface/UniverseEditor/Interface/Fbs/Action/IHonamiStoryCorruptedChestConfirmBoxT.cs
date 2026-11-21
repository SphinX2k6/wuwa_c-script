using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FCF RID: 28623
	public class IHonamiStoryCorruptedChestConfirmBoxT
	{
		// Token: 0x1700D1A9 RID: 53673
		// (get) Token: 0x06031967 RID: 203111 RVA: 0x006B81A4 File Offset: 0x006B63A4
		// (set) Token: 0x06031968 RID: 203112 RVA: 0x006B81AC File Offset: 0x006B63AC
		public EInteractionConfirmBoxType Type { get; set; }

		// Token: 0x1700D1AA RID: 53674
		// (get) Token: 0x06031969 RID: 203113 RVA: 0x006B81B5 File Offset: 0x006B63B5
		// (set) Token: 0x0603196A RID: 203114 RVA: 0x006B81BD File Offset: 0x006B63BD
		public int Id { get; set; }

		// Token: 0x0603196B RID: 203115 RVA: 0x006B81C6 File Offset: 0x006B63C6
		public IHonamiStoryCorruptedChestConfirmBoxT()
		{
			this.Type = EInteractionConfirmBoxType.Common;
			this.Id = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD5 RID: 28629
	public class IHonamiStoryEvacuateConfirmBoxT
	{
		// Token: 0x1700D1B2 RID: 53682
		// (get) Token: 0x06031991 RID: 203153 RVA: 0x006B8542 File Offset: 0x006B6742
		// (set) Token: 0x06031992 RID: 203154 RVA: 0x006B854A File Offset: 0x006B674A
		public EInteractionConfirmBoxType Type { get; set; }

		// Token: 0x06031993 RID: 203155 RVA: 0x006B8553 File Offset: 0x006B6753
		public IHonamiStoryEvacuateConfirmBoxT()
		{
			this.Type = EInteractionConfirmBoxType.Common;
		}
	}
}

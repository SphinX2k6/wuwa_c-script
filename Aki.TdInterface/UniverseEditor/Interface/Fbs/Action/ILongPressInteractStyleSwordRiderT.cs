using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007173 RID: 29043
	public class ILongPressInteractStyleSwordRiderT
	{
		// Token: 0x1700D496 RID: 54422
		// (get) Token: 0x060327A4 RID: 206756 RVA: 0x006D27BA File Offset: 0x006D09BA
		// (set) Token: 0x060327A5 RID: 206757 RVA: 0x006D27C2 File Offset: 0x006D09C2
		public ELongPressInteractStyle Type { get; set; }

		// Token: 0x060327A6 RID: 206758 RVA: 0x006D27CB File Offset: 0x006D09CB
		public ILongPressInteractStyleSwordRiderT()
		{
			this.Type = ELongPressInteractStyle.Default;
		}
	}
}

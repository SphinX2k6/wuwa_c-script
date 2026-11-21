using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007164 RID: 29028
	public class ILongPressInteractStyleConfigT
	{
		// Token: 0x1700D482 RID: 54402
		// (get) Token: 0x0603273C RID: 206652 RVA: 0x006D1E2A File Offset: 0x006D002A
		// (set) Token: 0x0603273D RID: 206653 RVA: 0x006D1E32 File Offset: 0x006D0032
		public ELongPressInteractStyle Type { get; set; }

		// Token: 0x0603273E RID: 206654 RVA: 0x006D1E3B File Offset: 0x006D003B
		public ILongPressInteractStyleConfigT()
		{
			this.Type = ELongPressInteractStyle.Default;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007170 RID: 29040
	public class ILongPressInteractStyleCoreFixT
	{
		// Token: 0x1700D493 RID: 54419
		// (get) Token: 0x06032792 RID: 206738 RVA: 0x006D2642 File Offset: 0x006D0842
		// (set) Token: 0x06032793 RID: 206739 RVA: 0x006D264A File Offset: 0x006D084A
		public ELongPressInteractStyle Type { get; set; }

		// Token: 0x06032794 RID: 206740 RVA: 0x006D2653 File Offset: 0x006D0853
		public ILongPressInteractStyleCoreFixT()
		{
			this.Type = ELongPressInteractStyle.Default;
		}
	}
}

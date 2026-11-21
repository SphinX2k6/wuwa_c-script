using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007167 RID: 29031
	public class ILongPressInteractStyleConfigDefaultT
	{
		// Token: 0x1700D485 RID: 54405
		// (get) Token: 0x0603274E RID: 206670 RVA: 0x006D1FA2 File Offset: 0x006D01A2
		// (set) Token: 0x0603274F RID: 206671 RVA: 0x006D1FAA File Offset: 0x006D01AA
		public ELongPressInteractStyle Type { get; set; }

		// Token: 0x06032750 RID: 206672 RVA: 0x006D1FB3 File Offset: 0x006D01B3
		public ILongPressInteractStyleConfigDefaultT()
		{
			this.Type = ELongPressInteractStyle.Default;
		}
	}
}

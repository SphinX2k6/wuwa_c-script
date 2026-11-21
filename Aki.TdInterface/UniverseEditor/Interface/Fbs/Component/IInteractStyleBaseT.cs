using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059FD RID: 23037
	public class IInteractStyleBaseT
	{
		// Token: 0x1700A762 RID: 42850
		// (get) Token: 0x060259DB RID: 154075 RVA: 0x00528496 File Offset: 0x00526696
		// (set) Token: 0x060259DC RID: 154076 RVA: 0x0052849E File Offset: 0x0052669E
		public EInteractStyleType Type { get; set; }

		// Token: 0x060259DD RID: 154077 RVA: 0x005284A7 File Offset: 0x005266A7
		public IInteractStyleBaseT()
		{
			this.Type = EInteractStyleType.Panorama;
		}
	}
}

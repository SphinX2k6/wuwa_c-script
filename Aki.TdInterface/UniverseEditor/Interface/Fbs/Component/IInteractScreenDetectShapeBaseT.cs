using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200546B RID: 21611
	public class IInteractScreenDetectShapeBaseT
	{
		// Token: 0x17009F19 RID: 40729
		// (get) Token: 0x060238D9 RID: 145625 RVA: 0x004EAD7E File Offset: 0x004E8F7E
		// (set) Token: 0x060238DA RID: 145626 RVA: 0x004EAD86 File Offset: 0x004E8F86
		public EInteractScreenDetectShape Type { get; set; }

		// Token: 0x060238DB RID: 145627 RVA: 0x004EAD8F File Offset: 0x004E8F8F
		public IInteractScreenDetectShapeBaseT()
		{
			this.Type = EInteractScreenDetectShape.Circle;
		}
	}
}

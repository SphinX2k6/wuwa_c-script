using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E3 RID: 21475
	public class IAttachTargetT
	{
		// Token: 0x170097F7 RID: 38903
		// (get) Token: 0x060218D7 RID: 137431 RVA: 0x004A05C6 File Offset: 0x0049E7C6
		// (set) Token: 0x060218D8 RID: 137432 RVA: 0x004A05CE File Offset: 0x0049E7CE
		public EAttachType Type { get; set; }

		// Token: 0x060218D9 RID: 137433 RVA: 0x004A05D7 File Offset: 0x0049E7D7
		public IAttachTargetT()
		{
			this.Type = EAttachType.Actor;
		}
	}
}

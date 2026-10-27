using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200502B RID: 20523
	public class IConveyorBeltComponentT
	{
		// Token: 0x170094F8 RID: 38136
		// (get) Token: 0x06020E25 RID: 134693 RVA: 0x00492BA5 File Offset: 0x00490DA5
		// (set) Token: 0x06020E26 RID: 134694 RVA: 0x00492BAD File Offset: 0x00490DAD
		public bool Disabled { get; set; }

		// Token: 0x170094F9 RID: 38137
		// (get) Token: 0x06020E27 RID: 134695 RVA: 0x00492BB6 File Offset: 0x00490DB6
		// (set) Token: 0x06020E28 RID: 134696 RVA: 0x00492BBE File Offset: 0x00490DBE
		public List<IConveyorBeltStateT> StateGroups { get; set; }

		// Token: 0x170094FA RID: 38138
		// (get) Token: 0x06020E29 RID: 134697 RVA: 0x00492BC7 File Offset: 0x00490DC7
		// (set) Token: 0x06020E2A RID: 134698 RVA: 0x00492BCF File Offset: 0x00490DCF
		public byte NullMask { get; set; }

		// Token: 0x06020E2B RID: 134699 RVA: 0x00492BD8 File Offset: 0x00490DD8
		public IConveyorBeltComponentT()
		{
			this.Disabled = false;
			this.StateGroups = null;
			this.NullMask = 0;
		}
	}
}

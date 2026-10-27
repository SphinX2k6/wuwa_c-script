using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007005 RID: 28677
	public class ISetInteractionLockStateT
	{
		// Token: 0x1700D502 RID: 54530
		// (get) Token: 0x06032BAB RID: 207787 RVA: 0x006D84FE File Offset: 0x006D66FE
		// (set) Token: 0x06032BAC RID: 207788 RVA: 0x006D8506 File Offset: 0x006D6706
		public bool IsLock { get; set; }

		// Token: 0x06032BAD RID: 207789 RVA: 0x006D850F File Offset: 0x006D670F
		public ISetInteractionLockStateT()
		{
			this.IsLock = false;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200727A RID: 29306
	public class IMotorSoarInWindFieldT
	{
		// Token: 0x1700D6D3 RID: 54995
		// (get) Token: 0x06033112 RID: 209170 RVA: 0x006E4699 File Offset: 0x006E2899
		// (set) Token: 0x06033113 RID: 209171 RVA: 0x006E46A1 File Offset: 0x006E28A1
		public TMotorSoarInWindFieldControlTypeUnion ControlType { get; set; }

		// Token: 0x06033114 RID: 209172 RVA: 0x006E46AA File Offset: 0x006E28AA
		public IMotorSoarInWindFieldT()
		{
			this.ControlType = null;
		}
	}
}

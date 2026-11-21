using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200726E RID: 29294
	public class IMotorRadioOperationRestrictionT
	{
		// Token: 0x1700D6C6 RID: 54982
		// (get) Token: 0x060330BC RID: 209084 RVA: 0x006E3C62 File Offset: 0x006E1E62
		// (set) Token: 0x060330BD RID: 209085 RVA: 0x006E3C6A File Offset: 0x006E1E6A
		public EMotorRadioOperationType Type { get; set; }

		// Token: 0x060330BE RID: 209086 RVA: 0x006E3C73 File Offset: 0x006E1E73
		public IMotorRadioOperationRestrictionT()
		{
			this.Type = EMotorRadioOperationType.EnableAll;
		}
	}
}

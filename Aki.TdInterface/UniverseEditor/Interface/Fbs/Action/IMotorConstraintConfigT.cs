using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200724D RID: 29261
	public class IMotorConstraintConfigT
	{
		// Token: 0x1700D674 RID: 54900
		// (get) Token: 0x06032F74 RID: 208756 RVA: 0x006E15E7 File Offset: 0x006DF7E7
		// (set) Token: 0x06032F75 RID: 208757 RVA: 0x006E15EF File Offset: 0x006DF7EF
		public List<EPlayerInputConstraintType> DisableInput { get; set; }

		// Token: 0x1700D675 RID: 54901
		// (get) Token: 0x06032F76 RID: 208758 RVA: 0x006E15F8 File Offset: 0x006DF7F8
		// (set) Token: 0x06032F77 RID: 208759 RVA: 0x006E1600 File Offset: 0x006DF800
		public byte NullMask { get; set; }

		// Token: 0x06032F78 RID: 208760 RVA: 0x006E1609 File Offset: 0x006DF809
		public IMotorConstraintConfigT()
		{
			this.DisableInput = null;
			this.NullMask = 0;
		}
	}
}

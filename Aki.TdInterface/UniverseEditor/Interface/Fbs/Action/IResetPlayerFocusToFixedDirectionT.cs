using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E95 RID: 28309
	public class IResetPlayerFocusToFixedDirectionT
	{
		// Token: 0x1700D2CD RID: 53965
		// (get) Token: 0x06032093 RID: 204947 RVA: 0x006C477B File Offset: 0x006C297B
		// (set) Token: 0x06032094 RID: 204948 RVA: 0x006C4783 File Offset: 0x006C2983
		public EResetPlayerFocusType Type { get; set; }

		// Token: 0x1700D2CE RID: 53966
		// (get) Token: 0x06032095 RID: 204949 RVA: 0x006C478C File Offset: 0x006C298C
		// (set) Token: 0x06032096 RID: 204950 RVA: 0x006C4794 File Offset: 0x006C2994
		public IVectorInfoT Direction { get; set; }

		// Token: 0x06032097 RID: 204951 RVA: 0x006C479D File Offset: 0x006C299D
		public IResetPlayerFocusToFixedDirectionT()
		{
			this.Type = EResetPlayerFocusType.ResetToDefaultDirection;
			this.Direction = null;
		}
	}
}

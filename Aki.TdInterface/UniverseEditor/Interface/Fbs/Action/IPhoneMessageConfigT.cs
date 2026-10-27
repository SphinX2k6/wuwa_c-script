using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA6 RID: 27814
	public class IPhoneMessageConfigT
	{
		// Token: 0x1700CF1B RID: 53019
		// (get) Token: 0x06031043 RID: 200771 RVA: 0x006A740C File Offset: 0x006A560C
		// (set) Token: 0x06031044 RID: 200772 RVA: 0x006A7414 File Offset: 0x006A5614
		public bool IsJumpToFirstOption { get; set; }

		// Token: 0x1700CF1C RID: 53020
		// (get) Token: 0x06031045 RID: 200773 RVA: 0x006A741D File Offset: 0x006A561D
		// (set) Token: 0x06031046 RID: 200774 RVA: 0x006A7425 File Offset: 0x006A5625
		public byte NullMask { get; set; }

		// Token: 0x06031047 RID: 200775 RVA: 0x006A742E File Offset: 0x006A562E
		public IPhoneMessageConfigT()
		{
			this.IsJumpToFirstOption = false;
			this.NullMask = 0;
		}
	}
}

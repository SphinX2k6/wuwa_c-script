using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200671B RID: 26395
	public class IExitDungeonT
	{
		// Token: 0x1700C412 RID: 50194
		// (get) Token: 0x0602DE9D RID: 188061 RVA: 0x006470A8 File Offset: 0x006452A8
		// (set) Token: 0x0602DE9E RID: 188062 RVA: 0x006470B0 File Offset: 0x006452B0
		public bool IsNeedSecondaryConfirmation { get; set; }

		// Token: 0x1700C413 RID: 50195
		// (get) Token: 0x0602DE9F RID: 188063 RVA: 0x006470B9 File Offset: 0x006452B9
		// (set) Token: 0x0602DEA0 RID: 188064 RVA: 0x006470C1 File Offset: 0x006452C1
		public byte NullMask { get; set; }

		// Token: 0x0602DEA1 RID: 188065 RVA: 0x006470CA File Offset: 0x006452CA
		public IExitDungeonT()
		{
			this.IsNeedSecondaryConfirmation = false;
			this.NullMask = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200741C RID: 29724
	public class IPhoneMessageConfigT
	{
		// Token: 0x1700DA58 RID: 55896
		// (get) Token: 0x0603401A RID: 213018 RVA: 0x00702640 File Offset: 0x00700840
		// (set) Token: 0x0603401B RID: 213019 RVA: 0x00702648 File Offset: 0x00700848
		public bool IsJumpToFirstOption { get; set; }

		// Token: 0x1700DA59 RID: 55897
		// (get) Token: 0x0603401C RID: 213020 RVA: 0x00702651 File Offset: 0x00700851
		// (set) Token: 0x0603401D RID: 213021 RVA: 0x00702659 File Offset: 0x00700859
		public byte NullMask { get; set; }

		// Token: 0x0603401E RID: 213022 RVA: 0x00702662 File Offset: 0x00700862
		public IPhoneMessageConfigT()
		{
			this.IsJumpToFirstOption = false;
			this.NullMask = 0;
		}
	}
}

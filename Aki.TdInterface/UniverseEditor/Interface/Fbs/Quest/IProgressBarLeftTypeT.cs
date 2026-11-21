using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043FE RID: 17406
	public class IProgressBarLeftTypeT
	{
		// Token: 0x170077F3 RID: 30707
		// (get) Token: 0x06018BE5 RID: 101349 RVA: 0x00386BDA File Offset: 0x00384DDA
		// (set) Token: 0x06018BE6 RID: 101350 RVA: 0x00386BE2 File Offset: 0x00384DE2
		public EProgressBarLeftType Type { get; set; }

		// Token: 0x06018BE7 RID: 101351 RVA: 0x00386BEB File Offset: 0x00384DEB
		public IProgressBarLeftTypeT()
		{
			this.Type = EProgressBarLeftType.UseCount;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C2 RID: 30146
	public class IRemoveEffectT
	{
		// Token: 0x1700DDA3 RID: 56739
		// (get) Token: 0x06034E3A RID: 216634 RVA: 0x0071BB95 File Offset: 0x00719D95
		// (set) Token: 0x06034E3B RID: 216635 RVA: 0x0071BB9D File Offset: 0x00719D9D
		public IRemoveScreenEffectT RemoveEffectConfig { get; set; }

		// Token: 0x06034E3C RID: 216636 RVA: 0x0071BBA6 File Offset: 0x00719DA6
		public IRemoveEffectT()
		{
			this.RemoveEffectConfig = null;
		}
	}
}

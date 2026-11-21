using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007846 RID: 30790
	public class ISetSportsStateT
	{
		// Token: 0x1700E1DF RID: 57823
		// (get) Token: 0x06036259 RID: 221785 RVA: 0x00740DE1 File Offset: 0x0073EFE1
		// (set) Token: 0x0603625A RID: 221786 RVA: 0x00740DE9 File Offset: 0x0073EFE9
		public TSportStateUnion Config { get; set; }

		// Token: 0x0603625B RID: 221787 RVA: 0x00740DF2 File Offset: 0x0073EFF2
		public ISetSportsStateT()
		{
			this.Config = null;
		}
	}
}

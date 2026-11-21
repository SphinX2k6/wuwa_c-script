using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200747B RID: 29819
	public class IPlayerLookTowardsT
	{
		// Token: 0x1700DB13 RID: 56083
		// (get) Token: 0x06034344 RID: 213828 RVA: 0x007083C1 File Offset: 0x007065C1
		// (set) Token: 0x06034345 RID: 213829 RVA: 0x007083C9 File Offset: 0x007065C9
		public TCharacterLookAtDataUnion Target { get; set; }

		// Token: 0x06034346 RID: 213830 RVA: 0x007083D2 File Offset: 0x007065D2
		public IPlayerLookTowardsT()
		{
			this.Target = null;
		}
	}
}

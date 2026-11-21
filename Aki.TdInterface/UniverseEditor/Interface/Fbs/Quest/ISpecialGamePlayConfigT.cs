using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004578 RID: 17784
	public class ISpecialGamePlayConfigT
	{
		// Token: 0x17007C49 RID: 31817
		// (get) Token: 0x06019E6F RID: 106095 RVA: 0x003B1B92 File Offset: 0x003AFD92
		// (set) Token: 0x06019E70 RID: 106096 RVA: 0x003B1B9A File Offset: 0x003AFD9A
		public ESpecialGamePlayConfigType Type { get; set; }

		// Token: 0x06019E71 RID: 106097 RVA: 0x003B1BA3 File Offset: 0x003AFDA3
		public ISpecialGamePlayConfigT()
		{
			this.Type = ESpecialGamePlayConfigType.Stalking;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005193 RID: 20883
	public class IEntityMatchAllCharacterT
	{
		// Token: 0x17009898 RID: 39064
		// (get) Token: 0x06021C8B RID: 138379 RVA: 0x004AFEAE File Offset: 0x004AE0AE
		// (set) Token: 0x06021C8C RID: 138380 RVA: 0x004AFEB6 File Offset: 0x004AE0B6
		public EEntityMatchType Type { get; set; }

		// Token: 0x06021C8D RID: 138381 RVA: 0x004AFEBF File Offset: 0x004AE0BF
		public IEntityMatchAllCharacterT()
		{
			this.Type = EEntityMatchType.Player;
		}
	}
}

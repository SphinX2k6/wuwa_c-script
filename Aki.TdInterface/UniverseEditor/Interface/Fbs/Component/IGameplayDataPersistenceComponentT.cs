using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052E6 RID: 21222
	public class IGameplayDataPersistenceComponentT
	{
		// Token: 0x17009BC5 RID: 39877
		// (get) Token: 0x06022A57 RID: 141911 RVA: 0x004CD621 File Offset: 0x004CB821
		// (set) Token: 0x06022A58 RID: 141912 RVA: 0x004CD629 File Offset: 0x004CB829
		public bool Disabled { get; set; }

		// Token: 0x17009BC6 RID: 39878
		// (get) Token: 0x06022A59 RID: 141913 RVA: 0x004CD632 File Offset: 0x004CB832
		// (set) Token: 0x06022A5A RID: 141914 RVA: 0x004CD63A File Offset: 0x004CB83A
		public IGameplayDataPersistenceTetrisBoardGameT DataPersistenceGameplay { get; set; }

		// Token: 0x17009BC7 RID: 39879
		// (get) Token: 0x06022A5B RID: 141915 RVA: 0x004CD643 File Offset: 0x004CB843
		// (set) Token: 0x06022A5C RID: 141916 RVA: 0x004CD64B File Offset: 0x004CB84B
		public byte NullMask { get; set; }

		// Token: 0x06022A5D RID: 141917 RVA: 0x004CD654 File Offset: 0x004CB854
		public IGameplayDataPersistenceComponentT()
		{
			this.Disabled = false;
			this.DataPersistenceGameplay = null;
			this.NullMask = 0;
		}
	}
}

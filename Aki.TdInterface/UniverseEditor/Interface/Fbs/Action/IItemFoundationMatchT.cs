using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200706B RID: 28779
	public class IItemFoundationMatchT
	{
		// Token: 0x1700D2C6 RID: 53958
		// (get) Token: 0x06031E7F RID: 204415 RVA: 0x006C138E File Offset: 0x006BF58E
		// (set) Token: 0x06031E80 RID: 204416 RVA: 0x006C1396 File Offset: 0x006BF596
		public int MatchEntityId { get; set; }

		// Token: 0x06031E81 RID: 204417 RVA: 0x006C139F File Offset: 0x006BF59F
		public IItemFoundationMatchT()
		{
			this.MatchEntityId = 0;
		}
	}
}

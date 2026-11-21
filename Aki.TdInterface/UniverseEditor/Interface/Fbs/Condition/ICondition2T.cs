using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050C5 RID: 20677
	public class ICondition2T
	{
		// Token: 0x17009436 RID: 37942
		// (get) Token: 0x06020661 RID: 132705 RVA: 0x0047CA56 File Offset: 0x0047AC56
		// (set) Token: 0x06020662 RID: 132706 RVA: 0x0047CA5E File Offset: 0x0047AC5E
		public ECondition Type { get; set; }

		// Token: 0x06020663 RID: 132707 RVA: 0x0047CA67 File Offset: 0x0047AC67
		public ICondition2T()
		{
			this.Type = ECondition.CompareVar;
		}
	}
}

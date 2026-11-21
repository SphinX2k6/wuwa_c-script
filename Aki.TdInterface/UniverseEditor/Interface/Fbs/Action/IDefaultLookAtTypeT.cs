using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BCA RID: 27594
	public class IDefaultLookAtTypeT
	{
		// Token: 0x1700CA74 RID: 51828
		// (get) Token: 0x0602F808 RID: 194568 RVA: 0x0067A3A2 File Offset: 0x006785A2
		// (set) Token: 0x0602F809 RID: 194569 RVA: 0x0067A3AA File Offset: 0x006785AA
		public EDefaultLookAtType Type { get; set; }

		// Token: 0x0602F80A RID: 194570 RVA: 0x0067A3B3 File Offset: 0x006785B3
		public IDefaultLookAtTypeT()
		{
			this.Type = EDefaultLookAtType.LookAtBubbleEntity;
		}
	}
}

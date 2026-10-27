using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A82 RID: 19074
	public class ICheckIsCharacterHoldingHandsT
	{
		// Token: 0x17008A2F RID: 35375
		// (get) Token: 0x0601DE8E RID: 122510 RVA: 0x00433729 File Offset: 0x00431929
		// (set) Token: 0x0601DE8F RID: 122511 RVA: 0x00433731 File Offset: 0x00431931
		public ECondition Type { get; set; }

		// Token: 0x17008A30 RID: 35376
		// (get) Token: 0x0601DE90 RID: 122512 RVA: 0x0043373A File Offset: 0x0043193A
		// (set) Token: 0x0601DE91 RID: 122513 RVA: 0x00433742 File Offset: 0x00431942
		public TCheckHoldingHandsCharacterUnion Target { get; set; }

		// Token: 0x17008A31 RID: 35377
		// (get) Token: 0x0601DE92 RID: 122514 RVA: 0x0043374B File Offset: 0x0043194B
		// (set) Token: 0x0601DE93 RID: 122515 RVA: 0x00433753 File Offset: 0x00431953
		public bool IsHoldingHands { get; set; }

		// Token: 0x0601DE94 RID: 122516 RVA: 0x0043375C File Offset: 0x0043195C
		public ICheckIsCharacterHoldingHandsT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.IsHoldingHands = false;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200508C RID: 20620
	public class ICompareFishingBoatStateT
	{
		// Token: 0x170093A2 RID: 37794
		// (get) Token: 0x06020428 RID: 132136 RVA: 0x004785E0 File Offset: 0x004767E0
		// (set) Token: 0x06020429 RID: 132137 RVA: 0x004785E8 File Offset: 0x004767E8
		public ECondition Type { get; set; }

		// Token: 0x170093A3 RID: 37795
		// (get) Token: 0x0602042A RID: 132138 RVA: 0x004785F1 File Offset: 0x004767F1
		// (set) Token: 0x0602042B RID: 132139 RVA: 0x004785F9 File Offset: 0x004767F9
		public bool IsStop { get; set; }

		// Token: 0x170093A4 RID: 37796
		// (get) Token: 0x0602042C RID: 132140 RVA: 0x00478602 File Offset: 0x00476802
		// (set) Token: 0x0602042D RID: 132141 RVA: 0x0047860A File Offset: 0x0047680A
		public int FishingPort { get; set; }

		// Token: 0x170093A5 RID: 37797
		// (get) Token: 0x0602042E RID: 132142 RVA: 0x00478613 File Offset: 0x00476813
		// (set) Token: 0x0602042F RID: 132143 RVA: 0x0047861B File Offset: 0x0047681B
		public byte NullMask { get; set; }

		// Token: 0x06020430 RID: 132144 RVA: 0x00478624 File Offset: 0x00476824
		public ICompareFishingBoatStateT()
		{
			this.Type = ECondition.CompareVar;
			this.IsStop = false;
			this.FishingPort = 0;
			this.NullMask = 0;
		}
	}
}

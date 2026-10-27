using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AB5 RID: 15029
	public class IPosAndRotT
	{
		// Token: 0x17006717 RID: 26391
		// (get) Token: 0x060146E8 RID: 83688 RVA: 0x002FA6EA File Offset: 0x002F88EA
		// (set) Token: 0x060146E9 RID: 83689 RVA: 0x002FA6F2 File Offset: 0x002F88F2
		public float X { get; set; }

		// Token: 0x17006718 RID: 26392
		// (get) Token: 0x060146EA RID: 83690 RVA: 0x002FA6FB File Offset: 0x002F88FB
		// (set) Token: 0x060146EB RID: 83691 RVA: 0x002FA703 File Offset: 0x002F8903
		public float Y { get; set; }

		// Token: 0x17006719 RID: 26393
		// (get) Token: 0x060146EC RID: 83692 RVA: 0x002FA70C File Offset: 0x002F890C
		// (set) Token: 0x060146ED RID: 83693 RVA: 0x002FA714 File Offset: 0x002F8914
		public float Z { get; set; }

		// Token: 0x1700671A RID: 26394
		// (get) Token: 0x060146EE RID: 83694 RVA: 0x002FA71D File Offset: 0x002F891D
		// (set) Token: 0x060146EF RID: 83695 RVA: 0x002FA725 File Offset: 0x002F8925
		public float A { get; set; }

		// Token: 0x1700671B RID: 26395
		// (get) Token: 0x060146F0 RID: 83696 RVA: 0x002FA72E File Offset: 0x002F892E
		// (set) Token: 0x060146F1 RID: 83697 RVA: 0x002FA736 File Offset: 0x002F8936
		public float Roll { get; set; }

		// Token: 0x1700671C RID: 26396
		// (get) Token: 0x060146F2 RID: 83698 RVA: 0x002FA73F File Offset: 0x002F893F
		// (set) Token: 0x060146F3 RID: 83699 RVA: 0x002FA747 File Offset: 0x002F8947
		public float Pitch { get; set; }

		// Token: 0x1700671D RID: 26397
		// (get) Token: 0x060146F4 RID: 83700 RVA: 0x002FA750 File Offset: 0x002F8950
		// (set) Token: 0x060146F5 RID: 83701 RVA: 0x002FA758 File Offset: 0x002F8958
		public byte NullMask { get; set; }

		// Token: 0x060146F6 RID: 83702 RVA: 0x002FA764 File Offset: 0x002F8964
		public IPosAndRotT()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.A = 0f;
			this.Roll = 0f;
			this.Pitch = 0f;
			this.NullMask = 0;
		}
	}
}

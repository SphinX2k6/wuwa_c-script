using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004807 RID: 18439
	public class INodeRefOccupationDataT
	{
		// Token: 0x1700809D RID: 32925
		// (get) Token: 0x0601B40E RID: 111630 RVA: 0x003DC891 File Offset: 0x003DAA91
		// (set) Token: 0x0601B40F RID: 111631 RVA: 0x003DC899 File Offset: 0x003DAA99
		public TNodeRefTiming NodeRefTiming { get; set; }

		// Token: 0x1700809E RID: 32926
		// (get) Token: 0x0601B410 RID: 111632 RVA: 0x003DC8A2 File Offset: 0x003DAAA2
		// (set) Token: 0x0601B411 RID: 111633 RVA: 0x003DC8AA File Offset: 0x003DAAAA
		public TRefType RefType { get; set; }

		// Token: 0x1700809F RID: 32927
		// (get) Token: 0x0601B412 RID: 111634 RVA: 0x003DC8B3 File Offset: 0x003DAAB3
		// (set) Token: 0x0601B413 RID: 111635 RVA: 0x003DC8BB File Offset: 0x003DAABB
		public TRefSourceDataUnion RefSource { get; set; }

		// Token: 0x170080A0 RID: 32928
		// (get) Token: 0x0601B414 RID: 111636 RVA: 0x003DC8C4 File Offset: 0x003DAAC4
		// (set) Token: 0x0601B415 RID: 111637 RVA: 0x003DC8CC File Offset: 0x003DAACC
		public string Occupation { get; set; }

		// Token: 0x170080A1 RID: 32929
		// (get) Token: 0x0601B416 RID: 111638 RVA: 0x003DC8D5 File Offset: 0x003DAAD5
		// (set) Token: 0x0601B417 RID: 111639 RVA: 0x003DC8DD File Offset: 0x003DAADD
		public byte NullMask { get; set; }

		// Token: 0x0601B418 RID: 111640 RVA: 0x003DC8E6 File Offset: 0x003DAAE6
		public INodeRefOccupationDataT()
		{
			this.NodeRefTiming = TNodeRefTiming.Enter;
			this.RefType = TRefType.Release;
			this.RefSource = null;
			this.Occupation = null;
			this.NullMask = 0;
		}
	}
}

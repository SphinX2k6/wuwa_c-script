using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043A5 RID: 17317
	public class INodeRefOccupationDataT
	{
		// Token: 0x17007A68 RID: 31336
		// (get) Token: 0x06019C80 RID: 105600 RVA: 0x003B0E69 File Offset: 0x003AF069
		// (set) Token: 0x06019C81 RID: 105601 RVA: 0x003B0E71 File Offset: 0x003AF071
		public TNodeRefTiming NodeRefTiming { get; set; }

		// Token: 0x17007A69 RID: 31337
		// (get) Token: 0x06019C82 RID: 105602 RVA: 0x003B0E7A File Offset: 0x003AF07A
		// (set) Token: 0x06019C83 RID: 105603 RVA: 0x003B0E82 File Offset: 0x003AF082
		public TRefType RefType { get; set; }

		// Token: 0x17007A6A RID: 31338
		// (get) Token: 0x06019C84 RID: 105604 RVA: 0x003B0E8B File Offset: 0x003AF08B
		// (set) Token: 0x06019C85 RID: 105605 RVA: 0x003B0E93 File Offset: 0x003AF093
		public TRefSourceDataUnion RefSource { get; set; }

		// Token: 0x17007A6B RID: 31339
		// (get) Token: 0x06019C86 RID: 105606 RVA: 0x003B0E9C File Offset: 0x003AF09C
		// (set) Token: 0x06019C87 RID: 105607 RVA: 0x003B0EA4 File Offset: 0x003AF0A4
		public string Occupation { get; set; }

		// Token: 0x17007A6C RID: 31340
		// (get) Token: 0x06019C88 RID: 105608 RVA: 0x003B0EAD File Offset: 0x003AF0AD
		// (set) Token: 0x06019C89 RID: 105609 RVA: 0x003B0EB5 File Offset: 0x003AF0B5
		public byte NullMask { get; set; }

		// Token: 0x06019C8A RID: 105610 RVA: 0x003B0EBE File Offset: 0x003AF0BE
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

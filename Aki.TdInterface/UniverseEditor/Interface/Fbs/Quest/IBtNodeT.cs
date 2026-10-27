using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D3B RID: 15675
	public class IBtNodeT
	{
		// Token: 0x17006B86 RID: 27526
		// (get) Token: 0x06015A75 RID: 88693 RVA: 0x00320059 File Offset: 0x0031E259
		// (set) Token: 0x06015A76 RID: 88694 RVA: 0x00320061 File Offset: 0x0031E261
		public EBtNode Type { get; set; }

		// Token: 0x17006B87 RID: 27527
		// (get) Token: 0x06015A77 RID: 88695 RVA: 0x0032006A File Offset: 0x0031E26A
		// (set) Token: 0x06015A78 RID: 88696 RVA: 0x00320072 File Offset: 0x0031E272
		public int Id { get; set; }

		// Token: 0x17006B88 RID: 27528
		// (get) Token: 0x06015A79 RID: 88697 RVA: 0x0032007B File Offset: 0x0031E27B
		// (set) Token: 0x06015A7A RID: 88698 RVA: 0x00320083 File Offset: 0x0031E283
		public string Desc { get; set; }

		// Token: 0x17006B89 RID: 27529
		// (get) Token: 0x06015A7B RID: 88699 RVA: 0x0032008C File Offset: 0x0031E28C
		// (set) Token: 0x06015A7C RID: 88700 RVA: 0x00320094 File Offset: 0x0031E294
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17006B8A RID: 27530
		// (get) Token: 0x06015A7D RID: 88701 RVA: 0x0032009D File Offset: 0x0031E29D
		// (set) Token: 0x06015A7E RID: 88702 RVA: 0x003200A5 File Offset: 0x0031E2A5
		public bool _FoldedForTree { get; set; }

		// Token: 0x17006B8B RID: 27531
		// (get) Token: 0x06015A7F RID: 88703 RVA: 0x003200AE File Offset: 0x0031E2AE
		// (set) Token: 0x06015A80 RID: 88704 RVA: 0x003200B6 File Offset: 0x0031E2B6
		public bool Disabled { get; set; }

		// Token: 0x17006B8C RID: 27532
		// (get) Token: 0x06015A81 RID: 88705 RVA: 0x003200BF File Offset: 0x0031E2BF
		// (set) Token: 0x06015A82 RID: 88706 RVA: 0x003200C7 File Offset: 0x0031E2C7
		public byte NullMask { get; set; }

		// Token: 0x06015A83 RID: 88707 RVA: 0x003200D0 File Offset: 0x0031E2D0
		public IBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}

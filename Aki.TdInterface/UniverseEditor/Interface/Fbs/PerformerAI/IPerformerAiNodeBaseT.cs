using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200436D RID: 17261
	public class IPerformerAiNodeBaseT
	{
		// Token: 0x170079D2 RID: 31186
		// (get) Token: 0x060199BE RID: 104894 RVA: 0x003AA4D7 File Offset: 0x003A86D7
		// (set) Token: 0x060199BF RID: 104895 RVA: 0x003AA4DF File Offset: 0x003A86DF
		public EPerformerAiNodeType Type { get; set; }

		// Token: 0x170079D3 RID: 31187
		// (get) Token: 0x060199C0 RID: 104896 RVA: 0x003AA4E8 File Offset: 0x003A86E8
		// (set) Token: 0x060199C1 RID: 104897 RVA: 0x003AA4F0 File Offset: 0x003A86F0
		public int Id { get; set; }

		// Token: 0x170079D4 RID: 31188
		// (get) Token: 0x060199C2 RID: 104898 RVA: 0x003AA4F9 File Offset: 0x003A86F9
		// (set) Token: 0x060199C3 RID: 104899 RVA: 0x003AA501 File Offset: 0x003A8701
		public string Desc { get; set; }

		// Token: 0x170079D5 RID: 31189
		// (get) Token: 0x060199C4 RID: 104900 RVA: 0x003AA50A File Offset: 0x003A870A
		// (set) Token: 0x060199C5 RID: 104901 RVA: 0x003AA512 File Offset: 0x003A8712
		public List<TPerformerAiDecoratorUnion> Decorators { get; set; }

		// Token: 0x170079D6 RID: 31190
		// (get) Token: 0x060199C6 RID: 104902 RVA: 0x003AA51B File Offset: 0x003A871B
		// (set) Token: 0x060199C7 RID: 104903 RVA: 0x003AA523 File Offset: 0x003A8723
		public bool _FoldedForTree { get; set; }

		// Token: 0x170079D7 RID: 31191
		// (get) Token: 0x060199C8 RID: 104904 RVA: 0x003AA52C File Offset: 0x003A872C
		// (set) Token: 0x060199C9 RID: 104905 RVA: 0x003AA534 File Offset: 0x003A8734
		public byte NullMask { get; set; }

		// Token: 0x060199CA RID: 104906 RVA: 0x003AA53D File Offset: 0x003A873D
		public IPerformerAiNodeBaseT()
		{
			this.Type = EPerformerAiNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.NullMask = 0;
		}
	}
}

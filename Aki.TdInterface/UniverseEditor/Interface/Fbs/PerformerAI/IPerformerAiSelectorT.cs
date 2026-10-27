using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004376 RID: 17270
	public class IPerformerAiSelectorT
	{
		// Token: 0x170079F7 RID: 31223
		// (get) Token: 0x06019A74 RID: 105076 RVA: 0x003AC4AF File Offset: 0x003AA6AF
		// (set) Token: 0x06019A75 RID: 105077 RVA: 0x003AC4B7 File Offset: 0x003AA6B7
		public EPerformerAiNodeType Type { get; set; }

		// Token: 0x170079F8 RID: 31224
		// (get) Token: 0x06019A76 RID: 105078 RVA: 0x003AC4C0 File Offset: 0x003AA6C0
		// (set) Token: 0x06019A77 RID: 105079 RVA: 0x003AC4C8 File Offset: 0x003AA6C8
		public int Id { get; set; }

		// Token: 0x170079F9 RID: 31225
		// (get) Token: 0x06019A78 RID: 105080 RVA: 0x003AC4D1 File Offset: 0x003AA6D1
		// (set) Token: 0x06019A79 RID: 105081 RVA: 0x003AC4D9 File Offset: 0x003AA6D9
		public string Desc { get; set; }

		// Token: 0x170079FA RID: 31226
		// (get) Token: 0x06019A7A RID: 105082 RVA: 0x003AC4E2 File Offset: 0x003AA6E2
		// (set) Token: 0x06019A7B RID: 105083 RVA: 0x003AC4EA File Offset: 0x003AA6EA
		public List<TPerformerAiDecoratorUnion> Decorators { get; set; }

		// Token: 0x170079FB RID: 31227
		// (get) Token: 0x06019A7C RID: 105084 RVA: 0x003AC4F3 File Offset: 0x003AA6F3
		// (set) Token: 0x06019A7D RID: 105085 RVA: 0x003AC4FB File Offset: 0x003AA6FB
		public bool _FoldedForTree { get; set; }

		// Token: 0x170079FC RID: 31228
		// (get) Token: 0x06019A7E RID: 105086 RVA: 0x003AC504 File Offset: 0x003AA704
		// (set) Token: 0x06019A7F RID: 105087 RVA: 0x003AC50C File Offset: 0x003AA70C
		public List<TPerformerAiNodeUnion> Children { get; set; }

		// Token: 0x170079FD RID: 31229
		// (get) Token: 0x06019A80 RID: 105088 RVA: 0x003AC515 File Offset: 0x003AA715
		// (set) Token: 0x06019A81 RID: 105089 RVA: 0x003AC51D File Offset: 0x003AA71D
		public byte NullMask { get; set; }

		// Token: 0x06019A82 RID: 105090 RVA: 0x003AC526 File Offset: 0x003AA726
		public IPerformerAiSelectorT()
		{
			this.Type = EPerformerAiNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.Children = null;
			this.NullMask = 0;
		}
	}
}

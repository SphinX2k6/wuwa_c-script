using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004590 RID: 17808
	public class ISubBehaviorTreeFileT
	{
		// Token: 0x17007C83 RID: 31875
		// (get) Token: 0x06019F80 RID: 106368 RVA: 0x003B438C File Offset: 0x003B258C
		// (set) Token: 0x06019F81 RID: 106369 RVA: 0x003B4394 File Offset: 0x003B2594
		public int Id { get; set; }

		// Token: 0x17007C84 RID: 31876
		// (get) Token: 0x06019F82 RID: 106370 RVA: 0x003B439D File Offset: 0x003B259D
		// (set) Token: 0x06019F83 RID: 106371 RVA: 0x003B43A5 File Offset: 0x003B25A5
		public string ParentUid { get; set; }

		// Token: 0x17007C85 RID: 31877
		// (get) Token: 0x06019F84 RID: 106372 RVA: 0x003B43AE File Offset: 0x003B25AE
		// (set) Token: 0x06019F85 RID: 106373 RVA: 0x003B43B6 File Offset: 0x003B25B6
		public IBehaviorTreeT Tree { get; set; }

		// Token: 0x17007C86 RID: 31878
		// (get) Token: 0x06019F86 RID: 106374 RVA: 0x003B43BF File Offset: 0x003B25BF
		// (set) Token: 0x06019F87 RID: 106375 RVA: 0x003B43C7 File Offset: 0x003B25C7
		public List<string> Children { get; set; }

		// Token: 0x17007C87 RID: 31879
		// (get) Token: 0x06019F88 RID: 106376 RVA: 0x003B43D0 File Offset: 0x003B25D0
		// (set) Token: 0x06019F89 RID: 106377 RVA: 0x003B43D8 File Offset: 0x003B25D8
		public List<string> Reference { get; set; }

		// Token: 0x17007C88 RID: 31880
		// (get) Token: 0x06019F8A RID: 106378 RVA: 0x003B43E1 File Offset: 0x003B25E1
		// (set) Token: 0x06019F8B RID: 106379 RVA: 0x003B43E9 File Offset: 0x003B25E9
		public List<string> WeakReference { get; set; }

		// Token: 0x17007C89 RID: 31881
		// (get) Token: 0x06019F8C RID: 106380 RVA: 0x003B43F2 File Offset: 0x003B25F2
		// (set) Token: 0x06019F8D RID: 106381 RVA: 0x003B43FA File Offset: 0x003B25FA
		public string _Name { get; set; }

		// Token: 0x17007C8A RID: 31882
		// (get) Token: 0x06019F8E RID: 106382 RVA: 0x003B4403 File Offset: 0x003B2603
		// (set) Token: 0x06019F8F RID: 106383 RVA: 0x003B440B File Offset: 0x003B260B
		public string _Path { get; set; }

		// Token: 0x17007C8B RID: 31883
		// (get) Token: 0x06019F90 RID: 106384 RVA: 0x003B4414 File Offset: 0x003B2614
		// (set) Token: 0x06019F91 RID: 106385 RVA: 0x003B441C File Offset: 0x003B261C
		public byte NullMask { get; set; }

		// Token: 0x06019F92 RID: 106386 RVA: 0x003B4428 File Offset: 0x003B2628
		public ISubBehaviorTreeFileT()
		{
			this.Id = 0;
			this.ParentUid = null;
			this.Tree = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this._Name = null;
			this._Path = null;
			this.NullMask = 0;
		}
	}
}

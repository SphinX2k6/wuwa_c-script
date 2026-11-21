using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044A3 RID: 17571
	public class IQuestSucceedBtNodeT
	{
		// Token: 0x17007A1D RID: 31261
		// (get) Token: 0x06019540 RID: 103744 RVA: 0x0039D901 File Offset: 0x0039BB01
		// (set) Token: 0x06019541 RID: 103745 RVA: 0x0039D909 File Offset: 0x0039BB09
		public EBtNode Type { get; set; }

		// Token: 0x17007A1E RID: 31262
		// (get) Token: 0x06019542 RID: 103746 RVA: 0x0039D912 File Offset: 0x0039BB12
		// (set) Token: 0x06019543 RID: 103747 RVA: 0x0039D91A File Offset: 0x0039BB1A
		public int Id { get; set; }

		// Token: 0x17007A1F RID: 31263
		// (get) Token: 0x06019544 RID: 103748 RVA: 0x0039D923 File Offset: 0x0039BB23
		// (set) Token: 0x06019545 RID: 103749 RVA: 0x0039D92B File Offset: 0x0039BB2B
		public string Desc { get; set; }

		// Token: 0x17007A20 RID: 31264
		// (get) Token: 0x06019546 RID: 103750 RVA: 0x0039D934 File Offset: 0x0039BB34
		// (set) Token: 0x06019547 RID: 103751 RVA: 0x0039D93C File Offset: 0x0039BB3C
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007A21 RID: 31265
		// (get) Token: 0x06019548 RID: 103752 RVA: 0x0039D945 File Offset: 0x0039BB45
		// (set) Token: 0x06019549 RID: 103753 RVA: 0x0039D94D File Offset: 0x0039BB4D
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007A22 RID: 31266
		// (get) Token: 0x0601954A RID: 103754 RVA: 0x0039D956 File Offset: 0x0039BB56
		// (set) Token: 0x0601954B RID: 103755 RVA: 0x0039D95E File Offset: 0x0039BB5E
		public bool Disabled { get; set; }

		// Token: 0x17007A23 RID: 31267
		// (get) Token: 0x0601954C RID: 103756 RVA: 0x0039D967 File Offset: 0x0039BB67
		// (set) Token: 0x0601954D RID: 103757 RVA: 0x0039D96F File Offset: 0x0039BB6F
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17007A24 RID: 31268
		// (get) Token: 0x0601954E RID: 103758 RVA: 0x0039D978 File Offset: 0x0039BB78
		// (set) Token: 0x0601954F RID: 103759 RVA: 0x0039D980 File Offset: 0x0039BB80
		public byte NullMask { get; set; }

		// Token: 0x06019550 RID: 103760 RVA: 0x0039D989 File Offset: 0x0039BB89
		public IQuestSucceedBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.FinishActions = null;
			this.NullMask = 0;
		}
	}
}

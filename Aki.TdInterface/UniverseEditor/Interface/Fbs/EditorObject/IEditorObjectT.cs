using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.EditorObject
{
	// Token: 0x02004D5F RID: 19807
	public class IEditorObjectT
	{
		// Token: 0x17008DC8 RID: 36296
		// (get) Token: 0x0601EB47 RID: 125767 RVA: 0x0044BA21 File Offset: 0x00449C21
		// (set) Token: 0x0601EB48 RID: 125768 RVA: 0x0044BA29 File Offset: 0x00449C29
		public TEditorObjectType ObjType { get; set; }

		// Token: 0x17008DC9 RID: 36297
		// (get) Token: 0x0601EB49 RID: 125769 RVA: 0x0044BA32 File Offset: 0x00449C32
		// (set) Token: 0x0601EB4A RID: 125770 RVA: 0x0044BA3A File Offset: 0x00449C3A
		public List<string> Children { get; set; }

		// Token: 0x17008DCA RID: 36298
		// (get) Token: 0x0601EB4B RID: 125771 RVA: 0x0044BA43 File Offset: 0x00449C43
		// (set) Token: 0x0601EB4C RID: 125772 RVA: 0x0044BA4B File Offset: 0x00449C4B
		public List<string> Reference { get; set; }

		// Token: 0x17008DCB RID: 36299
		// (get) Token: 0x0601EB4D RID: 125773 RVA: 0x0044BA54 File Offset: 0x00449C54
		// (set) Token: 0x0601EB4E RID: 125774 RVA: 0x0044BA5C File Offset: 0x00449C5C
		public List<string> WeakReference { get; set; }

		// Token: 0x17008DCC RID: 36300
		// (get) Token: 0x0601EB4F RID: 125775 RVA: 0x0044BA65 File Offset: 0x00449C65
		// (set) Token: 0x0601EB50 RID: 125776 RVA: 0x0044BA6D File Offset: 0x00449C6D
		public byte NullMask { get; set; }

		// Token: 0x0601EB51 RID: 125777 RVA: 0x0044BA76 File Offset: 0x00449C76
		public IEditorObjectT()
		{
			this.ObjType = TEditorObjectType.BehaviorTreeFragment;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.NullMask = 0;
		}
	}
}

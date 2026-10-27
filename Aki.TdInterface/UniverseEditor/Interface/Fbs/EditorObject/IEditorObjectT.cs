using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.EditorObject
{
	// Token: 0x020048FA RID: 18682
	public class IEditorObjectT
	{
		// Token: 0x17008780 RID: 34688
		// (get) Token: 0x0601D35A RID: 119642 RVA: 0x0041F285 File Offset: 0x0041D485
		// (set) Token: 0x0601D35B RID: 119643 RVA: 0x0041F28D File Offset: 0x0041D48D
		public TEditorObjectType ObjType { get; set; }

		// Token: 0x17008781 RID: 34689
		// (get) Token: 0x0601D35C RID: 119644 RVA: 0x0041F296 File Offset: 0x0041D496
		// (set) Token: 0x0601D35D RID: 119645 RVA: 0x0041F29E File Offset: 0x0041D49E
		public List<string> Children { get; set; }

		// Token: 0x17008782 RID: 34690
		// (get) Token: 0x0601D35E RID: 119646 RVA: 0x0041F2A7 File Offset: 0x0041D4A7
		// (set) Token: 0x0601D35F RID: 119647 RVA: 0x0041F2AF File Offset: 0x0041D4AF
		public List<string> Reference { get; set; }

		// Token: 0x17008783 RID: 34691
		// (get) Token: 0x0601D360 RID: 119648 RVA: 0x0041F2B8 File Offset: 0x0041D4B8
		// (set) Token: 0x0601D361 RID: 119649 RVA: 0x0041F2C0 File Offset: 0x0041D4C0
		public List<string> WeakReference { get; set; }

		// Token: 0x17008784 RID: 34692
		// (get) Token: 0x0601D362 RID: 119650 RVA: 0x0041F2C9 File Offset: 0x0041D4C9
		// (set) Token: 0x0601D363 RID: 119651 RVA: 0x0041F2D1 File Offset: 0x0041D4D1
		public byte NullMask { get; set; }

		// Token: 0x0601D364 RID: 119652 RVA: 0x0041F2DA File Offset: 0x0041D4DA
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

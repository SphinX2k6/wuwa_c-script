using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200485D RID: 18525
	public class IEditorConnectionConfigT
	{
		// Token: 0x17008561 RID: 34145
		// (get) Token: 0x0601CBCA RID: 117706 RVA: 0x00410061 File Offset: 0x0040E261
		// (set) Token: 0x0601CBCB RID: 117707 RVA: 0x00410069 File Offset: 0x0040E269
		public List<IConnectionGroupT> ConnectionGroups { get; set; }

		// Token: 0x0601CBCC RID: 117708 RVA: 0x00410072 File Offset: 0x0040E272
		public IEditorConnectionConfigT()
		{
			this.ConnectionGroups = null;
		}
	}
}

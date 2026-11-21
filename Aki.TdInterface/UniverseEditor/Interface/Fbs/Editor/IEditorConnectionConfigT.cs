using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CC5 RID: 19653
	public class IEditorConnectionConfigT
	{
		// Token: 0x17008BB0 RID: 35760
		// (get) Token: 0x0601E3D1 RID: 123857 RVA: 0x0043CB0D File Offset: 0x0043AD0D
		// (set) Token: 0x0601E3D2 RID: 123858 RVA: 0x0043CB15 File Offset: 0x0043AD15
		public List<IConnectionGroupT> ConnectionGroups { get; set; }

		// Token: 0x0601E3D3 RID: 123859 RVA: 0x0043CB1E File Offset: 0x0043AD1E
		public IEditorConnectionConfigT()
		{
			this.ConnectionGroups = null;
		}
	}
}

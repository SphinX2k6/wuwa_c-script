using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006087 RID: 24711
	public class IActionParams_UnionT
	{
		// Token: 0x1700B626 RID: 46630
		// (get) Token: 0x06029F85 RID: 171909 RVA: 0x005C9B0D File Offset: 0x005C7D0D
		// (set) Token: 0x06029F86 RID: 171910 RVA: 0x005C9B15 File Offset: 0x005C7D15
		public byte UnionIndex { get; set; }

		// Token: 0x1700B627 RID: 46631
		// (get) Token: 0x06029F87 RID: 171911 RVA: 0x005C9B1E File Offset: 0x005C7D1E
		// (set) Token: 0x06029F88 RID: 171912 RVA: 0x005C9B26 File Offset: 0x005C7D26
		public IActionParams_Union_0Union Data0 { get; set; }

		// Token: 0x1700B628 RID: 46632
		// (get) Token: 0x06029F89 RID: 171913 RVA: 0x005C9B2F File Offset: 0x005C7D2F
		// (set) Token: 0x06029F8A RID: 171914 RVA: 0x005C9B37 File Offset: 0x005C7D37
		public IActionParams_Union_1Union Data1 { get; set; }

		// Token: 0x06029F8B RID: 171915 RVA: 0x005C9B40 File Offset: 0x005C7D40
		public IActionParams_UnionT()
		{
			this.UnionIndex = 0;
			this.Data0 = null;
			this.Data1 = null;
		}
	}
}

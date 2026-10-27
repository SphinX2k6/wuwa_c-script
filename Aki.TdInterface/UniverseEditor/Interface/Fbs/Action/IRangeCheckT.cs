using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E0B RID: 28171
	public class IRangeCheckT
	{
		// Token: 0x1700D204 RID: 53764
		// (get) Token: 0x06031C76 RID: 203894 RVA: 0x006BD6CE File Offset: 0x006BB8CE
		// (set) Token: 0x06031C77 RID: 203895 RVA: 0x006BD6D6 File Offset: 0x006BB8D6
		public ERangeCheckType Type { get; set; }

		// Token: 0x06031C78 RID: 203896 RVA: 0x006BD6DF File Offset: 0x006BB8DF
		public IRangeCheckT()
		{
			this.Type = ERangeCheckType.Cone;
		}
	}
}

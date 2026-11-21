using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C12 RID: 31762
	public class IToolEditorActionContextT
	{
		// Token: 0x1700EDD4 RID: 60884
		// (get) Token: 0x060393EC RID: 234476 RVA: 0x007BB69D File Offset: 0x007B989D
		// (set) Token: 0x060393ED RID: 234477 RVA: 0x007BB6A5 File Offset: 0x007B98A5
		public string Type { get; set; }

		// Token: 0x060393EE RID: 234478 RVA: 0x007BB6AE File Offset: 0x007B98AE
		public IToolEditorActionContextT()
		{
			this.Type = null;
		}
	}
}

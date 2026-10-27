using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005779 RID: 22393
	public class IPrefabCompTransformItemT
	{
		// Token: 0x1700A70A RID: 42762
		// (get) Token: 0x0602589D RID: 153757 RVA: 0x0052DC83 File Offset: 0x0052BE83
		// (set) Token: 0x0602589E RID: 153758 RVA: 0x0052DC8B File Offset: 0x0052BE8B
		public bool IsAbsolute { get; set; }

		// Token: 0x1700A70B RID: 42763
		// (get) Token: 0x0602589F RID: 153759 RVA: 0x0052DC94 File Offset: 0x0052BE94
		// (set) Token: 0x060258A0 RID: 153760 RVA: 0x0052DC9C File Offset: 0x0052BE9C
		public IVectorInfoT Value { get; set; }

		// Token: 0x060258A1 RID: 153761 RVA: 0x0052DCA5 File Offset: 0x0052BEA5
		public IPrefabCompTransformItemT()
		{
			this.IsAbsolute = false;
			this.Value = null;
		}
	}
}

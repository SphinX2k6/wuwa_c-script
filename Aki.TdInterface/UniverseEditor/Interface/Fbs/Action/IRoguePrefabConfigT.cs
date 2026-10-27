using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE3 RID: 28387
	public class IRoguePrefabConfigT
	{
		// Token: 0x1700D32F RID: 54063
		// (get) Token: 0x06032297 RID: 205463 RVA: 0x006C78B0 File Offset: 0x006C5AB0
		// (set) Token: 0x06032298 RID: 205464 RVA: 0x006C78B8 File Offset: 0x006C5AB8
		public ECreatePrefabType Type { get; set; }

		// Token: 0x1700D330 RID: 54064
		// (get) Token: 0x06032299 RID: 205465 RVA: 0x006C78C1 File Offset: 0x006C5AC1
		// (set) Token: 0x0603229A RID: 205466 RVA: 0x006C78C9 File Offset: 0x006C5AC9
		public int Index { get; set; }

		// Token: 0x0603229B RID: 205467 RVA: 0x006C78D2 File Offset: 0x006C5AD2
		public IRoguePrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
			this.Index = 0;
		}
	}
}

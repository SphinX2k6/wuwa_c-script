using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200438F RID: 17295
	public class INewHandInItemsBaseT
	{
		// Token: 0x170076AA RID: 30378
		// (get) Token: 0x06018730 RID: 100144 RVA: 0x0037C116 File Offset: 0x0037A316
		// (set) Token: 0x06018731 RID: 100145 RVA: 0x0037C11E File Offset: 0x0037A31E
		public ENewHandInItemsType Type { get; set; }

		// Token: 0x06018732 RID: 100146 RVA: 0x0037C127 File Offset: 0x0037A327
		public INewHandInItemsBaseT()
		{
			this.Type = ENewHandInItemsType.ProjectionMachine;
		}
	}
}

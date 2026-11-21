using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063F3 RID: 25587
	public class IGiantAnimDataTypeT
	{
		// Token: 0x1700BD09 RID: 48393
		// (get) Token: 0x0602B78A RID: 178058 RVA: 0x005EC162 File Offset: 0x005EA362
		// (set) Token: 0x0602B78B RID: 178059 RVA: 0x005EC16A File Offset: 0x005EA36A
		public EGiantAnimationType Type { get; set; }

		// Token: 0x0602B78C RID: 178060 RVA: 0x005EC173 File Offset: 0x005EA373
		public IGiantAnimDataTypeT()
		{
			this.Type = EGiantAnimationType.Idle;
		}
	}
}

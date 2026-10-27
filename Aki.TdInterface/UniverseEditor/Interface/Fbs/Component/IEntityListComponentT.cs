using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200518D RID: 20877
	public class IEntityListComponentT
	{
		// Token: 0x17009885 RID: 39045
		// (get) Token: 0x06021C33 RID: 138291 RVA: 0x004AF270 File Offset: 0x004AD470
		// (set) Token: 0x06021C34 RID: 138292 RVA: 0x004AF278 File Offset: 0x004AD478
		public bool Disabled { get; set; }

		// Token: 0x17009886 RID: 39046
		// (get) Token: 0x06021C35 RID: 138293 RVA: 0x004AF281 File Offset: 0x004AD481
		// (set) Token: 0x06021C36 RID: 138294 RVA: 0x004AF289 File Offset: 0x004AD489
		public byte NullMask { get; set; }

		// Token: 0x06021C37 RID: 138295 RVA: 0x004AF292 File Offset: 0x004AD492
		public IEntityListComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}

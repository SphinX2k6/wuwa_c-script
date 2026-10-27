using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E7D RID: 28285
	public class IResetEntityT
	{
		// Token: 0x1700D2AB RID: 53931
		// (get) Token: 0x06031FE5 RID: 204773 RVA: 0x006C34C9 File Offset: 0x006C16C9
		// (set) Token: 0x06031FE6 RID: 204774 RVA: 0x006C34D1 File Offset: 0x006C16D1
		public TResetEntityConfigUnion ResetEntityConfig { get; set; }

		// Token: 0x06031FE7 RID: 204775 RVA: 0x006C34DA File Offset: 0x006C16DA
		public IResetEntityT()
		{
			this.ResetEntityConfig = null;
		}
	}
}

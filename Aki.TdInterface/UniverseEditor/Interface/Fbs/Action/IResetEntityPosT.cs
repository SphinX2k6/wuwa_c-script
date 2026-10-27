using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E86 RID: 28294
	public class IResetEntityPosT
	{
		// Token: 0x1700D2B3 RID: 53939
		// (get) Token: 0x06032017 RID: 204823 RVA: 0x006C3936 File Offset: 0x006C1B36
		// (set) Token: 0x06032018 RID: 204824 RVA: 0x006C393E File Offset: 0x006C1B3E
		public int EntityId { get; set; }

		// Token: 0x06032019 RID: 204825 RVA: 0x006C3947 File Offset: 0x006C1B47
		public IResetEntityPosT()
		{
			this.EntityId = 0;
		}
	}
}

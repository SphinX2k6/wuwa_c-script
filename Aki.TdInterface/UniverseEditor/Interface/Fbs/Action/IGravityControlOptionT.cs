using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200689B RID: 26779
	public class IGravityControlOptionT
	{
		// Token: 0x1700C6CF RID: 50895
		// (get) Token: 0x0602EB4C RID: 191308 RVA: 0x0065E273 File Offset: 0x0065C473
		// (set) Token: 0x0602EB4D RID: 191309 RVA: 0x0065E27B File Offset: 0x0065C47B
		public ESystemOptionType Type { get; set; }

		// Token: 0x1700C6D0 RID: 50896
		// (get) Token: 0x0602EB4E RID: 191310 RVA: 0x0065E284 File Offset: 0x0065C484
		// (set) Token: 0x0602EB4F RID: 191311 RVA: 0x0065E28C File Offset: 0x0065C48C
		public List<ISystemOptionT> SystemOptions { get; set; }

		// Token: 0x1700C6D1 RID: 50897
		// (get) Token: 0x0602EB50 RID: 191312 RVA: 0x0065E295 File Offset: 0x0065C495
		// (set) Token: 0x0602EB51 RID: 191313 RVA: 0x0065E29D File Offset: 0x0065C49D
		public bool KeepPreTalkItem { get; set; }

		// Token: 0x1700C6D2 RID: 50898
		// (get) Token: 0x0602EB52 RID: 191314 RVA: 0x0065E2A6 File Offset: 0x0065C4A6
		// (set) Token: 0x0602EB53 RID: 191315 RVA: 0x0065E2AE File Offset: 0x0065C4AE
		public byte NullMask { get; set; }

		// Token: 0x0602EB54 RID: 191316 RVA: 0x0065E2B7 File Offset: 0x0065C4B7
		public IGravityControlOptionT()
		{
			this.Type = ESystemOptionType.RogueRandomEvent;
			this.SystemOptions = null;
			this.KeepPreTalkItem = false;
			this.NullMask = 0;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F3C RID: 28476
	public class IGravityControlOptionT
	{
		// Token: 0x1700D0B5 RID: 53429
		// (get) Token: 0x06031486 RID: 201862 RVA: 0x006AD2F3 File Offset: 0x006AB4F3
		// (set) Token: 0x06031487 RID: 201863 RVA: 0x006AD2FB File Offset: 0x006AB4FB
		public ESystemOptionType Type { get; set; }

		// Token: 0x1700D0B6 RID: 53430
		// (get) Token: 0x06031488 RID: 201864 RVA: 0x006AD304 File Offset: 0x006AB504
		// (set) Token: 0x06031489 RID: 201865 RVA: 0x006AD30C File Offset: 0x006AB50C
		public List<ISystemOptionT> SystemOptions { get; set; }

		// Token: 0x1700D0B7 RID: 53431
		// (get) Token: 0x0603148A RID: 201866 RVA: 0x006AD315 File Offset: 0x006AB515
		// (set) Token: 0x0603148B RID: 201867 RVA: 0x006AD31D File Offset: 0x006AB51D
		public bool KeepPreTalkItem { get; set; }

		// Token: 0x1700D0B8 RID: 53432
		// (get) Token: 0x0603148C RID: 201868 RVA: 0x006AD326 File Offset: 0x006AB526
		// (set) Token: 0x0603148D RID: 201869 RVA: 0x006AD32E File Offset: 0x006AB52E
		public byte NullMask { get; set; }

		// Token: 0x0603148E RID: 201870 RVA: 0x006AD337 File Offset: 0x006AB537
		public IGravityControlOptionT()
		{
			this.Type = ESystemOptionType.RogueRandomEvent;
			this.SystemOptions = null;
			this.KeepPreTalkItem = false;
			this.NullMask = 0;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007634 RID: 30260
	public class IResetTeleControlEntityT
	{
		// Token: 0x1700DE4B RID: 56907
		// (get) Token: 0x0603519D RID: 217501 RVA: 0x007219D3 File Offset: 0x0071FBD3
		// (set) Token: 0x0603519E RID: 217502 RVA: 0x007219DB File Offset: 0x0071FBDB
		public EResetEntityType Type { get; set; }

		// Token: 0x1700DE4C RID: 56908
		// (get) Token: 0x0603519F RID: 217503 RVA: 0x007219E4 File Offset: 0x0071FBE4
		// (set) Token: 0x060351A0 RID: 217504 RVA: 0x007219EC File Offset: 0x0071FBEC
		public List<int> EntityIds { get; set; }

		// Token: 0x060351A1 RID: 217505 RVA: 0x007219F5 File Offset: 0x0071FBF5
		public IResetTeleControlEntityT()
		{
			this.Type = EResetEntityType.TeleControl;
			this.EntityIds = null;
		}
	}
}

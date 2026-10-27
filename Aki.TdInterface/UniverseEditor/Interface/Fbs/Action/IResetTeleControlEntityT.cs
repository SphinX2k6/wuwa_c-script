using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB0 RID: 28336
	public class IResetTeleControlEntityT
	{
		// Token: 0x1700D2F4 RID: 54004
		// (get) Token: 0x0603215D RID: 205149 RVA: 0x006C5C9F File Offset: 0x006C3E9F
		// (set) Token: 0x0603215E RID: 205150 RVA: 0x006C5CA7 File Offset: 0x006C3EA7
		public EResetEntityType Type { get; set; }

		// Token: 0x1700D2F5 RID: 54005
		// (get) Token: 0x0603215F RID: 205151 RVA: 0x006C5CB0 File Offset: 0x006C3EB0
		// (set) Token: 0x06032160 RID: 205152 RVA: 0x006C5CB8 File Offset: 0x006C3EB8
		public List<int> EntityIds { get; set; }

		// Token: 0x06032161 RID: 205153 RVA: 0x006C5CC1 File Offset: 0x006C3EC1
		public IResetTeleControlEntityT()
		{
			this.Type = EResetEntityType.TeleControl;
			this.EntityIds = null;
		}
	}
}

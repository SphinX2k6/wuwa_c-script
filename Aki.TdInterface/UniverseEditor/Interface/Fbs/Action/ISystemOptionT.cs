using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007284 RID: 29316
	public class ISystemOptionT
	{
		// Token: 0x1700D97D RID: 55677
		// (get) Token: 0x0603403D RID: 213053 RVA: 0x006FE7D1 File Offset: 0x006FC9D1
		// (set) Token: 0x0603403E RID: 213054 RVA: 0x006FE7D9 File Offset: 0x006FC9D9
		public int OptionId { get; set; }

		// Token: 0x1700D97E RID: 55678
		// (get) Token: 0x0603403F RID: 213055 RVA: 0x006FE7E2 File Offset: 0x006FC9E2
		// (set) Token: 0x06034040 RID: 213056 RVA: 0x006FE7EA File Offset: 0x006FC9EA
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700D97F RID: 55679
		// (get) Token: 0x06034041 RID: 213057 RVA: 0x006FE7F3 File Offset: 0x006FC9F3
		// (set) Token: 0x06034042 RID: 213058 RVA: 0x006FE7FB File Offset: 0x006FC9FB
		public byte NullMask { get; set; }

		// Token: 0x06034043 RID: 213059 RVA: 0x006FE804 File Offset: 0x006FCA04
		public ISystemOptionT()
		{
			this.OptionId = 0;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}

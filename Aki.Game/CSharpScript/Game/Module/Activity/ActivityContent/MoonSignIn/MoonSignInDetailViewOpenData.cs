using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x02006461 RID: 25697
	internal class MoonSignInDetailViewOpenData : IMoonSignInDetailViewOpenData
	{
		// Token: 0x1700948B RID: 38027
		// (get) Token: 0x06040946 RID: 264518 RVA: 0x00FA1287 File Offset: 0x00F9F487
		// (set) Token: 0x06040947 RID: 264519 RVA: 0x00FA128F File Offset: 0x00F9F48F
		public int MoonId { get; set; }

		// Token: 0x1700948C RID: 38028
		// (get) Token: 0x06040948 RID: 264520 RVA: 0x00FA1298 File Offset: 0x00F9F498
		// (set) Token: 0x06040949 RID: 264521 RVA: 0x00FA12A0 File Offset: 0x00F9F4A0
		public bool? Wishing { get; set; } = new bool?(false);
	}
}

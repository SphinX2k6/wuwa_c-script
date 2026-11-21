using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B9 RID: 29625
	public class IOverrideAbpAnimSchemeConfigT
	{
		// Token: 0x1700D9A2 RID: 55714
		// (get) Token: 0x06033D10 RID: 212240 RVA: 0x006FD418 File Offset: 0x006FB618
		// (set) Token: 0x06033D11 RID: 212241 RVA: 0x006FD420 File Offset: 0x006FB620
		public int EntityId { get; set; }

		// Token: 0x1700D9A3 RID: 55715
		// (get) Token: 0x06033D12 RID: 212242 RVA: 0x006FD429 File Offset: 0x006FB629
		// (set) Token: 0x06033D13 RID: 212243 RVA: 0x006FD431 File Offset: 0x006FB631
		public EAbpAnimScheme AnimScheme { get; set; }

		// Token: 0x06033D14 RID: 212244 RVA: 0x006FD43A File Offset: 0x006FB63A
		public IOverrideAbpAnimSchemeConfigT()
		{
			this.EntityId = 0;
			this.AnimScheme = EAbpAnimScheme.Default;
		}
	}
}

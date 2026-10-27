using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005250 RID: 21072
	public class IFillTypeT
	{
		// Token: 0x17009A5E RID: 39518
		// (get) Token: 0x06022477 RID: 140407 RVA: 0x004C0EA2 File Offset: 0x004BF0A2
		// (set) Token: 0x06022478 RID: 140408 RVA: 0x004C0EAA File Offset: 0x004BF0AA
		public EFillType Type { get; set; }

		// Token: 0x06022479 RID: 140409 RVA: 0x004C0EB3 File Offset: 0x004BF0B3
		public IFillTypeT()
		{
			this.Type = EFillType.Fixed;
		}
	}
}

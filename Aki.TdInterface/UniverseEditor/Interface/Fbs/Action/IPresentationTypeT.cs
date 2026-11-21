using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007526 RID: 29990
	public class IPresentationTypeT
	{
		// Token: 0x1700DCA9 RID: 56489
		// (get) Token: 0x06034983 RID: 215427 RVA: 0x00713F4A File Offset: 0x0071214A
		// (set) Token: 0x06034984 RID: 215428 RVA: 0x00713F52 File Offset: 0x00712152
		public EResetPresentationType Type { get; set; }

		// Token: 0x06034985 RID: 215429 RVA: 0x00713F5B File Offset: 0x0071215B
		public IPresentationTypeT()
		{
			this.Type = EResetPresentationType.Failure;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200593D RID: 22845
	public class IHookFetchMoveModeBaseT
	{
		// Token: 0x1700A5C1 RID: 42433
		// (get) Token: 0x060252AE RID: 152238 RVA: 0x00519AEE File Offset: 0x00517CEE
		// (set) Token: 0x060252AF RID: 152239 RVA: 0x00519AF6 File Offset: 0x00517CF6
		public EHookFetchMoveMode Type { get; set; }

		// Token: 0x060252B0 RID: 152240 RVA: 0x00519AFF File Offset: 0x00517CFF
		public IHookFetchMoveModeBaseT()
		{
			this.Type = EHookFetchMoveMode.Uniform;
		}
	}
}

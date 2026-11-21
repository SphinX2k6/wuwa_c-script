using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005943 RID: 22851
	public class IHookFetchMoveUniformT
	{
		// Token: 0x1700A5C7 RID: 42439
		// (get) Token: 0x060252CE RID: 152270 RVA: 0x00519DD0 File Offset: 0x00517FD0
		// (set) Token: 0x060252CF RID: 152271 RVA: 0x00519DD8 File Offset: 0x00517FD8
		public EHookFetchMoveMode Type { get; set; }

		// Token: 0x1700A5C8 RID: 42440
		// (get) Token: 0x060252D0 RID: 152272 RVA: 0x00519DE1 File Offset: 0x00517FE1
		// (set) Token: 0x060252D1 RID: 152273 RVA: 0x00519DE9 File Offset: 0x00517FE9
		public float Speed { get; set; }

		// Token: 0x060252D2 RID: 152274 RVA: 0x00519DF2 File Offset: 0x00517FF2
		public IHookFetchMoveUniformT()
		{
			this.Type = EHookFetchMoveMode.Uniform;
			this.Speed = 0f;
		}
	}
}

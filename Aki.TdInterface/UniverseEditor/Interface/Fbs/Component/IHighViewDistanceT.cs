using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058EF RID: 22767
	public class IHighViewDistanceT
	{
		// Token: 0x1700A524 RID: 42276
		// (get) Token: 0x06024FCA RID: 151498 RVA: 0x00513A9A File Offset: 0x00511C9A
		// (set) Token: 0x06024FCB RID: 151499 RVA: 0x00513AA2 File Offset: 0x00511CA2
		public EViewDistanceType Type { get; set; }

		// Token: 0x06024FCC RID: 151500 RVA: 0x00513AAB File Offset: 0x00511CAB
		public IHighViewDistanceT()
		{
			this.Type = EViewDistanceType.Low;
		}
	}
}

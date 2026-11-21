using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004047 RID: 16455
	public class IRequestResultT
	{
		// Token: 0x17006FDD RID: 28637
		// (get) Token: 0x060169B5 RID: 92597 RVA: 0x0033BC4F File Offset: 0x00339E4F
		// (set) Token: 0x060169B6 RID: 92598 RVA: 0x0033BC57 File Offset: 0x00339E57
		public bool IsSuccess { get; set; }

		// Token: 0x17006FDE RID: 28638
		// (get) Token: 0x060169B7 RID: 92599 RVA: 0x0033BC60 File Offset: 0x00339E60
		// (set) Token: 0x060169B8 RID: 92600 RVA: 0x0033BC68 File Offset: 0x00339E68
		public string Reason { get; set; }

		// Token: 0x060169B9 RID: 92601 RVA: 0x0033BC71 File Offset: 0x00339E71
		public IRequestResultT()
		{
			this.IsSuccess = false;
			this.Reason = null;
		}
	}
}

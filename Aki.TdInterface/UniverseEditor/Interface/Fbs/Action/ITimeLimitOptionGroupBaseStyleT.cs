using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BC7 RID: 31687
	public class ITimeLimitOptionGroupBaseStyleT
	{
		// Token: 0x1700ED69 RID: 60777
		// (get) Token: 0x060391E0 RID: 233952 RVA: 0x007B80BA File Offset: 0x007B62BA
		// (set) Token: 0x060391E1 RID: 233953 RVA: 0x007B80C2 File Offset: 0x007B62C2
		public ETimeLimitOptionGroupStyle Type { get; set; }

		// Token: 0x060391E2 RID: 233954 RVA: 0x007B80CB File Offset: 0x007B62CB
		public ITimeLimitOptionGroupBaseStyleT()
		{
			this.Type = ETimeLimitOptionGroupStyle.Default;
		}
	}
}

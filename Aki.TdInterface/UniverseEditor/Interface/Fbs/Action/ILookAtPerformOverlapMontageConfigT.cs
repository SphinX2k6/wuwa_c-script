using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A5D RID: 27229
	public class ILookAtPerformOverlapMontageConfigT
	{
		// Token: 0x1700CA01 RID: 51713
		// (get) Token: 0x0602FAEE RID: 195310 RVA: 0x0067D4E6 File Offset: 0x0067B6E6
		// (set) Token: 0x0602FAEF RID: 195311 RVA: 0x0067D4EE File Offset: 0x0067B6EE
		public float OverlapMontageLoopDuration { get; set; }

		// Token: 0x1700CA02 RID: 51714
		// (get) Token: 0x0602FAF0 RID: 195312 RVA: 0x0067D4F7 File Offset: 0x0067B6F7
		// (set) Token: 0x0602FAF1 RID: 195313 RVA: 0x0067D4FF File Offset: 0x0067B6FF
		public int OverlapMontageRepeatTimes { get; set; }

		// Token: 0x1700CA03 RID: 51715
		// (get) Token: 0x0602FAF2 RID: 195314 RVA: 0x0067D508 File Offset: 0x0067B708
		// (set) Token: 0x0602FAF3 RID: 195315 RVA: 0x0067D510 File Offset: 0x0067B710
		public byte NullMask { get; set; }

		// Token: 0x0602FAF4 RID: 195316 RVA: 0x0067D519 File Offset: 0x0067B719
		public ILookAtPerformOverlapMontageConfigT()
		{
			this.OverlapMontageLoopDuration = 0f;
			this.OverlapMontageRepeatTimes = 0;
			this.NullMask = 0;
		}
	}
}

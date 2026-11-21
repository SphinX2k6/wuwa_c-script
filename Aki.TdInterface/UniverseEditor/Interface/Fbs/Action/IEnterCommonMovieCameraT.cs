using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D23 RID: 27939
	public class IEnterCommonMovieCameraT
	{
		// Token: 0x1700CCFA RID: 52474
		// (get) Token: 0x06030308 RID: 197384 RVA: 0x0068D557 File Offset: 0x0068B757
		// (set) Token: 0x06030309 RID: 197385 RVA: 0x0068D55F File Offset: 0x0068B75F
		public EMovieCameraType Type { get; set; }

		// Token: 0x1700CCFB RID: 52475
		// (get) Token: 0x0603030A RID: 197386 RVA: 0x0068D568 File Offset: 0x0068B768
		// (set) Token: 0x0603030B RID: 197387 RVA: 0x0068D570 File Offset: 0x0068B770
		public string RowName { get; set; }

		// Token: 0x1700CCFC RID: 52476
		// (get) Token: 0x0603030C RID: 197388 RVA: 0x0068D579 File Offset: 0x0068B779
		// (set) Token: 0x0603030D RID: 197389 RVA: 0x0068D581 File Offset: 0x0068B781
		public int SpecElementIndex { get; set; }

		// Token: 0x1700CCFD RID: 52477
		// (get) Token: 0x0603030E RID: 197390 RVA: 0x0068D58A File Offset: 0x0068B78A
		// (set) Token: 0x0603030F RID: 197391 RVA: 0x0068D592 File Offset: 0x0068B792
		public byte NullMask { get; set; }

		// Token: 0x06030310 RID: 197392 RVA: 0x0068D59B File Offset: 0x0068B79B
		public IEnterCommonMovieCameraT()
		{
			this.Type = EMovieCameraType.Common;
			this.RowName = null;
			this.SpecElementIndex = 0;
			this.NullMask = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E1 RID: 29921
	public class IPosAndRotT
	{
		// Token: 0x1700DC2B RID: 56363
		// (get) Token: 0x06034748 RID: 214856 RVA: 0x00710066 File Offset: 0x0070E266
		// (set) Token: 0x06034749 RID: 214857 RVA: 0x0071006E File Offset: 0x0070E26E
		public float X { get; set; }

		// Token: 0x1700DC2C RID: 56364
		// (get) Token: 0x0603474A RID: 214858 RVA: 0x00710077 File Offset: 0x0070E277
		// (set) Token: 0x0603474B RID: 214859 RVA: 0x0071007F File Offset: 0x0070E27F
		public float Y { get; set; }

		// Token: 0x1700DC2D RID: 56365
		// (get) Token: 0x0603474C RID: 214860 RVA: 0x00710088 File Offset: 0x0070E288
		// (set) Token: 0x0603474D RID: 214861 RVA: 0x00710090 File Offset: 0x0070E290
		public float Z { get; set; }

		// Token: 0x1700DC2E RID: 56366
		// (get) Token: 0x0603474E RID: 214862 RVA: 0x00710099 File Offset: 0x0070E299
		// (set) Token: 0x0603474F RID: 214863 RVA: 0x007100A1 File Offset: 0x0070E2A1
		public float A { get; set; }

		// Token: 0x1700DC2F RID: 56367
		// (get) Token: 0x06034750 RID: 214864 RVA: 0x007100AA File Offset: 0x0070E2AA
		// (set) Token: 0x06034751 RID: 214865 RVA: 0x007100B2 File Offset: 0x0070E2B2
		public float Roll { get; set; }

		// Token: 0x1700DC30 RID: 56368
		// (get) Token: 0x06034752 RID: 214866 RVA: 0x007100BB File Offset: 0x0070E2BB
		// (set) Token: 0x06034753 RID: 214867 RVA: 0x007100C3 File Offset: 0x0070E2C3
		public float Pitch { get; set; }

		// Token: 0x1700DC31 RID: 56369
		// (get) Token: 0x06034754 RID: 214868 RVA: 0x007100CC File Offset: 0x0070E2CC
		// (set) Token: 0x06034755 RID: 214869 RVA: 0x007100D4 File Offset: 0x0070E2D4
		public byte NullMask { get; set; }

		// Token: 0x06034756 RID: 214870 RVA: 0x007100E0 File Offset: 0x0070E2E0
		public IPosAndRotT()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.A = 0f;
			this.Roll = 0f;
			this.Pitch = 0f;
			this.NullMask = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DD7 RID: 32215
	public class IVisualNovelPortraitTransformT
	{
		// Token: 0x1700F156 RID: 61782
		// (get) Token: 0x0603A381 RID: 238465 RVA: 0x007D8BCC File Offset: 0x007D6DCC
		// (set) Token: 0x0603A382 RID: 238466 RVA: 0x007D8BD4 File Offset: 0x007D6DD4
		public int PosX { get; set; }

		// Token: 0x1700F157 RID: 61783
		// (get) Token: 0x0603A383 RID: 238467 RVA: 0x007D8BDD File Offset: 0x007D6DDD
		// (set) Token: 0x0603A384 RID: 238468 RVA: 0x007D8BE5 File Offset: 0x007D6DE5
		public int PosY { get; set; }

		// Token: 0x1700F158 RID: 61784
		// (get) Token: 0x0603A385 RID: 238469 RVA: 0x007D8BEE File Offset: 0x007D6DEE
		// (set) Token: 0x0603A386 RID: 238470 RVA: 0x007D8BF6 File Offset: 0x007D6DF6
		public float Scale { get; set; }

		// Token: 0x1700F159 RID: 61785
		// (get) Token: 0x0603A387 RID: 238471 RVA: 0x007D8BFF File Offset: 0x007D6DFF
		// (set) Token: 0x0603A388 RID: 238472 RVA: 0x007D8C07 File Offset: 0x007D6E07
		public byte NullMask { get; set; }

		// Token: 0x0603A389 RID: 238473 RVA: 0x007D8C10 File Offset: 0x007D6E10
		public IVisualNovelPortraitTransformT()
		{
			this.PosX = 0;
			this.PosY = 0;
			this.Scale = 0f;
			this.NullMask = 0;
		}
	}
}

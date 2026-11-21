using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004008 RID: 16392
	public class ICircleRangeT
	{
		// Token: 0x17006F1D RID: 28445
		// (get) Token: 0x06016727 RID: 91943 RVA: 0x00336B79 File Offset: 0x00334D79
		// (set) Token: 0x06016728 RID: 91944 RVA: 0x00336B81 File Offset: 0x00334D81
		public ERangeType Type { get; set; }

		// Token: 0x17006F1E RID: 28446
		// (get) Token: 0x06016729 RID: 91945 RVA: 0x00336B8A File Offset: 0x00334D8A
		// (set) Token: 0x0601672A RID: 91946 RVA: 0x00336B92 File Offset: 0x00334D92
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17006F1F RID: 28447
		// (get) Token: 0x0601672B RID: 91947 RVA: 0x00336B9B File Offset: 0x00334D9B
		// (set) Token: 0x0601672C RID: 91948 RVA: 0x00336BA3 File Offset: 0x00334DA3
		public int Radius { get; set; }

		// Token: 0x0601672D RID: 91949 RVA: 0x00336BAC File Offset: 0x00334DAC
		public ICircleRangeT()
		{
			this.Type = ERangeType.CircleRange;
			this.Pos = null;
			this.Radius = 0;
		}
	}
}

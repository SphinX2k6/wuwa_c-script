using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C17 RID: 15383
	public class IGraphPointTipsActorT
	{
		// Token: 0x170069CE RID: 27086
		// (get) Token: 0x0601535D RID: 86877 RVA: 0x0031271C File Offset: 0x0031091C
		// (set) Token: 0x0601535E RID: 86878 RVA: 0x00312724 File Offset: 0x00310924
		public ETipsActorType Type { get; set; }

		// Token: 0x170069CF RID: 27087
		// (get) Token: 0x0601535F RID: 86879 RVA: 0x0031272D File Offset: 0x0031092D
		// (set) Token: 0x06015360 RID: 86880 RVA: 0x00312735 File Offset: 0x00310935
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x170069D0 RID: 27088
		// (get) Token: 0x06015361 RID: 86881 RVA: 0x0031273E File Offset: 0x0031093E
		// (set) Token: 0x06015362 RID: 86882 RVA: 0x00312746 File Offset: 0x00310946
		public float Size { get; set; }

		// Token: 0x170069D1 RID: 27089
		// (get) Token: 0x06015363 RID: 86883 RVA: 0x0031274F File Offset: 0x0031094F
		// (set) Token: 0x06015364 RID: 86884 RVA: 0x00312757 File Offset: 0x00310957
		public byte NullMask { get; set; }

		// Token: 0x06015365 RID: 86885 RVA: 0x00312760 File Offset: 0x00310960
		public IGraphPointTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Size = 0f;
			this.NullMask = 0;
		}
	}
}

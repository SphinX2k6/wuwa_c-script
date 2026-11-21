using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200790C RID: 30988
	public class ISlideConfigT
	{
		// Token: 0x1700E351 RID: 58193
		// (get) Token: 0x06036902 RID: 223490 RVA: 0x0074D914 File Offset: 0x0074BB14
		// (set) Token: 0x06036903 RID: 223491 RVA: 0x0074D91C File Offset: 0x0074BB1C
		public ESportStateType Type { get; set; }

		// Token: 0x1700E352 RID: 58194
		// (get) Token: 0x06036904 RID: 223492 RVA: 0x0074D925 File Offset: 0x0074BB25
		// (set) Token: 0x06036905 RID: 223493 RVA: 0x0074D92D File Offset: 0x0074BB2D
		public int SlideId { get; set; }

		// Token: 0x06036906 RID: 223494 RVA: 0x0074D936 File Offset: 0x0074BB36
		public ISlideConfigT()
		{
			this.Type = ESportStateType.Slide;
			this.SlideId = 0;
		}
	}
}

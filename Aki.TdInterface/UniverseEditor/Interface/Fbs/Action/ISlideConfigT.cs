using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007140 RID: 28992
	public class ISlideConfigT
	{
		// Token: 0x1700D76E RID: 55150
		// (get) Token: 0x06033660 RID: 210528 RVA: 0x006ED308 File Offset: 0x006EB508
		// (set) Token: 0x06033661 RID: 210529 RVA: 0x006ED310 File Offset: 0x006EB510
		public ESportStateType Type { get; set; }

		// Token: 0x1700D76F RID: 55151
		// (get) Token: 0x06033662 RID: 210530 RVA: 0x006ED319 File Offset: 0x006EB519
		// (set) Token: 0x06033663 RID: 210531 RVA: 0x006ED321 File Offset: 0x006EB521
		public int SlideId { get; set; }

		// Token: 0x06033664 RID: 210532 RVA: 0x006ED32A File Offset: 0x006EB52A
		public ISlideConfigT()
		{
			this.Type = ESportStateType.Slide;
			this.SlideId = 0;
		}
	}
}

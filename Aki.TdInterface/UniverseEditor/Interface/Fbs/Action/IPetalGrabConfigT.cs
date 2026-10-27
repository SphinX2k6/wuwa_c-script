using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C9A RID: 27802
	public class IPetalGrabConfigT
	{
		// Token: 0x1700CF0C RID: 53004
		// (get) Token: 0x06030FF9 RID: 200697 RVA: 0x006A6D94 File Offset: 0x006A4F94
		// (set) Token: 0x06030FFA RID: 200698 RVA: 0x006A6D9C File Offset: 0x006A4F9C
		public ESportStateType Type { get; set; }

		// Token: 0x1700CF0D RID: 53005
		// (get) Token: 0x06030FFB RID: 200699 RVA: 0x006A6DA5 File Offset: 0x006A4FA5
		// (set) Token: 0x06030FFC RID: 200700 RVA: 0x006A6DAD File Offset: 0x006A4FAD
		public int FirstGrabEntityId { get; set; }

		// Token: 0x06030FFD RID: 200701 RVA: 0x006A6DB6 File Offset: 0x006A4FB6
		public IPetalGrabConfigT()
		{
			this.Type = ESportStateType.Slide;
			this.FirstGrabEntityId = 0;
		}
	}
}

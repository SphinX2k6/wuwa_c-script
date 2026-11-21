using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007556 RID: 30038
	public class IQiuyuanLongPressQinggongT
	{
		// Token: 0x1700DCF2 RID: 56562
		// (get) Token: 0x06034AD5 RID: 215765 RVA: 0x00715F22 File Offset: 0x00714122
		// (set) Token: 0x06034AD6 RID: 215766 RVA: 0x00715F2A File Offset: 0x0071412A
		public ELeisureInteract Type { get; set; }

		// Token: 0x06034AD7 RID: 215767 RVA: 0x00715F33 File Offset: 0x00714133
		public IQiuyuanLongPressQinggongT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}

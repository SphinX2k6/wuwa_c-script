using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007568 RID: 30056
	public class IQiuyuanQinggongHoveringT
	{
		// Token: 0x1700DD04 RID: 56580
		// (get) Token: 0x06034B41 RID: 215873 RVA: 0x007167F2 File Offset: 0x007149F2
		// (set) Token: 0x06034B42 RID: 215874 RVA: 0x007167FA File Offset: 0x007149FA
		public ELeisureInteract Type { get; set; }

		// Token: 0x06034B43 RID: 215875 RVA: 0x00716803 File Offset: 0x00714A03
		public IQiuyuanQinggongHoveringT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}

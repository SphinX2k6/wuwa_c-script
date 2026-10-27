using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DED RID: 28141
	public class IQiuyuanQinggongHoveringT
	{
		// Token: 0x1700D1BC RID: 53692
		// (get) Token: 0x06031B45 RID: 203589 RVA: 0x006BB10A File Offset: 0x006B930A
		// (set) Token: 0x06031B46 RID: 203590 RVA: 0x006BB112 File Offset: 0x006B9312
		public ELeisureInteract Type { get; set; }

		// Token: 0x06031B47 RID: 203591 RVA: 0x006BB11B File Offset: 0x006B931B
		public IQiuyuanQinggongHoveringT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}

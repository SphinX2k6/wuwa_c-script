using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DDE RID: 28126
	public class IQiuyuanQinggongEndT
	{
		// Token: 0x1700D1AD RID: 53677
		// (get) Token: 0x06031AEB RID: 203499 RVA: 0x006BA9B2 File Offset: 0x006B8BB2
		// (set) Token: 0x06031AEC RID: 203500 RVA: 0x006BA9BA File Offset: 0x006B8BBA
		public ELeisureInteract Type { get; set; }

		// Token: 0x06031AED RID: 203501 RVA: 0x006BA9C3 File Offset: 0x006B8BC3
		public IQiuyuanQinggongEndT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}

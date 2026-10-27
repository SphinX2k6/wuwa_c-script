using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF0 RID: 28144
	public class IQiuyuanQinggongStraightT
	{
		// Token: 0x1700D1BF RID: 53695
		// (get) Token: 0x06031B57 RID: 203607 RVA: 0x006BB282 File Offset: 0x006B9482
		// (set) Token: 0x06031B58 RID: 203608 RVA: 0x006BB28A File Offset: 0x006B948A
		public ELeisureInteract Type { get; set; }

		// Token: 0x06031B59 RID: 203609 RVA: 0x006BB293 File Offset: 0x006B9493
		public IQiuyuanQinggongStraightT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}

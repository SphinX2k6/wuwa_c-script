using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DDB RID: 28123
	public class IQiuyuanLongPressQinggongT
	{
		// Token: 0x1700D1AA RID: 53674
		// (get) Token: 0x06031AD9 RID: 203481 RVA: 0x006BA83A File Offset: 0x006B8A3A
		// (set) Token: 0x06031ADA RID: 203482 RVA: 0x006BA842 File Offset: 0x006B8A42
		public ELeisureInteract Type { get; set; }

		// Token: 0x06031ADB RID: 203483 RVA: 0x006BA84B File Offset: 0x006B8A4B
		public IQiuyuanLongPressQinggongT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}

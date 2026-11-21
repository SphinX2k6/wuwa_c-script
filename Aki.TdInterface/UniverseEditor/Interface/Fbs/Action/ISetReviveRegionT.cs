using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007837 RID: 30775
	public class ISetReviveRegionT
	{
		// Token: 0x1700E1CC RID: 57804
		// (get) Token: 0x060361F5 RID: 221685 RVA: 0x007402A8 File Offset: 0x0073E4A8
		// (set) Token: 0x060361F6 RID: 221686 RVA: 0x007402B0 File Offset: 0x0073E4B0
		public ESetReviveType SetReviveType { get; set; }

		// Token: 0x1700E1CD RID: 57805
		// (get) Token: 0x060361F7 RID: 221687 RVA: 0x007402B9 File Offset: 0x0073E4B9
		// (set) Token: 0x060361F8 RID: 221688 RVA: 0x007402C1 File Offset: 0x0073E4C1
		public int ReviveId { get; set; }

		// Token: 0x060361F9 RID: 221689 RVA: 0x007402CA File Offset: 0x0073E4CA
		public ISetReviveRegionT()
		{
			this.SetReviveType = ESetReviveType.Add;
			this.ReviveId = 0;
		}
	}
}

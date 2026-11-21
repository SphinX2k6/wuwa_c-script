using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B6D RID: 27501
	public class ICustomScreenLoadingT
	{
		// Token: 0x1700C9DD RID: 51677
		// (get) Token: 0x0602F541 RID: 193857 RVA: 0x006759A3 File Offset: 0x00673BA3
		// (set) Token: 0x0602F542 RID: 193858 RVA: 0x006759AB File Offset: 0x00673BAB
		public ECustomScreenType Type { get; set; }

		// Token: 0x1700C9DE RID: 51678
		// (get) Token: 0x0602F543 RID: 193859 RVA: 0x006759B4 File Offset: 0x00673BB4
		// (set) Token: 0x0602F544 RID: 193860 RVA: 0x006759BC File Offset: 0x00673BBC
		public ICustomScreenLoadingCyberpunkT LoadingType { get; set; }

		// Token: 0x0602F545 RID: 193861 RVA: 0x006759C5 File Offset: 0x00673BC5
		public ICustomScreenLoadingT()
		{
			this.Type = ECustomScreenType.Spine;
			this.LoadingType = null;
		}
	}
}

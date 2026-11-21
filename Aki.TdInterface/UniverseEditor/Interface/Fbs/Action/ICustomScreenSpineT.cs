using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B79 RID: 27513
	public class ICustomScreenSpineT
	{
		// Token: 0x1700C9EA RID: 51690
		// (get) Token: 0x0602F587 RID: 193927 RVA: 0x00675FB0 File Offset: 0x006741B0
		// (set) Token: 0x0602F588 RID: 193928 RVA: 0x00675FB8 File Offset: 0x006741B8
		public ECustomScreenType Type { get; set; }

		// Token: 0x1700C9EB RID: 51691
		// (get) Token: 0x0602F589 RID: 193929 RVA: 0x00675FC1 File Offset: 0x006741C1
		// (set) Token: 0x0602F58A RID: 193930 RVA: 0x00675FC9 File Offset: 0x006741C9
		public int SpineId { get; set; }

		// Token: 0x0602F58B RID: 193931 RVA: 0x00675FD2 File Offset: 0x006741D2
		public ICustomScreenSpineT()
		{
			this.Type = ECustomScreenType.Spine;
			this.SpineId = 0;
		}
	}
}

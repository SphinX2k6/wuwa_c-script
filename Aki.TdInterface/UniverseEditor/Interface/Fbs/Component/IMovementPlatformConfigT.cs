using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B7A RID: 23418
	public class IMovementPlatformConfigT
	{
		// Token: 0x1700AB25 RID: 43813
		// (get) Token: 0x06026952 RID: 158034 RVA: 0x00548939 File Offset: 0x00546B39
		// (set) Token: 0x06026953 RID: 158035 RVA: 0x00548941 File Offset: 0x00546B41
		public List<int> PlayerAttachTags { get; set; }

		// Token: 0x1700AB26 RID: 43814
		// (get) Token: 0x06026954 RID: 158036 RVA: 0x0054894A File Offset: 0x00546B4A
		// (set) Token: 0x06026955 RID: 158037 RVA: 0x00548952 File Offset: 0x00546B52
		public int SafePointId { get; set; }

		// Token: 0x1700AB27 RID: 43815
		// (get) Token: 0x06026956 RID: 158038 RVA: 0x0054895B File Offset: 0x00546B5B
		// (set) Token: 0x06026957 RID: 158039 RVA: 0x00548963 File Offset: 0x00546B63
		public byte NullMask { get; set; }

		// Token: 0x06026958 RID: 158040 RVA: 0x0054896C File Offset: 0x00546B6C
		public IMovementPlatformConfigT()
		{
			this.PlayerAttachTags = null;
			this.SafePointId = 0;
			this.NullMask = 0;
		}
	}
}

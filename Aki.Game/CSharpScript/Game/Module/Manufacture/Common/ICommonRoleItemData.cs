using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x0200568E RID: 22158
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonRoleItemData
	{
		// Token: 0x1700877E RID: 34686
		// (get) Token: 0x0603861F RID: 230943 RVA: 0x00D62A16 File Offset: 0x00D60C16
		// (set) Token: 0x06038620 RID: 230944 RVA: 0x00D62A1E File Offset: 0x00D60C1E
		public int RoleId { get; set; }

		// Token: 0x1700877F RID: 34687
		// (get) Token: 0x06038621 RID: 230945 RVA: 0x00D62A27 File Offset: 0x00D60C27
		// (set) Token: 0x06038622 RID: 230946 RVA: 0x00D62A2F File Offset: 0x00D60C2F
		public string RoleName { get; set; } = string.Empty;

		// Token: 0x17008780 RID: 34688
		// (get) Token: 0x06038623 RID: 230947 RVA: 0x00D62A38 File Offset: 0x00D60C38
		// (set) Token: 0x06038624 RID: 230948 RVA: 0x00D62A40 File Offset: 0x00D60C40
		public string RoleIcon { get; set; } = string.Empty;

		// Token: 0x17008781 RID: 34689
		// (get) Token: 0x06038625 RID: 230949 RVA: 0x00D62A49 File Offset: 0x00D60C49
		// (set) Token: 0x06038626 RID: 230950 RVA: 0x00D62A51 File Offset: 0x00D60C51
		public bool IsBuff { get; set; }

		// Token: 0x17008782 RID: 34690
		// (get) Token: 0x06038627 RID: 230951 RVA: 0x00D62A5A File Offset: 0x00D60C5A
		// (set) Token: 0x06038628 RID: 230952 RVA: 0x00D62A62 File Offset: 0x00D60C62
		public int ItemId { get; set; }
	}
}

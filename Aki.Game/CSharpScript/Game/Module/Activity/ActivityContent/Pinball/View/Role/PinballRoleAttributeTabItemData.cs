using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02005283 RID: 21123
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballRoleAttributeTabItemData : IPinballRoleAttributeTabItemData
	{
		// Token: 0x17006629 RID: 26153
		// (get) Token: 0x06034942 RID: 215362 RVA: 0x00EB5602 File Offset: 0x00EB3802
		// (set) Token: 0x06034943 RID: 215363 RVA: 0x00EB560A File Offset: 0x00EB380A
		public EPinballRoleAttributeTabIndex TabIndex { get; set; }

		// Token: 0x1700662A RID: 26154
		// (get) Token: 0x06034944 RID: 215364 RVA: 0x00EB5613 File Offset: 0x00EB3813
		// (set) Token: 0x06034945 RID: 215365 RVA: 0x00EB561B File Offset: 0x00EB381B
		public bool IsSelected { get; set; }

		// Token: 0x1700662B RID: 26155
		// (get) Token: 0x06034946 RID: 215366 RVA: 0x00EB5624 File Offset: 0x00EB3824
		// (set) Token: 0x06034947 RID: 215367 RVA: 0x00EB562C File Offset: 0x00EB382C
		public Action<EPinballRoleAttributeTabIndex> OnSelectedDelegate { get; set; }
	}
}

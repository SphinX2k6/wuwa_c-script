using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02005282 RID: 21122
	[NullableContext(1)]
	public interface IPinballRoleAttributeTabItemData
	{
		// Token: 0x17006626 RID: 26150
		// (get) Token: 0x0603493C RID: 215356
		// (set) Token: 0x0603493D RID: 215357
		EPinballRoleAttributeTabIndex TabIndex { get; set; }

		// Token: 0x17006627 RID: 26151
		// (get) Token: 0x0603493E RID: 215358
		// (set) Token: 0x0603493F RID: 215359
		bool IsSelected { get; set; }

		// Token: 0x17006628 RID: 26152
		// (get) Token: 0x06034940 RID: 215360
		// (set) Token: 0x06034941 RID: 215361
		Action<EPinballRoleAttributeTabIndex> OnSelectedDelegate { get; set; }
	}
}

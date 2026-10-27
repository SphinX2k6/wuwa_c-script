using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006304 RID: 25348
	[NullableContext(1)]
	public interface IPinballRoleAttributeTabItemData
	{
		// Token: 0x170092C4 RID: 37572
		// (get) Token: 0x0603FC7B RID: 261243
		// (set) Token: 0x0603FC7C RID: 261244
		EPinballRoleAttributeTabIndex TabIndex { get; set; }

		// Token: 0x170092C5 RID: 37573
		// (get) Token: 0x0603FC7D RID: 261245
		// (set) Token: 0x0603FC7E RID: 261246
		bool IsSelected { get; set; }

		// Token: 0x170092C6 RID: 37574
		// (get) Token: 0x0603FC7F RID: 261247
		// (set) Token: 0x0603FC80 RID: 261248
		Action<EPinballRoleAttributeTabIndex> OnSelectedDelegate { get; set; }
	}
}

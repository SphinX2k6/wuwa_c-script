using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006305 RID: 25349
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballRoleAttributeTabItemData : IPinballRoleAttributeTabItemData
	{
		// Token: 0x170092C7 RID: 37575
		// (get) Token: 0x0603FC81 RID: 261249 RVA: 0x00F6E6A6 File Offset: 0x00F6C8A6
		// (set) Token: 0x0603FC82 RID: 261250 RVA: 0x00F6E6AE File Offset: 0x00F6C8AE
		public EPinballRoleAttributeTabIndex TabIndex { get; set; }

		// Token: 0x170092C8 RID: 37576
		// (get) Token: 0x0603FC83 RID: 261251 RVA: 0x00F6E6B7 File Offset: 0x00F6C8B7
		// (set) Token: 0x0603FC84 RID: 261252 RVA: 0x00F6E6BF File Offset: 0x00F6C8BF
		public bool IsSelected { get; set; }

		// Token: 0x170092C9 RID: 37577
		// (get) Token: 0x0603FC85 RID: 261253 RVA: 0x00F6E6C8 File Offset: 0x00F6C8C8
		// (set) Token: 0x0603FC86 RID: 261254 RVA: 0x00F6E6D0 File Offset: 0x00F6C8D0
		public Action<EPinballRoleAttributeTabIndex> OnSelectedDelegate { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053F2 RID: 21490
	[NullableContext(1)]
	public interface IRepeatKeyInfo
	{
		// Token: 0x170083FC RID: 33788
		// (get) Token: 0x06036EF4 RID: 225012
		// (set) Token: 0x06036EF5 RID: 225013
		EInputControllerType InputControllerType { get; set; }

		// Token: 0x170083FD RID: 33789
		// (get) Token: 0x06036EF6 RID: 225014
		// (set) Token: 0x06036EF7 RID: 225015
		KeySettingRowData CurrentKeySettingRowData { get; set; }

		// Token: 0x170083FE RID: 33790
		// (get) Token: 0x06036EF8 RID: 225016
		// (set) Token: 0x06036EF9 RID: 225017
		KeySettingRowData RepeatKeySettingRowData { get; set; }

		// Token: 0x170083FF RID: 33791
		// (get) Token: 0x06036EFA RID: 225018
		// (set) Token: 0x06036EFB RID: 225019
		[Nullable(2)]
		Action<bool> OnCloseCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}

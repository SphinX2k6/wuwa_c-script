using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043D5 RID: 17365
	[NullableContext(1)]
	public interface IRepeatKeyInfo
	{
		// Token: 0x170057C8 RID: 22472
		// (get) Token: 0x0602BE3C RID: 179772
		// (set) Token: 0x0602BE3D RID: 179773
		EInputControllerType InputControllerType { get; set; }

		// Token: 0x170057C9 RID: 22473
		// (get) Token: 0x0602BE3E RID: 179774
		// (set) Token: 0x0602BE3F RID: 179775
		KeySettingRowData CurrentKeySettingRowData { get; set; }

		// Token: 0x170057CA RID: 22474
		// (get) Token: 0x0602BE40 RID: 179776
		// (set) Token: 0x0602BE41 RID: 179777
		KeySettingRowData RepeatKeySettingRowData { get; set; }

		// Token: 0x170057CB RID: 22475
		// (get) Token: 0x0602BE42 RID: 179778
		// (set) Token: 0x0602BE43 RID: 179779
		[Nullable(2)]
		Action<bool> OnCloseCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046A9 RID: 18089
	[NullableContext(1)]
	public interface IOpenAndCloseViewHotKey
	{
		// Token: 0x1700763B RID: 30267
		// (get) Token: 0x0602EA29 RID: 191017
		// (set) Token: 0x0602EA2A RID: 191018
		int ConfigId { get; set; }

		// Token: 0x1700763C RID: 30268
		// (get) Token: 0x0602EA2B RID: 191019
		// (set) Token: 0x0602EA2C RID: 191020
		string ActionName { get; set; }

		// Token: 0x1700763D RID: 30269
		// (get) Token: 0x0602EA2D RID: 191021
		// (set) Token: 0x0602EA2E RID: 191022
		EOpenAndCloseViewInputControllerType InputControllerType { get; set; }

		// Token: 0x1700763E RID: 30270
		// (get) Token: 0x0602EA2F RID: 191023
		// (set) Token: 0x0602EA30 RID: 191024
		EUiViewName ViewName { get; set; }

		// Token: 0x1700763F RID: 30271
		// (get) Token: 0x0602EA31 RID: 191025
		// (set) Token: 0x0602EA32 RID: 191026
		string[] ViewParam { get; set; }

		// Token: 0x17007640 RID: 30272
		// (get) Token: 0x0602EA33 RID: 191027
		// (set) Token: 0x0602EA34 RID: 191028
		bool IsPressTrigger { get; set; }

		// Token: 0x17007641 RID: 30273
		// (get) Token: 0x0602EA35 RID: 191029
		// (set) Token: 0x0602EA36 RID: 191030
		int PressStartTime { get; set; }

		// Token: 0x17007642 RID: 30274
		// (get) Token: 0x0602EA37 RID: 191031
		// (set) Token: 0x0602EA38 RID: 191032
		int PressTriggerTime { get; set; }

		// Token: 0x17007643 RID: 30275
		// (get) Token: 0x0602EA39 RID: 191033
		// (set) Token: 0x0602EA3A RID: 191034
		bool IsReleaseTrigger { get; set; }

		// Token: 0x17007644 RID: 30276
		// (get) Token: 0x0602EA3B RID: 191035
		// (set) Token: 0x0602EA3C RID: 191036
		int ReleaseInvalidTime { get; set; }

		// Token: 0x17007645 RID: 30277
		// (get) Token: 0x0602EA3D RID: 191037
		// (set) Token: 0x0602EA3E RID: 191038
		bool IsPressClose { get; set; }

		// Token: 0x17007646 RID: 30278
		// (get) Token: 0x0602EA3F RID: 191039
		// (set) Token: 0x0602EA40 RID: 191040
		bool IsReleaseClose { get; set; }

		// Token: 0x17007647 RID: 30279
		// (get) Token: 0x0602EA41 RID: 191041
		// (set) Token: 0x0602EA42 RID: 191042
		Func<bool> IsAllowOpenViewByShortcutKey { get; set; }

		// Token: 0x17007648 RID: 30280
		// (get) Token: 0x0602EA43 RID: 191043
		// (set) Token: 0x0602EA44 RID: 191044
		Func<bool> IsAllowCloseViewByShortcutKey { get; set; }

		// Token: 0x17007649 RID: 30281
		// (get) Token: 0x0602EA45 RID: 191045
		// (set) Token: 0x0602EA46 RID: 191046
		Func<string, InputDistributeDefine.EActionType, bool> IsLockShortcutKey { get; set; }

		// Token: 0x1700764A RID: 30282
		// (get) Token: 0x0602EA47 RID: 191047
		// (set) Token: 0x0602EA48 RID: 191048
		[Nullable(2)]
		Action OpenViewCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700764B RID: 30283
		// (get) Token: 0x0602EA49 RID: 191049
		// (set) Token: 0x0602EA4A RID: 191050
		[Nullable(2)]
		Action CloseViewCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}

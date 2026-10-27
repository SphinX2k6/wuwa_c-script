using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046AA RID: 18090
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenAndCloseViewHotKey : IOpenAndCloseViewHotKey
	{
		// Token: 0x1700764C RID: 30284
		// (get) Token: 0x0602EA4B RID: 191051 RVA: 0x00ACBF15 File Offset: 0x00ACA115
		// (set) Token: 0x0602EA4C RID: 191052 RVA: 0x00ACBF1D File Offset: 0x00ACA11D
		public int ConfigId { get; set; }

		// Token: 0x1700764D RID: 30285
		// (get) Token: 0x0602EA4D RID: 191053 RVA: 0x00ACBF26 File Offset: 0x00ACA126
		// (set) Token: 0x0602EA4E RID: 191054 RVA: 0x00ACBF2E File Offset: 0x00ACA12E
		public string ActionName { get; set; }

		// Token: 0x1700764E RID: 30286
		// (get) Token: 0x0602EA4F RID: 191055 RVA: 0x00ACBF37 File Offset: 0x00ACA137
		// (set) Token: 0x0602EA50 RID: 191056 RVA: 0x00ACBF3F File Offset: 0x00ACA13F
		public EOpenAndCloseViewInputControllerType InputControllerType { get; set; }

		// Token: 0x1700764F RID: 30287
		// (get) Token: 0x0602EA51 RID: 191057 RVA: 0x00ACBF48 File Offset: 0x00ACA148
		// (set) Token: 0x0602EA52 RID: 191058 RVA: 0x00ACBF50 File Offset: 0x00ACA150
		public EUiViewName ViewName { get; set; }

		// Token: 0x17007650 RID: 30288
		// (get) Token: 0x0602EA53 RID: 191059 RVA: 0x00ACBF59 File Offset: 0x00ACA159
		// (set) Token: 0x0602EA54 RID: 191060 RVA: 0x00ACBF61 File Offset: 0x00ACA161
		public string[] ViewParam { get; set; }

		// Token: 0x17007651 RID: 30289
		// (get) Token: 0x0602EA55 RID: 191061 RVA: 0x00ACBF6A File Offset: 0x00ACA16A
		// (set) Token: 0x0602EA56 RID: 191062 RVA: 0x00ACBF72 File Offset: 0x00ACA172
		public bool IsPressTrigger { get; set; }

		// Token: 0x17007652 RID: 30290
		// (get) Token: 0x0602EA57 RID: 191063 RVA: 0x00ACBF7B File Offset: 0x00ACA17B
		// (set) Token: 0x0602EA58 RID: 191064 RVA: 0x00ACBF83 File Offset: 0x00ACA183
		public int PressStartTime { get; set; }

		// Token: 0x17007653 RID: 30291
		// (get) Token: 0x0602EA59 RID: 191065 RVA: 0x00ACBF8C File Offset: 0x00ACA18C
		// (set) Token: 0x0602EA5A RID: 191066 RVA: 0x00ACBF94 File Offset: 0x00ACA194
		public int PressTriggerTime { get; set; }

		// Token: 0x17007654 RID: 30292
		// (get) Token: 0x0602EA5B RID: 191067 RVA: 0x00ACBF9D File Offset: 0x00ACA19D
		// (set) Token: 0x0602EA5C RID: 191068 RVA: 0x00ACBFA5 File Offset: 0x00ACA1A5
		public bool IsReleaseTrigger { get; set; }

		// Token: 0x17007655 RID: 30293
		// (get) Token: 0x0602EA5D RID: 191069 RVA: 0x00ACBFAE File Offset: 0x00ACA1AE
		// (set) Token: 0x0602EA5E RID: 191070 RVA: 0x00ACBFB6 File Offset: 0x00ACA1B6
		public int ReleaseInvalidTime { get; set; }

		// Token: 0x17007656 RID: 30294
		// (get) Token: 0x0602EA5F RID: 191071 RVA: 0x00ACBFBF File Offset: 0x00ACA1BF
		// (set) Token: 0x0602EA60 RID: 191072 RVA: 0x00ACBFC7 File Offset: 0x00ACA1C7
		public bool IsPressClose { get; set; }

		// Token: 0x17007657 RID: 30295
		// (get) Token: 0x0602EA61 RID: 191073 RVA: 0x00ACBFD0 File Offset: 0x00ACA1D0
		// (set) Token: 0x0602EA62 RID: 191074 RVA: 0x00ACBFD8 File Offset: 0x00ACA1D8
		public bool IsReleaseClose { get; set; }

		// Token: 0x17007658 RID: 30296
		// (get) Token: 0x0602EA63 RID: 191075 RVA: 0x00ACBFE1 File Offset: 0x00ACA1E1
		// (set) Token: 0x0602EA64 RID: 191076 RVA: 0x00ACBFE9 File Offset: 0x00ACA1E9
		public Func<bool> IsAllowOpenViewByShortcutKey { get; set; }

		// Token: 0x17007659 RID: 30297
		// (get) Token: 0x0602EA65 RID: 191077 RVA: 0x00ACBFF2 File Offset: 0x00ACA1F2
		// (set) Token: 0x0602EA66 RID: 191078 RVA: 0x00ACBFFA File Offset: 0x00ACA1FA
		public Func<bool> IsAllowCloseViewByShortcutKey { get; set; }

		// Token: 0x1700765A RID: 30298
		// (get) Token: 0x0602EA67 RID: 191079 RVA: 0x00ACC003 File Offset: 0x00ACA203
		// (set) Token: 0x0602EA68 RID: 191080 RVA: 0x00ACC00B File Offset: 0x00ACA20B
		public Func<string, InputDistributeDefine.EActionType, bool> IsLockShortcutKey { get; set; }

		// Token: 0x1700765B RID: 30299
		// (get) Token: 0x0602EA69 RID: 191081 RVA: 0x00ACC014 File Offset: 0x00ACA214
		// (set) Token: 0x0602EA6A RID: 191082 RVA: 0x00ACC01C File Offset: 0x00ACA21C
		[Nullable(2)]
		public Action OpenViewCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700765C RID: 30300
		// (get) Token: 0x0602EA6B RID: 191083 RVA: 0x00ACC025 File Offset: 0x00ACA225
		// (set) Token: 0x0602EA6C RID: 191084 RVA: 0x00ACC02D File Offset: 0x00ACA22D
		[Nullable(2)]
		public Action CloseViewCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}

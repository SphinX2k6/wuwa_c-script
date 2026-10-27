using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053F3 RID: 21491
	[NullableContext(1)]
	[Nullable(0)]
	public class RepeatKeyInfo : IRepeatKeyInfo
	{
		// Token: 0x17008400 RID: 33792
		// (get) Token: 0x06036EFC RID: 225020 RVA: 0x00D04D95 File Offset: 0x00D02F95
		// (set) Token: 0x06036EFD RID: 225021 RVA: 0x00D04D9D File Offset: 0x00D02F9D
		public EInputControllerType InputControllerType { get; set; }

		// Token: 0x17008401 RID: 33793
		// (get) Token: 0x06036EFE RID: 225022 RVA: 0x00D04DA6 File Offset: 0x00D02FA6
		// (set) Token: 0x06036EFF RID: 225023 RVA: 0x00D04DAE File Offset: 0x00D02FAE
		public KeySettingRowData CurrentKeySettingRowData { get; set; }

		// Token: 0x17008402 RID: 33794
		// (get) Token: 0x06036F00 RID: 225024 RVA: 0x00D04DB7 File Offset: 0x00D02FB7
		// (set) Token: 0x06036F01 RID: 225025 RVA: 0x00D04DBF File Offset: 0x00D02FBF
		public KeySettingRowData RepeatKeySettingRowData { get; set; }

		// Token: 0x17008403 RID: 33795
		// (get) Token: 0x06036F02 RID: 225026 RVA: 0x00D04DC8 File Offset: 0x00D02FC8
		// (set) Token: 0x06036F03 RID: 225027 RVA: 0x00D04DD0 File Offset: 0x00D02FD0
		[Nullable(2)]
		public Action<bool> OnCloseCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}

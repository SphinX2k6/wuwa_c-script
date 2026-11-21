using System;
using System.Runtime.CompilerServices;

// Token: 0x02000284 RID: 644
[NullableContext(2)]
[Nullable(0)]
public class GameSettings : IGameSettings
{
	// Token: 0x170005FF RID: 1535
	// (get) Token: 0x0600271E RID: 10014 RVA: 0x000F0BE9 File Offset: 0x000EEDE9
	// (set) Token: 0x0600271F RID: 10015 RVA: 0x000F0BF1 File Offset: 0x000EEDF1
	public EFunction GameSettingId { get; set; }

	// Token: 0x17000600 RID: 1536
	// (get) Token: 0x06002720 RID: 10016 RVA: 0x000F0BFA File Offset: 0x000EEDFA
	// (set) Token: 0x06002721 RID: 10017 RVA: 0x000F0C02 File Offset: 0x000EEE02
	public EGameSettingsValueType ValueType { get; set; }

	// Token: 0x17000601 RID: 1537
	// (get) Token: 0x06002722 RID: 10018 RVA: 0x000F0C0B File Offset: 0x000EEE0B
	// (set) Token: 0x06002723 RID: 10019 RVA: 0x000F0C13 File Offset: 0x000EEE13
	[Nullable(1)]
	public object GetCallbackOrGlobalKey { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000602 RID: 1538
	// (get) Token: 0x06002724 RID: 10020 RVA: 0x000F0C1C File Offset: 0x000EEE1C
	// (set) Token: 0x06002725 RID: 10021 RVA: 0x000F0C24 File Offset: 0x000EEE24
	public Func<int, EGameSettingsApplyReason, bool> ApplyCallback { get; set; }

	// Token: 0x17000603 RID: 1539
	// (get) Token: 0x06002726 RID: 10022 RVA: 0x000F0C2D File Offset: 0x000EEE2D
	// (set) Token: 0x06002727 RID: 10023 RVA: 0x000F0C35 File Offset: 0x000EEE35
	public Func<float, EGameSettingsApplyReason, bool> ApplyCallbackFloat { get; set; }

	// Token: 0x17000604 RID: 1540
	// (get) Token: 0x06002728 RID: 10024 RVA: 0x000F0C3E File Offset: 0x000EEE3E
	// (set) Token: 0x06002729 RID: 10025 RVA: 0x000F0C46 File Offset: 0x000EEE46
	public Action<int, EGameSettingsApplyReason> HandleDoneCallback { get; set; }

	// Token: 0x17000605 RID: 1541
	// (get) Token: 0x0600272A RID: 10026 RVA: 0x000F0C4F File Offset: 0x000EEE4F
	// (set) Token: 0x0600272B RID: 10027 RVA: 0x000F0C57 File Offset: 0x000EEE57
	public Action<float, EGameSettingsApplyReason> HandleDoneCallbackFloat { get; set; }

	// Token: 0x17000606 RID: 1542
	// (get) Token: 0x0600272C RID: 10028 RVA: 0x000F0C60 File Offset: 0x000EEE60
	// (set) Token: 0x0600272D RID: 10029 RVA: 0x000F0C68 File Offset: 0x000EEE68
	[Nullable(1)]
	public Func<string> DumpCallback { [NullableContext(1)] get; [NullableContext(1)] set; }
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DD2 RID: 3538
[NullableContext(2)]
[Nullable(0)]
public class GameSettings : IGameSettings
{
	// Token: 0x170005D9 RID: 1497
	// (get) Token: 0x060053A7 RID: 21415 RVA: 0x000EA58A File Offset: 0x000E878A
	// (set) Token: 0x060053A8 RID: 21416 RVA: 0x000EA592 File Offset: 0x000E8792
	public EFunction GameSettingId { get; set; }

	// Token: 0x170005DA RID: 1498
	// (get) Token: 0x060053A9 RID: 21417 RVA: 0x000EA59B File Offset: 0x000E879B
	// (set) Token: 0x060053AA RID: 21418 RVA: 0x000EA5A3 File Offset: 0x000E87A3
	public EGameSettingsValueType ValueType { get; set; }

	// Token: 0x170005DB RID: 1499
	// (get) Token: 0x060053AB RID: 21419 RVA: 0x000EA5AC File Offset: 0x000E87AC
	// (set) Token: 0x060053AC RID: 21420 RVA: 0x000EA5B4 File Offset: 0x000E87B4
	[Nullable(1)]
	public object GetCallbackOrGlobalKey { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170005DC RID: 1500
	// (get) Token: 0x060053AD RID: 21421 RVA: 0x000EA5BD File Offset: 0x000E87BD
	// (set) Token: 0x060053AE RID: 21422 RVA: 0x000EA5C5 File Offset: 0x000E87C5
	public Func<int, EGameSettingsApplyReason, bool> ApplyCallback { get; set; }

	// Token: 0x170005DD RID: 1501
	// (get) Token: 0x060053AF RID: 21423 RVA: 0x000EA5CE File Offset: 0x000E87CE
	// (set) Token: 0x060053B0 RID: 21424 RVA: 0x000EA5D6 File Offset: 0x000E87D6
	public Func<float, EGameSettingsApplyReason, bool> ApplyCallbackFloat { get; set; }

	// Token: 0x170005DE RID: 1502
	// (get) Token: 0x060053B1 RID: 21425 RVA: 0x000EA5DF File Offset: 0x000E87DF
	// (set) Token: 0x060053B2 RID: 21426 RVA: 0x000EA5E7 File Offset: 0x000E87E7
	public Action<int, EGameSettingsApplyReason> HandleDoneCallback { get; set; }

	// Token: 0x170005DF RID: 1503
	// (get) Token: 0x060053B3 RID: 21427 RVA: 0x000EA5F0 File Offset: 0x000E87F0
	// (set) Token: 0x060053B4 RID: 21428 RVA: 0x000EA5F8 File Offset: 0x000E87F8
	public Action<float, EGameSettingsApplyReason> HandleDoneCallbackFloat { get; set; }

	// Token: 0x170005E0 RID: 1504
	// (get) Token: 0x060053B5 RID: 21429 RVA: 0x000EA601 File Offset: 0x000E8801
	// (set) Token: 0x060053B6 RID: 21430 RVA: 0x000EA609 File Offset: 0x000E8809
	[Nullable(1)]
	public Func<string> DumpCallback { [NullableContext(1)] get; [NullableContext(1)] set; }
}

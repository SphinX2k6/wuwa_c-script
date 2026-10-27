using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DD1 RID: 3537
[NullableContext(2)]
public interface IGameSettings
{
	// Token: 0x170005D1 RID: 1489
	// (get) Token: 0x0600539F RID: 21407
	EFunction GameSettingId { get; }

	// Token: 0x170005D2 RID: 1490
	// (get) Token: 0x060053A0 RID: 21408
	EGameSettingsValueType ValueType { get; }

	// Token: 0x170005D3 RID: 1491
	// (get) Token: 0x060053A1 RID: 21409
	[Nullable(1)]
	object GetCallbackOrGlobalKey { [NullableContext(1)] get; }

	// Token: 0x170005D4 RID: 1492
	// (get) Token: 0x060053A2 RID: 21410
	Func<int, EGameSettingsApplyReason, bool> ApplyCallback { get; }

	// Token: 0x170005D5 RID: 1493
	// (get) Token: 0x060053A3 RID: 21411
	Func<float, EGameSettingsApplyReason, bool> ApplyCallbackFloat { get; }

	// Token: 0x170005D6 RID: 1494
	// (get) Token: 0x060053A4 RID: 21412
	Action<int, EGameSettingsApplyReason> HandleDoneCallback { get; }

	// Token: 0x170005D7 RID: 1495
	// (get) Token: 0x060053A5 RID: 21413
	Action<float, EGameSettingsApplyReason> HandleDoneCallbackFloat { get; }

	// Token: 0x170005D8 RID: 1496
	// (get) Token: 0x060053A6 RID: 21414
	[Nullable(1)]
	Func<string> DumpCallback { [NullableContext(1)] get; }
}

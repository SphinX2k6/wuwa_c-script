using System;
using System.Runtime.CompilerServices;

// Token: 0x02000283 RID: 643
[NullableContext(2)]
public interface IGameSettings
{
	// Token: 0x170005F7 RID: 1527
	// (get) Token: 0x06002716 RID: 10006
	EFunction GameSettingId { get; }

	// Token: 0x170005F8 RID: 1528
	// (get) Token: 0x06002717 RID: 10007
	EGameSettingsValueType ValueType { get; }

	// Token: 0x170005F9 RID: 1529
	// (get) Token: 0x06002718 RID: 10008
	[Nullable(1)]
	object GetCallbackOrGlobalKey { [NullableContext(1)] get; }

	// Token: 0x170005FA RID: 1530
	// (get) Token: 0x06002719 RID: 10009
	Func<int, EGameSettingsApplyReason, bool> ApplyCallback { get; }

	// Token: 0x170005FB RID: 1531
	// (get) Token: 0x0600271A RID: 10010
	Func<float, EGameSettingsApplyReason, bool> ApplyCallbackFloat { get; }

	// Token: 0x170005FC RID: 1532
	// (get) Token: 0x0600271B RID: 10011
	Action<int, EGameSettingsApplyReason> HandleDoneCallback { get; }

	// Token: 0x170005FD RID: 1533
	// (get) Token: 0x0600271C RID: 10012
	Action<float, EGameSettingsApplyReason> HandleDoneCallbackFloat { get; }

	// Token: 0x170005FE RID: 1534
	// (get) Token: 0x0600271D RID: 10013
	[Nullable(1)]
	Func<string> DumpCallback { [NullableContext(1)] get; }
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02002558 RID: 9560
[NullableContext(1)]
public interface ITriggerConfig
{
	// Token: 0x17002483 RID: 9347
	// (get) Token: 0x060179C6 RID: 96710
	// (set) Token: 0x060179C7 RID: 96711
	string Type { get; set; }

	// Token: 0x17002484 RID: 9348
	// (get) Token: 0x060179C8 RID: 96712
	// (set) Token: 0x060179C9 RID: 96713
	string[] Preset { get; set; }

	// Token: 0x17002485 RID: 9349
	// (get) Token: 0x060179CA RID: 96714
	// (set) Token: 0x060179CB RID: 96715
	string Params { get; set; }

	// Token: 0x17002486 RID: 9350
	// (get) Token: 0x060179CC RID: 96716
	// (set) Token: 0x060179CD RID: 96717
	string Formula { get; set; }

	// Token: 0x17002487 RID: 9351
	// (get) Token: 0x060179CE RID: 96718
	// (set) Token: 0x060179CF RID: 96719
	EExecuteType ExecuteType { get; set; }
}

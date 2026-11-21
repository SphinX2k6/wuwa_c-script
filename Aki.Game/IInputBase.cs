using System;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Input;

// Token: 0x020025BE RID: 9662
public interface IInputBase
{
	// Token: 0x17002583 RID: 9603
	// (get) Token: 0x06018029 RID: 98345
	// (set) Token: 0x0601802A RID: 98346
	CSharpScript.Game.Input.EInputAction Action { get; set; }

	// Token: 0x17002584 RID: 9604
	// (get) Token: 0x0601802B RID: 98347
	// (set) Token: 0x0601802C RID: 98348
	EInputState State { get; set; }

	// Token: 0x17002585 RID: 9605
	// (get) Token: 0x0601802D RID: 98349
	// (set) Token: 0x0601802E RID: 98350
	float Time { get; set; }

	// Token: 0x17002586 RID: 9606
	// (get) Token: 0x0601802F RID: 98351
	// (set) Token: 0x06018030 RID: 98352
	int Id { get; set; }

	// Token: 0x17002587 RID: 9607
	// (get) Token: 0x06018031 RID: 98353
	// (set) Token: 0x06018032 RID: 98354
	float MoveInputYaw { get; set; }
}

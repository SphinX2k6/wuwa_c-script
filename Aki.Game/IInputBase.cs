using System;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Input;

// Token: 0x02003068 RID: 12392
public interface IInputBase
{
	// Token: 0x1700244D RID: 9293
	// (get) Token: 0x0601A671 RID: 108145
	// (set) Token: 0x0601A672 RID: 108146
	CSharpScript.Game.Input.EInputAction Action { get; set; }

	// Token: 0x1700244E RID: 9294
	// (get) Token: 0x0601A673 RID: 108147
	// (set) Token: 0x0601A674 RID: 108148
	EInputState State { get; set; }

	// Token: 0x1700244F RID: 9295
	// (get) Token: 0x0601A675 RID: 108149
	// (set) Token: 0x0601A676 RID: 108150
	float Time { get; set; }

	// Token: 0x17002450 RID: 9296
	// (get) Token: 0x0601A677 RID: 108151
	// (set) Token: 0x0601A678 RID: 108152
	int Id { get; set; }

	// Token: 0x17002451 RID: 9297
	// (get) Token: 0x0601A679 RID: 108153
	// (set) Token: 0x0601A67A RID: 108154
	float MoveInputYaw { get; set; }
}

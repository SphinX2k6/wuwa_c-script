using System;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Input;

// Token: 0x020025BF RID: 9663
public class InputEvent : IInputBase
{
	// Token: 0x17002588 RID: 9608
	// (get) Token: 0x06018033 RID: 98355 RVA: 0x00731889 File Offset: 0x0072FA89
	// (set) Token: 0x06018034 RID: 98356 RVA: 0x00731891 File Offset: 0x0072FA91
	public CSharpScript.Game.Input.EInputAction Action { get; set; }

	// Token: 0x17002589 RID: 9609
	// (get) Token: 0x06018035 RID: 98357 RVA: 0x0073189A File Offset: 0x0072FA9A
	// (set) Token: 0x06018036 RID: 98358 RVA: 0x007318A2 File Offset: 0x0072FAA2
	public EInputState State { get; set; }

	// Token: 0x1700258A RID: 9610
	// (get) Token: 0x06018037 RID: 98359 RVA: 0x007318AB File Offset: 0x0072FAAB
	// (set) Token: 0x06018038 RID: 98360 RVA: 0x007318B3 File Offset: 0x0072FAB3
	public float Time { get; set; }

	// Token: 0x1700258B RID: 9611
	// (get) Token: 0x06018039 RID: 98361 RVA: 0x007318BC File Offset: 0x0072FABC
	// (set) Token: 0x0601803A RID: 98362 RVA: 0x007318C4 File Offset: 0x0072FAC4
	public int Id { get; set; }

	// Token: 0x1700258C RID: 9612
	// (get) Token: 0x0601803B RID: 98363 RVA: 0x007318CD File Offset: 0x0072FACD
	// (set) Token: 0x0601803C RID: 98364 RVA: 0x007318D5 File Offset: 0x0072FAD5
	public float MoveInputYaw { get; set; }

	// Token: 0x0601803D RID: 98365 RVA: 0x007318DE File Offset: 0x0072FADE
	public InputEvent(CSharpScript.Game.Input.EInputAction action, EInputState state, float time, float moveInputYaw = 0f)
	{
		this.Action = action;
		this.State = state;
		this.Time = time;
		this.Id = -1;
		this.MoveInputYaw = moveInputYaw;
	}
}

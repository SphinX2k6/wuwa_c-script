using System;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Input;

// Token: 0x02003069 RID: 12393
public class InputEvent : IInputBase
{
	// Token: 0x17002452 RID: 9298
	// (get) Token: 0x0601A67B RID: 108155 RVA: 0x0070B095 File Offset: 0x00709295
	// (set) Token: 0x0601A67C RID: 108156 RVA: 0x0070B09D File Offset: 0x0070929D
	public CSharpScript.Game.Input.EInputAction Action { get; set; }

	// Token: 0x17002453 RID: 9299
	// (get) Token: 0x0601A67D RID: 108157 RVA: 0x0070B0A6 File Offset: 0x007092A6
	// (set) Token: 0x0601A67E RID: 108158 RVA: 0x0070B0AE File Offset: 0x007092AE
	public EInputState State { get; set; }

	// Token: 0x17002454 RID: 9300
	// (get) Token: 0x0601A67F RID: 108159 RVA: 0x0070B0B7 File Offset: 0x007092B7
	// (set) Token: 0x0601A680 RID: 108160 RVA: 0x0070B0BF File Offset: 0x007092BF
	public float Time { get; set; }

	// Token: 0x17002455 RID: 9301
	// (get) Token: 0x0601A681 RID: 108161 RVA: 0x0070B0C8 File Offset: 0x007092C8
	// (set) Token: 0x0601A682 RID: 108162 RVA: 0x0070B0D0 File Offset: 0x007092D0
	public int Id { get; set; }

	// Token: 0x17002456 RID: 9302
	// (get) Token: 0x0601A683 RID: 108163 RVA: 0x0070B0D9 File Offset: 0x007092D9
	// (set) Token: 0x0601A684 RID: 108164 RVA: 0x0070B0E1 File Offset: 0x007092E1
	public float MoveInputYaw { get; set; }

	// Token: 0x0601A685 RID: 108165 RVA: 0x0070B0EA File Offset: 0x007092EA
	public InputEvent(CSharpScript.Game.Input.EInputAction action, EInputState state, float time, float moveInputYaw = 0f)
	{
		this.Action = action;
		this.State = state;
		this.Time = time;
		this.Id = -1;
		this.MoveInputYaw = moveInputYaw;
	}
}

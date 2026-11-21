using System;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Input;

// Token: 0x020025C2 RID: 9666
public class InputCache : IInputBase
{
	// Token: 0x17002594 RID: 9620
	// (get) Token: 0x06018050 RID: 98384 RVA: 0x007319C2 File Offset: 0x0072FBC2
	// (set) Token: 0x06018051 RID: 98385 RVA: 0x007319CA File Offset: 0x0072FBCA
	public CSharpScript.Game.Input.EInputAction Action { get; set; }

	// Token: 0x17002595 RID: 9621
	// (get) Token: 0x06018052 RID: 98386 RVA: 0x007319D3 File Offset: 0x0072FBD3
	// (set) Token: 0x06018053 RID: 98387 RVA: 0x007319DB File Offset: 0x0072FBDB
	public EInputState State { get; set; }

	// Token: 0x17002596 RID: 9622
	// (get) Token: 0x06018054 RID: 98388 RVA: 0x007319E4 File Offset: 0x0072FBE4
	// (set) Token: 0x06018055 RID: 98389 RVA: 0x007319EC File Offset: 0x0072FBEC
	public float Time { get; set; }

	// Token: 0x17002597 RID: 9623
	// (get) Token: 0x06018056 RID: 98390 RVA: 0x007319F5 File Offset: 0x0072FBF5
	// (set) Token: 0x06018057 RID: 98391 RVA: 0x007319FD File Offset: 0x0072FBFD
	public float WorldTime { get; set; }

	// Token: 0x17002598 RID: 9624
	// (get) Token: 0x06018058 RID: 98392 RVA: 0x00731A06 File Offset: 0x0072FC06
	// (set) Token: 0x06018059 RID: 98393 RVA: 0x00731A0E File Offset: 0x0072FC0E
	public int Id { get; set; }

	// Token: 0x17002599 RID: 9625
	// (get) Token: 0x0601805A RID: 98394 RVA: 0x00731A17 File Offset: 0x0072FC17
	// (set) Token: 0x0601805B RID: 98395 RVA: 0x00731A1F File Offset: 0x0072FC1F
	public float MoveInputYaw { get; set; }

	// Token: 0x1700259A RID: 9626
	// (get) Token: 0x0601805C RID: 98396 RVA: 0x00731A28 File Offset: 0x0072FC28
	// (set) Token: 0x0601805D RID: 98397 RVA: 0x00731A30 File Offset: 0x0072FC30
	public double AccumulateTime { get; set; }

	// Token: 0x0601805E RID: 98398 RVA: 0x00731A39 File Offset: 0x0072FC39
	public InputCache(CSharpScript.Game.Input.EInputAction action, EInputState state, float time, float worldTime, float accumulateTime, int id = -1, float moveInputYaw = 0f)
	{
		this.Action = action;
		this.State = state;
		this.Time = time;
		this.WorldTime = worldTime;
		this.AccumulateTime = (double)accumulateTime;
		this.Id = id;
		this.MoveInputYaw = moveInputYaw;
	}
}

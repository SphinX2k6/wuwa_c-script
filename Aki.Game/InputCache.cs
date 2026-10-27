using System;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Input;

// Token: 0x0200306B RID: 12395
public class InputCache : IInputBase
{
	// Token: 0x1700245E RID: 9310
	// (get) Token: 0x0601A695 RID: 108181 RVA: 0x0070B1CC File Offset: 0x007093CC
	// (set) Token: 0x0601A696 RID: 108182 RVA: 0x0070B1D4 File Offset: 0x007093D4
	public CSharpScript.Game.Input.EInputAction Action { get; set; }

	// Token: 0x1700245F RID: 9311
	// (get) Token: 0x0601A697 RID: 108183 RVA: 0x0070B1DD File Offset: 0x007093DD
	// (set) Token: 0x0601A698 RID: 108184 RVA: 0x0070B1E5 File Offset: 0x007093E5
	public EInputState State { get; set; }

	// Token: 0x17002460 RID: 9312
	// (get) Token: 0x0601A699 RID: 108185 RVA: 0x0070B1EE File Offset: 0x007093EE
	// (set) Token: 0x0601A69A RID: 108186 RVA: 0x0070B1F6 File Offset: 0x007093F6
	public float Time { get; set; }

	// Token: 0x17002461 RID: 9313
	// (get) Token: 0x0601A69B RID: 108187 RVA: 0x0070B1FF File Offset: 0x007093FF
	// (set) Token: 0x0601A69C RID: 108188 RVA: 0x0070B207 File Offset: 0x00709407
	public float WorldTime { get; set; }

	// Token: 0x17002462 RID: 9314
	// (get) Token: 0x0601A69D RID: 108189 RVA: 0x0070B210 File Offset: 0x00709410
	// (set) Token: 0x0601A69E RID: 108190 RVA: 0x0070B218 File Offset: 0x00709418
	public int Id { get; set; }

	// Token: 0x17002463 RID: 9315
	// (get) Token: 0x0601A69F RID: 108191 RVA: 0x0070B221 File Offset: 0x00709421
	// (set) Token: 0x0601A6A0 RID: 108192 RVA: 0x0070B229 File Offset: 0x00709429
	public float MoveInputYaw { get; set; }

	// Token: 0x17002464 RID: 9316
	// (get) Token: 0x0601A6A1 RID: 108193 RVA: 0x0070B232 File Offset: 0x00709432
	// (set) Token: 0x0601A6A2 RID: 108194 RVA: 0x0070B23A File Offset: 0x0070943A
	public double AccumulateTime { get; set; }

	// Token: 0x0601A6A3 RID: 108195 RVA: 0x0070B243 File Offset: 0x00709443
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

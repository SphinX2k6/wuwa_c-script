using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x020025C1 RID: 9665
[NullableContext(1)]
[Nullable(0)]
public class InputCommand : IInputBase
{
	// Token: 0x1700258D RID: 9613
	// (get) Token: 0x06018041 RID: 98369 RVA: 0x0073190C File Offset: 0x0072FB0C
	// (set) Token: 0x06018042 RID: 98370 RVA: 0x00731914 File Offset: 0x0072FB14
	public CSharpScript.Game.Input.EInputAction Action { get; set; }

	// Token: 0x1700258E RID: 9614
	// (get) Token: 0x06018043 RID: 98371 RVA: 0x0073191D File Offset: 0x0072FB1D
	// (set) Token: 0x06018044 RID: 98372 RVA: 0x00731925 File Offset: 0x0072FB25
	public EInputState State { get; set; }

	// Token: 0x1700258F RID: 9615
	// (get) Token: 0x06018045 RID: 98373 RVA: 0x0073192E File Offset: 0x0072FB2E
	// (set) Token: 0x06018046 RID: 98374 RVA: 0x00731936 File Offset: 0x0072FB36
	public float Time { get; set; }

	// Token: 0x17002590 RID: 9616
	// (get) Token: 0x06018047 RID: 98375 RVA: 0x0073193F File Offset: 0x0072FB3F
	// (set) Token: 0x06018048 RID: 98376 RVA: 0x00731947 File Offset: 0x0072FB47
	public SInputCommand Command { get; set; }

	// Token: 0x17002591 RID: 9617
	// (get) Token: 0x06018049 RID: 98377 RVA: 0x00731950 File Offset: 0x0072FB50
	// (set) Token: 0x0601804A RID: 98378 RVA: 0x00731958 File Offset: 0x0072FB58
	public int Index { get; set; }

	// Token: 0x17002592 RID: 9618
	// (get) Token: 0x0601804B RID: 98379 RVA: 0x00731961 File Offset: 0x0072FB61
	// (set) Token: 0x0601804C RID: 98380 RVA: 0x00731969 File Offset: 0x0072FB69
	public int Id { get; set; }

	// Token: 0x17002593 RID: 9619
	// (get) Token: 0x0601804D RID: 98381 RVA: 0x00731972 File Offset: 0x0072FB72
	// (set) Token: 0x0601804E RID: 98382 RVA: 0x0073197A File Offset: 0x0072FB7A
	public float MoveInputYaw { get; set; }

	// Token: 0x0601804F RID: 98383 RVA: 0x00731983 File Offset: 0x0072FB83
	public InputCommand(CSharpScript.Game.Input.EInputAction action, EInputState state, float time, SInputCommand command, int index)
	{
		this.Action = action;
		this.State = state;
		this.Time = time;
		this.Command = command;
		this.Index = index;
		this.Id = -1;
		this.MoveInputYaw = 0f;
	}
}

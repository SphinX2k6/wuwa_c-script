using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x0200306A RID: 12394
[NullableContext(1)]
[Nullable(0)]
public class InputCommand : IInputBase
{
	// Token: 0x17002457 RID: 9303
	// (get) Token: 0x0601A686 RID: 108166 RVA: 0x0070B116 File Offset: 0x00709316
	// (set) Token: 0x0601A687 RID: 108167 RVA: 0x0070B11E File Offset: 0x0070931E
	public CSharpScript.Game.Input.EInputAction Action { get; set; }

	// Token: 0x17002458 RID: 9304
	// (get) Token: 0x0601A688 RID: 108168 RVA: 0x0070B127 File Offset: 0x00709327
	// (set) Token: 0x0601A689 RID: 108169 RVA: 0x0070B12F File Offset: 0x0070932F
	public EInputState State { get; set; }

	// Token: 0x17002459 RID: 9305
	// (get) Token: 0x0601A68A RID: 108170 RVA: 0x0070B138 File Offset: 0x00709338
	// (set) Token: 0x0601A68B RID: 108171 RVA: 0x0070B140 File Offset: 0x00709340
	public float Time { get; set; }

	// Token: 0x1700245A RID: 9306
	// (get) Token: 0x0601A68C RID: 108172 RVA: 0x0070B149 File Offset: 0x00709349
	// (set) Token: 0x0601A68D RID: 108173 RVA: 0x0070B151 File Offset: 0x00709351
	public SInputCommand Command { get; set; }

	// Token: 0x1700245B RID: 9307
	// (get) Token: 0x0601A68E RID: 108174 RVA: 0x0070B15A File Offset: 0x0070935A
	// (set) Token: 0x0601A68F RID: 108175 RVA: 0x0070B162 File Offset: 0x00709362
	public int Index { get; set; }

	// Token: 0x1700245C RID: 9308
	// (get) Token: 0x0601A690 RID: 108176 RVA: 0x0070B16B File Offset: 0x0070936B
	// (set) Token: 0x0601A691 RID: 108177 RVA: 0x0070B173 File Offset: 0x00709373
	public int Id { get; set; }

	// Token: 0x1700245D RID: 9309
	// (get) Token: 0x0601A692 RID: 108178 RVA: 0x0070B17C File Offset: 0x0070937C
	// (set) Token: 0x0601A693 RID: 108179 RVA: 0x0070B184 File Offset: 0x00709384
	public float MoveInputYaw { get; set; }

	// Token: 0x0601A694 RID: 108180 RVA: 0x0070B18D File Offset: 0x0070938D
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

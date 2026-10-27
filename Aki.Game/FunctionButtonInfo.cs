using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C3A RID: 7226
[NullableContext(1)]
[Nullable(0)]
public class FunctionButtonInfo
{
	// Token: 0x170011D2 RID: 4562
	// (get) Token: 0x0600D98C RID: 55692 RVA: 0x00326B05 File Offset: 0x00324D05
	// (set) Token: 0x0600D98D RID: 55693 RVA: 0x00326B0D File Offset: 0x00324D0D
	public string SpritePath { get; set; }

	// Token: 0x170011D3 RID: 4563
	// (get) Token: 0x0600D98E RID: 55694 RVA: 0x00326B16 File Offset: 0x00324D16
	// (set) Token: 0x0600D98F RID: 55695 RVA: 0x00326B1E File Offset: 0x00324D1E
	public Func<bool> StateFunc { get; set; }

	// Token: 0x170011D4 RID: 4564
	// (get) Token: 0x0600D990 RID: 55696 RVA: 0x00326B27 File Offset: 0x00324D27
	// (set) Token: 0x0600D991 RID: 55697 RVA: 0x00326B2F File Offset: 0x00324D2F
	public Action CallBack { get; set; }

	// Token: 0x0600D992 RID: 55698 RVA: 0x00326B38 File Offset: 0x00324D38
	public FunctionButtonInfo(string spritePath, Func<bool> stateFunc, Action callBack)
	{
		this.SpritePath = spritePath;
		this.StateFunc = stateFunc;
		this.CallBack = callBack;
	}
}

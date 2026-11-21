using System;
using System.Runtime.CompilerServices;

// Token: 0x020010F9 RID: 4345
[NullableContext(1)]
[Nullable(0)]
public class FunctionButtonInfo
{
	// Token: 0x170011F8 RID: 4600
	// (get) Token: 0x0600ADA2 RID: 44450 RVA: 0x00331F05 File Offset: 0x00330105
	// (set) Token: 0x0600ADA3 RID: 44451 RVA: 0x00331F0D File Offset: 0x0033010D
	public string SpritePath { get; set; }

	// Token: 0x170011F9 RID: 4601
	// (get) Token: 0x0600ADA4 RID: 44452 RVA: 0x00331F16 File Offset: 0x00330116
	// (set) Token: 0x0600ADA5 RID: 44453 RVA: 0x00331F1E File Offset: 0x0033011E
	public Func<bool> StateFunc { get; set; }

	// Token: 0x170011FA RID: 4602
	// (get) Token: 0x0600ADA6 RID: 44454 RVA: 0x00331F27 File Offset: 0x00330127
	// (set) Token: 0x0600ADA7 RID: 44455 RVA: 0x00331F2F File Offset: 0x0033012F
	public Action CallBack { get; set; }

	// Token: 0x0600ADA8 RID: 44456 RVA: 0x00331F38 File Offset: 0x00330138
	public FunctionButtonInfo(string spritePath, Func<bool> stateFunc, Action callBack)
	{
		this.SpritePath = spritePath;
		this.StateFunc = stateFunc;
		this.CallBack = callBack;
	}
}

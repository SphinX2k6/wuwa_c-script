using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000140 RID: 320
[NullableContext(1)]
[Nullable(0)]
internal class InputBehaviorAnsState
{
	// Token: 0x1700034A RID: 842
	// (get) Token: 0x060013FD RID: 5117 RVA: 0x00071B21 File Offset: 0x0006FD21
	public IInputBehaviorParam Param { get; }

	// Token: 0x1700034B RID: 843
	// (get) Token: 0x060013FE RID: 5118 RVA: 0x00071B29 File Offset: 0x0006FD29
	public InputBehaviorInputHandler InputHandler { get; }

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x060013FF RID: 5119 RVA: 0x00071B31 File Offset: 0x0006FD31
	public List<InputBehaviorRuntimeState> Behaviors { get; }

	// Token: 0x1700034D RID: 845
	// (get) Token: 0x06001400 RID: 5120 RVA: 0x00071B39 File Offset: 0x0006FD39
	public float TotalDuration { get; }

	// Token: 0x06001401 RID: 5121 RVA: 0x00071B41 File Offset: 0x0006FD41
	public InputBehaviorAnsState(IInputBehaviorParam param, InputBehaviorInputHandler inputHandler, List<InputBehaviorRuntimeState> behaviors, float totalDuration)
	{
		this.Param = param;
		this.InputHandler = inputHandler;
		this.Behaviors = behaviors;
		this.TotalDuration = totalDuration;
	}

	// Token: 0x04000E67 RID: 3687
	public bool Executing;

	// Token: 0x04000E68 RID: 3688
	public bool Executed;
}

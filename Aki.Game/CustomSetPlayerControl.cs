using System;
using System.Runtime.CompilerServices;

// Token: 0x0200240E RID: 9230
[NullableContext(1)]
[Nullable(0)]
public class CustomSetPlayerControl : CustomActionBase
{
	// Token: 0x06017189 RID: 94601 RVA: 0x006C06A3 File Offset: 0x006BE8A3
	public CustomSetPlayerControl(bool forbid, Func<bool, bool> applyPlayerControl, [Nullable(2)] Action callback = null)
	{
		this.Forbid = forbid;
		this.ApplyPlayerControl = applyPlayerControl;
		this.Callback = callback;
	}

	// Token: 0x0601718A RID: 94602 RVA: 0x006C06C0 File Offset: 0x006BE8C0
	protected override void OnRunAction()
	{
		base.Finish(this.ApplyPlayerControl(this.Forbid));
	}

	// Token: 0x0400C268 RID: 49768
	private readonly bool Forbid;

	// Token: 0x0400C269 RID: 49769
	private readonly Func<bool, bool> ApplyPlayerControl;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02002EBB RID: 11963
[NullableContext(1)]
[Nullable(0)]
public class CustomSetPlayerControl : CustomActionBase
{
	// Token: 0x060198A3 RID: 104611 RVA: 0x0069A3E3 File Offset: 0x006985E3
	public CustomSetPlayerControl(bool forbid, Func<bool, bool> applyPlayerControl, [Nullable(2)] Action callback = null)
	{
		this.Forbid = forbid;
		this.ApplyPlayerControl = applyPlayerControl;
		this.Callback = callback;
	}

	// Token: 0x060198A4 RID: 104612 RVA: 0x0069A400 File Offset: 0x00698600
	protected override void OnRunAction()
	{
		base.Finish(this.ApplyPlayerControl(this.Forbid));
	}

	// Token: 0x0400BECD RID: 48845
	private readonly bool Forbid;

	// Token: 0x0400BECE RID: 48846
	private readonly Func<bool, bool> ApplyPlayerControl;
}

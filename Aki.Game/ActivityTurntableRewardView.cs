using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020009FD RID: 2557
public class ActivityTurntableRewardView : UiViewBase
{
	// Token: 0x06006F83 RID: 28547 RVA: 0x00224F66 File Offset: 0x00223166
	[NullableContext(1)]
	public ActivityTurntableRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006F84 RID: 28548 RVA: 0x00224F6F File Offset: 0x0022316F
	protected override void OnAfterShow()
	{
		base.CloseMe(delegate(bool _)
		{
			Action closeFunc = this.CloseFunc;
			if (closeFunc == null)
			{
				return;
			}
			closeFunc();
		});
	}

	// Token: 0x06006F85 RID: 28549 RVA: 0x00224F83 File Offset: 0x00223183
	protected override void OnStart()
	{
		this.CloseFunc = (this.OpenParam as Action);
	}

	// Token: 0x04004508 RID: 17672
	[Nullable(2)]
	private Action CloseFunc;
}

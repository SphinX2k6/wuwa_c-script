using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001545 RID: 5445
public class ActivityTurntableRewardView : UiViewBase
{
	// Token: 0x06009BA5 RID: 39845 RVA: 0x0021B1B6 File Offset: 0x002193B6
	[NullableContext(1)]
	public ActivityTurntableRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009BA6 RID: 39846 RVA: 0x0021B1BF File Offset: 0x002193BF
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

	// Token: 0x06009BA7 RID: 39847 RVA: 0x0021B1D3 File Offset: 0x002193D3
	protected override void OnStart()
	{
		this.CloseFunc = (this.OpenParam as Action);
	}

	// Token: 0x04004462 RID: 17506
	[Nullable(2)]
	private Action CloseFunc;
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Ui;

// Token: 0x02001D45 RID: 7493
public class TrapDefenseEventBossComingTips : UiViewBase
{
	// Token: 0x0600E33D RID: 58173 RVA: 0x00356539 File Offset: 0x00354739
	[NullableContext(1)]
	public TrapDefenseEventBossComingTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E33E RID: 58174 RVA: 0x00356542 File Offset: 0x00354742
	protected override void OnStart()
	{
		this.Data = (this.OpenParam as ITrapDefenseBossComingTipsData);
	}

	// Token: 0x0600E33F RID: 58175 RVA: 0x00356555 File Offset: 0x00354755
	protected override void OnFinishShow()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600E340 RID: 58176 RVA: 0x00356560 File Offset: 0x00354760
	protected override void OnBeforeDestroy()
	{
		ITrapDefenseBossComingTipsData data = this.Data;
		Action action = (data != null) ? data.Callback : null;
		if (action != null)
		{
			action();
		}
	}

	// Token: 0x040068F0 RID: 26864
	[Nullable(2)]
	protected ITrapDefenseBossComingTipsData Data;
}

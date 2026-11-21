using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Ui;

// Token: 0x02001207 RID: 4615
public class TrapDefenseEventBossComingTips : UiViewBase
{
	// Token: 0x0600B75A RID: 46938 RVA: 0x00361F69 File Offset: 0x00360169
	[NullableContext(1)]
	public TrapDefenseEventBossComingTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B75B RID: 46939 RVA: 0x00361F72 File Offset: 0x00360172
	protected override void OnStart()
	{
		this.Data = (this.OpenParam as ITrapDefenseBossComingTipsData);
	}

	// Token: 0x0600B75C RID: 46940 RVA: 0x00361F85 File Offset: 0x00360185
	protected override void OnFinishShow()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600B75D RID: 46941 RVA: 0x00361F90 File Offset: 0x00360190
	protected override void OnBeforeDestroy()
	{
		ITrapDefenseBossComingTipsData data = this.Data;
		Action action = (data != null) ? data.Callback : null;
		if (action != null)
		{
			action();
		}
	}

	// Token: 0x040069CF RID: 27087
	[Nullable(2)]
	protected ITrapDefenseBossComingTipsData Data;
}

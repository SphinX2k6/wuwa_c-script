using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Ui;

// Token: 0x02001208 RID: 4616
public class TrapDefenseEventShopOpenTips : UiViewBase
{
	// Token: 0x0600B75E RID: 46942 RVA: 0x00361FB9 File Offset: 0x003601B9
	[NullableContext(1)]
	public TrapDefenseEventShopOpenTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B75F RID: 46943 RVA: 0x00361FC2 File Offset: 0x003601C2
	protected override void OnStart()
	{
		this.Data = (this.OpenParam as ITrapDefenseShopTipsData);
	}

	// Token: 0x0600B760 RID: 46944 RVA: 0x00361FD5 File Offset: 0x003601D5
	protected override void OnFinishShow()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600B761 RID: 46945 RVA: 0x00361FE0 File Offset: 0x003601E0
	protected override void OnBeforeDestroy()
	{
		ITrapDefenseShopTipsData data = this.Data;
		Action action = (data != null) ? data.Callback : null;
		if (action != null)
		{
			action();
		}
	}

	// Token: 0x040069D0 RID: 27088
	[Nullable(2)]
	protected ITrapDefenseShopTipsData Data;
}

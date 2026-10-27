using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Ui;

// Token: 0x02001D46 RID: 7494
public class TrapDefenseEventShopOpenTips : UiViewBase
{
	// Token: 0x0600E341 RID: 58177 RVA: 0x00356589 File Offset: 0x00354789
	[NullableContext(1)]
	public TrapDefenseEventShopOpenTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E342 RID: 58178 RVA: 0x00356592 File Offset: 0x00354792
	protected override void OnStart()
	{
		this.Data = (this.OpenParam as ITrapDefenseShopTipsData);
	}

	// Token: 0x0600E343 RID: 58179 RVA: 0x003565A5 File Offset: 0x003547A5
	protected override void OnFinishShow()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600E344 RID: 58180 RVA: 0x003565B0 File Offset: 0x003547B0
	protected override void OnBeforeDestroy()
	{
		ITrapDefenseShopTipsData data = this.Data;
		Action action = (data != null) ? data.Callback : null;
		if (action != null)
		{
			action();
		}
	}

	// Token: 0x040068F1 RID: 26865
	[Nullable(2)]
	protected ITrapDefenseShopTipsData Data;
}

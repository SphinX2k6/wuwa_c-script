using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200150F RID: 5391
public class KingShipLoadingView : UiViewBase
{
	// Token: 0x0600D7A2 RID: 55202 RVA: 0x003FF428 File Offset: 0x003FD628
	[NullableContext(1)]
	public KingShipLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D7A3 RID: 55203 RVA: 0x003FF434 File Offset: 0x003FD634
	protected override void OnStart()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
			{
				UiManager.Instance.OpenView(EUiViewName.KingShipMainView, this.OpenParam, null);
				UiBehaviorLevelSequence uiViewSequence3 = this.UiViewSequence;
				if (uiViewSequence3 == null)
				{
					return;
				}
				uiViewSequence3.PlaySequence("Close01", false, null);
			}, false);
		}
		UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
		if (uiViewSequence2 == null)
		{
			return;
		}
		uiViewSequence2.AddSequenceFinishEvent("Close01", delegate(string _)
		{
			base.CloseMe(null);
		}, false);
	}
}

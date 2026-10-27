using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200203C RID: 8252
public class KingShipLoadingView : UiViewBase
{
	// Token: 0x0601033A RID: 66362 RVA: 0x003F2E30 File Offset: 0x003F1030
	[NullableContext(1)]
	public KingShipLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601033B RID: 66363 RVA: 0x003F2E3C File Offset: 0x003F103C
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

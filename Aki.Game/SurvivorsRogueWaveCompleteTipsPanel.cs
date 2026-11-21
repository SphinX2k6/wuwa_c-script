using System;

// Token: 0x020011E6 RID: 4582
public class SurvivorsRogueWaveCompleteTipsPanel : SurvivorsRogueTipsPanelBase
{
	// Token: 0x0600B601 RID: 46593 RVA: 0x0035C610 File Offset: 0x0035A810
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				this.SequencePlayer.PlayOrReplaySequenceByName("Close", false, null);
				return;
			}
			if (sequenceName == "Close")
			{
				base.Hide(null);
				SurvivorsRogueController.Instance.RequestEnterStep(ESurvivorsStepType.End);
			}
		}, false);
	}
}

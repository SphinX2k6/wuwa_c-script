using System;

// Token: 0x02001D24 RID: 7460
public class SurvivorsRogueWaveCompleteTipsPanel : SurvivorsRogueTipsPanelBase
{
	// Token: 0x0600E1E4 RID: 57828 RVA: 0x00350BE0 File Offset: 0x0034EDE0
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

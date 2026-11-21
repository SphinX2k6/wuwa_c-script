using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001CD6 RID: 7382
public class RoleTowerLoadingView : UiViewBase
{
	// Token: 0x0601247C RID: 74876 RVA: 0x00563FCD File Offset: 0x005621CD
	[NullableContext(1)]
	public RoleTowerLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601247D RID: 74877 RVA: 0x00563FD6 File Offset: 0x005621D6
	protected override void OnStart()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
		{
			RoleTowerModel.Instance.OpenActivityMainView(true, delegate(bool success, int _)
			{
				if (!success)
				{
					if (!this.IsFinishing)
					{
						this.IsFinishing = true;
						base.CloseMe(null);
					}
					return;
				}
				this.PlaySyncAndClose();
			}, new Action(this.PlaySyncAndClose));
		}, false);
	}

	// Token: 0x0601247E RID: 74878 RVA: 0x00563FFA File Offset: 0x005621FA
	private void PlaySyncAndClose()
	{
		if (this.IsFinishing)
		{
			return;
		}
		this.IsFinishing = true;
		base.PlaySequence("Sync", delegate
		{
			base.CloseMe(null);
		}, false);
	}

	// Token: 0x04009F95 RID: 40853
	private bool IsFinishing;
}

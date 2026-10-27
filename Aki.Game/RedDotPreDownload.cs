using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033FF RID: 13311
public class RedDotPreDownload : RedDotBase
{
	// Token: 0x0601CCE4 RID: 117988 RVA: 0x0080AD4C File Offset: 0x00808F4C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PreDownloadStateUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CCE5 RID: 117989 RVA: 0x0080AD6A File Offset: 0x00808F6A
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PreDownloadStateUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CCE6 RID: 117990 RVA: 0x0080AD88 File Offset: 0x00808F88
	protected override bool OnCheck(int uId = 0)
	{
		return PreDownloadModel.Instance.HasClickBtnCheck() && !PreDownloadModel.Instance.IsComplete();
	}
}

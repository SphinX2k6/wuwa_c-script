using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002971 RID: 10609
public class RedDotPreDownload : RedDotBase
{
	// Token: 0x0601A9DC RID: 109020 RVA: 0x00831310 File Offset: 0x0082F510
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PreDownloadStateUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A9DD RID: 109021 RVA: 0x0083132E File Offset: 0x0082F52E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PreDownloadStateUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A9DE RID: 109022 RVA: 0x0083134C File Offset: 0x0082F54C
	protected override bool OnCheck(int uId = 0)
	{
		return PreDownloadModel.Instance.HasClickBtnCheck() && !PreDownloadModel.Instance.IsComplete();
	}
}

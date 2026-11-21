using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002972 RID: 10610
public class RedDotPreDownloadComplete : RedDotBase
{
	// Token: 0x0601A9E0 RID: 109024 RVA: 0x00831371 File Offset: 0x0082F571
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PreDownloadStateUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A9E1 RID: 109025 RVA: 0x0083138F File Offset: 0x0082F58F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PreDownloadStateUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A9E2 RID: 109026 RVA: 0x008313AD File Offset: 0x0082F5AD
	protected override bool OnCheck(int uId = 0)
	{
		return PreDownloadModel.Instance.IsComplete();
	}
}

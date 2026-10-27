using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003400 RID: 13312
public class RedDotPreDownloadComplete : RedDotBase
{
	// Token: 0x0601CCE8 RID: 117992 RVA: 0x0080ADAD File Offset: 0x00808FAD
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PreDownloadStateUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CCE9 RID: 117993 RVA: 0x0080ADCB File Offset: 0x00808FCB
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PreDownloadStateUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CCEA RID: 117994 RVA: 0x0080ADE9 File Offset: 0x00808FE9
	protected override bool OnCheck(int uId = 0)
	{
		return PreDownloadModel.Instance.IsComplete();
	}
}

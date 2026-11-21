using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x02002969 RID: 10601
public class RedDotPhantomArenaTaskReward : RedDotBase
{
	// Token: 0x0601A9B2 RID: 108978 RVA: 0x00830E31 File Offset: 0x0082F031
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaLimitReward);
	}

	// Token: 0x0601A9B3 RID: 108979 RVA: 0x00830E3D File Offset: 0x0082F03D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9B4 RID: 108980 RVA: 0x00830E5B File Offset: 0x0082F05B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9B5 RID: 108981 RVA: 0x00830E79 File Offset: 0x0082F079
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A9B6 RID: 108982 RVA: 0x00830E7C File Offset: 0x0082F07C
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomArenaModel.Instance.CheckTaskRedDot(uId);
	}
}

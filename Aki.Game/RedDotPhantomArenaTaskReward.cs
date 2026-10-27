using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x020033F7 RID: 13303
public class RedDotPhantomArenaTaskReward : RedDotBase
{
	// Token: 0x0601CCBA RID: 117946 RVA: 0x0080A86D File Offset: 0x00808A6D
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaLimitReward);
	}

	// Token: 0x0601CCBB RID: 117947 RVA: 0x0080A879 File Offset: 0x00808A79
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCBC RID: 117948 RVA: 0x0080A897 File Offset: 0x00808A97
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhantomArenaTaskAwardUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCBD RID: 117949 RVA: 0x0080A8B5 File Offset: 0x00808AB5
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CCBE RID: 117950 RVA: 0x0080A8B8 File Offset: 0x00808AB8
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomArenaModel.Instance.CheckTaskRedDot(uId);
	}
}

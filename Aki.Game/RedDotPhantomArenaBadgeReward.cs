using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x020033EC RID: 13292
public class RedDotPhantomArenaBadgeReward : RedDotBase
{
	// Token: 0x0601CC84 RID: 117892 RVA: 0x0080A4E2 File Offset: 0x008086E2
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaCollect);
	}

	// Token: 0x0601CC85 RID: 117893 RVA: 0x0080A4EE File Offset: 0x008086EE
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC86 RID: 117894 RVA: 0x0080A4F1 File Offset: 0x008086F1
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomArenaBadgeRewardUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC87 RID: 117895 RVA: 0x0080A50F File Offset: 0x0080870F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaBadgeRewardUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC88 RID: 117896 RVA: 0x0080A52D File Offset: 0x0080872D
	protected override bool OnCheck(int uId = 0)
	{
		return uId != 0 && PhantomArenaModel.Instance.GetBadgeRewardRedDot(uId);
	}
}

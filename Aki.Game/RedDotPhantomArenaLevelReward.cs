using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x02002963 RID: 10595
public class RedDotPhantomArenaLevelReward : RedDotBase
{
	// Token: 0x0601A995 RID: 108949 RVA: 0x00830C3D File Offset: 0x0082EE3D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomArenaMasterInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A996 RID: 108950 RVA: 0x00830C5B File Offset: 0x0082EE5B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaMasterInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A997 RID: 108951 RVA: 0x00830C79 File Offset: 0x0082EE79
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A998 RID: 108952 RVA: 0x00830C7C File Offset: 0x0082EE7C
	protected override bool OnCheck(int uId = 0)
	{
		return uId != 0 && PhantomArenaModel.Instance.GetMasterLevelRewardRedDot(uId);
	}
}

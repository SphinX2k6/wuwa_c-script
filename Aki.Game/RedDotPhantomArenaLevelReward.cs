using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x020033F1 RID: 13297
public class RedDotPhantomArenaLevelReward : RedDotBase
{
	// Token: 0x0601CC9D RID: 117917 RVA: 0x0080A679 File Offset: 0x00808879
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomArenaMasterInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC9E RID: 117918 RVA: 0x0080A697 File Offset: 0x00808897
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaMasterInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC9F RID: 117919 RVA: 0x0080A6B5 File Offset: 0x008088B5
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CCA0 RID: 117920 RVA: 0x0080A6B8 File Offset: 0x008088B8
	protected override bool OnCheck(int uId = 0)
	{
		return uId != 0 && PhantomArenaModel.Instance.GetMasterLevelRewardRedDot(uId);
	}
}

using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x020033F4 RID: 13300
public class RedDotPhantomArenaMapUnlockDropDownItem : RedDotBase
{
	// Token: 0x0601CCA6 RID: 117926 RVA: 0x0080A6F1 File Offset: 0x008088F1
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaMapUnlock);
	}

	// Token: 0x0601CCA7 RID: 117927 RVA: 0x0080A6FD File Offset: 0x008088FD
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaMapUnlockUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCA8 RID: 117928 RVA: 0x0080A71B File Offset: 0x0080891B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhantomArenaMapUnlockUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CCA9 RID: 117929 RVA: 0x0080A739 File Offset: 0x00808939
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomArenaModel.Instance.GetMapUnlockRedDotById(uId);
	}

	// Token: 0x0601CCAA RID: 117930 RVA: 0x0080A746 File Offset: 0x00808946
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CCAB RID: 117931 RVA: 0x0080A749 File Offset: 0x00808949
	protected override int GetParentCheckUid(int uId)
	{
		PhantomArenaActivityData permanentPhantomArenaActivityData = PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityData();
		if (permanentPhantomArenaActivityData == null)
		{
			return 0;
		}
		return permanentPhantomArenaActivityData.Id;
	}
}

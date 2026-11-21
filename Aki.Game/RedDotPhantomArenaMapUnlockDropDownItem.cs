using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x02002966 RID: 10598
public class RedDotPhantomArenaMapUnlockDropDownItem : RedDotBase
{
	// Token: 0x0601A99E RID: 108958 RVA: 0x00830CB5 File Offset: 0x0082EEB5
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaMapUnlock);
	}

	// Token: 0x0601A99F RID: 108959 RVA: 0x00830CC1 File Offset: 0x0082EEC1
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaMapUnlockUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9A0 RID: 108960 RVA: 0x00830CDF File Offset: 0x0082EEDF
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhantomArenaMapUnlockUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A9A1 RID: 108961 RVA: 0x00830CFD File Offset: 0x0082EEFD
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomArenaModel.Instance.GetMapUnlockRedDotById(uId);
	}

	// Token: 0x0601A9A2 RID: 108962 RVA: 0x00830D0A File Offset: 0x0082EF0A
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A9A3 RID: 108963 RVA: 0x00830D0D File Offset: 0x0082EF0D
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

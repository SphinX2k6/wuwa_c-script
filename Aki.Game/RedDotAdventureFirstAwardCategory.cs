using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003358 RID: 13144
public class RedDotAdventureFirstAwardCategory : RedDotBase
{
	// Token: 0x0601C9DA RID: 117210 RVA: 0x0080518E File Offset: 0x0080338E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RedDotSilentFirstAwardCategory, new Action<int>(this.OnRedDotSilentFirstAwardCategory));
	}

	// Token: 0x0601C9DB RID: 117211 RVA: 0x008051AC File Offset: 0x008033AC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RedDotSilentFirstAwardCategory, new Action<int>(this.OnRedDotSilentFirstAwardCategory));
	}

	// Token: 0x0601C9DC RID: 117212 RVA: 0x008051CA File Offset: 0x008033CA
	protected override bool OnCheck(int uId = 0)
	{
		return AdventureGuideController.Instance.CheckCanGetFirstAwardByTypeId(uId);
	}

	// Token: 0x0601C9DD RID: 117213 RVA: 0x008051D7 File Offset: 0x008033D7
	private void OnRedDotSilentFirstAwardCategory(int _)
	{
		base.EventCheck();
	}
}

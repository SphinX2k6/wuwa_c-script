using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028CA RID: 10442
public class RedDotAdventureFirstAwardCategory : RedDotBase
{
	// Token: 0x0601A6D2 RID: 108242 RVA: 0x0082B752 File Offset: 0x00829952
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RedDotSilentFirstAwardCategory, new Action<int>(this.OnRedDotSilentFirstAwardCategory));
	}

	// Token: 0x0601A6D3 RID: 108243 RVA: 0x0082B770 File Offset: 0x00829970
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RedDotSilentFirstAwardCategory, new Action<int>(this.OnRedDotSilentFirstAwardCategory));
	}

	// Token: 0x0601A6D4 RID: 108244 RVA: 0x0082B78E File Offset: 0x0082998E
	protected override bool OnCheck(int uId = 0)
	{
		return AdventureGuideController.Instance.CheckCanGetFirstAwardByTypeId(uId);
	}

	// Token: 0x0601A6D5 RID: 108245 RVA: 0x0082B79B File Offset: 0x0082999B
	private void OnRedDotSilentFirstAwardCategory(int _)
	{
		base.EventCheck();
	}
}

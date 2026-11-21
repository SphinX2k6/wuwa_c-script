using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002997 RID: 10647
public class RedDotFlySkinChildTab : RedDotBase
{
	// Token: 0x0601AA92 RID: 109202 RVA: 0x00832FF9 File Offset: 0x008311F9
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AA93 RID: 109203 RVA: 0x00832FFC File Offset: 0x008311FC
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FlySkinTab);
	}

	// Token: 0x0601AA94 RID: 109204 RVA: 0x00833005 File Offset: 0x00831205
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<EFlySkinType>(EEventName.RefreshFlySkinChildTabRed, new Action<EFlySkinType>(this.OnRefreshFlySkinChildTabRed));
	}

	// Token: 0x0601AA95 RID: 109205 RVA: 0x00833023 File Offset: 0x00831223
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<EFlySkinType>(EEventName.RefreshFlySkinChildTabRed, new Action<EFlySkinType>(this.OnRefreshFlySkinChildTabRed));
	}

	// Token: 0x0601AA96 RID: 109206 RVA: 0x00833041 File Offset: 0x00831241
	protected override bool OnCheck(int uId = 0)
	{
		return FlySkinModel.Instance.CheckFlySkinHasRedDotBySkinType((EFlySkinType)uId);
	}

	// Token: 0x0601AA97 RID: 109207 RVA: 0x0083304E File Offset: 0x0083124E
	private void OnRefreshFlySkinChildTabRed(EFlySkinType skinType)
	{
		base.EventCheckWithUid((int)skinType);
	}
}

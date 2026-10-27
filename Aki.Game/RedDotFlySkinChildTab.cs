using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003425 RID: 13349
public class RedDotFlySkinChildTab : RedDotBase
{
	// Token: 0x0601CD9A RID: 118170 RVA: 0x0080CA35 File Offset: 0x0080AC35
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CD9B RID: 118171 RVA: 0x0080CA38 File Offset: 0x0080AC38
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FlySkinTab);
	}

	// Token: 0x0601CD9C RID: 118172 RVA: 0x0080CA41 File Offset: 0x0080AC41
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<EFlySkinType>(EEventName.RefreshFlySkinChildTabRed, new Action<EFlySkinType>(this.OnRefreshFlySkinChildTabRed));
	}

	// Token: 0x0601CD9D RID: 118173 RVA: 0x0080CA5F File Offset: 0x0080AC5F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<EFlySkinType>(EEventName.RefreshFlySkinChildTabRed, new Action<EFlySkinType>(this.OnRefreshFlySkinChildTabRed));
	}

	// Token: 0x0601CD9E RID: 118174 RVA: 0x0080CA7D File Offset: 0x0080AC7D
	protected override bool OnCheck(int uId = 0)
	{
		return FlySkinModel.Instance.CheckFlySkinHasRedDotBySkinType((EFlySkinType)uId);
	}

	// Token: 0x0601CD9F RID: 118175 RVA: 0x0080CA8A File Offset: 0x0080AC8A
	private void OnRefreshFlySkinChildTabRed(EFlySkinType skinType)
	{
		base.EventCheckWithUid((int)skinType);
	}
}

using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200076E RID: 1902
public class LordGymActivityData : ActivityBaseData
{
	// Token: 0x06005758 RID: 22360 RVA: 0x001C9BDA File Offset: 0x001C7DDA
	public void RefreshActivityRedDotState()
	{
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06005759 RID: 22361 RVA: 0x001C9BF2 File Offset: 0x001C7DF2
	public void ReadRedDot()
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x0600575A RID: 22362 RVA: 0x001C9C1F File Offset: 0x001C7E1F
	public bool CheckRedDot()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, 0, 0) == 0;
	}

	// Token: 0x0600575B RID: 22363 RVA: 0x001C9C39 File Offset: 0x001C7E39
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckRedDot();
	}

	// Token: 0x04003BD9 RID: 15321
	private const int LORD_GYM_RED_DOT_CACHE_KEY = 100;
}

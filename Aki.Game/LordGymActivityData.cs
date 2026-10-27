using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020012BA RID: 4794
public class LordGymActivityData : ActivityBaseData
{
	// Token: 0x060083BD RID: 33725 RVA: 0x001C0D7E File Offset: 0x001BEF7E
	public void RefreshActivityRedDotState()
	{
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060083BE RID: 33726 RVA: 0x001C0D96 File Offset: 0x001BEF96
	public void ReadRedDot()
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060083BF RID: 33727 RVA: 0x001C0DC3 File Offset: 0x001BEFC3
	public bool CheckRedDot()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, 0, 0) == 0;
	}

	// Token: 0x060083C0 RID: 33728 RVA: 0x001C0DDD File Offset: 0x001BEFDD
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckRedDot();
	}

	// Token: 0x04003B41 RID: 15169
	private const int LORD_GYM_RED_DOT_CACHE_KEY = 100;
}

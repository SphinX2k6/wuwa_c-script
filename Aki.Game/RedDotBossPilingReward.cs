using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BossPiling;

// Token: 0x020028DD RID: 10461
public class RedDotBossPilingReward : RedDotBase
{
	// Token: 0x0601A72C RID: 108332 RVA: 0x0082C15C File Offset: 0x0082A35C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnBossPilingReward, new Action(base.EventCheck));
	}

	// Token: 0x0601A72D RID: 108333 RVA: 0x0082C17A File Offset: 0x0082A37A
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnBossPilingReward, new Action(base.EventCheck));
	}

	// Token: 0x0601A72E RID: 108334 RVA: 0x0082C198 File Offset: 0x0082A398
	protected override bool OnCheck(int uId = 0)
	{
		BossPilingActivityData activityData = BossPilingModel.Instance.GetActivityData();
		return activityData != null && activityData.CheckTaskRedDot();
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020009BF RID: 2495
public class ActivitySoarData : ActivityBaseData
{
	// Token: 0x06006D7C RID: 28028 RVA: 0x0021DB48 File Offset: 0x0021BD48
	[NullableContext(1)]
	protected override void PhraseEx(ActivityData data)
	{
		JinzhouFlyData jinzhouFlyData = data.JinzhouFlyData;
		if (jinzhouFlyData == null)
		{
			return;
		}
		this.QuestId = jinzhouFlyData.QuestId;
	}

	// Token: 0x06006D7D RID: 28029 RVA: 0x0021DB6C File Offset: 0x0021BD6C
	protected override bool GetExDataFinishShowState()
	{
		return QuestNewModel.Instance.CheckQuestFinished(this.QuestId);
	}

	// Token: 0x06006D7E RID: 28030 RVA: 0x0021DB7E File Offset: 0x0021BD7E
	public override bool GetExDataRedPointShowState()
	{
		return !this.GetExDataFinishShowState() && this.IsFirstClick();
	}

	// Token: 0x06006D7F RID: 28031 RVA: 0x0021DB90 File Offset: 0x0021BD90
	public bool IsFirstClick()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, 0, 0) == 0;
	}

	// Token: 0x06006D80 RID: 28032 RVA: 0x0021DBAC File Offset: 0x0021BDAC
	public void SaveFirstClick()
	{
		if (this.IsFirstClick())
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}
	}

	// Token: 0x06006D81 RID: 28033 RVA: 0x0021DBE1 File Offset: 0x0021BDE1
	public int GetQuestId()
	{
		return this.QuestId;
	}

	// Token: 0x0400441B RID: 17435
	private const int SOAR_RED_DOT_CACHE_KEY = 100;

	// Token: 0x0400441C RID: 17436
	private int QuestId;
}

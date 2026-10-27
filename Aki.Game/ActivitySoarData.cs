using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001507 RID: 5383
public class ActivitySoarData : ActivityBaseData
{
	// Token: 0x0600999E RID: 39326 RVA: 0x00213D90 File Offset: 0x00211F90
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

	// Token: 0x0600999F RID: 39327 RVA: 0x00213DB4 File Offset: 0x00211FB4
	protected override bool GetExDataFinishShowState()
	{
		return QuestNewModel.Instance.CheckQuestFinished(this.QuestId);
	}

	// Token: 0x060099A0 RID: 39328 RVA: 0x00213DC6 File Offset: 0x00211FC6
	public override bool GetExDataRedPointShowState()
	{
		return !this.GetExDataFinishShowState() && this.IsFirstClick();
	}

	// Token: 0x060099A1 RID: 39329 RVA: 0x00213DD8 File Offset: 0x00211FD8
	public bool IsFirstClick()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, 0, 0) == 0;
	}

	// Token: 0x060099A2 RID: 39330 RVA: 0x00213DF4 File Offset: 0x00211FF4
	public void SaveFirstClick()
	{
		if (this.IsFirstClick())
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}
	}

	// Token: 0x060099A3 RID: 39331 RVA: 0x00213E29 File Offset: 0x00212029
	public int GetQuestId()
	{
		return this.QuestId;
	}

	// Token: 0x04004375 RID: 17269
	private const int SOAR_RED_DOT_CACHE_KEY = 100;

	// Token: 0x04004376 RID: 17270
	private int QuestId;
}

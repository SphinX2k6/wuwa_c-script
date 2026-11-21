using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SolarSchool;

// Token: 0x020029A2 RID: 10658
public class RedDotSolarSchoolQuestItem : RedDotBase
{
	// Token: 0x0601AACB RID: 109259 RVA: 0x00833720 File Offset: 0x00831920
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotSolarSchoolQuest);
	}

	// Token: 0x0601AACC RID: 109260 RVA: 0x0083372C File Offset: 0x0083192C
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AACD RID: 109261 RVA: 0x00833730 File Offset: 0x00831930
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestUnlocked, new Action<int>(this.OnQuestChanged));
		EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestUnlockRedDotChanged, new Action<int>(this.OnQuestChanged));
		EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(base.EventCheck));
	}

	// Token: 0x0601AACE RID: 109262 RVA: 0x00833794 File Offset: 0x00831994
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestUnlocked, new Action<int>(this.OnQuestChanged));
		EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestUnlockRedDotChanged, new Action<int>(this.OnQuestChanged));
		EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(base.EventCheck));
	}

	// Token: 0x0601AACF RID: 109263 RVA: 0x008337F8 File Offset: 0x008319F8
	protected override bool OnCheck(int uId = 0)
	{
		SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
		SolarSchoolSingleQuestData questData = instance.QuestData.GetQuestData(uId);
		return instance.IsInGamePlay && questData != null && questData.ShouldShowQuestUnlockRedDot;
	}

	// Token: 0x0601AAD0 RID: 109264 RVA: 0x00833829 File Offset: 0x00831A29
	private void OnQuestChanged(int questId)
	{
		base.EventCheckWithUid(questId);
	}
}

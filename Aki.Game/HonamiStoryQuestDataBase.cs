using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001336 RID: 4918
[NullableContext(1)]
[Nullable(0)]
public abstract class HonamiStoryQuestDataBase : IStaticVariableResetter
{
	// Token: 0x0600C1B6 RID: 49590 RVA: 0x0039545E File Offset: 0x0039365E
	static HonamiStoryQuestDataBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HonamiStoryQuestDataBase.CreateStaticDefaultValue), new Action(HonamiStoryQuestDataBase.ResetStaticDefaultValue));
	}

	// Token: 0x0600C1B7 RID: 49591 RVA: 0x0039547D File Offset: 0x0039367D
	public static void CreateStaticDefaultValue()
	{
		HonamiStoryQuestDataBase.IdInternal = 0;
	}

	// Token: 0x0600C1B8 RID: 49592 RVA: 0x00395485 File Offset: 0x00393685
	public static void ResetStaticDefaultValue()
	{
		HonamiStoryQuestDataBase.IdInternal = 0;
	}

	// Token: 0x0600C1B9 RID: 49593 RVA: 0x0039548D File Offset: 0x0039368D
	public HonamiStoryQuestDataBase()
	{
		this.ActivityData = HonamiStoryModel.Instance.GetActivityData(true);
		this.Id = HonamiStoryQuestDataBase.IdInternal++;
	}

	// Token: 0x170012E8 RID: 4840
	// (get) Token: 0x0600C1BA RID: 49594 RVA: 0x003954C0 File Offset: 0x003936C0
	public bool IsInDungeon
	{
		get
		{
			return HonamiStoryUtil.CheckInHonamiStoryDungeon();
		}
	}

	// Token: 0x0600C1BB RID: 49595 RVA: 0x003954C7 File Offset: 0x003936C7
	public bool DoMapTrack(bool isTrack)
	{
		return this.CanMapTrack() && this.MapTrack(isTrack);
	}

	// Token: 0x0600C1BC RID: 49596
	public abstract string GetNameKey();

	// Token: 0x0600C1BD RID: 49597
	public abstract string GetDesc();

	// Token: 0x0600C1BE RID: 49598
	public abstract int GetRewardId();

	// Token: 0x0600C1BF RID: 49599
	public abstract bool IsFinished();

	// Token: 0x0600C1C0 RID: 49600
	[NullableContext(2)]
	public abstract LevelPlayInfo GetLevelPlayInfo();

	// Token: 0x0600C1C1 RID: 49601
	[NullableContext(2)]
	public abstract BehaviorTreeViewShowData GetTreeShowData();

	// Token: 0x0600C1C2 RID: 49602
	public abstract bool CanMapTrack();

	// Token: 0x0600C1C3 RID: 49603
	public abstract bool MapTrack(bool isTrack);

	// Token: 0x04006F20 RID: 28448
	public HonamiStoryActivityData ActivityData;

	// Token: 0x04006F21 RID: 28449
	public EHonamiStoryQuestType TaskType = EHonamiStoryQuestType.Main;

	// Token: 0x04006F22 RID: 28450
	private static int IdInternal;

	// Token: 0x04006F23 RID: 28451
	public int Id;
}

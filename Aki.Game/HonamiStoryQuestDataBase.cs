using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001E74 RID: 7796
[NullableContext(1)]
[Nullable(0)]
public abstract class HonamiStoryQuestDataBase : IStaticVariableResetter
{
	// Token: 0x0600ED97 RID: 60823 RVA: 0x0038986E File Offset: 0x00387A6E
	static HonamiStoryQuestDataBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HonamiStoryQuestDataBase.CreateStaticDefaultValue), new Action(HonamiStoryQuestDataBase.ResetStaticDefaultValue));
	}

	// Token: 0x0600ED98 RID: 60824 RVA: 0x0038988D File Offset: 0x00387A8D
	public static void CreateStaticDefaultValue()
	{
		HonamiStoryQuestDataBase.IdInternal = 0;
	}

	// Token: 0x0600ED99 RID: 60825 RVA: 0x00389895 File Offset: 0x00387A95
	public static void ResetStaticDefaultValue()
	{
		HonamiStoryQuestDataBase.IdInternal = 0;
	}

	// Token: 0x0600ED9A RID: 60826 RVA: 0x0038989D File Offset: 0x00387A9D
	public HonamiStoryQuestDataBase()
	{
		this.ActivityData = HonamiStoryModel.Instance.GetActivityData(true);
		this.Id = HonamiStoryQuestDataBase.IdInternal++;
	}

	// Token: 0x170012BE RID: 4798
	// (get) Token: 0x0600ED9B RID: 60827 RVA: 0x003898D0 File Offset: 0x00387AD0
	public bool IsInDungeon
	{
		get
		{
			return HonamiStoryUtil.CheckInHonamiStoryDungeon();
		}
	}

	// Token: 0x0600ED9C RID: 60828 RVA: 0x003898D7 File Offset: 0x00387AD7
	public bool DoMapTrack(bool isTrack)
	{
		return this.CanMapTrack() && this.MapTrack(isTrack);
	}

	// Token: 0x0600ED9D RID: 60829
	public abstract string GetNameKey();

	// Token: 0x0600ED9E RID: 60830
	public abstract string GetDesc();

	// Token: 0x0600ED9F RID: 60831
	public abstract int GetRewardId();

	// Token: 0x0600EDA0 RID: 60832
	public abstract bool IsFinished();

	// Token: 0x0600EDA1 RID: 60833
	[NullableContext(2)]
	public abstract LevelPlayInfo GetLevelPlayInfo();

	// Token: 0x0600EDA2 RID: 60834
	[NullableContext(2)]
	public abstract BehaviorTreeViewShowData GetTreeShowData();

	// Token: 0x0600EDA3 RID: 60835
	public abstract bool CanMapTrack();

	// Token: 0x0600EDA4 RID: 60836
	public abstract bool MapTrack(bool isTrack);

	// Token: 0x04006E3F RID: 28223
	public HonamiStoryActivityData ActivityData;

	// Token: 0x04006E40 RID: 28224
	public EHonamiStoryQuestType TaskType = EHonamiStoryQuestType.Main;

	// Token: 0x04006E41 RID: 28225
	private static int IdInternal;

	// Token: 0x04006E42 RID: 28226
	public int Id;
}

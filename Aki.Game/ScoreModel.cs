using System;
using System.Runtime.CompilerServices;

// Token: 0x0200295D RID: 10589
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ScoreModel : ModelBase
{
	// Token: 0x06015E45 RID: 89669 RVA: 0x005863E5 File Offset: 0x005845E5
	public int GetCurrentScore()
	{
		return this.CurrentScore;
	}

	// Token: 0x06015E46 RID: 89670 RVA: 0x005863ED File Offset: 0x005845ED
	public int GetTargetScore()
	{
		return this.TargetScore;
	}

	// Token: 0x06015E47 RID: 89671 RVA: 0x005863F5 File Offset: 0x005845F5
	public void SetCurrentScore(int score)
	{
		this.CurrentScore = score;
	}

	// Token: 0x06015E48 RID: 89672 RVA: 0x005863FE File Offset: 0x005845FE
	public void SetTargetScore(int score)
	{
		this.TargetScore = score;
	}

	// Token: 0x06015E49 RID: 89673 RVA: 0x00586407 File Offset: 0x00584607
	public void SetScore(int currentScore, int targetScore)
	{
		this.CurrentScore = currentScore;
		this.TargetScore = targetScore;
	}

	// Token: 0x06015E4A RID: 89674 RVA: 0x00586417 File Offset: 0x00584617
	public void Reset()
	{
		this.CurrentScore = 0;
		this.TargetScore = 0;
	}

	// Token: 0x17001D81 RID: 7553
	// (get) Token: 0x06015E4B RID: 89675 RVA: 0x00586427 File Offset: 0x00584627
	public static ScoreModel Instance
	{
		get
		{
			return ScoreModel._Instance;
		}
	}

	// Token: 0x06015E4C RID: 89676 RVA: 0x0058642E File Offset: 0x0058462E
	public static ScoreModel GetOrCreateInstance()
	{
		if (ScoreModel._Instance == null)
		{
			ScoreModel.CreateInstance();
		}
		return ScoreModel._Instance;
	}

	// Token: 0x06015E4D RID: 89677 RVA: 0x00586442 File Offset: 0x00584642
	public static bool CreateInstance()
	{
		if (ScoreModel._Instance != null)
		{
			return true;
		}
		ScoreModel._Instance = new ScoreModel();
		return true;
	}

	// Token: 0x06015E4E RID: 89678 RVA: 0x00586458 File Offset: 0x00584658
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015E4F RID: 89679 RVA: 0x0058645A File Offset: 0x0058465A
	public static void ResetStaticDefaultValue()
	{
		ScoreModel._Instance = null;
	}

	// Token: 0x06015E50 RID: 89680 RVA: 0x00586462 File Offset: 0x00584662
	static ScoreModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ScoreModel.CreateStaticDefaultValue), new Action(ScoreModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A2F5 RID: 41717
	private int CurrentScore;

	// Token: 0x0400A2F6 RID: 41718
	private int TargetScore;

	// Token: 0x0400A2F7 RID: 41719
	[Nullable(2)]
	private static ScoreModel _Instance;
}

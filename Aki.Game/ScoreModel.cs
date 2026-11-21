using System;
using System.Runtime.CompilerServices;

// Token: 0x02001ED8 RID: 7896
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ScoreModel : ModelBase
{
	// Token: 0x06013849 RID: 79945 RVA: 0x005B13E5 File Offset: 0x005AF5E5
	public int GetCurrentScore()
	{
		return this.CurrentScore;
	}

	// Token: 0x0601384A RID: 79946 RVA: 0x005B13ED File Offset: 0x005AF5ED
	public int GetTargetScore()
	{
		return this.TargetScore;
	}

	// Token: 0x0601384B RID: 79947 RVA: 0x005B13F5 File Offset: 0x005AF5F5
	public void SetCurrentScore(int score)
	{
		this.CurrentScore = score;
	}

	// Token: 0x0601384C RID: 79948 RVA: 0x005B13FE File Offset: 0x005AF5FE
	public void SetTargetScore(int score)
	{
		this.TargetScore = score;
	}

	// Token: 0x0601384D RID: 79949 RVA: 0x005B1407 File Offset: 0x005AF607
	public void SetScore(int currentScore, int targetScore)
	{
		this.CurrentScore = currentScore;
		this.TargetScore = targetScore;
	}

	// Token: 0x0601384E RID: 79950 RVA: 0x005B1417 File Offset: 0x005AF617
	public void Reset()
	{
		this.CurrentScore = 0;
		this.TargetScore = 0;
	}

	// Token: 0x17001DDA RID: 7642
	// (get) Token: 0x0601384F RID: 79951 RVA: 0x005B1427 File Offset: 0x005AF627
	public static ScoreModel Instance
	{
		get
		{
			return ScoreModel._Instance;
		}
	}

	// Token: 0x06013850 RID: 79952 RVA: 0x005B142E File Offset: 0x005AF62E
	public static ScoreModel GetOrCreateInstance()
	{
		if (ScoreModel._Instance == null)
		{
			ScoreModel.CreateInstance();
		}
		return ScoreModel._Instance;
	}

	// Token: 0x06013851 RID: 79953 RVA: 0x005B1442 File Offset: 0x005AF642
	public static bool CreateInstance()
	{
		if (ScoreModel._Instance != null)
		{
			return true;
		}
		ScoreModel._Instance = new ScoreModel();
		return true;
	}

	// Token: 0x06013852 RID: 79954 RVA: 0x005B1458 File Offset: 0x005AF658
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013853 RID: 79955 RVA: 0x005B145A File Offset: 0x005AF65A
	public static void ResetStaticDefaultValue()
	{
		ScoreModel._Instance = null;
	}

	// Token: 0x06013854 RID: 79956 RVA: 0x005B1462 File Offset: 0x005AF662
	static ScoreModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ScoreModel.CreateStaticDefaultValue), new Action(ScoreModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A6DF RID: 42719
	private int CurrentScore;

	// Token: 0x0400A6E0 RID: 42720
	private int TargetScore;

	// Token: 0x0400A6E1 RID: 42721
	[Nullable(2)]
	private static ScoreModel _Instance;
}

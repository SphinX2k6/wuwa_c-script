using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200126D RID: 4717
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class GreatSwordChallengeModel : ModelBase
{
	// Token: 0x0600BAA3 RID: 47779 RVA: 0x00370DB6 File Offset: 0x0036EFB6
	public void InitChallenge(ITrialChallenge challenge)
	{
		this.Challenge = challenge;
	}

	// Token: 0x0600BAA4 RID: 47780 RVA: 0x00370DBF File Offset: 0x0036EFBF
	public List<TrialSubChallenge> GetSubChallenges()
	{
		ITrialChallenge challenge = this.Challenge;
		return (((challenge != null) ? challenge.SubChallenges : null) as List<TrialSubChallenge>) ?? new List<TrialSubChallenge>();
	}

	// Token: 0x0600BAA5 RID: 47781 RVA: 0x00370DE4 File Offset: 0x0036EFE4
	public void SetSubChallengeState(int index, bool unlocked, bool completed)
	{
		if (this.Challenge != null && this.Challenge.SubChallenges[index] != null)
		{
			this.Challenge.SubChallenges[index].Unlocked = unlocked;
			this.Challenge.SubChallenges[index].Completed = completed;
		}
	}

	// Token: 0x0600BAA6 RID: 47782 RVA: 0x00370E3A File Offset: 0x0036F03A
	public void SetActionIncId(int incId)
	{
		this.ActionIncId = incId;
	}

	// Token: 0x0600BAA7 RID: 47783 RVA: 0x00370E43 File Offset: 0x0036F043
	public void SetIsStartChallenge(bool isStart)
	{
		this.IsStartChallenge = isStart;
	}

	// Token: 0x0600BAA8 RID: 47784 RVA: 0x00370E4C File Offset: 0x0036F04C
	public int GetActionIncId()
	{
		return this.ActionIncId;
	}

	// Token: 0x0600BAA9 RID: 47785 RVA: 0x00370E54 File Offset: 0x0036F054
	public bool GetIsStartChallenge()
	{
		return this.IsStartChallenge;
	}

	// Token: 0x0600BAAA RID: 47786 RVA: 0x00370E5C File Offset: 0x0036F05C
	[NullableContext(2)]
	public ITrialChallenge GetChallenge()
	{
		return this.Challenge;
	}

	// Token: 0x0600BAAB RID: 47787 RVA: 0x00370E64 File Offset: 0x0036F064
	public int GetSelectedIndex()
	{
		return this.SelectedIndex;
	}

	// Token: 0x0600BAAC RID: 47788 RVA: 0x00370E6C File Offset: 0x0036F06C
	public void SetSelectedIndex(int index)
	{
		this.SelectedIndex = index;
	}

	// Token: 0x0600BAAD RID: 47789 RVA: 0x00370E75 File Offset: 0x0036F075
	public void ClearData()
	{
		this.Challenge = null;
		this.SelectedIndex = 0;
		this.ActionIncId = 0;
		this.IsStartChallenge = false;
	}

	// Token: 0x17001295 RID: 4757
	// (get) Token: 0x0600BAAE RID: 47790 RVA: 0x00370E93 File Offset: 0x0036F093
	public static GreatSwordChallengeModel Instance
	{
		get
		{
			return GreatSwordChallengeModel._Instance;
		}
	}

	// Token: 0x0600BAAF RID: 47791 RVA: 0x00370E9A File Offset: 0x0036F09A
	public static GreatSwordChallengeModel GetOrCreateInstance()
	{
		if (GreatSwordChallengeModel._Instance == null)
		{
			GreatSwordChallengeModel.CreateInstance();
		}
		return GreatSwordChallengeModel._Instance;
	}

	// Token: 0x0600BAB0 RID: 47792 RVA: 0x00370EAE File Offset: 0x0036F0AE
	public static bool CreateInstance()
	{
		if (GreatSwordChallengeModel._Instance != null)
		{
			return true;
		}
		GreatSwordChallengeModel._Instance = new GreatSwordChallengeModel();
		return true;
	}

	// Token: 0x0600BAB1 RID: 47793 RVA: 0x00370EC4 File Offset: 0x0036F0C4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600BAB2 RID: 47794 RVA: 0x00370EC6 File Offset: 0x0036F0C6
	public static void ResetStaticDefaultValue()
	{
		GreatSwordChallengeModel._Instance = null;
	}

	// Token: 0x0600BAB3 RID: 47795 RVA: 0x00370ECE File Offset: 0x0036F0CE
	static GreatSwordChallengeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GreatSwordChallengeModel.CreateStaticDefaultValue), new Action(GreatSwordChallengeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006B7D RID: 27517
	[Nullable(2)]
	private ITrialChallenge Challenge;

	// Token: 0x04006B7E RID: 27518
	private int SelectedIndex;

	// Token: 0x04006B7F RID: 27519
	private int ActionIncId;

	// Token: 0x04006B80 RID: 27520
	private bool IsStartChallenge;

	// Token: 0x04006B81 RID: 27521
	[Nullable(2)]
	private static GreatSwordChallengeModel _Instance;
}

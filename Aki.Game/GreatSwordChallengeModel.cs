using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001DAB RID: 7595
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class GreatSwordChallengeModel : ModelBase
{
	// Token: 0x0600E685 RID: 59013 RVA: 0x00365156 File Offset: 0x00363356
	public void InitChallenge(ITrialChallenge challenge)
	{
		this.Challenge = challenge;
	}

	// Token: 0x0600E686 RID: 59014 RVA: 0x0036515F File Offset: 0x0036335F
	public List<TrialSubChallenge> GetSubChallenges()
	{
		ITrialChallenge challenge = this.Challenge;
		return (((challenge != null) ? challenge.SubChallenges : null) as List<TrialSubChallenge>) ?? new List<TrialSubChallenge>();
	}

	// Token: 0x0600E687 RID: 59015 RVA: 0x00365184 File Offset: 0x00363384
	public void SetSubChallengeState(int index, bool unlocked, bool completed)
	{
		if (this.Challenge != null && this.Challenge.SubChallenges[index] != null)
		{
			this.Challenge.SubChallenges[index].Unlocked = unlocked;
			this.Challenge.SubChallenges[index].Completed = completed;
		}
	}

	// Token: 0x0600E688 RID: 59016 RVA: 0x003651DA File Offset: 0x003633DA
	public void SetActionIncId(int incId)
	{
		this.ActionIncId = incId;
	}

	// Token: 0x0600E689 RID: 59017 RVA: 0x003651E3 File Offset: 0x003633E3
	public void SetIsStartChallenge(bool isStart)
	{
		this.IsStartChallenge = isStart;
	}

	// Token: 0x0600E68A RID: 59018 RVA: 0x003651EC File Offset: 0x003633EC
	public int GetActionIncId()
	{
		return this.ActionIncId;
	}

	// Token: 0x0600E68B RID: 59019 RVA: 0x003651F4 File Offset: 0x003633F4
	public bool GetIsStartChallenge()
	{
		return this.IsStartChallenge;
	}

	// Token: 0x0600E68C RID: 59020 RVA: 0x003651FC File Offset: 0x003633FC
	[NullableContext(2)]
	public ITrialChallenge GetChallenge()
	{
		return this.Challenge;
	}

	// Token: 0x0600E68D RID: 59021 RVA: 0x00365204 File Offset: 0x00363404
	public int GetSelectedIndex()
	{
		return this.SelectedIndex;
	}

	// Token: 0x0600E68E RID: 59022 RVA: 0x0036520C File Offset: 0x0036340C
	public void SetSelectedIndex(int index)
	{
		this.SelectedIndex = index;
	}

	// Token: 0x0600E68F RID: 59023 RVA: 0x00365215 File Offset: 0x00363415
	public void ClearData()
	{
		this.Challenge = null;
		this.SelectedIndex = 0;
		this.ActionIncId = 0;
		this.IsStartChallenge = false;
	}

	// Token: 0x1700126B RID: 4715
	// (get) Token: 0x0600E690 RID: 59024 RVA: 0x00365233 File Offset: 0x00363433
	public static GreatSwordChallengeModel Instance
	{
		get
		{
			return GreatSwordChallengeModel._Instance;
		}
	}

	// Token: 0x0600E691 RID: 59025 RVA: 0x0036523A File Offset: 0x0036343A
	public static GreatSwordChallengeModel GetOrCreateInstance()
	{
		if (GreatSwordChallengeModel._Instance == null)
		{
			GreatSwordChallengeModel.CreateInstance();
		}
		return GreatSwordChallengeModel._Instance;
	}

	// Token: 0x0600E692 RID: 59026 RVA: 0x0036524E File Offset: 0x0036344E
	public static bool CreateInstance()
	{
		if (GreatSwordChallengeModel._Instance != null)
		{
			return true;
		}
		GreatSwordChallengeModel._Instance = new GreatSwordChallengeModel();
		return true;
	}

	// Token: 0x0600E693 RID: 59027 RVA: 0x00365264 File Offset: 0x00363464
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E694 RID: 59028 RVA: 0x00365266 File Offset: 0x00363466
	public static void ResetStaticDefaultValue()
	{
		GreatSwordChallengeModel._Instance = null;
	}

	// Token: 0x0600E695 RID: 59029 RVA: 0x0036526E File Offset: 0x0036346E
	static GreatSwordChallengeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GreatSwordChallengeModel.CreateStaticDefaultValue), new Action(GreatSwordChallengeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006A9C RID: 27292
	[Nullable(2)]
	private ITrialChallenge Challenge;

	// Token: 0x04006A9D RID: 27293
	private int SelectedIndex;

	// Token: 0x04006A9E RID: 27294
	private int ActionIncId;

	// Token: 0x04006A9F RID: 27295
	private bool IsStartChallenge;

	// Token: 0x04006AA0 RID: 27296
	[Nullable(2)]
	private static GreatSwordChallengeModel _Instance;
}

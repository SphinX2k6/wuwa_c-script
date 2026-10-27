using System;
using System.Runtime.CompilerServices;

// Token: 0x0200310E RID: 12558
[NullableContext(1)]
[Nullable(0)]
public class WhirlpoolPoint : IClear, IStaticVariableResetter
{
	// Token: 0x0601AF96 RID: 110486 RVA: 0x00751E0C File Offset: 0x0075000C
	static WhirlpoolPoint()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WhirlpoolPoint.CreateStaticDefaultValue), new Action(WhirlpoolPoint.ResetStaticDefaultValue));
	}

	// Token: 0x0601AF97 RID: 110487 RVA: 0x00751E2B File Offset: 0x0075002B
	public static int GenId()
	{
		return WhirlpoolPoint.GlobalId++;
	}

	// Token: 0x0601AF98 RID: 110488 RVA: 0x00751E3A File Offset: 0x0075003A
	public bool GetEnable()
	{
		return this.Enable;
	}

	// Token: 0x0601AF99 RID: 110489 RVA: 0x00751E42 File Offset: 0x00750042
	public bool GetCancelByHit()
	{
		return this.CancelByHit;
	}

	// Token: 0x0601AF9A RID: 110490 RVA: 0x00751E4A File Offset: 0x0075004A
	public float GetMoveTime()
	{
		return this.MoveTime;
	}

	// Token: 0x0601AF9B RID: 110491 RVA: 0x00751E52 File Offset: 0x00750052
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x0601AF9C RID: 110492 RVA: 0x00751E5C File Offset: 0x0075005C
	public void Begin(int id, float moveTime, Vector location, Vector beginLocation, float duration = -1f, EVelocityCurveType curveType = EVelocityCurveType.None, bool cancelByHit = true, int needTagId = 0)
	{
		this.Id = id;
		this.MoveTime = moveTime;
		this.ToLocation.FromUeVector(location);
		this.BeginLocation.FromUeVector(beginLocation);
		this.Enable = true;
		this.ElapsedTime = 0f;
		this.Duration = duration;
		this.CurveType = curveType;
		this.CancelByHit = cancelByHit;
		this.NeedTagId = needTagId;
	}

	// Token: 0x0601AF9D RID: 110493 RVA: 0x00751EC2 File Offset: 0x007500C2
	public void UpdateLocation(Vector location)
	{
		this.ToLocation.FromUeVector(location);
	}

	// Token: 0x0601AF9E RID: 110494 RVA: 0x00751ED0 File Offset: 0x007500D0
	public bool OnTick(float delta)
	{
		this.ElapsedTime += delta;
		if (this.Duration > 0f && this.Duration <= this.ElapsedTime)
		{
			this.ElapsedTime = this.Duration;
			return false;
		}
		return true;
	}

	// Token: 0x0601AF9F RID: 110495 RVA: 0x00751F0A File Offset: 0x0075010A
	public void OnEnd()
	{
		this.Enable = false;
	}

	// Token: 0x0601AFA0 RID: 110496 RVA: 0x00751F13 File Offset: 0x00750113
	public bool ClearObject()
	{
		this.Id = 0;
		this.MoveTime = 0f;
		this.Enable = false;
		this.ElapsedTime = 0f;
		this.Duration = 0f;
		return true;
	}

	// Token: 0x0601AFA1 RID: 110497 RVA: 0x00751F48 File Offset: 0x00750148
	public float GetAlpha()
	{
		float num = this.ElapsedTime / this.MoveTime;
		switch (this.CurveType)
		{
		case EVelocityCurveType.Convex:
			return 1f + MathF.Pow(num - 1f, 3f);
		case EVelocityCurveType.LinearityDown:
			return 1f - num;
		case EVelocityCurveType.Concave:
			return MathF.Pow(num, 3f);
		}
		return num;
	}

	// Token: 0x0601AFA2 RID: 110498 RVA: 0x00751FAF File Offset: 0x007501AF
	public static void CreateStaticDefaultValue()
	{
		WhirlpoolPoint.GlobalId = 0;
	}

	// Token: 0x0601AFA3 RID: 110499 RVA: 0x00751FB7 File Offset: 0x007501B7
	public static void ResetStaticDefaultValue()
	{
		WhirlpoolPoint.GlobalId = 0;
	}

	// Token: 0x0601AFA4 RID: 110500 RVA: 0x00751FBF File Offset: 0x007501BF
	public int GetNeedTagId()
	{
		return this.NeedTagId;
	}

	// Token: 0x0400D1B0 RID: 53680
	private int Id;

	// Token: 0x0400D1B1 RID: 53681
	public readonly Vector ToLocation = Vector.Create();

	// Token: 0x0400D1B2 RID: 53682
	public readonly Vector BeginLocation = Vector.Create();

	// Token: 0x0400D1B3 RID: 53683
	private bool Enable;

	// Token: 0x0400D1B4 RID: 53684
	private float MoveTime;

	// Token: 0x0400D1B5 RID: 53685
	private static int GlobalId;

	// Token: 0x0400D1B6 RID: 53686
	private float ElapsedTime;

	// Token: 0x0400D1B7 RID: 53687
	private float Duration = -1f;

	// Token: 0x0400D1B8 RID: 53688
	private EVelocityCurveType CurveType;

	// Token: 0x0400D1B9 RID: 53689
	private bool CancelByHit;

	// Token: 0x0400D1BA RID: 53690
	private int NeedTagId;
}

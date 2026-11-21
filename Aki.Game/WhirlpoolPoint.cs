using System;
using System.Runtime.CompilerServices;

// Token: 0x02002669 RID: 9833
[NullableContext(1)]
[Nullable(0)]
public class WhirlpoolPoint : IClear, IStaticVariableResetter
{
	// Token: 0x060189E6 RID: 100838 RVA: 0x00777FDC File Offset: 0x007761DC
	static WhirlpoolPoint()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WhirlpoolPoint.CreateStaticDefaultValue), new Action(WhirlpoolPoint.ResetStaticDefaultValue));
	}

	// Token: 0x060189E7 RID: 100839 RVA: 0x00777FFB File Offset: 0x007761FB
	public static int GenId()
	{
		return WhirlpoolPoint.GlobalId++;
	}

	// Token: 0x060189E8 RID: 100840 RVA: 0x0077800A File Offset: 0x0077620A
	public bool GetEnable()
	{
		return this.Enable;
	}

	// Token: 0x060189E9 RID: 100841 RVA: 0x00778012 File Offset: 0x00776212
	public bool GetCancelByHit()
	{
		return this.CancelByHit;
	}

	// Token: 0x060189EA RID: 100842 RVA: 0x0077801A File Offset: 0x0077621A
	public float GetMoveTime()
	{
		return this.MoveTime;
	}

	// Token: 0x060189EB RID: 100843 RVA: 0x00778022 File Offset: 0x00776222
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x060189EC RID: 100844 RVA: 0x0077802C File Offset: 0x0077622C
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

	// Token: 0x060189ED RID: 100845 RVA: 0x00778092 File Offset: 0x00776292
	public void UpdateLocation(Vector location)
	{
		this.ToLocation.FromUeVector(location);
	}

	// Token: 0x060189EE RID: 100846 RVA: 0x007780A0 File Offset: 0x007762A0
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

	// Token: 0x060189EF RID: 100847 RVA: 0x007780DA File Offset: 0x007762DA
	public void OnEnd()
	{
		this.Enable = false;
	}

	// Token: 0x060189F0 RID: 100848 RVA: 0x007780E3 File Offset: 0x007762E3
	public bool ClearObject()
	{
		this.Id = 0;
		this.MoveTime = 0f;
		this.Enable = false;
		this.ElapsedTime = 0f;
		this.Duration = 0f;
		return true;
	}

	// Token: 0x060189F1 RID: 100849 RVA: 0x00778118 File Offset: 0x00776318
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

	// Token: 0x060189F2 RID: 100850 RVA: 0x0077817F File Offset: 0x0077637F
	public static void CreateStaticDefaultValue()
	{
		WhirlpoolPoint.GlobalId = 0;
	}

	// Token: 0x060189F3 RID: 100851 RVA: 0x00778187 File Offset: 0x00776387
	public static void ResetStaticDefaultValue()
	{
		WhirlpoolPoint.GlobalId = 0;
	}

	// Token: 0x060189F4 RID: 100852 RVA: 0x0077818F File Offset: 0x0077638F
	public int GetNeedTagId()
	{
		return this.NeedTagId;
	}

	// Token: 0x0400D5D1 RID: 54737
	private int Id;

	// Token: 0x0400D5D2 RID: 54738
	public readonly Vector ToLocation = Vector.Create();

	// Token: 0x0400D5D3 RID: 54739
	public readonly Vector BeginLocation = Vector.Create();

	// Token: 0x0400D5D4 RID: 54740
	private bool Enable;

	// Token: 0x0400D5D5 RID: 54741
	private float MoveTime;

	// Token: 0x0400D5D6 RID: 54742
	private static int GlobalId;

	// Token: 0x0400D5D7 RID: 54743
	private float ElapsedTime;

	// Token: 0x0400D5D8 RID: 54744
	private float Duration = -1f;

	// Token: 0x0400D5D9 RID: 54745
	private EVelocityCurveType CurveType;

	// Token: 0x0400D5DA RID: 54746
	private bool CancelByHit;

	// Token: 0x0400D5DB RID: 54747
	private int NeedTagId;
}

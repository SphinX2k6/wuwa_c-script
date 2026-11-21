using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D1C RID: 7452
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MainRoleModel : ModelBase
{
	// Token: 0x0601272C RID: 75564 RVA: 0x00573497 File Offset: 0x00571697
	public void MarkElementChanged()
	{
		if (this.ElementChangeState == EElementChangeState.None)
		{
			this.ElementChangeState = EElementChangeState.Changed;
		}
	}

	// Token: 0x0601272D RID: 75565 RVA: 0x005734A8 File Offset: 0x005716A8
	public bool IsElementChanged()
	{
		return this.ElementChangeState == EElementChangeState.Changed;
	}

	// Token: 0x0601272E RID: 75566 RVA: 0x005734B3 File Offset: 0x005716B3
	public void MarkElementChangeTriggered()
	{
		if (this.ElementChangeState == EElementChangeState.Changed)
		{
			this.ElementChangeState = EElementChangeState.Triggered;
		}
	}

	// Token: 0x0601272F RID: 75567 RVA: 0x005734C5 File Offset: 0x005716C5
	public void ResetElementChangeState()
	{
		this.ElementChangeState = EElementChangeState.None;
	}

	// Token: 0x06012730 RID: 75568 RVA: 0x005734CE File Offset: 0x005716CE
	public void UpdateCanChangeSexTime(long time)
	{
		this.CanChangeSexTime = time;
	}

	// Token: 0x06012731 RID: 75569 RVA: 0x005734D7 File Offset: 0x005716D7
	public bool CanChangeSex()
	{
		return TimeUtil.Instance.GetServerTimeStamp() >= (double)this.CanChangeSexTime;
	}

	// Token: 0x06012732 RID: 75570 RVA: 0x005734EF File Offset: 0x005716EF
	public double GetCanChangeSexTime()
	{
		return (double)this.CanChangeSexTime;
	}

	// Token: 0x17001B7D RID: 7037
	// (get) Token: 0x06012733 RID: 75571 RVA: 0x005734F8 File Offset: 0x005716F8
	public static MainRoleModel Instance
	{
		get
		{
			return MainRoleModel._Instance;
		}
	}

	// Token: 0x06012734 RID: 75572 RVA: 0x005734FF File Offset: 0x005716FF
	public static MainRoleModel GetOrCreateInstance()
	{
		if (MainRoleModel._Instance == null)
		{
			MainRoleModel.CreateInstance();
		}
		return MainRoleModel._Instance;
	}

	// Token: 0x06012735 RID: 75573 RVA: 0x00573513 File Offset: 0x00571713
	public static bool CreateInstance()
	{
		if (MainRoleModel._Instance != null)
		{
			return true;
		}
		MainRoleModel._Instance = new MainRoleModel();
		return true;
	}

	// Token: 0x06012736 RID: 75574 RVA: 0x00573529 File Offset: 0x00571729
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012737 RID: 75575 RVA: 0x0057352B File Offset: 0x0057172B
	public static void ResetStaticDefaultValue()
	{
		MainRoleModel._Instance = null;
	}

	// Token: 0x06012738 RID: 75576 RVA: 0x00573533 File Offset: 0x00571733
	static MainRoleModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MainRoleModel.CreateStaticDefaultValue), new Action(MainRoleModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A099 RID: 41113
	private long CanChangeSexTime;

	// Token: 0x0400A09A RID: 41114
	private EElementChangeState ElementChangeState;

	// Token: 0x0400A09B RID: 41115
	[Nullable(2)]
	private static MainRoleModel _Instance;
}

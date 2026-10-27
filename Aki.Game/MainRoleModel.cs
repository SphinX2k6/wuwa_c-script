using System;
using System.Runtime.CompilerServices;

// Token: 0x020027A1 RID: 10145
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MainRoleModel : ModelBase
{
	// Token: 0x06014D57 RID: 85335 RVA: 0x0054933B File Offset: 0x0054753B
	public void UpdateCanChangeSexTime(long time)
	{
		this.CanChangeSexTime = time;
	}

	// Token: 0x06014D58 RID: 85336 RVA: 0x00549344 File Offset: 0x00547544
	public bool CanChangeSex()
	{
		return TimeUtil.Instance.GetServerTimeStamp() >= (double)this.CanChangeSexTime;
	}

	// Token: 0x06014D59 RID: 85337 RVA: 0x0054935C File Offset: 0x0054755C
	public double GetCanChangeSexTime()
	{
		return (double)this.CanChangeSexTime;
	}

	// Token: 0x17001B26 RID: 6950
	// (get) Token: 0x06014D5A RID: 85338 RVA: 0x00549365 File Offset: 0x00547565
	public static MainRoleModel Instance
	{
		get
		{
			return MainRoleModel._Instance;
		}
	}

	// Token: 0x06014D5B RID: 85339 RVA: 0x0054936C File Offset: 0x0054756C
	public static MainRoleModel GetOrCreateInstance()
	{
		if (MainRoleModel._Instance == null)
		{
			MainRoleModel.CreateInstance();
		}
		return MainRoleModel._Instance;
	}

	// Token: 0x06014D5C RID: 85340 RVA: 0x00549380 File Offset: 0x00547580
	public static bool CreateInstance()
	{
		if (MainRoleModel._Instance != null)
		{
			return true;
		}
		MainRoleModel._Instance = new MainRoleModel();
		return true;
	}

	// Token: 0x06014D5D RID: 85341 RVA: 0x00549396 File Offset: 0x00547596
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014D5E RID: 85342 RVA: 0x00549398 File Offset: 0x00547598
	public static void ResetStaticDefaultValue()
	{
		MainRoleModel._Instance = null;
	}

	// Token: 0x06014D5F RID: 85343 RVA: 0x005493A0 File Offset: 0x005475A0
	static MainRoleModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MainRoleModel.CreateStaticDefaultValue), new Action(MainRoleModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009CC7 RID: 40135
	private long CanChangeSexTime;

	// Token: 0x04009CC8 RID: 40136
	[Nullable(2)]
	private static MainRoleModel _Instance;
}

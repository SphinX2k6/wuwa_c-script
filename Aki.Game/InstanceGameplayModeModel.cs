using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001FA8 RID: 8104
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class InstanceGameplayModeModel : ModelBase
{
	// Token: 0x0600FBE1 RID: 64481 RVA: 0x003D1062 File Offset: 0x003CF262
	protected override bool OnClear()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x0600FBE2 RID: 64482 RVA: 0x003D106B File Offset: 0x003CF26B
	protected override bool OnLeaveLevel()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x0600FBE3 RID: 64483 RVA: 0x003D1074 File Offset: 0x003CF274
	protected override bool OnChangeMode()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x0600FBE4 RID: 64484 RVA: 0x003D107D File Offset: 0x003CF27D
	private void ClearAll()
	{
		this.DisabledCreatureSet.Clear();
	}

	// Token: 0x1700134C RID: 4940
	// (get) Token: 0x0600FBE5 RID: 64485 RVA: 0x003D108A File Offset: 0x003CF28A
	public static InstanceGameplayModeModel Instance
	{
		get
		{
			return InstanceGameplayModeModel._Instance;
		}
	}

	// Token: 0x0600FBE6 RID: 64486 RVA: 0x003D1091 File Offset: 0x003CF291
	public static InstanceGameplayModeModel GetOrCreateInstance()
	{
		if (InstanceGameplayModeModel._Instance == null)
		{
			InstanceGameplayModeModel.CreateInstance();
		}
		return InstanceGameplayModeModel._Instance;
	}

	// Token: 0x0600FBE7 RID: 64487 RVA: 0x003D10A5 File Offset: 0x003CF2A5
	public static bool CreateInstance()
	{
		if (InstanceGameplayModeModel._Instance != null)
		{
			return true;
		}
		InstanceGameplayModeModel._Instance = new InstanceGameplayModeModel();
		return true;
	}

	// Token: 0x0600FBE8 RID: 64488 RVA: 0x003D10BB File Offset: 0x003CF2BB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FBE9 RID: 64489 RVA: 0x003D10BD File Offset: 0x003CF2BD
	public static void ResetStaticDefaultValue()
	{
		InstanceGameplayModeModel._Instance = null;
	}

	// Token: 0x0600FBEA RID: 64490 RVA: 0x003D10C5 File Offset: 0x003CF2C5
	static InstanceGameplayModeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InstanceGameplayModeModel.CreateStaticDefaultValue), new Action(InstanceGameplayModeModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400751F RID: 29983
	public EDefaultCameraMode DefaultCameraMode;

	// Token: 0x04007520 RID: 29984
	public HashSet<long> DisabledCreatureSet = new HashSet<long>();

	// Token: 0x04007521 RID: 29985
	[Nullable(2)]
	private static InstanceGameplayModeModel _Instance;
}

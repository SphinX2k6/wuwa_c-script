using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200146A RID: 5226
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class InstanceGameplayModeModel : ModelBase
{
	// Token: 0x0600D003 RID: 53251 RVA: 0x003DCCDE File Offset: 0x003DAEDE
	protected override bool OnClear()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x0600D004 RID: 53252 RVA: 0x003DCCE7 File Offset: 0x003DAEE7
	protected override bool OnLeaveLevel()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x0600D005 RID: 53253 RVA: 0x003DCCF0 File Offset: 0x003DAEF0
	protected override bool OnChangeMode()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x0600D006 RID: 53254 RVA: 0x003DCCF9 File Offset: 0x003DAEF9
	private void ClearAll()
	{
		this.DisabledCreatureSet.Clear();
	}

	// Token: 0x17001376 RID: 4982
	// (get) Token: 0x0600D007 RID: 53255 RVA: 0x003DCD06 File Offset: 0x003DAF06
	public static InstanceGameplayModeModel Instance
	{
		get
		{
			return InstanceGameplayModeModel._Instance;
		}
	}

	// Token: 0x0600D008 RID: 53256 RVA: 0x003DCD0D File Offset: 0x003DAF0D
	public static InstanceGameplayModeModel GetOrCreateInstance()
	{
		if (InstanceGameplayModeModel._Instance == null)
		{
			InstanceGameplayModeModel.CreateInstance();
		}
		return InstanceGameplayModeModel._Instance;
	}

	// Token: 0x0600D009 RID: 53257 RVA: 0x003DCD21 File Offset: 0x003DAF21
	public static bool CreateInstance()
	{
		if (InstanceGameplayModeModel._Instance != null)
		{
			return true;
		}
		InstanceGameplayModeModel._Instance = new InstanceGameplayModeModel();
		return true;
	}

	// Token: 0x0600D00A RID: 53258 RVA: 0x003DCD37 File Offset: 0x003DAF37
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D00B RID: 53259 RVA: 0x003DCD39 File Offset: 0x003DAF39
	public static void ResetStaticDefaultValue()
	{
		InstanceGameplayModeModel._Instance = null;
	}

	// Token: 0x0600D00C RID: 53260 RVA: 0x003DCD41 File Offset: 0x003DAF41
	static InstanceGameplayModeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InstanceGameplayModeModel.CreateStaticDefaultValue), new Action(InstanceGameplayModeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007602 RID: 30210
	public EDefaultCameraMode DefaultCameraMode;

	// Token: 0x04007603 RID: 30211
	public HashSet<long> DisabledCreatureSet = new HashSet<long>();

	// Token: 0x04007604 RID: 30212
	[Nullable(2)]
	private static InstanceGameplayModeModel _Instance;
}

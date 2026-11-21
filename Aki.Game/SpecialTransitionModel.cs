using System;
using System.Runtime.CompilerServices;

// Token: 0x02002002 RID: 8194
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SpecialTransitionModel : ModelBase
{
	// Token: 0x060144D6 RID: 83158 RVA: 0x005E9BFA File Offset: 0x005E7DFA
	[NullableContext(2)]
	public ISpecialTransitionParams GetSpecialTransitionParams()
	{
		return this.SpecialTransitionParams;
	}

	// Token: 0x060144D7 RID: 83159 RVA: 0x005E9C04 File Offset: 0x005E7E04
	public bool SetSpecialTransitionParams(ISpecialTransitionParams @params)
	{
		if (this.SpecialTransitionParams != null)
		{
			Log.Instance.Error(ELogModule.Loading, ELogAuthor.CB, "SpecialTransitionParams已存在,被重复设置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		this.SpecialTransitionParams = @params;
		return true;
	}

	// Token: 0x060144D8 RID: 83160 RVA: 0x005E9C3F File Offset: 0x005E7E3F
	public void ClearSpecialTransitionParams()
	{
		this.SpecialTransitionParams = null;
	}

	// Token: 0x060144D9 RID: 83161 RVA: 0x005E9C48 File Offset: 0x005E7E48
	public bool IsLoadingMode()
	{
		ISpecialTransitionParams specialTransitionParams = this.SpecialTransitionParams;
		return specialTransitionParams != null && specialTransitionParams.LoadingType != null;
	}

	// Token: 0x060144DA RID: 83162 RVA: 0x005E9C6E File Offset: 0x005E7E6E
	protected override bool OnClear()
	{
		this.SpecialTransitionParams = null;
		return true;
	}

	// Token: 0x17001E8C RID: 7820
	// (get) Token: 0x060144DB RID: 83163 RVA: 0x005E9C78 File Offset: 0x005E7E78
	public static SpecialTransitionModel Instance
	{
		get
		{
			return SpecialTransitionModel._Instance;
		}
	}

	// Token: 0x060144DC RID: 83164 RVA: 0x005E9C7F File Offset: 0x005E7E7F
	public static SpecialTransitionModel GetOrCreateInstance()
	{
		if (SpecialTransitionModel._Instance == null)
		{
			SpecialTransitionModel.CreateInstance();
		}
		return SpecialTransitionModel._Instance;
	}

	// Token: 0x060144DD RID: 83165 RVA: 0x005E9C93 File Offset: 0x005E7E93
	public static bool CreateInstance()
	{
		if (SpecialTransitionModel._Instance != null)
		{
			return true;
		}
		SpecialTransitionModel._Instance = new SpecialTransitionModel();
		return true;
	}

	// Token: 0x060144DE RID: 83166 RVA: 0x005E9CA9 File Offset: 0x005E7EA9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060144DF RID: 83167 RVA: 0x005E9CAB File Offset: 0x005E7EAB
	public static void ResetStaticDefaultValue()
	{
		SpecialTransitionModel._Instance = null;
	}

	// Token: 0x060144E0 RID: 83168 RVA: 0x005E9CB3 File Offset: 0x005E7EB3
	static SpecialTransitionModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialTransitionModel.CreateStaticDefaultValue), new Action(SpecialTransitionModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400AC2E RID: 44078
	[Nullable(2)]
	private ISpecialTransitionParams SpecialTransitionParams;

	// Token: 0x0400AC2F RID: 44079
	[Nullable(2)]
	private static SpecialTransitionModel _Instance;
}

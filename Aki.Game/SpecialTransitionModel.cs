using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A86 RID: 10886
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SpecialTransitionModel : ModelBase
{
	// Token: 0x06016AB1 RID: 92849 RVA: 0x005BD9CA File Offset: 0x005BBBCA
	[NullableContext(2)]
	public ISpecialTransitionParams GetSpecialTransitionParams()
	{
		return this.SpecialTransitionParams;
	}

	// Token: 0x06016AB2 RID: 92850 RVA: 0x005BD9D4 File Offset: 0x005BBBD4
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

	// Token: 0x06016AB3 RID: 92851 RVA: 0x005BDA0F File Offset: 0x005BBC0F
	public void ClearSpecialTransitionParams()
	{
		this.SpecialTransitionParams = null;
	}

	// Token: 0x06016AB4 RID: 92852 RVA: 0x005BDA18 File Offset: 0x005BBC18
	public bool IsLoadingMode()
	{
		ISpecialTransitionParams specialTransitionParams = this.SpecialTransitionParams;
		return specialTransitionParams != null && specialTransitionParams.LoadingType != null;
	}

	// Token: 0x06016AB5 RID: 92853 RVA: 0x005BDA3E File Offset: 0x005BBC3E
	protected override bool OnClear()
	{
		this.SpecialTransitionParams = null;
		return true;
	}

	// Token: 0x17001E34 RID: 7732
	// (get) Token: 0x06016AB6 RID: 92854 RVA: 0x005BDA48 File Offset: 0x005BBC48
	public static SpecialTransitionModel Instance
	{
		get
		{
			return SpecialTransitionModel._Instance;
		}
	}

	// Token: 0x06016AB7 RID: 92855 RVA: 0x005BDA4F File Offset: 0x005BBC4F
	public static SpecialTransitionModel GetOrCreateInstance()
	{
		if (SpecialTransitionModel._Instance == null)
		{
			SpecialTransitionModel.CreateInstance();
		}
		return SpecialTransitionModel._Instance;
	}

	// Token: 0x06016AB8 RID: 92856 RVA: 0x005BDA63 File Offset: 0x005BBC63
	public static bool CreateInstance()
	{
		if (SpecialTransitionModel._Instance != null)
		{
			return true;
		}
		SpecialTransitionModel._Instance = new SpecialTransitionModel();
		return true;
	}

	// Token: 0x06016AB9 RID: 92857 RVA: 0x005BDA79 File Offset: 0x005BBC79
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016ABA RID: 92858 RVA: 0x005BDA7B File Offset: 0x005BBC7B
	public static void ResetStaticDefaultValue()
	{
		SpecialTransitionModel._Instance = null;
	}

	// Token: 0x06016ABB RID: 92859 RVA: 0x005BDA83 File Offset: 0x005BBC83
	static SpecialTransitionModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialTransitionModel.CreateStaticDefaultValue), new Action(SpecialTransitionModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A829 RID: 43049
	[Nullable(2)]
	private ISpecialTransitionParams SpecialTransitionParams;

	// Token: 0x0400A82A RID: 43050
	[Nullable(2)]
	private static SpecialTransitionModel _Instance;
}

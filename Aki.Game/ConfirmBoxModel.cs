using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020019DA RID: 6618
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ConfirmBoxModel : ModelBase
{
	// Token: 0x0600C137 RID: 49463 RVA: 0x002B9835 File Offset: 0x002B7A35
	protected override bool OnClear()
	{
		this.NotShowAgainSet.Clear();
		return true;
	}

	// Token: 0x1700102D RID: 4141
	// (get) Token: 0x0600C138 RID: 49464 RVA: 0x002B9843 File Offset: 0x002B7A43
	public static ConfirmBoxModel Instance
	{
		get
		{
			return ConfirmBoxModel._Instance;
		}
	}

	// Token: 0x0600C139 RID: 49465 RVA: 0x002B984A File Offset: 0x002B7A4A
	public static ConfirmBoxModel GetOrCreateInstance()
	{
		if (ConfirmBoxModel._Instance == null)
		{
			ConfirmBoxModel.CreateInstance();
		}
		return ConfirmBoxModel._Instance;
	}

	// Token: 0x0600C13A RID: 49466 RVA: 0x002B985E File Offset: 0x002B7A5E
	public static bool CreateInstance()
	{
		if (ConfirmBoxModel._Instance != null)
		{
			return true;
		}
		ConfirmBoxModel._Instance = new ConfirmBoxModel();
		return true;
	}

	// Token: 0x0600C13B RID: 49467 RVA: 0x002B9874 File Offset: 0x002B7A74
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C13C RID: 49468 RVA: 0x002B9876 File Offset: 0x002B7A76
	public static void ResetStaticDefaultValue()
	{
		ConfirmBoxModel._Instance = null;
	}

	// Token: 0x0600C13D RID: 49469 RVA: 0x002B987E File Offset: 0x002B7A7E
	static ConfirmBoxModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ConfirmBoxModel.CreateStaticDefaultValue), new Action(ConfirmBoxModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005915 RID: 22805
	public readonly HashSet<EConfirmBoxConfigId> NotShowAgainSet = new HashSet<EConfirmBoxConfigId>();

	// Token: 0x04005916 RID: 22806
	[Nullable(2)]
	private static ConfirmBoxModel _Instance;
}

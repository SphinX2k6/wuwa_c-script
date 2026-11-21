using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000E99 RID: 3737
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ConfirmBoxModel : ModelBase
{
	// Token: 0x06009544 RID: 38212 RVA: 0x002C480D File Offset: 0x002C2A0D
	protected override bool OnClear()
	{
		this.NotShowAgainSet.Clear();
		return true;
	}

	// Token: 0x17001052 RID: 4178
	// (get) Token: 0x06009545 RID: 38213 RVA: 0x002C481B File Offset: 0x002C2A1B
	public static ConfirmBoxModel Instance
	{
		get
		{
			return ConfirmBoxModel._Instance;
		}
	}

	// Token: 0x06009546 RID: 38214 RVA: 0x002C4822 File Offset: 0x002C2A22
	public static ConfirmBoxModel GetOrCreateInstance()
	{
		if (ConfirmBoxModel._Instance == null)
		{
			ConfirmBoxModel.CreateInstance();
		}
		return ConfirmBoxModel._Instance;
	}

	// Token: 0x06009547 RID: 38215 RVA: 0x002C4836 File Offset: 0x002C2A36
	public static bool CreateInstance()
	{
		if (ConfirmBoxModel._Instance != null)
		{
			return true;
		}
		ConfirmBoxModel._Instance = new ConfirmBoxModel();
		return true;
	}

	// Token: 0x06009548 RID: 38216 RVA: 0x002C484C File Offset: 0x002C2A4C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009549 RID: 38217 RVA: 0x002C484E File Offset: 0x002C2A4E
	public static void ResetStaticDefaultValue()
	{
		ConfirmBoxModel._Instance = null;
	}

	// Token: 0x0600954A RID: 38218 RVA: 0x002C4856 File Offset: 0x002C2A56
	static ConfirmBoxModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ConfirmBoxModel.CreateStaticDefaultValue), new Action(ConfirmBoxModel.ResetStaticDefaultValue));
	}

	// Token: 0x040059E4 RID: 23012
	public readonly HashSet<EConfirmBoxConfigId> NotShowAgainSet = new HashSet<EConfirmBoxConfigId>();

	// Token: 0x040059E5 RID: 23013
	[Nullable(2)]
	private static ConfirmBoxModel _Instance;
}

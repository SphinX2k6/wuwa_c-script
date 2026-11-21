using System;
using System.Runtime.CompilerServices;

// Token: 0x02001957 RID: 6487
public class PhantomInteractDropDownItemOptionTextId : IStaticVariableResetter
{
	// Token: 0x06010060 RID: 65632 RVA: 0x004AC320 File Offset: 0x004AA520
	static PhantomInteractDropDownItemOptionTextId()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomInteractDropDownItemOptionTextId.CreateStaticDefaultValue), new Action(PhantomInteractDropDownItemOptionTextId.ResetStaticDefaultValue));
	}

	// Token: 0x06010061 RID: 65633 RVA: 0x004AC33F File Offset: 0x004AA53F
	public static void CreateStaticDefaultValue()
	{
		PhantomInteractDropDownItemOptionTextId.TextIds = new string[]
		{
			"PhantomDisplay_SelectAll",
			"PhantomDisplay_SelectSpecial",
			"PhantomDisplay_SelectCommon"
		};
	}

	// Token: 0x06010062 RID: 65634 RVA: 0x004AC364 File Offset: 0x004AA564
	public static void ResetStaticDefaultValue()
	{
		PhantomInteractDropDownItemOptionTextId.TextIds = null;
	}

	// Token: 0x04008E56 RID: 36438
	[Nullable(1)]
	public static string[] TextIds;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02002472 RID: 9330
public class PhantomInteractDropDownItemOptionTextId : IStaticVariableResetter
{
	// Token: 0x06012BA8 RID: 76712 RVA: 0x0049EBB4 File Offset: 0x0049CDB4
	static PhantomInteractDropDownItemOptionTextId()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomInteractDropDownItemOptionTextId.CreateStaticDefaultValue), new Action(PhantomInteractDropDownItemOptionTextId.ResetStaticDefaultValue));
	}

	// Token: 0x06012BA9 RID: 76713 RVA: 0x0049EBD3 File Offset: 0x0049CDD3
	public static void CreateStaticDefaultValue()
	{
		PhantomInteractDropDownItemOptionTextId.TextIds = new string[]
		{
			"PhantomDisplay_SelectAll",
			"PhantomDisplay_SelectSpecial",
			"PhantomDisplay_SelectCommon"
		};
	}

	// Token: 0x06012BAA RID: 76714 RVA: 0x0049EBF8 File Offset: 0x0049CDF8
	public static void ResetStaticDefaultValue()
	{
		PhantomInteractDropDownItemOptionTextId.TextIds = null;
	}

	// Token: 0x04008D0F RID: 36111
	[Nullable(1)]
	public static string[] TextIds;
}

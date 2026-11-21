using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DE7 RID: 3559
public class MediumItemGridRoleDevelopTagMarkComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600908D RID: 37005 RVA: 0x002B56DD File Offset: 0x002B38DD
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_RoleDevelopTagMark";
	}

	// Token: 0x0600908E RID: 37006 RVA: 0x002B56E4 File Offset: 0x002B38E4
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}
}

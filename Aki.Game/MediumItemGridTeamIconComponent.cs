using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DF6 RID: 3574
public class MediumItemGridTeamIconComponent : MediumItemGridComponent
{
	// Token: 0x060090D7 RID: 37079 RVA: 0x002B66EC File Offset: 0x002B48EC
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTeam";
	}

	// Token: 0x060090D8 RID: 37080 RVA: 0x002B66F4 File Offset: 0x002B48F4
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (!(data is bool) || !(bool)data)
		{
			this.SetActive(false);
			return;
		}
		this.SetActive(true);
	}
}

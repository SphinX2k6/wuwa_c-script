using System;
using System.Runtime.CompilerServices;

// Token: 0x0200193A RID: 6458
public class MediumItemGridTeamIconComponent : MediumItemGridComponent
{
	// Token: 0x0600BCDC RID: 48348 RVA: 0x002ABC20 File Offset: 0x002A9E20
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTeam";
	}

	// Token: 0x0600BCDD RID: 48349 RVA: 0x002ABC28 File Offset: 0x002A9E28
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

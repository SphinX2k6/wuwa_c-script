using System;
using System.Runtime.CompilerServices;

// Token: 0x02001E7B RID: 7803
public class NormalExtraItemIdProxy : IExtraItemIdProxy
{
	// Token: 0x060134A2 RID: 79010 RVA: 0x005A31D5 File Offset: 0x005A13D5
	[NullableContext(1)]
	public NormalExtraItemIdProxy(RouletteListDataExplore Owner)
	{
		this.Owner = Owner;
	}

	// Token: 0x060134A3 RID: 79011 RVA: 0x005A31E4 File Offset: 0x005A13E4
	public int GetExtraItemId()
	{
		return this.CurrentItemId;
	}

	// Token: 0x060134A4 RID: 79012 RVA: 0x005A31EC File Offset: 0x005A13EC
	public int? GetExtraItemIdReplaceOverride()
	{
		return null;
	}

	// Token: 0x060134A5 RID: 79013 RVA: 0x005A3204 File Offset: 0x005A1404
	[NullableContext(2)]
	public void SetExtraItemId(int itemId, Action<bool> callback = null)
	{
		IRouletteListSaveData rouletteListSaveData = this.Owner.GetRouletteListSaveData();
		rouletteListSaveData.ExtraItemId = itemId;
		RouletteController.Instance.SaveRouletteDataRequest(rouletteListSaveData, callback);
	}

	// Token: 0x060134A6 RID: 79014 RVA: 0x005A3230 File Offset: 0x005A1430
	public void ApplyServerSnapshot(int itemId)
	{
		this.CurrentItemId = itemId;
	}

	// Token: 0x0400A515 RID: 42261
	private int CurrentItemId;

	// Token: 0x0400A516 RID: 42262
	[Nullable(1)]
	private readonly RouletteListDataExplore Owner;
}

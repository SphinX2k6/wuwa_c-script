using System;
using System.Runtime.CompilerServices;

// Token: 0x02002900 RID: 10496
public class NormalExtraItemIdProxy : IExtraItemIdProxy
{
	// Token: 0x06015A9E RID: 88734 RVA: 0x005782E1 File Offset: 0x005764E1
	[NullableContext(1)]
	public NormalExtraItemIdProxy(RouletteListDataExplore Owner)
	{
		this.Owner = Owner;
	}

	// Token: 0x06015A9F RID: 88735 RVA: 0x005782F0 File Offset: 0x005764F0
	public int GetExtraItemId()
	{
		return this.CurrentItemId;
	}

	// Token: 0x06015AA0 RID: 88736 RVA: 0x005782F8 File Offset: 0x005764F8
	public int? GetExtraItemIdReplaceOverride()
	{
		return null;
	}

	// Token: 0x06015AA1 RID: 88737 RVA: 0x00578310 File Offset: 0x00576510
	[NullableContext(2)]
	public void SetExtraItemId(int itemId, Action<bool> callback = null)
	{
		IRouletteListSaveData rouletteListSaveData = this.Owner.GetRouletteListSaveData();
		rouletteListSaveData.ExtraItemId = itemId;
		RouletteController.Instance.SaveRouletteDataRequest(rouletteListSaveData, callback);
	}

	// Token: 0x06015AA2 RID: 88738 RVA: 0x0057833C File Offset: 0x0057653C
	public void ApplyServerSnapshot(int itemId)
	{
		this.CurrentItemId = itemId;
	}

	// Token: 0x0400A12A RID: 41258
	private int CurrentItemId;

	// Token: 0x0400A12B RID: 41259
	[Nullable(1)]
	private readonly RouletteListDataExplore Owner;
}

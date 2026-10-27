using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020023CC RID: 9164
public class PersonalCardItem : PersonalCardBaseItem
{
	// Token: 0x0601252B RID: 75051 RVA: 0x004834FC File Offset: 0x004816FC
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
	}

	// Token: 0x0601252C RID: 75052 RVA: 0x0048353C File Offset: 0x0048173C
	[NullableContext(1)]
	public override void Refresh(PersonalCardData data, bool isSelected, int gridIndex)
	{
		base.Refresh(data, isSelected, gridIndex);
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(4);
		bool flag = PersonalController.Instance.CheckCardIsUsing(this.CardConfig.Value.Id);
		item.SetUIActive(flag && !this.IsOtherCardItem);
		item2.SetUIActive(!data.IsUnLock);
	}

	// Token: 0x0601252D RID: 75053 RVA: 0x004835A2 File Offset: 0x004817A2
	public void SetIsOtherCardItem(bool isOther)
	{
		this.IsOtherCardItem = isOther;
	}

	// Token: 0x04008A7D RID: 35453
	private bool IsOtherCardItem;
}

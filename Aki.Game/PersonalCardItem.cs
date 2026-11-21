using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020018B1 RID: 6321
public class PersonalCardItem : PersonalCardBaseItem
{
	// Token: 0x0600F9DD RID: 63965 RVA: 0x004909FC File Offset: 0x0048EBFC
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
	}

	// Token: 0x0600F9DE RID: 63966 RVA: 0x00490A3C File Offset: 0x0048EC3C
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

	// Token: 0x0600F9DF RID: 63967 RVA: 0x00490AA2 File Offset: 0x0048ECA2
	public void SetIsOtherCardItem(bool isOther)
	{
		this.IsOtherCardItem = isOther;
	}

	// Token: 0x04008BC4 RID: 35780
	private bool IsOtherCardItem;
}

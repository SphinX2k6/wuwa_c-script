using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000DA7 RID: 3495
public class ItemTipsCharacterComponent : TipsBaseSubComponent
{
	// Token: 0x06008EF2 RID: 36594 RVA: 0x002B004C File Offset: 0x002AE24C
	[NullableContext(1)]
	public ItemTipsCharacterComponent(UUIItem rootUiItem) : base(rootUiItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_TipsRole", rootUiItem, false);
	}

	// Token: 0x06008EF3 RID: 36595 RVA: 0x002B0064 File Offset: 0x002AE264
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008EF4 RID: 36596 RVA: 0x002B010F File Offset: 0x002AE30F
	protected override void OnStart()
	{
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x06008EF5 RID: 36597 RVA: 0x002B011E File Offset: 0x002AE31E
	protected override void OnBeforeDestroy()
	{
		if (this.Data != null)
		{
			this.Data = null;
			ItemTipsModel.Instance.SetCurrentItemTipsData(null);
		}
	}

	// Token: 0x06008EF6 RID: 36598 RVA: 0x002B013C File Offset: 0x002AE33C
	[NullableContext(1)]
	public override void Refresh(ItemTipsData data)
	{
		TipsCharacterData tipsCharacterData = (TipsCharacterData)data;
		Action action = delegate()
		{
			this.Data = tipsCharacterData;
			ItemTipsModel.Instance.SetCurrentItemTipsData(tipsCharacterData);
			ElementInfo elementConfig = tipsCharacterData.GetElementConfig();
			UUITexture texture = this.GetTexture(1);
			this.SetElementIcon(elementConfig.Icon, texture, elementConfig.Id, null);
			texture.SetColor(FColor.FromHex(elementConfig.ElementColor));
			LguiUtil.Instance.SetLocalTextNew(this.GetText(0), elementConfig.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(this.GetText(2), tipsCharacterData.GetRoleIntroduction(), Array.Empty<object>());
		};
		if (base.InAsyncLoading())
		{
			this.OperationMap["Refresh"] = action;
			return;
		}
		action();
	}

	// Token: 0x0400559E RID: 21918
	[Nullable(2)]
	private TipsCharacterData Data;

	// Token: 0x02006FE9 RID: 28649
	private class EChildType
	{
		// Token: 0x040248DC RID: 149724
		public const int ElementText = 0;

		// Token: 0x040248DD RID: 149725
		public const int ElementTexture = 1;

		// Token: 0x040248DE RID: 149726
		public const int BackgroundText = 2;

		// Token: 0x040248DF RID: 149727
		public const int GetWayItem = 3;
	}
}

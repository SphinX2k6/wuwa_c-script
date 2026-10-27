using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020018EE RID: 6382
public class ItemTipsCharacterComponent : TipsBaseSubComponent
{
	// Token: 0x0600BB08 RID: 47880 RVA: 0x002A58DC File Offset: 0x002A3ADC
	[NullableContext(1)]
	public ItemTipsCharacterComponent(UUIItem rootUiItem) : base(rootUiItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_TipsRole", rootUiItem, false);
	}

	// Token: 0x0600BB09 RID: 47881 RVA: 0x002A58F4 File Offset: 0x002A3AF4
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

	// Token: 0x0600BB0A RID: 47882 RVA: 0x002A599F File Offset: 0x002A3B9F
	protected override void OnStart()
	{
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x0600BB0B RID: 47883 RVA: 0x002A59AE File Offset: 0x002A3BAE
	protected override void OnBeforeDestroy()
	{
		if (this.Data != null)
		{
			this.Data = null;
			ItemTipsModel.Instance.SetCurrentItemTipsData(null);
		}
	}

	// Token: 0x0600BB0C RID: 47884 RVA: 0x002A59CC File Offset: 0x002A3BCC
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

	// Token: 0x040054F3 RID: 21747
	[Nullable(2)]
	private TipsCharacterData Data;

	// Token: 0x02007E62 RID: 32354
	private class EChildType
	{
		// Token: 0x040295AF RID: 169391
		public const int ElementText = 0;

		// Token: 0x040295B0 RID: 169392
		public const int ElementTexture = 1;

		// Token: 0x040295B1 RID: 169393
		public const int BackgroundText = 2;

		// Token: 0x040295B2 RID: 169394
		public const int GetWayItem = 3;
	}
}

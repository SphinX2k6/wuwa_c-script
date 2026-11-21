using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000774 RID: 1908
[NullableContext(1)]
[Nullable(0)]
public class LordGymBossCardItem : AutoAttachItem<int>
{
	// Token: 0x06005773 RID: 22387 RVA: 0x001CA25C File Offset: 0x001C845C
	[NullableContext(2)]
	public LordGymBossCardItem(AActor uiItem = null) : base(uiItem)
	{
	}

	// Token: 0x06005774 RID: 22388 RVA: 0x001CA270 File Offset: 0x001C8470
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06005775 RID: 22389 RVA: 0x001CA35D File Offset: 0x001C855D
	private LordGymLordStarItem CreateStarItem()
	{
		return new LordGymLordStarItem();
	}

	// Token: 0x06005776 RID: 22390 RVA: 0x001CA364 File Offset: 0x001C8564
	public void BindOnSelected(Action<int> onSelected)
	{
		this.OnSelectedCallback = onSelected;
	}

	// Token: 0x06005777 RID: 22391 RVA: 0x001CA36D File Offset: 0x001C856D
	public override void OnSelect()
	{
		if (this.OnSelectedCallback != null)
		{
			this.OnSelectedCallback(base.GetCurrentShowItemIndex());
		}
	}

	// Token: 0x06005778 RID: 22392 RVA: 0x001CA388 File Offset: 0x001C8588
	protected override void OnUnSelect()
	{
	}

	// Token: 0x06005779 RID: 22393 RVA: 0x001CA38A File Offset: 0x001C858A
	protected override void OnMoveItem()
	{
	}

	// Token: 0x0600577A RID: 22394 RVA: 0x001CA38C File Offset: 0x001C858C
	protected override void OnRefreshItem(int id)
	{
		LordGymEntrance? lordGymEntranceConfig = LordGymConfig.Instance.GetLordGymEntranceConfig(id);
		if (lordGymEntranceConfig == null)
		{
			return;
		}
		LordGymEntrance value = lordGymEntranceConfig.Value;
		if (value.LordGymListLength == 0)
		{
			return;
		}
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(value.LordGymList(0));
		if (lordGymConfig == null)
		{
			return;
		}
		LordGym value2 = lordGymConfig.Value;
		if (value2.MonsterListLength == 0)
		{
			return;
		}
		MonsterInfo value3 = ConfigMonsterInfoById.GetConfig(value2.MonsterList(0), true).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value3.Name, Array.Empty<object>());
		base.SetTextureByPath(value3.BigIcon, base.GetTexture(1), null, null);
		this.StarDataList.Clear();
		for (int i = 0; i < value.LordGymListLength; i++)
		{
			this.StarDataList.Add(LordGymModel.Instance.GetLordGymIsFinish(value.LordGymList(i)));
		}
		if (this.StarLayout == null)
		{
			this.StarLayout = new GenericLayout<LordGymLordStarItem, bool>(base.GetHorizontalLayout(3), new Func<LordGymLordStarItem>(this.CreateStarItem), null, false, true);
		}
		this.StarLayout.RefreshByData(this.StarDataList, null, false);
	}

	// Token: 0x04003BEE RID: 15342
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<LordGymLordStarItem, bool> StarLayout;

	// Token: 0x04003BEF RID: 15343
	private List<bool> StarDataList = new List<bool>();

	// Token: 0x04003BF0 RID: 15344
	[Nullable(2)]
	private Action<int> OnSelectedCallback;

	// Token: 0x02006A64 RID: 27236
	[NullableContext(0)]
	private class ECardComponent
	{
		// Token: 0x0402303A RID: 143418
		public const int Btn = 0;

		// Token: 0x0402303B RID: 143419
		public const int Monster = 1;

		// Token: 0x0402303C RID: 143420
		public const int Name = 2;

		// Token: 0x0402303D RID: 143421
		public const int StarLayout = 3;

		// Token: 0x0402303E RID: 143422
		public const int Star = 4;

		// Token: 0x0402303F RID: 143423
		public const int New = 5;
	}
}

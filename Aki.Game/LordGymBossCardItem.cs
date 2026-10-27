using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020012C0 RID: 4800
[NullableContext(1)]
[Nullable(0)]
public class LordGymBossCardItem : AutoAttachItem<int>
{
	// Token: 0x060083D8 RID: 33752 RVA: 0x001C1400 File Offset: 0x001BF600
	[NullableContext(2)]
	public LordGymBossCardItem(AActor uiItem = null) : base(uiItem)
	{
	}

	// Token: 0x060083D9 RID: 33753 RVA: 0x001C1414 File Offset: 0x001BF614
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

	// Token: 0x060083DA RID: 33754 RVA: 0x001C1501 File Offset: 0x001BF701
	private LordGymLordStarItem CreateStarItem()
	{
		return new LordGymLordStarItem();
	}

	// Token: 0x060083DB RID: 33755 RVA: 0x001C1508 File Offset: 0x001BF708
	public void BindOnSelected(Action<int> onSelected)
	{
		this.OnSelectedCallback = onSelected;
	}

	// Token: 0x060083DC RID: 33756 RVA: 0x001C1511 File Offset: 0x001BF711
	public override void OnSelect()
	{
		if (this.OnSelectedCallback != null)
		{
			this.OnSelectedCallback(base.GetCurrentShowItemIndex());
		}
	}

	// Token: 0x060083DD RID: 33757 RVA: 0x001C152C File Offset: 0x001BF72C
	protected override void OnUnSelect()
	{
	}

	// Token: 0x060083DE RID: 33758 RVA: 0x001C152E File Offset: 0x001BF72E
	protected override void OnMoveItem()
	{
	}

	// Token: 0x060083DF RID: 33759 RVA: 0x001C1530 File Offset: 0x001BF730
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

	// Token: 0x04003B56 RID: 15190
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<LordGymLordStarItem, bool> StarLayout;

	// Token: 0x04003B57 RID: 15191
	private List<bool> StarDataList = new List<bool>();

	// Token: 0x04003B58 RID: 15192
	[Nullable(2)]
	private Action<int> OnSelectedCallback;

	// Token: 0x020078DA RID: 30938
	[NullableContext(0)]
	private class ECardComponent
	{
		// Token: 0x04027D0C RID: 163084
		public const int Btn = 0;

		// Token: 0x04027D0D RID: 163085
		public const int Monster = 1;

		// Token: 0x04027D0E RID: 163086
		public const int Name = 2;

		// Token: 0x04027D0F RID: 163087
		public const int StarLayout = 3;

		// Token: 0x04027D10 RID: 163088
		public const int Star = 4;

		// Token: 0x04027D11 RID: 163089
		public const int New = 5;
	}
}

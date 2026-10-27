using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CA2 RID: 7330
public class GachaShareTenPanel : UiPanelBase
{
	// Token: 0x0600DD56 RID: 56662 RVA: 0x0033C6B4 File Offset: 0x0033A8B4
	protected override UniTask OnBeforeStartAsync()
	{
		GachaShareTenPanel.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaShareTenPanel.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DD57 RID: 56663 RVA: 0x0033C6F8 File Offset: 0x0033A8F8
	[NullableContext(1)]
	public void Refresh(GachaResult[] dataList)
	{
		List<GachaResult> list = new List<GachaResult>(dataList);
		list.Sort(delegate(GachaResult a, GachaResult b)
		{
			if (a.Proto_GachaReward == null || b.Proto_GachaReward == null)
			{
				return 0;
			}
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.Proto_GachaReward.ItemId);
			ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(b.Proto_GachaReward.ItemId);
			int num = (itemConfigData != null) ? itemConfigData.QualityId : 0;
			int num2 = (itemConfigData2 != null) ? itemConfigData2.QualityId : 0;
			if (num == num2)
			{
				int num3 = GachaShareTenPanel.<Refresh>g__RevertType|3_0(GachaConfig.Instance.GetItemIdType(a.Proto_GachaReward.ItemId));
				return GachaShareTenPanel.<Refresh>g__RevertType|3_0(GachaConfig.Instance.GetItemIdType(b.Proto_GachaReward.ItemId)) - num3;
			}
			return num2 - num;
		});
		this.GachaResultLayout.RefreshByData(list.ToArray(), null, false);
	}

	// Token: 0x0600DD58 RID: 56664 RVA: 0x0033C744 File Offset: 0x0033A944
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600DD59 RID: 56665 RVA: 0x0033C767 File Offset: 0x0033A967
	[NullableContext(2)]
	public UUIGridLayout GetGachaResultItemLayout()
	{
		return base.GetGridLayout(0);
	}

	// Token: 0x0600DD5A RID: 56666 RVA: 0x0033C770 File Offset: 0x0033A970
	[NullableContext(1)]
	private GachaShareResultItem InitGachaResultItem()
	{
		return new GachaShareResultItem();
	}

	// Token: 0x0600DD5B RID: 56667 RVA: 0x0033C777 File Offset: 0x0033A977
	protected override void OnBeforeDestroy()
	{
		GenericLayout<GachaShareResultItem, GachaResult> gachaResultLayout = this.GachaResultLayout;
		if (gachaResultLayout == null)
		{
			return;
		}
		gachaResultLayout.ClearChildren();
	}

	// Token: 0x0600DD5D RID: 56669 RVA: 0x0033C791 File Offset: 0x0033A991
	[CompilerGenerated]
	internal static int <Refresh>g__RevertType|3_0(InventoryDefine.EItemDataType type)
	{
		switch (type)
		{
		case InventoryDefine.EItemDataType.RoleItem:
			return 2;
		case InventoryDefine.EItemDataType.WeaponItem:
			return 1;
		}
		return 0;
	}

	// Token: 0x04006597 RID: 26007
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<GachaShareResultItem, GachaResult> GachaResultLayout;

	// Token: 0x02008288 RID: 33416
	private enum EComponent
	{
		// Token: 0x0402A96D RID: 174445
		GachaResultGridLayout
	}
}

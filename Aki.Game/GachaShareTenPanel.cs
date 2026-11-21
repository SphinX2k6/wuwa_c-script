using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001161 RID: 4449
public class GachaShareTenPanel : UiPanelBase
{
	// Token: 0x0600B16C RID: 45420 RVA: 0x00347B00 File Offset: 0x00345D00
	protected override UniTask OnBeforeStartAsync()
	{
		GachaShareTenPanel.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaShareTenPanel.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B16D RID: 45421 RVA: 0x00347B44 File Offset: 0x00345D44
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

	// Token: 0x0600B16E RID: 45422 RVA: 0x00347B90 File Offset: 0x00345D90
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600B16F RID: 45423 RVA: 0x00347BB3 File Offset: 0x00345DB3
	[NullableContext(2)]
	public UUIGridLayout GetGachaResultItemLayout()
	{
		return base.GetGridLayout(0);
	}

	// Token: 0x0600B170 RID: 45424 RVA: 0x00347BBC File Offset: 0x00345DBC
	[NullableContext(1)]
	private GachaShareResultItem InitGachaResultItem()
	{
		return new GachaShareResultItem();
	}

	// Token: 0x0600B171 RID: 45425 RVA: 0x00347BC3 File Offset: 0x00345DC3
	protected override void OnBeforeDestroy()
	{
		GenericLayout<GachaShareResultItem, GachaResult> gachaResultLayout = this.GachaResultLayout;
		if (gachaResultLayout == null)
		{
			return;
		}
		gachaResultLayout.ClearChildren();
	}

	// Token: 0x0600B173 RID: 45427 RVA: 0x00347BDD File Offset: 0x00345DDD
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

	// Token: 0x04006668 RID: 26216
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<GachaShareResultItem, GachaResult> GachaResultLayout;

	// Token: 0x0200740F RID: 29711
	private enum EComponent
	{
		// Token: 0x04025C8B RID: 154763
		GachaResultGridLayout
	}
}

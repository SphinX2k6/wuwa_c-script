using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029C2 RID: 10690
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerResetItem : UiPanelBase
{
	// Token: 0x0601628A RID: 90762 RVA: 0x0059AB04 File Offset: 0x00598D04
	public UniTask Init(UUIItem item)
	{
		ShipTowerResetItem.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ShipTowerResetItem.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0601628B RID: 90763 RVA: 0x0059AB50 File Offset: 0x00598D50
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
	}

	// Token: 0x0601628C RID: 90764 RVA: 0x0059AC04 File Offset: 0x00598E04
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerResetItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerResetItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601628D RID: 90765 RVA: 0x0059AC48 File Offset: 0x00598E48
	private void OnClickBuff(MediumItemGridExtendCallback param)
	{
		ShipTowerTeamData panelData = this.PanelData;
		int? num;
		if (panelData == null)
		{
			num = null;
		}
		else
		{
			ShipTowerBuffData buffData = panelData.BuffData;
			num = ((buffData != null) ? new int?(buffData.ItemId) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault(1);
		ItemController.Instance.OpenItemTipsByItemId(valueOrDefault, true, null);
	}

	// Token: 0x0601628E RID: 90766 RVA: 0x0059ACA0 File Offset: 0x00598EA0
	public void UpdateData(ShipTowerTeamData data)
	{
		this.PanelData = data;
		ShipTowerBuffData buffData = data.BuffData;
		int value = (buffData != null) ? buffData.ItemId : 1;
		this.BuffItem.Apply<PropSmallItemGrid>(new PropSmallItemGrid
		{
			Data = data,
			ItemConfigId = new int?(value)
		});
		ShipTowerBuffData buffData2 = data.BuffData;
		bool flag = buffData2 != null && buffData2.IsUnlimited(new int?(data.StageId));
		base.GetItem(4).SetUIActive(!flag);
		base.GetText(5).SetUIActive(flag);
		UUIText text = base.GetText(1);
		ShipTowerBuffData buffData3 = data.BuffData;
		text.ShowTextNew(((buffData3 != null) ? buffData3.ItemNameKey : null) ?? "");
		ShipTowerBuffData buffData4 = data.BuffData;
		text.SetColor((buffData4 != null) ? buffData4.GetQualityColor() : new FColor());
		if (flag)
		{
			return;
		}
		ShipTowerBuffData buffData5 = data.BuffData;
		int num = (buffData5 != null) ? buffData5.CanUseCountNoEdit : 0;
		int val = num + 1;
		ShipTowerBuffData buffData6 = data.BuffData;
		int num2 = Math.Min(val, (buffData6 != null) ? buffData6.TotalUseCount : 0);
		base.GetText(2).SetText(num.ToString(), true);
		base.GetText(3).SetText(num2.ToString(), true);
	}

	// Token: 0x0400A50C RID: 42252
	private SmallItemGrid BuffItem;

	// Token: 0x0400A50D RID: 42253
	[Nullable(2)]
	private ShipTowerTeamData PanelData;

	// Token: 0x02008FDF RID: 36831
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E977 RID: 190839
		public const int ItemBuff = 0;

		// Token: 0x0402E978 RID: 190840
		public const int TxtName = 1;

		// Token: 0x0402E979 RID: 190841
		public const int TxtCount = 2;

		// Token: 0x0402E97A RID: 190842
		public const int TxtResetCount = 3;

		// Token: 0x0402E97B RID: 190843
		public const int ItemCountRoot = 4;

		// Token: 0x0402E97C RID: 190844
		public const int TxtEndless = 5;

		// Token: 0x0402E97D RID: 190845
		public const int TxtUseCount = 6;
	}
}

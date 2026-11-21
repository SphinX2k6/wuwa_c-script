using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F3D RID: 7997
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerResetItem : UiPanelBase
{
	// Token: 0x06013C90 RID: 81040 RVA: 0x005C5ABC File Offset: 0x005C3CBC
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

	// Token: 0x06013C91 RID: 81041 RVA: 0x005C5B08 File Offset: 0x005C3D08
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

	// Token: 0x06013C92 RID: 81042 RVA: 0x005C5BBC File Offset: 0x005C3DBC
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerResetItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerResetItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013C93 RID: 81043 RVA: 0x005C5C00 File Offset: 0x005C3E00
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
		ItemController.Instance.OpenItemTipsByItemId(valueOrDefault, true, null, false);
	}

	// Token: 0x06013C94 RID: 81044 RVA: 0x005C5C58 File Offset: 0x005C3E58
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

	// Token: 0x0400A8F6 RID: 43254
	private SmallItemGrid BuffItem;

	// Token: 0x0400A8F7 RID: 43255
	[Nullable(2)]
	private ShipTowerTeamData PanelData;

	// Token: 0x02008226 RID: 33318
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A06F RID: 172143
		public const int ItemBuff = 0;

		// Token: 0x0402A070 RID: 172144
		public const int TxtName = 1;

		// Token: 0x0402A071 RID: 172145
		public const int TxtCount = 2;

		// Token: 0x0402A072 RID: 172146
		public const int TxtResetCount = 3;

		// Token: 0x0402A073 RID: 172147
		public const int ItemCountRoot = 4;

		// Token: 0x0402A074 RID: 172148
		public const int TxtEndless = 5;

		// Token: 0x0402A075 RID: 172149
		public const int TxtUseCount = 6;
	}
}

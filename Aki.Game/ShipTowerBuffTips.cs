using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200299E RID: 10654
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerBuffTips : UiPanelBase
{
	// Token: 0x06016165 RID: 90469 RVA: 0x005959E8 File Offset: 0x00593BE8
	public UniTask Init(UUIItem item)
	{
		ShipTowerBuffTips.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ShipTowerBuffTips.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06016166 RID: 90470 RVA: 0x00595A34 File Offset: 0x00593C34
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerBuffTips.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerBuffTips.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016167 RID: 90471 RVA: 0x00595A78 File Offset: 0x00593C78
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent))
		};
	}

	// Token: 0x06016168 RID: 90472 RVA: 0x00595B9B File Offset: 0x00593D9B
	protected override void OnStart()
	{
	}

	// Token: 0x06016169 RID: 90473 RVA: 0x00595B9D File Offset: 0x00593D9D
	protected override void OnBeforeShow()
	{
	}

	// Token: 0x0601616A RID: 90474 RVA: 0x00595B9F File Offset: 0x00593D9F
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x0601616B RID: 90475 RVA: 0x00595BA4 File Offset: 0x00593DA4
	public void UpdateData(ShipTowerBuffData data)
	{
		this.Data = data;
		ItemTipsData tipsDataById = ItemTipsComponentUtilTool.GetTipsDataById(this.Data.ItemId, null, null);
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(this.Data.ItemId);
		base.GetText(2).ShowTextNew(tipsDataById.Title);
		base.GetText(3).ShowTextNew(((itemConfig != null) ? itemConfig.GetValueOrDefault().BgDescription : null) ?? "");
		base.SetTextureByPath(((itemConfig != null) ? itemConfig.GetValueOrDefault().IconMiddle : null) ?? "", base.GetTexture(4), null, null);
		bool flag = tipsDataById.GetWayData != null && tipsDataById.GetWayData.Length != 0;
		base.GetVerticalLayout(9).RootUIComp.Get().SetUIActive(flag);
		if (flag)
		{
			GenericLayout<ShipTowerBuffWayItem, IGetWayItemData> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.RefreshByDataAsync(tipsDataById.GetWayData, false, null);
		}
	}

	// Token: 0x0601616C RID: 90476 RVA: 0x00595CBF File Offset: 0x00593EBF
	private ShipTowerBuffWayItem CreateWayItem()
	{
		return new ShipTowerBuffWayItem();
	}

	// Token: 0x0400A4A3 RID: 42147
	private ShipTowerBuffData Data;

	// Token: 0x0400A4A4 RID: 42148
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerBuffWayItem, IGetWayItemData> ItemLayout;

	// Token: 0x02008FA4 RID: 36772
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E860 RID: 190560
		public const int TextureQualityBg = 0;

		// Token: 0x0402E861 RID: 190561
		public const int TxtUseTimes = 1;

		// Token: 0x0402E862 RID: 190562
		public const int TxtName = 2;

		// Token: 0x0402E863 RID: 190563
		public const int TxtDesc = 3;

		// Token: 0x0402E864 RID: 190564
		public const int TextureIcon = 4;

		// Token: 0x0402E865 RID: 190565
		public const int ItemQualityEffectBlue = 5;

		// Token: 0x0402E866 RID: 190566
		public const int SpriteQualityBgPurple = 6;

		// Token: 0x0402E867 RID: 190567
		public const int ItemQualityEffectPurple = 7;

		// Token: 0x0402E868 RID: 190568
		public const int ItemQualityEffectGold = 8;

		// Token: 0x0402E869 RID: 190569
		public const int VerticalLayoutWay = 9;

		// Token: 0x0402E86A RID: 190570
		public const int ItemWay = 10;

		// Token: 0x0402E86B RID: 190571
		public const int BtnWay = 11;
	}
}

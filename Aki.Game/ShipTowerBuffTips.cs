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

// Token: 0x02001F19 RID: 7961
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerBuffTips : UiPanelBase
{
	// Token: 0x06013B6B RID: 80747 RVA: 0x005C09A8 File Offset: 0x005BEBA8
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

	// Token: 0x06013B6C RID: 80748 RVA: 0x005C09F4 File Offset: 0x005BEBF4
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerBuffTips.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerBuffTips.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013B6D RID: 80749 RVA: 0x005C0A38 File Offset: 0x005BEC38
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

	// Token: 0x06013B6E RID: 80750 RVA: 0x005C0B5B File Offset: 0x005BED5B
	protected override void OnStart()
	{
	}

	// Token: 0x06013B6F RID: 80751 RVA: 0x005C0B5D File Offset: 0x005BED5D
	protected override void OnBeforeShow()
	{
	}

	// Token: 0x06013B70 RID: 80752 RVA: 0x005C0B5F File Offset: 0x005BED5F
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06013B71 RID: 80753 RVA: 0x005C0B64 File Offset: 0x005BED64
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

	// Token: 0x06013B72 RID: 80754 RVA: 0x005C0C7F File Offset: 0x005BEE7F
	private ShipTowerBuffWayItem CreateWayItem()
	{
		return new ShipTowerBuffWayItem();
	}

	// Token: 0x0400A88D RID: 43149
	private ShipTowerBuffData Data;

	// Token: 0x0400A88E RID: 43150
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerBuffWayItem, IGetWayItemData> ItemLayout;

	// Token: 0x020081ED RID: 33261
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029F5F RID: 171871
		public const int TextureQualityBg = 0;

		// Token: 0x04029F60 RID: 171872
		public const int TxtUseTimes = 1;

		// Token: 0x04029F61 RID: 171873
		public const int TxtName = 2;

		// Token: 0x04029F62 RID: 171874
		public const int TxtDesc = 3;

		// Token: 0x04029F63 RID: 171875
		public const int TextureIcon = 4;

		// Token: 0x04029F64 RID: 171876
		public const int ItemQualityEffectBlue = 5;

		// Token: 0x04029F65 RID: 171877
		public const int SpriteQualityBgPurple = 6;

		// Token: 0x04029F66 RID: 171878
		public const int ItemQualityEffectPurple = 7;

		// Token: 0x04029F67 RID: 171879
		public const int ItemQualityEffectGold = 8;

		// Token: 0x04029F68 RID: 171880
		public const int VerticalLayoutWay = 9;

		// Token: 0x04029F69 RID: 171881
		public const int ItemWay = 10;

		// Token: 0x04029F6A RID: 171882
		public const int BtnWay = 11;
	}
}

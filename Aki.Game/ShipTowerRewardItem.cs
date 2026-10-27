using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029C8 RID: 10696
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerRewardItem : GridProxyAbstract<ShipTowerRewardItemData>
{
	// Token: 0x060162AE RID: 90798 RVA: 0x0059B3FC File Offset: 0x005995FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUISprite))
		};
	}

	// Token: 0x060162AF RID: 90799 RVA: 0x0059B4B0 File Offset: 0x005996B0
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerRewardItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerRewardItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060162B0 RID: 90800 RVA: 0x0059B4F4 File Offset: 0x005996F4
	public override void Refresh(ShipTowerRewardItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.ShowTextNew(this.ItemData.TitleKey);
		}
		UUIButtonComponent button = base.GetButton(1);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(this.ItemData.IsReceive);
			}
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetUIActive(this.ItemData.IsProgress);
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(this.ItemData.IsCompleted);
		}
		UUISprite sprite2 = base.GetSprite(6);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(this.ItemData.IsCompleted);
		}
		ButtonItem btnReceive = this.BtnReceive;
		if (btnReceive != null)
		{
			btnReceive.SetRedDotVisible(this.ItemData.IsReceive);
		}
		GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
		if (rewardLayout == null)
		{
			return;
		}
		rewardLayout.RefreshByData(this.ItemData.RewardList, null, false);
	}

	// Token: 0x060162B1 RID: 90801 RVA: 0x0059B5E5 File Offset: 0x005997E5
	private void OnClickBtnReceive()
	{
		Action<ShipTowerRewardItemData> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this.ItemData);
	}

	// Token: 0x0400A516 RID: 42262
	private ShipTowerRewardItemData ItemData;

	// Token: 0x0400A517 RID: 42263
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x0400A518 RID: 42264
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerRewardItemData> ClickCallBack;

	// Token: 0x0400A519 RID: 42265
	[Nullable(2)]
	public ButtonItem BtnReceive;

	// Token: 0x02008FE9 RID: 36841
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E9A4 RID: 190884
		public const int TextName = 0;

		// Token: 0x0402E9A5 RID: 190885
		public const int BtnReceive = 1;

		// Token: 0x0402E9A6 RID: 190886
		public const int TextProgress = 2;

		// Token: 0x0402E9A7 RID: 190887
		public const int HLayoutReward = 3;

		// Token: 0x0402E9A8 RID: 190888
		public const int ItemLock = 4;

		// Token: 0x0402E9A9 RID: 190889
		public const int SpriteMask = 5;

		// Token: 0x0402E9AA RID: 190890
		public const int SpriteCompleted = 6;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F43 RID: 8003
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerRewardItem : GridProxyAbstract<ShipTowerRewardItemData>
{
	// Token: 0x06013CB4 RID: 81076 RVA: 0x005C63B4 File Offset: 0x005C45B4
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

	// Token: 0x06013CB5 RID: 81077 RVA: 0x005C6468 File Offset: 0x005C4668
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerRewardItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerRewardItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013CB6 RID: 81078 RVA: 0x005C64AC File Offset: 0x005C46AC
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

	// Token: 0x06013CB7 RID: 81079 RVA: 0x005C659D File Offset: 0x005C479D
	private void OnClickBtnReceive()
	{
		Action<ShipTowerRewardItemData> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this.ItemData);
	}

	// Token: 0x0400A900 RID: 43264
	private ShipTowerRewardItemData ItemData;

	// Token: 0x0400A901 RID: 43265
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x0400A902 RID: 43266
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerRewardItemData> ClickCallBack;

	// Token: 0x0400A903 RID: 43267
	[Nullable(2)]
	public ButtonItem BtnReceive;

	// Token: 0x02008230 RID: 33328
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A09C RID: 172188
		public const int TextName = 0;

		// Token: 0x0402A09D RID: 172189
		public const int BtnReceive = 1;

		// Token: 0x0402A09E RID: 172190
		public const int TextProgress = 2;

		// Token: 0x0402A09F RID: 172191
		public const int HLayoutReward = 3;

		// Token: 0x0402A0A0 RID: 172192
		public const int ItemLock = 4;

		// Token: 0x0402A0A1 RID: 172193
		public const int SpriteMask = 5;

		// Token: 0x0402A0A2 RID: 172194
		public const int SpriteCompleted = 6;
	}
}

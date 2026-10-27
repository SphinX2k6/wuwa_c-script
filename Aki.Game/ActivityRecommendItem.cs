using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001098 RID: 4248
[NullableContext(1)]
[Nullable(0)]
public class ActivityRecommendItem : GridProxyAbstract<int>
{
	// Token: 0x06006EA3 RID: 28323 RVA: 0x00169605 File Offset: 0x00167805
	public void SetViewModel(ActivityRecommendViewModel vm)
	{
		this.Vm = vm;
	}

	// Token: 0x06006EA4 RID: 28324 RVA: 0x00169610 File Offset: 0x00167810
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUISprite)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUISprite)),
			new ValueTuple<int, Type>(18, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(11, new Action(this.OnClickJumpBtn)),
			new ValueTuple<int, Delegate>(12, new Action(this.OnClickPreOpenBtn))
		};
	}

	// Token: 0x06006EA5 RID: 28325 RVA: 0x00169811 File Offset: 0x00167A11
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(9), new Func<CommonItemSmallItemGrid>(this.InitRewardItem), null, false, true);
	}

	// Token: 0x06006EA6 RID: 28326 RVA: 0x00169835 File Offset: 0x00167A35
	private CommonItemSmallItemGrid InitRewardItem()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = ((TItem _) => this.RewardShowReceived)
		};
	}

	// Token: 0x06006EA7 RID: 28327 RVA: 0x00169850 File Offset: 0x00167A50
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.CurrentId = data;
		ActivityRecommendViewModel vm = this.Vm;
		RecommendItemDisplay? recommendItemDisplay = (vm != null) ? vm.GetItemDisplayData(data) : null;
		if (recommendItemDisplay == null)
		{
			return;
		}
		this.ApplyDisplay(recommendItemDisplay.Value);
	}

	// Token: 0x06006EA8 RID: 28328 RVA: 0x00169898 File Offset: 0x00167A98
	private void ApplyDisplay(RecommendItemDisplay display)
	{
		base.GetText(3).SetText(display.Title, true);
		UUIText text = base.GetText(4);
		if (display.SubTitle == null)
		{
			text.SetUIActive(false);
		}
		else
		{
			text.SetUIActive(true);
			LguiUtil.Instance.SetLocalText(text, display.SubTitle.Value.Key, display.SubTitle.Value.Args);
		}
		this.ApplyIcon(display);
		UUIItem item = base.GetItem(5);
		if (display.Tag == null)
		{
			item.SetUIActive(false);
		}
		else
		{
			RecommendTagDisplay value = display.Tag.Value;
			item.SetUIActive(true);
			this.SetSpriteByPath(value.BgSpritePath, base.GetSprite(6), false, null, null);
			UUISprite sprite = base.GetSprite(7);
			if (!string.IsNullOrEmpty(value.IconSpritePath))
			{
				sprite.SetUIActive(true);
				this.SetSpriteByPath(value.IconSpritePath, sprite, false, null, null);
				sprite.SetColor(value.IconColor ?? ActivityRecommendItem.FallbackTagColor);
			}
			else
			{
				sprite.SetUIActive(false);
			}
			UUIText text2 = base.GetText(8);
			if (value.TextLocalize != null)
			{
				LguiUtil.Instance.SetLocalTextNew(text2, value.TextLocalize.Value.Key, value.TextLocalize.Value.Args);
			}
			else
			{
				text2.SetText(value.Text ?? "", true);
			}
			text2.SetColor(value.IconColor ?? ActivityRecommendItem.FallbackTagColor);
		}
		this.RewardShowReceived = display.ShowDownMask;
		if (display.Tag != null && display.Tag.GetValueOrDefault().Style == ERecommendTagStyle.Area)
		{
			GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
			if (rewardLayout != null)
			{
				rewardLayout.RefreshByData(display.RewardList, delegate
				{
					List<CommonItemSmallItemGrid> layoutItemList = this.RewardLayout.GetLayoutItemList();
					if (layoutItemList != null)
					{
						foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in layoutItemList)
						{
							commonItemSmallItemGrid.SetBottomTextVisible(false);
						}
					}
				}, false);
			}
		}
		else
		{
			GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout2 = this.RewardLayout;
			if (rewardLayout2 != null)
			{
				rewardLayout2.RefreshByData(display.RewardList, null, false);
			}
		}
		GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout3 = this.RewardLayout;
		if (rewardLayout3 != null)
		{
			UUIItem rootUiItem = rewardLayout3.GetRootUiItem();
			if (rootUiItem != null)
			{
				rootUiItem.SetUIActive(display.RewardList.Count > 0);
			}
		}
		UUIItem uuiitem = base.GetButton(11).RootUIComp.Get();
		if (uuiitem != null)
		{
			uuiitem.SetUIActive(display.ShowJumpBtn);
		}
		UUIItem uuiitem2 = base.GetButton(12).RootUIComp.Get();
		if (uuiitem2 != null)
		{
			uuiitem2.SetUIActive(display.ShowPreOpenBtn);
		}
		base.GetItem(18).SetUIActive(display.ShowLockedBtn);
		base.GetItem(13).SetUIActive(display.ShowDownMask);
		base.GetItem(14).SetUIActive(!display.IsMainQuestFinished);
	}

	// Token: 0x06006EA9 RID: 28329 RVA: 0x00169B70 File Offset: 0x00167D70
	private void ApplyIcon(RecommendItemDisplay display)
	{
		UUISprite iconSprite = base.GetSprite(1);
		UUITexture iconTexture = base.GetTexture(2);
		UUIItem item = base.GetItem(16);
		if (display.IsBigIcon)
		{
			iconSprite.SetUIActive(false);
			iconTexture.SetUIActive(false);
			if (!string.IsNullOrEmpty(display.IconSpritePath))
			{
				item.SetUIActive(true);
				this.SetSpriteByPath(display.IconSpritePath, base.GetSprite(17), false, null, null);
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			item.SetUIActive(false);
			switch (display.IconSource)
			{
			case ERecommendIconSource.None:
				iconSprite.SetUIActive(false);
				iconTexture.SetUIActive(false);
				return;
			case ERecommendIconSource.Sprite:
				if (string.IsNullOrEmpty(display.IconSpritePath))
				{
					iconSprite.SetUIActive(false);
					iconTexture.SetUIActive(false);
					return;
				}
				iconTexture.SetUIActive(false);
				this.SetSpriteByPath(display.IconSpritePath, iconSprite, false, null, delegate(bool _)
				{
					iconSprite.SetUIActive(true);
				});
				return;
			case ERecommendIconSource.Texture:
				if (string.IsNullOrEmpty(display.IconTexturePath))
				{
					iconSprite.SetUIActive(false);
					iconTexture.SetUIActive(false);
					return;
				}
				iconSprite.SetUIActive(false);
				base.SetTextureByPath(display.IconTexturePath, iconTexture, null, delegate(bool _)
				{
					iconTexture.SetUIActive(true);
				});
				return;
			default:
				return;
			}
		}
	}

	// Token: 0x06006EAA RID: 28330 RVA: 0x00169CF0 File Offset: 0x00167EF0
	private void OnClickJumpBtn()
	{
		ActivityRecommendViewModel vm = this.Vm;
		if (vm == null)
		{
			return;
		}
		vm.OnClickJump(this.CurrentId);
	}

	// Token: 0x06006EAB RID: 28331 RVA: 0x00169D08 File Offset: 0x00167F08
	private void OnClickPreOpenBtn()
	{
		ActivityRecommendViewModel vm = this.Vm;
		if (vm == null)
		{
			return;
		}
		vm.OnClickPreOpen(this.CurrentId);
	}

	// Token: 0x04003351 RID: 13137
	[StaticVariableRuleIgnore]
	private static readonly FColor FallbackTagColor = FColor.FromHex("FFFFFF");

	// Token: 0x04003352 RID: 13138
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x04003353 RID: 13139
	[Nullable(2)]
	private ActivityRecommendViewModel Vm;

	// Token: 0x04003354 RID: 13140
	private int CurrentId;

	// Token: 0x04003355 RID: 13141
	private bool RewardShowReceived;
}

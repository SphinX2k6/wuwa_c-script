using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x02005631 RID: 22065
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DropCatchRewardPreviewItem : GridProxyAbstract<IDropCatchRewardPreviewData>
	{
		// Token: 0x06036891 RID: 223377 RVA: 0x00F3824C File Offset: 0x00F3644C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIArtText)),
				new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.OnClicked))
			};
		}

		// Token: 0x06036892 RID: 223378 RVA: 0x00F38350 File Offset: 0x00F36550
		protected override void OnStart()
		{
			if (this.RewardScrollView != null)
			{
				return;
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(6);
			if (scrollViewWithScrollbar != null)
			{
				this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
			}
			this.StarLayout = new GenericLayout<DropCatchRewardStarItem, bool>(base.GetHorizontalLayout(3), new Func<DropCatchRewardStarItem>(this.CreateStarItem), null, false, true);
		}

		// Token: 0x06036893 RID: 223379 RVA: 0x00F383AD File Offset: 0x00F365AD
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => this.IsRewarded)
			};
		}

		// Token: 0x06036894 RID: 223380 RVA: 0x00F383C6 File Offset: 0x00F365C6
		private DropCatchRewardStarItem CreateStarItem()
		{
			return new DropCatchRewardStarItem();
		}

		// Token: 0x06036895 RID: 223381 RVA: 0x00F383D0 File Offset: 0x00F365D0
		public override void Refresh(IDropCatchRewardPreviewData data, bool isSelected, int gridIndex)
		{
			if (data == null)
			{
				return;
			}
			this.CfgId = data.CfgId;
			DropCatchReward? dropCatchRewardById = DropCatchConfig.Instance.GetDropCatchRewardById(this.CfgId);
			if (dropCatchRewardById == null)
			{
				return;
			}
			this.IsRewarded = (data.State.GetValueOrDefault() == EDropCatchLevelState.Rewarded);
			bool flag = data.State.GetValueOrDefault() == EDropCatchLevelState.Unlock || data.State.GetValueOrDefault() == EDropCatchLevelState.Rewarded;
			UUIArtText artText = base.GetArtText(2);
			UUIItem uuiitem = artText;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(artText.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			UUISprite sprite = base.GetSprite(0);
			UUIItem uuiitem2 = sprite;
			bool bUseChangeColor2 = flag;
			fcolor = new FColor?(sprite.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			UUISprite sprite2 = base.GetSprite(1);
			UUIItem uuiitem3 = sprite2;
			bool bUseChangeColor3 = flag;
			fcolor = new FColor?(sprite2.changeColor);
			uuiitem3.SetChangeColor(bUseChangeColor3, fcolor);
			UUIButtonComponent button = base.GetButton(7);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(data.State.GetValueOrDefault() == EDropCatchLevelState.Unlock);
			}
			UUISprite sprite3 = base.GetSprite(5);
			if (sprite3 != null)
			{
				sprite3.SetUIActive(this.IsRewarded);
			}
			UUISprite sprite4 = base.GetSprite(8);
			if (sprite4 != null)
			{
				sprite4.SetUIActive(flag);
			}
			if (artText != null)
			{
				artText.SetText(dropCatchRewardById.Value.Score.ToString().PadLeft(5, '0'));
			}
			List<TItem> data2 = (dropCatchRewardById.Value.DropId > 0) ? CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropCatchRewardById.Value.DropId) : new List<TItem>();
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScrollView = this.RewardScrollView;
			if (rewardScrollView != null)
			{
				rewardScrollView.RefreshByData(data2, null, false);
			}
			List<bool> list = new List<bool>();
			for (int i = 0; i < gridIndex + 1; i++)
			{
				list.Add(flag);
			}
			GenericLayout<DropCatchRewardStarItem, bool> starLayout = this.StarLayout;
			if (starLayout != null)
			{
				starLayout.RefreshByData(list, null, false);
			}
			if (sprite != null)
			{
				sprite.SetHeight((float)(data.IsLast ? 194 : 224));
			}
		}

		// Token: 0x06036896 RID: 223382 RVA: 0x00F385CB File Offset: 0x00F367CB
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06036897 RID: 223383 RVA: 0x00F385D4 File Offset: 0x00F367D4
		private void OnClicked()
		{
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.CfgId);
		}

		// Token: 0x0401CCF3 RID: 118003
		private int CfgId;

		// Token: 0x0401CCF4 RID: 118004
		private Action<int> ClickCallback = delegate(int index)
		{
		};

		// Token: 0x0401CCF5 RID: 118005
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0401CCF6 RID: 118006
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<DropCatchRewardStarItem, bool> StarLayout;

		// Token: 0x0401CCF7 RID: 118007
		private bool IsRewarded;

		// Token: 0x0401CCF8 RID: 118008
		private const int PROGRESS_BAR_NORMAL_HEIGHT = 224;

		// Token: 0x0401CCF9 RID: 118009
		private const int PROGRESS_BAR_LAST_HEIGHT = 194;
	}
}

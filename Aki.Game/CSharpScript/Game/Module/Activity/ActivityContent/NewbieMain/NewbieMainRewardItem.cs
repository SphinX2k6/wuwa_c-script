using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x02005305 RID: 21253
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NewbieMainRewardItem : GridProxyAbstract<NewbieMainRewardItemData>
	{
		// Token: 0x06034DDB RID: 216539 RVA: 0x00EC75DC File Offset: 0x00EC57DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034DDC RID: 216540 RVA: 0x00EC7688 File Offset: 0x00EC5888
		protected override void OnStart()
		{
			this.RewardGrid = new SmallItemGrid();
			this.RewardGrid.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback _)
			{
				this.OnClickGrid();
			});
			this.RewardGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
			this.RewardGrid.CreateThenShowByActor(base.GetItem(2).GetOwner(), null);
		}

		// Token: 0x06034DDD RID: 216541 RVA: 0x00EC76F9 File Offset: 0x00EC58F9
		public void SetClickCallback(Action<NewbieMainRewardItemData> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06034DDE RID: 216542 RVA: 0x00EC7704 File Offset: 0x00EC5904
		public override void Refresh(NewbieMainRewardItemData data, bool isSelected, int gridIndex)
		{
			this.RewardData = data;
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(data.Score.ToString(), true);
			}
			this.RefreshRewardGrid(data);
			float fillAmount = (data.State == ENewbieScoreRewardState.UnAchieved) ? 0f : 1f;
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(fillAmount);
		}

		// Token: 0x06034DDF RID: 216543 RVA: 0x00EC7764 File Offset: 0x00EC5964
		private void RefreshRewardGrid(NewbieMainRewardItemData data)
		{
			if (this.RewardGrid == null || data.PreviewReward == null)
			{
				return;
			}
			TItem value = data.PreviewReward.Value;
			bool value2 = data.State == ENewbieScoreRewardState.Claimable;
			bool value3 = data.State == ENewbieScoreRewardState.Claimed;
			PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
			propSmallItemGrid.Data = value;
			propSmallItemGrid.ItemConfigId = new int?(value.ItemData.ItemId);
			string bottomText;
			if (value.Count <= 0)
			{
				bottomText = "";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value.Count);
				bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			propSmallItemGrid.BottomText = bottomText;
			propSmallItemGrid.IsReceivableVisible = new bool?(value2);
			propSmallItemGrid.IsReceivedVisible = new bool?(value3);
			propSmallItemGrid.IsRedDotVisible = new bool?(value2);
			PropSmallItemGrid parameters = propSmallItemGrid;
			this.RewardGrid.ApplyPropSmallItemGrid(parameters);
		}

		// Token: 0x06034DE0 RID: 216544 RVA: 0x00EC7832 File Offset: 0x00EC5A32
		private void OnClickGrid()
		{
			if (this.RewardData != null)
			{
				Action<NewbieMainRewardItemData> clickCallback = this.ClickCallback;
				if (clickCallback == null)
				{
					return;
				}
				clickCallback(this.RewardData);
			}
		}

		// Token: 0x0401BF6A RID: 114538
		[Nullable(2)]
		private NewbieMainRewardItemData RewardData;

		// Token: 0x0401BF6B RID: 114539
		[Nullable(2)]
		private SmallItemGrid RewardGrid;

		// Token: 0x0401BF6C RID: 114540
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<NewbieMainRewardItemData> ClickCallback;

		// Token: 0x0200AF7E RID: 44926
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040363BB RID: 222139
			public const int BarItem = 0;

			// Token: 0x040363BC RID: 222140
			public const int BarSprite = 1;

			// Token: 0x040363BD RID: 222141
			public const int RewardGridItem = 2;

			// Token: 0x040363BE RID: 222142
			public const int NeedCountText = 3;
		}
	}
}

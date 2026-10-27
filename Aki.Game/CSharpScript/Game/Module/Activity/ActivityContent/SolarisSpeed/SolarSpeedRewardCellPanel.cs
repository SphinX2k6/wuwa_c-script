using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060D0 RID: 24784
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class SolarSpeedRewardCellPanel : GridProxyAbstract<ISolarSpeedRewardCellPanelData>
	{
		// Token: 0x0603EA8D RID: 256653 RVA: 0x00F22140 File Offset: 0x00F20340
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603EA8E RID: 256654 RVA: 0x00F22250 File Offset: 0x00F20450
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSpeedRewardCellPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSpeedRewardCellPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EA8F RID: 256655 RVA: 0x00F22294 File Offset: 0x00F20494
		public override void Refresh(ISolarSpeedRewardCellPanelData data, bool isSelected, int gridIndex)
		{
			this.OpenParam = data;
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), data.TitleTextId, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), data.ProgressTextId, data.ProgressTextArgs);
			ButtonItem buttonItem = this.ButtonItem;
			if (buttonItem != null)
			{
				buttonItem.SetUiActive(data.ButtonActive);
			}
			if (data.ButtonActive)
			{
				ButtonItem buttonItem2 = this.ButtonItem;
				if (buttonItem2 != null)
				{
					buttonItem2.SetFunction(new Action<int>(this.HandleOnClickReward));
				}
				ButtonItem buttonItem3 = this.ButtonItem;
				if (buttonItem3 != null)
				{
					buttonItem3.SetLocalTextNew(data.ButtonTextId, Array.Empty<object>());
				}
			}
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(data.RightActive);
			}
			UUISprite sprite = base.GetSprite(6);
			if (sprite != null)
			{
				sprite.SetUIActive(data.DoneSpriteActive);
			}
			GenericLayout<CommonItemSmallItemGrid, TItem> rewardItems = this.RewardItems;
			if (rewardItems == null)
			{
				return;
			}
			rewardItems.RefreshByData(data.ItemsData.ToList<TItem>(), null, false);
		}

		// Token: 0x0603EA90 RID: 256656 RVA: 0x00F22386 File Offset: 0x00F20586
		private CommonItemSmallItemGrid BuildRewardSmallItemGrid()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603EA91 RID: 256657 RVA: 0x00F22390 File Offset: 0x00F20590
		private void HandleOnClickReward(int _)
		{
			ISolarSpeedRewardCellPanelData solarSpeedRewardCellPanelData = this.OpenParam as ISolarSpeedRewardCellPanelData;
			ActivitySolarSpeedController.Instance.RequestTeamParkourRewardRequest(solarSpeedRewardCellPanelData.RewardId);
		}

		// Token: 0x04020C18 RID: 134168
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardItems;

		// Token: 0x04020C19 RID: 134169
		private ButtonItem ButtonItem;

		// Token: 0x0200C324 RID: 49956
		[NullableContext(0)]
		private class ERewardCellComponent
		{
			// Token: 0x0403AEBE RID: 241342
			public const int NameText = 0;

			// Token: 0x0403AEBF RID: 241343
			public const int NumberText = 1;

			// Token: 0x0403AEC0 RID: 241344
			public const int ContentLayout = 2;

			// Token: 0x0403AEC1 RID: 241345
			public const int ContentCellItem = 3;

			// Token: 0x0403AEC2 RID: 241346
			public const int ConfirmButtonItem = 4;

			// Token: 0x0403AEC3 RID: 241347
			public const int RightText = 5;

			// Token: 0x0403AEC4 RID: 241348
			public const int DoneSprite = 6;
		}
	}
}

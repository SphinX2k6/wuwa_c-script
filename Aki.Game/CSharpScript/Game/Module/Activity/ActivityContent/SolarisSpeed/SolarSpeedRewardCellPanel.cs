using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x0200504E RID: 20558
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class SolarSpeedRewardCellPanel : GridProxyAbstract<ISolarSpeedRewardCellPanelData>
	{
		// Token: 0x06033751 RID: 210769 RVA: 0x00E68F10 File Offset: 0x00E67110
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

		// Token: 0x06033752 RID: 210770 RVA: 0x00E69020 File Offset: 0x00E67220
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSpeedRewardCellPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSpeedRewardCellPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033753 RID: 210771 RVA: 0x00E69064 File Offset: 0x00E67264
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
			rewardItems.RefreshByData(data.ItemsData, null, false);
		}

		// Token: 0x06033754 RID: 210772 RVA: 0x00E69151 File Offset: 0x00E67351
		private CommonItemSmallItemGrid BuildRewardSmallItemGrid()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06033755 RID: 210773 RVA: 0x00E69158 File Offset: 0x00E67358
		private void HandleOnClickReward(int _)
		{
			ISolarSpeedRewardCellPanelData solarSpeedRewardCellPanelData = this.OpenParam as ISolarSpeedRewardCellPanelData;
			ActivitySolarSpeedController.Instance.RequestTeamParkourRewardRequest(solarSpeedRewardCellPanelData.RewardId);
		}

		// Token: 0x0401B545 RID: 111941
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardItems;

		// Token: 0x0401B546 RID: 111942
		private ButtonItem ButtonItem;

		// Token: 0x0200AD0F RID: 44303
		[NullableContext(0)]
		private class ERewardCellComponent
		{
			// Token: 0x04035826 RID: 219174
			public const int NameText = 0;

			// Token: 0x04035827 RID: 219175
			public const int NumberText = 1;

			// Token: 0x04035828 RID: 219176
			public const int ContentLayout = 2;

			// Token: 0x04035829 RID: 219177
			public const int ContentCellItem = 3;

			// Token: 0x0403582A RID: 219178
			public const int ConfirmButtonItem = 4;

			// Token: 0x0403582B RID: 219179
			public const int RightText = 5;

			// Token: 0x0403582C RID: 219180
			public const int DoneSprite = 6;
		}
	}
}

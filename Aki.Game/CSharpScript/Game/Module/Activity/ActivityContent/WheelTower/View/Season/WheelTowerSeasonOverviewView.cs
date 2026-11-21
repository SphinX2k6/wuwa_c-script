using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season
{
	// Token: 0x02004F53 RID: 20307
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSeasonOverviewView : UiViewBase
	{
		// Token: 0x06032FEC RID: 208876 RVA: 0x00E4AC1C File Offset: 0x00E48E1C
		public WheelTowerSeasonOverviewView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032FED RID: 208877 RVA: 0x00E4AC28 File Offset: 0x00E48E28
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032FEE RID: 208878 RVA: 0x00E4ACB4 File Offset: 0x00E48EB4
		protected override UniTask OnBeforeStartAsync()
		{
			WheelTowerSeasonOverviewView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerSeasonOverviewView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032FEF RID: 208879 RVA: 0x00E4ACF8 File Offset: 0x00E48EF8
		private UniTask RefreshSeasonScrollAsync()
		{
			WheelTowerSeasonOverviewView.<RefreshSeasonScrollAsync>d__6 <RefreshSeasonScrollAsync>d__;
			<RefreshSeasonScrollAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSeasonScrollAsync>d__.<>4__this = this;
			<RefreshSeasonScrollAsync>d__.<>1__state = -1;
			<RefreshSeasonScrollAsync>d__.<>t__builder.Start<WheelTowerSeasonOverviewView.<RefreshSeasonScrollAsync>d__6>(ref <RefreshSeasonScrollAsync>d__);
			return <RefreshSeasonScrollAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032FF0 RID: 208880 RVA: 0x00E4AD3C File Offset: 0x00E48F3C
		private void SetSelectedSeasonId(int seasonId)
		{
			if (this.CurrentSelectedSeasonId != 0 && this.CurrentSelectedSeasonId != seasonId)
			{
				GenericScrollViewNew<WheelTowerSeasonOverviewItem, int> seasonScroll = this.SeasonScroll;
				if (seasonScroll != null)
				{
					WheelTowerSeasonOverviewItem scrollItemByKey = seasonScroll.GetScrollItemByKey(this.CurrentSelectedSeasonId);
					if (scrollItemByKey != null)
					{
						scrollItemByKey.SetSelected(false);
					}
				}
			}
			GenericScrollViewNew<WheelTowerSeasonOverviewItem, int> seasonScroll2 = this.SeasonScroll;
			if (seasonScroll2 != null)
			{
				WheelTowerSeasonOverviewItem scrollItemByKey2 = seasonScroll2.GetScrollItemByKey(seasonId);
				if (scrollItemByKey2 != null)
				{
					scrollItemByKey2.SetSelected(true);
				}
			}
			this.CurrentSelectedSeasonId = seasonId;
		}

		// Token: 0x06032FF1 RID: 208881 RVA: 0x00E4ADAC File Offset: 0x00E48FAC
		private WheelTowerSeasonOverviewItem CreateItem()
		{
			WheelTowerSeasonOverviewItem wheelTowerSeasonOverviewItem = new WheelTowerSeasonOverviewItem();
			wheelTowerSeasonOverviewItem.SetClickCallback(new Action<int>(this.OnSeasonItemClick));
			return wheelTowerSeasonOverviewItem;
		}

		// Token: 0x06032FF2 RID: 208882 RVA: 0x00E4ADC8 File Offset: 0x00E48FC8
		private void OnSeasonItemClick(int seasonId)
		{
			WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
			int num = (activityData != null) ? activityData.SeasonId : 0;
			if (seasonId != num)
			{
				GenericScrollViewNew<WheelTowerSeasonOverviewItem, int> seasonScroll = this.SeasonScroll;
				if (seasonScroll != null)
				{
					WheelTowerSeasonOverviewItem scrollItemByKey = seasonScroll.GetScrollItemByKey(seasonId);
					if (scrollItemByKey != null)
					{
						scrollItemByKey.SetSelected(false);
					}
				}
			}
			GenericScrollViewNew<WheelTowerSeasonOverviewItem, int> seasonScroll2 = this.SeasonScroll;
			if (seasonScroll2 != null)
			{
				WheelTowerSeasonOverviewItem scrollItemByKey2 = seasonScroll2.GetScrollItemByKey(num);
				if (scrollItemByKey2 != null)
				{
					scrollItemByKey2.SetSelected(true);
				}
			}
			WheelTowerController.Instance.OpenSeasonMedalView(seasonId, false);
		}

		// Token: 0x06032FF3 RID: 208883 RVA: 0x00E4AE42 File Offset: 0x00E49042
		private void ClickCloseCallback()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401B0F1 RID: 110833
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<WheelTowerSeasonOverviewItem, int> SeasonScroll;

		// Token: 0x0401B0F2 RID: 110834
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B0F3 RID: 110835
		private int CurrentSelectedSeasonId;
	}
}

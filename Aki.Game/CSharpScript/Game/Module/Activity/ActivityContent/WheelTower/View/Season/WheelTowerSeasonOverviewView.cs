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
	// Token: 0x02005F6C RID: 24428
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSeasonOverviewView : UiViewBase
	{
		// Token: 0x0603E052 RID: 254034 RVA: 0x00EF8F34 File Offset: 0x00EF7134
		public WheelTowerSeasonOverviewView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E053 RID: 254035 RVA: 0x00EF8F40 File Offset: 0x00EF7140
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

		// Token: 0x0603E054 RID: 254036 RVA: 0x00EF8FCC File Offset: 0x00EF71CC
		protected override UniTask OnBeforeStartAsync()
		{
			WheelTowerSeasonOverviewView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerSeasonOverviewView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E055 RID: 254037 RVA: 0x00EF9010 File Offset: 0x00EF7210
		private UniTask RefreshSeasonScrollAsync()
		{
			WheelTowerSeasonOverviewView.<RefreshSeasonScrollAsync>d__6 <RefreshSeasonScrollAsync>d__;
			<RefreshSeasonScrollAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSeasonScrollAsync>d__.<>4__this = this;
			<RefreshSeasonScrollAsync>d__.<>1__state = -1;
			<RefreshSeasonScrollAsync>d__.<>t__builder.Start<WheelTowerSeasonOverviewView.<RefreshSeasonScrollAsync>d__6>(ref <RefreshSeasonScrollAsync>d__);
			return <RefreshSeasonScrollAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E056 RID: 254038 RVA: 0x00EF9054 File Offset: 0x00EF7254
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

		// Token: 0x0603E057 RID: 254039 RVA: 0x00EF90C4 File Offset: 0x00EF72C4
		private WheelTowerSeasonOverviewItem CreateItem()
		{
			WheelTowerSeasonOverviewItem wheelTowerSeasonOverviewItem = new WheelTowerSeasonOverviewItem();
			wheelTowerSeasonOverviewItem.SetClickCallback(new Action<int>(this.OnSeasonItemClick));
			return wheelTowerSeasonOverviewItem;
		}

		// Token: 0x0603E058 RID: 254040 RVA: 0x00EF90E0 File Offset: 0x00EF72E0
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

		// Token: 0x0603E059 RID: 254041 RVA: 0x00EF915A File Offset: 0x00EF735A
		private void ClickCloseCallback()
		{
			base.CloseMe(null);
		}

		// Token: 0x0402061F RID: 132639
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<WheelTowerSeasonOverviewItem, int> SeasonScroll;

		// Token: 0x04020620 RID: 132640
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020621 RID: 132641
		private int CurrentSelectedSeasonId;
	}
}

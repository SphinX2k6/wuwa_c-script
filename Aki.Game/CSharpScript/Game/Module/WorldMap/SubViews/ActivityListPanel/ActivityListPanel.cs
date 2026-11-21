using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.ActivityListPanel
{
	// Token: 0x0200377A RID: 14202
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityListPanel : WorldMapSecondaryUi
	{
		// Token: 0x06024E7C RID: 151164 RVA: 0x00A6D411 File Offset: 0x00A6B611
		public override string GetResourceId()
		{
			return "UiView_CyclesActivitiesAssistant";
		}

		// Token: 0x06024E7D RID: 151165 RVA: 0x00A6D418 File Offset: 0x00A6B618
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

		// Token: 0x06024E7E RID: 151166 RVA: 0x00A6D4A4 File Offset: 0x00A6B6A4
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityListPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityListPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024E7F RID: 151167 RVA: 0x00A6D4E7 File Offset: 0x00A6B6E7
		protected override void OnStart()
		{
			this.PopupCaption.SetCloseCallBack(new Action(base.Close));
			this.PopupCaption.SetHelpBtnActive(false);
		}

		// Token: 0x06024E80 RID: 151168 RVA: 0x00A6D50C File Offset: 0x00A6B70C
		protected override void OnShowWorldMapSecondaryUi(params object[] parameters)
		{
			if (this.TimerId == null)
			{
				this.TimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.UpdateTimeInterval), 1000f, 1f, null, null, true);
			}
			this.RefreshActivityList();
		}

		// Token: 0x06024E81 RID: 151169 RVA: 0x00A6D545 File Offset: 0x00A6B745
		protected override void OnBeforeHide()
		{
			if (this.TimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
				this.TimerId = null;
			}
		}

		// Token: 0x06024E82 RID: 151170 RVA: 0x00A6D568 File Offset: 0x00A6B768
		private List<ActivityListPanelItemData> GetActivityDataList()
		{
			List<ActivityListPanelItemData> list = new List<ActivityListPanelItemData>();
			foreach (IActivityListItemData data in WorldMapModel.Instance.ActivityListData)
			{
				list.Add(new ActivityListPanelItemData
				{
					Data = data,
					OnClickCb = new Action(this.RefreshActivityList)
				});
			}
			return list;
		}

		// Token: 0x06024E83 RID: 151171 RVA: 0x00A6D5E4 File Offset: 0x00A6B7E4
		private void RefreshActivityList()
		{
			WorldMapModel.Instance.UpdateActivityListItemData(false);
			if (this.ScrollView != null)
			{
				this.ScrollView.RefreshByDataAsync(this.GetActivityDataList(), false).Forget();
			}
		}

		// Token: 0x06024E84 RID: 151172 RVA: 0x00A6D610 File Offset: 0x00A6B810
		private void UpdateTimeInterval(float delta)
		{
			foreach (IActivityListItemData activityListItemData in WorldMapModel.Instance.ActivityListData)
			{
				Action<IActivityListItemData> onLeftTimeRefreshCb = activityListItemData.OnLeftTimeRefreshCb;
				if (onLeftTimeRefreshCb != null)
				{
					onLeftTimeRefreshCb(activityListItemData);
				}
			}
			bool flag = false;
			using (List<IActivityListItemData>.Enumerator enumerator = WorldMapModel.Instance.ActivityListData.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.LeftTime <= 0.0)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				WorldMapModel.Instance.UpdateActivityListItemData(true);
				if (this.ScrollView != null)
				{
					this.ScrollView.RefreshByDataAsync(this.GetActivityDataList(), false).Forget();
					return;
				}
			}
			else
			{
				GenericScrollViewNew<ActivityListItem, ActivityListPanelItemData> scrollView = this.ScrollView;
				if (scrollView == null)
				{
					return;
				}
				scrollView.GetScrollItemList().ForEach(delegate(ActivityListItem item)
				{
					item.RefreshInfo();
				});
			}
		}

		// Token: 0x04014715 RID: 83733
		private readonly PopupCaptionItem PopupCaption = new PopupCaptionItem(null);

		// Token: 0x04014716 RID: 83734
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivityListItem, ActivityListPanelItemData> ScrollView;

		// Token: 0x04014717 RID: 83735
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x020094D4 RID: 38100
		[NullableContext(0)]
		public static class EChildType
		{
			// Token: 0x0402E7A9 RID: 190377
			public const int Caption = 0;

			// Token: 0x0402E7AA RID: 190378
			public const int ActivityScroller = 1;

			// Token: 0x0402E7AB RID: 190379
			public const int ActivityItem = 2;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02004849 RID: 18505
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityListPanel : WorldMapSecondaryUi
	{
		// Token: 0x060306AC RID: 198316 RVA: 0x00B3D229 File Offset: 0x00B3B429
		public override string GetResourceId()
		{
			return "UiView_CyclesActivitiesAssistant";
		}

		// Token: 0x060306AD RID: 198317 RVA: 0x00B3D230 File Offset: 0x00B3B430
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

		// Token: 0x060306AE RID: 198318 RVA: 0x00B3D2BC File Offset: 0x00B3B4BC
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityListPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityListPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060306AF RID: 198319 RVA: 0x00B3D2FF File Offset: 0x00B3B4FF
		protected override void OnStart()
		{
			this.PopupCaption.SetCloseCallBack(new Action(base.Close));
			this.PopupCaption.SetHelpBtnActive(false);
		}

		// Token: 0x060306B0 RID: 198320 RVA: 0x00B3D324 File Offset: 0x00B3B524
		protected override void OnShowWorldMapSecondaryUi(params object[] parameters)
		{
			if (this.TimerId == null)
			{
				this.TimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.UpdateTimeInterval), 1000f, 1f, null, null, true);
			}
			this.RefreshActivityList();
		}

		// Token: 0x060306B1 RID: 198321 RVA: 0x00B3D35D File Offset: 0x00B3B55D
		protected override void OnBeforeHide()
		{
			if (this.TimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
				this.TimerId = null;
			}
		}

		// Token: 0x060306B2 RID: 198322 RVA: 0x00B3D37F File Offset: 0x00B3B57F
		private List<ActivityListPanelItemData> GetActivityDataList()
		{
			return (from data in WorldMapModel.Instance.ActivityListData
			select new ActivityListPanelItemData
			{
				Data = data,
				OnClickCb = new Action(this.RefreshActivityList)
			}).ToList<ActivityListPanelItemData>();
		}

		// Token: 0x060306B3 RID: 198323 RVA: 0x00B3D3A1 File Offset: 0x00B3B5A1
		private void RefreshActivityList()
		{
			WorldMapModel.Instance.UpdateActivityListItemData(false);
			if (this.ScrollView != null)
			{
				this.ScrollView.RefreshByDataAsync(this.GetActivityDataList(), false).Forget();
			}
		}

		// Token: 0x060306B4 RID: 198324 RVA: 0x00B3D3D0 File Offset: 0x00B3B5D0
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
			if (WorldMapModel.Instance.ActivityListData.Any((IActivityListItemData data) => data.LeftTime <= 0.0))
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

		// Token: 0x0401A061 RID: 106593
		private readonly PopupCaptionItem PopupCaption = new PopupCaptionItem(null);

		// Token: 0x0401A062 RID: 106594
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ActivityListItem, ActivityListPanelItemData> ScrollView;

		// Token: 0x0401A063 RID: 106595
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x0200AB26 RID: 43814
		[NullableContext(0)]
		public static class EChildType
		{
			// Token: 0x0403402E RID: 213038
			public const int Caption = 0;

			// Token: 0x0403402F RID: 213039
			public const int ActivityScroller = 1;

			// Token: 0x04034030 RID: 213040
			public const int ActivityItem = 2;
		}
	}
}

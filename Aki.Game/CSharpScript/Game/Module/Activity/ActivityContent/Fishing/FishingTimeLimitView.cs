using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005508 RID: 21768
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTimeLimitView : UiTickViewBase
	{
		// Token: 0x06035F1E RID: 220958 RVA: 0x00F10D5A File Offset: 0x00F0EF5A
		public FishingTimeLimitView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035F1F RID: 220959 RVA: 0x00F10D8C File Offset: 0x00F0EF8C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035F20 RID: 220960 RVA: 0x00F10E58 File Offset: 0x00F0F058
		protected override UniTask OnBeforeStartAsync()
		{
			FishingTimeLimitView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingTimeLimitView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035F21 RID: 220961 RVA: 0x00F10E9C File Offset: 0x00F0F09C
		private UniTask InitCaption()
		{
			FishingTimeLimitView.<InitCaption>d__12 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<FishingTimeLimitView.<InitCaption>d__12>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06035F22 RID: 220962 RVA: 0x00F10EE0 File Offset: 0x00F0F0E0
		private UniTask InitTabComponent()
		{
			FishingTimeLimitView.<InitTabComponent>d__13 <InitTabComponent>d__;
			<InitTabComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabComponent>d__.<>4__this = this;
			<InitTabComponent>d__.<>1__state = -1;
			<InitTabComponent>d__.<>t__builder.Start<FishingTimeLimitView.<InitTabComponent>d__13>(ref <InitTabComponent>d__);
			return <InitTabComponent>d__.<>t__builder.Task;
		}

		// Token: 0x06035F23 RID: 220963 RVA: 0x00F10F23 File Offset: 0x00F0F123
		private void InitTabViewComponent()
		{
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
		}

		// Token: 0x06035F24 RID: 220964 RVA: 0x00F10F38 File Offset: 0x00F0F138
		protected override void OnStart()
		{
			this.RemainTimeText = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			this.RefreshTime();
		}

		// Token: 0x06035F25 RID: 220965 RVA: 0x00F10F51 File Offset: 0x00F0F151
		protected override void OnBeforeShow()
		{
			this.RefreshTabItem();
		}

		// Token: 0x06035F26 RID: 220966 RVA: 0x00F10F5C File Offset: 0x00F0F15C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FishingTimeLimitRewardListRefresh, new Action(this.RefreshTabItem));
			EventSystem.Instance.Add(EEventName.FishingTimeLimitRewardProgressRefresh, new Action(this.RefreshTabItem));
			EventSystem.Instance.Add(EEventName.FishingTimeLimitShopRefresh, new Action(this.RefreshTabItem));
		}

		// Token: 0x06035F27 RID: 220967 RVA: 0x00F10FC0 File Offset: 0x00F0F1C0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FishingTimeLimitRewardListRefresh, new Action(this.RefreshTabItem));
			EventSystem.Instance.Remove(EEventName.FishingTimeLimitRewardProgressRefresh, new Action(this.RefreshTabItem));
			EventSystem.Instance.Remove(EEventName.FishingTimeLimitShopRefresh, new Action(this.RefreshTabItem));
		}

		// Token: 0x06035F28 RID: 220968 RVA: 0x00F11021 File Offset: 0x00F0F221
		private void InitTabList()
		{
			this.TabDataList = this.ActivityDataBase.GetRewardTabList();
			this.SetTabState(0, true, true);
		}

		// Token: 0x06035F29 RID: 220969 RVA: 0x00F11040 File Offset: 0x00F0F240
		private void RefreshTabItem()
		{
			bool timeLimitRewardRedDotState = this.ActivityDataBase.GetTimeLimitRewardRedDotState();
			bool limitTimeShopRedDotState = this.ActivityDataBase.GetLimitTimeShopRedDotState();
			this.TabItemList[0].SetRedDotVisible(timeLimitRewardRedDotState);
			this.TabItemList[1].SetRedDotVisible(limitTimeShopRedDotState);
		}

		// Token: 0x06035F2A RID: 220970 RVA: 0x00F11081 File Offset: 0x00F0F281
		private void SetTabState(int index, bool state, bool bFireEvent)
		{
			this.TabItemList[index].SetToggleState(state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent);
		}

		// Token: 0x06035F2B RID: 220971 RVA: 0x00F11098 File Offset: 0x00F0F298
		private void ToggleCallBack(int index)
		{
			if (index != this.CurrentTabIndex)
			{
				this.SetTabState(this.CurrentTabIndex, false, true);
			}
			this.CurrentTabIndex = index;
			UiDynamicTab data = this.TabDataList[index];
			this.SwitchTabView(data, index);
		}

		// Token: 0x06035F2C RID: 220972 RVA: 0x00F110D8 File Offset: 0x00F0F2D8
		private void SwitchTabView(UiDynamicTab data, int index)
		{
			EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
			this.TabViewComponent.ToggleCallBack(data, viewName, this.TabItemList[index], this.ActivityDataBase, null);
			string icon = data.Icon;
			if (icon != null)
			{
				this.CaptionItem.SetTitleIcon(icon);
			}
			string tabName = data.TabName;
			if (tabName != null)
			{
				this.CaptionItem.SetTitleByTextIdAndArgNew(tabName, Array.Empty<object>());
			}
		}

		// Token: 0x06035F2D RID: 220973 RVA: 0x00F11149 File Offset: 0x00F0F349
		protected override void OnTick(float delta)
		{
			if (this.LimitTimeRewardOn)
			{
				this.RefreshTime();
			}
		}

		// Token: 0x06035F2E RID: 220974 RVA: 0x00F1115C File Offset: 0x00F0F35C
		private void RefreshTime()
		{
			long limitTimeEndTime = this.ActivityDataBase.GetLimitTimeEndTime();
			double serverTime = TimeUtil.Instance.GetServerTime();
			if ((double)limitTimeEndTime - serverTime < 0.0)
			{
				this.LimitTimeRewardOn = false;
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
				return;
			}
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(limitTimeEndTime, this.RemainTimeText);
			base.GetText(4).SetText(remainTimeText, true);
		}

		// Token: 0x0401C82A RID: 116778
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401C82B RID: 116779
		protected FishingRewardMainTabItem[] TabItemList = Array.Empty<FishingRewardMainTabItem>();

		// Token: 0x0401C82C RID: 116780
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401C82D RID: 116781
		protected ActivityFishingData ActivityDataBase;

		// Token: 0x0401C82E RID: 116782
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401C82F RID: 116783
		private bool LimitTimeRewardOn = true;

		// Token: 0x0401C830 RID: 116784
		private string RemainTimeText = "";

		// Token: 0x0401C831 RID: 116785
		private int CurrentTabIndex;

		// Token: 0x0200B16A RID: 45418
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04036DC2 RID: 224706
			public const int CaptionItem = 0;

			// Token: 0x04036DC3 RID: 224707
			public const int ContentItem = 1;

			// Token: 0x04036DC4 RID: 224708
			public const int ToggleReward = 2;

			// Token: 0x04036DC5 RID: 224709
			public const int ToggleShop = 3;

			// Token: 0x04036DC6 RID: 224710
			public const int TxtTime = 4;
		}
	}
}

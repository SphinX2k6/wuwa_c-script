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
	// Token: 0x0200658A RID: 25994
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTimeLimitView : UiTickViewBase
	{
		// Token: 0x06041259 RID: 266841 RVA: 0x00FC9DAA File Offset: 0x00FC7FAA
		public FishingTimeLimitView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0604125A RID: 266842 RVA: 0x00FC9DDC File Offset: 0x00FC7FDC
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

		// Token: 0x0604125B RID: 266843 RVA: 0x00FC9EA8 File Offset: 0x00FC80A8
		protected override UniTask OnBeforeStartAsync()
		{
			FishingTimeLimitView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingTimeLimitView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604125C RID: 266844 RVA: 0x00FC9EEC File Offset: 0x00FC80EC
		private UniTask InitCaption()
		{
			FishingTimeLimitView.<InitCaption>d__12 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<FishingTimeLimitView.<InitCaption>d__12>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0604125D RID: 266845 RVA: 0x00FC9F30 File Offset: 0x00FC8130
		private UniTask InitTabComponent()
		{
			FishingTimeLimitView.<InitTabComponent>d__13 <InitTabComponent>d__;
			<InitTabComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabComponent>d__.<>4__this = this;
			<InitTabComponent>d__.<>1__state = -1;
			<InitTabComponent>d__.<>t__builder.Start<FishingTimeLimitView.<InitTabComponent>d__13>(ref <InitTabComponent>d__);
			return <InitTabComponent>d__.<>t__builder.Task;
		}

		// Token: 0x0604125E RID: 266846 RVA: 0x00FC9F73 File Offset: 0x00FC8173
		private void InitTabViewComponent()
		{
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
		}

		// Token: 0x0604125F RID: 266847 RVA: 0x00FC9F88 File Offset: 0x00FC8188
		protected override void OnStart()
		{
			this.RemainTimeText = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			this.RefreshTime();
		}

		// Token: 0x06041260 RID: 266848 RVA: 0x00FC9FA1 File Offset: 0x00FC81A1
		protected override void OnBeforeShow()
		{
			this.RefreshTabItem();
		}

		// Token: 0x06041261 RID: 266849 RVA: 0x00FC9FAC File Offset: 0x00FC81AC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FishingTimeLimitRewardListRefresh, new Action(this.RefreshTabItem));
			EventSystem.Instance.Add(EEventName.FishingTimeLimitRewardProgressRefresh, new Action(this.RefreshTabItem));
			EventSystem.Instance.Add(EEventName.FishingTimeLimitShopRefresh, new Action(this.RefreshTabItem));
		}

		// Token: 0x06041262 RID: 266850 RVA: 0x00FCA010 File Offset: 0x00FC8210
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FishingTimeLimitRewardListRefresh, new Action(this.RefreshTabItem));
			EventSystem.Instance.Remove(EEventName.FishingTimeLimitRewardProgressRefresh, new Action(this.RefreshTabItem));
			EventSystem.Instance.Remove(EEventName.FishingTimeLimitShopRefresh, new Action(this.RefreshTabItem));
		}

		// Token: 0x06041263 RID: 266851 RVA: 0x00FCA071 File Offset: 0x00FC8271
		private void InitTabList()
		{
			this.TabDataList = this.ActivityDataBase.GetRewardTabList();
			this.SetTabState(0, true, true);
		}

		// Token: 0x06041264 RID: 266852 RVA: 0x00FCA090 File Offset: 0x00FC8290
		private void RefreshTabItem()
		{
			bool timeLimitRewardRedDotState = this.ActivityDataBase.GetTimeLimitRewardRedDotState();
			bool limitTimeShopRedDotState = this.ActivityDataBase.GetLimitTimeShopRedDotState();
			this.TabItemList[0].SetRedDotVisible(timeLimitRewardRedDotState);
			this.TabItemList[1].SetRedDotVisible(limitTimeShopRedDotState);
		}

		// Token: 0x06041265 RID: 266853 RVA: 0x00FCA0D1 File Offset: 0x00FC82D1
		private void SetTabState(int index, bool state, bool bFireEvent)
		{
			this.TabItemList[index].SetToggleState(state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent);
		}

		// Token: 0x06041266 RID: 266854 RVA: 0x00FCA0E8 File Offset: 0x00FC82E8
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

		// Token: 0x06041267 RID: 266855 RVA: 0x00FCA128 File Offset: 0x00FC8328
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

		// Token: 0x06041268 RID: 266856 RVA: 0x00FCA199 File Offset: 0x00FC8399
		protected override void OnTick(float delta)
		{
			if (this.LimitTimeRewardOn)
			{
				this.RefreshTime();
			}
		}

		// Token: 0x06041269 RID: 266857 RVA: 0x00FCA1AC File Offset: 0x00FC83AC
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

		// Token: 0x04021EF9 RID: 139001
		protected PopupCaptionItem CaptionItem;

		// Token: 0x04021EFA RID: 139002
		protected FishingRewardMainTabItem[] TabItemList = Array.Empty<FishingRewardMainTabItem>();

		// Token: 0x04021EFB RID: 139003
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x04021EFC RID: 139004
		protected ActivityFishingData ActivityDataBase;

		// Token: 0x04021EFD RID: 139005
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x04021EFE RID: 139006
		private bool LimitTimeRewardOn = true;

		// Token: 0x04021EFF RID: 139007
		private string RemainTimeText = "";

		// Token: 0x04021F00 RID: 139008
		private int CurrentTabIndex;

		// Token: 0x0200C785 RID: 51077
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403C471 RID: 246897
			public const int CaptionItem = 0;

			// Token: 0x0403C472 RID: 246898
			public const int ContentItem = 1;

			// Token: 0x0403C473 RID: 246899
			public const int ToggleReward = 2;

			// Token: 0x0403C474 RID: 246900
			public const int ToggleShop = 3;

			// Token: 0x0403C475 RID: 246901
			public const int TxtTime = 4;
		}
	}
}

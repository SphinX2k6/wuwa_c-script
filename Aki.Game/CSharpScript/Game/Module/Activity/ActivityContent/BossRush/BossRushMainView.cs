using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x02005858 RID: 22616
	[NullableContext(1)]
	[Nullable(0)]
	public class BossRushMainView : UiViewBase
	{
		// Token: 0x06037C1A RID: 228378 RVA: 0x00F974F2 File Offset: 0x00F956F2
		public BossRushMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037C1B RID: 228379 RVA: 0x00F97508 File Offset: 0x00F95708
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06037C1C RID: 228380 RVA: 0x00F97574 File Offset: 0x00F95774
		protected override UniTask OnBeforeStartAsync()
		{
			BossRushMainView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossRushMainView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037C1D RID: 228381 RVA: 0x00F975B7 File Offset: 0x00F957B7
		protected override void OnBeforeDestroy()
		{
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent != null)
			{
				tabViewComponent.DestroyTabViewComponent();
			}
			this.TabViewComponent = null;
			BossRushModel.Instance.OnlyOpenRewardView = false;
			BossRushModel.Instance.PlayBackAnimation = false;
		}

		// Token: 0x06037C1E RID: 228382 RVA: 0x00F975E7 File Offset: 0x00F957E7
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EUiTabViewName>(EEventName.RequestChangeBossRushView, new Action<EUiTabViewName>(this.OnRequestChangeBossRushView));
		}

		// Token: 0x06037C1F RID: 228383 RVA: 0x00F97605 File Offset: 0x00F95805
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<EUiTabViewName>(EEventName.RequestChangeBossRushView, new Action<EUiTabViewName>(this.OnRequestChangeBossRushView));
		}

		// Token: 0x06037C20 RID: 228384 RVA: 0x00F97623 File Offset: 0x00F95823
		private void OnRequestChangeBossRushView(EUiTabViewName viewName)
		{
			TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
			if (tabComponent != null)
			{
				tabComponent.SelectToggleByIndex(this.GetViewIndex(viewName), false);
			}
			EventSystem.Instance.Emit<EUiTabViewName>(EEventName.BossRushSubViewChanged, viewName);
		}

		// Token: 0x06037C21 RID: 228385 RVA: 0x00F9764F File Offset: 0x00F9584F
		protected override void OnStart()
		{
			TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
			if (tabComponent == null)
			{
				return;
			}
			tabComponent.SelectToggleByIndex(this.GetViewIndex(BossRushModel.Instance.OnlyOpenRewardView ? EUiTabViewName.BossRushRewardView : EUiTabViewName.BossRushSelectView), true);
		}

		// Token: 0x06037C22 RID: 228386 RVA: 0x00F97680 File Offset: 0x00F95880
		private UniTask InitTab()
		{
			BossRushMainView.<InitTab>d__13 <InitTab>d__;
			<InitTab>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTab>d__.<>4__this = this;
			<InitTab>d__.<>1__state = -1;
			<InitTab>d__.<>t__builder.Start<BossRushMainView.<InitTab>d__13>(ref <InitTab>d__);
			return <InitTab>d__.<>t__builder.Task;
		}

		// Token: 0x06037C23 RID: 228387 RVA: 0x00F976C3 File Offset: 0x00F958C3
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x06037C24 RID: 228388 RVA: 0x00F976CC File Offset: 0x00F958CC
		private void ToggleCallBack(int index)
		{
			this.CurrentSelectIndex = index;
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			this.TabViewComponent.ToggleCallBack(data, viewName, tabItemByIndex, null, null);
		}

		// Token: 0x06037C25 RID: 228389 RVA: 0x00F9771F File Offset: 0x00F9591F
		private CommonTabData GetCommonData(int index)
		{
			return new CommonTabData("", null, null);
		}

		// Token: 0x06037C26 RID: 228390 RVA: 0x00F97730 File Offset: 0x00F95930
		private int GetViewIndex(EUiTabViewName tabName)
		{
			for (int i = 0; i < this.TabDataList.Count; i++)
			{
				if (this.TabDataList[i].ChildViewName == tabName)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x06037C27 RID: 228391 RVA: 0x00F97778 File Offset: 0x00F95978
		private void BackClick()
		{
			if (this.CurrentSelectIndex != 0)
			{
				if (this.CurrentSelectIndex != this.GetViewIndex(EUiTabViewName.BossRushRewardView))
				{
					EUiTabViewName viewName = (EUiTabViewName)this.TabDataList[this.CurrentSelectIndex - 1].ChildViewName;
					BossRushModel.Instance.PlayBackAnimation = true;
					this.OnRequestChangeBossRushView(viewName);
					return;
				}
				BossRushModel.Instance.PlayBackAnimation = true;
				if (BossRushModel.Instance.OnlyOpenRewardView)
				{
					BossRushModel.Instance.OnlyOpenRewardView = false;
					base.CloseMe(null);
					return;
				}
				this.OnRequestChangeBossRushView(EUiTabViewName.BossRushSelectView);
				return;
			}
			else
			{
				if (GameModeController.Instance.IsInInstance())
				{
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
					return;
				}
				base.CloseMe(null);
				return;
			}
		}

		// Token: 0x0401D6D6 RID: 120534
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401D6D7 RID: 120535
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401D6D8 RID: 120536
		protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401D6D9 RID: 120537
		private int CurrentSelectIndex;

		// Token: 0x0200B47E RID: 46206
		[NullableContext(0)]
		public class EComponent
		{
			// Token: 0x04037D19 RID: 228633
			public const int CaptionItem = 0;

			// Token: 0x04037D1A RID: 228634
			public const int ContentItem = 1;
		}
	}
}

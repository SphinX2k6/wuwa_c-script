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
	// Token: 0x02006908 RID: 26888
	[NullableContext(1)]
	[Nullable(0)]
	public class BossRushMainView : UiViewBase
	{
		// Token: 0x060430C2 RID: 274626 RVA: 0x01055EBE File Offset: 0x010540BE
		public BossRushMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060430C3 RID: 274627 RVA: 0x01055ED4 File Offset: 0x010540D4
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

		// Token: 0x060430C4 RID: 274628 RVA: 0x01055F40 File Offset: 0x01054140
		protected override UniTask OnBeforeStartAsync()
		{
			BossRushMainView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossRushMainView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060430C5 RID: 274629 RVA: 0x01055F83 File Offset: 0x01054183
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

		// Token: 0x060430C6 RID: 274630 RVA: 0x01055FB3 File Offset: 0x010541B3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EUiTabViewName>(EEventName.RequestChangeBossRushView, new Action<EUiTabViewName>(this.OnRequestChangeBossRushView));
		}

		// Token: 0x060430C7 RID: 274631 RVA: 0x01055FD1 File Offset: 0x010541D1
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<EUiTabViewName>(EEventName.RequestChangeBossRushView, new Action<EUiTabViewName>(this.OnRequestChangeBossRushView));
		}

		// Token: 0x060430C8 RID: 274632 RVA: 0x01055FEF File Offset: 0x010541EF
		private void OnRequestChangeBossRushView(EUiTabViewName viewName)
		{
			TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
			if (tabComponent != null)
			{
				tabComponent.SelectToggleByIndex(this.GetViewIndex(viewName), false);
			}
			EventSystem.Instance.Emit<EUiTabViewName>(EEventName.BossRushSubViewChanged, viewName);
		}

		// Token: 0x060430C9 RID: 274633 RVA: 0x0105601B File Offset: 0x0105421B
		protected override void OnStart()
		{
			TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
			if (tabComponent == null)
			{
				return;
			}
			tabComponent.SelectToggleByIndex(this.GetViewIndex(BossRushModel.Instance.OnlyOpenRewardView ? EUiTabViewName.BossRushRewardView : EUiTabViewName.BossRushSelectView), true);
		}

		// Token: 0x060430CA RID: 274634 RVA: 0x0105604C File Offset: 0x0105424C
		private UniTask InitTab()
		{
			BossRushMainView.<InitTab>d__13 <InitTab>d__;
			<InitTab>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTab>d__.<>4__this = this;
			<InitTab>d__.<>1__state = -1;
			<InitTab>d__.<>t__builder.Start<BossRushMainView.<InitTab>d__13>(ref <InitTab>d__);
			return <InitTab>d__.<>t__builder.Task;
		}

		// Token: 0x060430CB RID: 274635 RVA: 0x0105608F File Offset: 0x0105428F
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x060430CC RID: 274636 RVA: 0x01056098 File Offset: 0x01054298
		private void ToggleCallBack(int index)
		{
			this.CurrentSelectIndex = index;
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			this.TabViewComponent.ToggleCallBack(data, viewName, tabItemByIndex, null, null);
		}

		// Token: 0x060430CD RID: 274637 RVA: 0x010560EB File Offset: 0x010542EB
		private CommonTabData GetCommonData(int index)
		{
			return new CommonTabData("", null, null);
		}

		// Token: 0x060430CE RID: 274638 RVA: 0x010560FC File Offset: 0x010542FC
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

		// Token: 0x060430CF RID: 274639 RVA: 0x01056144 File Offset: 0x01054344
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

		// Token: 0x04022E7A RID: 142970
		private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x04022E7B RID: 142971
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x04022E7C RID: 142972
		protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x04022E7D RID: 142973
		private int CurrentSelectIndex;

		// Token: 0x0200CAB6 RID: 51894
		[NullableContext(0)]
		public class EComponent
		{
			// Token: 0x0403D43F RID: 250943
			public const int CaptionItem = 0;

			// Token: 0x0403D440 RID: 250944
			public const int ContentItem = 1;
		}
	}
}

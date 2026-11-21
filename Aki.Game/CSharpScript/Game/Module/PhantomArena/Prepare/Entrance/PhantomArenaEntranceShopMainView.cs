using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004135 RID: 16693
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaEntranceShopMainView : UiTickViewBase
	{
		// Token: 0x0602A35F RID: 172895 RVA: 0x00BEAE16 File Offset: 0x00BE9016
		public PhantomArenaEntranceShopMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602A360 RID: 172896 RVA: 0x00BEAE38 File Offset: 0x00BE9038
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x0602A361 RID: 172897 RVA: 0x00BEAE94 File Offset: 0x00BE9094
		protected override void OnStart()
		{
			BattleShopViewOpenParam battleShopViewOpenParam = this.OpenParam as BattleShopViewOpenParam;
			this.CurSelectTabView = new EUiTabViewName?(battleShopViewOpenParam.TabViewName);
			this.ActivityId = battleShopViewOpenParam.ActivityId;
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			this.InitTabComponent();
			this.CurrencyId = PhantomArenaModel.Instance.GetCurrencyId(this.ActivityId);
			if (this.CurrencyId > 0)
			{
				TabComponentWithCaptionItem<PhantomArenaEntranceShopTabItem> tabComponent = this.TabComponent;
				if (tabComponent != null)
				{
					tabComponent.SetCurrencyItemList(new List<int>
					{
						this.CurrencyId
					});
				}
			}
			this.RemainTimeText = (TextConfig.Instance.GetMultiTextByKey("ActivityRemainingTime") ?? "");
			this.RefreshTime();
		}

		// Token: 0x0602A362 RID: 172898 RVA: 0x00BEAF4C File Offset: 0x00BE914C
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			PhantomArenaEntranceShopMainView.<OnBeforeShowAsyncImplementImplement>d__12 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<PhantomArenaEntranceShopMainView.<OnBeforeShowAsyncImplementImplement>d__12>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602A363 RID: 172899 RVA: 0x00BEAF8F File Offset: 0x00BE918F
		protected override void OnTick(float delta)
		{
			this.RefreshTime();
		}

		// Token: 0x0602A364 RID: 172900 RVA: 0x00BEAF97 File Offset: 0x00BE9197
		protected override void OnBeforeDestroy()
		{
			if (this.TabComponent != null)
			{
				this.TabComponent.Destroy(null);
				this.TabComponent = null;
			}
		}

		// Token: 0x0602A365 RID: 172901 RVA: 0x00BEAFB4 File Offset: 0x00BE91B4
		private void OnCloseClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602A366 RID: 172902 RVA: 0x00BEAFC0 File Offset: 0x00BE91C0
		protected void InitTabComponent()
		{
			CommonTabComponentData<PhantomArenaEntranceShopTabItem> data = new CommonTabComponentData<PhantomArenaEntranceShopTabItem>(new Func<UUIItem, int?, PhantomArenaEntranceShopTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
			this.TabComponent = new TabComponentWithCaptionItem<PhantomArenaEntranceShopTabItem>(base.GetItem(0), data, new Action(this.OnCloseClicked), false);
			this.TabComponent.SetHelpButtonShowState(true);
			this.TabComponent.SetHelpButtonCallBack(new Action(this.OnClickedHelp));
			this.LastClickTime = null;
			this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
		}

		// Token: 0x0602A367 RID: 172903 RVA: 0x00BEB070 File Offset: 0x00BE9270
		private UniTask RefreshTabListAsync()
		{
			PhantomArenaEntranceShopMainView.<RefreshTabListAsync>d__17 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<PhantomArenaEntranceShopMainView.<RefreshTabListAsync>d__17>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A368 RID: 172904 RVA: 0x00BEB0B4 File Offset: 0x00BE92B4
		private PhantomArenaEntranceShopTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new PhantomArenaEntranceShopTabData(uiDynamicTab.Icon, new CommonTabTitleData("PhantomBattle_1098", Array.Empty<object>()), uiDynamicTab.TabName, (EUiTabViewName)uiDynamicTab.ChildViewName);
		}

		// Token: 0x0602A369 RID: 172905 RVA: 0x00BEB0FC File Offset: 0x00BE92FC
		protected bool CanToggleChange(int index, bool? _)
		{
			if (Info.Instance.IsInGamepad())
			{
				return true;
			}
			int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
			if (this.LastClickTime != null)
			{
				double? num = Time.Instance.Now - this.LastClickTime;
				int? num2 = intConfig;
				double? num3 = (num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null;
				if (!(num.GetValueOrDefault() >= num3.GetValueOrDefault() & (num != null & num3 != null)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0602A36A RID: 172906 RVA: 0x00BEB1B7 File Offset: 0x00BE93B7
		private PhantomArenaEntranceShopTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new PhantomArenaEntranceShopTabItem();
		}

		// Token: 0x0602A36B RID: 172907 RVA: 0x00BEB1C0 File Offset: 0x00BE93C0
		private void ToggleCallBack(int index)
		{
			this.LastClickTime = new double?(Time.Instance.Now);
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
			PhantomArenaEntranceShopTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, this.ActivityId, null);
			this.CurSelectTabView = new EUiTabViewName?(euiTabViewName);
		}

		// Token: 0x0602A36C RID: 172908 RVA: 0x00BEB237 File Offset: 0x00BE9437
		private void OnClickedHelp()
		{
			HelpController.Instance.OpenHelpById(335);
		}

		// Token: 0x0602A36D RID: 172909 RVA: 0x00BEB248 File Offset: 0x00BE9448
		private ERedDotName? GetRedDotNameByTabId(EUiTabViewName tab)
		{
			if (tab == EUiTabViewName.PhantomArenaEntranceTaskTabView)
			{
				return new ERedDotName?(ERedDotName.RedDotPhantomArenaTaskReward);
			}
			if (tab == EUiTabViewName.PhantomArenaEntranceShopTabView)
			{
				return new ERedDotName?(ERedDotName.RedDotPhantomArenaShopUpdate);
			}
			return null;
		}

		// Token: 0x0602A36E RID: 172910 RVA: 0x00BEB290 File Offset: 0x00BE9490
		private void RefreshTime()
		{
			ValueTuple<bool, string> valueTuple = PhantomArenaModel.Instance.IsInLimitTime(this.ActivityId, this.RemainTimeText);
			bool item = valueTuple.Item1;
			string item2 = valueTuple.Item2;
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(item);
			}
			UUIText text2 = base.GetText(2);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(item2, true);
		}

		// Token: 0x04016F9F RID: 94111
		protected int ActivityId;

		// Token: 0x04016FA0 RID: 94112
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<PhantomArenaEntranceShopTabItem> TabComponent;

		// Token: 0x04016FA1 RID: 94113
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x04016FA2 RID: 94114
		private double? LastClickTime;

		// Token: 0x04016FA3 RID: 94115
		protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x04016FA4 RID: 94116
		private EUiTabViewName? CurSelectTabView;

		// Token: 0x04016FA5 RID: 94117
		private int CurrencyId;

		// Token: 0x04016FA6 RID: 94118
		private string RemainTimeText = "";

		// Token: 0x02009CFF RID: 40191
		[NullableContext(0)]
		private class EChildComponentType
		{
			// Token: 0x04030D01 RID: 199937
			public const int CaptionItem = 0;

			// Token: 0x04030D02 RID: 199938
			public const int InfoContent = 1;

			// Token: 0x04030D03 RID: 199939
			public const int TxtTime = 2;
		}
	}
}

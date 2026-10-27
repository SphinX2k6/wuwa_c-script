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
	// Token: 0x02005165 RID: 20837
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaEntranceShopMainView : UiTickViewBase
	{
		// Token: 0x06035463 RID: 218211 RVA: 0x00C9D8E6 File Offset: 0x00C9BAE6
		public PhantomArenaEntranceShopMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06035464 RID: 218212 RVA: 0x00C9D908 File Offset: 0x00C9BB08
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x06035465 RID: 218213 RVA: 0x00C9D964 File Offset: 0x00C9BB64
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

		// Token: 0x06035466 RID: 218214 RVA: 0x00C9DA1C File Offset: 0x00C9BC1C
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			PhantomArenaEntranceShopMainView.<OnBeforeShowAsyncImplementImplement>d__12 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<PhantomArenaEntranceShopMainView.<OnBeforeShowAsyncImplementImplement>d__12>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06035467 RID: 218215 RVA: 0x00C9DA5F File Offset: 0x00C9BC5F
		protected override void OnTick(float delta)
		{
			this.RefreshTime();
		}

		// Token: 0x06035468 RID: 218216 RVA: 0x00C9DA67 File Offset: 0x00C9BC67
		protected override void OnBeforeDestroy()
		{
			if (this.TabComponent != null)
			{
				this.TabComponent.Destroy(null);
				this.TabComponent = null;
			}
		}

		// Token: 0x06035469 RID: 218217 RVA: 0x00C9DA84 File Offset: 0x00C9BC84
		private void OnCloseClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603546A RID: 218218 RVA: 0x00C9DA90 File Offset: 0x00C9BC90
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

		// Token: 0x0603546B RID: 218219 RVA: 0x00C9DB40 File Offset: 0x00C9BD40
		private UniTask RefreshTabListAsync()
		{
			PhantomArenaEntranceShopMainView.<RefreshTabListAsync>d__17 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<PhantomArenaEntranceShopMainView.<RefreshTabListAsync>d__17>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603546C RID: 218220 RVA: 0x00C9DB84 File Offset: 0x00C9BD84
		private PhantomArenaEntranceShopTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new PhantomArenaEntranceShopTabData(uiDynamicTab.Icon, new CommonTabTitleData("PhantomBattle_1098", Array.Empty<object>()), uiDynamicTab.TabName, (EUiTabViewName)uiDynamicTab.ChildViewName);
		}

		// Token: 0x0603546D RID: 218221 RVA: 0x00C9DBCC File Offset: 0x00C9BDCC
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

		// Token: 0x0603546E RID: 218222 RVA: 0x00C9DC87 File Offset: 0x00C9BE87
		private PhantomArenaEntranceShopTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new PhantomArenaEntranceShopTabItem();
		}

		// Token: 0x0603546F RID: 218223 RVA: 0x00C9DC90 File Offset: 0x00C9BE90
		private void ToggleCallBack(int index)
		{
			this.LastClickTime = new double?(Time.Instance.Now);
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
			PhantomArenaEntranceShopTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, this.ActivityId, null);
			this.CurSelectTabView = new EUiTabViewName?(euiTabViewName);
		}

		// Token: 0x06035470 RID: 218224 RVA: 0x00C9DD07 File Offset: 0x00C9BF07
		private void OnClickedHelp()
		{
			HelpController.Instance.OpenHelpById(335);
		}

		// Token: 0x06035471 RID: 218225 RVA: 0x00C9DD18 File Offset: 0x00C9BF18
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

		// Token: 0x06035472 RID: 218226 RVA: 0x00C9DD60 File Offset: 0x00C9BF60
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

		// Token: 0x0401C56A RID: 116074
		protected int ActivityId;

		// Token: 0x0401C56B RID: 116075
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<PhantomArenaEntranceShopTabItem> TabComponent;

		// Token: 0x0401C56C RID: 116076
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401C56D RID: 116077
		private double? LastClickTime;

		// Token: 0x0401C56E RID: 116078
		protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401C56F RID: 116079
		private EUiTabViewName? CurSelectTabView;

		// Token: 0x0401C570 RID: 116080
		private int CurrencyId;

		// Token: 0x0401C571 RID: 116081
		private string RemainTimeText = "";

		// Token: 0x0200B2C6 RID: 45766
		[NullableContext(0)]
		private class EChildComponentType
		{
			// Token: 0x040362AC RID: 221868
			public const int CaptionItem = 0;

			// Token: 0x040362AD RID: 221869
			public const int InfoContent = 1;

			// Token: 0x040362AE RID: 221870
			public const int TxtTime = 2;
		}
	}
}

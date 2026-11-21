using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042EA RID: 17130
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueIllustratedEventView : UiViewBase
	{
		// Token: 0x0602B581 RID: 177537 RVA: 0x00C2E0D5 File Offset: 0x00C2C2D5
		public RogueIllustratedEventView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B582 RID: 177538 RVA: 0x00C2E0F0 File Offset: 0x00C2C2F0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0602B583 RID: 177539 RVA: 0x00C2E12C File Offset: 0x00C2C32C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueIllustratedEventView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueIllustratedEventView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B584 RID: 177540 RVA: 0x00C2E167 File Offset: 0x00C2C367
		protected override void OnStart()
		{
			this.IsNormalEvent = (bool)this.OpenParam;
			this.InitTabComponent();
		}

		// Token: 0x0602B585 RID: 177541 RVA: 0x00C2E180 File Offset: 0x00C2C380
		protected override void OnBeforeShow()
		{
			this.RefreshTabListAsync();
		}

		// Token: 0x0602B586 RID: 177542 RVA: 0x00C2E189 File Offset: 0x00C2C389
		protected override void OnBeforeDestroy()
		{
			this.TabComponent = null;
		}

		// Token: 0x0602B587 RID: 177543 RVA: 0x00C2E194 File Offset: 0x00C2C394
		protected void InitTabComponent()
		{
			this.TabComponent = new TabComponentWithCaptionItem<CommonTabItem>(base.GetItem(0), new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData)), new Action(this.OnCloseClicked), false);
			this.LastClickTime = null;
			this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
			this.TabComponent.SetHelpButtonShowState(false);
			this.TabViewComponentInstance = new TabViewComponent<RogueIllustratedTabData>(base.GetItem(1), EKeyMode.Default);
		}

		// Token: 0x0602B588 RID: 177544 RVA: 0x00C2E22B File Offset: 0x00C2C42B
		private void OnCloseClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602B589 RID: 177545 RVA: 0x00C2E234 File Offset: 0x00C2C434
		protected bool CanToggleChange(int index, bool? _)
		{
			if (Info.Instance.IsInGamepad())
			{
				return true;
			}
			int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
			if (this.LastClickTime != null)
			{
				double num = Time.Instance.Now - this.LastClickTime.Value;
				int? num2 = intConfig;
				double? num3 = (num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null;
				if (!(num >= num3.GetValueOrDefault() & num3 != null))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0602B58A RID: 177546 RVA: 0x00C2E2BA File Offset: 0x00C2C4BA
		private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x0602B58B RID: 177547 RVA: 0x00C2E2C4 File Offset: 0x00C2C4C4
		private void ToggleCallBack(int index)
		{
			this.LastClickTime = new double?(Time.Instance.Now);
			RogueIllustratedTabData rogueIllustratedTabData = this.TabDataList[index];
			EUiTabViewName tabViewName = this.GetTabViewName();
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			this.TabViewComponentInstance.ToggleCallBack(rogueIllustratedTabData, tabViewName, tabItemByIndex, this.IsNormalEvent, null);
			this.CurSelectSeason = ((rogueIllustratedTabData.Config != null) ? rogueIllustratedTabData.Config.Value.Id : 0);
		}

		// Token: 0x0602B58C RID: 177548 RVA: 0x00C2E354 File Offset: 0x00C2C554
		private CommonTabData GetCommonData(int index)
		{
			RogueIllustratedTabData rogueIllustratedTabData = this.TabDataList[index];
			return new CommonTabData(rogueIllustratedTabData.Icon, new CommonTabTitleData(rogueIllustratedTabData.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x0602B58D RID: 177549 RVA: 0x00C2E38C File Offset: 0x00C2C58C
		private UniTask RefreshTabListAsync()
		{
			RogueIllustratedEventView.<RefreshTabListAsync>d__18 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<RogueIllustratedEventView.<RefreshTabListAsync>d__18>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B58E RID: 177550 RVA: 0x00C2E3D0 File Offset: 0x00C2C5D0
		private EUiTabViewName GetTabViewName()
		{
			return (EUiTabViewName)DynamicTabConfig.Instance.GetViewTabList(EUiViewName.RogueEventIllustratedView)[0].ChildViewName;
		}

		// Token: 0x0602B58F RID: 177551 RVA: 0x00C2E404 File Offset: 0x00C2C604
		private List<CommonTabItemData> GetTabItemData(List<RogueIllustratedTabData> tabData)
		{
			int count = tabData.Count;
			List<CommonTabItemData> list = this.TabComponent.CreateTabItemDataByLength(count);
			for (int i = 0; i < count; i++)
			{
				RogueIllustratedTabData rogueIllustratedTabData = tabData[i];
				if (rogueIllustratedTabData != null)
				{
					list[i].RedDotName = new ERedDotName?(this.IsNormalEvent ? ERedDotName.RogueResIllustratedNormalTab : ERedDotName.RogueResIllustratedMapTab);
					CommonTabItemData commonTabItemData = list[i];
					RogueIllustratedTabData rogueIllustratedTabData2 = rogueIllustratedTabData;
					commonTabItemData.RedDotUid = new int?((rogueIllustratedTabData2.Config != null) ? rogueIllustratedTabData2.Config.GetValueOrDefault().Id : 0);
				}
			}
			return list;
		}

		// Token: 0x0602B590 RID: 177552 RVA: 0x00C2E490 File Offset: 0x00C2C690
		private List<RogueIllustratedTabData> GetIllustratedTabData()
		{
			List<RogueIllustratedTabData> list = new List<RogueIllustratedTabData>();
			List<UiDynamicTab> viewTabList = DynamicTabConfig.Instance.GetViewTabList(EUiViewName.RogueEventIllustratedView);
			if (viewTabList.Count == 0)
			{
				return list;
			}
			UiDynamicTab uiDynamicTab = viewTabList[0];
			list.Add(new RogueIllustratedTabData
			{
				TabType = (this.IsNormalEvent ? ERogueHandbookType.NormalEvent : ERogueHandbookType.MapEvent),
				Icon = uiDynamicTab.Icon,
				TabName = (this.IsNormalEvent ? "UiDynamicTab_114_TabName_Normal" : "UiDynamicTab_114_TabName_Map"),
				Index = uiDynamicTab.TabIndex,
				Config = null
			});
			IReadOnlyList<RogueResTheme> configList = ConfigRogueResThemeAll.GetConfigList(true);
			if (configList == null)
			{
				return list;
			}
			for (int i = 0; i < configList.Count; i++)
			{
				list.Add(new RogueIllustratedTabData
				{
					TabType = (this.IsNormalEvent ? ERogueHandbookType.NormalEvent : ERogueHandbookType.MapEvent),
					Icon = configList[i].Icon,
					TabName = configList[i].Name,
					Config = new RogueResTheme?(configList[i]),
					Index = i + 2
				});
			}
			return list;
		}

		// Token: 0x04017651 RID: 95825
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x04017652 RID: 95826
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabViewComponent<RogueIllustratedTabData> TabViewComponentInstance;

		// Token: 0x04017653 RID: 95827
		private double? LastClickTime;

		// Token: 0x04017654 RID: 95828
		protected List<RogueIllustratedTabData> TabDataList = new List<RogueIllustratedTabData>();

		// Token: 0x04017655 RID: 95829
		protected bool IsNormalEvent = true;

		// Token: 0x04017656 RID: 95830
		private int CurSelectSeason;
	}
}

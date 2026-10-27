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
	// Token: 0x0200531A RID: 21274
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueIllustratedEventView : UiViewBase
	{
		// Token: 0x06036685 RID: 222853 RVA: 0x00CE0705 File Offset: 0x00CDE905
		public RogueIllustratedEventView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036686 RID: 222854 RVA: 0x00CE0720 File Offset: 0x00CDE920
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06036687 RID: 222855 RVA: 0x00CE075C File Offset: 0x00CDE95C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueIllustratedEventView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueIllustratedEventView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036688 RID: 222856 RVA: 0x00CE0797 File Offset: 0x00CDE997
		protected override void OnStart()
		{
			this.IsNormalEvent = (bool)this.OpenParam;
			this.InitTabComponent();
		}

		// Token: 0x06036689 RID: 222857 RVA: 0x00CE07B0 File Offset: 0x00CDE9B0
		protected override void OnBeforeShow()
		{
			this.RefreshTabListAsync();
		}

		// Token: 0x0603668A RID: 222858 RVA: 0x00CE07B9 File Offset: 0x00CDE9B9
		protected override void OnBeforeDestroy()
		{
			this.TabComponent = null;
		}

		// Token: 0x0603668B RID: 222859 RVA: 0x00CE07C4 File Offset: 0x00CDE9C4
		protected void InitTabComponent()
		{
			this.TabComponent = new TabComponentWithCaptionItem<CommonTabItem>(base.GetItem(0), new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData)), new Action(this.OnCloseClicked), false);
			this.LastClickTime = null;
			this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
			this.TabComponent.SetHelpButtonShowState(false);
			this.TabViewComponentInstance = new TabViewComponent<RogueIllustratedTabData>(base.GetItem(1), EKeyMode.Default);
		}

		// Token: 0x0603668C RID: 222860 RVA: 0x00CE085B File Offset: 0x00CDEA5B
		private void OnCloseClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603668D RID: 222861 RVA: 0x00CE0864 File Offset: 0x00CDEA64
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

		// Token: 0x0603668E RID: 222862 RVA: 0x00CE08EA File Offset: 0x00CDEAEA
		private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x0603668F RID: 222863 RVA: 0x00CE08F4 File Offset: 0x00CDEAF4
		private void ToggleCallBack(int index)
		{
			this.LastClickTime = new double?(Time.Instance.Now);
			RogueIllustratedTabData rogueIllustratedTabData = this.TabDataList[index];
			EUiTabViewName tabViewName = this.GetTabViewName();
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			this.TabViewComponentInstance.ToggleCallBack(rogueIllustratedTabData, tabViewName, tabItemByIndex, this.IsNormalEvent, null);
			this.CurSelectSeason = ((rogueIllustratedTabData.Config != null) ? rogueIllustratedTabData.Config.Value.Id : 0);
		}

		// Token: 0x06036690 RID: 222864 RVA: 0x00CE0984 File Offset: 0x00CDEB84
		private CommonTabData GetCommonData(int index)
		{
			RogueIllustratedTabData rogueIllustratedTabData = this.TabDataList[index];
			return new CommonTabData(rogueIllustratedTabData.Icon, new CommonTabTitleData(rogueIllustratedTabData.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x06036691 RID: 222865 RVA: 0x00CE09BC File Offset: 0x00CDEBBC
		private UniTask RefreshTabListAsync()
		{
			RogueIllustratedEventView.<RefreshTabListAsync>d__18 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<RogueIllustratedEventView.<RefreshTabListAsync>d__18>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036692 RID: 222866 RVA: 0x00CE0A00 File Offset: 0x00CDEC00
		private EUiTabViewName GetTabViewName()
		{
			return (EUiTabViewName)DynamicTabConfig.Instance.GetViewTabList(EUiViewName.RogueEventIllustratedView)[0].ChildViewName;
		}

		// Token: 0x06036693 RID: 222867 RVA: 0x00CE0A34 File Offset: 0x00CDEC34
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

		// Token: 0x06036694 RID: 222868 RVA: 0x00CE0AC0 File Offset: 0x00CDECC0
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

		// Token: 0x0401CC1B RID: 117787
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401CC1C RID: 117788
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabViewComponent<RogueIllustratedTabData> TabViewComponentInstance;

		// Token: 0x0401CC1D RID: 117789
		private double? LastClickTime;

		// Token: 0x0401CC1E RID: 117790
		protected List<RogueIllustratedTabData> TabDataList = new List<RogueIllustratedTabData>();

		// Token: 0x0401CC1F RID: 117791
		protected bool IsNormalEvent = true;

		// Token: 0x0401CC20 RID: 117792
		private int CurSelectSeason;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x0200534A RID: 21322
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueTokenIllustratedView : UiViewBase
	{
		// Token: 0x0603678C RID: 223116 RVA: 0x00CE6372 File Offset: 0x00CE4572
		public RogueTokenIllustratedView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603678D RID: 223117 RVA: 0x00CE6388 File Offset: 0x00CE4588
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIExtendToggle))
			};
		}

		// Token: 0x0603678E RID: 223118 RVA: 0x00CE63F8 File Offset: 0x00CE45F8
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.InitTabComponent();
			this.InitExtendToggle();
		}

		// Token: 0x0603678F RID: 223119 RVA: 0x00CE6419 File Offset: 0x00CE4619
		protected override void OnBeforeShow()
		{
			this.RefreshTabListAsync();
		}

		// Token: 0x06036790 RID: 223120 RVA: 0x00CE6422 File Offset: 0x00CE4622
		protected override void OnBeforeDestroy()
		{
			if (this.TabComponent != null)
			{
				this.TabComponent.Destroy(null);
				this.TabComponent = null;
			}
		}

		// Token: 0x06036791 RID: 223121 RVA: 0x00CE643F File Offset: 0x00CE463F
		private void OnCloseClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036792 RID: 223122 RVA: 0x00CE6448 File Offset: 0x00CE4648
		protected void InitTabComponent()
		{
			CommonTabComponentData<CommonTabItem> data = new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
			this.TabComponent = new TabComponentWithCaptionItem<CommonTabItem>(base.GetItem(0), data, new Action(this.OnCloseClicked), false);
			this.LastClickTime = null;
			this.TabComponent.SetHelpButtonShowState(false);
			this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
			this.TabViewComponentInstance = new TabViewComponent<RogueIllustratedTabData>(base.GetItem(1), EKeyMode.Default);
		}

		// Token: 0x06036793 RID: 223123 RVA: 0x00CE64E4 File Offset: 0x00CE46E4
		protected void InitExtendToggle()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			EToggleState state = (RogueBattleModel.Instance.DescMode == EDescModel.DETAIL) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(state, false, false, false);
			}
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnExtendToggleStateChange));
		}

		// Token: 0x06036794 RID: 223124 RVA: 0x00CE6538 File Offset: 0x00CE4738
		private UniTask RefreshTabListAsync()
		{
			RogueTokenIllustratedView.<RefreshTabListAsync>d__13 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<RogueTokenIllustratedView.<RefreshTabListAsync>d__13>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036795 RID: 223125 RVA: 0x00CE657C File Offset: 0x00CE477C
		private List<CommonTabItemData> GetTabItemData(List<RogueIllustratedTabData> tabData)
		{
			int count = tabData.Count;
			List<CommonTabItemData> list = this.TabComponent.CreateTabItemDataByLength(count);
			for (int i = 0; i < count; i++)
			{
				RogueIllustratedTabData rogueIllustratedTabData = tabData[i];
				if (rogueIllustratedTabData != null)
				{
					list[i].RedDotName = new ERedDotName?(ERedDotName.RogueResIllustratedTokenTab);
					list[i].RedDotUid = new int?((rogueIllustratedTabData.Config != null) ? rogueIllustratedTabData.Config.Value.Id : 0);
				}
			}
			return list;
		}

		// Token: 0x06036796 RID: 223126 RVA: 0x00CE6600 File Offset: 0x00CE4800
		private CommonTabData GetCommonData(int index)
		{
			RogueIllustratedTabData rogueIllustratedTabData = this.TabDataList[index];
			return new CommonTabData(rogueIllustratedTabData.Icon, new CommonTabTitleData(rogueIllustratedTabData.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x06036797 RID: 223127 RVA: 0x00CE6638 File Offset: 0x00CE4838
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

		// Token: 0x06036798 RID: 223128 RVA: 0x00CE66BE File Offset: 0x00CE48BE
		private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x06036799 RID: 223129 RVA: 0x00CE66C8 File Offset: 0x00CE48C8
		private void ToggleCallBack(int index)
		{
			this.LastClickTime = new double?(Time.Instance.Now);
			RogueIllustratedTabData rogueIllustratedTabData = this.TabDataList[index];
			EUiTabViewName tabViewName = this.GetTabViewName();
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			EToggleState toggleState = base.GetExtendToggle(3).GetToggleState();
			this.TabViewComponentInstance.ToggleCallBack(rogueIllustratedTabData, tabViewName, tabItemByIndex, toggleState, null);
			this.CurSelectSeason = ((rogueIllustratedTabData.Config != null) ? rogueIllustratedTabData.Config.Value.Id : 0);
		}

		// Token: 0x0603679A RID: 223130 RVA: 0x00CE6760 File Offset: 0x00CE4960
		private void OnExtendToggleStateChange(EToggleState newState)
		{
			RogueBattleModel.Instance.ChangeDescMode();
		}

		// Token: 0x0603679B RID: 223131 RVA: 0x00CE676C File Offset: 0x00CE496C
		private EUiTabViewName GetTabViewName()
		{
			List<UiDynamicTab> viewTabList = DynamicTabConfig.Instance.GetViewTabList(EUiViewName.RogueTokenIllustratedView);
			if (viewTabList.Count == 0)
			{
				Log.Instance.Error(ELogModule.Activity, ELogAuthor.WHJ, "Missing Rogue Illustrated View Config, Use Default", default(ReadOnlySpan<ValueTuple<string, object>>));
				return EUiTabViewName.RogueIllustratedTokenTabView;
			}
			return (EUiTabViewName)viewTabList[0].ChildViewName;
		}

		// Token: 0x0603679C RID: 223132 RVA: 0x00CE67D0 File Offset: 0x00CE49D0
		private List<RogueIllustratedTabData> GetIllustratedTabData()
		{
			List<RogueIllustratedTabData> list = new List<RogueIllustratedTabData>();
			List<UiDynamicTab> viewTabList = DynamicTabConfig.Instance.GetViewTabList(EUiViewName.RogueTokenIllustratedView);
			if (viewTabList.Count == 0)
			{
				return list;
			}
			UiDynamicTab uiDynamicTab = viewTabList[0];
			list.Add(new RogueIllustratedTabData
			{
				TabType = ERogueHandbookType.Token,
				Icon = uiDynamicTab.Icon,
				TabName = uiDynamicTab.TabName,
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
					TabType = ERogueHandbookType.Token,
					Icon = configList[i].Icon,
					TabName = configList[i].Name,
					Config = new RogueResTheme?(configList[i]),
					Index = i + 2
				});
			}
			return list;
		}

		// Token: 0x0401CD27 RID: 118055
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401CD28 RID: 118056
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabViewComponent<RogueIllustratedTabData> TabViewComponentInstance;

		// Token: 0x0401CD29 RID: 118057
		private double? LastClickTime;

		// Token: 0x0401CD2A RID: 118058
		protected List<RogueIllustratedTabData> TabDataList = new List<RogueIllustratedTabData>();

		// Token: 0x0401CD2B RID: 118059
		private int CurSelectSeason;
	}
}

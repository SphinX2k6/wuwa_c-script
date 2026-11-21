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
	// Token: 0x0200431A RID: 17178
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueTokenIllustratedView : UiViewBase
	{
		// Token: 0x0602B688 RID: 177800 RVA: 0x00C33D42 File Offset: 0x00C31F42
		public RogueTokenIllustratedView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B689 RID: 177801 RVA: 0x00C33D58 File Offset: 0x00C31F58
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

		// Token: 0x0602B68A RID: 177802 RVA: 0x00C33DC8 File Offset: 0x00C31FC8
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

		// Token: 0x0602B68B RID: 177803 RVA: 0x00C33DE9 File Offset: 0x00C31FE9
		protected override void OnBeforeShow()
		{
			this.RefreshTabListAsync();
		}

		// Token: 0x0602B68C RID: 177804 RVA: 0x00C33DF2 File Offset: 0x00C31FF2
		protected override void OnBeforeDestroy()
		{
			if (this.TabComponent != null)
			{
				this.TabComponent.Destroy(null);
				this.TabComponent = null;
			}
		}

		// Token: 0x0602B68D RID: 177805 RVA: 0x00C33E0F File Offset: 0x00C3200F
		private void OnCloseClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602B68E RID: 177806 RVA: 0x00C33E18 File Offset: 0x00C32018
		protected void InitTabComponent()
		{
			CommonTabComponentData<CommonTabItem> data = new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
			this.TabComponent = new TabComponentWithCaptionItem<CommonTabItem>(base.GetItem(0), data, new Action(this.OnCloseClicked), false);
			this.LastClickTime = null;
			this.TabComponent.SetHelpButtonShowState(false);
			this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
			this.TabViewComponentInstance = new TabViewComponent<RogueIllustratedTabData>(base.GetItem(1), EKeyMode.Default);
		}

		// Token: 0x0602B68F RID: 177807 RVA: 0x00C33EB4 File Offset: 0x00C320B4
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

		// Token: 0x0602B690 RID: 177808 RVA: 0x00C33F08 File Offset: 0x00C32108
		private UniTask RefreshTabListAsync()
		{
			RogueTokenIllustratedView.<RefreshTabListAsync>d__13 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<RogueTokenIllustratedView.<RefreshTabListAsync>d__13>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B691 RID: 177809 RVA: 0x00C33F4C File Offset: 0x00C3214C
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

		// Token: 0x0602B692 RID: 177810 RVA: 0x00C33FD0 File Offset: 0x00C321D0
		private CommonTabData GetCommonData(int index)
		{
			RogueIllustratedTabData rogueIllustratedTabData = this.TabDataList[index];
			return new CommonTabData(rogueIllustratedTabData.Icon, new CommonTabTitleData(rogueIllustratedTabData.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x0602B693 RID: 177811 RVA: 0x00C34008 File Offset: 0x00C32208
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

		// Token: 0x0602B694 RID: 177812 RVA: 0x00C3408E File Offset: 0x00C3228E
		private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x0602B695 RID: 177813 RVA: 0x00C34098 File Offset: 0x00C32298
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

		// Token: 0x0602B696 RID: 177814 RVA: 0x00C34130 File Offset: 0x00C32330
		private void OnExtendToggleStateChange(EToggleState newState)
		{
			RogueBattleModel.Instance.ChangeDescMode();
		}

		// Token: 0x0602B697 RID: 177815 RVA: 0x00C3413C File Offset: 0x00C3233C
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

		// Token: 0x0602B698 RID: 177816 RVA: 0x00C341A0 File Offset: 0x00C323A0
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

		// Token: 0x0401775D RID: 96093
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401775E RID: 96094
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabViewComponent<RogueIllustratedTabData> TabViewComponentInstance;

		// Token: 0x0401775F RID: 96095
		private double? LastClickTime;

		// Token: 0x04017760 RID: 96096
		protected List<RogueIllustratedTabData> TabDataList = new List<RogueIllustratedTabData>();

		// Token: 0x04017761 RID: 96097
		private int CurSelectSeason;
	}
}

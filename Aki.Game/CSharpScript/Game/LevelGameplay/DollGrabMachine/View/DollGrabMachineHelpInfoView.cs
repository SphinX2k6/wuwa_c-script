using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EEB RID: 28395
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabMachineHelpInfoView : UiViewBase
	{
		// Token: 0x06045273 RID: 283251 RVA: 0x0111A987 File Offset: 0x01118B87
		public DollGrabMachineHelpInfoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06045274 RID: 283252 RVA: 0x0111A9A4 File Offset: 0x01118BA4
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06045275 RID: 283253 RVA: 0x0111AA70 File Offset: 0x01118C70
		protected override UniTask OnBeforeStartAsync()
		{
			DollGrabMachineHelpInfoView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DollGrabMachineHelpInfoView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06045276 RID: 283254 RVA: 0x0111AAB3 File Offset: 0x01118CB3
		protected override void OnBeforeShow()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(true);
		}

		// Token: 0x06045277 RID: 283255 RVA: 0x0111AAD8 File Offset: 0x01118CD8
		private TabItem CreateTabItem()
		{
			TabItem tabItem = new TabItem();
			tabItem.SetTabClickCallback(new Action<int>(this.OnClickTab));
			return tabItem;
		}

		// Token: 0x06045278 RID: 283256 RVA: 0x0111AAF4 File Offset: 0x01118CF4
		private void OnClickTab(int tabIndex)
		{
			if (this.SelectedTabIndex == tabIndex)
			{
				return;
			}
			this.SelectedTabIndex = tabIndex;
			GenericLayout<TabItem, int> tabLayout = this.TabLayout;
			if (tabLayout != null)
			{
				tabLayout.SelectGridProxy(tabIndex, false);
			}
			this.RefreshDescriptionScroll();
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("Switch", false, null, false);
		}

		// Token: 0x06045279 RID: 283257 RVA: 0x0111AB4C File Offset: 0x01118D4C
		private void RefreshDescriptionScroll()
		{
			this.InitScrollViewData();
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.ScrollDataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = 0;
			MultiTemplateScrollView setMultiTemplateScrollView = this.SetMultiTemplateScrollView;
			if (setMultiTemplateScrollView == null)
			{
				return;
			}
			setMultiTemplateScrollView.RefreshByData(multiTemplateScrollViewRefreshContext);
		}

		// Token: 0x0604527A RID: 283258 RVA: 0x0111AB84 File Offset: 0x01118D84
		private void InitScrollViewData()
		{
			this.ScrollDataList = new List<IMultiTemplateGridData>();
			if (this.SelectedTabIndex == 0)
			{
				IReadOnlyList<DollGrabMachineHelpInfo> configList = ConfigDollGrabMachineHelpInfoAll.GetConfigList(true);
				if (configList == null)
				{
					return;
				}
				using (IEnumerator<DollGrabMachineHelpInfo> enumerator = configList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DollGrabMachineHelpInfo dollGrabMachineHelpInfo = enumerator.Current;
						IDollDescriptionItemData data = new DollDescriptionItemData
						{
							IconPath = dollGrabMachineHelpInfo.IconPath,
							TextTitle = dollGrabMachineHelpInfo.Name,
							TextContent = dollGrabMachineHelpInfo.Description
						};
						DollDescriptionItemTemplateData dollDescriptionItemTemplateData = new DollDescriptionItemTemplateData();
						dollDescriptionItemTemplateData.Data = data;
						this.ScrollDataList.Add(dollDescriptionItemTemplateData);
					}
					return;
				}
			}
			IDollDescriptionItemData data2 = new DollDescriptionItemData
			{
				IconPath = "",
				TextTitle = "KClawIntro_Title",
				TextContent = "KClawIntro_Desc"
			};
			DollPlayDescriptionItemTemplateData dollPlayDescriptionItemTemplateData = new DollPlayDescriptionItemTemplateData();
			dollPlayDescriptionItemTemplateData.Data = data2;
			this.ScrollDataList.Add(dollPlayDescriptionItemTemplateData);
			IDollDescriptionItemData data3 = new DollDescriptionItemData
			{
				IconPath = "",
				TextTitle = "KClawRule_Title",
				TextContent = "KClawRule_Desc"
			};
			DollPlayDescriptionItemTemplateData dollPlayDescriptionItemTemplateData2 = new DollPlayDescriptionItemTemplateData();
			dollPlayDescriptionItemTemplateData2.Data = data3;
			this.ScrollDataList.Add(dollPlayDescriptionItemTemplateData2);
		}

		// Token: 0x04024054 RID: 147540
		[Nullable(2)]
		private DollGrabMachineHelpInfoCaptionPanel CaptionPanel;

		// Token: 0x04024055 RID: 147541
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TabItem, int> TabLayout;

		// Token: 0x04024056 RID: 147542
		[Nullable(2)]
		private MultiTemplateScrollView SetMultiTemplateScrollView;

		// Token: 0x04024057 RID: 147543
		private int SelectedTabIndex = -1;

		// Token: 0x04024058 RID: 147544
		private List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x04024059 RID: 147545
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}

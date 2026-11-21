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
	// Token: 0x0200606B RID: 24683
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabMachineHelpInfoView : UiViewBase
	{
		// Token: 0x0603B41C RID: 242716 RVA: 0x010C4717 File Offset: 0x010C2917
		public DollGrabMachineHelpInfoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B41D RID: 242717 RVA: 0x010C4734 File Offset: 0x010C2934
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

		// Token: 0x0603B41E RID: 242718 RVA: 0x010C4800 File Offset: 0x010C2A00
		protected override UniTask OnBeforeStartAsync()
		{
			DollGrabMachineHelpInfoView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DollGrabMachineHelpInfoView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B41F RID: 242719 RVA: 0x010C4843 File Offset: 0x010C2A43
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

		// Token: 0x0603B420 RID: 242720 RVA: 0x010C4868 File Offset: 0x010C2A68
		private TabItem CreateTabItem()
		{
			TabItem tabItem = new TabItem();
			tabItem.SetTabClickCallback(new Action<int>(this.OnClickTab));
			return tabItem;
		}

		// Token: 0x0603B421 RID: 242721 RVA: 0x010C4884 File Offset: 0x010C2A84
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

		// Token: 0x0603B422 RID: 242722 RVA: 0x010C48DC File Offset: 0x010C2ADC
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

		// Token: 0x0603B423 RID: 242723 RVA: 0x010C4914 File Offset: 0x010C2B14
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

		// Token: 0x0401F307 RID: 127751
		[Nullable(2)]
		private DollGrabMachineHelpInfoCaptionPanel CaptionPanel;

		// Token: 0x0401F308 RID: 127752
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TabItem, int> TabLayout;

		// Token: 0x0401F309 RID: 127753
		[Nullable(2)]
		private MultiTemplateScrollView SetMultiTemplateScrollView;

		// Token: 0x0401F30A RID: 127754
		private int SelectedTabIndex = -1;

		// Token: 0x0401F30B RID: 127755
		private List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401F30C RID: 127756
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}

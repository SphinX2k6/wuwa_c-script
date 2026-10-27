using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Monster
{
	// Token: 0x02006327 RID: 25383
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMonsterDetailView : UiViewBase
	{
		// Token: 0x0603FDCC RID: 261580 RVA: 0x00F735D8 File Offset: 0x00F717D8
		public PinballMonsterDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603FDCD RID: 261581 RVA: 0x00F735E4 File Offset: 0x00F717E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FDCE RID: 261582 RVA: 0x00F73804 File Offset: 0x00F71A04
		protected override UniTask OnBeforeStartAsync()
		{
			PinballMonsterDetailView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballMonsterDetailView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FDCF RID: 261583 RVA: 0x00F73848 File Offset: 0x00F71A48
		protected override void OnBeforeShow()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Switch01", false, null);
		}

		// Token: 0x0603FDD0 RID: 261584 RVA: 0x00F73874 File Offset: 0x00F71A74
		public void UpdateGridDataList()
		{
			HashSet<int> hashSet = PinballModel.Instance.CollectMonsterTypesByLevel(this.LevelId);
			PinballMonsterMultiTemplateGridData selectedGridData = this.SelectedGridData;
			int num = (selectedGridData != null) ? selectedGridData.Data.ItemData.Id : 0;
			foreach (int num2 in hashSet)
			{
				EPinballMonsterRiskType riskType = (EPinballMonsterRiskType)PinballConfig.Instance.GetPinballMonsterTypeConfigById(num2).Value.RiskType;
				if (!this.TitleDataMap.ContainsKey(riskType))
				{
					PinballMonsterRiskTypeTitleGridData value = new PinballMonsterRiskTypeTitleGridData(PinballConfig.Instance.GetPinballMonsterRiskTypeConfigById((int)riskType).Value);
					this.TitleDataMap[riskType] = value;
				}
				List<PinballMonsterMultiTemplateGridData> list;
				if (!this.MonsterDataMap.TryGetValue(riskType, out list))
				{
					list = new List<PinballMonsterMultiTemplateGridData>();
					this.MonsterDataMap[riskType] = list;
				}
				PinballItemDataMonster itemData = new PinballItemDataMonster
				{
					Type = EPinballItemType.Monster,
					Id = num2
				};
				PinballMonsterMultiTemplateGridData item = new PinballMonsterMultiTemplateGridData(new PinballItemSyncMonsterGridViewData
				{
					ItemData = itemData,
					IsSelected = (num2 == num),
					OnStateChangeDelegate = new Action<IPinballItemToggleCallback>(this.OnMonsterGridStateChange)
				});
				list.Add(item);
			}
			using (Dictionary<EPinballMonsterRiskType, List<PinballMonsterMultiTemplateGridData>>.ValueCollection.Enumerator enumerator2 = this.MonsterDataMap.Values.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					enumerator2.Current.Sort((PinballMonsterMultiTemplateGridData a, PinballMonsterMultiTemplateGridData b) => a.Data.ItemData.Id - b.Data.ItemData.Id);
				}
			}
			List<EPinballMonsterRiskType> list2 = new List<EPinballMonsterRiskType>(this.TitleDataMap.Keys);
			list2.Sort((EPinballMonsterRiskType a, EPinballMonsterRiskType b) => b - a);
			foreach (EPinballMonsterRiskType key in list2)
			{
				List<PinballMonsterMultiTemplateGridData> collection = this.MonsterDataMap[key];
				PinballMonsterRiskTypeTitleGridData item2 = this.TitleDataMap[key];
				this.GridDataList.Add(item2);
				this.GridDataList.AddRange(collection);
			}
		}

		// Token: 0x0603FDD1 RID: 261585 RVA: 0x00F73AC4 File Offset: 0x00F71CC4
		public void SetSelectedGridData(int index)
		{
			if (index < 0 || index >= this.GridDataList.Count)
			{
				return;
			}
			PinballMonsterMultiTemplateGridData selectedGridData = this.SelectedGridData;
			if (selectedGridData != null)
			{
				selectedGridData.Data.IsSelected = false;
			}
			this.SelectedGridIndex = index;
			PinballMonsterMultiTemplateGridData pinballMonsterMultiTemplateGridData = (PinballMonsterMultiTemplateGridData)this.GridDataList[index];
			this.SelectedGridData = pinballMonsterMultiTemplateGridData;
			pinballMonsterMultiTemplateGridData.Data.IsSelected = true;
			this.SelectedSkillIndex = -1;
			int id = pinballMonsterMultiTemplateGridData.Data.ItemData.Id;
			this.SelectedMonsterTypeConfig = PinballConfig.Instance.GetPinballMonsterTypeConfigById(id);
			this.UpdateSkillDataList();
			this.SetSelectedSkillIndex(0);
		}

		// Token: 0x0603FDD2 RID: 261586 RVA: 0x00F73B5C File Offset: 0x00F71D5C
		public void UpdateSkillDataList()
		{
			if (this.SelectedGridData == null || this.SelectedMonsterTypeConfig == null)
			{
				return;
			}
			this.SkillConfigList.Clear();
			this.SkillTabItemDataList.Clear();
			int[] array = this.SelectedMonsterTypeConfig.Value.DisplayedSkillList();
			if (array.Length < 0)
			{
				return;
			}
			for (int i = 0; i < array.Length; i++)
			{
				int id = array[i];
				PinballMonsterSkillDisplay? pinballMonsterSkillDisplayConfigById = PinballConfig.Instance.GetPinballMonsterSkillDisplayConfigById(id);
				this.SkillConfigList.Add(pinballMonsterSkillDisplayConfigById.Value);
				PinballMonsterSkillTabItemData item = new PinballMonsterSkillTabItemData
				{
					IsSelected = (i == this.SelectedSkillIndex),
					Name = this.SkillTabNameList[i],
					OnSelected = new Action<int>(this.OnSkillTabItemSelected)
				};
				this.SkillTabItemDataList.Add(item);
			}
		}

		// Token: 0x0603FDD3 RID: 261587 RVA: 0x00F73C24 File Offset: 0x00F71E24
		public void SetSelectedSkillIndex(int index)
		{
			if (index < 0 || index >= this.SkillTabItemDataList.Count)
			{
				return;
			}
			int selectedSkillIndex = this.SelectedSkillIndex;
			if (selectedSkillIndex != -1)
			{
				this.SkillTabItemDataList[selectedSkillIndex].IsSelected = false;
			}
			this.SelectedSkillIndex = index;
			this.SkillTabItemDataList[index].IsSelected = true;
		}

		// Token: 0x0603FDD4 RID: 261588 RVA: 0x00F73C7C File Offset: 0x00F71E7C
		public void RefreshGrids()
		{
			MultiTemplateScrollViewRefreshContext context = new MultiTemplateScrollViewRefreshContext(this.GridDataList);
			MultiTemplateScrollView gridScrollView = this.GridScrollView;
			if (gridScrollView == null)
			{
				return;
			}
			gridScrollView.RefreshByData(context);
		}

		// Token: 0x0603FDD5 RID: 261589 RVA: 0x00F73CA8 File Offset: 0x00F71EA8
		public void SelectGrid(int index)
		{
			int selectedGridIndex = this.SelectedGridIndex;
			if (selectedGridIndex == index)
			{
				return;
			}
			this.SetSelectedGridData(index);
			if (selectedGridIndex != -1)
			{
				MultiTemplateScrollView gridScrollView = this.GridScrollView;
				(((gridScrollView != null) ? gridScrollView.GetProxyByGridIndex(selectedGridIndex) : null) as PinballItemSyncMonsterGridView).RefreshToggleState(false);
			}
			MultiTemplateScrollView gridScrollView2 = this.GridScrollView;
			(((gridScrollView2 != null) ? gridScrollView2.GetProxyByGridIndex(index) : null) as PinballItemSyncMonsterGridView).RefreshToggleState(false);
			this.RefreshMonsterInfo();
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Switch01", false, null);
		}

		// Token: 0x0603FDD6 RID: 261590 RVA: 0x00F73D30 File Offset: 0x00F71F30
		public void SelectSkill(int index)
		{
			if (index < 0 || index >= this.SkillConfigList.Count)
			{
				return;
			}
			int selectedSkillIndex = this.SelectedSkillIndex;
			this.SetSelectedSkillIndex(index);
			if (selectedSkillIndex != -1)
			{
				GenericLayout<PinballMonsterSkillTabItem, IPinballMonsterSkillTabItemData> skillLayout = this.SkillLayout;
				if (skillLayout != null)
				{
					PinballMonsterSkillTabItem layoutItemByIndex = skillLayout.GetLayoutItemByIndex(selectedSkillIndex);
					if (layoutItemByIndex != null)
					{
						layoutItemByIndex.RefreshToggle(false);
					}
				}
			}
			GenericLayout<PinballMonsterSkillTabItem, IPinballMonsterSkillTabItemData> skillLayout2 = this.SkillLayout;
			if (skillLayout2 != null)
			{
				PinballMonsterSkillTabItem layoutItemByIndex2 = skillLayout2.GetLayoutItemByIndex(index);
				if (layoutItemByIndex2 != null)
				{
					layoutItemByIndex2.RefreshToggle(false);
				}
			}
			this.SkillInfoDirty = true;
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Switch02", false, null);
		}

		// Token: 0x0603FDD7 RID: 261591 RVA: 0x00F73DC4 File Offset: 0x00F71FC4
		public void RefreshMonsterInfo()
		{
			if (this.SelectedGridData == null || this.SelectedMonsterTypeConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.SelectedMonsterTypeConfig.Value.Name, Array.Empty<object>());
			this.SetSpriteByPath(PinballConfig.Instance.GetPinballMonsterRiskTypeConfigById(this.SelectedMonsterTypeConfig.Value.RiskType).Value.Icon1, base.GetSprite(14), false, null, null);
			int recommendBd = this.SelectedMonsterTypeConfig.Value.RecommendBd;
			if (recommendBd != 0)
			{
				this.BdItem.SetUiActive(true);
				PinballBdConfig? pinballBdConfigById = PinballConfig.Instance.GetPinballBdConfigById(recommendBd);
				PinballRoleClassItemData data = new PinballRoleClassItemData
				{
					Name = pinballBdConfigById.Value.BdName,
					IconPath = pinballBdConfigById.Value.Icon,
					BgColor = pinballBdConfigById.Value.BgColor
				};
				this.BdItem.Refresh(data, false, 0);
			}
			else
			{
				this.BdItem.SetUiActive(false);
			}
			bool flag = this.SkillConfigList.Count > 0;
			base.GetLayoutBase(6).RootUIComp.Get().SetUIActive(flag);
			base.GetItem(8).SetUIActive(!flag);
			base.GetTexture(11).SetUIActive(flag);
			if (flag)
			{
				GenericLayout<PinballMonsterSkillTabItem, IPinballMonsterSkillTabItemData> skillLayout = this.SkillLayout;
				if (skillLayout != null)
				{
					skillLayout.RefreshByData(this.SkillTabItemDataList, null, false);
				}
				this.RefreshSkillInfo();
				return;
			}
			this.RefreshNormalMonsterInfo();
		}

		// Token: 0x0603FDD8 RID: 261592 RVA: 0x00F73F60 File Offset: 0x00F72160
		public void RefreshSkillInfo()
		{
			if (this.SelectedGridData == null)
			{
				return;
			}
			PinballMonsterSkillDisplay pinballMonsterSkillDisplay = this.SkillConfigList[this.SelectedSkillIndex];
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), pinballMonsterSkillDisplay.Desc, Array.Empty<object>());
			this.MediaPlayer.PlayVideo(pinballMonsterSkillDisplay.VideoName, pinballMonsterSkillDisplay.VideoPath, true);
		}

		// Token: 0x0603FDD9 RID: 261593 RVA: 0x00F73FC0 File Offset: 0x00F721C0
		public void RefreshNormalMonsterInfo()
		{
			if (this.SelectedGridData == null || this.SelectedMonsterTypeConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), this.SelectedMonsterTypeConfig.Value.Desc, Array.Empty<object>());
			USpineSkeletonAnimationComponent spine = base.GetSpine(10);
			base.SetSpineAssetByPath(this.SelectedMonsterTypeConfig.Value.SpineAtlasPath, this.SelectedMonsterTypeConfig.Value.SpineSkeletonDataPath, spine).Forget();
			base.SetTextureByPath(this.SelectedMonsterTypeConfig.Value.SpineBg, base.GetTexture(9), null, null);
		}

		// Token: 0x0603FDDA RID: 261594 RVA: 0x00F74074 File Offset: 0x00F72274
		private void OnMonsterGridStateChange(IPinballItemToggleCallback callbackParameter)
		{
			if (callbackParameter.State == EToggleState.ETT_Checked)
			{
				PinballItemSyncMonsterGridView pinballItemSyncMonsterGridView = callbackParameter.View as PinballItemSyncMonsterGridView;
				this.SelectGrid(pinballItemSyncMonsterGridView.GridIndex);
			}
		}

		// Token: 0x0603FDDB RID: 261595 RVA: 0x00F740A2 File Offset: 0x00F722A2
		private void OnSkillTabItemSelected(int gridIndex)
		{
			this.SelectSkill(gridIndex);
		}

		// Token: 0x0603FDDC RID: 261596 RVA: 0x00F740AB File Offset: 0x00F722AB
		private PinballMonsterSkillTabItem CreateSkillItem()
		{
			return new PinballMonsterSkillTabItem();
		}

		// Token: 0x0603FDDD RID: 261597 RVA: 0x00F740B2 File Offset: 0x00F722B2
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603FDDE RID: 261598 RVA: 0x00F740BB File Offset: 0x00F722BB
		private void OnEventSequence(string sequenceName, string eventName)
		{
			if (sequenceName == "Switch02" && eventName == "Switch02" && this.SkillInfoDirty)
			{
				this.RefreshSkillInfo();
				this.SkillInfoDirty = false;
			}
		}

		// Token: 0x0603FDDF RID: 261599 RVA: 0x00F740EC File Offset: 0x00F722EC
		protected override void OnBeforeDestroy()
		{
			MediaPlayer mediaPlayer = this.MediaPlayer;
			if (mediaPlayer != null)
			{
				mediaPlayer.Clear();
			}
			this.MediaPlayer = null;
		}

		// Token: 0x0402150F RID: 136463
		protected int LevelId;

		// Token: 0x04021510 RID: 136464
		protected int SelectedGridIndex;

		// Token: 0x04021511 RID: 136465
		[Nullable(2)]
		protected PinballMonsterMultiTemplateGridData SelectedGridData;

		// Token: 0x04021512 RID: 136466
		protected PinballMonsterType? SelectedMonsterTypeConfig;

		// Token: 0x04021513 RID: 136467
		protected int SelectedSkillIndex;

		// Token: 0x04021514 RID: 136468
		protected List<IMultiTemplateGridData> GridDataList;

		// Token: 0x04021515 RID: 136469
		protected Dictionary<EPinballMonsterRiskType, PinballMonsterRiskTypeTitleGridData> TitleDataMap;

		// Token: 0x04021516 RID: 136470
		protected Dictionary<EPinballMonsterRiskType, List<PinballMonsterMultiTemplateGridData>> MonsterDataMap;

		// Token: 0x04021517 RID: 136471
		protected List<IPinballMonsterSkillTabItemData> SkillTabItemDataList;

		// Token: 0x04021518 RID: 136472
		protected List<PinballMonsterSkillDisplay> SkillConfigList;

		// Token: 0x04021519 RID: 136473
		private string[] SkillTabNameList;

		// Token: 0x0402151A RID: 136474
		[Nullable(2)]
		private MediaPlayer MediaPlayer;

		// Token: 0x0402151B RID: 136475
		[Nullable(2)]
		protected MultiTemplateScrollView GridScrollView;

		// Token: 0x0402151C RID: 136476
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<PinballMonsterSkillTabItem, IPinballMonsterSkillTabItemData> SkillLayout;

		// Token: 0x0402151D RID: 136477
		[Nullable(2)]
		protected PinballRoleClassItem BdItem;

		// Token: 0x0402151E RID: 136478
		[Nullable(2)]
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0402151F RID: 136479
		private bool SkillInfoDirty;

		// Token: 0x0200C525 RID: 50469
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403B803 RID: 243715
			CaptionItem,
			// Token: 0x0403B804 RID: 243716
			MultiTemplateScrollView,
			// Token: 0x0403B805 RID: 243717
			TitleTemplateItem,
			// Token: 0x0403B806 RID: 243718
			MonsterGridTemplateItem,
			// Token: 0x0403B807 RID: 243719
			NameText,
			// Token: 0x0403B808 RID: 243720
			BdItem,
			// Token: 0x0403B809 RID: 243721
			SkillLayout,
			// Token: 0x0403B80A RID: 243722
			SkillItem,
			// Token: 0x0403B80B RID: 243723
			MonsterSpineRootItem,
			// Token: 0x0403B80C RID: 243724
			MonsterBgTexture,
			// Token: 0x0403B80D RID: 243725
			MonsterSpine,
			// Token: 0x0403B80E RID: 243726
			CGTexture,
			// Token: 0x0403B80F RID: 243727
			InfoScrollView,
			// Token: 0x0403B810 RID: 243728
			DescText,
			// Token: 0x0403B811 RID: 243729
			TypeIconSprite
		}
	}
}

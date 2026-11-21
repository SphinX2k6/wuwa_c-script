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
	// Token: 0x020052A5 RID: 21157
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMonsterDetailView : UiViewBase
	{
		// Token: 0x06034A8D RID: 215693 RVA: 0x00EBA534 File Offset: 0x00EB8734
		public PinballMonsterDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06034A8E RID: 215694 RVA: 0x00EBA540 File Offset: 0x00EB8740
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

		// Token: 0x06034A8F RID: 215695 RVA: 0x00EBA760 File Offset: 0x00EB8960
		protected override UniTask OnBeforeStartAsync()
		{
			PinballMonsterDetailView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballMonsterDetailView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A90 RID: 215696 RVA: 0x00EBA7A4 File Offset: 0x00EB89A4
		protected override void OnBeforeShow()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Switch01", false, null);
		}

		// Token: 0x06034A91 RID: 215697 RVA: 0x00EBA7D0 File Offset: 0x00EB89D0
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

		// Token: 0x06034A92 RID: 215698 RVA: 0x00EBAA20 File Offset: 0x00EB8C20
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

		// Token: 0x06034A93 RID: 215699 RVA: 0x00EBAAB8 File Offset: 0x00EB8CB8
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

		// Token: 0x06034A94 RID: 215700 RVA: 0x00EBAB80 File Offset: 0x00EB8D80
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

		// Token: 0x06034A95 RID: 215701 RVA: 0x00EBABD8 File Offset: 0x00EB8DD8
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

		// Token: 0x06034A96 RID: 215702 RVA: 0x00EBAC04 File Offset: 0x00EB8E04
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

		// Token: 0x06034A97 RID: 215703 RVA: 0x00EBAC8C File Offset: 0x00EB8E8C
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

		// Token: 0x06034A98 RID: 215704 RVA: 0x00EBAD20 File Offset: 0x00EB8F20
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

		// Token: 0x06034A99 RID: 215705 RVA: 0x00EBAEBC File Offset: 0x00EB90BC
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

		// Token: 0x06034A9A RID: 215706 RVA: 0x00EBAF1C File Offset: 0x00EB911C
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

		// Token: 0x06034A9B RID: 215707 RVA: 0x00EBAFD0 File Offset: 0x00EB91D0
		private void OnMonsterGridStateChange(IPinballItemToggleCallback callbackParameter)
		{
			if (callbackParameter.State == EToggleState.ETT_Checked)
			{
				PinballItemSyncMonsterGridView pinballItemSyncMonsterGridView = callbackParameter.View as PinballItemSyncMonsterGridView;
				this.SelectGrid(pinballItemSyncMonsterGridView.GridIndex);
			}
		}

		// Token: 0x06034A9C RID: 215708 RVA: 0x00EBAFFE File Offset: 0x00EB91FE
		private void OnSkillTabItemSelected(int gridIndex)
		{
			this.SelectSkill(gridIndex);
		}

		// Token: 0x06034A9D RID: 215709 RVA: 0x00EBB007 File Offset: 0x00EB9207
		private PinballMonsterSkillTabItem CreateSkillItem()
		{
			return new PinballMonsterSkillTabItem();
		}

		// Token: 0x06034A9E RID: 215710 RVA: 0x00EBB00E File Offset: 0x00EB920E
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06034A9F RID: 215711 RVA: 0x00EBB017 File Offset: 0x00EB9217
		private void OnEventSequence(string sequenceName, string eventName)
		{
			if (sequenceName == "Switch02" && eventName == "Switch02" && this.SkillInfoDirty)
			{
				this.RefreshSkillInfo();
				this.SkillInfoDirty = false;
			}
		}

		// Token: 0x06034AA0 RID: 215712 RVA: 0x00EBB048 File Offset: 0x00EB9248
		protected override void OnBeforeDestroy()
		{
			MediaPlayer mediaPlayer = this.MediaPlayer;
			if (mediaPlayer != null)
			{
				mediaPlayer.Clear();
			}
			this.MediaPlayer = null;
		}

		// Token: 0x0401BE3E RID: 114238
		protected int LevelId;

		// Token: 0x0401BE3F RID: 114239
		protected int SelectedGridIndex;

		// Token: 0x0401BE40 RID: 114240
		[Nullable(2)]
		protected PinballMonsterMultiTemplateGridData SelectedGridData;

		// Token: 0x0401BE41 RID: 114241
		protected PinballMonsterType? SelectedMonsterTypeConfig;

		// Token: 0x0401BE42 RID: 114242
		protected int SelectedSkillIndex;

		// Token: 0x0401BE43 RID: 114243
		protected List<IMultiTemplateGridData> GridDataList;

		// Token: 0x0401BE44 RID: 114244
		protected Dictionary<EPinballMonsterRiskType, PinballMonsterRiskTypeTitleGridData> TitleDataMap;

		// Token: 0x0401BE45 RID: 114245
		protected Dictionary<EPinballMonsterRiskType, List<PinballMonsterMultiTemplateGridData>> MonsterDataMap;

		// Token: 0x0401BE46 RID: 114246
		protected List<IPinballMonsterSkillTabItemData> SkillTabItemDataList;

		// Token: 0x0401BE47 RID: 114247
		protected List<PinballMonsterSkillDisplay> SkillConfigList;

		// Token: 0x0401BE48 RID: 114248
		private string[] SkillTabNameList;

		// Token: 0x0401BE49 RID: 114249
		[Nullable(2)]
		private MediaPlayer MediaPlayer;

		// Token: 0x0401BE4A RID: 114250
		[Nullable(2)]
		protected MultiTemplateScrollView GridScrollView;

		// Token: 0x0401BE4B RID: 114251
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<PinballMonsterSkillTabItem, IPinballMonsterSkillTabItemData> SkillLayout;

		// Token: 0x0401BE4C RID: 114252
		[Nullable(2)]
		protected PinballRoleClassItem BdItem;

		// Token: 0x0401BE4D RID: 114253
		[Nullable(2)]
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401BE4E RID: 114254
		private bool SkillInfoDirty;

		// Token: 0x0200AF0C RID: 44812
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04036165 RID: 221541
			CaptionItem,
			// Token: 0x04036166 RID: 221542
			MultiTemplateScrollView,
			// Token: 0x04036167 RID: 221543
			TitleTemplateItem,
			// Token: 0x04036168 RID: 221544
			MonsterGridTemplateItem,
			// Token: 0x04036169 RID: 221545
			NameText,
			// Token: 0x0403616A RID: 221546
			BdItem,
			// Token: 0x0403616B RID: 221547
			SkillLayout,
			// Token: 0x0403616C RID: 221548
			SkillItem,
			// Token: 0x0403616D RID: 221549
			MonsterSpineRootItem,
			// Token: 0x0403616E RID: 221550
			MonsterBgTexture,
			// Token: 0x0403616F RID: 221551
			MonsterSpine,
			// Token: 0x04036170 RID: 221552
			CGTexture,
			// Token: 0x04036171 RID: 221553
			InfoScrollView,
			// Token: 0x04036172 RID: 221554
			DescText,
			// Token: 0x04036173 RID: 221555
			TypeIconSprite
		}
	}
}

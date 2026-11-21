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

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A37 RID: 23095
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolScheduleView : UiViewBase
	{
		// Token: 0x17006C81 RID: 27777
		// (get) Token: 0x06038ED7 RID: 233175 RVA: 0x00FF1465 File Offset: 0x00FEF665
		private bool IsCurrentWeek
		{
			get
			{
				return this.WeekOffset == 0;
			}
		}

		// Token: 0x06038ED8 RID: 233176 RVA: 0x00FF1470 File Offset: 0x00FEF670
		public SolarSchoolScheduleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038ED9 RID: 233177 RVA: 0x00FF14DC File Offset: 0x00FEF6DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 47;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(35, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(37, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(38, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(39, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(40, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(41, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(42, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(43, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(44, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(45, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(46, typeof(UUIArtText));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickReset));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.OnClickPreWeek));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(19, new Action(this.OnClickNextWeek));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038EDA RID: 233178 RVA: 0x00FF1BC0 File Offset: 0x00FEFDC0
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolScheduleView.<OnBeforeStartAsync>d__29 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolScheduleView.<OnBeforeStartAsync>d__29>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038EDB RID: 233179 RVA: 0x00FF1C04 File Offset: 0x00FEFE04
		protected override void OnBeforeShow()
		{
			this.ResetScheduleAnimations();
			this.ScheduleAnimationsEnabled = true;
			this.ResetPreviewNotice();
			this.PreviousCells.Clear();
			this.TempData = SolarSchoolGamePlayModel.Instance.ScheduleData.CreateDraft();
			this.WeekOffset = 0;
			this.SelectedBehavior = null;
			this.TrimFatigueOverflow();
			this.IncreasedAttrs.Clear();
			this.RefreshAttrs();
			this.RefreshTabs();
			this.RefreshWeekNav();
			this.RefreshCurrentDate();
			this.InitSaveBtnState();
			this.RefreshLeftColumns(true, true);
			int index = this.FindFirstNonEmptyTabIndex();
			this.SelectTab(index, true);
			int id = (SolarSchoolGamePlayModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? 101 : 102;
			SolarSchoolRole? role = SolarSchoolConfig.Instance.GetRole(id);
			if (role != null)
			{
				base.SetTextureByPath(role.Value.HeadIcon, base.GetTexture(1), null, null);
			}
		}

		// Token: 0x06038EDC RID: 233180 RVA: 0x00FF1CE8 File Offset: 0x00FEFEE8
		protected override void OnBeforeHide()
		{
			this.ResetPreviewNotice();
			this.ResetScheduleAnimations();
		}

		// Token: 0x06038EDD RID: 233181 RVA: 0x00FF1CF8 File Offset: 0x00FEFEF8
		private void ResetScheduleAnimations()
		{
			this.ScheduleAnimationsEnabled = false;
			this.BehaviorRefreshVersion++;
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.StopSequenceByKey("Switch", false, false);
			}
			UUIInturnAnimController behaviorAnimationController = this.GetBehaviorAnimationController();
			if (behaviorAnimationController != null)
			{
				behaviorAnimationController.Stop();
			}
			if (this.BehaviorScroll != null)
			{
				for (int i = 0; i < this.BehaviorScroll.GetDisplayGridNum(); i++)
				{
					UUIItem gridByDisplayIndex = this.BehaviorScroll.GetGridByDisplayIndex(i);
					AUIBaseActor auibaseActor = ((gridByDisplayIndex != null) ? gridByDisplayIndex.GetOwner() : null) as AUIBaseActor;
					if (auibaseActor != null)
					{
						auibaseActor.StopSequenceByKey("Start");
					}
					if (gridByDisplayIndex != null)
					{
						gridByDisplayIndex.SetAlpha(1f);
					}
				}
			}
			foreach (GenericLayout<SolarSchoolScheduleGroupItem, SolarSchoolScheduleGroupData> genericLayout in this.GroupLayouts)
			{
				List<SolarSchoolScheduleGroupItem> list = (genericLayout != null) ? genericLayout.GetLayoutItemList() : null;
				if (list != null)
				{
					foreach (SolarSchoolScheduleGroupItem solarSchoolScheduleGroupItem in list)
					{
						solarSchoolScheduleGroupItem.ResetAnimations();
					}
				}
			}
		}

		// Token: 0x06038EDE RID: 233182 RVA: 0x00FF1E08 File Offset: 0x00FF0008
		private int FindFirstNonEmptyTabIndex()
		{
			int count = this.GetTabCategories().Count;
			for (int i = 0; i < count; i++)
			{
				if (this.GetTabBehaviorIds(i).Count > 0)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x06038EDF RID: 233183 RVA: 0x00FF1E3F File Offset: 0x00FF003F
		private void CreateGroupLayouts()
		{
			this.CreateGroupLayout(0, 9, 7);
			this.CreateGroupLayout(1, 12, 10);
		}

		// Token: 0x06038EE0 RID: 233184 RVA: 0x00FF1E58 File Offset: 0x00FF0058
		private void CreateGroupLayout(int columnIndex, int layoutComponent, int templateComponent)
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(layoutComponent);
			UUIItem item = base.GetItem(templateComponent);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (verticalLayout == null || auibaseActor == null)
			{
				return;
			}
			this.GroupLayouts[columnIndex] = new GenericLayout<SolarSchoolScheduleGroupItem, SolarSchoolScheduleGroupData>(verticalLayout, new Func<SolarSchoolScheduleGroupItem>(this.CreateGroupItem), auibaseActor, false, true);
		}

		// Token: 0x06038EE1 RID: 233185 RVA: 0x00FF1EAA File Offset: 0x00FF00AA
		private SolarSchoolScheduleGroupItem CreateGroupItem()
		{
			return new SolarSchoolScheduleGroupItem
			{
				DeleteCallback = new Action<SolarSchoolScheduleGroupData>(this.OnClickDeleteGroup),
				CanPlayAnimations = (() => this.ScheduleAnimationsEnabled)
			};
		}

		// Token: 0x06038EE2 RID: 233186 RVA: 0x00FF1ED8 File Offset: 0x00FF00D8
		private void CreateTabLayout()
		{
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(33);
			UUIItem item = base.GetItem(34);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (horizontalLayout == null || auibaseActor == null)
			{
				return;
			}
			this.TabLayout = new GenericLayout<SolarSchoolScheduleTabItem, SolarSchoolScheduleTabItemData>(horizontalLayout, new Func<SolarSchoolScheduleTabItem>(this.CreateTabItem), auibaseActor, false, true);
		}

		// Token: 0x06038EE3 RID: 233187 RVA: 0x00FF1F2A File Offset: 0x00FF012A
		private SolarSchoolScheduleTabItem CreateTabItem()
		{
			return new SolarSchoolScheduleTabItem
			{
				ClickCallback = new Action<SolarSchoolScheduleTabItemData>(this.OnClickTab)
			};
		}

		// Token: 0x06038EE4 RID: 233188 RVA: 0x00FF1F44 File Offset: 0x00FF0144
		private void CreateAttrLayout()
		{
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(2);
			UUIItem item = base.GetItem(3);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (horizontalLayout == null || auibaseActor == null)
			{
				return;
			}
			this.AttrLayout = new GenericLayout<SolarSchoolAttrBriefItem, ESolarSchoolSecondAttr>(horizontalLayout, () => new SolarSchoolAttrBriefItem
			{
				IsAttrIncreased = ((ESolarSchoolSecondAttr attr) => this.IncreasedAttrs.Contains(attr))
			}, auibaseActor, false, true);
		}

		// Token: 0x06038EE5 RID: 233189 RVA: 0x00FF1F94 File Offset: 0x00FF0194
		private void CreateConsumeLayout()
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(26);
			UUIItem item = base.GetItem(27);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (verticalLayout == null || auibaseActor == null)
			{
				return;
			}
			this.ConsumeLayout = new GenericLayout<SolarSchoolAttrDeltaItem, SolarSchoolAttrDeltaItemData>(verticalLayout, () => new SolarSchoolAttrDeltaItem(), auibaseActor, false, true);
		}

		// Token: 0x06038EE6 RID: 233190 RVA: 0x00FF1FFC File Offset: 0x00FF01FC
		private void CreateBehaviorScroll()
		{
			UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(35);
			UUIItem item = base.GetItem(36);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (loopScrollViewComponent == null || auibaseActor == null)
			{
				return;
			}
			this.BehaviorScroll = new LoopScrollView<SolarSchoolScheduleBehaviorItem, SolarSchoolScheduleBehaviorData>(loopScrollViewComponent, auibaseActor, new Func<SolarSchoolScheduleBehaviorItem>(this.CreateBehaviorItem), false);
		}

		// Token: 0x06038EE7 RID: 233191 RVA: 0x00FF204D File Offset: 0x00FF024D
		private SolarSchoolScheduleBehaviorItem CreateBehaviorItem()
		{
			return new SolarSchoolScheduleBehaviorItem
			{
				SelectCallback = new Action<SolarSchoolScheduleBehaviorData>(this.OnClickBehavior),
				AddCallback = new Action<SolarSchoolScheduleBehaviorData>(this.OnClickAddBehavior)
			};
		}

		// Token: 0x06038EE8 RID: 233192 RVA: 0x00FF2078 File Offset: 0x00FF0278
		private UniTask CreateSpecialDayItemsAsync()
		{
			SolarSchoolScheduleView.<CreateSpecialDayItemsAsync>d__43 <CreateSpecialDayItemsAsync>d__;
			<CreateSpecialDayItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSpecialDayItemsAsync>d__.<>4__this = this;
			<CreateSpecialDayItemsAsync>d__.<>1__state = -1;
			<CreateSpecialDayItemsAsync>d__.<>t__builder.Start<SolarSchoolScheduleView.<CreateSpecialDayItemsAsync>d__43>(ref <CreateSpecialDayItemsAsync>d__);
			return <CreateSpecialDayItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038EE9 RID: 233193 RVA: 0x00FF20BC File Offset: 0x00FF02BC
		private int GetSpecialDayItemComponent(int weekday)
		{
			int result;
			switch (weekday)
			{
			case 1:
				result = 13;
				break;
			case 2:
				result = 14;
				break;
			case 3:
				result = 15;
				break;
			case 4:
				result = 16;
				break;
			default:
				result = 17;
				break;
			}
			return result;
		}

		// Token: 0x06038EEA RID: 233194 RVA: 0x00FF20FC File Offset: 0x00FF02FC
		private void RefreshAttrs()
		{
			List<ESolarSchoolSecondAttr> list = new List<ESolarSchoolSecondAttr>
			{
				ESolarSchoolSecondAttr.Popularity
			};
			list.AddRange(SolarSchoolDefine.AttrsShowList);
			GenericLayout<SolarSchoolAttrBriefItem, ESolarSchoolSecondAttr> attrLayout = this.AttrLayout;
			if (attrLayout == null)
			{
				return;
			}
			attrLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06038EEB RID: 233195 RVA: 0x00FF2134 File Offset: 0x00FF0334
		private IReadOnlyList<SolarSchoolBehaviorCategory> GetTabCategories()
		{
			IReadOnlyList<SolarSchoolBehaviorCategory> behaviorCategoryListOrdered = SolarSchoolConfig.Instance.GetBehaviorCategoryListOrdered(SolarSchoolGamePlayModel.Instance.ActivityId);
			if (SolarSchoolSpecialBehaviorCenter.Instance.IsUnlocked())
			{
				return behaviorCategoryListOrdered;
			}
			List<SolarSchoolBehaviorCategory> list = new List<SolarSchoolBehaviorCategory>();
			foreach (SolarSchoolBehaviorCategory item in behaviorCategoryListOrdered)
			{
				if (item.Id != 5)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06038EEC RID: 233196 RVA: 0x00FF21B0 File Offset: 0x00FF03B0
		private void RefreshTabs()
		{
			List<SolarSchoolScheduleTabItemData> list = new List<SolarSchoolScheduleTabItemData>();
			IReadOnlyList<SolarSchoolBehaviorCategory> tabCategories = this.GetTabCategories();
			for (int i = 0; i < tabCategories.Count; i++)
			{
				list.Add(new SolarSchoolScheduleTabItemData
				{
					TabIndex = i,
					IconPath = tabCategories[i].Icon,
					IsSpecialCategory = (tabCategories[i].Id == 5)
				});
			}
			GenericLayout<SolarSchoolScheduleTabItem, SolarSchoolScheduleTabItemData> tabLayout = this.TabLayout;
			if (tabLayout == null)
			{
				return;
			}
			tabLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06038EED RID: 233197 RVA: 0x00FF2230 File Offset: 0x00FF0430
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			int num;
			if (configParams.Length < 2 || !int.TryParse(configParams[1], out num) || num <= 0)
			{
				return null;
			}
			int num2 = num - 1;
			string a = configParams[0];
			UUIItem uuiitem2;
			if (!(a == "ScheduleTab"))
			{
				if (!(a == "ScheduleBehavior"))
				{
					if (!(a == "ScheduleGroup"))
					{
						return null;
					}
					int num3;
					if (configParams.Length < 3 || num2 >= this.ColumnSlots.Length || !int.TryParse(configParams[2], out num3) || num3 <= 0)
					{
						return null;
					}
					GenericLayout<SolarSchoolScheduleGroupItem, SolarSchoolScheduleGroupData> genericLayout = this.GroupLayouts[num2];
					UUIItem uuiitem;
					if (genericLayout == null)
					{
						uuiitem = null;
					}
					else
					{
						SolarSchoolScheduleGroupItem layoutItemByIndex = genericLayout.GetLayoutItemByIndex(num3 - 1);
						uuiitem = ((layoutItemByIndex != null) ? layoutItemByIndex.GetGuideGroupItem() : null);
					}
					uuiitem2 = uuiitem;
				}
				else
				{
					if (this.BehaviorScroll == null || num2 >= this.SelectTabBehaviors.Count)
					{
						return null;
					}
					this.BehaviorScroll.ScrollToGridIndex(num2, false);
					SolarSchoolScheduleBehaviorItem solarSchoolScheduleBehaviorItem = this.BehaviorScroll.UnsafeGetGridProxy(num2, false);
					uuiitem2 = ((solarSchoolScheduleBehaviorItem != null) ? solarSchoolScheduleBehaviorItem.GetGuideBehaviorItem() : null);
				}
			}
			else
			{
				GenericLayout<SolarSchoolScheduleTabItem, SolarSchoolScheduleTabItemData> tabLayout = this.TabLayout;
				UUIItem uuiitem3;
				if (tabLayout == null)
				{
					uuiitem3 = null;
				}
				else
				{
					SolarSchoolScheduleTabItem layoutItemByIndex2 = tabLayout.GetLayoutItemByIndex(num2);
					uuiitem3 = ((layoutItemByIndex2 != null) ? layoutItemByIndex2.GetGuideToggleItem() : null);
				}
				uuiitem2 = uuiitem3;
			}
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}

		// Token: 0x06038EEE RID: 233198 RVA: 0x00FF2354 File Offset: 0x00FF0554
		private void OnClickTab(SolarSchoolScheduleTabItemData data)
		{
			int tabIndex = data.TabIndex;
			if (tabIndex < 0 || tabIndex >= this.GetTabCategories().Count || tabIndex == this.CurrentTabIndex)
			{
				return;
			}
			this.SelectTab(tabIndex, true);
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x06038EEF RID: 233199 RVA: 0x00FF23A1 File Offset: 0x00FF05A1
		private void SelectTab(int index, bool playListAnimation = false)
		{
			this.CurrentTabIndex = index;
			GenericLayout<SolarSchoolScheduleTabItem, SolarSchoolScheduleTabItemData> tabLayout = this.TabLayout;
			if (tabLayout != null)
			{
				tabLayout.SelectGridProxy(index, false);
			}
			this.BuildBehaviorList(index, playListAnimation);
			this.SelectFirstBehavior();
		}

		// Token: 0x06038EF0 RID: 233200 RVA: 0x00FF23CC File Offset: 0x00FF05CC
		private void SelectFirstBehavior()
		{
			if (this.SelectTabBehaviors.Count <= 0)
			{
				this.SelectedBehavior = null;
				LoopScrollView<SolarSchoolScheduleBehaviorItem, SolarSchoolScheduleBehaviorData> behaviorScroll = this.BehaviorScroll;
				if (behaviorScroll != null)
				{
					behaviorScroll.DeselectCurrentGridProxy(false);
				}
				this.RefreshPreviewOnly();
				this.RefreshDetail(null);
				return;
			}
			LoopScrollView<SolarSchoolScheduleBehaviorItem, SolarSchoolScheduleBehaviorData> behaviorScroll2 = this.BehaviorScroll;
			if (behaviorScroll2 != null)
			{
				behaviorScroll2.SelectGridProxy(0, false);
			}
			this.OnSelectBehavior(this.SelectTabBehaviors[0]);
		}

		// Token: 0x06038EF1 RID: 233201 RVA: 0x00FF2434 File Offset: 0x00FF0634
		private void BuildBehaviorList(int tabIndex, bool playListAnimation)
		{
			SolarSchoolScheduleView.<>c__DisplayClass52_0 CS$<>8__locals1 = new SolarSchoolScheduleView.<>c__DisplayClass52_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.playListAnimation = playListAnimation;
			this.SelectTabBehaviors.Clear();
			IReadOnlyList<SolarSchoolBehaviorCategory> tabCategories = this.GetTabCategories();
			string bgNmlPath = string.Empty;
			string bgHoldPath = string.Empty;
			if (tabIndex >= 0 && tabIndex < tabCategories.Count)
			{
				bgNmlPath = (tabCategories[tabIndex].BgNmlPath ?? string.Empty);
				bgHoldPath = (tabCategories[tabIndex].BgHoldPath ?? string.Empty);
			}
			foreach (int behaviorId in this.GetTabBehaviorIds(tabIndex))
			{
				SolarSchoolBehavior? currentLevelRow = SolarSchoolGamePlayModel.Instance.PlayerData.GetCurrentLevelRow(behaviorId);
				if (currentLevelRow != null)
				{
					SolarSchoolScheduleBehaviorData solarSchoolScheduleBehaviorData = new SolarSchoolScheduleBehaviorData
					{
						BehaviorId = behaviorId,
						BehaviorType = (ESolarSchoolBehaviorType)currentLevelRow.Value.BehaviorType,
						AvailableSlots = SolarSchoolUtils.GetAvailableSlots(currentLevelRow.Value),
						StarLevel = currentLevelRow.Value.StarLevel,
						Level = currentLevelRow.Value.Level,
						Name = SolarSchoolUtils.GetTextWithPlaceholder(currentLevelRow.Value.Name),
						Desc = SolarSchoolUtils.GetTextWithPlaceholder(currentLevelRow.Value.DescText),
						IconPath = (currentLevelRow.Value.BehaviourIcon ?? string.Empty),
						BgNmlPath = bgNmlPath,
						BgHoldPath = bgHoldPath
					};
					solarSchoolScheduleBehaviorData.IsAddEnabled = this.CanAddByFatigue(solarSchoolScheduleBehaviorData);
					this.SelectTabBehaviors.Add(solarSchoolScheduleBehaviorData);
				}
			}
			SolarSchoolScheduleView.<>c__DisplayClass52_0 CS$<>8__locals2 = CS$<>8__locals1;
			int num = this.BehaviorRefreshVersion + 1;
			this.BehaviorRefreshVersion = num;
			CS$<>8__locals2.refreshVersion = num;
			UUIInturnAnimController behaviorAnimationController = this.GetBehaviorAnimationController();
			if (behaviorAnimationController != null)
			{
				behaviorAnimationController.Stop();
			}
			LoopScrollView<SolarSchoolScheduleBehaviorItem, SolarSchoolScheduleBehaviorData> behaviorScroll = this.BehaviorScroll;
			if (behaviorScroll != null)
			{
				behaviorScroll.RefreshByData(this.SelectTabBehaviors.ToArray(), false, delegate
				{
					if (!CS$<>8__locals1.<>4__this.ScheduleAnimationsEnabled || CS$<>8__locals1.refreshVersion != CS$<>8__locals1.<>4__this.BehaviorRefreshVersion)
					{
						return;
					}
					if (CS$<>8__locals1.<>4__this.SelectTabBehaviors.Count > 0 && CS$<>8__locals1.<>4__this.SelectedBehavior == CS$<>8__locals1.<>4__this.SelectTabBehaviors[0])
					{
						LoopScrollView<SolarSchoolScheduleBehaviorItem, SolarSchoolScheduleBehaviorData> behaviorScroll2 = CS$<>8__locals1.<>4__this.BehaviorScroll;
						if (behaviorScroll2 != null)
						{
							behaviorScroll2.SelectGridProxy(0, false);
						}
					}
					if (CS$<>8__locals1.playListAnimation)
					{
						UUIInturnAnimController behaviorAnimationController2 = CS$<>8__locals1.<>4__this.GetBehaviorAnimationController();
						if (behaviorAnimationController2 == null)
						{
							return;
						}
						behaviorAnimationController2.Play("", -1, true);
					}
				}, false);
			}
			UUIItem item = base.GetItem(37);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.SelectTabBehaviors.Count == 0);
		}

		// Token: 0x06038EF2 RID: 233202 RVA: 0x00FF267C File Offset: 0x00FF087C
		private IReadOnlyList<int> GetTabBehaviorIds(int tabIndex)
		{
			IReadOnlyList<SolarSchoolBehaviorCategory> tabCategories = this.GetTabCategories();
			if (tabIndex < 0 || tabIndex >= tabCategories.Count)
			{
				return Array.Empty<int>();
			}
			return SolarSchoolGamePlayModel.Instance.GetScheduleAvailableBehaviorsByCategory((ESolarSchoolBehaviorCategory)tabCategories[tabIndex].Id);
		}

		// Token: 0x06038EF3 RID: 233203 RVA: 0x00FF26BC File Offset: 0x00FF08BC
		[NullableContext(2)]
		private UUIInturnAnimController GetBehaviorAnimationController()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(35);
			object obj;
			if (scrollViewWithScrollbar == null)
			{
				obj = null;
			}
			else
			{
				AUIBaseActor auibaseActor = scrollViewWithScrollbar.Content.Get();
				obj = ((auibaseActor != null) ? auibaseActor.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null);
			}
			return obj as UUIInturnAnimController;
		}

		// Token: 0x06038EF4 RID: 233204 RVA: 0x00FF2700 File Offset: 0x00FF0900
		private void OnClickBehavior(SolarSchoolScheduleBehaviorData data)
		{
			SolarSchoolScheduleBehaviorData selectedBehavior = this.SelectedBehavior;
			int? num = (selectedBehavior != null) ? new int?(selectedBehavior.BehaviorId) : null;
			int behaviorId = data.BehaviorId;
			bool flag = !(num.GetValueOrDefault() == behaviorId & num != null);
			this.OnSelectBehavior(data);
			if (flag)
			{
				base.PlayOrReplaySequence("Switch", false, null);
			}
		}

		// Token: 0x06038EF5 RID: 233205 RVA: 0x00FF2767 File Offset: 0x00FF0967
		private void OnSelectBehavior(SolarSchoolScheduleBehaviorData data)
		{
			this.SelectedBehavior = data;
			this.RefreshPreviewOnly();
			this.RefreshDetail(data);
		}

		// Token: 0x06038EF6 RID: 233206 RVA: 0x00FF2780 File Offset: 0x00FF0980
		private void OnClickAddBehavior(SolarSchoolScheduleBehaviorData data)
		{
			if (!this.IsCurrentWeek)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_Schedule_OnlyCurrentWeek", Array.Empty<object>());
				return;
			}
			if (!this.CanAddByFatigue(data))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_Tired_2", Array.Empty<object>());
				return;
			}
			bool flag;
			if (data.BehaviorType == ESolarSchoolBehaviorType.Special)
			{
				ESolarSchoolTimeSlot slot;
				int[] weekdays;
				if (!this.TryGetSpecialPlacement(data, out slot, out weekdays))
				{
					return;
				}
				flag = this.TempData.SetSpecialBehavior(data.BehaviorId, slot, weekdays, false);
				if (!flag)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_Schedule_SlotFull", Array.Empty<object>());
					return;
				}
			}
			else
			{
				int weekday;
				ESolarSchoolTimeSlot slot2;
				if (!this.TryFindNextEmptyCell(data, out weekday, out slot2))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_Schedule_SlotFull", Array.Empty<object>());
					return;
				}
				flag = this.TempData.SetNormalBehavior(weekday, slot2, data.BehaviorId);
			}
			if (flag)
			{
				this.TrimFatigueOverflow();
				this.RefreshLeftColumns(false, false);
			}
		}

		// Token: 0x06038EF7 RID: 233207 RVA: 0x00FF2854 File Offset: 0x00FF0A54
		private unsafe bool TryGetSpecialSlot(SolarSchoolScheduleBehaviorData data, out ESolarSchoolTimeSlot slot)
		{
			slot = ESolarSchoolTimeSlot.None;
			if (data.AvailableSlots.Length != 1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 特批行为的 AvailableTimeSlot 必须且只能配一个时段";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", data.BehaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("slotCount", data.AvailableSlots.Length);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			slot = data.AvailableSlots[0];
			return true;
		}

		// Token: 0x06038EF8 RID: 233208 RVA: 0x00FF28E8 File Offset: 0x00FF0AE8
		private bool TryGetSpecialPlacement(SolarSchoolScheduleBehaviorData data, out ESolarSchoolTimeSlot slot, out int[] weekdays)
		{
			weekdays = Array.Empty<int>();
			if (!this.TryGetSpecialSlot(data, out slot))
			{
				return false;
			}
			SolarSchoolBehavior? currentLevelRow = SolarSchoolGamePlayModel.Instance.PlayerData.GetCurrentLevelRow(data.BehaviorId);
			weekdays = (((currentLevelRow != null) ? currentLevelRow.GetValueOrDefault().GetOccupyDayOfWeekArray() : null) ?? Array.Empty<int>());
			if (weekdays.Length == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 特批行为未配 OccupyDayOfWeek";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("behaviorId", data.BehaviorId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return true;
		}

		// Token: 0x06038EF9 RID: 233209 RVA: 0x00FF2980 File Offset: 0x00FF0B80
		private bool TryFindNextEmptyCell(SolarSchoolScheduleBehaviorData data, out int weekday, out ESolarSchoolTimeSlot slot)
		{
			foreach (ESolarSchoolTimeSlot esolarSchoolTimeSlot in this.ColumnSlots)
			{
				if (this.CanPlaceInColumn(data, esolarSchoolTimeSlot))
				{
					int num = this.FindNextEmptyWeekday(esolarSchoolTimeSlot);
					if (num > 0)
					{
						weekday = num;
						slot = esolarSchoolTimeSlot;
						return true;
					}
				}
			}
			weekday = 0;
			slot = ESolarSchoolTimeSlot.None;
			return false;
		}

		// Token: 0x06038EFA RID: 233210 RVA: 0x00FF29CC File Offset: 0x00FF0BCC
		private bool CanPlaceInColumn(SolarSchoolScheduleBehaviorData data, ESolarSchoolTimeSlot columnSlot)
		{
			ESolarSchoolTimeSlot[] availableSlots = data.AvailableSlots;
			for (int i = 0; i < availableSlots.Length; i++)
			{
				if (availableSlots[i] == columnSlot)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06038EFB RID: 233211 RVA: 0x00FF29F8 File Offset: 0x00FF0BF8
		private int FindNextEmptyWeekday(ESolarSchoolTimeSlot slot)
		{
			SolarSchoolScheduleData scheduleData = SolarSchoolGamePlayModel.Instance.ScheduleData;
			for (int i = 1; i <= 5; i++)
			{
				if (scheduleData.IsNormalDay(this.WeekOffset, i) && this.TempData.IsSlotAtOrAfterNow(i, slot) && this.TempData.GetScheduledBehaviorId(i, slot) == 0)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x06038EFC RID: 233212 RVA: 0x00FF2A4C File Offset: 0x00FF0C4C
		private HashSet<int> ComputeHighlightWeekdays(SolarSchoolScheduleBehaviorData behaviorData, out ESolarSchoolTimeSlot highlightSlot)
		{
			HashSet<int> hashSet = new HashSet<int>();
			highlightSlot = ESolarSchoolTimeSlot.None;
			int item2;
			if (behaviorData.BehaviorType == ESolarSchoolBehaviorType.Special)
			{
				int[] array;
				int i;
				if (!this.TryGetSpecialPlacement(behaviorData, out highlightSlot, out array) || !this.TempData.CanSetSpecialBehavior(behaviorData.BehaviorId, highlightSlot, array, out i))
				{
					highlightSlot = ESolarSchoolTimeSlot.None;
					return hashSet;
				}
				foreach (int item in array)
				{
					hashSet.Add(item);
				}
			}
			else if (this.TryFindNextEmptyCell(behaviorData, out item2, out highlightSlot))
			{
				hashSet.Add(item2);
			}
			return hashSet;
		}

		// Token: 0x06038EFD RID: 233213 RVA: 0x00FF2ACC File Offset: 0x00FF0CCC
		private bool CanAddByFatigue(SolarSchoolScheduleBehaviorData data)
		{
			if (data.BehaviorType == ESolarSchoolBehaviorType.Special)
			{
				ESolarSchoolTimeSlot slot;
				int[] weekdays;
				return !this.TryGetSpecialPlacement(data, out slot, out weekdays) || this.TempData.CanPlaceSpecial(data.BehaviorId, slot, weekdays);
			}
			int weekday;
			ESolarSchoolTimeSlot slot2;
			return !this.TryFindNextEmptyCell(data, out weekday, out slot2) || this.TempData.CanPlaceNormal(data.BehaviorId, weekday, slot2);
		}

		// Token: 0x06038EFE RID: 233214 RVA: 0x00FF2B28 File Offset: 0x00FF0D28
		private void RefreshBehaviorAddEnabled()
		{
			foreach (SolarSchoolScheduleBehaviorData solarSchoolScheduleBehaviorData in this.SelectTabBehaviors)
			{
				solarSchoolScheduleBehaviorData.IsAddEnabled = this.CanAddByFatigue(solarSchoolScheduleBehaviorData);
			}
			if (this.BehaviorScroll == null)
			{
				return;
			}
			int num = Math.Min(this.BehaviorScroll.GetDisplayGridEndIndex(), this.SelectTabBehaviors.Count - 1);
			for (int i = Math.Max(0, this.BehaviorScroll.GetDisplayGridStartIndex()); i <= num; i++)
			{
				SolarSchoolScheduleBehaviorItem solarSchoolScheduleBehaviorItem = this.BehaviorScroll.UnsafeGetGridProxy(i, false);
				if (solarSchoolScheduleBehaviorItem != null)
				{
					solarSchoolScheduleBehaviorItem.SetAddEnabled(this.SelectTabBehaviors[i].IsAddEnabled);
				}
			}
		}

		// Token: 0x06038EFF RID: 233215 RVA: 0x00FF2BF0 File Offset: 0x00FF0DF0
		private void TrimFatigueOverflow()
		{
			if (this.TempData.TrimOverflow() > 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_Tired_3", Array.Empty<object>());
			}
		}

		// Token: 0x06038F00 RID: 233216 RVA: 0x00FF2C14 File Offset: 0x00FF0E14
		private int GetDisplayFatigue()
		{
			return this.TempData.GetProjectedFatigue();
		}

		// Token: 0x06038F01 RID: 233217 RVA: 0x00FF2C24 File Offset: 0x00FF0E24
		private void RefreshFatiguePreview()
		{
			this.IncreasedAttrs.Clear();
			SolarSchoolCaptionItem caption = this.Caption;
			if (caption != null)
			{
				caption.SetFatiguePreview(this.TempData.GetProjectedFatigue());
			}
			foreach (KeyValuePair<ESolarSchoolSecondAttr, int> keyValuePair in this.TempData.GetProjectedAttrDeltas())
			{
				ESolarSchoolSecondAttr esolarSchoolSecondAttr;
				int num;
				keyValuePair.Deconstruct(out esolarSchoolSecondAttr, out num);
				ESolarSchoolSecondAttr item = esolarSchoolSecondAttr;
				if (num > 0)
				{
					this.IncreasedAttrs.Add(item);
				}
			}
			this.RefreshAttrs();
		}

		// Token: 0x06038F02 RID: 233218 RVA: 0x00FF2CC4 File Offset: 0x00FF0EC4
		private void OnClickPreWeek()
		{
			this.TryChangeWeek(this.WeekOffset - 1);
		}

		// Token: 0x06038F03 RID: 233219 RVA: 0x00FF2CD4 File Offset: 0x00FF0ED4
		private void OnClickNextWeek()
		{
			this.TryChangeWeek(this.WeekOffset + 1);
		}

		// Token: 0x06038F04 RID: 233220 RVA: 0x00FF2CE4 File Offset: 0x00FF0EE4
		private void TryChangeWeek(int offset)
		{
			int num = 3;
			if (offset < -num || offset > num || offset == this.WeekOffset)
			{
				return;
			}
			this.WeekOffset = offset;
			if (this.IsCurrentWeek)
			{
				this.TrimFatigueOverflow();
			}
			this.RefreshWeekNav();
			this.RefreshLeftColumns(true, true);
		}

		// Token: 0x06038F05 RID: 233221 RVA: 0x00FF2D2C File Offset: 0x00FF0F2C
		private void RefreshWeekNav()
		{
			int num = 3;
			UUIButtonComponent button = base.GetButton(18);
			if (button != null)
			{
				button.SetSelfInteractive(this.WeekOffset > -num);
			}
			UUIButtonComponent button2 = base.GetButton(19);
			if (button2 != null)
			{
				button2.SetSelfInteractive(this.WeekOffset < num);
			}
			UUIButtonComponent button3 = base.GetButton(38);
			if (button3 != null)
			{
				button3.SetSelfInteractive(this.IsCurrentWeek);
			}
			UUIText text = base.GetText(20);
			if (text != null)
			{
				text.SetText(this.GetWeekPeriodText(), true);
			}
			this.RefreshWeekdayDates();
			SolarSchoolBtnItem useLastWeekBtn = this.UseLastWeekBtn;
			if (useLastWeekBtn == null)
			{
				return;
			}
			useLastWeekBtn.SetEnable(SolarSchoolGamePlayModel.Instance.ScheduleData.HasLastWeekData);
		}

		// Token: 0x06038F06 RID: 233222 RVA: 0x00FF2DCC File Offset: 0x00FF0FCC
		private void RefreshWeekdayDates()
		{
			SolarSchoolTimeData timeData = SolarSchoolGamePlayModel.Instance.TimeData;
			int viewMondayDayIndex = this.GetViewMondayDayIndex();
			for (int i = 0; i < 5; i++)
			{
				int item = timeData.GetMonthDay(viewMondayDayIndex + i).Item2;
				UUIArtText artText = base.GetArtText(42 + i);
				if (artText != null)
				{
					artText.SetText(item.ToString("D2"));
				}
			}
		}

		// Token: 0x06038F07 RID: 233223 RVA: 0x00FF2E28 File Offset: 0x00FF1028
		private void RefreshCurrentDate()
		{
			SolarSchoolTimeData timeData = SolarSchoolGamePlayModel.Instance.TimeData;
			UUIText text = base.GetText(39);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(timeData.Month, "D2");
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(timeData.Day, "D2");
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUIArtText artText = base.GetArtText(41);
			if (artText != null)
			{
				artText.SetText(timeData.Day.ToString("D2"));
			}
			UUIText text2 = base.GetText(40);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(SolarSchoolUtils.GetWeekdayText(timeData.DayOfWeek), true);
		}

		// Token: 0x06038F08 RID: 233224 RVA: 0x00FF2ED8 File Offset: 0x00FF10D8
		private unsafe string GetWeekPeriodText()
		{
			SolarSchoolTimeData timeData = SolarSchoolGamePlayModel.Instance.TimeData;
			int viewMondayDayIndex = this.GetViewMondayDayIndex();
			ValueTuple<int, int> monthDay = timeData.GetMonthDay(viewMondayDayIndex);
			int item = monthDay.Item1;
			int item2 = monthDay.Item2;
			ValueTuple<int, int> monthDay2 = timeData.GetMonthDay(viewMondayDayIndex + 5 - 1);
			int item3 = monthDay2.Item1;
			int item4 = monthDay2.Item2;
			string format = ConfigMultiTextLang.GetLocalTextNew("SolarSchool_Schedule_WeekPeriod", null) ?? string.Empty;
			<>y__InlineArray4<object> <>y__InlineArray = default(<>y__InlineArray4<object>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<object>, object>(ref <>y__InlineArray, 0) = item.ToString("D2");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<object>, object>(ref <>y__InlineArray, 1) = item2.ToString("D2");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<object>, object>(ref <>y__InlineArray, 2) = item3.ToString("D2");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<object>, object>(ref <>y__InlineArray, 3) = item4.ToString("D2");
			return string.Format(format, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<object>, object>(<>y__InlineArray, 4));
		}

		// Token: 0x06038F09 RID: 233225 RVA: 0x00FF2F9F File Offset: 0x00FF119F
		private int GetViewMondayDayIndex()
		{
			return SolarSchoolGamePlayModel.Instance.TimeData.CurrentMondayDayIndex + this.WeekOffset * 7;
		}

		// Token: 0x06038F0A RID: 233226 RVA: 0x00FF2FBC File Offset: 0x00FF11BC
		private void RefreshLeftColumns(bool playAllItems = false, bool resetItemState = false)
		{
			Dictionary<ValueTuple<ESolarSchoolTimeSlot, int>, SolarSchoolScheduleCellData> dictionary = new Dictionary<ValueTuple<ESolarSchoolTimeSlot, int>, SolarSchoolScheduleCellData>();
			for (int i = 0; i < this.ColumnSlots.Length; i++)
			{
				List<SolarSchoolScheduleGroupData> list = this.BuildGroups(this.ColumnSlots[i]);
				foreach (SolarSchoolScheduleGroupData solarSchoolScheduleGroupData in list)
				{
					foreach (SolarSchoolScheduleCellData solarSchoolScheduleCellData in solarSchoolScheduleGroupData.Cells)
					{
						ValueTuple<ESolarSchoolTimeSlot, int> key = new ValueTuple<ESolarSchoolTimeSlot, int>(solarSchoolScheduleCellData.Slot, solarSchoolScheduleCellData.Weekday);
						SolarSchoolScheduleCellData solarSchoolScheduleCellData2;
						this.PreviousCells.TryGetValue(key, out solarSchoolScheduleCellData2);
						bool flag = solarSchoolScheduleCellData2 == null || solarSchoolScheduleCellData2.BehaviorId != solarSchoolScheduleCellData.BehaviorId || solarSchoolScheduleCellData2.State != solarSchoolScheduleCellData.State || solarSchoolScheduleCellData2.IsSpecialDay != solarSchoolScheduleCellData.IsSpecialDay;
						bool flag2 = flag && solarSchoolScheduleCellData.State == ESolarSchoolCellState.Scheduled && (solarSchoolScheduleCellData2 == null || solarSchoolScheduleCellData2.State == ESolarSchoolCellState.Empty || solarSchoolScheduleCellData2.BehaviorId != solarSchoolScheduleCellData.BehaviorId);
						solarSchoolScheduleCellData.PlayCancelAnimation = (!playAllItems && flag && solarSchoolScheduleCellData2 != null && !solarSchoolScheduleCellData2.IsSpecialDay && !solarSchoolScheduleCellData.IsSpecialDay && (solarSchoolScheduleCellData2.State == ESolarSchoolCellState.Empty || solarSchoolScheduleCellData.State == ESolarSchoolCellState.Empty));
						solarSchoolScheduleCellData.PlayRefreshAnimation = (playAllItems || flag2 || solarSchoolScheduleCellData.PlayCancelAnimation);
						solarSchoolScheduleCellData.PreviousBgPath = (((solarSchoolScheduleCellData2 != null) ? solarSchoolScheduleCellData2.BgPath : null) ?? string.Empty);
						solarSchoolScheduleCellData.WasPreviewCovered = (!resetItemState && solarSchoolScheduleCellData2 != null && solarSchoolScheduleCellData2.IsPreviewCovered);
						dictionary[key] = solarSchoolScheduleCellData;
					}
				}
				GenericLayout<SolarSchoolScheduleGroupItem, SolarSchoolScheduleGroupData> genericLayout = this.GroupLayouts[i];
				List<SolarSchoolScheduleGroupItem> list2 = (genericLayout != null) ? genericLayout.GetLayoutItemList() : null;
				if (list2 != null)
				{
					for (int j = list.Count; j < list2.Count; j++)
					{
						list2[j].Clear();
					}
				}
				int currentColumnIndex = i;
				GenericLayout<SolarSchoolScheduleGroupItem, SolarSchoolScheduleGroupData> genericLayout2 = this.GroupLayouts[i];
				if (genericLayout2 != null)
				{
					genericLayout2.RefreshByData(list, delegate
					{
						if (this.ScheduleAnimationsEnabled)
						{
							this.RefreshPreviewCoveredCells(currentColumnIndex, this.GetPreviewCoveredWeekdays(this.ColumnSlots[currentColumnIndex]));
						}
					}, false);
				}
			}
			this.PreviousCells.Clear();
			foreach (KeyValuePair<ValueTuple<ESolarSchoolTimeSlot, int>, SolarSchoolScheduleCellData> keyValuePair in dictionary)
			{
				this.PreviousCells.Add(keyValuePair.Key, keyValuePair.Value);
			}
			this.RefreshSpecialDays();
			this.RefreshPreviewOnly();
			this.RefreshSaveBtnState();
			this.RefreshBehaviorAddEnabled();
			this.RefreshFatiguePreview();
			this.RefreshDetail(this.SelectedBehavior);
		}

		// Token: 0x06038F0B RID: 233227 RVA: 0x00FF32C8 File Offset: 0x00FF14C8
		[NullableContext(2)]
		private HashSet<int> GetPreviewCoveredWeekdays(ESolarSchoolTimeSlot slot)
		{
			if (!this.IsCurrentWeek || this.SelectedBehavior == null)
			{
				return null;
			}
			ESolarSchoolTimeSlot esolarSchoolTimeSlot;
			HashSet<int> hashSet = this.ComputeHighlightWeekdays(this.SelectedBehavior, out esolarSchoolTimeSlot);
			if (esolarSchoolTimeSlot != slot || hashSet.Count <= 0)
			{
				return null;
			}
			return hashSet;
		}

		// Token: 0x06038F0C RID: 233228 RVA: 0x00FF3308 File Offset: 0x00FF1508
		private void RefreshSpecialDays()
		{
			SolarSchoolScheduleData scheduleData = SolarSchoolGamePlayModel.Instance.ScheduleData;
			for (int i = 0; i < 5; i++)
			{
				SolarSchoolScheduleSpecialDayItem solarSchoolScheduleSpecialDayItem = this.SpecialDayItems[i];
				if (solarSchoolScheduleSpecialDayItem != null)
				{
					int weekday = i + 1;
					string nameTextKey;
					if (!scheduleData.IsNormalDay(this.WeekOffset, weekday))
					{
						nameTextKey = this.GetSpecialDayNameKey(scheduleData.GetWeekInstanceId(this.WeekOffset, weekday));
					}
					else
					{
						if (!scheduleData.IsSkippedDay(this.WeekOffset, weekday))
						{
							solarSchoolScheduleSpecialDayItem.SetUiActive(false);
							goto IL_77;
						}
						nameTextKey = this.GetSkippedDayNameKey(weekday);
					}
					solarSchoolScheduleSpecialDayItem.SetUiActive(true);
					solarSchoolScheduleSpecialDayItem.Refresh(nameTextKey);
				}
				IL_77:;
			}
		}

		// Token: 0x06038F0D RID: 233229 RVA: 0x00FF3394 File Offset: 0x00FF1594
		[NullableContext(2)]
		private string GetSpecialDayNameKey(int instanceId)
		{
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			if (SolarSchoolConfig.Instance.GetInstance(activityId, instanceId) == null)
			{
				return null;
			}
			SolarSchoolInstance? solarSchoolInstance;
			return solarSchoolInstance.GetValueOrDefault().Name;
		}

		// Token: 0x06038F0E RID: 233230 RVA: 0x00FF33D4 File Offset: 0x00FF15D4
		[NullableContext(2)]
		private string GetSkippedDayNameKey(int weekday)
		{
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			int dayIndex = this.GetViewMondayDayIndex() + weekday - 1;
			if (SolarSchoolConfig.Instance.GetCalendarDay(activityId, dayIndex) == null)
			{
				return null;
			}
			SolarSchoolCalendar? solarSchoolCalendar;
			return solarSchoolCalendar.GetValueOrDefault().SkipDesc;
		}

		// Token: 0x06038F0F RID: 233231 RVA: 0x00FF3420 File Offset: 0x00FF1620
		private bool IsSpecialDay(int weekday)
		{
			SolarSchoolScheduleData scheduleData = SolarSchoolGamePlayModel.Instance.ScheduleData;
			return !scheduleData.IsNormalDay(this.WeekOffset, weekday) || scheduleData.IsSkippedDay(this.WeekOffset, weekday);
		}

		// Token: 0x06038F10 RID: 233232 RVA: 0x00FF3458 File Offset: 0x00FF1658
		private void RefreshPreviewOnly()
		{
			ESolarSchoolTimeSlot esolarSchoolTimeSlot = ESolarSchoolTimeSlot.None;
			HashSet<int> hashSet = (this.IsCurrentWeek && this.SelectedBehavior != null) ? this.ComputeHighlightWeekdays(this.SelectedBehavior, out esolarSchoolTimeSlot) : new HashSet<int>();
			for (int i = 0; i < this.ColumnSlots.Length; i++)
			{
				HashSet<int> hashSet2 = (this.ColumnSlots[i] == esolarSchoolTimeSlot && hashSet.Count > 0) ? hashSet : null;
				this.RefreshPreviewFrame(i, hashSet2);
				this.RefreshPreviewCoveredCells(i, hashSet2);
			}
			this.RefreshPreviewNotice(esolarSchoolTimeSlot, hashSet);
		}

		// Token: 0x06038F11 RID: 233233 RVA: 0x00FF34D8 File Offset: 0x00FF16D8
		[NullableContext(2)]
		private void RefreshPreviewCoveredCells(int columnIndex, HashSet<int> coveredWeekdays)
		{
			GenericLayout<SolarSchoolScheduleGroupItem, SolarSchoolScheduleGroupData> genericLayout = this.GroupLayouts[columnIndex];
			List<SolarSchoolScheduleGroupItem> list = (genericLayout != null) ? genericLayout.GetLayoutItemList() : null;
			if (list == null)
			{
				return;
			}
			foreach (SolarSchoolScheduleGroupItem solarSchoolScheduleGroupItem in list)
			{
				solarSchoolScheduleGroupItem.SetPreviewCoveredWeekdays(coveredWeekdays);
			}
		}

		// Token: 0x06038F12 RID: 233234 RVA: 0x00FF3540 File Offset: 0x00FF1740
		private List<SolarSchoolScheduleGroupData> BuildGroups(ESolarSchoolTimeSlot slot)
		{
			List<SolarSchoolScheduleGroupData> list = new List<SolarSchoolScheduleGroupData>();
			HashSet<int> previewCoveredWeekdays = this.GetPreviewCoveredWeekdays(slot);
			int i = 1;
			while (i <= 5)
			{
				int viewBehaviorId = this.GetViewBehaviorId(i, slot);
				ESolarSchoolBehaviorType? viewBehaviorType = this.GetViewBehaviorType(viewBehaviorId);
				if (viewBehaviorId != 0 && viewBehaviorType.GetValueOrDefault() == ESolarSchoolBehaviorType.Special)
				{
					SolarSchoolScheduleGroupData solarSchoolScheduleGroupData = new SolarSchoolScheduleGroupData
					{
						Slot = slot,
						BehaviorId = viewBehaviorId,
						BehaviorType = viewBehaviorType,
						FirstWeekday = i,
						CanDelete = this.CanRemoveViewSlot(i, slot)
					};
					while (i <= 5 && this.GetViewBehaviorId(i, slot) == viewBehaviorId)
					{
						solarSchoolScheduleGroupData.Cells.Add(this.BuildCellData(i, slot, previewCoveredWeekdays));
						i++;
					}
					list.Add(solarSchoolScheduleGroupData);
				}
				else
				{
					SolarSchoolScheduleGroupData solarSchoolScheduleGroupData2 = new SolarSchoolScheduleGroupData
					{
						Slot = slot,
						BehaviorId = viewBehaviorId,
						BehaviorType = viewBehaviorType,
						FirstWeekday = i,
						CanDelete = this.CanRemoveViewSlot(i, slot),
						IsEmptyClickable = (viewBehaviorId == 0 && this.IsEmptyCellClickable(i, slot))
					};
					solarSchoolScheduleGroupData2.Cells.Add(this.BuildCellData(i, slot, previewCoveredWeekdays));
					list.Add(solarSchoolScheduleGroupData2);
					i++;
				}
			}
			return list;
		}

		// Token: 0x06038F13 RID: 233235 RVA: 0x00FF3658 File Offset: 0x00FF1858
		private SolarSchoolScheduleCellData BuildCellData(int weekday, ESolarSchoolTimeSlot slot, [Nullable(2)] HashSet<int> coveredWeekdays)
		{
			int viewBehaviorId = this.GetViewBehaviorId(weekday, slot);
			string text = string.Empty;
			ESolarSchoolCellState state;
			if (viewBehaviorId != 0)
			{
				state = ESolarSchoolCellState.Scheduled;
				text = SolarSchoolGamePlayModel.Instance.PlayerData.GetBehaviorNameWithLevel(viewBehaviorId);
			}
			else
			{
				state = ESolarSchoolCellState.Empty;
			}
			return new SolarSchoolScheduleCellData
			{
				Weekday = weekday,
				Slot = slot,
				BehaviorId = viewBehaviorId,
				BehaviorType = this.GetViewBehaviorType(viewBehaviorId),
				State = state,
				Text = text,
				BgPath = this.GetCellBgPath(viewBehaviorId, weekday, slot),
				CanDelete = this.CanRemoveViewSlot(weekday, slot),
				IsPreviewCovered = (coveredWeekdays != null && coveredWeekdays.Contains(weekday)),
				IsSpecialDay = this.IsSpecialDay(weekday)
			};
		}

		// Token: 0x06038F14 RID: 233236 RVA: 0x00FF3700 File Offset: 0x00FF1900
		private string GetCellBgPath(int behaviorId, int weekday, ESolarSchoolTimeSlot slot)
		{
			string text;
			if (!this.IsCurrentWeek || !this.TempData.IsSlotAtOrAfterNow(weekday, slot))
			{
				text = "T_ScheduleCellBgOtherWeek";
			}
			else if (behaviorId == 0)
			{
				text = "T_ScheduleCellBgEmpty";
			}
			else
			{
				ESolarSchoolBehaviorType? viewBehaviorType = this.GetViewBehaviorType(behaviorId);
				string text2;
				if (viewBehaviorType != null)
				{
					switch (viewBehaviorType.GetValueOrDefault())
					{
					case ESolarSchoolBehaviorType.Fixed:
						text2 = "T_ScheduleCellBgFixed";
						goto IL_83;
					case ESolarSchoolBehaviorType.Low:
						text2 = "T_ScheduleCellBgLow";
						goto IL_83;
					case ESolarSchoolBehaviorType.Normal:
						text2 = "T_ScheduleCellBgNormal";
						goto IL_83;
					case ESolarSchoolBehaviorType.Special:
						text2 = "T_ScheduleCellBgSpecial";
						goto IL_83;
					}
				}
				text2 = string.Empty;
				IL_83:
				text = text2;
				if (string.IsNullOrEmpty(text))
				{
					return string.Empty;
				}
			}
			return UiResourceConfig.Instance.GetResourcePath(text);
		}

		// Token: 0x06038F15 RID: 233237 RVA: 0x00FF37AC File Offset: 0x00FF19AC
		private int GetViewBehaviorId(int weekday, ESolarSchoolTimeSlot slot)
		{
			SolarSchoolScheduleData scheduleData = SolarSchoolGamePlayModel.Instance.ScheduleData;
			if (this.IsSpecialDay(weekday))
			{
				return 0;
			}
			if (this.IsCurrentWeek)
			{
				return this.TempData.GetScheduledBehaviorId(weekday, slot);
			}
			if (this.WeekOffset < 0)
			{
				return scheduleData.GetHistoryBehaviorId(-this.WeekOffset, weekday, slot);
			}
			int dayIndex = this.GetViewMondayDayIndex() + (weekday - 1);
			return SolarSchoolGamePlayModel.Instance.GetAutoPlacedBehaviorId(dayIndex, slot);
		}

		// Token: 0x06038F16 RID: 233238 RVA: 0x00FF3818 File Offset: 0x00FF1A18
		private ESolarSchoolBehaviorType? GetViewBehaviorType(int behaviorId)
		{
			if (behaviorId == 0)
			{
				return null;
			}
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			return SolarSchoolConfig.Instance.GetBehaviorType(activityId, behaviorId);
		}

		// Token: 0x06038F17 RID: 233239 RVA: 0x00FF3849 File Offset: 0x00FF1A49
		private bool CanRemoveViewSlot(int weekday, ESolarSchoolTimeSlot slot)
		{
			return this.IsCurrentWeek && this.TempData.CanRemoveSlot(weekday, slot);
		}

		// Token: 0x06038F18 RID: 233240 RVA: 0x00FF3862 File Offset: 0x00FF1A62
		private bool IsEmptyCellClickable(int weekday, ESolarSchoolTimeSlot slot)
		{
			return this.IsCurrentWeek && !this.IsSpecialDay(weekday) && this.TempData.IsSlotAtOrAfterNow(weekday, slot);
		}

		// Token: 0x06038F19 RID: 233241 RVA: 0x00FF3884 File Offset: 0x00FF1A84
		[NullableContext(2)]
		private void RefreshPreviewFrame(int columnIndex, HashSet<int> highlightWeekdays)
		{
			int name = (columnIndex == 0) ? 8 : 11;
			UUISprite sprite = base.GetSprite(name);
			if (sprite == null)
			{
				return;
			}
			if (highlightWeekdays == null || highlightWeekdays.Count == 0)
			{
				return;
			}
			int num = int.MaxValue;
			int num2 = int.MinValue;
			foreach (int num3 in highlightWeekdays)
			{
				if (num3 < num)
				{
					num = num3;
				}
				if (num3 > num2)
				{
					num2 = num3;
				}
			}
			float num4 = 128f;
			float num5 = 8f;
			float stretchTop = (float)(num - 1) * num4 - num5;
			float stretchBottom = (float)(5 - num2) * num4 - num5;
			sprite.SetStretchTop(stretchTop);
			sprite.SetStretchBottom(stretchBottom);
		}

		// Token: 0x06038F1A RID: 233242 RVA: 0x00FF3940 File Offset: 0x00FF1B40
		private void RefreshPreviewNotice(ESolarSchoolTimeSlot highlightSlot, HashSet<int> highlightWeekdays)
		{
			int num = 0;
			foreach (int num2 in highlightWeekdays)
			{
				num |= 1 << num2;
			}
			ESolarSchoolTimeSlot esolarSchoolTimeSlot = (num == 0) ? ESolarSchoolTimeSlot.None : highlightSlot;
			if (esolarSchoolTimeSlot == this.PreviewSlot && num == this.PreviewWeekdayMask)
			{
				return;
			}
			bool flag = this.PreviewSlot > ESolarSchoolTimeSlot.None;
			this.PreviewSlot = esolarSchoolTimeSlot;
			this.PreviewWeekdayMask = num;
			if (esolarSchoolTimeSlot == ESolarSchoolTimeSlot.None)
			{
				if (flag)
				{
					this.StopPreviewNoticeSequences();
					base.PlayOrReplaySequence("NoticeClose", false, null);
				}
				return;
			}
			this.StopPreviewNoticeSequences();
			UUISprite sprite = base.GetSprite(8);
			if (sprite != null)
			{
				sprite.SetUIActive(esolarSchoolTimeSlot == ESolarSchoolTimeSlot.Day);
			}
			UUISprite sprite2 = base.GetSprite(11);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(esolarSchoolTimeSlot == ESolarSchoolTimeSlot.Dusk);
			}
			base.PlayOrReplaySequence("Notice", false, null);
		}

		// Token: 0x06038F1B RID: 233243 RVA: 0x00FF3A34 File Offset: 0x00FF1C34
		private void StopPreviewNoticeSequences()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.StopSequenceByKey("Notice", false, false);
			}
			AUIBaseActor auibaseActor = base.GetRootActor() as AUIBaseActor;
			if (auibaseActor != null)
			{
				auibaseActor.StopSequenceByKey("NoticeLoop");
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 == null)
			{
				return;
			}
			uiViewSequence2.StopSequenceByKey("NoticeClose", false, false);
		}

		// Token: 0x06038F1C RID: 233244 RVA: 0x00FF3A8B File Offset: 0x00FF1C8B
		private void ResetPreviewNotice()
		{
			this.StopPreviewNoticeSequences();
			this.PreviewSlot = ESolarSchoolTimeSlot.None;
			this.PreviewWeekdayMask = 0;
			UUISprite sprite = base.GetSprite(8);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUISprite sprite2 = base.GetSprite(11);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetUIActive(false);
		}

		// Token: 0x06038F1D RID: 233245 RVA: 0x00FF3AC8 File Offset: 0x00FF1CC8
		private void OnClickDeleteGroup(SolarSchoolScheduleGroupData group)
		{
			if (group.BehaviorId == 0 || !this.IsCurrentWeek)
			{
				return;
			}
			bool flag;
			if (group.BehaviorType.GetValueOrDefault() == ESolarSchoolBehaviorType.Special)
			{
				flag = this.TempData.RemoveSpecialBehavior(group.BehaviorId, false);
			}
			else
			{
				flag = this.TempData.SetNormalBehavior(group.FirstWeekday, group.Slot, 0);
			}
			if (flag)
			{
				this.TrimFatigueOverflow();
				this.RefreshLeftColumns(false, false);
			}
		}

		// Token: 0x06038F1E RID: 233246 RVA: 0x00FF3B33 File Offset: 0x00FF1D33
		private void OnClickReset()
		{
			if (!this.IsCurrentWeek)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_Schedule_OnlyCurrentWeek", Array.Empty<object>());
				return;
			}
			this.TempData.ResetEditable();
			this.RefreshLeftColumns(true, false);
		}

		// Token: 0x06038F1F RID: 233247 RVA: 0x00FF3B68 File Offset: 0x00FF1D68
		private void OnClickUseLastWeek()
		{
			if (!this.IsCurrentWeek)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_Schedule_OnlyCurrentWeek", Array.Empty<object>());
				return;
			}
			if (!SolarSchoolGamePlayModel.Instance.ScheduleData.HasLastWeekData)
			{
				return;
			}
			this.TempData.ResetEditable();
			HashSet<int> availableIds = this.CollectAvailableBehaviorIds();
			this.FillLastWeekSpecials(availableIds);
			this.FillLastWeekNormals(availableIds);
			int num = this.TempData.TrimOverflow();
			this.RefreshLeftColumns(true, false);
			ScrollingTipsController.Instance.ShowTipsByTextId((num > 0) ? "SolarSchool_Tired_3" : "SolarSchool_Schedule_UseLastWeekSuccess", Array.Empty<object>());
		}

		// Token: 0x06038F20 RID: 233248 RVA: 0x00FF3BF8 File Offset: 0x00FF1DF8
		private HashSet<int> CollectAvailableBehaviorIds()
		{
			HashSet<int> hashSet = new HashSet<int>();
			int count = this.GetTabCategories().Count;
			for (int i = 0; i < count; i++)
			{
				foreach (int item in this.GetTabBehaviorIds(i))
				{
					hashSet.Add(item);
				}
			}
			return hashSet;
		}

		// Token: 0x06038F21 RID: 233249 RVA: 0x00FF3C68 File Offset: 0x00FF1E68
		private unsafe void FillLastWeekSpecials(HashSet<int> availableIds)
		{
			SolarSchoolScheduleData scheduleData = SolarSchoolGamePlayModel.Instance.ScheduleData;
			HashSet<int> hashSet = new HashSet<int>();
			foreach (ESolarSchoolTimeSlot slot in this.ColumnSlots)
			{
				for (int j = 1; j <= 5; j++)
				{
					int lastWeekBehaviorId = scheduleData.GetLastWeekBehaviorId(j, slot);
					if (lastWeekBehaviorId != 0 && availableIds.Contains(lastWeekBehaviorId))
					{
						SolarSchoolBehavior? currentLevelRow = SolarSchoolGamePlayModel.Instance.PlayerData.GetCurrentLevelRow(lastWeekBehaviorId);
						if (currentLevelRow != null && currentLevelRow.Value.BehaviorType == 4 && hashSet.Add(lastWeekBehaviorId))
						{
							ESolarSchoolTimeSlot[] availableSlots = SolarSchoolUtils.GetAvailableSlots(currentLevelRow.Value);
							if (availableSlots.Length != 1)
							{
								Log instance = Log.Instance;
								ELogModule module = ELogModule.SolarSchool;
								ELogAuthor author = ELogAuthor.LRC;
								string message = "[SolarSchool] 特批行为的 AvailableTimeSlot 必须且只能配一个时段";
								<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", lastWeekBehaviorId);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("slotCount", availableSlots.Length);
								instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
							}
							else
							{
								this.TempData.SetSpecialBehavior(lastWeekBehaviorId, availableSlots[0], currentLevelRow.Value.GetOccupyDayOfWeekArray(), false);
							}
						}
					}
				}
			}
		}

		// Token: 0x06038F22 RID: 233250 RVA: 0x00FF3DC4 File Offset: 0x00FF1FC4
		private void FillLastWeekNormals(HashSet<int> availableIds)
		{
			SolarSchoolScheduleData scheduleData = SolarSchoolGamePlayModel.Instance.ScheduleData;
			foreach (ESolarSchoolTimeSlot slot in this.ColumnSlots)
			{
				for (int j = 1; j <= 5; j++)
				{
					int lastWeekBehaviorId = scheduleData.GetLastWeekBehaviorId(j, slot);
					if (lastWeekBehaviorId != 0 && availableIds.Contains(lastWeekBehaviorId) && this.CanFillLastWeekNormal(lastWeekBehaviorId, j, slot))
					{
						this.TempData.SetNormalBehavior(j, slot, lastWeekBehaviorId);
					}
				}
			}
		}

		// Token: 0x06038F23 RID: 233251 RVA: 0x00FF3E3C File Offset: 0x00FF203C
		private bool CanFillLastWeekNormal(int behaviorId, int weekday, ESolarSchoolTimeSlot slot)
		{
			SolarSchoolBehavior? currentLevelRow = SolarSchoolGamePlayModel.Instance.PlayerData.GetCurrentLevelRow(behaviorId);
			return currentLevelRow != null && currentLevelRow.Value.BehaviorType == 3 && SolarSchoolGamePlayModel.Instance.ScheduleData.IsNormalDay(0, weekday) && this.TempData.GetScheduledBehaviorId(weekday, slot) == 0 && this.TempData.IsSlotAtOrAfterNow(weekday, slot) && SolarSchoolUtils.CanPlaceInSlot(currentLevelRow.Value, slot);
		}

		// Token: 0x06038F24 RID: 233252 RVA: 0x00FF3EB8 File Offset: 0x00FF20B8
		[NullableContext(2)]
		private void RefreshDetail(SolarSchoolScheduleBehaviorData data)
		{
			UUIItem item = base.GetItem(21);
			if (item != null)
			{
				item.SetUIActive(data != null);
			}
			if (data != null)
			{
				UUIText text = base.GetText(22);
				if (text != null)
				{
					text.SetText(SolarSchoolGamePlayModel.Instance.PlayerData.GetBehaviorNameWithLevel(data.BehaviorId), true);
				}
				UUIText text2 = base.GetText(32);
				if (text2 != null)
				{
					text2.SetText(data.Desc, true);
				}
				this.RefreshOccupyInfo(data);
				this.RefreshConsumeList(data);
				this.RefreshSpecialInfo(data);
				return;
			}
			UUIText text3 = base.GetText(22);
			if (text3 == null)
			{
				return;
			}
			text3.SetText(string.Empty, true);
		}

		// Token: 0x06038F25 RID: 233253 RVA: 0x00FF3F50 File Offset: 0x00FF2150
		private void RefreshOccupyInfo(SolarSchoolScheduleBehaviorData data)
		{
			SolarSchoolBehavior? currentLevelRow = SolarSchoolGamePlayModel.Instance.PlayerData.GetCurrentLevelRow(data.BehaviorId);
			UUIItem item = base.GetItem(23);
			if (item != null)
			{
				item.SetUIActive(currentLevelRow != null);
			}
			if (currentLevelRow == null)
			{
				return;
			}
			UUIText text = base.GetText(25);
			if (text != null)
			{
				text.SetText(SolarSchoolUtils.GetTextWithPlaceholder(currentLevelRow.Value.OccupyText), true);
			}
			base.SetTextureByPath(currentLevelRow.Value.OccupyIcon, base.GetTexture(24), null, null);
		}

		// Token: 0x06038F26 RID: 233254 RVA: 0x00FF3FE8 File Offset: 0x00FF21E8
		private void RefreshConsumeList(SolarSchoolScheduleBehaviorData data)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolBehavior? currentLevelRow = instance.PlayerData.GetCurrentLevelRow(data.BehaviorId);
			List<SolarSchoolAttrDeltaItemData> list = new List<SolarSchoolAttrDeltaItemData>();
			if (currentLevelRow != null)
			{
				int displayFatigue = this.GetDisplayFatigue();
				foreach (ValueTuple<ESolarSchoolSecondAttr, int> valueTuple in instance.GetBehaviorSuccessAttrDeltas(currentLevelRow.Value))
				{
					ESolarSchoolSecondAttr item = valueTuple.Item1;
					int item2 = valueTuple.Item2;
					if (item == ESolarSchoolSecondAttr.Fatigue)
					{
						list.Insert(0, new SolarSchoolAttrDeltaItemData(item, item2, displayFatigue));
					}
					else
					{
						list.Add(new SolarSchoolAttrDeltaItemData(item, item2));
					}
				}
			}
			GenericLayout<SolarSchoolAttrDeltaItem, SolarSchoolAttrDeltaItemData> consumeLayout = this.ConsumeLayout;
			if (consumeLayout == null)
			{
				return;
			}
			consumeLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06038F27 RID: 233255 RVA: 0x00FF40B4 File Offset: 0x00FF22B4
		private void RefreshSpecialInfo(SolarSchoolScheduleBehaviorData data)
		{
			bool flag = data.BehaviorType == ESolarSchoolBehaviorType.Special;
			UUIItem item = base.GetItem(28);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(30);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			SolarSchoolSpecialBehaviorCenter instance = SolarSchoolSpecialBehaviorCenter.Instance;
			int behaviorId = data.BehaviorId;
			SolarSchoolBehavior? currentLevelRow = SolarSchoolGamePlayModel.Instance.PlayerData.GetCurrentLevelRow(behaviorId);
			int num = (currentLevelRow != null) ? currentLevelRow.GetValueOrDefault().FinishCount : 0;
			int num2 = Math.Max(0, num - instance.GetFinishedCount(behaviorId));
			UUIText text = base.GetText(29);
			if (text != null)
			{
				text.SetText(string.Format(ConfigMultiTextLang.GetLocalTextNew("SolarSchool_Tepi_1", null) ?? string.Empty, num2, num), true);
			}
			int finishDeadline = instance.GetFinishDeadline(behaviorId);
			if (finishDeadline <= 0)
			{
				UUIText text2 = base.GetText(31);
				if (text2 == null)
				{
					return;
				}
				text2.SetText(string.Empty, true);
				return;
			}
			else
			{
				ValueTuple<int, int> monthDay = SolarSchoolGamePlayModel.Instance.TimeData.GetMonthDay(finishDeadline);
				int item3 = monthDay.Item1;
				int item4 = monthDay.Item2;
				UUIText text3 = base.GetText(31);
				if (text3 == null)
				{
					return;
				}
				text3.SetText(string.Format(ConfigMultiTextLang.GetLocalTextNew("SolarSchool_Schedule_SpecialDeadline", null) ?? string.Empty, item3.ToString("D2"), item4.ToString("D2")), true);
				return;
			}
		}

		// Token: 0x06038F28 RID: 233256 RVA: 0x00FF420B File Offset: 0x00FF240B
		private void OnClickSave()
		{
			bool flag = this.IsCurrentWeekFullyScheduled();
			SolarSchoolGamePlayModel.Instance.SaveScheduleTempData(this.TempData);
			this.CloseSelf();
			if (flag)
			{
				SolarSchoolGamePlayModel.Instance.OnClickGoOut();
			}
		}

		// Token: 0x06038F29 RID: 233257 RVA: 0x00FF4235 File Offset: 0x00FF2435
		private void InitSaveBtnState()
		{
			this.IsSaveBtnInStartState = this.IsCurrentWeekFullyScheduled();
			SolarSchoolBtnItem saveBtn = this.SaveBtn;
			if (saveBtn == null)
			{
				return;
			}
			saveBtn.SetTextByTextId(SolarSchoolScheduleView.GetSaveBtnTextId(this.IsSaveBtnInStartState));
		}

		// Token: 0x06038F2A RID: 233258 RVA: 0x00FF4260 File Offset: 0x00FF2460
		private void RefreshSaveBtnState()
		{
			bool flag = this.IsCurrentWeekFullyScheduled();
			if (flag == this.IsSaveBtnInStartState)
			{
				return;
			}
			this.IsSaveBtnInStartState = flag;
			SolarSchoolBtnItem saveBtn = this.SaveBtn;
			if (saveBtn != null)
			{
				saveBtn.SetTextByTextId(SolarSchoolScheduleView.GetSaveBtnTextId(flag));
			}
			if (flag)
			{
				SolarSchoolBtnItem saveBtn2 = this.SaveBtn;
				if (saveBtn2 == null)
				{
					return;
				}
				saveBtn2.PlaySequenceByName("StartSchedule");
			}
		}

		// Token: 0x06038F2B RID: 233259 RVA: 0x00FF42B4 File Offset: 0x00FF24B4
		private static string GetSaveBtnTextId(bool isStartState)
		{
			if (!isStartState)
			{
				return "SolarSchool_SaveSchedule1";
			}
			return "SolarSchool_SaveSchedule2";
		}

		// Token: 0x06038F2C RID: 233260 RVA: 0x00FF42C4 File Offset: 0x00FF24C4
		private bool IsCurrentWeekFullyScheduled()
		{
			SolarSchoolScheduleData scheduleData = SolarSchoolGamePlayModel.Instance.ScheduleData;
			for (int i = 1; i <= 5; i++)
			{
				if (scheduleData.IsNormalDay(0, i))
				{
					foreach (ESolarSchoolTimeSlot slot in this.ColumnSlots)
					{
						if (this.TempData.IsSlotAtOrAfterNow(i, slot) && this.TempData.GetScheduledBehaviorId(i, slot) == 0)
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0401DF5D RID: 122717
		[Nullable(new byte[]
		{
			1,
			2,
			1,
			1
		})]
		private readonly GenericLayout<SolarSchoolScheduleGroupItem, SolarSchoolScheduleGroupData>[] GroupLayouts = new GenericLayout<SolarSchoolScheduleGroupItem, SolarSchoolScheduleGroupData>[2];

		// Token: 0x0401DF5E RID: 122718
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SolarSchoolScheduleTabItem, SolarSchoolScheduleTabItemData> TabLayout;

		// Token: 0x0401DF5F RID: 122719
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolAttrBriefItem, ESolarSchoolSecondAttr> AttrLayout;

		// Token: 0x0401DF60 RID: 122720
		private readonly HashSet<ESolarSchoolSecondAttr> IncreasedAttrs = new HashSet<ESolarSchoolSecondAttr>();

		// Token: 0x0401DF61 RID: 122721
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolAttrDeltaItem, SolarSchoolAttrDeltaItemData> ConsumeLayout;

		// Token: 0x0401DF62 RID: 122722
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SolarSchoolScheduleBehaviorItem, SolarSchoolScheduleBehaviorData> BehaviorScroll;

		// Token: 0x0401DF63 RID: 122723
		[Nullable(2)]
		private SolarSchoolCaptionItem Caption;

		// Token: 0x0401DF64 RID: 122724
		[Nullable(2)]
		private SolarSchoolBtnItem SaveBtn;

		// Token: 0x0401DF65 RID: 122725
		[Nullable(2)]
		private SolarSchoolBtnItem UseLastWeekBtn;

		// Token: 0x0401DF66 RID: 122726
		private bool IsSaveBtnInStartState;

		// Token: 0x0401DF67 RID: 122727
		private const string NoticeCloseSequence = "NoticeClose";

		// Token: 0x0401DF68 RID: 122728
		private const string NoticeLoopSequence = "NoticeLoop";

		// Token: 0x0401DF69 RID: 122729
		private ESolarSchoolTimeSlot PreviewSlot;

		// Token: 0x0401DF6A RID: 122730
		private int PreviewWeekdayMask;

		// Token: 0x0401DF6B RID: 122731
		private bool ScheduleAnimationsEnabled;

		// Token: 0x0401DF6C RID: 122732
		private int BehaviorRefreshVersion;

		// Token: 0x0401DF6D RID: 122733
		[TupleElementNames(new string[]
		{
			"Slot",
			"Weekday"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly Dictionary<ValueTuple<ESolarSchoolTimeSlot, int>, SolarSchoolScheduleCellData> PreviousCells = new Dictionary<ValueTuple<ESolarSchoolTimeSlot, int>, SolarSchoolScheduleCellData>();

		// Token: 0x0401DF6E RID: 122734
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly SolarSchoolScheduleSpecialDayItem[] SpecialDayItems = new SolarSchoolScheduleSpecialDayItem[5];

		// Token: 0x0401DF6F RID: 122735
		private SolarSchoolScheduleBoard TempData = new SolarSchoolScheduleBoard();

		// Token: 0x0401DF70 RID: 122736
		private int WeekOffset;

		// Token: 0x0401DF71 RID: 122737
		private int CurrentTabIndex;

		// Token: 0x0401DF72 RID: 122738
		private readonly List<SolarSchoolScheduleBehaviorData> SelectTabBehaviors = new List<SolarSchoolScheduleBehaviorData>();

		// Token: 0x0401DF73 RID: 122739
		[Nullable(2)]
		private SolarSchoolScheduleBehaviorData SelectedBehavior;

		// Token: 0x0401DF74 RID: 122740
		private readonly ESolarSchoolTimeSlot[] ColumnSlots = new ESolarSchoolTimeSlot[]
		{
			ESolarSchoolTimeSlot.Day,
			ESolarSchoolTimeSlot.Dusk
		};

		// Token: 0x0200B63A RID: 46650
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040385C3 RID: 230851
			public const int UiItemSolarSchoolCaption = 0;

			// Token: 0x040385C4 RID: 230852
			public const int TexHead = 1;

			// Token: 0x040385C5 RID: 230853
			public const int PnlList = 2;

			// Token: 0x040385C6 RID: 230854
			public const int PnlItem = 3;

			// Token: 0x040385C7 RID: 230855
			public const int BtnRefresh = 4;

			// Token: 0x040385C8 RID: 230856
			public const int BtnUse = 5;

			// Token: 0x040385C9 RID: 230857
			public const int BtnSave = 6;

			// Token: 0x040385CA RID: 230858
			public const int BtnCurGroupClass = 7;

			// Token: 0x040385CB RID: 230859
			public const int SprFrameCurL = 8;

			// Token: 0x040385CC RID: 230860
			public const int PnlListClass = 9;

			// Token: 0x040385CD RID: 230861
			public const int BtnCurGroupListAfterSchool = 10;

			// Token: 0x040385CE RID: 230862
			public const int SprFrameCurR = 11;

			// Token: 0x040385CF RID: 230863
			public const int PnlListAfterSchool = 12;

			// Token: 0x040385D0 RID: 230864
			public const int PnlExamItem1 = 13;

			// Token: 0x040385D1 RID: 230865
			public const int PnlExamItem2 = 14;

			// Token: 0x040385D2 RID: 230866
			public const int PnlExamItem3 = 15;

			// Token: 0x040385D3 RID: 230867
			public const int PnlExamItem4 = 16;

			// Token: 0x040385D4 RID: 230868
			public const int PnlExamItem5 = 17;

			// Token: 0x040385D5 RID: 230869
			public const int BtnPre = 18;

			// Token: 0x040385D6 RID: 230870
			public const int BtnNext = 19;

			// Token: 0x040385D7 RID: 230871
			public const int TxtTimePeriod = 20;

			// Token: 0x040385D8 RID: 230872
			public const int PnlCenterUi = 21;

			// Token: 0x040385D9 RID: 230873
			public const int TxtTitleC = 22;

			// Token: 0x040385DA RID: 230874
			public const int PnlTxt = 23;

			// Token: 0x040385DB RID: 230875
			public const int TexIconType = 24;

			// Token: 0x040385DC RID: 230876
			public const int TxtClassTime = 25;

			// Token: 0x040385DD RID: 230877
			public const int PnlConsumList = 26;

			// Token: 0x040385DE RID: 230878
			public const int ConsumItemTemplate = 27;

			// Token: 0x040385DF RID: 230879
			public const int PnlTimes = 28;

			// Token: 0x040385E0 RID: 230880
			public const int TxtTimes = 29;

			// Token: 0x040385E1 RID: 230881
			public const int PnlEnd = 30;

			// Token: 0x040385E2 RID: 230882
			public const int TxtEnd = 31;

			// Token: 0x040385E3 RID: 230883
			public const int TxtDesc = 32;

			// Token: 0x040385E4 RID: 230884
			public const int PnlTabList = 33;

			// Token: 0x040385E5 RID: 230885
			public const int TogtItemTemplate = 34;

			// Token: 0x040385E6 RID: 230886
			public const int BehaviorLoopView = 35;

			// Token: 0x040385E7 RID: 230887
			public const int BehaviorItemTemplate = 36;

			// Token: 0x040385E8 RID: 230888
			public const int UiItemEmpty = 37;

			// Token: 0x040385E9 RID: 230889
			public const int PnlBtnSetDisColor = 38;

			// Token: 0x040385EA RID: 230890
			public const int TxtDate = 39;

			// Token: 0x040385EB RID: 230891
			public const int TxtWeek = 40;

			// Token: 0x040385EC RID: 230892
			public const int ArtTxtDate = 41;

			// Token: 0x040385ED RID: 230893
			public const int ArtTxtDate01 = 42;

			// Token: 0x040385EE RID: 230894
			public const int ArtTxtDate02 = 43;

			// Token: 0x040385EF RID: 230895
			public const int ArtTxtDate03 = 44;

			// Token: 0x040385F0 RID: 230896
			public const int ArtTxtDate04 = 45;

			// Token: 0x040385F1 RID: 230897
			public const int ArtTxtDate05 = 46;
		}
	}
}

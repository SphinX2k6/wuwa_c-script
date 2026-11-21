using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Giant.View;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x0200494E RID: 18766
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantSystemQuestView : UiViewBase
	{
		// Token: 0x0602F10A RID: 192778 RVA: 0x00D202B4 File Offset: 0x00D1E4B4
		public GiantSystemQuestView(UiViewInfo viewInfo) : base(viewInfo)
		{
			this.OnStableValueChange = delegate(GiantEcoNetType? _, double _, double _)
			{
				this.OnGiantDataChange();
			};
			this.OnStageCross = delegate(GiantEcoNetType? _, EGiantStage _, EGiantStage _)
			{
				this.OnGiantDataChange();
			};
			this.OnEcoStatusChange = delegate(GiantEcoNetType _, GiantEcoNetStatus _, GiantEcoNetStatus _)
			{
				this.OnGiantDataChange();
			};
			this.OnAccessProgressChange = delegate(int _, int _, int _)
			{
				this.OnGiantDataChange();
			};
		}

		// Token: 0x0602F10B RID: 192779 RVA: 0x00D20330 File Offset: 0x00D1E530
		protected unsafe override void OnRegisterComponent()
		{
			int num = 30;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickLevelPre));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickLevelNext));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(24, new Action(this.OnClickDeliver));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602F10C RID: 192780 RVA: 0x00D207D0 File Offset: 0x00D1E9D0
		protected override void OnBeforeCreate()
		{
			IGiantSystemQuestOpenParam giantSystemQuestOpenParam = this.OpenParam as IGiantSystemQuestOpenParam;
			this.EcoType = giantSystemQuestOpenParam.EcoType;
			this.GuideOnly = giantSystemQuestOpenParam.GuideOnly.GetValueOrDefault();
		}

		// Token: 0x0602F10D RID: 192781 RVA: 0x00D2080C File Offset: 0x00D1EA0C
		protected override UniTask OnBeforeStartAsync()
		{
			GiantSystemQuestView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GiantSystemQuestView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F10E RID: 192782 RVA: 0x00D20850 File Offset: 0x00D1EA50
		protected override void OnStart()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(19);
			object obj;
			if (scrollViewWithScrollbar == null)
			{
				obj = null;
			}
			else
			{
				AUIBaseActor content = scrollViewWithScrollbar.GetContent();
				obj = ((content != null) ? content.GetComponentByClass(UUILayoutBase.StaticClass()) : null);
			}
			UUILayoutBase uuilayoutBase = obj as UUILayoutBase;
			if (uuilayoutBase != null)
			{
				this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(uuilayoutBase, () => new CommonItemSmallItemGrid
				{
					ShowReceivedCallBack = ((TItem data) => this.IsBrowseLevelRewardReceived())
				}, null, false, true);
			}
			this.InitQuestGuideList();
			this.InitCollectedList();
			this.InitMindsetTabs();
			this.Caption = new PopupCaptionItem(base.GetItem(0));
			this.Caption.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.ViewedEcoSet.Add(this.EcoType);
			this.BrowseLevel = this.GetDisplayLevelFromStage();
			this.Refresh();
			this.PlayQuestGuideListAnim();
		}

		// Token: 0x0602F10F RID: 192783 RVA: 0x00D20910 File Offset: 0x00D1EB10
		protected override void OnBeforeDestroy()
		{
			GiantDeliverBtnItem deliverBtn = this.DeliverBtn;
			UUIItem uuiitem = (deliverBtn != null) ? deliverBtn.GetRedDotItem() : null;
			if (uuiitem != null && this.BoundDeliverEco != null)
			{
				RedDotController.Instance.UnBindGivenUi(ERedDotName.GiantDeliverable, uuiitem, (int)this.BoundDeliverEco.Value);
			}
			this.BoundDeliverEco = null;
			this.DeliverBtn = null;
		}

		// Token: 0x0602F110 RID: 192784 RVA: 0x00D20970 File Offset: 0x00D1EB70
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, this.OnStableValueChange);
			EventSystem.Instance.Add<GiantEcoNetType?, EGiantStage, EGiantStage>(EEventName.OnGiantStageCross, this.OnStageCross);
			EventSystem.Instance.Add<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, this.OnEcoStatusChange);
			EventSystem.Instance.Add<int, int, int>(EEventName.OnGiantAccessProgressChange, this.OnAccessProgressChange);
		}

		// Token: 0x0602F111 RID: 192785 RVA: 0x00D209D8 File Offset: 0x00D1EBD8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, this.OnStableValueChange);
			EventSystem.Instance.Remove<GiantEcoNetType?, EGiantStage, EGiantStage>(EEventName.OnGiantStageCross, this.OnStageCross);
			EventSystem.Instance.Remove<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, this.OnEcoStatusChange);
			EventSystem.Instance.Remove<int, int, int>(EEventName.OnGiantAccessProgressChange, this.OnAccessProgressChange);
			this.MarkViewedEcoAccessRead();
		}

		// Token: 0x0602F112 RID: 192786 RVA: 0x00D20A44 File Offset: 0x00D1EC44
		private void MarkViewedEcoAccessRead()
		{
			if (this.ViewedEcoSet.Count == 0)
			{
				return;
			}
			GiantModel instance = GiantModel.Instance;
			List<int> list = new List<int>();
			foreach (GiantEcoNetType eco in this.ViewedEcoSet)
			{
				foreach (GiantItemAccess giantItemAccess in GiantConfig.GetEcoItemAccessList(eco))
				{
					if (instance.HasNewAccess(giantItemAccess.Id))
					{
						list.Add(giantItemAccess.Id);
					}
				}
			}
			this.ViewedEcoSet.Clear();
			instance.MarkAccessReadBatch(list);
		}

		// Token: 0x0602F113 RID: 192787 RVA: 0x00D20B14 File Offset: 0x00D1ED14
		private void OnGiantDataChange()
		{
			this.Refresh();
		}

		// Token: 0x0602F114 RID: 192788 RVA: 0x00D20B1C File Offset: 0x00D1ED1C
		private void InitQuestGuideList()
		{
			UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(4);
			UUIExtendToggle extendToggle = base.GetExtendToggle(5);
			AUIBaseActor auibaseActor = ((extendToggle != null) ? extendToggle.GetOwner() : null) as AUIBaseActor;
			if (loopScrollViewComponent == null || auibaseActor == null)
			{
				return;
			}
			this.QuestGuideList = new LoopScrollView<GiantQuestGuideItem, IGiantQuestGuideData>(loopScrollViewComponent, auibaseActor, new Func<GiantQuestGuideItem>(this.CreateQuestGuideItem), false);
		}

		// Token: 0x0602F115 RID: 192789 RVA: 0x00D20B6B File Offset: 0x00D1ED6B
		private GiantQuestGuideItem CreateQuestGuideItem()
		{
			return new GiantQuestGuideItem
			{
				OnHoverCallBack = new Action<int>(this.OnHoverQuestGuideItem)
			};
		}

		// Token: 0x0602F116 RID: 192790 RVA: 0x00D20B84 File Offset: 0x00D1ED84
		private void OnHoverQuestGuideItem(int gridIndex)
		{
			this.MarkGuideAccessRead(gridIndex);
		}

		// Token: 0x0602F117 RID: 192791 RVA: 0x00D20B90 File Offset: 0x00D1ED90
		private void MarkGuideAccessRead(int gridIndex)
		{
			if (gridIndex < 0 || gridIndex >= this.CurrentGuideData.Count)
			{
				return;
			}
			IGiantQuestGuideData giantQuestGuideData = this.CurrentGuideData[gridIndex];
			List<int> list = (giantQuestGuideData != null) ? giantQuestGuideData.GroupAccessIds : null;
			if (list == null)
			{
				return;
			}
			GiantModel instance = GiantModel.Instance;
			foreach (int accessId in list)
			{
				if (instance.GetAccessState(accessId) != GiantItemAccessStatus.AccessLock)
				{
					instance.MarkAccessRead(accessId);
				}
			}
		}

		// Token: 0x0602F118 RID: 192792 RVA: 0x00D20C20 File Offset: 0x00D1EE20
		private void InitCollectedList()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(22);
			object obj;
			if (scrollViewWithScrollbar == null)
			{
				obj = null;
			}
			else
			{
				AUIBaseActor content = scrollViewWithScrollbar.GetContent();
				obj = ((content != null) ? content.GetComponentByClass(UUILayoutBase.StaticClass()) : null);
			}
			UUILayoutBase uuilayoutBase = obj as UUILayoutBase;
			UUIItem item = base.GetItem(23);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (uuilayoutBase == null || auibaseActor == null)
			{
				return;
			}
			this.CollectedList = new GenericLayout<GiantCollectedCoinItem, IGiantCollectedCoinData>(uuilayoutBase, () => new GiantCollectedCoinItem(), auibaseActor, false, true);
		}

		// Token: 0x0602F119 RID: 192793 RVA: 0x00D20CAC File Offset: 0x00D1EEAC
		private void InitMindsetTabs()
		{
			for (int i = 0; i < GiantSystemQuestView.tabChildList.Length; i++)
			{
				GiantEcoNetType eco = GiantSystemQuestView.tabEcoList[i];
				UUIExtendToggle extendToggle = base.GetExtendToggle(GiantSystemQuestView.tabChildList[i]);
				if (extendToggle != null)
				{
					extendToggle.OnStateChange.Add(delegate(EToggleState state)
					{
						if (state == EToggleState.ETT_Checked)
						{
							this.SwitchEco(eco);
						}
					});
				}
			}
		}

		// Token: 0x0602F11A RID: 192794 RVA: 0x00D20D10 File Offset: 0x00D1EF10
		private void SwitchEco(GiantEcoNetType eco)
		{
			if (this.EcoType == eco)
			{
				return;
			}
			this.EcoType = eco;
			this.ViewedEcoSet.Add(eco);
			this.BrowseLevel = this.GetDisplayLevelFromStage();
			base.PlayOrReplaySequence("Switch2", false, null);
			this.Refresh();
			LoopScrollView<GiantQuestGuideItem, IGiantQuestGuideData> questGuideList = this.QuestGuideList;
			if (questGuideList != null)
			{
				questGuideList.ScrollToGridIndex(0, false);
			}
			this.PlayQuestGuideListAnim();
		}

		// Token: 0x0602F11B RID: 192795 RVA: 0x00D20D7B File Offset: 0x00D1EF7B
		private void PlayQuestGuideListAnim()
		{
			LoopScrollView<GiantQuestGuideItem, IGiantQuestGuideData> questGuideList = this.QuestGuideList;
			if (questGuideList == null)
			{
				return;
			}
			UUIInturnAnimController uiAnimController = questGuideList.GetUiAnimController();
			if (uiAnimController == null)
			{
				return;
			}
			uiAnimController.Play("", -1, false);
		}

		// Token: 0x0602F11C RID: 192796 RVA: 0x00D20DA0 File Offset: 0x00D1EFA0
		private void Refresh()
		{
			IGiantEcoDisplayConfig config = GiantDefine.EcoDisplayConfigs[this.EcoType];
			GiantEcoNetStatus ecoStatus = GiantModel.Instance.GetEcoStatus(this.EcoType);
			this.RefreshGuideVisibility();
			this.RefreshTabSelection();
			this.RefreshIcon(config, ecoStatus);
			this.RefreshTextAndColor(config, ecoStatus);
			this.RefreshProgress();
			this.RefreshLevelBrowse();
			this.RefreshRewardList();
			this.RefreshQuestGuide();
			this.RefreshCollectedItems();
			this.RefreshDeliverState(ecoStatus);
			this.RefreshDeliverRedDot();
		}

		// Token: 0x0602F11D RID: 192797 RVA: 0x00D20E18 File Offset: 0x00D1F018
		private void RefreshDeliverRedDot()
		{
			GiantDeliverBtnItem deliverBtn = this.DeliverBtn;
			UUIItem uuiitem = (deliverBtn != null) ? deliverBtn.GetRedDotItem() : null;
			if (uuiitem == null)
			{
				return;
			}
			GiantEcoNetType? giantEcoNetType = this.GuideOnly ? null : new GiantEcoNetType?(this.EcoType);
			GiantEcoNetType? boundDeliverEco = this.BoundDeliverEco;
			GiantEcoNetType? giantEcoNetType2 = giantEcoNetType;
			if (boundDeliverEco.GetValueOrDefault() == giantEcoNetType2.GetValueOrDefault() & boundDeliverEco != null == (giantEcoNetType2 != null))
			{
				return;
			}
			if (this.BoundDeliverEco != null)
			{
				RedDotController.Instance.UnBindGivenUi(ERedDotName.GiantDeliverable, uuiitem, (int)this.BoundDeliverEco.Value);
			}
			if (giantEcoNetType != null)
			{
				RedDotController.Instance.BindRedDot(ERedDotName.GiantDeliverable, uuiitem, null, (int)giantEcoNetType.Value);
			}
			this.BoundDeliverEco = giantEcoNetType;
		}

		// Token: 0x0602F11E RID: 192798 RVA: 0x00D20ED8 File Offset: 0x00D1F0D8
		private void RefreshGuideVisibility()
		{
			bool uiactive = !this.GuideOnly;
			UUIButtonComponent button = base.GetButton(24);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(uiactive);
		}

		// Token: 0x0602F11F RID: 192799 RVA: 0x00D20F14 File Offset: 0x00D1F114
		private void RefreshTabSelection()
		{
			for (int i = 0; i < GiantSystemQuestView.tabChildList.Length; i++)
			{
				GiantEcoNetType giantEcoNetType = GiantSystemQuestView.tabEcoList[i];
				UUIExtendToggle extendToggle = base.GetExtendToggle(GiantSystemQuestView.tabChildList[i]);
				if (extendToggle != null)
				{
					extendToggle.SetToggleState((giantEcoNetType == this.EcoType) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
				}
				bool uiactive = GiantModel.Instance.GetEcoStatus(giantEcoNetType) == GiantEcoNetStatus.MaxStableValue;
				UUIItem tabComplete = this.GetTabComplete(extendToggle);
				if (tabComplete != null)
				{
					tabComplete.SetUIActive(uiactive);
				}
			}
		}

		// Token: 0x0602F120 RID: 192800 RVA: 0x00D20F88 File Offset: 0x00D1F188
		[NullableContext(2)]
		private UUIItem GetTabComplete(UUIExtendToggle toggle)
		{
			AUIBaseActor auibaseActor = ((toggle != null) ? toggle.GetOwner() : null) as AUIBaseActor;
			if (auibaseActor == null || !auibaseActor.IsValid())
			{
				return null;
			}
			ULGUIComponentsRegistry componentsRegistry = LguiUtil.Instance.GetComponentsRegistry(auibaseActor);
			if (componentsRegistry == null || !componentsRegistry.IsValid() || 2 >= componentsRegistry.Components.Num())
			{
				return null;
			}
			AActor aactor = componentsRegistry.Components.Get(2);
			return ((aactor != null) ? aactor.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem;
		}

		// Token: 0x0602F121 RID: 192801 RVA: 0x00D21010 File Offset: 0x00D1F210
		private void RefreshIcon(IGiantEcoDisplayConfig config, GiantEcoNetStatus status)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(config.IconSpriteNormal);
			base.TrySetSpriteByPath(resourcePath, base.GetSprite(10), false, null, null);
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(config.IconSpriteActive);
			base.TrySetSpriteByPath(resourcePath2, base.GetSprite(9), false, null, null);
			string resourcePath3 = UiResourceConfig.Instance.GetResourcePath(config.PortraitTexture);
			base.TrySetTextureByPath(resourcePath3, base.GetTexture(6), null, null);
		}

		// Token: 0x0602F122 RID: 192802 RVA: 0x00D2109C File Offset: 0x00D1F29C
		private void RefreshTextAndColor(IGiantEcoDisplayConfig config, GiantEcoNetStatus status)
		{
			FColor color = FColor.FromHex(config.OutlineColorHex);
			UUIText text = base.GetText(11);
			if (text != null)
			{
				text.SetText(GiantConfig.ResolveLocalTextOrKey(config.MindsetNameKey), true);
			}
			this.SetTextOutline(11, color);
			this.RefreshLevelUnlockText();
			this.RefreshFeatureActivation();
		}

		// Token: 0x0602F123 RID: 192803 RVA: 0x00D210EC File Offset: 0x00D1F2EC
		private void RefreshLevelUnlockText()
		{
			GiantLevelUnlock? levelUnlock = GiantConfig.GetLevelUnlock(this.EcoType, this.BrowseLevel);
			bool flag = this.IsBrowseLevelReached();
			string text = (flag ? ((levelUnlock != null) ? levelUnlock.GetValueOrDefault().PostUnlockDesc1 : null) : ((levelUnlock != null) ? levelUnlock.GetValueOrDefault().PreUnlockDesc : null)) ?? "";
			string text2 = (flag ? ((levelUnlock != null) ? levelUnlock.GetValueOrDefault().PostUnlockDesc2 : null) : "") ?? "";
			bool uiactive = !StringUtils.IsNothing(text);
			UUIText text3 = base.GetText(14);
			if (text3 != null)
			{
				text3.SetText((!StringUtils.IsNothing(text)) ? GiantConfig.ResolveLocalTextOrKey(text) : "", true);
			}
			UUISprite sprite = base.GetSprite(26);
			if (sprite != null)
			{
				sprite.SetUIActive(uiactive);
			}
			bool flag2 = !StringUtils.IsNothing(text2);
			UUIText text4 = base.GetText(17);
			if (text4 != null)
			{
				text4.SetUIActive(flag2);
			}
			UUISprite sprite2 = base.GetSprite(27);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(flag2);
			}
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(flag2);
			}
			if (flag2)
			{
				UUIText text5 = base.GetText(17);
				if (text5 != null)
				{
					text5.SetText(GiantConfig.ResolveLocalTextOrKey(text2), true);
				}
			}
			this.RefreshTitles();
		}

		// Token: 0x0602F124 RID: 192804 RVA: 0x00D2123C File Offset: 0x00D1F43C
		private void RefreshTitles()
		{
			bool flag = this.BrowseLevel >= this.GetMaxLevel();
			string textKey = flag ? GiantConfig.GetTextKeyTraitTitleMax() : GiantConfig.GetTextKeyTraitTitleUpgrade();
			UUIText text = base.GetText(28);
			if (text != null)
			{
				text.SetText(GiantConfig.ResolveLocalTextOrKey(textKey), true);
			}
			string newText = flag ? GiantConfig.GetRewardTitleOfferingText(this.EcoType) : GiantConfig.ResolveLocalTextOrKey(GiantConfig.GetTextKeyRewardTitleUpgrade());
			UUIText text2 = base.GetText(29);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(newText, true);
		}

		// Token: 0x0602F125 RID: 192805 RVA: 0x00D212B4 File Offset: 0x00D1F4B4
		private void RefreshFeatureActivation()
		{
			bool flag = this.IsBrowseLevelReached();
			UUIText text = base.GetText(14);
			UUIText text2 = base.GetText(17);
			UUISprite sprite = base.GetSprite(26);
			UUISprite sprite2 = base.GetSprite(27);
			if (text != null)
			{
				UUIItem uuiitem = text;
				bool bUseChangeColor = flag;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			if (text2 != null)
			{
				UUIItem uuiitem2 = text2;
				bool bUseChangeColor2 = flag;
				FColor? fcolor = new FColor?(text2.changeColor);
				uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			}
			if (sprite != null)
			{
				UUIItem uuiitem3 = sprite;
				bool bUseChangeColor3 = flag;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem3.SetChangeColor(bUseChangeColor3, fcolor);
			}
			if (sprite2 != null)
			{
				UUIItem uuiitem4 = sprite2;
				bool bUseChangeColor4 = flag;
				FColor? fcolor = new FColor?(sprite2.changeColor);
				uuiitem4.SetChangeColor(bUseChangeColor4, fcolor);
			}
		}

		// Token: 0x0602F126 RID: 192806 RVA: 0x00D21354 File Offset: 0x00D1F554
		private void SetTextOutline(int name, FColor color)
		{
			UUIText text = base.GetText(name);
			if (text == null)
			{
				return;
			}
			text.SetFontOutlineColor(color);
		}

		// Token: 0x0602F127 RID: 192807 RVA: 0x00D21368 File Offset: 0x00D1F568
		private void RefreshProgress()
		{
			UUIText text = base.GetText(12);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Lv.");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.BrowseLevel);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0602F128 RID: 192808 RVA: 0x00D213B4 File Offset: 0x00D1F5B4
		private bool IsBrowseLevelReached()
		{
			int displayLevelFromStage = this.GetDisplayLevelFromStage();
			return this.BrowseLevel < displayLevelFromStage || displayLevelFromStage >= this.GetMaxLevel();
		}

		// Token: 0x0602F129 RID: 192809 RVA: 0x00D213DF File Offset: 0x00D1F5DF
		private bool IsBrowseLevelRewardReceived()
		{
			return this.BrowseLevel < this.GetMaxLevel() && this.IsBrowseLevelReached();
		}

		// Token: 0x0602F12A RID: 192810 RVA: 0x00D213F8 File Offset: 0x00D1F5F8
		private void RefreshRewardList()
		{
			if (this.RewardLayout == null)
			{
				return;
			}
			GiantDeliveryReward? deliveryReward = GiantConfig.GetDeliveryReward(this.EcoType);
			if (deliveryReward == null)
			{
				this.RewardLayout.RefreshByData(Array.Empty<TItem>(), null, false);
				return;
			}
			GiantDeliveryReward value = deliveryReward.Value;
			int[] array = value.GetDropIdsArray() ?? Array.Empty<int>();
			int? num = (this.BrowseLevel - 1 < array.Length) ? new int?(array[this.BrowseLevel - 1]) : null;
			List<int> list;
			if (num == null)
			{
				(list = new List<int>()).Add(value.MaxLevelDropId);
			}
			else
			{
				(list = new List<int>()).Add(num.Value);
			}
			List<int> idList = list;
			List<TItem> dropPackagePreviewItemListByIdList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemListByIdList(idList);
			this.RewardLayout.RefreshByData(dropPackagePreviewItemListByIdList, null, false);
		}

		// Token: 0x0602F12B RID: 192811 RVA: 0x00D214C6 File Offset: 0x00D1F6C6
		private void RefreshQuestGuide()
		{
			if (this.QuestGuideList == null)
			{
				return;
			}
			this.CurrentGuideData = this.BuildQuestGuideData();
			this.QuestGuideList.RefreshByData(this.CurrentGuideData, false, null, false);
		}

		// Token: 0x0602F12C RID: 192812 RVA: 0x00D214F4 File Offset: 0x00D1F6F4
		private List<IGiantQuestGuideData> BuildQuestGuideData()
		{
			GiantModel instance = GiantModel.Instance;
			bool flag = instance.GetEcoStatus(this.EcoType) == GiantEcoNetStatus.MaxStableValue;
			List<IGiantQuestGuideData> list = new List<IGiantQuestGuideData>();
			foreach (List<GiantItemAccess> list2 in GiantConfig.GetEcoItemAccessGroups(this.EcoType))
			{
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				foreach (GiantItemAccess giantItemAccess in list2)
				{
					IReadOnlyDictionary<int, int> accessItemInfos = instance.GetAccessItemInfos(giantItemAccess.Id);
					if (accessItemInfos != null)
					{
						foreach (KeyValuePair<int, int> keyValuePair in accessItemInfos)
						{
							int num;
							dictionary[keyValuePair.Key] = (dictionary.TryGetValue(keyValuePair.Key, out num) ? num : 0) + keyValuePair.Value;
						}
					}
				}
				List<IGiantQuestGuideItemInfo> list3 = new List<IGiantQuestGuideItemInfo>();
				foreach (KeyValuePair<int, int> keyValuePair2 in dictionary)
				{
					if (keyValuePair2.Value > 0)
					{
						list3.Add(new GiantQuestGuideItemInfo
						{
							ItemId = keyValuePair2.Key,
							Count = keyValuePair2.Value
						});
					}
				}
				list3.Sort((IGiantQuestGuideItemInfo a, IGiantQuestGuideItemInfo b) => GiantConfig.GetItemQuality(a.ItemId) - GiantConfig.GetItemQuality(b.ItemId));
				bool flag2 = false;
				foreach (GiantItemAccess giantItemAccess2 in list2)
				{
					if (instance.GetAccessState(giantItemAccess2.Id) == GiantItemAccessStatus.AccessLock)
					{
						flag2 = true;
						break;
					}
				}
				int num2 = 0;
				foreach (IGiantQuestGuideItemInfo giantQuestGuideItemInfo in list3)
				{
					num2 += giantQuestGuideItemInfo.Count;
				}
				EGiantQuestGuideState state = flag2 ? EGiantQuestGuideState.Locked : ((num2 <= 0) ? EGiantQuestGuideState.Done : EGiantQuestGuideState.CanGoto);
				GiantItemAccess? giantItemAccess3 = null;
				foreach (GiantItemAccess value in list2)
				{
					if (instance.GetAccessState(value.Id) != GiantItemAccessStatus.AccessLock && this.GetAccessRemain(value.Id) > 0)
					{
						giantItemAccess3 = new GiantItemAccess?(value);
						break;
					}
				}
				bool flag3 = false;
				if (!flag)
				{
					foreach (GiantItemAccess giantItemAccess4 in list2)
					{
						if (instance.HasNewAccess(giantItemAccess4.Id))
						{
							flag3 = true;
							break;
						}
					}
				}
				bool flag4 = giantItemAccess3 != null && GiantConfig.GetAccessHasSkip(giantItemAccess3.Value.AccessPathId);
				GiantItemAccess giantItemAccess5 = list2[0];
				foreach (GiantItemAccess giantItemAccess6 in list2)
				{
					if (giantItemAccess6.Id < giantItemAccess5.Id)
					{
						giantItemAccess5 = giantItemAccess6;
					}
				}
				List<int> list4 = new List<int>();
				foreach (GiantItemAccess giantItemAccess7 in list2)
				{
					list4.Add(giantItemAccess7.Id);
				}
				list.Add(new GiantQuestGuideData
				{
					AccessId = giantItemAccess5.Id,
					GroupAccessIds = list4,
					SkipConfigId = ((giantItemAccess3 != null) ? giantItemAccess3.GetValueOrDefault().AccessPathId : 0),
					AnchorItemId = ((list3.Count > 0) ? list3[0].ItemId : 0),
					DescText = GiantConfig.ResolveLocalTextOrKey(giantItemAccess5.Desc),
					LockedText = GiantConfig.GetAccessUnlockHintText(giantItemAccess5.AccessPathId),
					State = state,
					Items = list3,
					HasNew = flag3,
					HasSkip = flag4,
					OnGoto = new Action<IGiantQuestGuideData>(this.OnGotoAccess)
				});
				if (flag3 && !flag4)
				{
					foreach (int accessId in list4)
					{
						if (instance.GetAccessState(accessId) != GiantItemAccessStatus.AccessLock)
						{
							instance.MarkAccessReadSilently(accessId);
						}
					}
				}
			}
			List<IGiantQuestGuideData> list5 = new List<IGiantQuestGuideData>(list.Count);
			for (int i = 0; i < 3; i++)
			{
				foreach (IGiantQuestGuideData giantQuestGuideData in list)
				{
					if (GiantSystemQuestView.<BuildQuestGuideData>g__Rank|52_0(giantQuestGuideData.State) == i)
					{
						list5.Add(giantQuestGuideData);
					}
				}
			}
			return list5;
		}

		// Token: 0x0602F12D RID: 192813 RVA: 0x00D21AF0 File Offset: 0x00D1FCF0
		private int GetAccessRemain(int accessId)
		{
			IReadOnlyDictionary<int, int> accessItemInfos = GiantModel.Instance.GetAccessItemInfos(accessId);
			if (accessItemInfos == null)
			{
				return 0;
			}
			int num = 0;
			foreach (KeyValuePair<int, int> keyValuePair in accessItemInfos)
			{
				num += keyValuePair.Value;
			}
			return num;
		}

		// Token: 0x0602F12E RID: 192814 RVA: 0x00D21B50 File Offset: 0x00D1FD50
		private void OnGotoAccess(IGiantQuestGuideData data)
		{
			GiantModel instance = GiantModel.Instance;
			foreach (int accessId in data.GroupAccessIds)
			{
				if (instance.GetAccessState(accessId) != GiantItemAccessStatus.AccessLock)
				{
					instance.MarkAccessRead(accessId);
				}
			}
			if (data.SkipConfigId > 0)
			{
				SkipTaskManager.RunByConfigId(data.SkipConfigId, data.AnchorItemId);
			}
		}

		// Token: 0x0602F12F RID: 192815 RVA: 0x00D21BD4 File Offset: 0x00D1FDD4
		private void RefreshCollectedItems()
		{
			if (this.CollectedList == null)
			{
				return;
			}
			InventoryModel instance = InventoryModel.Instance;
			IEnumerable<int> ecoItemIds = GiantConfig.GetEcoItemIds(this.EcoType);
			Func<int, int> keySelector;
			if ((keySelector = GiantSystemQuestView.<>O.<0>__GetItemQuality) == null)
			{
				keySelector = (GiantSystemQuestView.<>O.<0>__GetItemQuality = new Func<int, int>(GiantConfig.GetItemQuality));
			}
			List<int> list = NoLinq.OrderByDescendingToList<int, int>(ecoItemIds, keySelector);
			List<IGiantCollectedCoinData> list2 = new List<IGiantCollectedCoinData>(list.Count);
			foreach (int num in list)
			{
				list2.Add(new GiantCollectedCoinData
				{
					ItemId = num,
					Count = instance.GetItemCountByConfigId(num, 0)
				});
			}
			this.CollectedList.RefreshByData(list2, null, false);
		}

		// Token: 0x0602F130 RID: 192816 RVA: 0x00D21C90 File Offset: 0x00D1FE90
		private void RefreshDeliverState(GiantEcoNetStatus status)
		{
			bool flag = status == GiantEcoNetStatus.MaxStableValue;
			UUIItem item = base.GetItem(25);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(18);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			UUIItem item3 = base.GetItem(21);
			if (item3 != null)
			{
				item3.SetUIActive(!flag);
			}
			UUIButtonComponent button = base.GetButton(24);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(!this.GuideOnly && !flag);
		}

		// Token: 0x0602F131 RID: 192817 RVA: 0x00D21D17 File Offset: 0x00D1FF17
		private void OnClickLevelPre()
		{
			this.SwitchLevel(-1);
		}

		// Token: 0x0602F132 RID: 192818 RVA: 0x00D21D20 File Offset: 0x00D1FF20
		private void OnClickLevelNext()
		{
			this.SwitchLevel(1);
		}

		// Token: 0x0602F133 RID: 192819 RVA: 0x00D21D2C File Offset: 0x00D1FF2C
		private void SwitchLevel(int delta)
		{
			int num = this.BrowseLevel + delta;
			if (num < 1 || num > this.GetBrowseCap())
			{
				return;
			}
			this.BrowseLevel = num;
			base.PlayOrReplaySequence("Switch", false, null);
			this.RefreshLevelBrowse();
			this.RefreshProgress();
			this.RefreshLevelUnlockText();
			this.RefreshFeatureActivation();
			this.RefreshRewardList();
		}

		// Token: 0x0602F134 RID: 192820 RVA: 0x00D21D8A File Offset: 0x00D1FF8A
		private int GetBrowseCap()
		{
			return this.GetMaxLevel();
		}

		// Token: 0x0602F135 RID: 192821 RVA: 0x00D21D94 File Offset: 0x00D1FF94
		private void RefreshLevelBrowse()
		{
			int browseCap = this.GetBrowseCap();
			UUIButtonComponent button = base.GetButton(7);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(this.BrowseLevel > 1);
				}
			}
			UUIButtonComponent button2 = base.GetButton(8);
			if (button2 == null)
			{
				return;
			}
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 == null)
			{
				return;
			}
			uuiitem2.SetUIActive(this.BrowseLevel < browseCap);
		}

		// Token: 0x0602F136 RID: 192822 RVA: 0x00D21E04 File Offset: 0x00D20004
		private void OnClickDeliver()
		{
			if (this.IsEcoWholeLocked())
			{
				GiantController.Instance.OpenUnlockConditionView(this.EcoType);
				return;
			}
			GiantDeliveryReward? deliveryReward = GiantConfig.GetDeliveryReward(this.EcoType);
			int num = (deliveryReward != null) ? deliveryReward.GetValueOrDefault().AltarMarkId : 0;
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = new int?(num),
				MarkType = GiantConfig.GetMarkTypeByMarkId(num)
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
		}

		// Token: 0x0602F137 RID: 192823 RVA: 0x00D21E7E File Offset: 0x00D2007E
		private bool IsEcoWholeLocked()
		{
			return GiantModel.Instance.GetEcoStatus(this.EcoType) == GiantEcoNetStatus.Lock;
		}

		// Token: 0x0602F138 RID: 192824 RVA: 0x00D21E93 File Offset: 0x00D20093
		private bool IsItemLocked(int itemId)
		{
			return this.IsEcoWholeLocked() || GiantModel.Instance.GetItemLocked(itemId);
		}

		// Token: 0x0602F139 RID: 192825 RVA: 0x00D21EAC File Offset: 0x00D200AC
		private int GetMaxLevel()
		{
			int num = GiantConfig.GetEcoGoals(this.EcoType).Length;
			if (num <= 0)
			{
				return 1;
			}
			return num + 1;
		}

		// Token: 0x0602F13A RID: 192826 RVA: 0x00D21ED0 File Offset: 0x00D200D0
		private int GetDisplayLevelFromStage()
		{
			return GiantConfig.GetEcoLevelByValue(this.EcoType, (int)GiantModel.Instance.GetStableValue(this.EcoType));
		}

		// Token: 0x0602F143 RID: 192835 RVA: 0x00D21F63 File Offset: 0x00D20163
		[CompilerGenerated]
		internal static int <BuildQuestGuideData>g__Rank|52_0(EGiantQuestGuideState state)
		{
			if (state == EGiantQuestGuideState.CanGoto)
			{
				return 0;
			}
			if (state != EGiantQuestGuideState.Locked)
			{
				return 2;
			}
			return 1;
		}

		// Token: 0x04018FCA RID: 102346
		[StaticVariableRuleIgnore]
		private static readonly GiantEcoNetType[] tabEcoList = new GiantEcoNetType[]
		{
			GiantEcoNetType.Wood,
			GiantEcoNetType.Fire,
			GiantEcoNetType.Water
		};

		// Token: 0x04018FCB RID: 102347
		[StaticVariableRuleIgnore]
		private static readonly int[] tabChildList = new int[]
		{
			1,
			2,
			3
		};

		// Token: 0x04018FCC RID: 102348
		private const int TAB_NESTED_PNL_COMPLETE = 2;

		// Token: 0x04018FCD RID: 102349
		private GiantEcoNetType EcoType;

		// Token: 0x04018FCE RID: 102350
		private bool GuideOnly;

		// Token: 0x04018FCF RID: 102351
		private int BrowseLevel = 1;

		// Token: 0x04018FD0 RID: 102352
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x04018FD1 RID: 102353
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x04018FD2 RID: 102354
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<GiantQuestGuideItem, IGiantQuestGuideData> QuestGuideList;

		// Token: 0x04018FD3 RID: 102355
		private readonly HashSet<GiantEcoNetType> ViewedEcoSet = new HashSet<GiantEcoNetType>();

		// Token: 0x04018FD4 RID: 102356
		private List<IGiantQuestGuideData> CurrentGuideData = new List<IGiantQuestGuideData>();

		// Token: 0x04018FD5 RID: 102357
		private readonly Action<GiantEcoNetType?, double, double> OnStableValueChange;

		// Token: 0x04018FD6 RID: 102358
		private readonly Action<GiantEcoNetType?, EGiantStage, EGiantStage> OnStageCross;

		// Token: 0x04018FD7 RID: 102359
		private readonly Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus> OnEcoStatusChange;

		// Token: 0x04018FD8 RID: 102360
		private readonly Action<int, int, int> OnAccessProgressChange;

		// Token: 0x04018FD9 RID: 102361
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<GiantCollectedCoinItem, IGiantCollectedCoinData> CollectedList;

		// Token: 0x04018FDA RID: 102362
		[Nullable(2)]
		private GiantDeliverBtnItem DeliverBtn;

		// Token: 0x04018FDB RID: 102363
		private GiantEcoNetType? BoundDeliverEco;

		// Token: 0x0200A60F RID: 42511
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040335E3 RID: 210403
			[Nullable(0)]
			public static Func<int, int> <0>__GetItemQuality;
		}
	}
}

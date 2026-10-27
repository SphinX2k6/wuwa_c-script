using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005975 RID: 22901
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantSystemQuestView : UiViewBase
	{
		// Token: 0x0603A1E4 RID: 238052 RVA: 0x00DD0F8C File Offset: 0x00DCF18C
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

		// Token: 0x0603A1E5 RID: 238053 RVA: 0x00DD1008 File Offset: 0x00DCF208
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

		// Token: 0x0603A1E6 RID: 238054 RVA: 0x00DD14A8 File Offset: 0x00DCF6A8
		protected override void OnBeforeCreate()
		{
			IGiantSystemQuestOpenParam giantSystemQuestOpenParam = this.OpenParam as IGiantSystemQuestOpenParam;
			this.EcoType = giantSystemQuestOpenParam.EcoType;
			this.GuideOnly = giantSystemQuestOpenParam.GuideOnly.GetValueOrDefault();
		}

		// Token: 0x0603A1E7 RID: 238055 RVA: 0x00DD14E4 File Offset: 0x00DCF6E4
		protected override UniTask OnBeforeStartAsync()
		{
			GiantSystemQuestView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GiantSystemQuestView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A1E8 RID: 238056 RVA: 0x00DD1528 File Offset: 0x00DCF728
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

		// Token: 0x0603A1E9 RID: 238057 RVA: 0x00DD15E8 File Offset: 0x00DCF7E8
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

		// Token: 0x0603A1EA RID: 238058 RVA: 0x00DD1648 File Offset: 0x00DCF848
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, this.OnStableValueChange);
			EventSystem.Instance.Add<GiantEcoNetType?, EGiantStage, EGiantStage>(EEventName.OnGiantStageCross, this.OnStageCross);
			EventSystem.Instance.Add<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, this.OnEcoStatusChange);
			EventSystem.Instance.Add<int, int, int>(EEventName.OnGiantAccessProgressChange, this.OnAccessProgressChange);
		}

		// Token: 0x0603A1EB RID: 238059 RVA: 0x00DD16B0 File Offset: 0x00DCF8B0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<GiantEcoNetType?, double, double>(EEventName.OnGiantStableValueChange, this.OnStableValueChange);
			EventSystem.Instance.Remove<GiantEcoNetType?, EGiantStage, EGiantStage>(EEventName.OnGiantStageCross, this.OnStageCross);
			EventSystem.Instance.Remove<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(EEventName.OnGiantEcoStatusChange, this.OnEcoStatusChange);
			EventSystem.Instance.Remove<int, int, int>(EEventName.OnGiantAccessProgressChange, this.OnAccessProgressChange);
			this.MarkViewedEcoAccessRead();
		}

		// Token: 0x0603A1EC RID: 238060 RVA: 0x00DD171C File Offset: 0x00DCF91C
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

		// Token: 0x0603A1ED RID: 238061 RVA: 0x00DD17EC File Offset: 0x00DCF9EC
		private void OnGiantDataChange()
		{
			this.Refresh();
		}

		// Token: 0x0603A1EE RID: 238062 RVA: 0x00DD17F4 File Offset: 0x00DCF9F4
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

		// Token: 0x0603A1EF RID: 238063 RVA: 0x00DD1843 File Offset: 0x00DCFA43
		private GiantQuestGuideItem CreateQuestGuideItem()
		{
			return new GiantQuestGuideItem
			{
				OnHoverCallBack = new Action<int>(this.OnHoverQuestGuideItem)
			};
		}

		// Token: 0x0603A1F0 RID: 238064 RVA: 0x00DD185C File Offset: 0x00DCFA5C
		private void OnHoverQuestGuideItem(int gridIndex)
		{
			this.MarkGuideAccessRead(gridIndex);
		}

		// Token: 0x0603A1F1 RID: 238065 RVA: 0x00DD1868 File Offset: 0x00DCFA68
		private void MarkGuideAccessRead(int gridIndex)
		{
			IGiantQuestGuideData giantQuestGuideData = this.CurrentGuideData.ElementAtOrDefault(gridIndex);
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

		// Token: 0x0603A1F2 RID: 238066 RVA: 0x00DD18E4 File Offset: 0x00DCFAE4
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

		// Token: 0x0603A1F3 RID: 238067 RVA: 0x00DD1970 File Offset: 0x00DCFB70
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

		// Token: 0x0603A1F4 RID: 238068 RVA: 0x00DD19D4 File Offset: 0x00DCFBD4
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

		// Token: 0x0603A1F5 RID: 238069 RVA: 0x00DD1A3F File Offset: 0x00DCFC3F
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

		// Token: 0x0603A1F6 RID: 238070 RVA: 0x00DD1A64 File Offset: 0x00DCFC64
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

		// Token: 0x0603A1F7 RID: 238071 RVA: 0x00DD1ADC File Offset: 0x00DCFCDC
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

		// Token: 0x0603A1F8 RID: 238072 RVA: 0x00DD1B9C File Offset: 0x00DCFD9C
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

		// Token: 0x0603A1F9 RID: 238073 RVA: 0x00DD1BD8 File Offset: 0x00DCFDD8
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

		// Token: 0x0603A1FA RID: 238074 RVA: 0x00DD1C4C File Offset: 0x00DCFE4C
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

		// Token: 0x0603A1FB RID: 238075 RVA: 0x00DD1CD4 File Offset: 0x00DCFED4
		private void RefreshIcon(IGiantEcoDisplayConfig config, GiantEcoNetStatus status)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(config.IconSpriteNormal);
			base.TrySetSpriteByPath(resourcePath, base.GetSprite(10), false, null, null);
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(config.IconSpriteActive);
			base.TrySetSpriteByPath(resourcePath2, base.GetSprite(9), false, null, null);
			string resourcePath3 = UiResourceConfig.Instance.GetResourcePath(config.PortraitTexture);
			base.TrySetTextureByPath(resourcePath3, base.GetTexture(6), null, null);
		}

		// Token: 0x0603A1FC RID: 238076 RVA: 0x00DD1D60 File Offset: 0x00DCFF60
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

		// Token: 0x0603A1FD RID: 238077 RVA: 0x00DD1DB0 File Offset: 0x00DCFFB0
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

		// Token: 0x0603A1FE RID: 238078 RVA: 0x00DD1F00 File Offset: 0x00DD0100
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

		// Token: 0x0603A1FF RID: 238079 RVA: 0x00DD1F78 File Offset: 0x00DD0178
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

		// Token: 0x0603A200 RID: 238080 RVA: 0x00DD2018 File Offset: 0x00DD0218
		private void SetTextOutline(int name, FColor color)
		{
			UUIText text = base.GetText(name);
			if (text == null)
			{
				return;
			}
			text.SetFontOutlineColor(color);
		}

		// Token: 0x0603A201 RID: 238081 RVA: 0x00DD202C File Offset: 0x00DD022C
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

		// Token: 0x0603A202 RID: 238082 RVA: 0x00DD2078 File Offset: 0x00DD0278
		private bool IsBrowseLevelReached()
		{
			int displayLevelFromStage = this.GetDisplayLevelFromStage();
			return this.BrowseLevel < displayLevelFromStage || displayLevelFromStage >= this.GetMaxLevel();
		}

		// Token: 0x0603A203 RID: 238083 RVA: 0x00DD20A3 File Offset: 0x00DD02A3
		private bool IsBrowseLevelRewardReceived()
		{
			return this.BrowseLevel < this.GetMaxLevel() && this.IsBrowseLevelReached();
		}

		// Token: 0x0603A204 RID: 238084 RVA: 0x00DD20BC File Offset: 0x00DD02BC
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

		// Token: 0x0603A205 RID: 238085 RVA: 0x00DD218A File Offset: 0x00DD038A
		private void RefreshQuestGuide()
		{
			if (this.QuestGuideList == null)
			{
				return;
			}
			this.CurrentGuideData = this.BuildQuestGuideData();
			this.QuestGuideList.RefreshByData(this.CurrentGuideData, false, null, false);
		}

		// Token: 0x0603A206 RID: 238086 RVA: 0x00DD21B8 File Offset: 0x00DD03B8
		private List<IGiantQuestGuideData> BuildQuestGuideData()
		{
			GiantModel model = GiantModel.Instance;
			bool flag = model.GetEcoStatus(this.EcoType) == GiantEcoNetStatus.MaxStableValue;
			List<IGiantQuestGuideData> list = new List<IGiantQuestGuideData>();
			Func<GiantItemAccess, bool> <>9__3;
			Func<GiantItemAccess, bool> <>9__5;
			foreach (List<GiantItemAccess> list2 in GiantConfig.GetEcoItemAccessGroups(this.EcoType))
			{
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				foreach (GiantItemAccess giantItemAccess in list2)
				{
					IReadOnlyDictionary<int, int> accessItemInfos = model.GetAccessItemInfos(giantItemAccess.Id);
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
				IEnumerable<GiantItemAccess> source = list2;
				Func<GiantItemAccess, bool> predicate;
				if ((predicate = <>9__3) == null)
				{
					predicate = (<>9__3 = ((GiantItemAccess access) => model.GetAccessState(access.Id) == GiantItemAccessStatus.AccessLock));
				}
				bool flag2 = source.Any(predicate);
				int num2 = list3.Sum((IGiantQuestGuideItemInfo info) => info.Count);
				EGiantQuestGuideState state = flag2 ? EGiantQuestGuideState.Locked : ((num2 <= 0) ? EGiantQuestGuideState.Done : EGiantQuestGuideState.CanGoto);
				GiantItemAccess? giantItemAccess2 = null;
				foreach (GiantItemAccess value in list2)
				{
					if (model.GetAccessState(value.Id) != GiantItemAccessStatus.AccessLock && this.GetAccessRemain(value.Id) > 0)
					{
						giantItemAccess2 = new GiantItemAccess?(value);
						break;
					}
				}
				bool flag3;
				if (!flag)
				{
					IEnumerable<GiantItemAccess> source2 = list2;
					Func<GiantItemAccess, bool> predicate2;
					if ((predicate2 = <>9__5) == null)
					{
						predicate2 = (<>9__5 = ((GiantItemAccess access) => model.HasNewAccess(access.Id)));
					}
					flag3 = source2.Any(predicate2);
				}
				else
				{
					flag3 = false;
				}
				bool flag4 = flag3;
				bool flag5 = giantItemAccess2 != null && GiantConfig.GetAccessHasSkip(giantItemAccess2.Value.AccessPathId);
				GiantItemAccess giantItemAccess3 = list2.Aggregate(list2[0], delegate(GiantItemAccess min, GiantItemAccess access)
				{
					if (access.Id >= min.Id)
					{
						return min;
					}
					return access;
				});
				List<int> list4 = (from access in list2
				select access.Id).ToList<int>();
				list.Add(new GiantQuestGuideData
				{
					AccessId = giantItemAccess3.Id,
					GroupAccessIds = list4,
					SkipConfigId = ((giantItemAccess2 != null) ? giantItemAccess2.GetValueOrDefault().AccessPathId : 0),
					AnchorItemId = ((list3.Count > 0) ? list3[0].ItemId : 0),
					DescText = GiantConfig.ResolveLocalTextOrKey(giantItemAccess3.Desc),
					LockedText = GiantConfig.GetAccessUnlockHintText(giantItemAccess3.AccessPathId),
					State = state,
					Items = list3,
					HasNew = flag4,
					HasSkip = flag5,
					OnGoto = new Action<IGiantQuestGuideData>(this.OnGotoAccess)
				});
				if (flag4 && !flag5)
				{
					foreach (int accessId in list4)
					{
						if (model.GetAccessState(accessId) != GiantItemAccessStatus.AccessLock)
						{
							model.MarkAccessReadSilently(accessId);
						}
					}
				}
			}
			return (from d in list
			orderby GiantSystemQuestView.<BuildQuestGuideData>g__Rank|52_0(d.State)
			select d).ToList<IGiantQuestGuideData>();
		}

		// Token: 0x0603A207 RID: 238087 RVA: 0x00DD269C File Offset: 0x00DD089C
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

		// Token: 0x0603A208 RID: 238088 RVA: 0x00DD26FC File Offset: 0x00DD08FC
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

		// Token: 0x0603A209 RID: 238089 RVA: 0x00DD2780 File Offset: 0x00DD0980
		private void RefreshCollectedItems()
		{
			if (this.CollectedList == null)
			{
				return;
			}
			InventoryModel inventory = InventoryModel.Instance;
			List<IGiantCollectedCoinData> data = (from itemId in (from itemId in GiantConfig.GetEcoItemIds(this.EcoType)
			orderby GiantConfig.GetItemQuality(itemId) descending
			select itemId).ToList<int>()
			select new GiantCollectedCoinData
			{
				ItemId = itemId,
				Count = inventory.GetItemCountByConfigId(itemId, 0)
			}).ToList<IGiantCollectedCoinData>();
			this.CollectedList.RefreshByData(data, null, false);
		}

		// Token: 0x0603A20A RID: 238090 RVA: 0x00DD2800 File Offset: 0x00DD0A00
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

		// Token: 0x0603A20B RID: 238091 RVA: 0x00DD2887 File Offset: 0x00DD0A87
		private void OnClickLevelPre()
		{
			this.SwitchLevel(-1);
		}

		// Token: 0x0603A20C RID: 238092 RVA: 0x00DD2890 File Offset: 0x00DD0A90
		private void OnClickLevelNext()
		{
			this.SwitchLevel(1);
		}

		// Token: 0x0603A20D RID: 238093 RVA: 0x00DD289C File Offset: 0x00DD0A9C
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

		// Token: 0x0603A20E RID: 238094 RVA: 0x00DD28FA File Offset: 0x00DD0AFA
		private int GetBrowseCap()
		{
			return this.GetMaxLevel();
		}

		// Token: 0x0603A20F RID: 238095 RVA: 0x00DD2904 File Offset: 0x00DD0B04
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

		// Token: 0x0603A210 RID: 238096 RVA: 0x00DD2974 File Offset: 0x00DD0B74
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

		// Token: 0x0603A211 RID: 238097 RVA: 0x00DD29EE File Offset: 0x00DD0BEE
		private bool IsEcoWholeLocked()
		{
			return GiantModel.Instance.GetEcoStatus(this.EcoType) == GiantEcoNetStatus.Lock;
		}

		// Token: 0x0603A212 RID: 238098 RVA: 0x00DD2A03 File Offset: 0x00DD0C03
		private bool IsItemLocked(int itemId)
		{
			return this.IsEcoWholeLocked() || GiantModel.Instance.GetItemLocked(itemId);
		}

		// Token: 0x0603A213 RID: 238099 RVA: 0x00DD2A1C File Offset: 0x00DD0C1C
		private int GetMaxLevel()
		{
			int num = GiantConfig.GetEcoGoals(this.EcoType).Length;
			if (num <= 0)
			{
				return 1;
			}
			return num + 1;
		}

		// Token: 0x0603A214 RID: 238100 RVA: 0x00DD2A40 File Offset: 0x00DD0C40
		private int GetDisplayLevelFromStage()
		{
			return GiantConfig.GetEcoLevelByValue(this.EcoType, (int)GiantModel.Instance.GetStableValue(this.EcoType));
		}

		// Token: 0x0603A21D RID: 238109 RVA: 0x00DD2AD3 File Offset: 0x00DD0CD3
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

		// Token: 0x0401E52C RID: 124204
		[StaticVariableRuleIgnore]
		private static readonly GiantEcoNetType[] tabEcoList = new GiantEcoNetType[]
		{
			GiantEcoNetType.Wood,
			GiantEcoNetType.Fire,
			GiantEcoNetType.Water
		};

		// Token: 0x0401E52D RID: 124205
		[StaticVariableRuleIgnore]
		private static readonly int[] tabChildList = new int[]
		{
			1,
			2,
			3
		};

		// Token: 0x0401E52E RID: 124206
		private const int TAB_NESTED_PNL_COMPLETE = 2;

		// Token: 0x0401E52F RID: 124207
		private GiantEcoNetType EcoType;

		// Token: 0x0401E530 RID: 124208
		private bool GuideOnly;

		// Token: 0x0401E531 RID: 124209
		private int BrowseLevel = 1;

		// Token: 0x0401E532 RID: 124210
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0401E533 RID: 124211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0401E534 RID: 124212
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<GiantQuestGuideItem, IGiantQuestGuideData> QuestGuideList;

		// Token: 0x0401E535 RID: 124213
		private readonly HashSet<GiantEcoNetType> ViewedEcoSet = new HashSet<GiantEcoNetType>();

		// Token: 0x0401E536 RID: 124214
		private List<IGiantQuestGuideData> CurrentGuideData = new List<IGiantQuestGuideData>();

		// Token: 0x0401E537 RID: 124215
		private readonly Action<GiantEcoNetType?, double, double> OnStableValueChange;

		// Token: 0x0401E538 RID: 124216
		private readonly Action<GiantEcoNetType?, EGiantStage, EGiantStage> OnStageCross;

		// Token: 0x0401E539 RID: 124217
		private readonly Action<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus> OnEcoStatusChange;

		// Token: 0x0401E53A RID: 124218
		private readonly Action<int, int, int> OnAccessProgressChange;

		// Token: 0x0401E53B RID: 124219
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<GiantCollectedCoinItem, IGiantCollectedCoinData> CollectedList;

		// Token: 0x0401E53C RID: 124220
		[Nullable(2)]
		private GiantDeliverBtnItem DeliverBtn;

		// Token: 0x0401E53D RID: 124221
		private GiantEcoNetType? BoundDeliverEco;
	}
}

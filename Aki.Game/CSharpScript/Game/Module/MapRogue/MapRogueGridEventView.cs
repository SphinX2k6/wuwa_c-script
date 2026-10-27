using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055FD RID: 22013
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueGridEventView : UiViewBase
	{
		// Token: 0x06038088 RID: 229512 RVA: 0x00D45176 File Offset: 0x00D43376
		public MapRogueGridEventView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038089 RID: 229513 RVA: 0x00D45194 File Offset: 0x00D43394
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.SetVisible)),
				new ValueTuple<int, Delegate>(8, new Action(this.OnMaskBtnClick)),
				new ValueTuple<int, Delegate>(9, new Action(this.SetAuto))
			};
		}

		// Token: 0x0603808A RID: 229514 RVA: 0x00D4533C File Offset: 0x00D4353C
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueGridEventView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueGridEventView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603808B RID: 229515 RVA: 0x00D4537F File Offset: 0x00D4357F
		protected override void OnBeforeShow()
		{
			this.RefreshLv(false);
			this.RefreshMood(false);
		}

		// Token: 0x0603808C RID: 229516 RVA: 0x00D45390 File Offset: 0x00D43590
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
			EventSystem.Instance.Add<int>(EEventName.RogueResTeamLvChange, new Action<int>(this.OnRogueResTeamLvChange));
			EventSystem.Instance.Add<int, int, int>(EEventName.RogueResMoodChange, new Action<int, int, int>(this.OnRogueResMoodChange));
		}

		// Token: 0x0603808D RID: 229517 RVA: 0x00D453F4 File Offset: 0x00D435F4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
			EventSystem.Instance.Remove(EEventName.RogueResTeamLvChange, new Action<int>(this.OnRogueResTeamLvChange));
			EventSystem.Instance.Remove(EEventName.RogueResMoodChange, new Action<int, int, int>(this.OnRogueResMoodChange));
		}

		// Token: 0x0603808E RID: 229518 RVA: 0x00D45455 File Offset: 0x00D43655
		protected override void OnBeforeDestroy()
		{
			if (this.OpData != null)
			{
				this.OpData.EventStepUpdateFunc = null;
				this.OpData = null;
			}
			this.StepItemList.Clear();
		}

		// Token: 0x0603808F RID: 229519 RVA: 0x00D45480 File Offset: 0x00D43680
		private UniTask InitCaption()
		{
			MapRogueGridEventView.<InitCaption>d__20 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<MapRogueGridEventView.<InitCaption>d__20>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06038090 RID: 229520 RVA: 0x00D454C3 File Offset: 0x00D436C3
		private void SetVisible()
		{
			this.VisibleState = !this.VisibleState;
			base.GetItem(7).SetUIActive(this.VisibleState);
			base.GetItem(1).SetUIActive(this.VisibleState);
		}

		// Token: 0x06038091 RID: 229521 RVA: 0x00D454F8 File Offset: 0x00D436F8
		private void SetAuto()
		{
			IEventStepItem currentStepItem = this.GetCurrentStepItem();
			if (currentStepItem == null || currentStepItem.StepType != EStepType.Desc)
			{
				return;
			}
			this.AutoState = true;
			if (this.ViewState == EViewState.Anim)
			{
				this.OnMaskBtnClick();
				this.OnMaskBtnClick();
				return;
			}
			if (this.ViewState == EViewState.CanInteract)
			{
				this.OnMaskBtnClick();
			}
		}

		// Token: 0x06038092 RID: 229522 RVA: 0x00D45545 File Offset: 0x00D43745
		private void OnBackBtnClick()
		{
			if (this.ViewState == EViewState.Forbidden)
			{
				return;
			}
			MapRogueController.Instance.OpenExploreEnd(false);
		}

		// Token: 0x06038093 RID: 229523 RVA: 0x00D4555C File Offset: 0x00D4375C
		private void UpdateBg(int newBgId, bool needAnim)
		{
			if (newBgId == 0)
			{
				return;
			}
			if (this.CurrentBgId == newBgId)
			{
				return;
			}
			this.CurrentBgId = newBgId;
			if (!needAnim)
			{
				this.RefreshBg();
				return;
			}
			if (!this.UiViewSequence.HasSequenceNameInPlaying("Switch"))
			{
				this.UiViewSequence.PlaySequence("Switch", false, null);
				return;
			}
			this.RefreshBg();
		}

		// Token: 0x06038094 RID: 229524 RVA: 0x00D455BC File Offset: 0x00D437BC
		private void RefreshLv(bool needAnim)
		{
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo != null)
			{
				this.PanelLv.SetLv(gameInfo.TeamLv, needAnim);
			}
		}

		// Token: 0x06038095 RID: 229525 RVA: 0x00D455EC File Offset: 0x00D437EC
		private void RefreshMood(bool needAnim)
		{
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo == null)
			{
				return;
			}
			this.MoodBar.SetLimit(gameInfo.MoodMin, gameInfo.MoodMax);
			if (!needAnim)
			{
				this.TempMood = gameInfo.Mood;
				this.MoodBar.SetCurrentValue(gameInfo.Mood);
				return;
			}
			int changeValue = gameInfo.Mood - this.TempMood;
			this.MoodBar.ShowPreviewValue(changeValue, gameInfo.Mood);
			this.TempMood = gameInfo.Mood;
		}

		// Token: 0x06038096 RID: 229526 RVA: 0x00D4566C File Offset: 0x00D4386C
		private void OnActivitySequenceEmitEvent(string eventName)
		{
			if (eventName != "Change")
			{
				return;
			}
			this.RefreshBg();
		}

		// Token: 0x06038097 RID: 229527 RVA: 0x00D45682 File Offset: 0x00D43882
		private void OnRogueResTeamLvChange(int lv)
		{
			this.RefreshLv(true);
		}

		// Token: 0x06038098 RID: 229528 RVA: 0x00D4568B File Offset: 0x00D4388B
		private void OnRogueResMoodChange(int curMood, int minMood, int maxMood)
		{
			this.RefreshMood(true);
		}

		// Token: 0x06038099 RID: 229529 RVA: 0x00D45694 File Offset: 0x00D43894
		private void RefreshBg()
		{
			RogueResEventBg? eventBgById = MapRogueConfig.Instance.GetEventBgById(this.CurrentBgId);
			if (eventBgById == null)
			{
				return;
			}
			UUITexture texBg = base.GetTexture(0);
			UUIItem item = base.GetItem(11);
			USpineSkeletonAnimationComponent spine = base.GetSpine(10);
			bool flag = !StringUtils.IsEmpty(eventBgById.Value.BgPath) || !StringUtils.IsEmpty(eventBgById.Value.BgFemalePath);
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			if (flag)
			{
				string path = (playerGender == EPlayerGender.Female) ? eventBgById.Value.BgFemalePath : eventBgById.Value.BgPath;
				base.SetTextureByPath(path, texBg, null, delegate(bool _)
				{
					texBg.SetSizeFromTexture();
				});
			}
			else
			{
				string atlasPath = (playerGender == EPlayerGender.Female) ? eventBgById.Value.BgSpineAtlasFemalePath : eventBgById.Value.BgSpineAtlasPath;
				string skeletonPath = (playerGender == EPlayerGender.Female) ? eventBgById.Value.BgSpineSkeletonFemalePath : eventBgById.Value.BgSpineSkeletonPath;
				base.SetSpineAssetByPath(atlasPath, skeletonPath, spine);
				spine.SetAnimation(0, "idle", true);
			}
			texBg.SetUIActive(flag);
			item.SetUIActive(!flag);
		}

		// Token: 0x0603809A RID: 229530 RVA: 0x00D457F0 File Offset: 0x00D439F0
		private void UpdateBgm(int newBgmId)
		{
			if (newBgmId == 0)
			{
				return;
			}
			if (this.CurrentBgmId == newBgmId)
			{
				return;
			}
			this.CurrentBgmId = newBgmId;
			RogueResEventBgm? eventBgmById = MapRogueConfig.Instance.GetEventBgmById(newBgmId);
			if (eventBgmById == null)
			{
				return;
			}
			string bgmPath = eventBgmById.Value.BgmPath;
			AudioSystem.Instance.PostEvent(bgmPath);
		}

		// Token: 0x17008718 RID: 34584
		// (get) Token: 0x0603809C RID: 229532 RVA: 0x00D45857 File Offset: 0x00D43A57
		// (set) Token: 0x0603809B RID: 229531 RVA: 0x00D45844 File Offset: 0x00D43A44
		protected EViewState ViewState
		{
			get
			{
				return this.ViewStateInternal;
			}
			set
			{
				if (this.ViewStateInternal == value)
				{
					return;
				}
				this.ViewStateInternal = value;
			}
		}

		// Token: 0x0603809D RID: 229533 RVA: 0x00D4585F File Offset: 0x00D43A5F
		[NullableContext(2)]
		private bool OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
		{
			this.IsDragging = true;
			return true;
		}

		// Token: 0x0603809E RID: 229534 RVA: 0x00D45869 File Offset: 0x00D43A69
		[NullableContext(2)]
		private bool OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
		{
			this.IsDragging = false;
			return true;
		}

		// Token: 0x0603809F RID: 229535 RVA: 0x00D45874 File Offset: 0x00D43A74
		private void OnMaskBtnClick()
		{
			if (this.IsDragging)
			{
				return;
			}
			IEventStepItem currentStepItem = this.GetCurrentStepItem();
			if (currentStepItem == null)
			{
				return;
			}
			switch (currentStepItem.StepType)
			{
			case EStepType.Desc:
				if (this.ViewState == EViewState.Anim)
				{
					currentStepItem.MaskClick();
					return;
				}
				if (this.ViewState == EViewState.CanInteract)
				{
					base.GetItem(5).SetUIActive(false);
					base.GetItem(6).SetUIActive(false);
					base.GetButton(8).RootUIComp.Get().SetUIActive(false);
					this.ExecuteStep(currentStepItem.StepId, 0);
					return;
				}
				break;
			case EStepType.Choose:
			case EStepType.ChooseEffect:
				break;
			case EStepType.Ending:
				if (this.ViewState == EViewState.CanInteract)
				{
					base.GetButton(8).RootUIComp.Get().SetUIActive(false);
					this.ExecuteStep(currentStepItem.StepId, 0);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x060380A0 RID: 229536 RVA: 0x00D45940 File Offset: 0x00D43B40
		private UUIItem GetParentItem()
		{
			return base.GetVerticalLayout(3).RootUIComp.Get();
		}

		// Token: 0x060380A1 RID: 229537 RVA: 0x00D45964 File Offset: 0x00D43B64
		[NullableContext(2)]
		private IEventStepItem GetCurrentStepItem()
		{
			int count = this.StepItemList.Count;
			if (count > 0)
			{
				return this.StepItemList[count - 1];
			}
			return null;
		}

		// Token: 0x060380A2 RID: 229538 RVA: 0x00D45994 File Offset: 0x00D43B94
		private void ScrollToBottom(UUIItem item)
		{
			MapRogueGridEventView.<>c__DisplayClass41_0 CS$<>8__locals1 = new MapRogueGridEventView.<>c__DisplayClass41_0();
			CS$<>8__locals1.item = item;
			CS$<>8__locals1.scrollView = base.GetScrollViewWithScrollbar(2);
			MapRogueGridEventView.<>c__DisplayClass41_0 CS$<>8__locals2 = CS$<>8__locals1;
			FVector relativeLocation = CS$<>8__locals1.scrollView.ContentUIItem.Get().RelativeLocation;
			CS$<>8__locals2.pos = new FVector2D(ref relativeLocation);
			TimerSystem.Instance.Delay(delegate(float _)
			{
				CS$<>8__locals1.scrollView.ScrollToBottom(ref CS$<>8__locals1.pos, CS$<>8__locals1.item, false);
			}, 100f, null, null, true, 1f);
		}

		// Token: 0x060380A3 RID: 229539 RVA: 0x00D45A08 File Offset: 0x00D43C08
		protected UniTask CreateComponentChoice(int stepId, IList<EventOption> options)
		{
			MapRogueGridEventView.<CreateComponentChoice>d__42 <CreateComponentChoice>d__;
			<CreateComponentChoice>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateComponentChoice>d__.<>4__this = this;
			<CreateComponentChoice>d__.stepId = stepId;
			<CreateComponentChoice>d__.options = options;
			<CreateComponentChoice>d__.<>1__state = -1;
			<CreateComponentChoice>d__.<>t__builder.Start<MapRogueGridEventView.<CreateComponentChoice>d__42>(ref <CreateComponentChoice>d__);
			return <CreateComponentChoice>d__.<>t__builder.Task;
		}

		// Token: 0x060380A4 RID: 229540 RVA: 0x00D45A5C File Offset: 0x00D43C5C
		protected UniTask CreateComponentDesc(int stepId)
		{
			MapRogueGridEventView.<CreateComponentDesc>d__43 <CreateComponentDesc>d__;
			<CreateComponentDesc>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateComponentDesc>d__.<>4__this = this;
			<CreateComponentDesc>d__.stepId = stepId;
			<CreateComponentDesc>d__.<>1__state = -1;
			<CreateComponentDesc>d__.<>t__builder.Start<MapRogueGridEventView.<CreateComponentDesc>d__43>(ref <CreateComponentDesc>d__);
			return <CreateComponentDesc>d__.<>t__builder.Task;
		}

		// Token: 0x060380A5 RID: 229541 RVA: 0x00D45AA8 File Offset: 0x00D43CA8
		protected UniTask CreateComponentEnding(int stepId)
		{
			MapRogueGridEventView.<CreateComponentEnding>d__44 <CreateComponentEnding>d__;
			<CreateComponentEnding>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateComponentEnding>d__.<>4__this = this;
			<CreateComponentEnding>d__.stepId = stepId;
			<CreateComponentEnding>d__.<>1__state = -1;
			<CreateComponentEnding>d__.<>t__builder.Start<MapRogueGridEventView.<CreateComponentEnding>d__44>(ref <CreateComponentEnding>d__);
			return <CreateComponentEnding>d__.<>t__builder.Task;
		}

		// Token: 0x060380A6 RID: 229542 RVA: 0x00D45AF4 File Offset: 0x00D43CF4
		private void CanInteractCallback(int stepId, EStepType type)
		{
			switch (type)
			{
			case EStepType.Desc:
				base.GetItem(5).SetUIActive(false);
				base.GetItem(6).SetUIActive(true);
				break;
			case EStepType.Choose:
				base.GetButton(8).RootUIComp.Get().SetUIActive(false);
				break;
			case EStepType.Ending:
				base.GetButton(8).RootUIComp.Get().SetUIActive(false);
				break;
			}
			this.ViewState = EViewState.CanInteract;
		}

		// Token: 0x060380A7 RID: 229543 RVA: 0x00D45B74 File Offset: 0x00D43D74
		private void ExecuteStep(int stepId, int optionId)
		{
			MapRogueOpGridEvent opData = this.OpData;
			if (opData == null)
			{
				return;
			}
			opData.ExecuteStep(stepId, optionId);
		}

		// Token: 0x060380A8 RID: 229544 RVA: 0x00D45B88 File Offset: 0x00D43D88
		private void OnGridEventStepUpdate(int stepId)
		{
			this.UpdateBg(this.OpData.CurrentPlotBgId, true);
			this.UpdateBgm(this.OpData.CurrentPlotBgmId);
			this.StepStart(stepId);
		}

		// Token: 0x060380A9 RID: 229545 RVA: 0x00D45BB8 File Offset: 0x00D43DB8
		private UniTask StepStart(int stepId)
		{
			MapRogueGridEventView.<StepStart>d__48 <StepStart>d__;
			<StepStart>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StepStart>d__.<>4__this = this;
			<StepStart>d__.stepId = stepId;
			<StepStart>d__.<>1__state = -1;
			<StepStart>d__.<>t__builder.Start<MapRogueGridEventView.<StepStart>d__48>(ref <StepStart>d__);
			return <StepStart>d__.<>t__builder.Task;
		}

		// Token: 0x0401D72E RID: 120622
		private const string SPINE_DEFAULT_ANIM_NAME = "idle";

		// Token: 0x0401D72F RID: 120623
		private int TempMood;

		// Token: 0x0401D730 RID: 120624
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D731 RID: 120625
		[Nullable(2)]
		private MapRoguePanelLv PanelLv;

		// Token: 0x0401D732 RID: 120626
		[Nullable(2)]
		private MapRogueMoodBar MoodBar;

		// Token: 0x0401D733 RID: 120627
		private readonly List<IEventStepItem> StepItemList = new List<IEventStepItem>();

		// Token: 0x0401D734 RID: 120628
		private EViewState ViewStateInternal;

		// Token: 0x0401D735 RID: 120629
		private bool VisibleState = true;

		// Token: 0x0401D736 RID: 120630
		protected bool AutoState;

		// Token: 0x0401D737 RID: 120631
		private int OpIncId;

		// Token: 0x0401D738 RID: 120632
		[Nullable(2)]
		protected MapRogueOpGridEvent OpData;

		// Token: 0x0401D739 RID: 120633
		protected int CurrentBgId;

		// Token: 0x0401D73A RID: 120634
		protected int CurrentBgmId;

		// Token: 0x0401D73B RID: 120635
		private bool IsDragging;
	}
}

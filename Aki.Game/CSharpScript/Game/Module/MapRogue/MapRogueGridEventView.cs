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
	// Token: 0x020045D3 RID: 17875
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueGridEventView : UiViewBase
	{
		// Token: 0x0602CF86 RID: 184198 RVA: 0x00C92EBE File Offset: 0x00C910BE
		public MapRogueGridEventView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602CF87 RID: 184199 RVA: 0x00C92EDC File Offset: 0x00C910DC
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

		// Token: 0x0602CF88 RID: 184200 RVA: 0x00C93084 File Offset: 0x00C91284
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueGridEventView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueGridEventView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CF89 RID: 184201 RVA: 0x00C930C7 File Offset: 0x00C912C7
		protected override void OnBeforeShow()
		{
			this.RefreshLv(false);
			this.RefreshMood(false);
		}

		// Token: 0x0602CF8A RID: 184202 RVA: 0x00C930D8 File Offset: 0x00C912D8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
			EventSystem.Instance.Add<int>(EEventName.RogueResTeamLvChange, new Action<int>(this.OnRogueResTeamLvChange));
			EventSystem.Instance.Add<int, int, int>(EEventName.RogueResMoodChange, new Action<int, int, int>(this.OnRogueResMoodChange));
		}

		// Token: 0x0602CF8B RID: 184203 RVA: 0x00C9313C File Offset: 0x00C9133C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
			EventSystem.Instance.Remove(EEventName.RogueResTeamLvChange, new Action<int>(this.OnRogueResTeamLvChange));
			EventSystem.Instance.Remove(EEventName.RogueResMoodChange, new Action<int, int, int>(this.OnRogueResMoodChange));
		}

		// Token: 0x0602CF8C RID: 184204 RVA: 0x00C9319D File Offset: 0x00C9139D
		protected override void OnBeforeDestroy()
		{
			if (this.OpData != null)
			{
				this.OpData.EventStepUpdateFunc = null;
				this.OpData = null;
			}
			this.StepItemList.Clear();
		}

		// Token: 0x0602CF8D RID: 184205 RVA: 0x00C931C8 File Offset: 0x00C913C8
		private UniTask InitCaption()
		{
			MapRogueGridEventView.<InitCaption>d__20 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<MapRogueGridEventView.<InitCaption>d__20>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0602CF8E RID: 184206 RVA: 0x00C9320B File Offset: 0x00C9140B
		private void SetVisible()
		{
			this.VisibleState = !this.VisibleState;
			base.GetItem(7).SetUIActive(this.VisibleState);
			base.GetItem(1).SetUIActive(this.VisibleState);
		}

		// Token: 0x0602CF8F RID: 184207 RVA: 0x00C93240 File Offset: 0x00C91440
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

		// Token: 0x0602CF90 RID: 184208 RVA: 0x00C9328D File Offset: 0x00C9148D
		private void OnBackBtnClick()
		{
			if (this.ViewState == EViewState.Forbidden)
			{
				return;
			}
			MapRogueController.Instance.OpenExploreEnd(false);
		}

		// Token: 0x0602CF91 RID: 184209 RVA: 0x00C932A4 File Offset: 0x00C914A4
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

		// Token: 0x0602CF92 RID: 184210 RVA: 0x00C93304 File Offset: 0x00C91504
		private void RefreshLv(bool needAnim)
		{
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo != null)
			{
				this.PanelLv.SetLv(gameInfo.TeamLv, needAnim);
			}
		}

		// Token: 0x0602CF93 RID: 184211 RVA: 0x00C93334 File Offset: 0x00C91534
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

		// Token: 0x0602CF94 RID: 184212 RVA: 0x00C933B4 File Offset: 0x00C915B4
		private void OnActivitySequenceEmitEvent(string eventName)
		{
			if (eventName != "Change")
			{
				return;
			}
			this.RefreshBg();
		}

		// Token: 0x0602CF95 RID: 184213 RVA: 0x00C933CA File Offset: 0x00C915CA
		private void OnRogueResTeamLvChange(int lv)
		{
			this.RefreshLv(true);
		}

		// Token: 0x0602CF96 RID: 184214 RVA: 0x00C933D3 File Offset: 0x00C915D3
		private void OnRogueResMoodChange(int curMood, int minMood, int maxMood)
		{
			this.RefreshMood(true);
		}

		// Token: 0x0602CF97 RID: 184215 RVA: 0x00C933DC File Offset: 0x00C915DC
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

		// Token: 0x0602CF98 RID: 184216 RVA: 0x00C93538 File Offset: 0x00C91738
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

		// Token: 0x17005ADF RID: 23263
		// (get) Token: 0x0602CF9A RID: 184218 RVA: 0x00C9359F File Offset: 0x00C9179F
		// (set) Token: 0x0602CF99 RID: 184217 RVA: 0x00C9358C File Offset: 0x00C9178C
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

		// Token: 0x0602CF9B RID: 184219 RVA: 0x00C935A7 File Offset: 0x00C917A7
		[NullableContext(2)]
		private bool OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
		{
			this.IsDragging = true;
			return true;
		}

		// Token: 0x0602CF9C RID: 184220 RVA: 0x00C935B1 File Offset: 0x00C917B1
		[NullableContext(2)]
		private bool OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
		{
			this.IsDragging = false;
			return true;
		}

		// Token: 0x0602CF9D RID: 184221 RVA: 0x00C935BC File Offset: 0x00C917BC
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

		// Token: 0x0602CF9E RID: 184222 RVA: 0x00C93688 File Offset: 0x00C91888
		private UUIItem GetParentItem()
		{
			return base.GetVerticalLayout(3).RootUIComp.Get();
		}

		// Token: 0x0602CF9F RID: 184223 RVA: 0x00C936AC File Offset: 0x00C918AC
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

		// Token: 0x0602CFA0 RID: 184224 RVA: 0x00C936DC File Offset: 0x00C918DC
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

		// Token: 0x0602CFA1 RID: 184225 RVA: 0x00C93750 File Offset: 0x00C91950
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

		// Token: 0x0602CFA2 RID: 184226 RVA: 0x00C937A4 File Offset: 0x00C919A4
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

		// Token: 0x0602CFA3 RID: 184227 RVA: 0x00C937F0 File Offset: 0x00C919F0
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

		// Token: 0x0602CFA4 RID: 184228 RVA: 0x00C9383C File Offset: 0x00C91A3C
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

		// Token: 0x0602CFA5 RID: 184229 RVA: 0x00C938BC File Offset: 0x00C91ABC
		private void ExecuteStep(int stepId, int optionId)
		{
			MapRogueOpGridEvent opData = this.OpData;
			if (opData == null)
			{
				return;
			}
			opData.ExecuteStep(stepId, optionId);
		}

		// Token: 0x0602CFA6 RID: 184230 RVA: 0x00C938D0 File Offset: 0x00C91AD0
		private void OnGridEventStepUpdate(int stepId)
		{
			this.UpdateBg(this.OpData.CurrentPlotBgId, true);
			this.UpdateBgm(this.OpData.CurrentPlotBgmId);
			this.StepStart(stepId);
		}

		// Token: 0x0602CFA7 RID: 184231 RVA: 0x00C93900 File Offset: 0x00C91B00
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

		// Token: 0x040181B9 RID: 98745
		private const string SPINE_DEFAULT_ANIM_NAME = "idle";

		// Token: 0x040181BA RID: 98746
		private int TempMood;

		// Token: 0x040181BB RID: 98747
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040181BC RID: 98748
		[Nullable(2)]
		private MapRoguePanelLv PanelLv;

		// Token: 0x040181BD RID: 98749
		[Nullable(2)]
		private MapRogueMoodBar MoodBar;

		// Token: 0x040181BE RID: 98750
		private readonly List<IEventStepItem> StepItemList = new List<IEventStepItem>();

		// Token: 0x040181BF RID: 98751
		private EViewState ViewStateInternal;

		// Token: 0x040181C0 RID: 98752
		private bool VisibleState = true;

		// Token: 0x040181C1 RID: 98753
		protected bool AutoState;

		// Token: 0x040181C2 RID: 98754
		private int OpIncId;

		// Token: 0x040181C3 RID: 98755
		[Nullable(2)]
		protected MapRogueOpGridEvent OpData;

		// Token: 0x040181C4 RID: 98756
		protected int CurrentBgId;

		// Token: 0x040181C5 RID: 98757
		protected int CurrentBgmId;

		// Token: 0x040181C6 RID: 98758
		private bool IsDragging;
	}
}

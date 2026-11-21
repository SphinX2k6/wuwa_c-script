using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FB7 RID: 24503
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingQteView : UiTickViewBase
	{
		// Token: 0x0603AE02 RID: 241154 RVA: 0x010A2E8D File Offset: 0x010A108D
		[NullableContext(1)]
		public FishingQteView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603AE03 RID: 241155 RVA: 0x010A2E98 File Offset: 0x010A1098
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603AE04 RID: 241156 RVA: 0x010A3030 File Offset: 0x010A1230
		protected override UniTask OnBeforeStartAsync()
		{
			FishingQteView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingQteView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE05 RID: 241157 RVA: 0x010A3073 File Offset: 0x010A1273
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.OnFishingQteStageUpdate, new Action<EFishingQteStage>(this.OnGameStageUpdate));
			EventSystem.Instance.Add(EEventName.OnFishingQteAreaChange, new Action<int>(this.OnFishingQteAreaChange));
			this.Init();
		}

		// Token: 0x0603AE06 RID: 241158 RVA: 0x010A30B4 File Offset: 0x010A12B4
		private void Init()
		{
			this.GameInfo.SetGameStage(EFishingQteStage.Ready);
			this.TagItem.Refresh(FishingQteModel.Instance.CurrentFishingPointConfigId);
			this.RefreshFishingPointCount();
			this.RingItem.InitRing();
			this.GameInfo.GetRingInfo().EnterNextValidArea();
			this.ButtonItem.SetPauseWithoutAnim(false);
			int maxRound = this.GameInfo.MaxRound;
			List<int> list = new List<int>(maxRound);
			for (int i = 0; i < maxRound; i++)
			{
				list.Add(0);
			}
			this.FishIconLayout.RefreshByData(list, null, false);
			this.UiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
			{
				this.SetGameStart();
			}, false);
		}

		// Token: 0x0603AE07 RID: 241159 RVA: 0x010A3160 File Offset: 0x010A1360
		protected override void OnBeforeShow()
		{
			this.CabinItem.RefreshCabin();
		}

		// Token: 0x0603AE08 RID: 241160 RVA: 0x010A316D File Offset: 0x010A136D
		protected override void OnAfterShow()
		{
		}

		// Token: 0x0603AE09 RID: 241161 RVA: 0x010A3170 File Offset: 0x010A1370
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnFishingQteStageUpdate, new Action<EFishingQteStage>(this.OnGameStageUpdate));
			EventSystem.Instance.Remove(EEventName.OnFishingQteAreaChange, new Action<int>(this.OnFishingQteAreaChange));
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603AE0A RID: 241162 RVA: 0x010A31CD File Offset: 0x010A13CD
		protected override void OnAfterDestroy()
		{
			Action finishCallback = this.FinishCallback;
			if (finishCallback == null)
			{
				return;
			}
			finishCallback();
		}

		// Token: 0x0603AE0B RID: 241163 RVA: 0x010A31E0 File Offset: 0x010A13E0
		protected override void OnTick(float delta)
		{
			FishingProgressItem progressItem = this.ProgressItem;
			if (progressItem != null)
			{
				progressItem.OnTick(delta);
			}
			FishingQteRingItem ringItem = this.RingItem;
			if (ringItem != null)
			{
				ringItem.OnTick(delta);
			}
			FishingButtonItem buttonItem = this.ButtonItem;
			if (buttonItem != null)
			{
				buttonItem.OnTick(delta);
			}
			FishingGetScrollItem getScrollItem = this.GetScrollItem;
			if (getScrollItem != null)
			{
				getScrollItem.OnTick(delta);
			}
			if (this.GameInfo.IsGamePause())
			{
				return;
			}
			float num = delta / 1000f;
			this.GameInfo.CurrentScore += FishingQteModel.Instance.ScoreUp * num;
			if (this.GameInfo.CurrentScore >= (float)this.GameConfig.MaxScore)
			{
				EventSystem.Instance.Emit(EEventName.OnFishingQteScoreReachedMaximum);
				this.EnterNextRound();
			}
		}

		// Token: 0x0603AE0C RID: 241164 RVA: 0x010A3298 File Offset: 0x010A1498
		private void EnterNextRound()
		{
			FishingQteModel.Instance.EnterNextRound();
			this.PlayAnim("FishSuccess");
			this.ProgressItem.EnterNextRound();
			this.RefreshFishingPointCount();
			long currentFishingPointCreatureDataId = FishingQteModel.Instance.CurrentFishingPointCreatureDataId;
			FishingQteController.Instance.FishingGetRequest(currentFishingPointCreatureDataId, delegate(bool success, int? fishCount)
			{
				if (!success)
				{
					this.GameInfo.SetGameStage(EFishingQteStage.Pause);
					base.CloseMe(null);
					return;
				}
				if (this.GameInfo.CurrentRound == this.GameInfo.MaxRound)
				{
					this.SetGameEnd(fishCount.Value);
					return;
				}
				this.TipsTxt.ShowTip(EFishingTipsType.GetFish, fishCount.ToString(), null);
			});
		}

		// Token: 0x0603AE0D RID: 241165 RVA: 0x010A32F0 File Offset: 0x010A14F0
		private UniTask InitTips()
		{
			FishingQteView.<InitTips>d__30 <InitTips>d__;
			<InitTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTips>d__.<>4__this = this;
			<InitTips>d__.<>1__state = -1;
			<InitTips>d__.<>t__builder.Start<FishingQteView.<InitTips>d__30>(ref <InitTips>d__);
			return <InitTips>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE0E RID: 241166 RVA: 0x010A3334 File Offset: 0x010A1534
		private UniTask InitGetScrollView()
		{
			FishingQteView.<InitGetScrollView>d__31 <InitGetScrollView>d__;
			<InitGetScrollView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitGetScrollView>d__.<>4__this = this;
			<InitGetScrollView>d__.<>1__state = -1;
			<InitGetScrollView>d__.<>t__builder.Start<FishingQteView.<InitGetScrollView>d__31>(ref <InitGetScrollView>d__);
			return <InitGetScrollView>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE0F RID: 241167 RVA: 0x010A3378 File Offset: 0x010A1578
		private UniTask InitRing()
		{
			FishingQteView.<InitRing>d__32 <InitRing>d__;
			<InitRing>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRing>d__.<>4__this = this;
			<InitRing>d__.<>1__state = -1;
			<InitRing>d__.<>t__builder.Start<FishingQteView.<InitRing>d__32>(ref <InitRing>d__);
			return <InitRing>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE10 RID: 241168 RVA: 0x010A33BC File Offset: 0x010A15BC
		private UniTask InitProgressItem()
		{
			FishingQteView.<InitProgressItem>d__33 <InitProgressItem>d__;
			<InitProgressItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitProgressItem>d__.<>4__this = this;
			<InitProgressItem>d__.<>1__state = -1;
			<InitProgressItem>d__.<>t__builder.Start<FishingQteView.<InitProgressItem>d__33>(ref <InitProgressItem>d__);
			return <InitProgressItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE11 RID: 241169 RVA: 0x010A3400 File Offset: 0x010A1600
		private UniTask InitFullTipItem()
		{
			FishingQteView.<InitFullTipItem>d__34 <InitFullTipItem>d__;
			<InitFullTipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFullTipItem>d__.<>4__this = this;
			<InitFullTipItem>d__.<>1__state = -1;
			<InitFullTipItem>d__.<>t__builder.Start<FishingQteView.<InitFullTipItem>d__34>(ref <InitFullTipItem>d__);
			return <InitFullTipItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE12 RID: 241170 RVA: 0x010A3443 File Offset: 0x010A1643
		[NullableContext(1)]
		private FishingRoundItem CreateFishIcon()
		{
			return new FishingRoundItem();
		}

		// Token: 0x0603AE13 RID: 241171 RVA: 0x010A344A File Offset: 0x010A164A
		private void OnFishingQteAreaChange(int areaRelativeIndex)
		{
			this.RingItem.OnArrowStayAreaUpdate(areaRelativeIndex);
		}

		// Token: 0x0603AE14 RID: 241172 RVA: 0x010A3458 File Offset: 0x010A1658
		private void OnGameStageUpdate(EFishingQteStage currentGameStage)
		{
			switch (currentGameStage)
			{
			case EFishingQteStage.OnGoing:
			case EFishingQteStage.End:
			case EFishingQteStage.Success:
				break;
			case EFishingQteStage.Pause:
				this.ButtonItem.SetPause(true);
				return;
			case EFishingQteStage.AnimEnd:
			{
				List<DockyardItemBlockOriginalData> tempGetDataList = FishingQteModel.Instance.GetTempGetDataList();
				FishingQteController.Instance.OpenFishingSuccessView(tempGetDataList, delegate(bool success)
				{
					if (success)
					{
						FishingQteModel.Instance.GameInfo.SetGameStage(EFishingQteStage.Success);
						base.CloseMe(null);
					}
				});
				return;
			}
			case EFishingQteStage.Destroy:
				this.OnExit();
				break;
			default:
				return;
			}
		}

		// Token: 0x0603AE15 RID: 241173 RVA: 0x010A34BC File Offset: 0x010A16BC
		protected void OnExit()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603AE16 RID: 241174 RVA: 0x010A34C5 File Offset: 0x010A16C5
		private void OnClickCabin()
		{
			if (this.GameInfo.GetGameStage() == EFishingQteStage.OnGoing)
			{
				this.GameInfo.SetGameStage(EFishingQteStage.Pause);
			}
			FishingController.Instance.OpenDockyardWareHouseView(true);
		}

		// Token: 0x0603AE17 RID: 241175 RVA: 0x010A34EC File Offset: 0x010A16EC
		private void OnClickBack()
		{
			if (this.GameInfo.GetGameStage() == EFishingQteStage.OnGoing)
			{
				this.GameInfo.SetGameStage(EFishingQteStage.Pause);
			}
			UiManager.Instance.OpenView(EUiViewName.FishingQtePauseView, null, null);
		}

		// Token: 0x0603AE18 RID: 241176 RVA: 0x010A351C File Offset: 0x010A171C
		private void OnClickFishButton()
		{
			if (this.GameInfo.IsGamePause() && !this.GameInfo.IsGameEnd())
			{
				this.SetGameGoing();
				return;
			}
			FishingQteRingInfo ringInfo = this.GameInfo.GetRingInfo();
			int currentArrowStayCellIndex = ringInfo.CurrentArrowStayCellIndex;
			ContinuousRingArea continuousRingArea = ringInfo.CheckInArea(ringInfo.GetPerfectAreas(), currentArrowStayCellIndex);
			if (continuousRingArea != null)
			{
				this.OnAreaClick(EFishingAreaType.PerfectArea, continuousRingArea);
				return;
			}
			ContinuousRingArea continuousRingArea2 = ringInfo.CheckInArea(ringInfo.GetQteAreas(), currentArrowStayCellIndex);
			if (continuousRingArea2 != null)
			{
				this.OnAreaClick(EFishingAreaType.QteArea, continuousRingArea2);
				return;
			}
			this.OnAreaClick(EFishingAreaType.BlankArea, null);
		}

		// Token: 0x0603AE19 RID: 241177 RVA: 0x010A3599 File Offset: 0x010A1799
		private void SetGameStart()
		{
			this.FullTipItem.SetTxtInfo("Fishing_QTE_Start", Array.Empty<object>());
			this.FullTipItem.PlayTipSequence(new Action(this.<SetGameStart>g__startAnimFlow|42_0), "Start", true);
		}

		// Token: 0x0603AE1A RID: 241178 RVA: 0x010A35CD File Offset: 0x010A17CD
		private void SetGameGoing()
		{
			this.ButtonItem.SetPause(false);
			this.FullTipItem.SetTxtInfo("Fishing_QTE_Start", Array.Empty<object>());
			this.FullTipItem.PlayTipSequence(new Action(this.<SetGameGoing>g__startAnimFlow|43_0), "Start", true);
		}

		// Token: 0x0603AE1B RID: 241179 RVA: 0x010A360D File Offset: 0x010A180D
		private void SetGameEnd(int fishCount)
		{
			UiLayer.Instance.SetShowMaskLayer("FishingQteAnimEnd.Start", true);
			this.TipsTxt.ShowTip(EFishingTipsType.GetFish, fishCount.ToString(), new Action(this.<SetGameEnd>g__animFlow1|44_1));
		}

		// Token: 0x0603AE1C RID: 241180 RVA: 0x010A3640 File Offset: 0x010A1840
		private void OnAreaClick(EFishingAreaType areaType, ContinuousRingArea area)
		{
			this.ButtonItem.SetForbiddenStart((float)this.GameConfig.HitColdTime);
			this.RingItem.OnAreaClick(areaType, area);
			switch (areaType)
			{
			case EFishingAreaType.BlankArea:
				this.PlayAnim("QteFail");
				FishingQteModel.Instance.OnMissOn();
				EventSystem.Instance.Emit<bool>(EEventName.FishingQteBtnHitValidArea, false);
				return;
			case EFishingAreaType.QteArea:
			{
				this.ProgressItem.StartAnimProgress();
				this.PlayAnim("QteSuccess");
				FishingQteModel.Instance.OnQteOn();
				FishingQteRingInfo ringInfo = this.GameInfo.GetRingInfo();
				if (!ringInfo.IsWholeRing)
				{
					ringInfo.EnterNextValidArea();
				}
				this.RingItem.SpawnContinuousArea(area.ContinuousIndex, EFishingAreaType.QteArea);
				EventSystem.Instance.Emit<bool>(EEventName.FishingQteBtnHitValidArea, true);
				return;
			}
			case EFishingAreaType.PerfectArea:
			{
				this.ProgressItem.StartAnimProgress();
				this.PlayAnim("PerfectQte");
				FishingQteModel.Instance.OnPerfectOn();
				FishingQteRingInfo ringInfo2 = this.GameInfo.GetRingInfo();
				if (!ringInfo2.IsWholeRing)
				{
					ringInfo2.EnterNextValidArea();
				}
				this.RingItem.SpawnContinuousArea(area.ContinuousIndex, EFishingAreaType.PerfectArea);
				EventSystem.Instance.Emit<bool>(EEventName.FishingQteBtnHitValidArea, true);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0603AE1D RID: 241181 RVA: 0x010A3768 File Offset: 0x010A1968
		[NullableContext(1)]
		private void PlayAnim(string sequenceName)
		{
			if (this.LevelSequencePlayer.GetCurrentSequence() == sequenceName)
			{
				this.LevelSequencePlayer.ReplaySequenceByKey(sequenceName);
				return;
			}
			this.LevelSequencePlayer.StopPlayingSequence(false, true);
			this.LevelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x0603AE1E RID: 241182 RVA: 0x010A37BC File Offset: 0x010A19BC
		private void RefreshFishingPointCount()
		{
			int currentRound = this.GameInfo.CurrentRound;
			int index = this.GameInfo.MaxRound - currentRound;
			FishingRoundItem layoutItemByIndex = this.FishIconLayout.GetLayoutItemByIndex(index);
			if (layoutItemByIndex == null)
			{
				return;
			}
			layoutItemByIndex.ShowIcon((int)FishingQteModel.Instance.CurrentFishingIconType);
		}

		// Token: 0x0603AE22 RID: 241186 RVA: 0x010A388C File Offset: 0x010A1A8C
		[CompilerGenerated]
		private void <SetGameStart>g__startAnimFlow|42_0()
		{
			this.GameInfo.SetGameStage(EFishingQteStage.OnGoing);
		}

		// Token: 0x0603AE23 RID: 241187 RVA: 0x010A389A File Offset: 0x010A1A9A
		[CompilerGenerated]
		private void <SetGameGoing>g__startAnimFlow|43_0()
		{
			this.GameInfo.SetGameStage(EFishingQteStage.OnGoing);
		}

		// Token: 0x0603AE24 RID: 241188 RVA: 0x010A38A8 File Offset: 0x010A1AA8
		[CompilerGenerated]
		private void <SetGameEnd>g__animFlow2|44_0()
		{
			this.GameInfo.SetGameStage(EFishingQteStage.AnimEnd);
			UiLayer.Instance.SetShowMaskLayer("FishingQteAnimEnd.Start", false);
		}

		// Token: 0x0603AE25 RID: 241189 RVA: 0x010A38C6 File Offset: 0x010A1AC6
		[CompilerGenerated]
		private void <SetGameEnd>g__animFlow1|44_1()
		{
			this.FullTipItem.SetTxtInfo("Fishing_QTE_Finish", Array.Empty<object>());
			this.FullTipItem.PlayTipSequence(new Action(this.<SetGameEnd>g__animFlow2|44_0), "Start", true);
		}

		// Token: 0x0401EF2E RID: 126766
		[Nullable(1)]
		private const string ANIM_FISHING_SUCCESS = "FishSuccess";

		// Token: 0x0401EF2F RID: 126767
		[Nullable(1)]
		private const string ANIM_QTE_SUCCESS = "QteSuccess";

		// Token: 0x0401EF30 RID: 126768
		[Nullable(1)]
		private const string ANIM_QTE_PERFECT = "PerfectQte";

		// Token: 0x0401EF31 RID: 126769
		[Nullable(1)]
		private const string ANIM_QTE_FAIL = "QteFail";

		// Token: 0x0401EF32 RID: 126770
		[Nullable(1)]
		protected FishingQteGameInfo GameInfo;

		// Token: 0x0401EF33 RID: 126771
		[Nullable(1)]
		protected IFishingQteConfig GameConfig;

		// Token: 0x0401EF34 RID: 126772
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401EF35 RID: 126773
		private FishingTagItem TagItem;

		// Token: 0x0401EF36 RID: 126774
		private FishingCabinItem CabinItem;

		// Token: 0x0401EF37 RID: 126775
		private FishingButtonItem ButtonItem;

		// Token: 0x0401EF38 RID: 126776
		private FishingQteTipsItem TipsTxt;

		// Token: 0x0401EF39 RID: 126777
		private FishingGetScrollItem GetScrollItem;

		// Token: 0x0401EF3A RID: 126778
		private FishingProgressItem ProgressItem;

		// Token: 0x0401EF3B RID: 126779
		private FishingQteRingItem RingItem;

		// Token: 0x0401EF3C RID: 126780
		private FishingFullTipItem FullTipItem;

		// Token: 0x0401EF3D RID: 126781
		[Nullable(1)]
		private GenericLayout<FishingRoundItem, int> FishIconLayout;

		// Token: 0x0401EF3E RID: 126782
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401EF3F RID: 126783
		private Action FinishCallback;

		// Token: 0x0200B8D1 RID: 47313
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040390B4 RID: 233652
			public const int CaptionItem = 0;

			// Token: 0x040390B5 RID: 233653
			public const int LayoutFishIcon = 1;

			// Token: 0x040390B6 RID: 233654
			public const int FishIcon = 2;

			// Token: 0x040390B7 RID: 233655
			public const int PanelRing = 3;

			// Token: 0x040390B8 RID: 233656
			public const int PanelProgressBar = 4;

			// Token: 0x040390B9 RID: 233657
			public const int BtnFish = 5;

			// Token: 0x040390BA RID: 233658
			public const int PanelGrid = 6;

			// Token: 0x040390BB RID: 233659
			public const int TagLeftItem = 7;

			// Token: 0x040390BC RID: 233660
			public const int PanelTipsLeft = 8;

			// Token: 0x040390BD RID: 233661
			public const int PanelTipsCenter = 9;

			// Token: 0x040390BE RID: 233662
			public const int TipsTxt = 10;
		}
	}
}

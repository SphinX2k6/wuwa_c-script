using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02006E36 RID: 28214
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingQteView : UiTickViewBase
	{
		// Token: 0x06044C75 RID: 281717 RVA: 0x010F891D File Offset: 0x010F6B1D
		[NullableContext(1)]
		public FishingQteView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06044C76 RID: 281718 RVA: 0x010F8928 File Offset: 0x010F6B28
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

		// Token: 0x06044C77 RID: 281719 RVA: 0x010F8AC0 File Offset: 0x010F6CC0
		protected override UniTask OnBeforeStartAsync()
		{
			FishingQteView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingQteView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06044C78 RID: 281720 RVA: 0x010F8B03 File Offset: 0x010F6D03
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.OnFishingQteStageUpdate, new Action<EFishingQteStage>(this.OnGameStageUpdate));
			EventSystem.Instance.Add(EEventName.OnFishingQteAreaChange, new Action<int>(this.OnFishingQteAreaChange));
			this.Init();
		}

		// Token: 0x06044C79 RID: 281721 RVA: 0x010F8B44 File Offset: 0x010F6D44
		private void Init()
		{
			this.GameInfo.SetGameStage(EFishingQteStage.Ready);
			this.TagItem.Refresh(FishingQteModel.Instance.CurrentFishingPointConfigId);
			this.RefreshFishingPointCount();
			this.RingItem.InitRing();
			this.GameInfo.GetRingInfo().EnterNextValidArea();
			this.ButtonItem.SetPauseWithoutAnim(false);
			this.FishIconLayout.RefreshByData(new List<int>(Enumerable.Repeat<int>(0, this.GameInfo.MaxRound)), null, false);
			this.UiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
			{
				this.SetGameStart();
			}, false);
		}

		// Token: 0x06044C7A RID: 281722 RVA: 0x010F8BDF File Offset: 0x010F6DDF
		protected override void OnBeforeShow()
		{
			this.CabinItem.RefreshCabin();
		}

		// Token: 0x06044C7B RID: 281723 RVA: 0x010F8BEC File Offset: 0x010F6DEC
		protected override void OnAfterShow()
		{
		}

		// Token: 0x06044C7C RID: 281724 RVA: 0x010F8BF0 File Offset: 0x010F6DF0
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

		// Token: 0x06044C7D RID: 281725 RVA: 0x010F8C4D File Offset: 0x010F6E4D
		protected override void OnAfterDestroy()
		{
			Action finishCallback = this.FinishCallback;
			if (finishCallback == null)
			{
				return;
			}
			finishCallback();
		}

		// Token: 0x06044C7E RID: 281726 RVA: 0x010F8C60 File Offset: 0x010F6E60
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

		// Token: 0x06044C7F RID: 281727 RVA: 0x010F8D18 File Offset: 0x010F6F18
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

		// Token: 0x06044C80 RID: 281728 RVA: 0x010F8D70 File Offset: 0x010F6F70
		private UniTask InitTips()
		{
			FishingQteView.<InitTips>d__30 <InitTips>d__;
			<InitTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTips>d__.<>4__this = this;
			<InitTips>d__.<>1__state = -1;
			<InitTips>d__.<>t__builder.Start<FishingQteView.<InitTips>d__30>(ref <InitTips>d__);
			return <InitTips>d__.<>t__builder.Task;
		}

		// Token: 0x06044C81 RID: 281729 RVA: 0x010F8DB4 File Offset: 0x010F6FB4
		private UniTask InitGetScrollView()
		{
			FishingQteView.<InitGetScrollView>d__31 <InitGetScrollView>d__;
			<InitGetScrollView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitGetScrollView>d__.<>4__this = this;
			<InitGetScrollView>d__.<>1__state = -1;
			<InitGetScrollView>d__.<>t__builder.Start<FishingQteView.<InitGetScrollView>d__31>(ref <InitGetScrollView>d__);
			return <InitGetScrollView>d__.<>t__builder.Task;
		}

		// Token: 0x06044C82 RID: 281730 RVA: 0x010F8DF8 File Offset: 0x010F6FF8
		private UniTask InitRing()
		{
			FishingQteView.<InitRing>d__32 <InitRing>d__;
			<InitRing>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRing>d__.<>4__this = this;
			<InitRing>d__.<>1__state = -1;
			<InitRing>d__.<>t__builder.Start<FishingQteView.<InitRing>d__32>(ref <InitRing>d__);
			return <InitRing>d__.<>t__builder.Task;
		}

		// Token: 0x06044C83 RID: 281731 RVA: 0x010F8E3C File Offset: 0x010F703C
		private UniTask InitProgressItem()
		{
			FishingQteView.<InitProgressItem>d__33 <InitProgressItem>d__;
			<InitProgressItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitProgressItem>d__.<>4__this = this;
			<InitProgressItem>d__.<>1__state = -1;
			<InitProgressItem>d__.<>t__builder.Start<FishingQteView.<InitProgressItem>d__33>(ref <InitProgressItem>d__);
			return <InitProgressItem>d__.<>t__builder.Task;
		}

		// Token: 0x06044C84 RID: 281732 RVA: 0x010F8E80 File Offset: 0x010F7080
		private UniTask InitFullTipItem()
		{
			FishingQteView.<InitFullTipItem>d__34 <InitFullTipItem>d__;
			<InitFullTipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFullTipItem>d__.<>4__this = this;
			<InitFullTipItem>d__.<>1__state = -1;
			<InitFullTipItem>d__.<>t__builder.Start<FishingQteView.<InitFullTipItem>d__34>(ref <InitFullTipItem>d__);
			return <InitFullTipItem>d__.<>t__builder.Task;
		}

		// Token: 0x06044C85 RID: 281733 RVA: 0x010F8EC3 File Offset: 0x010F70C3
		[NullableContext(1)]
		private FishingRoundItem CreateFishIcon()
		{
			return new FishingRoundItem();
		}

		// Token: 0x06044C86 RID: 281734 RVA: 0x010F8ECA File Offset: 0x010F70CA
		private void OnFishingQteAreaChange(int areaRelativeIndex)
		{
			this.RingItem.OnArrowStayAreaUpdate(areaRelativeIndex);
		}

		// Token: 0x06044C87 RID: 281735 RVA: 0x010F8ED8 File Offset: 0x010F70D8
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

		// Token: 0x06044C88 RID: 281736 RVA: 0x010F8F3C File Offset: 0x010F713C
		protected void OnExit()
		{
			base.CloseMe(null);
		}

		// Token: 0x06044C89 RID: 281737 RVA: 0x010F8F45 File Offset: 0x010F7145
		private void OnClickCabin()
		{
			if (this.GameInfo.GetGameStage() == EFishingQteStage.OnGoing)
			{
				this.GameInfo.SetGameStage(EFishingQteStage.Pause);
			}
			FishingController.Instance.OpenDockyardWareHouseView(true);
		}

		// Token: 0x06044C8A RID: 281738 RVA: 0x010F8F6C File Offset: 0x010F716C
		private void OnClickBack()
		{
			if (this.GameInfo.GetGameStage() == EFishingQteStage.OnGoing)
			{
				this.GameInfo.SetGameStage(EFishingQteStage.Pause);
			}
			UiManager.Instance.OpenView(EUiViewName.FishingQtePauseView, null, null);
		}

		// Token: 0x06044C8B RID: 281739 RVA: 0x010F8F9C File Offset: 0x010F719C
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

		// Token: 0x06044C8C RID: 281740 RVA: 0x010F9019 File Offset: 0x010F7219
		private void SetGameStart()
		{
			this.FullTipItem.SetTxtInfo("Fishing_QTE_Start", Array.Empty<object>());
			this.FullTipItem.PlayTipSequence(new Action(this.<SetGameStart>g__startAnimFlow|42_0), "Start", true);
		}

		// Token: 0x06044C8D RID: 281741 RVA: 0x010F904D File Offset: 0x010F724D
		private void SetGameGoing()
		{
			this.ButtonItem.SetPause(false);
			this.FullTipItem.SetTxtInfo("Fishing_QTE_Start", Array.Empty<object>());
			this.FullTipItem.PlayTipSequence(new Action(this.<SetGameGoing>g__startAnimFlow|43_0), "Start", true);
		}

		// Token: 0x06044C8E RID: 281742 RVA: 0x010F908D File Offset: 0x010F728D
		private void SetGameEnd(int fishCount)
		{
			UiLayer.Instance.SetShowMaskLayer("FishingQteAnimEnd.Start", true);
			this.TipsTxt.ShowTip(EFishingTipsType.GetFish, fishCount.ToString(), new Action(this.<SetGameEnd>g__animFlow1|44_1));
		}

		// Token: 0x06044C8F RID: 281743 RVA: 0x010F90C0 File Offset: 0x010F72C0
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

		// Token: 0x06044C90 RID: 281744 RVA: 0x010F91E8 File Offset: 0x010F73E8
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

		// Token: 0x06044C91 RID: 281745 RVA: 0x010F923C File Offset: 0x010F743C
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

		// Token: 0x06044C95 RID: 281749 RVA: 0x010F930C File Offset: 0x010F750C
		[CompilerGenerated]
		private void <SetGameStart>g__startAnimFlow|42_0()
		{
			this.GameInfo.SetGameStage(EFishingQteStage.OnGoing);
		}

		// Token: 0x06044C96 RID: 281750 RVA: 0x010F931A File Offset: 0x010F751A
		[CompilerGenerated]
		private void <SetGameGoing>g__startAnimFlow|43_0()
		{
			this.GameInfo.SetGameStage(EFishingQteStage.OnGoing);
		}

		// Token: 0x06044C97 RID: 281751 RVA: 0x010F9328 File Offset: 0x010F7528
		[CompilerGenerated]
		private void <SetGameEnd>g__animFlow2|44_0()
		{
			this.GameInfo.SetGameStage(EFishingQteStage.AnimEnd);
			UiLayer.Instance.SetShowMaskLayer("FishingQteAnimEnd.Start", false);
		}

		// Token: 0x06044C98 RID: 281752 RVA: 0x010F9346 File Offset: 0x010F7546
		[CompilerGenerated]
		private void <SetGameEnd>g__animFlow1|44_1()
		{
			this.FullTipItem.SetTxtInfo("Fishing_QTE_Finish", Array.Empty<object>());
			this.FullTipItem.PlayTipSequence(new Action(this.<SetGameEnd>g__animFlow2|44_0), "Start", true);
		}

		// Token: 0x04023C79 RID: 146553
		[Nullable(1)]
		private const string ANIM_FISHING_SUCCESS = "FishSuccess";

		// Token: 0x04023C7A RID: 146554
		[Nullable(1)]
		private const string ANIM_QTE_SUCCESS = "QteSuccess";

		// Token: 0x04023C7B RID: 146555
		[Nullable(1)]
		private const string ANIM_QTE_PERFECT = "PerfectQte";

		// Token: 0x04023C7C RID: 146556
		[Nullable(1)]
		private const string ANIM_QTE_FAIL = "QteFail";

		// Token: 0x04023C7D RID: 146557
		[Nullable(1)]
		protected FishingQteGameInfo GameInfo;

		// Token: 0x04023C7E RID: 146558
		[Nullable(1)]
		protected IFishingQteConfig GameConfig;

		// Token: 0x04023C7F RID: 146559
		private PopupCaptionItem CaptionItem;

		// Token: 0x04023C80 RID: 146560
		private FishingTagItem TagItem;

		// Token: 0x04023C81 RID: 146561
		private FishingCabinItem CabinItem;

		// Token: 0x04023C82 RID: 146562
		private FishingButtonItem ButtonItem;

		// Token: 0x04023C83 RID: 146563
		private FishingQteTipsItem TipsTxt;

		// Token: 0x04023C84 RID: 146564
		private FishingGetScrollItem GetScrollItem;

		// Token: 0x04023C85 RID: 146565
		private FishingProgressItem ProgressItem;

		// Token: 0x04023C86 RID: 146566
		private FishingQteRingItem RingItem;

		// Token: 0x04023C87 RID: 146567
		private FishingFullTipItem FullTipItem;

		// Token: 0x04023C88 RID: 146568
		[Nullable(1)]
		private GenericLayout<FishingRoundItem, int> FishIconLayout;

		// Token: 0x04023C89 RID: 146569
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04023C8A RID: 146570
		private Action FinishCallback;

		// Token: 0x0200CCE1 RID: 52449
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403DC92 RID: 253074
			public const int CaptionItem = 0;

			// Token: 0x0403DC93 RID: 253075
			public const int LayoutFishIcon = 1;

			// Token: 0x0403DC94 RID: 253076
			public const int FishIcon = 2;

			// Token: 0x0403DC95 RID: 253077
			public const int PanelRing = 3;

			// Token: 0x0403DC96 RID: 253078
			public const int PanelProgressBar = 4;

			// Token: 0x0403DC97 RID: 253079
			public const int BtnFish = 5;

			// Token: 0x0403DC98 RID: 253080
			public const int PanelGrid = 6;

			// Token: 0x0403DC99 RID: 253081
			public const int TagLeftItem = 7;

			// Token: 0x0403DC9A RID: 253082
			public const int PanelTipsLeft = 8;

			// Token: 0x0403DC9B RID: 253083
			public const int PanelTipsCenter = 9;

			// Token: 0x0403DC9C RID: 253084
			public const int TipsTxt = 10;
		}
	}
}

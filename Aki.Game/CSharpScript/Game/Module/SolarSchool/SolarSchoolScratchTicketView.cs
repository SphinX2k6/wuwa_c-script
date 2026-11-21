using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200594A RID: 22858
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolScratchTicketView : UiViewBase
	{
		// Token: 0x06038520 RID: 230688 RVA: 0x00FBED5A File Offset: 0x00FBCF5A
		public SolarSchoolScratchTicketView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038521 RID: 230689 RVA: 0x00FBED64 File Offset: 0x00FBCF64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038522 RID: 230690 RVA: 0x00FBEDF0 File Offset: 0x00FBCFF0
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolScratchTicketView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolScratchTicketView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038523 RID: 230691 RVA: 0x00FBEE33 File Offset: 0x00FBD033
		protected override void OnStart()
		{
			if (this.Handler == null)
			{
				return;
			}
			this.Handler.OnViewReady(this);
		}

		// Token: 0x06038524 RID: 230692 RVA: 0x00FBEE4A File Offset: 0x00FBD04A
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			SolarSchoolScratchTicketCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.PlayClose(false);
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x06038525 RID: 230693 RVA: 0x00FBEE63 File Offset: 0x00FBD063
		protected override void OnBeforeDestroy()
		{
			this.SetMaskActive(false);
			this.ClearRevealTimer();
			ISolarSchoolScratchTicketViewHandler handler = this.Handler;
			if (handler != null)
			{
				handler.OnViewClosed();
			}
			this.Handler = null;
		}

		// Token: 0x06038526 RID: 230694 RVA: 0x00FBEE8A File Offset: 0x00FBD08A
		private void RefreshRewardList()
		{
			SolarSchoolScratchTicketInfoPanel infoPanel = this.InfoPanel;
			if (infoPanel == null)
			{
				return;
			}
			infoPanel.RefreshRewardList(this.Data.GetRemainRewardList());
		}

		// Token: 0x06038527 RID: 230695 RVA: 0x00FBEEA8 File Offset: 0x00FBD0A8
		public void PlayRevealAnim(SolarSchoolScratchTicketData data, List<ScratchTicketRoundResult> results)
		{
			this.Data = data;
			if (results.Count <= 0)
			{
				ISolarSchoolScratchTicketViewHandler handler = this.Handler;
				if (handler == null)
				{
					return;
				}
				handler.OnRevealAnimFinished();
				return;
			}
			else
			{
				this.SetMaskActive(true);
				this.ClearRevealTimer();
				this.RefreshRoundReward(results[0]);
				if (results.Count == 1)
				{
					this.RevealTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
					{
						this.SetMaskActive(false);
						this.ClearRevealTimer();
						this.RefreshRewardList();
						ISolarSchoolScratchTicketViewHandler handler2 = this.Handler;
						if (handler2 == null)
						{
							return;
						}
						handler2.OnRevealAnimFinished();
					}, results[0].DelayInterval, null, null, true, 1f);
					return;
				}
				int time = 1;
				float delayInterval = results[0].DelayInterval;
				float deltaTime = 0f;
				this.RevealTimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float delta)
				{
					deltaTime += delta;
					if (deltaTime < delayInterval)
					{
						return;
					}
					deltaTime %= delayInterval;
					int time;
					if (time >= results.Count)
					{
						this.SetMaskActive(false);
						this.ClearRevealTimer();
						this.RefreshRewardList();
						ISolarSchoolScratchTicketViewHandler handler2 = this.Handler;
						if (handler2 == null)
						{
							return;
						}
						handler2.OnRevealAnimFinished();
						return;
					}
					else
					{
						if (time == results.Count - 1)
						{
							this.RefreshRoundReward(results[time]);
							delayInterval = 700f;
							time = time;
							time++;
							return;
						}
						this.RefreshRoundReward(results[time]);
						delayInterval = results[time].DelayInterval;
						time = time;
						time++;
						return;
					}
				}, 50f, 1f, null, null, true);
				return;
			}
		}

		// Token: 0x06038528 RID: 230696 RVA: 0x00FBEFA4 File Offset: 0x00FBD1A4
		public void ShowResult()
		{
			this.SetMaskActive(false);
		}

		// Token: 0x06038529 RID: 230697 RVA: 0x00FBEFB0 File Offset: 0x00FBD1B0
		private void RefreshRoundReward(ScratchTicketRoundResult roundData)
		{
			if (roundData.RewardList.Count > 0)
			{
				this.RefreshCellReward(roundData.RewardList);
			}
			if (roundData.SequenceName != "Empty")
			{
				this.UiViewSequence.PlaySequence(roundData.SequenceName, false, null);
			}
		}

		// Token: 0x0603852A RID: 230698 RVA: 0x00FBF004 File Offset: 0x00FBD204
		private void RefreshCellReward(List<ScratchTicketRewardResult> resultData)
		{
			foreach (ScratchTicketRewardResult scratchTicketRewardResult in resultData)
			{
				SolarSchoolScratchTicketCellItem layoutItemByKey = this.CellLayout.GetLayoutItemByKey(scratchTicketRewardResult.Index);
				SolarSchoolScratchTicketCellData cellDataByIndex = this.Data.GetCellDataByIndex(scratchTicketRewardResult.Index);
				if (layoutItemByKey != null && cellDataByIndex != null)
				{
					layoutItemByKey.RefreshByResultData(cellDataByIndex, scratchTicketRewardResult);
				}
			}
		}

		// Token: 0x0603852B RID: 230699 RVA: 0x00FBF084 File Offset: 0x00FBD284
		private SolarSchoolScratchTicketCellItem CreateCellItem()
		{
			SolarSchoolScratchTicketCellItem solarSchoolScratchTicketCellItem = new SolarSchoolScratchTicketCellItem();
			solarSchoolScratchTicketCellItem.SetClickCallback(new Action<SolarSchoolScratchTicketCellData>(this.OnClickCellItem));
			return solarSchoolScratchTicketCellItem;
		}

		// Token: 0x0603852C RID: 230700 RVA: 0x00FBF09D File Offset: 0x00FBD29D
		private void OnClickCellItem(SolarSchoolScratchTicketCellData data)
		{
			ISolarSchoolScratchTicketViewHandler handler = this.Handler;
			if (handler == null)
			{
				return;
			}
			handler.OnCellClicked(data.Index);
		}

		// Token: 0x0603852D RID: 230701 RVA: 0x00FBF0B5 File Offset: 0x00FBD2B5
		private void ClearRevealTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.RevealTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RevealTimerHandle);
				this.RevealTimerHandle = null;
			}
		}

		// Token: 0x0603852E RID: 230702 RVA: 0x00FBF0E1 File Offset: 0x00FBD2E1
		private void OnClickCloseBtn()
		{
			ISolarSchoolScratchTicketViewHandler handler = this.Handler;
			if (handler == null)
			{
				return;
			}
			handler.OnRequestClose();
		}

		// Token: 0x0603852F RID: 230703 RVA: 0x00FBF0F3 File Offset: 0x00FBD2F3
		private void SetMaskActive(bool active)
		{
			UiLayer.Instance.SetShowMaskLayer(this.ViewInfo.Name, active);
		}

		// Token: 0x0401DA8F RID: 121487
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SolarSchoolScratchTicketCellItem, SolarSchoolScratchTicketCellData> CellLayout;

		// Token: 0x0401DA90 RID: 121488
		[Nullable(2)]
		private SolarSchoolScratchTicketInfoPanel InfoPanel;

		// Token: 0x0401DA91 RID: 121489
		[Nullable(2)]
		private SolarSchoolScratchTicketCaptionItem CaptionItem;

		// Token: 0x0401DA92 RID: 121490
		[Nullable(2)]
		private ISolarSchoolScratchTicketViewHandler Handler;

		// Token: 0x0401DA93 RID: 121491
		[Nullable(2)]
		private SolarSchoolScratchTicketData Data;

		// Token: 0x0401DA94 RID: 121492
		[Nullable(2)]
		private TimerHandle RevealTimerHandle;

		// Token: 0x0200B501 RID: 46337
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037F73 RID: 229235
			PnlInfo,
			// Token: 0x04037F74 RID: 229236
			PnlGridLayout,
			// Token: 0x04037F75 RID: 229237
			UiItem_SolarSchoolScratchoff
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.TuningStand.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x02005B29 RID: 23337
	[NullableContext(2)]
	[Nullable(0)]
	public class TuningStandView : UiViewBase
	{
		// Token: 0x06039678 RID: 235128 RVA: 0x0101BCCE File Offset: 0x01019ECE
		[NullableContext(1)]
		public TuningStandView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039679 RID: 235129 RVA: 0x0101BCD8 File Offset: 0x01019ED8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(12, typeof(UUIText)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIItem)),
				new ValueTuple<int, Type>(19, typeof(UUIItem)),
				new ValueTuple<int, Type>(20, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(21, typeof(UUIItem)),
				new ValueTuple<int, Type>(22, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(13, new Action(this.ResetGrid)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickedTips)),
				new ValueTuple<int, Delegate>(9, new Action(this.OnClickedTips)),
				new ValueTuple<int, Delegate>(20, new Action(this.OnCloseGuide))
			};
		}

		// Token: 0x0603967A RID: 235130 RVA: 0x0101BF50 File Offset: 0x0101A150
		protected override UniTask OnBeforeStartAsync()
		{
			TuningStandView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TuningStandView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603967B RID: 235131 RVA: 0x0101BF94 File Offset: 0x0101A194
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(1));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickClose));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelp));
			this.IsTuning = (this.Config.VisualType == ETuningStandVisualType.Tuning);
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(this.IsTuning);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(this.IsTuning);
			}
			if (this.IsTuning)
			{
				string path = UiResourceConfig.Instance.GetResourcePath("IconRoleHeadMemes_FLL") ?? "";
				base.SetTextureByPath(path, base.GetTexture(4), null, null);
				string resourceId = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? "IconRoleHeadMemes_Nv" : "IconRoleHeadMemes_Nan";
				string path2 = UiResourceConfig.Instance.GetResourcePath(resourceId) ?? "";
				base.SetTextureByPath(path2, base.GetTexture(8), null, null);
			}
			UUIItem item3 = base.GetItem(19);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			this.FloroSequencer = new LevelSequencePlayer(base.GetItem(3));
			this.MainSequencer = new LevelSequencePlayer(base.GetItem(7));
			this.LightButtonLeft = new LevelSequencePlayer(base.GetButton(5).RootUIComp);
			this.LightButtonRight = new LevelSequencePlayer(base.GetButton(9).RootUIComp);
			this.UiViewSequence.AddSequenceFinishEvent("Start", new Action<string>(this.OnStartEnd), false);
		}

		// Token: 0x0603967C RID: 235132 RVA: 0x0101C134 File Offset: 0x0101A334
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int?>(EEventName.TuningStandUpdate, new Action<int?>(this.OnRefreshGrid));
			EventSystem.Instance.Add(EEventName.TuningStandSuccess, new Action(this.OnClear));
			EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.TuningStandSuccessShowStart, new Action<IReadOnlyList<int>>(this.ClearAnimShowStart));
			EventSystem.Instance.Add(EEventName.TuningStandSuccessShowEnd, new Action(this.ClearAnimShowEnd));
			EventSystem.Instance.Add<bool>(EEventName.TuningStandTooLongTime, new Action<bool>(this.OnTooLong));
			EventSystem.Instance.Add<ITuningStandBubbleData>(EEventName.TuningStandBubbleUpdate, new Action<ITuningStandBubbleData>(this.OnBubble));
			EventSystem.Instance.Add<ETuningStandBubbleTriggerType>(EEventName.TuningStandBubbleEnd, new Action<ETuningStandBubbleTriggerType>(this.OnBubbleEnd));
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
			EventSystem.Instance.Add<bool>(EEventName.TuningStandOnLinkMiss, new Action<bool>(this.OnLinkMiss));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x0603967D RID: 235133 RVA: 0x0101C25C File Offset: 0x0101A45C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int?>(EEventName.TuningStandUpdate, new Action<int?>(this.OnRefreshGrid));
			EventSystem.Instance.Remove(EEventName.TuningStandSuccess, new Action(this.OnClear));
			EventSystem.Instance.Remove<IReadOnlyList<int>>(EEventName.TuningStandSuccessShowStart, new Action<IReadOnlyList<int>>(this.ClearAnimShowStart));
			EventSystem.Instance.Remove(EEventName.TuningStandSuccessShowEnd, new Action(this.ClearAnimShowEnd));
			EventSystem.Instance.Remove<bool>(EEventName.TuningStandTooLongTime, new Action<bool>(this.OnTooLong));
			EventSystem.Instance.Remove<ITuningStandBubbleData>(EEventName.TuningStandBubbleUpdate, new Action<ITuningStandBubbleData>(this.OnBubble));
			EventSystem.Instance.Remove<ETuningStandBubbleTriggerType>(EEventName.TuningStandBubbleEnd, new Action<ETuningStandBubbleTriggerType>(this.OnBubbleEnd));
			EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
			EventSystem.Instance.Remove<bool>(EEventName.TuningStandOnLinkMiss, new Action<bool>(this.OnLinkMiss));
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x0603967E RID: 235134 RVA: 0x0101C381 File Offset: 0x0101A581
		protected override void OnBeforeHide()
		{
			if (!this.LastHide)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x0603967F RID: 235135 RVA: 0x0101C394 File Offset: 0x0101A594
		protected override void OnBeforeDestroy()
		{
			if (this.TooLongHandle != null)
			{
				if (TimerSystem.GameplayTimeInstance.Has(this.TooLongHandle))
				{
					TimerSystem.GameplayTimeInstance.Remove(this.TooLongHandle);
				}
				this.TooLongHandle = null;
			}
			this.MusicItem = null;
			this.MusicItemPlay = null;
			this.GuideItem = null;
			TuningStandModel.Instance.UnloadData();
			TuningStandNodeTween redTweener = this.RedTweener;
			if (redTweener != null)
			{
				redTweener.Clear();
			}
			this.RedTweener = null;
			TuningStandNodeTween blueTweener = this.BlueTweener;
			if (blueTweener != null)
			{
				blueTweener.Clear();
			}
			this.BlueTweener = null;
		}

		// Token: 0x06039680 RID: 235136 RVA: 0x0101C422 File Offset: 0x0101A622
		private void OnClickClose()
		{
			this.UiViewSequence.CloseSequenceName = "Close";
			if (this.IsGameClear)
			{
				this.OnClearClose();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x06039681 RID: 235137 RVA: 0x0101C44A File Offset: 0x0101A64A
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(346);
		}

		// Token: 0x06039682 RID: 235138 RVA: 0x0101C45B File Offset: 0x0101A65B
		[NullableContext(1)]
		private TuningStandGridItem CreateGrid()
		{
			return new TuningStandGridItem();
		}

		// Token: 0x06039683 RID: 235139 RVA: 0x0101C464 File Offset: 0x0101A664
		private void OnRefreshGrid(int? index = null)
		{
			List<TuningStandGridItem> layoutItemList = this.GridLayout.GetLayoutItemList();
			if (index != null)
			{
				layoutItemList[index.Value].RefreshGrid();
				return;
			}
			foreach (TuningStandGridItem tuningStandGridItem in layoutItemList)
			{
				tuningStandGridItem.RefreshGrid();
			}
		}

		// Token: 0x06039684 RID: 235140 RVA: 0x0101C4D8 File Offset: 0x0101A6D8
		private void OnClear()
		{
			if (this.TooLongHandle != null)
			{
				if (TimerSystem.GameplayTimeInstance.Has(this.TooLongHandle))
				{
					TimerSystem.GameplayTimeInstance.Remove(this.TooLongHandle);
				}
				this.TooLongHandle = null;
			}
			UiNavigationNewController.Instance.ResetNavigationFocusForViewWithDirtyCheck();
			this.IsGameClear = true;
			base.GetItem(19).SetUIActive(true);
			if (this.IsTuning)
			{
				TuningStandModel.Instance.TryStartBubbleFlow(ETuningStandBubbleTriggerType.LinkComplete);
			}
		}

		// Token: 0x06039685 RID: 235141 RVA: 0x0101C54C File Offset: 0x0101A74C
		[NullableContext(1)]
		private void ClearAnimShowStart(IReadOnlyList<int> startIndex)
		{
			List<TuningStandGridItem> layoutItemList = this.GridLayout.GetLayoutItemList();
			List<TuningGridData> gridList = TuningStandModel.Instance.GetGridList();
			bool flag = false;
			for (int i = 0; i < layoutItemList.Count; i++)
			{
				bool flag2 = false;
				for (int j = 0; j < startIndex.Count; j++)
				{
					if (startIndex[j] == i)
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					layoutItemList[i].StartRevolving();
				}
			}
			foreach (int index in startIndex)
			{
				TuningStandGridItem item = layoutItemList[index];
				ETuningStandGridType gridType = gridList[index].GridType;
				UUIItem activeNode = this.MusicItem.GetActiveNode(gridType);
				FVectorDouble start = item.GetRootItem().D_K2_GetComponentLocation();
				FVectorDouble end = activeNode.D_K2_GetComponentLocation();
				if (gridType == ETuningStandGridType.Start1)
				{
					TimerSystem.Instance.Delay(delegate(float _)
					{
						TuningStandNodeTween redTweener = this.RedTweener;
						if (redTweener != null)
						{
							redTweener.PlayTween(start, end, true);
						}
						item.StartRevolving();
					}, 250f, null, null, true, 1f);
				}
				if (gridType == ETuningStandGridType.Start2)
				{
					flag = true;
					item.StartRevolving();
					TuningStandNodeTween blueTweener = this.BlueTweener;
					if (blueTweener != null)
					{
						blueTweener.PlayTween(start, end, true);
					}
				}
			}
			if (!flag)
			{
				FVectorDouble fvectorDouble = base.GetItem(0).D_K2_GetComponentLocation();
				TuningStandNodeTween blueTweener2 = this.BlueTweener;
				if (blueTweener2 == null)
				{
					return;
				}
				blueTweener2.PlayTween(fvectorDouble, fvectorDouble, false);
			}
		}

		// Token: 0x06039686 RID: 235142 RVA: 0x0101C6E0 File Offset: 0x0101A8E0
		private void ClearAnimShowEnd()
		{
			this.OnClearAnimShowEnd();
		}

		// Token: 0x06039687 RID: 235143 RVA: 0x0101C6EC File Offset: 0x0101A8EC
		private UniTask OnClearAnimShowEnd()
		{
			TuningStandView.<OnClearAnimShowEnd>d__38 <OnClearAnimShowEnd>d__;
			<OnClearAnimShowEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClearAnimShowEnd>d__.<>4__this = this;
			<OnClearAnimShowEnd>d__.<>1__state = -1;
			<OnClearAnimShowEnd>d__.<>t__builder.Start<TuningStandView.<OnClearAnimShowEnd>d__38>(ref <OnClearAnimShowEnd>d__);
			return <OnClearAnimShowEnd>d__.<>t__builder.Task;
		}

		// Token: 0x06039688 RID: 235144 RVA: 0x0101C730 File Offset: 0x0101A930
		private void ResetGrid()
		{
			if (this.IsGameClear)
			{
				return;
			}
			TuningStandModel.Instance.ResetGrid();
			List<TuningGridData> gridList = TuningStandModel.Instance.GetGridList();
			this.GridLayout.RefreshByData(gridList, null, false);
			TimerSystem.Instance.Delay(delegate(float _)
			{
				this.SetFocusOnStart();
			}, 500f, null, null, true, 1f);
		}

		// Token: 0x06039689 RID: 235145 RVA: 0x0101C78D File Offset: 0x0101A98D
		private void OnBubbleEnd(ETuningStandBubbleTriggerType type)
		{
			if (type == ETuningStandBubbleTriggerType.Enter)
			{
				this.OnEnterBubbleEnd();
			}
		}

		// Token: 0x0603968A RID: 235146 RVA: 0x0101C798 File Offset: 0x0101A998
		private void OnTooLong(bool isMain)
		{
			if (this.IsTuning)
			{
				UUIButtonComponent button = base.GetButton(5);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(!isMain);
				}
				UUIButtonComponent button2 = base.GetButton(9);
				if (button2 != null)
				{
					button2.RootUIComp.Get().SetUIActive(isMain);
				}
				if (isMain)
				{
					this.LightButtonRight.PlayLevelSequenceByName("Start", false, null, false);
					return;
				}
				this.LightButtonLeft.PlayLevelSequenceByName("Start", false, null, false);
			}
		}

		// Token: 0x0603968B RID: 235147 RVA: 0x0101C82C File Offset: 0x0101AA2C
		[NullableContext(1)]
		private void OnBubble(ITuningStandBubbleData data)
		{
			if (this.BubbleTimer != null)
			{
				if (TimerSystem.GameplayTimeInstance.Has(this.BubbleTimer))
				{
					TimerSystem.GameplayTimeInstance.Remove(this.BubbleTimer);
				}
				this.BubbleTimer = null;
			}
			if (data.MainRoleTex != null)
			{
				base.SetTextureByPath(data.MainRoleTex, base.GetTexture(8), null, null);
			}
			if (data.FloroTex != null)
			{
				base.SetTextureByPath(data.FloroTex, base.GetTexture(4), null, null);
			}
			if (data.MainRoleTalk != null)
			{
				UUIText text = base.GetText(10);
				if (text == null || !text.IsUIActiveSelf())
				{
					UUIText text2 = base.GetText(10);
					if (text2 != null)
					{
						text2.SetUIActive(true);
					}
				}
				this.IsMainTalking = true;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(10), data.MainRoleTalk, Array.Empty<object>());
				this.PlayBubbleFadeIn(this.MainSequencer);
			}
			else if (this.IsMainTalking)
			{
				this.IsMainTalking = false;
				this.PlayBubbleFadeOut(this.MainSequencer);
			}
			if (data.FloroTalk != null)
			{
				UUIText text3 = base.GetText(6);
				if (text3 == null || !text3.IsUIActiveSelf())
				{
					UUIText text4 = base.GetText(6);
					if (text4 != null)
					{
						text4.SetUIActive(true);
					}
				}
				this.IsFloroTalking = true;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(6), data.FloroTalk, Array.Empty<object>());
				this.PlayBubbleFadeIn(this.FloroSequencer);
			}
			else if (this.IsFloroTalking)
			{
				this.IsFloroTalking = false;
				this.PlayBubbleFadeOut(this.FloroSequencer);
			}
			double num = (((double)data.WaitTime > 1.5) ? ((double)data.WaitTime - 0.5) : ((double)data.WaitTime)) * 1000.0;
			this.BubbleTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.OnBubbleDelayEnd();
			}, (float)((long)num), null, null, true, 1f);
		}

		// Token: 0x0603968C RID: 235148 RVA: 0x0101CA14 File Offset: 0x0101AC14
		private void OnClickedTips()
		{
			UUIItem item = base.GetItem(14);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(true);
		}

		// Token: 0x0603968D RID: 235149 RVA: 0x0101CA29 File Offset: 0x0101AC29
		private void OnCloseGuide()
		{
			UUIItem item = base.GetItem(14);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603968E RID: 235150 RVA: 0x0101CA3E File Offset: 0x0101AC3E
		[NullableContext(1)]
		private void OnStartEnd(string _)
		{
			if (this.IsTuning && !TuningStandModel.Instance.TryStartBubbleFlow(ETuningStandBubbleTriggerType.Enter))
			{
				this.OnEnterBubbleEnd();
			}
			TimerSystem.Instance.Next(delegate(float __)
			{
				this.SetFocusOnStart();
			}, null, null);
		}

		// Token: 0x0603968F RID: 235151 RVA: 0x0101CA74 File Offset: 0x0101AC74
		private void OnSuccessEnd()
		{
			this.UiViewSequence.CloseSequenceName = "Close2";
			this.OnClearClose();
		}

		// Token: 0x06039690 RID: 235152 RVA: 0x0101CA8C File Offset: 0x0101AC8C
		[NullableContext(1)]
		private void OnAnimEvent(string param)
		{
			if (param == "In")
			{
				TuningStandLineItem musicItem = this.MusicItem;
				if (musicItem != null)
				{
					musicItem.OnStartAnim();
				}
				foreach (TuningStandGridItem tuningStandGridItem in this.GridLayout.GetLayoutItemList())
				{
					tuningStandGridItem.PlayShowAnim();
				}
			}
		}

		// Token: 0x06039691 RID: 235153 RVA: 0x0101CB00 File Offset: 0x0101AD00
		private void OnLinkMiss(bool isEnd)
		{
			foreach (TuningStandGridItem tuningStandGridItem in this.GridLayout.GetLayoutItemList())
			{
				tuningStandGridItem.OnLinkMiss(isEnd);
			}
		}

		// Token: 0x06039692 RID: 235154 RVA: 0x0101CB58 File Offset: 0x0101AD58
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			if (!Info.Instance.IsInGamepad() || this.IsGameClear)
			{
				return;
			}
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.SetFocusOnStart();
			}, null, null);
		}

		// Token: 0x06039693 RID: 235155 RVA: 0x0101CB88 File Offset: 0x0101AD88
		private void OnEnterBubbleEnd()
		{
			this.DoTooLongDelay();
		}

		// Token: 0x06039694 RID: 235156 RVA: 0x0101CB90 File Offset: 0x0101AD90
		private void DoTooLongDelay()
		{
			this.TooLongDelayCount++;
			if (this.TooLongDelayCount > 3)
			{
				TuningStandModel.Instance.ProcessTooLong();
				return;
			}
			this.TooLongHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.DoTooLongDelay();
			}, 60000f, null, null, true, 1f);
		}

		// Token: 0x06039695 RID: 235157 RVA: 0x0101CBE8 File Offset: 0x0101ADE8
		private void PlayBubbleFadeIn(LevelSequencePlayer player)
		{
			if (player == null)
			{
				return;
			}
			if (player.IsPlayingSequence("Off"))
			{
				player.StopSequenceByKey("Off", false, false);
			}
			if (player.IsPlayingSequence("On"))
			{
				player.ReplaySequenceByKey("On");
				return;
			}
			player.PlayLevelSequenceByName("On", false, null, false);
		}

		// Token: 0x06039696 RID: 235158 RVA: 0x0101CC44 File Offset: 0x0101AE44
		private void PlayBubbleFadeOut(LevelSequencePlayer player)
		{
			if (player == null)
			{
				return;
			}
			if (player.IsPlayingSequence("On"))
			{
				player.StopSequenceByKey("On", false, false);
			}
			if (player.IsPlayingSequence("Off"))
			{
				player.ReplaySequenceByKey("Off");
				return;
			}
			player.PlayLevelSequenceByName("Off", false, null, false);
		}

		// Token: 0x06039697 RID: 235159 RVA: 0x0101CCA0 File Offset: 0x0101AEA0
		private void OnBubbleDelayEnd()
		{
			if (this.BubbleTimer != null)
			{
				if (TimerSystem.GameplayTimeInstance.Has(this.BubbleTimer))
				{
					TimerSystem.GameplayTimeInstance.Remove(this.BubbleTimer);
				}
				this.BubbleTimer = null;
			}
			if (this.IsMainTalking)
			{
				this.IsMainTalking = false;
				this.PlayBubbleFadeOut(this.MainSequencer);
			}
			if (this.IsFloroTalking)
			{
				this.IsFloroTalking = false;
				this.PlayBubbleFadeOut(this.FloroSequencer);
			}
		}

		// Token: 0x06039698 RID: 235160 RVA: 0x0101CD18 File Offset: 0x0101AF18
		[NullableContext(1)]
		protected TuningStandGridBase GetFirstStartItem()
		{
			List<TuningStandGridItem> layoutItemList = this.GridLayout.GetLayoutItemList();
			List<TuningGridData> gridList = TuningStandModel.Instance.GetGridList();
			int index = 0;
			foreach (TuningGridData tuningGridData in gridList)
			{
				if (tuningGridData.GridMainType == EGridMainType.Start)
				{
					index = tuningGridData.Index;
					break;
				}
			}
			return layoutItemList[index].GetGrid();
		}

		// Token: 0x06039699 RID: 235161 RVA: 0x0101CD94 File Offset: 0x0101AF94
		protected void SetFocusOnStart()
		{
			TuningStandGridBase firstStartItem = this.GetFirstStartItem();
			UiNavigationNewController.Instance.SetNavigationFocusForView(firstStartItem.GetRootItem(), true, false, false);
		}

		// Token: 0x0603969A RID: 235162 RVA: 0x0101CDBC File Offset: 0x0101AFBC
		protected void OnClearClose()
		{
			if (this.FinishCb != null)
			{
				this.FinishCb();
				this.FinishCb = null;
			}
			base.CloseMe(null);
		}

		// Token: 0x0401E480 RID: 124032
		protected TuningStandLineItem MusicItem;

		// Token: 0x0401E481 RID: 124033
		protected TuningStandLineItem MusicItemPlay;

		// Token: 0x0401E482 RID: 124034
		protected UiPanelBase GuideItem;

		// Token: 0x0401E483 RID: 124035
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401E484 RID: 124036
		protected ITuningStand Config;

		// Token: 0x0401E485 RID: 124037
		protected bool IsTuning;

		// Token: 0x0401E486 RID: 124038
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<TuningStandGridItem, TuningGridData> GridLayout;

		// Token: 0x0401E487 RID: 124039
		protected Action FinishCb;

		// Token: 0x0401E488 RID: 124040
		protected TimerHandle TooLongHandle;

		// Token: 0x0401E489 RID: 124041
		protected LevelSequencePlayer FloroSequencer;

		// Token: 0x0401E48A RID: 124042
		protected bool IsFloroTalking;

		// Token: 0x0401E48B RID: 124043
		protected LevelSequencePlayer MainSequencer;

		// Token: 0x0401E48C RID: 124044
		protected bool IsMainTalking;

		// Token: 0x0401E48D RID: 124045
		protected TimerHandle BubbleTimer;

		// Token: 0x0401E48E RID: 124046
		private int TooLongDelayCount;

		// Token: 0x0401E48F RID: 124047
		protected LevelSequencePlayer LightButtonLeft;

		// Token: 0x0401E490 RID: 124048
		protected LevelSequencePlayer LightButtonRight;

		// Token: 0x0401E491 RID: 124049
		private TuningStandNodeTween RedTweener;

		// Token: 0x0401E492 RID: 124050
		private TuningStandNodeTween BlueTweener;

		// Token: 0x0401E493 RID: 124051
		private bool HasTweenerEnd;

		// Token: 0x0401E494 RID: 124052
		private bool IsGameClear;

		// Token: 0x0200B71E RID: 46878
		[NullableContext(1)]
		[Nullable(0)]
		[RequiredMember]
		public class Params
		{
			// Token: 0x06047EE3 RID: 294627 RVA: 0x015EAAC6 File Offset: 0x015E8CC6
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public Params()
			{
			}

			// Token: 0x040389D6 RID: 231894
			[RequiredMember]
			public ITuningStand Config;

			// Token: 0x040389D7 RID: 231895
			[RequiredMember]
			public Action Cb;
		}

		// Token: 0x0200B71F RID: 46879
		[NullableContext(0)]
		public enum ETuningDefine
		{
			// Token: 0x040389D9 RID: 231897
			PanelMainUI,
			// Token: 0x040389DA RID: 231898
			Caption,
			// Token: 0x040389DB RID: 231899
			DigitalMazeLineItem,
			// Token: 0x040389DC RID: 231900
			PanelLeftDialogue,
			// Token: 0x040389DD RID: 231901
			TexLeftRole,
			// Token: 0x040389DE RID: 231902
			HeadTipsLeft,
			// Token: 0x040389DF RID: 231903
			TxtLeftDialogue,
			// Token: 0x040389E0 RID: 231904
			PanelRightDialogue,
			// Token: 0x040389E1 RID: 231905
			TexRightRole,
			// Token: 0x040389E2 RID: 231906
			HeadTipsRight,
			// Token: 0x040389E3 RID: 231907
			TxtRightDialogue,
			// Token: 0x040389E4 RID: 231908
			PanelLatticeGridList,
			// Token: 0x040389E5 RID: 231909
			TxtBottomTips,
			// Token: 0x040389E6 RID: 231910
			BtnReset,
			// Token: 0x040389E7 RID: 231911
			PanelMaskGuide,
			// Token: 0x040389E8 RID: 231912
			PanelPlayUI,
			// Token: 0x040389E9 RID: 231913
			DigitalMazeLineStaffPlayItem,
			// Token: 0x040389EA RID: 231914
			PanelMainLine,
			// Token: 0x040389EB RID: 231915
			EmptyItem,
			// Token: 0x040389EC RID: 231916
			OpMaskItem,
			// Token: 0x040389ED RID: 231917
			BtnMaskGuide,
			// Token: 0x040389EE RID: 231918
			PanelFlyFxRed,
			// Token: 0x040389EF RID: 231919
			PanelFlyFxBlue
		}
	}
}

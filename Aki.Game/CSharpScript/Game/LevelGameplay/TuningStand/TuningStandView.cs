using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020069CD RID: 27085
	[NullableContext(2)]
	[Nullable(0)]
	public class TuningStandView : UiViewBase
	{
		// Token: 0x0604363C RID: 276028 RVA: 0x0107783A File Offset: 0x01075A3A
		[NullableContext(1)]
		public TuningStandView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0604363D RID: 276029 RVA: 0x01077844 File Offset: 0x01075A44
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

		// Token: 0x0604363E RID: 276030 RVA: 0x01077ABC File Offset: 0x01075CBC
		protected override UniTask OnBeforeStartAsync()
		{
			TuningStandView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TuningStandView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604363F RID: 276031 RVA: 0x01077B00 File Offset: 0x01075D00
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

		// Token: 0x06043640 RID: 276032 RVA: 0x01077CA0 File Offset: 0x01075EA0
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

		// Token: 0x06043641 RID: 276033 RVA: 0x01077DC8 File Offset: 0x01075FC8
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

		// Token: 0x06043642 RID: 276034 RVA: 0x01077EED File Offset: 0x010760ED
		protected override void OnBeforeHide()
		{
			if (!this.LastHide)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x06043643 RID: 276035 RVA: 0x01077F00 File Offset: 0x01076100
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

		// Token: 0x06043644 RID: 276036 RVA: 0x01077F8E File Offset: 0x0107618E
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

		// Token: 0x06043645 RID: 276037 RVA: 0x01077FB6 File Offset: 0x010761B6
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(346);
		}

		// Token: 0x06043646 RID: 276038 RVA: 0x01077FC7 File Offset: 0x010761C7
		[NullableContext(1)]
		private TuningStandGridItem CreateGrid()
		{
			return new TuningStandGridItem();
		}

		// Token: 0x06043647 RID: 276039 RVA: 0x01077FD0 File Offset: 0x010761D0
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

		// Token: 0x06043648 RID: 276040 RVA: 0x01078044 File Offset: 0x01076244
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

		// Token: 0x06043649 RID: 276041 RVA: 0x010780B8 File Offset: 0x010762B8
		[NullableContext(1)]
		private void ClearAnimShowStart(IReadOnlyList<int> startIndex)
		{
			List<TuningStandGridItem> layoutItemList = this.GridLayout.GetLayoutItemList();
			List<TuningGridData> gridList = TuningStandModel.Instance.GetGridList();
			bool flag = false;
			for (int i = 0; i < layoutItemList.Count; i++)
			{
				if (!startIndex.Contains(i))
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

		// Token: 0x0604364A RID: 276042 RVA: 0x0107822C File Offset: 0x0107642C
		private void ClearAnimShowEnd()
		{
			this.OnClearAnimShowEnd();
		}

		// Token: 0x0604364B RID: 276043 RVA: 0x01078238 File Offset: 0x01076438
		private UniTask OnClearAnimShowEnd()
		{
			TuningStandView.<OnClearAnimShowEnd>d__38 <OnClearAnimShowEnd>d__;
			<OnClearAnimShowEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClearAnimShowEnd>d__.<>4__this = this;
			<OnClearAnimShowEnd>d__.<>1__state = -1;
			<OnClearAnimShowEnd>d__.<>t__builder.Start<TuningStandView.<OnClearAnimShowEnd>d__38>(ref <OnClearAnimShowEnd>d__);
			return <OnClearAnimShowEnd>d__.<>t__builder.Task;
		}

		// Token: 0x0604364C RID: 276044 RVA: 0x0107827C File Offset: 0x0107647C
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

		// Token: 0x0604364D RID: 276045 RVA: 0x010782D9 File Offset: 0x010764D9
		private void OnBubbleEnd(ETuningStandBubbleTriggerType type)
		{
			if (type == ETuningStandBubbleTriggerType.Enter)
			{
				this.OnEnterBubbleEnd();
			}
		}

		// Token: 0x0604364E RID: 276046 RVA: 0x010782E4 File Offset: 0x010764E4
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

		// Token: 0x0604364F RID: 276047 RVA: 0x01078378 File Offset: 0x01076578
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

		// Token: 0x06043650 RID: 276048 RVA: 0x01078560 File Offset: 0x01076760
		private void OnClickedTips()
		{
			UUIItem item = base.GetItem(14);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(true);
		}

		// Token: 0x06043651 RID: 276049 RVA: 0x01078575 File Offset: 0x01076775
		private void OnCloseGuide()
		{
			UUIItem item = base.GetItem(14);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06043652 RID: 276050 RVA: 0x0107858A File Offset: 0x0107678A
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

		// Token: 0x06043653 RID: 276051 RVA: 0x010785C0 File Offset: 0x010767C0
		private void OnSuccessEnd()
		{
			this.UiViewSequence.CloseSequenceName = "Close2";
			this.OnClearClose();
		}

		// Token: 0x06043654 RID: 276052 RVA: 0x010785D8 File Offset: 0x010767D8
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

		// Token: 0x06043655 RID: 276053 RVA: 0x0107864C File Offset: 0x0107684C
		private void OnLinkMiss(bool isEnd)
		{
			foreach (TuningStandGridItem tuningStandGridItem in this.GridLayout.GetLayoutItemList())
			{
				tuningStandGridItem.OnLinkMiss(isEnd);
			}
		}

		// Token: 0x06043656 RID: 276054 RVA: 0x010786A4 File Offset: 0x010768A4
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

		// Token: 0x06043657 RID: 276055 RVA: 0x010786D4 File Offset: 0x010768D4
		private void OnEnterBubbleEnd()
		{
			this.DoTooLongDelay();
		}

		// Token: 0x06043658 RID: 276056 RVA: 0x010786DC File Offset: 0x010768DC
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

		// Token: 0x06043659 RID: 276057 RVA: 0x01078734 File Offset: 0x01076934
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

		// Token: 0x0604365A RID: 276058 RVA: 0x01078790 File Offset: 0x01076990
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

		// Token: 0x0604365B RID: 276059 RVA: 0x010787EC File Offset: 0x010769EC
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

		// Token: 0x0604365C RID: 276060 RVA: 0x01078864 File Offset: 0x01076A64
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

		// Token: 0x0604365D RID: 276061 RVA: 0x010788E0 File Offset: 0x01076AE0
		protected void SetFocusOnStart()
		{
			TuningStandGridBase firstStartItem = this.GetFirstStartItem();
			UiNavigationNewController.Instance.SetNavigationFocusForView(firstStartItem.GetRootItem(), true, false, false);
		}

		// Token: 0x0604365E RID: 276062 RVA: 0x01078908 File Offset: 0x01076B08
		protected void OnClearClose()
		{
			if (this.FinishCb != null)
			{
				this.FinishCb();
				this.FinishCb = null;
			}
			base.CloseMe(null);
		}

		// Token: 0x04023290 RID: 144016
		protected TuningStandLineItem MusicItem;

		// Token: 0x04023291 RID: 144017
		protected TuningStandLineItem MusicItemPlay;

		// Token: 0x04023292 RID: 144018
		protected UiPanelBase GuideItem;

		// Token: 0x04023293 RID: 144019
		protected PopupCaptionItem CaptionItem;

		// Token: 0x04023294 RID: 144020
		protected ITuningStand Config;

		// Token: 0x04023295 RID: 144021
		protected bool IsTuning;

		// Token: 0x04023296 RID: 144022
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<TuningStandGridItem, TuningGridData> GridLayout;

		// Token: 0x04023297 RID: 144023
		protected Action FinishCb;

		// Token: 0x04023298 RID: 144024
		protected TimerHandle TooLongHandle;

		// Token: 0x04023299 RID: 144025
		protected LevelSequencePlayer FloroSequencer;

		// Token: 0x0402329A RID: 144026
		protected bool IsFloroTalking;

		// Token: 0x0402329B RID: 144027
		protected LevelSequencePlayer MainSequencer;

		// Token: 0x0402329C RID: 144028
		protected bool IsMainTalking;

		// Token: 0x0402329D RID: 144029
		protected TimerHandle BubbleTimer;

		// Token: 0x0402329E RID: 144030
		private int TooLongDelayCount;

		// Token: 0x0402329F RID: 144031
		protected LevelSequencePlayer LightButtonLeft;

		// Token: 0x040232A0 RID: 144032
		protected LevelSequencePlayer LightButtonRight;

		// Token: 0x040232A1 RID: 144033
		private TuningStandNodeTween RedTweener;

		// Token: 0x040232A2 RID: 144034
		private TuningStandNodeTween BlueTweener;

		// Token: 0x040232A3 RID: 144035
		private bool HasTweenerEnd;

		// Token: 0x040232A4 RID: 144036
		private bool IsGameClear;

		// Token: 0x0200CB3F RID: 52031
		[NullableContext(1)]
		[Nullable(0)]
		[RequiredMember]
		public class Params
		{
			// Token: 0x06051699 RID: 333465 RVA: 0x016167CA File Offset: 0x016149CA
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public Params()
			{
			}

			// Token: 0x0403D5F4 RID: 251380
			[RequiredMember]
			public ITuningStand Config;

			// Token: 0x0403D5F5 RID: 251381
			[RequiredMember]
			public Action Cb;
		}

		// Token: 0x0200CB40 RID: 52032
		[NullableContext(0)]
		public enum ETuningDefine
		{
			// Token: 0x0403D5F7 RID: 251383
			PanelMainUI,
			// Token: 0x0403D5F8 RID: 251384
			Caption,
			// Token: 0x0403D5F9 RID: 251385
			DigitalMazeLineItem,
			// Token: 0x0403D5FA RID: 251386
			PanelLeftDialogue,
			// Token: 0x0403D5FB RID: 251387
			TexLeftRole,
			// Token: 0x0403D5FC RID: 251388
			HeadTipsLeft,
			// Token: 0x0403D5FD RID: 251389
			TxtLeftDialogue,
			// Token: 0x0403D5FE RID: 251390
			PanelRightDialogue,
			// Token: 0x0403D5FF RID: 251391
			TexRightRole,
			// Token: 0x0403D600 RID: 251392
			HeadTipsRight,
			// Token: 0x0403D601 RID: 251393
			TxtRightDialogue,
			// Token: 0x0403D602 RID: 251394
			PanelLatticeGridList,
			// Token: 0x0403D603 RID: 251395
			TxtBottomTips,
			// Token: 0x0403D604 RID: 251396
			BtnReset,
			// Token: 0x0403D605 RID: 251397
			PanelMaskGuide,
			// Token: 0x0403D606 RID: 251398
			PanelPlayUI,
			// Token: 0x0403D607 RID: 251399
			DigitalMazeLineStaffPlayItem,
			// Token: 0x0403D608 RID: 251400
			PanelMainLine,
			// Token: 0x0403D609 RID: 251401
			EmptyItem,
			// Token: 0x0403D60A RID: 251402
			OpMaskItem,
			// Token: 0x0403D60B RID: 251403
			BtnMaskGuide,
			// Token: 0x0403D60C RID: 251404
			PanelFlyFxRed,
			// Token: 0x0403D60D RID: 251405
			PanelFlyFxBlue
		}
	}
}
